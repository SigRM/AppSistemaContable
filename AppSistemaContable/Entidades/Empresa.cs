using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Entidades
{
    public class Empresa
    {
        public int Identificacion { set; get; }
        public string TipoIdentificacion { set; get; }
        public string Nombre { set; get; }
        public string Telefono { set; get; }
        public string Direccion { set; get; }
        public byte[] Logo { set; get; }
        public bool Estado { set; get; }

    }
}
