
using Events.Models.ViewModels;
using System.Diagnostics;
﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Events.Data;
using Events.Models;
using Events.Service;
using Humanizer.Localisation;

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
            List<Event> events = await _eventService.FindAllAsync();
            return View(events);
        }


        //parte tirada do home controller - Tela de erro
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}