using AppSistemaContable.DAL;
using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.BLL
{
    class BLLSolicitudVacaciones
    {
        DALSolicitudVacaciones DAL = new DALSolicitudVacaciones();
        #region CRUD : CREATE
        public void Create(SolicitudesVacaciones pSolicitudVacaciones)
        {
            if (pSolicitudVacaciones.IdColaborador != 0) 
            {
                DAL.Create(pSolicitudVacaciones);
            }
        }
        #endregion

        #region CRUD : UPDATE
        public void Update(SolicitudesVacaciones pSolicitudVacaciones)
        {
            if (pSolicitudVacaciones.IdColaborador!= 0)
            {
                DAL.Update(pSolicitudVacaciones);
            }

        }
        #endregion

        #region CRUD : DELETE
        public void Delete(string pID)
        {
            DAL.Delete(pID);
        }
        #endregion

        #region CRUD : READ
        public void Read(string pID)
        {
            DAL.Read(pID);
        }
        #endregion

        #region CRUD : READALL
        public List<SolicitudesVacaciones> ReadAlll()
        {
            return DAL.ReadAll();
        }
        #endregion
    }
}

