using Microsoft.EntityFrameworkCore;

namespace qfbackend1.Models
{
    public class QFJContext : DbContext
    {
        public QFJContext(DbContextOptions<QFJContext> options): base(options)
        {
        }
        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<Appt> Appts { get; set; }
    }
}
