using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.BLL
{
    class BLLControlMarcas
    {
        #region CREATE
        public static void CREATE(ControlMarcas controlMarcas)
        {
            DAL.DALControlMarcas.CREATE(controlMarcas);
        }
        #endregion

        #region DELETE
        public static void DELETE()
        {
            DAL.DALControlMarcas.DELETE();
        }
        #endregion

        #region SELECT ALL
        public static List<ControlMarcas> SelectAll()
        {
            return DAL.DALControlMarcas.SelectAll();
        }
        #endregion
    }
}
