using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.BLL
{
    class BLLPlanillaDetalle
    {
        public static void CREATE(PlanillaDetalle pPlanillaDetalle)
        {
            if (pPlanillaDetalle.Id != 0)
            {
                DAL.DALPlanillaDetalle.UPDATE(pPlanillaDetalle);
            }
            else
            {
                DAL.DALPlanillaDetalle.CREATE(pPlanillaDetalle);
            }

        }

        public static void UPDATE(PlanillaDetalle pPlanillaDetalle)
        {
            if (pPlanillaDetalle.Id != 0)
            {
                DAL.DALPlanillaDetalle.UPDATE(pPlanillaDetalle);
            }
        }

        public static void DELETE(string Id)
        {
            if (Id != null)
            {
                DAL.DALPlanillaDetalle.DELETE(Id);
            }
        }

        public static List<PlanillaDetalle> SelectAll()
        {
            return DAL.DALPlanillaDetalle.SelectAll();
        }


        public static PlanillaDetalle SelectById(string Id)
        {
            return DAL.DALPlanillaDetalle.SelectById(Id);
        }

        public static bool Existe(String id)
        {
            PlanillaDetalle planillaDetalle = DAL.DALPlanillaDetalle.SelectById(id);
            if (planillaDetalle != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
