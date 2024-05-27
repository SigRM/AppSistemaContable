using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Entidades
{
    public class Roles
    {
        public int Codigo { set; get; }
        public string Nombre { set; get; }
        public bool Estado { set; get; }

        public override string ToString()
        {           
            return String.Format("{0}",Nombre);
        }
    }
}
