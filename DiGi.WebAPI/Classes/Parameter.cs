using DiGi.Core.Classes;
using System.Text.Json.Nodes;

namespace DiGi.WebAPI.Classes
{
    /// <summary>
    /// Abstract class for input parameters for endpoint.
    /// </summary>
    public abstract class Parameter : SerializableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Parameter"/> class by copying another instance of the same type.
        /// </summary>
        /// <param name="parameter">The <see cref="Parameter"/> instance to copy from.</param>
        public Parameter(Parameter parameter)
            : base(parameter)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Parameter"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> that contains the initialization data.</param>
        public Parameter(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Parameter"/> class.
        /// </summary>
        public Parameter()
            : base()
        {

        }
    }
}
