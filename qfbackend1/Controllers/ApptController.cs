using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using qfbackend1.Emails;
using qfbackend1.Models;

namespace qfbackend1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApptController : ControllerBase
    {
        private readonly QFJContext _context;

        public ApptController(QFJContext context)
        {
            _context = context;
        }

        [HttpPost]
        public void PostAppt(Appt appt)
        {
            _context.Appts.Add(appt);
            _context.SaveChanges();
            ConfirmationEmail.Send(appt);
        }

       
    }
}
