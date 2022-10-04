namespace qfbackend1.Models
{
    public class TimeSlot
    {
        public int Id { get; set; }
        public DateTime Slot { get; set; }
        public int CustomerId { get; set; }
    }
}
