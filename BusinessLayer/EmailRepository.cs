using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace BusinessLayer
{
    public class EmailRepository:IEmailRepository
    {
       
        public void SendEmail(string FromAddress,string ToAddress,string Password,string Body,string Subject)
        {
            using SmtpClient email = new SmtpClient
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Host = "smtp.gmail.com",
                Port = 587,
                Credentials = new NetworkCredential(FromAddress, Password)
            };
            Console.WriteLine(FromAddress);
            string subject = "Good Morning";
            try
            {
                Console.WriteLine("sending email");
                email.Send(FromAddress, ToAddress, Subject, Body);
                Console.WriteLine("email sent");

            }catch(Exception ex)
            {
                throw;
            }
        }
    }
}
