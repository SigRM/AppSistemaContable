using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSistemaContable.BLL
{
    class BLLEmpresa
    {
        public static void CREATE(Empresa pEmpresa)
        {
            if (pEmpresa.Identificacion != 0)
            {
                DAL.DALEmpresa.UPDATE(pEmpresa);
            }
            else
            {
                DAL.DALEmpresa.CREATE(pEmpresa);
            }

        }

        public static void UPDATE(Empresa pEmpresa)
        {
            if (pEmpresa.Identificacion != 0)
            {
                DAL.DALEmpresa.UPDATE(pEmpresa);
            }
        }

        public static void DELETE(string Id)
        {
            if (Id != null)
            {
                DAL.DALEmpresa.DELETE(Id);
            }
        }

        public static List<Empresa> SelectAll()
        {
            return DAL.DALEmpresa.SelectAll();
        }


        public static Empresa SelectById(string Id)
        {
            return DAL.DALEmpresa.SelectById(Id);
        }

        public static bool Existe(String id)
        {
            Empresa pEmpresa = DAL.DALEmpresa.SelectById(id);
            if (pEmpresa != null)
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
