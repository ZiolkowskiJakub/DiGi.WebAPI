using DiGi.WebAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DiGi.WebAPI.Classes
{
    /// <summary>
    /// Serves as the base class for all WebAPI controllers, providing common MVC and API functionality.
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Produces("application/json")]
    public abstract class WebAPIController : ControllerBase, IWebAPIController
    {
    }
}