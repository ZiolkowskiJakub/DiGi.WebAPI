using DiGi.WebAPI.Classes;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace DiGi.WebAPI
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a new <see cref="VersionInformation"/> instance containing host service, WebAPI framework, and runtime versions.
        /// </summary>
        /// <param name="includeCommitHash">Whether the source control commit hash is kept on the informational versions. False trims everything from the '+' separator onwards, leaving the build stamp intact.</param>
        /// <param name="hostAssembly">Optional host assembly. If null, the entry assembly or executing assembly is used.</param>
        /// <param name="startTimeUtc">Optional process start time in UTC.</param>
        /// <returns>A new <see cref="VersionInformation"/> instance.</returns>
        public static VersionInformation VersionInformation(bool includeCommitHash = false, Assembly? hostAssembly = null, DateTime? startTimeUtc = null)
        {
            Assembly? entryAssembly = hostAssembly ?? Assembly.GetEntryAssembly() ?? Assembly.GetExecutingAssembly();
            Assembly webAPIAssembly = typeof(Create).Assembly;

            string? serviceVersion = entryAssembly?.GetName()?.Version?.ToString();
            string? serviceInformationalVersion = TrimCommitHash(entryAssembly?.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion, includeCommitHash);

            string? webAPIVersion = webAPIAssembly?.GetName()?.Version?.ToString();
            string? webAPIInformationalVersion = TrimCommitHash(webAPIAssembly?.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion, includeCommitHash);

            static string? TrimCommitHash(string? informationalVersion, bool keep)
            {
                if (keep || string.IsNullOrWhiteSpace(informationalVersion))
                {
                    return informationalVersion;
                }

                int index = informationalVersion.IndexOf('+');

                return index == -1 ? informationalVersion : informationalVersion.Substring(0, index);
            }

            string runtimeVersion = Environment.Version.ToString();
            string frameworkDescription = RuntimeInformation.FrameworkDescription;

            DateTime? resolvedStartTimeUtc = startTimeUtc;
            if (!resolvedStartTimeUtc.HasValue)
            {
                try
                {
                    using Process process = Process.GetCurrentProcess();
                    resolvedStartTimeUtc = process.StartTime.ToUniversalTime();
                }
                catch
                {
                    resolvedStartTimeUtc = null;
                }
            }

            return new VersionInformation(serviceVersion, serviceInformationalVersion, webAPIVersion, webAPIInformationalVersion, runtimeVersion, frameworkDescription, resolvedStartTimeUtc);
        }
    }
}
