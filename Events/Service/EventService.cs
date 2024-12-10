using Events.Models;
using Events.Data;
using Microsoft.EntityFrameworkCore;

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
    }
}
