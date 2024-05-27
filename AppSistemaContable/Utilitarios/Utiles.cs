using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MessagingToolkit.QRCode.Codec;

namespace AppSistemaContable.Utilitarios
{
    class Utiles
    {
        public static String ToProperCase(String s)
        {
            if (s == null) return s;

            String[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 0) continue;

                Char firstChar = Char.ToUpper(words[i][0]);
                String rest = "";
                if (words[i].Length > 1)
                {
                    rest = words[i].Substring(1).ToLower();
                }
                words[i] = firstChar + rest;
            }
            return String.Join(" ", words);
        }

        /// <summary>
        /// Método que devuelve un la imagen generada
        /// El primer parámetro es la palabra(s) a convertir
        /// y el segundo parámetro es el nivel. Este parámetro  es muy importante
        /// </summary>
        /// <param name="input"></param>
        /// <param name="qrlevel"></param>
        /// <returns></returns>
        public static Image QuickResponseGenerador(string input, int qrlevel)
        {
            string toenc = input;
            MessagingToolkit.QRCode.Codec.QRCodeEncoder qe = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            qe.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qe.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L; // - Using LOW for more storage
            qe.QRCodeVersion = qrlevel;
            System.Drawing.Bitmap bm = qe.Encode(toenc);
            return bm;
        }

        //Ejemplo sin asignar
        public static Bitmap CreateBitmapImage(string sImageText)
        {

            Bitmap objBmpImage = new Bitmap(500, 500);

            int intWidth = 0;

            int intHeight = 0;


            // Create the Font object for the image text drawing.
            Font objFont = new Font("Arial", 20, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);

            // Create a graphics object to measure the text's width and height.
            Graphics objGraphics = Graphics.FromImage(objBmpImage);

            // This is where the bitmap size is determined.
            intWidth = (int)objGraphics.MeasureString(sImageText, objFont).Width;
            intHeight = (int)objGraphics.MeasureString(sImageText, objFont).Height;


            // Create the bmpImage again with the correct size for the text and font.
            objBmpImage = new Bitmap(objBmpImage, new Size(intWidth, intHeight));

            // Add the colors to the new bitmap.
            objGraphics = Graphics.FromImage(objBmpImage);

            // Set Background color

            objGraphics.Clear(Color.White);
            objGraphics.SmoothingMode = SmoothingMode.AntiAlias;

            objGraphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            objGraphics.DrawString(sImageText, objFont, new SolidBrush(Color.FromArgb(102, 102, 102)), 0, 0);
            objGraphics.Flush();

            return (objBmpImage);
        }

        public String mensajeCatch(Exception er)
        {
            StringBuilder msg = new StringBuilder();
            msg.AppendFormat("Message        {0}\n", er.Message);
            msg.AppendFormat("Source         {0}\n", er.Source);
            msg.AppendFormat("InnerException {0}\n", er.InnerException);
            msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
            msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
            return msg.ToString();
        }



        #region ValidarExepcionSQL

        public static string ValidarExepcionSQL(Exception exception)
        {

            string message = "";

            if (exception.InnerException != null)
            {
                message += exception.InnerException.Message;
                if (exception.InnerException.InnerException != null)
                {
                    message += exception.InnerException.InnerException.Message;
                }
            }
            else
            {
                message += exception.Message;
            }

            if (message.ToUpper().Contains("DUPLICATE ENTRY") || message.ToUpper().Contains("SAME PRIMARY KEY"))
            {
                return "El registro a insertar ya se encuentra en el sistema. " +
                        "Cambiar el o los códigos que desea guardar por otros que no existan en el sistema.";
            }
            else
            {
                if (message.ToUpper().Contains("CANNOT DELETE OR UPDATE A PARENT ROW"))
                {
                    return "El registro está siendo utilizado por otras funcionalidades del sistema. " +
                            "Para eliminar el registro primero se deben eliminar los registros asociados en los respectivos mantenimientos o modificar estos para que no se relacionen con este registro.";
                }
                else
                {
                    if (message.ToUpper().Contains("FOREIGN KEY"))
                    {
                        if (message.ToUpper().Contains("ADD"))
                        {
                            return "El registro a insertar contiene datos asociados que aún no están almacenados en el sistema. " + "\n" +
                                                "Para insertar el registro primero debe verificar los registros asociados, esto porque algún registro asociado no existe en el sistema.";
                        }
                        else
                        {
                            return "El registro está siendo utilizado por otras funcionalidades del sistema. " +
                                                "Para eliminar el registro primero se deben eliminar los registros asociados en los respectivos mantenimientos o modificar estos para que no se relacionen con este registro.";
                        }
                    }
                    else
                    {
                        return "Error: " + message;
                    }
                }
            }
        }

