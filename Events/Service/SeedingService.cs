using Events.Data;
using Events.Models;

namespace Events.Service
{
    public class SeedingService
    {
        private readonly EventContext _context;
        public SeedingService(EventContext context)
        {
            _context = context;
        }
        public async Task Seed()
        {
            if (_context.Events.Any())
            {
                return;
            }

            Event e1 = new Event(1, "Evolução Francesa", new DateTime(2024, 9, 11, 13, 15, 0), "Palácio de Versales", 2000, 2000);
            Event e2 = new Event(2, "Festa do juninho", new DateTime(2026, 3, 25, 17, 0, 0), "Casa do juninho", 20, 1);
            Event e3 = new Event(3, "Disney", new DateTime(2007, 7, 7, 7, 0, 0), "Disneylândia", 40000, 5000);
            Event e4 = new Event(4, "Festa do Pijama", new DateTime(2025, 12, 13, 23, 0, 0), "Casa do Carlos", 7, 20);
            Event e5 = new Event(5, "Gameplays", new DateTime(2025, 2, 15, 7, 0, 0), "LanHouse", 15, 0);

            await _context.Events.AddRangeAsync(
            e1, e2, e3, e4, e5);

            await _context.SaveChangesAsync();
        }
    }
}
