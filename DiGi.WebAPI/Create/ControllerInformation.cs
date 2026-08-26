using DiGi.WebAPI.Classes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
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

            Type type = typeInfo.AsType();
            Assembly? assembly = type.Assembly;
            AssemblyName? assemblyName = assembly?.GetName();

            string? version = assemblyName?.Version?.ToString();
            string? informationalVersion = assembly?.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;

            string? routePrefix = type.GetCustomAttribute<RouteAttribute>()?.Template;

            int actionCount = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                .Count(methodInfo => !methodInfo.IsSpecialName && methodInfo.GetCustomAttribute<NonActionAttribute>() is null);

            return new ControllerInformation(typeInfo.Name, assemblyName?.Name, version, informationalVersion, actionCount, routePrefix);
        }
    }
}