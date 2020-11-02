using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace CarePartnersPortal
{
    public class Email
    {
        public string From { get; set; }
        public string To { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool BodyIsHTML { get; set; } = false;
        public string AttachmentPath { get; set; }

        public void Send()
        {
            using SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Host = "carepartners-ca.mail.protection.outlook.com";

            using (MailMessage mail = new MailMessage())
            {
                string[] separators = { ",", ";", ":" };
                mail.IsBodyHtml = BodyIsHTML;
                mail.From = new MailAddress(From);

                if (To != null)
                {
                    string[] toAddresses = To.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var address in toAddresses)
                    {
                        mail.To.Add(address);
                    };
                }

                if (CC != null)
                {
                    string[] ccAddresses = CC.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var address in ccAddresses)
                    {
                        mail.CC.Add(address);
                    };
                }

                if (BCC != null)
                {
                    string[] bccAddresses = BCC.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var address in bccAddresses)
                    {
                        mail.Bcc.Add(address);
                    };
                }
                if (AttachmentPath != null)
                {
                    mail.Attachments.Add(new Attachment(AttachmentPath));
                }

                mail.Subject = Subject;
                mail.Body = Body;
                client.Send(mail);
            }
        }
    }    
}
