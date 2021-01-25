using Microsoft.AspNetCore.Mvc;

namespace NotesFE.Controllers
{
    public class ErrorController : Controller
    {
        [Route("404")]
        public IActionResult BoardNotFound()
        {
            Response.StatusCode = 404;
            return View();
        }
        
        [Route("403")]
        public IActionResult BoardForbidden()
        {
            Response.StatusCode = 403;
            return View();
        }
    }
}