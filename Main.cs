using System;
using Microsoft.VisualBasic;
using System.Net.Mail;

namespace myClass
{
    
    class SendEmail
    {
        static void Main(string[] args)
        {
            MailMessage message = new MailMessage();
            message.To.Add("joaquin77j@gmail.com");     // para quien está dirigido
            message.Subject = "Asunto del mensaje";
            mensaje.SubjectEncoding = System.Text.Encoding.UTF8;
            message.Body = "Contenido o cuerpo del mensaje";
            mensaje.BodyEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;
            mensaje.From = System.Net.Mail.MailAddress(""); // correo desde el cual se envia el mensaje

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            // correo y contraseña del emisor
            cliente.Credentials = new System.Net.Network.Credential("correo", "password");

            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.UseDefaultCredentials = false;
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";    // or: smtp.domian.com

            // Ejecución y enviar mensaje:
            try
            {
                cliente.Send(mensaje);  // enviamos el mensaje
            }
            catch (System.Exception)
            {
                MessageBox.Show("Error al enviar Mensaje");
            }

        }
    }

}