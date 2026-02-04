using DiGi.WebAPI.Classes;
using System.Reflection;

namespace DiGi.WebAPI
{
    public static partial class Create
    {
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