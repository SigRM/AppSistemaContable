using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSistemaContable.DAL
{
    class DALSolicitudVacaciones
    {
        #region CRUD : CREATE
        public void Create(SolicitudesVacaciones pSolicitudesVacaciones)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_SolicitudesVacaciones"); //Cambiar nombre

                    command.Parameters.AddWithValue("@IdColaborador", int.Parse(pSolicitudesVacaciones.IdColaborador.ToString()));
                    command.Parameters.AddWithValue("@FechaSolicitud", pSolicitudesVacaciones.FechaSolicitud);
                    command.Parameters.AddWithValue("@FechaSolicitarDesde", pSolicitudesVacaciones.FechaSolicitarDesde);
                    command.Parameters.AddWithValue("@FechaSolicitarHasta", pSolicitudesVacaciones.FechaSolicitarHasta);
                    command.Parameters.AddWithValue("@CantidadDias", pSolicitudesVacaciones.CantidadDias);
                    command.Parameters.AddWithValue("@Observaciones", pSolicitudesVacaciones.Observaciones);
                    command.Parameters.AddWithValue("@Estado", pSolicitudesVacaciones.Estado);

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message  {0}\n", er.Message);
                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region CRUD: UPDATE
        public void Update(SolicitudesVacaciones pSolicitudesVacaciones)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_SolicitudesVacaciones"); //Crear SQL Command

                    command.Parameters.AddWithValue("@IdColaborador", int.Parse(pSolicitudesVacaciones.IdColaborador.ToString()));
                    command.Parameters.AddWithValue("@FechaSolicitud", pSolicitudesVacaciones.FechaSolicitud);
                    command.Parameters.AddWithValue("@FechaSolicitarDesde", pSolicitudesVacaciones.FechaSolicitarDesde);
                    command.Parameters.AddWithValue("@FechaSolicitarHasta", pSolicitudesVacaciones.FechaSolicitarHasta);
                    command.Parameters.AddWithValue("@CantidadDias", pSolicitudesVacaciones.CantidadDias);
                    command.Parameters.AddWithValue("@Observaciones", pSolicitudesVacaciones.Observaciones);
                    command.Parameters.AddWithValue("@Estado", pSolicitudesVacaciones.Estado);

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region CRUD: DELETE
        public void Delete(string pID)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_DELETE_SolicitudesVacaciones_ByID"); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@IdColaborador", pID);

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region CRUD: READ
        public SolicitudesVacaciones Read(string pID)
        {
            try
            {
                DataSet ds = null;  //Crear dataset

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_SolicitudesVacaciones_ByID"); //Crear SQL Command

                    //Pasar parametros
                    command.Parameters.AddWithValue("@IdColaborador", pID);

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Extraer la tabla
                DataTable dr = ds.Tables[0];

                //Crear objeto
                SolicitudesVacaciones oSolicitudesVacaciones = null;

                if (dr.Rows.Count > 0)
                {
                    oSolicitudesVacaciones = new SolicitudesVacaciones()
                    {
                        IdColaborador = Convert.ToUInt16(dr.Rows[0]["IdColaborador"].ToString()),
                        FechaSolicitud = Convert.ToDateTime(dr.Rows[0]["FechaSolicitud"].ToString()),
                        FechaSolicitarDesde = Convert.ToDateTime(dr.Rows[0]["FechaSolicitarDesde"].ToString()),
                        FechaSolicitarHasta = Convert.ToDateTime(dr.Rows[0]["FechaSolicitarHasta"].ToString()),
                        CantidadDias = Convert.ToUInt16(dr.Rows[0]["CantidadDias"].ToString()),
                        Observaciones = dr.Rows[0]["Observaciones"].ToString(),
                        Estado = Convert.ToBoolean(dr.Rows[0]["Estado"].ToString()),

                    };
                }
                return oSolicitudesVacaciones;
            }

            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region CRUD : READALL
        public List<SolicitudesVacaciones> ReadAll()
        {
            try
            {
                //Crear Dataset
                DataSet ds = null;

                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_SolicitudesVacaciones_All"); //Crear SQL Command

                    //Asignar Store Procedures
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
                //Crear lista
                List<SolicitudesVacaciones> lista = new List<SolicitudesVacaciones>();
                //Cargar lista con objetos segun tabla del dataset
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        SolicitudesVacaciones oSolicitudesVacaciones = new SolicitudesVacaciones()
                        {
                            IdColaborador = Convert.ToUInt16(dr["IdColaborador"].ToString()),
                            FechaSolicitud = Convert.ToDateTime(dr["FechaSolicitud"].ToString()),
                            FechaSolicitarDesde = Convert.ToDateTime(dr["FechaSolicitarDesde"].ToString()),
                            FechaSolicitarHasta = Convert.ToDateTime(dr["FechaSolicitarHasta"].ToString()),
                            CantidadDias = Convert.ToUInt16(dr["CantidadDias"].ToString()),
                            Observaciones = dr["Observaciones"].ToString(),
                            Estado = Convert.ToBoolean(dr["Estado"].ToString()),

                        };
                        lista.Add(oSolicitudesVacaciones);
                    }
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}


