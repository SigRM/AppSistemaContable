using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Interfaces
{
    interface IPlanillaEncabezadoBLL
    {
        void CREATE(PlanillaEncabezado pPlanillaEncabezado);
        void UPDATE(PlanillaEncabezado pPlanillaEncabezado);
        void DELETE(string Id);
        List<PlanillaEncabezado> SelectAll();
        PlanillaEncabezado SelectById(string Id);
        bool Existe(String id);
    }
}
