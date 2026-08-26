using DiGi.WebAPI.Classes;
using System;
using System.Diagnostics;

namespace DiGi.WebAPI
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a new <see cref="ServiceHealthInformation"/> instance reflecting current service status and uptime.
        /// </summary>
        /// <param name="status">The health status string, defaulting to "Healthy".</param>
        /// <param name="startTimeUtc">Optional process start time in UTC. If not provided, it is retrieved from the current process.</param>
        /// <returns>A new <see cref="ServiceHealthInformation"/> instance.</returns>
        public static ServiceHealthInformation ServiceHealthInformation(string status = "Healthy", DateTime? startTimeUtc = null)
        {
            DateTime serverTimeUtc = DateTime.UtcNow;
            DateTimeOffset serverTimeLocal = DateTimeOffset.Now;
            int processId = Environment.ProcessId;

            DateTime startTimeUtc_Resolved;
            if (startTimeUtc.HasValue)
            {
                startTimeUtc_Resolved = startTimeUtc.Value;
            }
            else
            {
                try
                {
                    using Process process = Process.GetCurrentProcess();
                    startTimeUtc_Resolved = process.StartTime.ToUniversalTime();
                }
                catch
                {
                    startTimeUtc_Resolved = serverTimeUtc;
                }
            }

            TimeSpan uptime = serverTimeUtc - startTimeUtc_Resolved;
            if (uptime < TimeSpan.Zero)
            {
                uptime = TimeSpan.Zero;
            }

            return new ServiceHealthInformation(status, serverTimeUtc, serverTimeLocal, uptime, processId);
        }
    }
}
