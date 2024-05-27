using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.BLL
{
    class BLLDeduccionesPercepcionesColaborador
    {
        public static void CREATE(DeduccionesPercepcionesColaborador pDeduccionesPercepcionesColaborador)
            {
                if (pDeduccionesPercepcionesColaborador.Codigo != 0)
                {
                    DAL.DALDeduccionesPercepcionesColaborador.UPDATE(pDeduccionesPercepcionesColaborador);
                }
                else
                {
                    DAL.DALDeduccionesPercepcionesColaborador.CREATE(pDeduccionesPercepcionesColaborador);
                }

            }

            public static void UPDATE(DeduccionesPercepcionesColaborador pDeduccionesPercepcionesColaborador)
            {
                if (pDeduccionesPercepcionesColaborador.Codigo != 0)
                {
                    DAL.DALDeduccionesPercepcionesColaborador.UPDATE(pDeduccionesPercepcionesColaborador);
                }
            }

            public static void DELETE(string Id)
            {
                if (Id != null)
                {
                    DAL.DALDeduccionesPercepcionesColaborador.DELETE(Id);
                }
            }

            public static List<DeduccionesPercepcionesColaborador> SelectAll()
            {
                return DAL.DALDeduccionesPercepcionesColaborador.SelectAll();
            }


            public static DeduccionesPercepcionesColaborador SelectById(string Id)
            {
                return DAL.DALDeduccionesPercepcionesColaborador.SelectById(Id);
            }

            public static bool Existe(String id)
            {
                DeduccionesPercepcionesColaborador pDeduccionesPercepcionesColaborador = DAL.DALDeduccionesPercepcionesColaborador.SelectById(id);
                if (pDeduccionesPercepcionesColaborador != null)
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


