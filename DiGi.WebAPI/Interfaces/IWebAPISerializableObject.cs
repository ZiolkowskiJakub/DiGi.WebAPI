using DiGi.Core.Interfaces;

namespace DiGi.WebAPI.Interfaces
{
    /// <summary>
    /// Defines the contract for WebAPI objects that support GUID identification and serialization.
    /// </summary>
    public interface IWebAPIGuidObject : IGuidObject, IWebAPISerializableObject
    {
    }
}