using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace LoginAndRegister
{
    public class EmailGeneration
    {
        public static void SendEmail(string recipientEmail, string ticket, string description)
        {
            try
            {
                ValidateEmail(recipientEmail);

                var client = ConfigureSmtpClient();

                var message = CreateEmailMessage(recipientEmail, ticket, description);

                client.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Email Error");
            }
        }

        private static void ValidateEmail(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
            }
            catch
            {
                throw new ArgumentException($"Invalid email format: {email}");
            }
        }

        private static SmtpClient ConfigureSmtpClient()
        {
            return new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("jfghithelp@gmail.com", "uelx gxcl cqzs find"),
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Timeout = 30000
            };
        }

        private static MailMessage CreateEmailMessage(string recipientEmail, string ticket, string description)
        {
            return new MailMessage
            {
                From = new MailAddress("jfghithelp@gmail.com"),
                Subject = $"Support Ticket - {ticket}",
                Body = $"Hello,\n\nHere is your support ticket:\n\nTicket: {ticket}\nDescription: {description}\n\nThanks for contacting us.",
                IsBodyHtml = false
            }.AddRecipient(recipientEmail);
        }
    }

    public static class MailMessageExtensions
    {
        public static MailMessage AddRecipient(this MailMessage message, string recipientEmail)
        {
            message.To.Add(recipientEmail);
            return message;
        }
    }
}
