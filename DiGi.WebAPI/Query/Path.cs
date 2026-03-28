using Microsoft.AspNetCore.Mvc;

namespace DiGi.WebAPI
{
    public static partial class Query
    {
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