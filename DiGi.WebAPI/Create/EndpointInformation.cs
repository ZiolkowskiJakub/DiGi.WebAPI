using DiGi.WebAPI.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DiGi.WebAPI
{
    public static partial class Create
    {
        /// <summary>
        /// Extracts endpoint metadata from an <see cref="ActionDescriptor"/> instance.
        /// </summary>
        /// <param name="actionDescriptor">The action descriptor to extract metadata from.</param>
        /// <returns>A new <see cref="EndpointInformation"/> instance, or null if the action descriptor is null.</returns>
        public static EndpointInformation? EndpointInformation(this ActionDescriptor? actionDescriptor)
        {
            if (actionDescriptor is null)
            {
                return null;
            }

            string? controllerName = null;
            string? actionName = null;
            string? returnTypeName = null;
            bool isApiIgnored = false;

            if (actionDescriptor is ControllerActionDescriptor controllerActionDescriptor)
            {
                controllerName = controllerActionDescriptor.ControllerName;
                actionName = controllerActionDescriptor.ActionName;
                returnTypeName = controllerActionDescriptor.MethodInfo.ReturnType.Name;

                ApiExplorerSettingsAttribute? methodApiExplorer = controllerActionDescriptor.MethodInfo.GetCustomAttribute<ApiExplorerSettingsAttribute>();
                ApiExplorerSettingsAttribute? controllerApiExplorer = controllerActionDescriptor.ControllerTypeInfo.GetCustomAttribute<ApiExplorerSettingsAttribute>();

                if (methodApiExplorer is not null)
                {
                    isApiIgnored = methodApiExplorer.IgnoreApi;
                }
                else if (controllerApiExplorer is not null)
                {
                    isApiIgnored = controllerApiExplorer.IgnoreApi;
                }
            }
            else
            {
                if (actionDescriptor.RouteValues.TryGetValue("controller", out string? routeController))
                {
                    controllerName = routeController;
                }

                if (actionDescriptor.RouteValues.TryGetValue("action", out string? routeAction))
                {
                    actionName = routeAction;
                }

                ApiExplorerSettingsAttribute? endpointApiExplorer = actionDescriptor.EndpointMetadata?.OfType<ApiExplorerSettingsAttribute>().FirstOrDefault();
                if (endpointApiExplorer is not null)
                {
                    isApiIgnored = endpointApiExplorer.IgnoreApi;
                }
            }

            string? routeTemplate = actionDescriptor.AttributeRouteInfo?.Template;

            List<string> httpMethods = [];
            HttpMethodActionConstraint? httpMethodActionConstraint = actionDescriptor.ActionConstraints?.OfType<HttpMethodActionConstraint>().FirstOrDefault();
            if (httpMethodActionConstraint is not null && httpMethodActionConstraint.HttpMethods is not null)
            {
                httpMethods.AddRange(httpMethodActionConstraint.HttpMethods);
            }
            else
            {
                IHttpMethodMetadata? httpMethodMetadata = actionDescriptor.EndpointMetadata?.OfType<IHttpMethodMetadata>().FirstOrDefault();
                if (httpMethodMetadata is not null && httpMethodMetadata.HttpMethods is not null)
                {
                    httpMethods.AddRange(httpMethodMetadata.HttpMethods);
                }
            }

            List<EndpointParameterInformation> endpointParameterInformations = [];
            if (actionDescriptor.Parameters is not null)
            {
                foreach (ParameterDescriptor parameterDescriptor in actionDescriptor.Parameters)
                {
                    EndpointParameterInformation? endpointParameterInformation = Create.EndpointParameterInformation(parameterDescriptor);
                    if (endpointParameterInformation is not null)
                    {
                        endpointParameterInformations.Add(endpointParameterInformation);
                    }
                }
            }

            return new EndpointInformation(controllerName, actionName, routeTemplate, httpMethods, isApiIgnored, returnTypeName, endpointParameterInformations);
        }
    }
}
