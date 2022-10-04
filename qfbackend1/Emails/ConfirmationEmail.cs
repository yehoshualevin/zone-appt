using qfbackend1.Models;
using System.Net;
using System.Net.Mail;

namespace qfbackend1.Emails
{
    public class ConfirmationEmail
    {
        public static void Send(Appt appt)
        {
           
                string fromEmail = "jlevin@snftrend.com";
                string password = "rcpcmvtebqbmnjdi";
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(fromEmail, password);

                MailMessage message = new MailMessage(fromEmail, appt.Email);
                message.Subject = "Service Request Created";
                message.Body = $"Thank you for your service request {appt.FirstName}. \nYour service is scheduled for {appt.ApptDay.ToLongDateString()}";

                client.Send(message);

        }
    }
}
