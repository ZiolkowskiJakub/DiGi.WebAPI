using DiGi.Core.Classes;
using System.Text.Json.Nodes;

namespace DiGi.WebAPI.Classes
{
    /// <summary>
    /// Abstract class for input parameters for endpoint.
    /// </summary>
    public abstract class Parameter : SerializableObject
    {
        public Parameter(Parameter parameter)
            : base(parameter)
        {

        }

        public Parameter(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Parameter()
            : base()
        {

        }
    }
}