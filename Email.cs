using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MedicineReminderApp
{
    public class Email
    {
        private string SenderEmail = "ENTER_YOUR_EMAIL_HERE";
        private string AppPassword ="ENTER_YOUR_APP_PASSWORD_HERE";
        public void SendInventoryAlert(string receiver, int count)
        {
            string subject = "Health Guardian: Inventory Alert";
            string body = $"Stock Alert: You only have {count} doses left. Time to restock soon!!";

            SendEmail(receiver, subject, body);
        }
        public void SendPatientAlert(string receiver)
        {
            string subject = "Health Guardian: Missed Dose Warning";
            string body = "Warning: The patient has not confirmed taking the medicine dose on time.";

            SendEmail(receiver, subject, body);
        }
        public void SendEmail(string receiverEmail, string subject, string body)
        {
            try
            {

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false, 
                    Credentials = new NetworkCredential(SenderEmail, AppPassword)
                };


                smtpClient.Send(SenderEmail, receiverEmail, subject, body);
            }
            catch (Exception ex)
            {
                 throw new Exception("Email sending failed: " + ex.Message);
            }
        }
    }
}
