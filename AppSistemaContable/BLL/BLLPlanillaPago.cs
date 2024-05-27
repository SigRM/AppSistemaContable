using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.BLL
{
    class BLLPlanillaPago
    {
        public static void CREATE(PlanillaPago pPlanillaPago)
        {
            if (pPlanillaPago.Id!= 0)
            {
                DAL.DALPlanillaPago.UPDATE(pPlanillaPago);
            }
            else
            {
                DAL.DALPlanillaPago.CREATE(pPlanillaPago);
            }

        }

        public static void UPDATE(PlanillaPago pPlanillaPago)
        {
            if (pPlanillaPago.Id != 0)
            {
                DAL.DALPlanillaPago.UPDATE(pPlanillaPago);
            }
        }

        public static void DELETE(string Id)
        {
            if (Id != null)
            {
                DAL.DALPlanillaPago.DELETE(Id);
            }
        }

        public static List<PlanillaPago> SelectAll()
        {
            return DAL.DALPlanillaPago.SelectAll();
        }


        public static PlanillaPago SelectById(string Id)
        {
            return DAL.DALPlanillaPago.SelectById(Id);
        }

        public static bool Existe(String id)
        {
            PlanillaPago planillaPago = DAL.DALPlanillaPago.SelectById(id);
            if (planillaPago != null)
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
