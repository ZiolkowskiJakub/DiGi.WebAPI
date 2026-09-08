using DiGi.WebAPI.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Loader;

namespace DiGi.WebAPI
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a new <see cref="VersionInformation"/> instance containing host service, WebAPI framework, runtime, and loaded extension versions.
        /// <para>Extensions are the assemblies loaded from an <c>extensions/</c> directory. Their informational versions follow the same commit-hash rule as the host and framework: trimmed for unauthenticated callers, kept for authorized ones.</para>
        /// </summary>
        /// <param name="includeCommitHash">Whether the source control commit hash is kept on the informational versions. False trims everything from the '+' separator onwards, leaving the build stamp intact.</param>
        /// <param name="hostAssembly">Optional host assembly. If null, the entry assembly or executing assembly is used.</param>
        /// <param name="startTimeUtc">Optional process start time in UTC.</param>
        /// <param name="extensionAssemblies">Optional explicit list of extension assemblies. If null, the default assembly load context is filtered to assemblies loaded from an <c>extensions/</c> directory.</param>
        /// <returns>A new <see cref="VersionInformation"/> instance.</returns>
        public static VersionInformation VersionInformation(bool includeCommitHash = false, Assembly? hostAssembly = null, DateTime? startTimeUtc = null, IEnumerable<Assembly>? extensionAssemblies = null)
        {
            static bool IsExtension(Assembly assembly)
            {
                string? location = assembly.Location;
                if (string.IsNullOrWhiteSpace(location))
                {
                    return false;
                }

                return location.Contains(@"\extensions\", StringComparison.OrdinalIgnoreCase) ||
                       location.Contains("/extensions/", StringComparison.OrdinalIgnoreCase);
            }
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

            List<ExtensionVersionInformation> extensionVersionInformations = [];
            IEnumerable<Assembly> resolvedExtensionAssemblies = extensionAssemblies ?? AssemblyLoadContext.Default.Assemblies;
            foreach (Assembly assembly in resolvedExtensionAssemblies)
            {
                if (extensionAssemblies is null && !IsExtension(assembly))
                {
                    continue;
                }

                string? extensionName = assembly.GetName()?.Name;
                if (string.IsNullOrWhiteSpace(extensionName))
                {
                    continue;
                }

                string? extensionInformationalVersion = TrimCommitHash(assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion, includeCommitHash);
                extensionVersionInformations.Add(new ExtensionVersionInformation(extensionName, extensionInformationalVersion));
            }

            extensionVersionInformations.Sort((left, right) => string.Compare(left.Name ?? string.Empty, right.Name ?? string.Empty, StringComparison.OrdinalIgnoreCase));

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

            return new VersionInformation(serviceVersion, serviceInformationalVersion, webAPIVersion, webAPIInformationalVersion, runtimeVersion, frameworkDescription, resolvedStartTimeUtc, extensionVersionInformations);
        }
    }
}
