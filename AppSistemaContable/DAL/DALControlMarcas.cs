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
    class DALControlMarcas
    {
        #region SELECT ALL
        public static List<ControlMarcas> SelectAll()
        {
            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_ControlMarcas_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "ControlMarcas");
                }

                List<ControlMarcas> lista = new List<ControlMarcas>();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ControlMarcas oControlMarcas = new ControlMarcas();
                        oControlMarcas.Id = int.Parse(dr["Id"].ToString());
                        oControlMarcas.Fecha = dr["Fecha"].ToString();
                        oControlMarcas.IdColaborador = int.Parse(dr["IdColaborador"].ToString());
                        oControlMarcas.HoraEntrada = dr["HoraEntrada"].ToString();
                        oControlMarcas.HoraSalida = dr["HoraSalida"].ToString();
                        oControlMarcas.HrsTrabajadas = double.Parse(dr["HrsTrabajadas"].ToString());

                        lista.Add(oControlMarcas);
                    }
                }
                return lista;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return null;
            }
        }
        #endregion

        #region DELETE
        public static void DELETE()
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_DELETE_ControlMarcas_ByID");
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        #endregion

        #region CREATE
        public static void CREATE(ControlMarcas controlMarcas)
        {
            try
            {
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_INSERT_ControlMarcas");
                    command.Parameters.AddWithValue("@Id", controlMarcas.Id);
                    command.Parameters.AddWithValue("@Fecha", controlMarcas.Fecha);
                    command.Parameters.AddWithValue("@IdColaborador", controlMarcas.IdColaborador);
                    command.Parameters.AddWithValue("@HoraEntrada", controlMarcas.HoraEntrada);
                    command.Parameters.AddWithValue("@HoraSalida", controlMarcas.HoraSalida);
                    command.Parameters.AddWithValue("@HrsTrabajadas", controlMarcas.HrsTrabajadas);
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        #endregion
    }
}
