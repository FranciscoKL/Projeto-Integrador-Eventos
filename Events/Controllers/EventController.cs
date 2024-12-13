
using Events.Models.ViewModels;
using System.Diagnostics;
﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Events.Data;
using Events.Models;
using Events.Service;
using Humanizer.Localisation;
using Events.Service.Exceptions;
using System.Data;
using System.Reflection.Metadata.Ecma335;

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

        // GET: Event/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST Genres/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Event events)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            await _eventService.InsertAsync(events);
            return RedirectToAction(nameof(Index));
        }

        // GET Event/Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }
            var obj = await _eventService.FindByIdAsync(id.Value);
            if (obj is null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }
            return View(obj);
        }

        // POST Event/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _eventService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException ex)
            {
                return RedirectToAction(nameof(Error), new { message =ex.Message});
            }
        }

        // GET Event/Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }
            var obj = await _eventService.FindByIdAsync(id.Value);
            if (obj is null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }
            return View(obj);
        }

        // POST Event/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Event events)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id != events.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id's não condizentes" });
            }

            try
            {
                await _eventService.UpdateAsync(events);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException ex)
            {
                return RedirectToAction(nameof(Error), new { message = ex.Message });
            }
        }

        // GET: Event/Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id is null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }
            var obj = await _eventService.FindByIdAsync(id.Value);
            if (obj is null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }
            return View(obj);
        }
        public IActionResult Error(string? message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}