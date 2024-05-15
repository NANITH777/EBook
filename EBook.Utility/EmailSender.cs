using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBook.Utility
{
    public class EmailSender : IEmailSender
    {
        public string SendGridSecret { get; set; }
        public EmailSender(IConfiguration _config) 
        {
            SendGridSecret = _config.GetValue<string>("SendGrid:SecretKey");
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // Logic to send emails

            var client = new SendGridClient(SendGridSecret);
            var from = new EmailAddress("b201200576@sakarya.edu.tr", "EBook");
            var to = new EmailAddress(email);
            var message = MailHelper.CreateSingleEmail(from, to, subject,"",htmlMessage);

            return client.SendEmailAsync(message);
        }
    }
}
