using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Interfaces
{
    interface ISolicitudVacacionesBLL
    {
        void Create(SolicitudesVacaciones pSolicitudVacaciones);
        void Update(SolicitudesVacaciones pSolicitudVacaciones);
        void Delete(string pID);
        void Read(string pID);
        List<SolicitudesVacaciones> ReadAlll();
    }
}
