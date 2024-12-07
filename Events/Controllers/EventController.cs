using Microsoft.AspNetCore.Mvc;

namespace Events.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
