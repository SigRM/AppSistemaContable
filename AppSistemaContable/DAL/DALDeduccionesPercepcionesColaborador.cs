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
    class DALDeduccionesPercepcionesColaborador
    {
        #region CREATE
        public static void CREATE(DeduccionesPercepcionesColaborador pDeduccionesPercepcionesColaborador)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    //   string sql = @"Insert into Usuarios(Identificacion,NombreCompleto,Telefono,FechaNacimiento,Direccion,CorreoElectronico,SalarioCRC,SalarioUSD,Genero,Foto) values (@Identificacion,@NombreCompleto,@Telefono,@FechaNacimiento,@Direccion,@CorreoElectronico,@SalarioCRC,@SalarioUSD,@Genero,@Foto)";
                    //   SqlCommand command = new SqlCommand();
                    var command = new SqlCommand("usp_INSERT_DeduccionesPercepcionesColaborador");
                    command.Parameters.AddWithValue("@Codigo", pDeduccionesPercepcionesColaborador.Codigo);
                    command.Parameters.AddWithValue("@IdColaborador", pDeduccionesPercepcionesColaborador.IdColaborador.Identificacion);
                    command.Parameters.AddWithValue("@Prioridad", pDeduccionesPercepcionesColaborador.Prioridad);
                    command.Parameters.AddWithValue("@Estado", pDeduccionesPercepcionesColaborador.Estado);
                  
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region UPDATE
        public static void UPDATE(DeduccionesPercepcionesColaborador pDeduccionesPercepcionesColaborador)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    //   string sql = @"Insert into Usuarios(Identificacion,NombreCompleto,Telefono,FechaNacimiento,Direccion,CorreoElectronico,SalarioCRC,SalarioUSD,Genero,Foto) values (@Identificacion,@NombreCompleto,@Telefono,@FechaNacimiento,@Direccion,@CorreoElectronico,@SalarioCRC,@SalarioUSD,@Genero,@Foto)";
                    //   SqlCommand command = new SqlCommand();
                    var command = new SqlCommand("usp_UPDATE_DeduccionesPercepcionesColaborador");

                    command.Parameters.AddWithValue("Codigo", pDeduccionesPercepcionesColaborador.Codigo);

                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region DELETE
        public static void DELETE(string Id)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    // string sql = @"Delete from  Usuarios   Where (Identificacion = @Identificacion) ";
                    // SqlCommand command = new SqlCommand();
                    var command = new SqlCommand("usp_DELETE_DeduccionesPercepcionesColaborador_ByID");
                    command.Parameters.AddWithValue("@Codigo", Id);
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region SELECT ALL
        public static List<DeduccionesPercepcionesColaborador> SelectAll()
        {

            try
            {
                // Declarar el DataSet para extraer los datos;
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    var command = new SqlCommand("usp_SELECT_DeduccionesPercepcionesColaborador_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "DeduccionesPercepcionesColaborador");
                }

                List<DeduccionesPercepcionesColaborador> lista = new List<DeduccionesPercepcionesColaborador>();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        DeduccionesPercepcionesColaborador oDeduccionesPercepcionesColaborador = new DeduccionesPercepcionesColaborador();
                        oDeduccionesPercepcionesColaborador.Codigo = int.Parse(dr["Codigo"].ToString());
                        oDeduccionesPercepcionesColaborador.IdColaborador = BLL.BLLColaboradores.SelectById(dr["IdColaborador"].ToString());
                        oDeduccionesPercepcionesColaborador.Prioridad = int.Parse(dr["Prioridad"].ToString());
                        oDeduccionesPercepcionesColaborador.Estado = bool.Parse(dr["Estado"].ToString());
                        lista.Add(oDeduccionesPercepcionesColaborador);

                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        #endregion

        #region SELECT BY ID
        public static DeduccionesPercepcionesColaborador SelectById(string Id)
        {

            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    var command = new SqlCommand("usp_SELECT_DeduccionesPercepcionesColaborador_ByID");
                    command.Parameters.AddWithValue("@Identificacion", Id);
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "DeduccionesPercepcionesColaborador");
                }


                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Se crea el datatable
                    DataTable dt = ds.Tables[0];
                    DeduccionesPercepcionesColaborador oDeduccionesPercepcionesColaborador = new DeduccionesPercepcionesColaborador();
                    oDeduccionesPercepcionesColaborador.Codigo = int.Parse(dt.Rows[0]["Codigo"].ToString());
                    oDeduccionesPercepcionesColaborador.IdColaborador = BLL.BLLColaboradores.SelectById(dt.Rows[0]["IdColaborador"].ToString());
                    oDeduccionesPercepcionesColaborador.Prioridad = int.Parse(dt.Rows[0]["Prioridad"].ToString());
                    oDeduccionesPercepcionesColaborador.Estado = bool.Parse(dt.Rows[0]["Estado"].ToString());
       

                    return oDeduccionesPercepcionesColaborador;

                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        #endregion
    }
}
