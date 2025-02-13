using Entity.Identity.ViewModels;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;

namespace ServiceLayer.Helpers.Identity.EmailHelper
{
    // Interfaz para enviar correos electrónicos, incluyendo un método para enviar el enlace de restablecimiento de contraseña.
    public interface IEmailSendMethod
    {
        Task SendPasswordResetLinkWithToken(string passwordResetLink, string toEmail);
    }

    // Implementación concreta de la interfaz IEmailSendMethod que se encarga de enviar correos electrónicos con un enlace de restablecimiento de contraseña.
    public class EmailSendMethod : IEmailSendMethod
    {
        private readonly GmailInformationVM _emailInfo;

        // Constructor que recibe la configuración del correo electrónico desde opciones configuradas (IOptions).
        public EmailSendMethod(IOptions<GmailInformationVM> emailInfo)
        {
            // Se obtiene la configuración del correo de la inyección de dependencias.
            _emailInfo = emailInfo.Value;
        }

        // Método que envía un correo con el enlace de restablecimiento de contraseña.
        public async Task SendPasswordResetLinkWithToken(string passwordResetLink, string toEmail)
        {   
            var smtpClient = new SmtpClient(); // Se crea un cliente SMTP para enviar el correo.

            // Se configura el cliente SMTP.
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network; // Método de entrega mediante red.
            smtpClient.Host = _emailInfo.Host; // El servidor SMTP.
            smtpClient.Port = 587; // El puerto para la conexión segura.
            smtpClient.UseDefaultCredentials = false; // No usar credenciales predeterminadas.
            smtpClient.Credentials = new NetworkCredential(_emailInfo.Email, _emailInfo.Password); // Las credenciales de autenticación.
            smtpClient.EnableSsl = true; // Habilitar SSL para la seguridad.
       
            var mailMessage = new MailMessage // Se configura el mensaje de correo electrónico.
            {
                From = new MailAddress(_emailInfo.Email), // Dirección de correo de origen.
                Subject = "Password Reset Link | Sistema de Gestión de Grupos de Scouts (SGGS)", // Asunto del correo.
                Body = $@"<h1>PASSWORD RESET LINK</h1>
                      <h5>Click <a href='{passwordResetLink}'>HERE</a> to reset your password</h5>", // Cuerpo del correo en formato HTML.
                IsBodyHtml = true // Indica que el cuerpo del correo es HTML.
            };

            mailMessage.To.Add(toEmail); // Se agrega el destinatario del correo.
            await smtpClient.SendMailAsync(mailMessage); // Se envía el correo de forma asíncrona.
        }
    }
}
