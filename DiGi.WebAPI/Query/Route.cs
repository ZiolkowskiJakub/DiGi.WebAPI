using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using System;
using System.Reflection;

namespace DiGi.WebAPI
{
    public static partial class Query
    {
        public static string? Route<TControllerBase>() where TControllerBase : ControllerBase
        {
            Type type = typeof(TControllerBase);
            RouteAttribute? routeAttribute = type.GetCustomAttribute<RouteAttribute>();

            if (routeAttribute is null)
            {
                return null;
            }

            string result = routeAttribute.Template;

            // Handle the [controller] token
            if (result.Contains("[controller]"))
            {
                string controllerName = type.Name.EndsWith("Controller") ? type.Name[..^"Controller".Length] : type.Name;

                result = result.Replace("[controller]", controllerName.ToLowerInvariant());
            }

            return result;
        }

        public static string? Route<TControllerBase>(string methodName) where TControllerBase : ControllerBase
        {
            Type controllerType = typeof(TControllerBase);

            // 1. Get the method by name
            MethodInfo? methodInfo = controllerType.GetMethod(methodName);
            if (methodInfo is null)
            {
                return string.Empty;
            }

            // 2. Look for attributes that derive from HttpMethodAttribute (HttpPost, HttpGet, etc.)
            // or the [Route] attribute on the method itself
            HttpMethodAttribute? httpMethodAttribute = methodInfo.GetCustomAttribute<HttpMethodAttribute>();
            if (httpMethodAttribute is not null && !string.IsNullOrWhiteSpace(httpMethodAttribute.Template))
            {
                return httpMethodAttribute.Template;
            }

            RouteAttribute? routeAttribute = methodInfo.GetCustomAttribute<RouteAttribute>();
            if (routeAttribute is not null && !string.IsNullOrWhiteSpace(routeAttribute.Template))
            {
                return routeAttribute.Template;
            }

            return string.Empty;
        }
    }
}