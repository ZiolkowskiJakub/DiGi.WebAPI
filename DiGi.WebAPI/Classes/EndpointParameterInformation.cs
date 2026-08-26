using DiGi.WebAPI.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.WebAPI.Classes
{
    /// <summary>
    /// Holds metadata about an action method parameter.
    /// </summary>
    public class EndpointParameterInformation : Core.Classes.SerializableObject, IWebAPISerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(HasDefaultValue))]
        private readonly bool hasDefaultValue;

        [JsonInclude, JsonPropertyName(nameof(IsNullable))]
        private readonly bool isNullable;

        [JsonInclude, JsonPropertyName(nameof(Name))]
        private readonly string? name;

        [JsonInclude, JsonPropertyName(nameof(Source))]
        private readonly string? source;

        [JsonInclude, JsonPropertyName(nameof(TypeName))]
        private readonly string? typeName;

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointParameterInformation"/> class.
        /// </summary>
        /// <param name="name">The parameter name.</param>
        /// <param name="source">The parameter binding source (e.g., "Query", "Body", "Path").</param>
        /// <param name="typeName">The C# type name of the parameter.</param>
        /// <param name="isNullable">Whether the parameter type is nullable.</param>
        /// <param name="hasDefaultValue">Whether the parameter has a default value.</param>
        public EndpointParameterInformation(string? name, string? source, string? typeName, bool isNullable, bool hasDefaultValue)
            : base()
        {
            this.name = name;
            this.source = source;
            this.typeName = typeName;
            this.isNullable = isNullable;
            this.hasDefaultValue = hasDefaultValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointParameterInformation"/> class by copying from another instance.
        /// </summary>
        /// <param name="endpointParameterInformation">The <see cref="EndpointParameterInformation"/> to copy from.</param>
        public EndpointParameterInformation(EndpointParameterInformation? endpointParameterInformation)
            : base(endpointParameterInformation)
        {
            if (endpointParameterInformation is not null)
            {
                name = endpointParameterInformation.name;
                source = endpointParameterInformation.source;
                typeName = endpointParameterInformation.typeName;
                isNullable = endpointParameterInformation.isNullable;
                hasDefaultValue = endpointParameterInformation.hasDefaultValue;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointParameterInformation"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to deserialize from.</param>
        public EndpointParameterInformation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets a value indicating whether the parameter has a default value.
        /// </summary>
        [JsonIgnore]
        public bool HasDefaultValue
        {
            get
            {
                return hasDefaultValue;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the parameter type is nullable.
        /// </summary>
        [JsonIgnore]
        public bool IsNullable
        {
            get
            {
                return isNullable;
            }
        }

        /// <summary>
        /// Gets the parameter name.
        /// </summary>
        [JsonIgnore]
        public string? Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Gets the parameter binding source (e.g., "Query", "Body", "Path").
        /// </summary>
        [JsonIgnore]
        public string? Source
        {
            get
            {
                return source;
            }
        }

        /// <summary>
        /// Gets the C# type name of the parameter.
        /// </summary>
        [JsonIgnore]
        public string? TypeName
        {
            get
            {
                return typeName;
            }
        }
    }
}
