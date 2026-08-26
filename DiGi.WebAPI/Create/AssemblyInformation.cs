using DiGi.WebAPI.Classes;
using System.Reflection;

namespace DiGi.WebAPI
{
    public static partial class Create
    {
        /// <summary>
        /// Extracts assembly metadata from an <see cref="Assembly"/> instance.
        /// </summary>
        /// <param name="assembly">The assembly to extract metadata from.</param>
        /// <returns>A new <see cref="AssemblyInformation"/> instance, or null if the assembly is null.</returns>
        public static AssemblyInformation? AssemblyInformation(this Assembly? assembly)
        {
            if (assembly is null)
            {
                return null;
            }

            AssemblyName assemblyName = assembly.GetName();
            string? name = assemblyName.Name;
            string? fullName = assembly.FullName;
            string? version = assemblyName.Version?.ToString();
            string? informationalVersion = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
            bool isDynamic = assembly.IsDynamic;

            return new AssemblyInformation(name, fullName, version, informationalVersion, isDynamic);
        }
    }
}
