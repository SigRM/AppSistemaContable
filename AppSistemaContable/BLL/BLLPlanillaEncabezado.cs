using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.BLL
{
    class BLLPlanillaEncabezado
    {
        public static void CREATE(PlanillaEncabezado pPlanillaEncabezado)
        {
            if (pPlanillaEncabezado.Id!= 0)
            {
                DAL.DALPlanillaEncabezado.UPDATE(pPlanillaEncabezado);
            }
            else
            {
                DAL.DALPlanillaEncabezado.CREATE(pPlanillaEncabezado);
            }

        }

        public static void UPDATE(PlanillaEncabezado pPlanillaEncabezado)
        {
            if (pPlanillaEncabezado.Id!= 0)
            {
                DAL.DALPlanillaEncabezado.UPDATE(pPlanillaEncabezado);
            }
        }

        public static void DELETE(string Id)
        {
            if (Id != null)
            {
                DAL.DALPlanillaEncabezado.DELETE(Id);
            }
        }

        public static List<PlanillaEncabezado> SelectAll()
        {
            return DAL.DALPlanillaEncabezado.SelectAll();
        }


        public static PlanillaEncabezado SelectById(string Id)
        {
            return DAL.DALPlanillaEncabezado.SelectById(Id);
        }

        public static bool Existe(String id)
        {
            PlanillaEncabezado usuario = DAL.DALPlanillaEncabezado.SelectById(id);
            if (usuario != null)
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
