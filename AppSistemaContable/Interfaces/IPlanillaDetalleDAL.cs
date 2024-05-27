using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Interfaces
{
    interface IPlanillaDetalleDAL
    {
        void CREATE(PlanillaDetalle pPlanillaDetalle);
        void UPDATE(PlanillaDetalle pPlanillaDetalle);
        void DELETE(string Id);
        List<PlanillaDetalle> SelectAll();
        PlanillaDetalle SelectById(string Id);
    }
}
