using DiGi.WebAPI.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.WebAPI.Classes
{
    /// <summary>
    /// Holds route, action, and parameter contract metadata for a registered API endpoint.
    /// </summary>
    public class EndpointInformation : Core.Classes.SerializableObject, IWebAPISerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(ActionName))]
        private readonly string? actionName;

        [JsonInclude, JsonPropertyName(nameof(ControllerName))]
        private readonly string? controllerName;

        [JsonInclude, JsonPropertyName(nameof(HttpMethods))]
        private readonly IList<string>? httpMethods;

        [JsonInclude, JsonPropertyName(nameof(IsApiIgnored))]
        private readonly bool isApiIgnored;

        [JsonInclude, JsonPropertyName(nameof(Parameters))]
        private readonly IList<EndpointParameterInformation>? parameters;

        [JsonInclude, JsonPropertyName(nameof(ReturnTypeName))]
        private readonly string? returnTypeName;

        [JsonInclude, JsonPropertyName(nameof(RouteTemplate))]
        private readonly string? routeTemplate;

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointInformation"/> class.
        /// </summary>
        /// <param name="controllerName">The name of the declaring controller.</param>
        /// <param name="actionName">The name of the action method.</param>
        /// <param name="routeTemplate">The relative route template for the endpoint.</param>
        /// <param name="httpMethods">The supported HTTP verbs (e.g. GET, POST).</param>
        /// <param name="isApiIgnored">Whether the endpoint is hidden from API explorer / Swagger.</param>
        /// <param name="returnTypeName">The return type name of the endpoint.</param>
        /// <param name="parameters">The list of parameters accepted by the endpoint.</param>
        public EndpointInformation(string? controllerName, string? actionName, string? routeTemplate, IEnumerable<string>? httpMethods, bool isApiIgnored, string? returnTypeName, IEnumerable<EndpointParameterInformation>? parameters)
            : base()
        {
            this.controllerName = controllerName;
            this.actionName = actionName;
            this.routeTemplate = routeTemplate;
            this.httpMethods = httpMethods == null ? null : new List<string>(httpMethods);
            this.isApiIgnored = isApiIgnored;
            this.returnTypeName = returnTypeName;
            this.parameters = parameters == null ? null : new List<EndpointParameterInformation>(parameters);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointInformation"/> class by copying from another instance.
        /// </summary>
        /// <param name="endpointInformation">The <see cref="EndpointInformation"/> to copy from.</param>
        public EndpointInformation(EndpointInformation? endpointInformation)
            : base(endpointInformation)
        {
            if (endpointInformation is not null)
            {
                controllerName = endpointInformation.controllerName;
                actionName = endpointInformation.actionName;
                routeTemplate = endpointInformation.routeTemplate;
                httpMethods = endpointInformation.httpMethods == null ? null : new List<string>(endpointInformation.httpMethods);
                isApiIgnored = endpointInformation.isApiIgnored;
                returnTypeName = endpointInformation.returnTypeName;

                if (endpointInformation.parameters != null)
                {
                    parameters = [];
                    foreach (EndpointParameterInformation endpointParameterInformation in endpointInformation.parameters)
                    {
                        if (Core.Query.Clone(endpointParameterInformation) is EndpointParameterInformation parameter_Temp)
                        {
                            parameters.Add(parameter_Temp);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointInformation"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to deserialize from.</param>
        public EndpointInformation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the name of the action method.
        /// </summary>
        [JsonIgnore]
        public string? ActionName
        {
            get
            {
                return actionName;
            }
        }

        /// <summary>
        /// Gets the name of the declaring controller.
        /// </summary>
        [JsonIgnore]
        public string? ControllerName
        {
            get
            {
                return controllerName;
            }
        }

        /// <summary>
        /// Gets the supported HTTP verbs (e.g. GET, POST).
        /// </summary>
        [JsonIgnore]
        public IEnumerable<string>? HttpMethods
        {
            get
            {
                return httpMethods;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the endpoint is hidden from API explorer / Swagger.
        /// </summary>
        [JsonIgnore]
        public bool IsApiIgnored
        {
            get
            {
                return isApiIgnored;
            }
        }

        /// <summary>
        /// Gets the list of parameters accepted by the endpoint.
        /// </summary>
        [JsonIgnore]
        public IEnumerable<EndpointParameterInformation>? Parameters
        {
            get
            {
                return parameters;
            }
        }

        /// <summary>
        /// Gets the return type name of the endpoint.
        /// </summary>
        [JsonIgnore]
        public string? ReturnTypeName
        {
            get
            {
                return returnTypeName;
            }
        }

        /// <summary>
        /// Gets the relative route template for the endpoint.
        /// </summary>
        [JsonIgnore]
        public string? RouteTemplate
        {
            get
            {
                return routeTemplate;
            }
        }
    }
}
