using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace DiGi.WebAPI.Classes
{
    /// <summary>
    /// Tracks revoked JWT identifiers (jti claims) together with the expiration of the tokens that carry them,
    /// enabling server-side session termination for otherwise stateless tokens.
    /// <para>Entries live at most as long as the token they revoke: expired entries are dropped by a lazy sweep
    /// once the store grows past <see cref="SweepThreshold"/> entries, and are never reported as revoked by
    /// <see cref="IsRevoked(string?)"/> after their token has expired.</para>
    /// </summary>
    public sealed class TokenRevocationStore
    {
        /// <summary>
        /// The number of stored revocations that, once exceeded, triggers a sweep of expired entries on the next <see cref="Revoke(string?, DateTimeOffset)"/>.
        /// </summary>
        public const int SweepThreshold = 1024;

        /// <summary>
        /// Stores the expiration of each revoked token, keyed by its JWT identifier (jti claim).
        /// </summary>
        private readonly ConcurrentDictionary<string, DateTimeOffset> revocationExpiries = new();

        /// <summary>
        /// Gets the number of revocations currently stored, including any not yet swept expired entries.
        /// </summary>
        public int Count
        {
            get
            {
                return revocationExpiries.Count;
            }
        }

        /// <summary>
        /// Revokes the token carrying the given JWT identifier (jti claim) until the token expires naturally.
        /// <para>Calling this for an already revoked identifier is a no-op that keeps the original entry. A null or
        /// whitespace identifier is ignored: a token without a jti claim cannot be represented in the store.</para>
        /// </summary>
        /// <param name="jti">The JWT identifier (jti claim) of the token to revoke.</param>
        /// <param name="expiresAt">The expiration of the revoked token; the entry is irrelevant and removable after this instant.</param>
        public void Revoke(string? jti, DateTimeOffset expiresAt)
        {
            if (string.IsNullOrWhiteSpace(jti))
            {
                return;
            }

            revocationExpiries[jti] = expiresAt;

            if (Count > SweepThreshold)
            {
                SweepExpired();
            }
        }

        /// <summary>
        /// Determines whether the token carrying the given JWT identifier (jti claim) has been revoked and has not yet expired.
        /// <para>A null or whitespace identifier returns false: a token without a jti claim cannot be revoked, and an
        /// entry whose token has already expired is not reported as revoked, because lifetime validation rejects such a token regardless.</para>
        /// </summary>
        /// <param name="jti">The JWT identifier (jti claim) to check.</param>
        /// <returns>true if the identifier is revoked and the revoked token has not yet expired; otherwise, false.</returns>
        public bool IsRevoked(string? jti)
        {
            if (string.IsNullOrWhiteSpace(jti))
            {
                return false;
            }

            if (revocationExpiries.TryGetValue(jti, out DateTimeOffset expiresAt))
            {
                if (expiresAt <= DateTimeOffset.UtcNow)
                {
                    revocationExpiries.TryRemove(jti, out _);
                    return false;
                }

                return true;
            }

            return false;
        }

        /// <summary>
        /// Removes every stored entry whose token has already expired, bounding the memory of the store by the token lifetime.
        /// </summary>
        private void SweepExpired()
        {
            DateTimeOffset utcNow = DateTimeOffset.UtcNow;

            List<string> jtis_Expired = [];
            foreach (KeyValuePair<string, DateTimeOffset> keyValuePair in revocationExpiries)
            {
                if (keyValuePair.Value <= utcNow)
                {
                    jtis_Expired.Add(keyValuePair.Key);
                }
            }

            foreach (string jti_Expired in jtis_Expired)
            {
                revocationExpiries.TryRemove(jti_Expired, out _);
            }
        }
    }
}
