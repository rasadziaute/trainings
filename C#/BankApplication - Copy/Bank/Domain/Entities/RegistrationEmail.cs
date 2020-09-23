using Bank.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Bank.Domain.Entities
{
    public static class RegistrationEmail
    {
        public static void SendRegistrationEmail(string email)
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                SmtpClient smptClient = new SmtpClient();
                mailMessage.From = new MailAddress("support@gmail.com");
                mailMessage.To.Add(new MailAddress(email));
                mailMessage.Subject = "Bank Application";
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = "Registration completed!";
                smptClient.Port = 587;
                smptClient.Host = "smtp.gmail.com";
                smptClient.EnableSsl = true;
                smptClient.UseDefaultCredentials = false;
                smptClient.Credentials = new NetworkCredential("support@gmail.com", "password");
                smptClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smptClient.Send(mailMessage);
            }

            catch (Exception e)
            {
                throw new EmailException("Email was not sent with an error " + e);
                
            }
        }
    }
}
