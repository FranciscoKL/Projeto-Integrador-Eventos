using Events.Models;
using Events.Data;
using Microsoft.EntityFrameworkCore;
using Events.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Humanizer.Localisation;
using Events.Service.Exceptions;

namespace Events.Service
{
    public class EventService
    {
        private readonly EventContext _context;
        public EventService(EventContext context)
        {
            _context = context;
        }

        public async Task<List<Event>> FindAllAsync()
        {
           return await _context.Events.ToListAsync();
        }

        // POST: Event/Create
        public async Task InsertAsync(Event events)
        {
            _context.Add(events);
            await _context.SaveChangesAsync();
        }

        // POST: Event/Delete
        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Events.FindAsync(id);
                _context.Events.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new IntegrityException(ex.Message);
            }
        }
        public async Task<Event?> FindByIdAsync(int id)
        {
            return await _context
                .Events
                .FirstOrDefaultAsync(x => x.Id == id);
        }
        // POST: Event/Edit
        public async Task UpdateAsync(Event events)
        {
            bool hasAny = await _context.Events.AnyAsync(x => x.Id == events.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id não encontrado");
            }
            try
            {
                _context.Update(events);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new DbConcurrencyException(ex.Message);
            }
        }
    }
}
