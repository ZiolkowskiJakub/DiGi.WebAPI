using DiGi.Core.Interfaces;

namespace DiGi.WebAPI.Interfaces
{
    /// <summary>
    /// Defines the contract for WebAPI objects that support serialization.
    /// </summary>
    public interface IWebAPISerializableObject : IWebAPIObject, ISerializableObject
    {
    }
}