using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
 
namespace NotesFE.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return Content(User.Identity.Name);
        }
    }
}