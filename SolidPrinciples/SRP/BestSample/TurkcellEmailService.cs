using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP.BestSample
{
    public interface IEmailService
    {
        void SendEmail();
    }


    public class VodafoneEmailService: IEmailService
    {
        public void SendEmail()
        {
           
        }
    }

    public  class TurkcellEmailService: IEmailService
    {
        public void SendEmail()
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("email", "password"),
                EnableSsl = true,
            };

            smtpClient.Send("email", "recipient", "subject", "body");
        }
    }
}