        #endregion

        #region CULTURE
        public static CultureInfo GetCulture()
        {
            CultureInfo Micultura = new CultureInfo("es-CR", false);
            Micultura.NumberFormat.CurrencySymbol = "₵";
            Micultura.NumberFormat.CurrencyDecimalDigits = 2;
            Micultura.NumberFormat.CurrencyDecimalSeparator = ".";
            Micultura.NumberFormat.CurrencyGroupSeparator = ",";
            int[] grupo = new int[] { 3, 3, 3 };
            Micultura.NumberFormat.CurrencyGroupSizes = grupo;
            Micultura.NumberFormat.NumberDecimalDigits = 2;
            Micultura.NumberFormat.NumberGroupSeparator = ",";
            Micultura.NumberFormat.NumberDecimalSeparator = ".";
            Micultura.NumberFormat.NumberGroupSizes = grupo;
            return Micultura;
        }

        public static CultureInfo GetCultureCaja()
        {
            CultureInfo Micultura = new CultureInfo("es-CR", false);
            Micultura.NumberFormat.CurrencySymbol = "₵";
            Micultura.NumberFormat.CurrencyDecimalDigits = 2;
            Micultura.NumberFormat.CurrencyDecimalSeparator = ".";
            Micultura.NumberFormat.CurrencyGroupSeparator = ",";
            int[] grupo = new int[] { 3, 3, 3 };
            Micultura.NumberFormat.CurrencyGroupSizes = grupo;
            Micultura.NumberFormat.NumberDecimalDigits = 2;
            //Micultura.NumberFormat.NumberGroupSeparator = ",";
            //Micultura.NumberFormat.NumberDecimalSeparator = ".";
            Micultura.NumberFormat.NumberGroupSizes = grupo;
            Micultura.DateTimeFormat.ShortTimePattern = "HH:mm:ss";
            Micultura.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
            Micultura.DateTimeFormat.FullDateTimePattern = "yyyy-MM-dd HH:mm:ss";
            Micultura.DateTimeFormat.TimeSeparator = ":";
            Micultura.DateTimeFormat.DateSeparator = "-";

            return Micultura;

        }
        #endregion

        #region Varios
        public static Stream GenerateStreamFromString(string s)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        /// <summary>
        /// genera un Stream a partir de un MemoryStream
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static Stream GenerateStreamFromMemoryStream(MemoryStream stream)
        {
            StreamWriter writer = new StreamWriter(stream);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        public static string GetCorreoPrincipal(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo))
            {
                return null;
            }
            else
            {
                string[] lista = correo.Split(';');
                if (lista.Length == 0)
                    return correo;
                else
                    return lista[0];

            }
        }

        /// <summary>
        /// Genera una contraseña de valores de a-z A-Z  0-0 !@#$%*_+-/
        /// </summary>
        /// <param name="longitud">Cantidad de digitos que va a tener la contraseña</param>
        /// <returns></returns>
        public static string GenerarContrasena(int longitud)
        {
            const string valido = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%*_+-/";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < longitud--)
            {
                res.Append(valido[rnd.Next(valido.Length)]);
            }
            return res.ToString();
        }

        /// <summary>
        /// verifica que existan los datos de la conexionn con hacienda
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        public static string GenerarCodigoVerificador(string pIdCliente, string pConsecutivo, string pIdTipoDocumento, string pImporte)
        {
            string valor = "";
            string cadenaSeguridad = "";
            byte[] HashValue;
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] MessageBytes = UE.GetBytes(pIdCliente + pConsecutivo + pIdTipoDocumento + pImporte);
            SHA256Managed SHhash = new SHA256Managed();
            HashValue = SHhash.ComputeHash(MessageBytes);
            foreach (byte b in HashValue)
            {
                cadenaSeguridad = cadenaSeguridad + b;
            }
            if (cadenaSeguridad.Length >= 8)
            {
                valor = cadenaSeguridad.Substring(0, 8).ToString();
            }
            else
            {
                valor = "";
            }
            return valor;
        }

        public static bool AccesoInternet()
        {
            try
            {
                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("fe.msasoft.net");
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        #endregion
    }
}
