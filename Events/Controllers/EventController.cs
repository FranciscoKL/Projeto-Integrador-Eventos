using Microsoft.AspNetCore.Mvc;
using Events.Data;
using Events.Models;
using Events.Service;

namespace Events.Controllers
{
    public class EventController : Controller
    {
        private readonly EventService _eventService;
        public EventController(EventService service)
        {
            _eventService = service;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _eventService.FindAllAsync());
        }
    }
}
