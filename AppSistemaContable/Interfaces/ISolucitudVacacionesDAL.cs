using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Interfaces
{
    interface ISolucitudVacacionesDAL
    {
        void Create(SolicitudesVacaciones pSolicitudesVacaciones);
        void Update(SolicitudesVacaciones pSolicitudesVacaciones);
        void Delete(string pID);
        SolicitudesVacaciones Read(string pID);
        List<SolicitudesVacaciones> ReadAll();

    }
}
