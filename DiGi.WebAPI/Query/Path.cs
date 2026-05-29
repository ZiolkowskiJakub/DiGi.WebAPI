using Microsoft.AspNetCore.Mvc;

namespace DiGi.WebAPI
{
    public static partial class Query
    {
        /// <summary>
        /// Combines the controller route and method route into a full path.
        /// </summary>
        /// <typeparam name="TControllerBase">The type of the controller base.</typeparam>
        /// <param name="methodName">The name of the method to include in the path.</param>
        /// <returns>The combined route path, or null if the controller route is not available.</returns>
        public static string? Path<TControllerBase>(string? methodName) where TControllerBase : ControllerBase
        {
            string? controllerRoute = Route<TControllerBase>();
            if (string.IsNullOrWhiteSpace(controllerRoute))
            {
                return null;
            }

            if (string.IsNullOrWhiteSpace(methodName))
            {
                return controllerRoute;
            }

            string? methodRoute = Route<TControllerBase>(methodName);
            if (string.IsNullOrWhiteSpace(methodRoute))
            {
                return controllerRoute;
            }

            // Combine ensuring there is a slash between them, but not double
            return $"{controllerRoute.TrimEnd('/')}/{methodRoute.TrimStart('/')}";
        }
    }
}