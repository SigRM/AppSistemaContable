using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.BLL
{
    class BLLDeduccionPercepciones
    {
        public static void CREATE(DeduccionPercepciones pDeduccionPercepciones)
            {
                if (pDeduccionPercepciones.Codigo!= 0)
                {
                    DAL.DALDeduccionPercepciones.UPDATE(pDeduccionPercepciones);
                }
                else
                {
                    DAL.DALDeduccionPercepciones.CREATE(pDeduccionPercepciones);
                }

            }

            public static void UPDATE(DeduccionPercepciones pDeduccionPercepciones)
            {
                if (pDeduccionPercepciones.Codigo!= 0)
                {
                    DAL.DALDeduccionPercepciones.UPDATE(pDeduccionPercepciones);
                }
            }

            public static void DELETE(string Id)
            {
                if (Id != null)
                {
                    DAL.DALDeduccionPercepciones.DELETE(Id);
                }
            }

            public static List<DeduccionPercepciones> SelectAll()
            {
                return DAL.DALDeduccionPercepciones.SelectAll();
            }


            public static DeduccionPercepciones SelectById(string Id)
            {
                return DAL.DALDeduccionPercepciones.SelectById(Id);
            }

            public static bool Existe(String id)
            {
            DeduccionPercepciones pDeduccionPercepciones = DAL.DALDeduccionPercepciones.SelectById(id);
                if (pDeduccionPercepciones != null)
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
