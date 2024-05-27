using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Entidades
{
    public class PlanillaPago
    {
        public int Id { set; get; }
        public string NombrePlanilla { set; get; }
        public DateTime FechaDesde { set; get; }
        public DateTime FechaHasta { set; get; }
        public DateTime FechaPago { set; get; }
        public int EmpresaId { set; get; }
        public bool Estado { set; get; }

        
    
    }
}
