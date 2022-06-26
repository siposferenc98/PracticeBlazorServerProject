using Microsoft.EntityFrameworkCore;

namespace PracticeBlazorServerProject.Models
{
    public class EventsBoxDbContext : DbContext
    {
        public EventsBoxDbContext(DbContextOptions<EventsBoxDbContext> options) : base(options)
        {

        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Card> Cards { get; set; }
    }
}
