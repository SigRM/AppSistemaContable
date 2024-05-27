using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.BLL
{
    class BLLColaboradores
    {
        #region CREATE
        public static void CREATE(Colaboradores usuarios)
        {
            if (usuarios.Identificacion != null)
            {
                if (Existe(usuarios.Identificacion))
                {
                    //MessageBox.Show("El usuario ya existe");
                    DAL.DALColaboradores.UPDATE(usuarios);
                }
                else
                {
                    DAL.DALColaboradores.CREATE(usuarios);
                }
            }
        }
        #endregion
        #region UPDATE
        public static void UPDATE(Colaboradores pColaboradores)
        {
            if (pColaboradores.Identificacion != null)
            {
                DAL.DALColaboradores.UPDATE(pColaboradores);
            }
        }
        #endregion
        #region DELETE
        public static void DELETE(string Id)
        {
            if (Id != null)
            {
                DAL.DALColaboradores.DELETE(Id);
            }
        }
        #endregion
        #region SELECT ALL
        public static List<Colaboradores> SelectAll()
        {
            return DAL.DALColaboradores.SelectAll();
        }
        #endregion
        #region SELECT BY ID
        public static Colaboradores SelectById(string Id)
        {
            return DAL.DALColaboradores.SelectById(Id);
        }
        #endregion

        #region Existe
        public static bool Existe(String id)
        {
            Colaboradores usuario = DAL.DALColaboradores.SelectById(id);
            if (usuario != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
