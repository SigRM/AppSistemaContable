using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSistemaContable.Utilitarios
{
    class LeerDatos
    {
        #region Methods
        // Numero: parametro control
        public static bool Es_Numero(Control miTextBox)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            return regex.IsMatch(miTextBox.Text);
        }
        // Numero: parametro string
        public static bool Es_Numero(string miTextBox)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            return regex.IsMatch(miTextBox);
        }
        // Cadena: parametro control
        public static bool Es_Cadena(Control miTextBox)
        {
            Regex regex = new Regex(@"^[^ ][a-zA-Z ]+[^ ]$");
            return regex.IsMatch(miTextBox.Text);
        }
        // Cadena: parametro string
        public static bool Es_Cadena(string pValor)
        {
            Regex regex = new Regex(@"^[^ ][a-zA-Z ]+[^ ]$");
            return regex.IsMatch(pValor);
        }
        // Telefono
        public static bool Es_Telefono(Control miTextBox)
        {
            Regex regex = new Regex(@"^([0-9]{3})[-. ]?([0-9]{4})$");
            return regex.IsMatch(miTextBox.Text);
        }
        // Decimal: parametro control
        public static bool Es_Decimal(Control miTextBox)
        {
            Regex regex = new Regex(@"^[0-9]{1,9}([\.\,][0-9]{1,3})?$");
            return regex.IsMatch(miTextBox.Text);
        }
        // Decimal: parametro string
        public static bool Es_Decimal(string pValor)
        {
            Regex regex = new Regex(@"^[0-9]{1,9}([\.\,][0-9]{1,3})?$");
            return regex.IsMatch(pValor);
        }
        // URL                                       
        public static bool Es_Url(Control miTextBox)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9\-\.]+\.(com|org|net|mil|edu|COM|ORG|NET|MIL|EDU)$");
            return regex.IsMatch(miTextBox.Text);
        }
        // Email
        public static bool Es_Email(Control miTextBox)
        {
            Regex regex = new Regex(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$");

            // Resultado: 
            //       Valid: david.jones@proseware.com 
            //       Valid: d.j@server1.proseware.com 
            //       Valid: jones@ms1.proseware.com 
            //       Invalid: j.@server1.proseware.com 
            //       Invalid: j@proseware.com9 
            //       Valid: js#internal@proseware.com 
            //       Valid: j_9@[129.126.118.1] 
            //       Invalid: j..s@proseware.com 
            //       Invalid: js*@proseware.com 
            //       Invalid: js@proseware..com 
            //       Invalid: js@proseware.com9 
            //       Valid: j.s@server1.proseware.com

            return regex.IsMatch(miTextBox.Text);
        }

        #endregion
    }
}
