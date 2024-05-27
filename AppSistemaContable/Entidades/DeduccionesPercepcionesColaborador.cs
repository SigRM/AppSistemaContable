using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Entidades
{
    public class DeduccionesPercepcionesColaborador
    {
        public int Codigo { set; get; }
        public Colaboradores IdColaborador { set; get; }
        public int Prioridad { set; get; }
        public bool Estado { set; get; }


    }
}
