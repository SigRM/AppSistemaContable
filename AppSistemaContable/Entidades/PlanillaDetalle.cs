using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Entidades
{
    public class PlanillaDetalle
    {
        public int Id { set; get; }
        public int IdEncabezado { set; get; }
        public int IdColaborador { set; get; }//string?
        public string NombreColaborador { set; get; }
        public int Tipo { set; get; }
        public int Codigo { set; get; }
        public double MontoDeducciones { set; get; }

    

    }
}
