using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Entidades
{
    public class SolicitudesVacaciones
    {
       
            public int IdColaborador { set; get; }
            public DateTime FechaSolicitud { set; get; }
            public DateTime FechaSolicitarDesde { set; get; }
            public DateTime FechaSolicitarHasta { set; get; }
            public int CantidadDias { set; get; }
            public string Observaciones { set; get; }
            public bool Estado { set; get; }
        

    }
}
