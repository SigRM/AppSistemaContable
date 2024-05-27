using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Entidades
{
    public class DeduccionPercepciones
    {
        public int Codigo { set; get; }
        public string Nombre { set; get; }
        public int Tipo { set; get; }
        public double Valor { set; get; } //5.5 Asociacion Solidarista
        public int TipoValor { set; get; }

    }
}
