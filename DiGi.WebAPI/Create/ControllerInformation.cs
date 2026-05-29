using DiGi.WebAPI.Classes;
using System.Reflection;

namespace DiGi.WebAPI
{
    public static partial class Create
    {
        /// <summary>
        /// Extracts controller metadata from a <see cref="TypeInfo"/> instance.
        /// </summary>
        /// <param name="typeInfo">The type information of the controller.</param>
        /// <returns>A <see cref="ControllerInformation"/> instance with the controller metadata, or null if the type info is null.</returns>
        public static ControllerInformation? ControllerInformation(this TypeInfo? typeInfo)
        {
            if (typeInfo is null)
            {
                return null;
            }

            Assembly? assembly = typeInfo.AsType().Assembly;
            AssemblyName? assemblyName = assembly?.GetName();

            string? version = assemblyName?.Version?.ToString();

            string? informationalVersion = assembly?.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;

            return new ControllerInformation(typeInfo.Name, assemblyName?.Name, version, informationalVersion);
        }
    }
}