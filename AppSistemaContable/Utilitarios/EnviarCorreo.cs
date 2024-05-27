using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSistemaContable.Utilitarios
{
    class EnviarCorreo
    {
        public String CuentaCorreoElectronico = "utnpruebaisw711@gmail.com";//Revisar
        public String ContrasenaGeneradaGmail = "fhplwjoogyjbpftd";

        public EnviarCorreo()
        {
        }

        public void enviarCorreoGmail(string body, string receptor, string asunto, string adjunto)
        {
            MailMessage mensaje = new MailMessage();
            mensaje.IsBodyHtml = true;
            mensaje.Subject = asunto;
            mensaje.Body = body;
            mensaje.From = new MailAddress(CuentaCorreoElectronico);
            mensaje.To.Add(receptor);  //Correo del destinatario
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(CuentaCorreoElectronico, ContrasenaGeneradaGmail);
            smtp.EnableSsl = true;
            if (adjunto != null && !adjunto.Equals(""))
            {
                Attachment attachment = new Attachment(adjunto);
                mensaje.Attachments.Add(attachment);
            }
            smtp.Send(mensaje);
            MessageBox.Show("Correo enviado exitosamente", "Enviar Correo", MessageBoxButtons.OK, MessageBoxIcon.Information);//Muestra mensaje
        }

    }
}
