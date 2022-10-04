namespace qfbackend1.Models
{
    public class Appt
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }
        public DateTime ApptDay { get; set; }
    }
}
