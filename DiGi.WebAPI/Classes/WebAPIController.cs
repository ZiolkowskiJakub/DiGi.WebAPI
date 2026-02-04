using DiGi.WebAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DiGi.WebAPI.Classes
{
    public abstract class WebAPIController : ControllerBase, IWebAPIController
    {
    }
}