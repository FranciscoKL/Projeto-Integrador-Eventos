using Events.Models;
using Microsoft.EntityFrameworkCore;



namespace Events.Data
{
    public class EventContext : DbContext
    {
        public EventContext(DbContextOptions<EventContext> options) : base(options) 
        {
        }
        public DbSet<Event> Events { get; set; }
    }
}
