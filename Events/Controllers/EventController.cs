using Events.Models.ViewModels;
using System.Diagnostics;
﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        //parte tirada do home controller - Tela de erro
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}