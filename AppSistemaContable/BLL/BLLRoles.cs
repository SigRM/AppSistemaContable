using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.BLL
{
    class BLLRoles
    {

        public static void CREATE(Roles proles)
        {
            if (proles.Codigo != 0)
            {
                DAL.DALRoles.UPDATE(proles);
            }
            else
            {
                DAL.DALRoles.CREATE(proles);
            }

        }

        public static void UPDATE(Roles proles)
        {
            if (proles.Codigo != 0)
            {
                DAL.DALRoles.UPDATE(proles);
            }
        }

        public static void DELETE(string Id)
        {
            if (Id != null)
            {
                DAL.DALRoles.DELETE(Id);
            }
        }

        public static List<Roles> SelectAll()
        {
            return DAL.DALRoles.SelectAll();
        }


        public static Roles SelectById(string Id)
        {
            return DAL.DALRoles.SelectById(Id);
        }
      
        public static bool Existe(String id)
        {
            Roles usuario = DAL.DALRoles.SelectById(id);
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

