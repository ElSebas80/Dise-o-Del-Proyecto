using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Diseño.Datos.Logn
{
    public abstract class Email
    {
            private SmtpClient smClient;
            protected string EnviaMail { get; set; }
            protected string contra { get; set; }
            protected string host { get; set; }
            protected int port { get; set; }
            protected bool ssl { get; set; }

            protected void IniciarsmClient()
            {
                smClient = new SmtpClient();
                smClient.UseDefaultCredentials = false;
                smClient.Credentials = new NetworkCredential(EnviaMail, contra);// Correo de donde se envia el mensaje (correo y la clave)
                smClient.Host = host;
                smClient.Port = port;
                smClient.EnableSsl = ssl;
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            }
            public void Enviarmensaje(string Asunto, string Cuerpo, string Destino)
            {
                var mailMessage = new MailMessage();
                try
                {
                    mailMessage.To.Add(Destino);//A donde va
                    mailMessage.Subject = Asunto; // Asunto del mensaje
                    mailMessage.SubjectEncoding = Encoding.UTF8;// Acepte caracteres
                    mailMessage.From = new MailAddress(EnviaMail); // Desde donde enviamos el correo
                    mailMessage.Body = Cuerpo;//Cuerpo del mensaje
                    mailMessage.Priority = MailPriority.Normal; // Prioridad normal

                    smClient.Send(mailMessage);
                }
                catch (Exception)
                {

                }
                finally
                {
                    mailMessage.Dispose();
                    smClient.Dispose();
                }
            }
    }
    
}
