using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Interfaces
{
    interface IPlanillaPagoBLL
    {
        void CREATE(PlanillaPago pPlanillaPago);
        void UPDATE(PlanillaPago pPlanillaPago);
        void DELETE(string Id);
        List<PlanillaPago> SelectAll();
        PlanillaPago SelectById(string Id);
        bool Existe(String id);


    }
}
