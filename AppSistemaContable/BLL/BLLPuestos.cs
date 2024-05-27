using AppSistemaContable.DAL;
using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.BLL
{
    class BLLPuestos
    {
        public static void CREATE(Puestos pPuestos)
        {
            if (pPuestos.Codigo != 0)
            {
                DAL.DALPuestos.UPDATE(pPuestos);
            }
            

        }

        public static void UPDATE(Puestos pPuestos)
        {
            if (pPuestos.Codigo != 0)
            {
                DAL.DALPuestos.UPDATE(pPuestos);
            }
        }

        public static void DELETE(string Id)
        {
            if (Id != null)
            {
                DAL.DALPuestos.DELETE(Id);
            }
        }

        public static List<Puestos> SelectAll()
        {
            return DAL.DALPuestos.SelectAll();
        }


        public static Puestos SelectById(string Id)
        {
            return DAL.DALPuestos.SelectById(Id);
        }

        public static bool Existe(String id)
        {
            Puestos usuario = DAL.DALPuestos.SelectById(id);
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