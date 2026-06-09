using Swashbuckle.AspNetCore.SwaggerGen;

namespace DiGi.WebAPI.Interfaces
{
    /// <summary>
    /// Defines a filter that can be used to modify the generated Swagger document.
    /// </summary>
    public interface IWebAPIDocumentFilter : IDocumentFilter
    {
    }
}
