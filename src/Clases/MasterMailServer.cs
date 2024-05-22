using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace pet4sitter
{
    public abstract class MasterMailServer
    {
        SmtpClient smtpClient;
        protected string senderMail;
        protected string password;
        protected string host;
        protected int port;
        protected bool ssl;

        protected void initializeSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail,password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }

        public void sendMail(string subject,string body,string recipientMail)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(senderMail);
                mailMessage.To.Add(recipientMail);
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex){
                // Registra la excepción en la consola o en un archivo de registro
                Console.WriteLine("Error al enviar el correo electrónico: " + ex.Message);

                // También puedes mostrar un mensaje de error al usuario
                MessageBox.Show("Se produjo un error al enviar el correo electrónico. Por favor, inténtalo de nuevo más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mailMessage.Dispose();
                smtpClient.Dispose();
            }
        }
    }
}
