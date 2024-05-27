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
    class DALPuestos
    {
        #region CREATE
        public static void CREATE(Puestos pPuestos)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    //   string sql = @"Insert into Usuarios(Identificacion,NombreCompleto,Telefono,FechaNacimiento,Direccion,CorreoElectronico,SalarioCRC,SalarioUSD,Genero,Foto) values (@Identificacion,@NombreCompleto,@Telefono,@FechaNacimiento,@Direccion,@CorreoElectronico,@SalarioCRC,@SalarioUSD,@Genero,@Foto)";
                    //   SqlCommand command = new SqlCommand();
                    var command = new SqlCommand("usp_INSERT_Puestos");
                    command.Parameters.AddWithValue("@Codigo", pPuestos.Codigo);
                    command.Parameters.AddWithValue("@NombrePuesto", pPuestos.NombrePuesto);
                    command.Parameters.AddWithValue("@Estado", pPuestos.Estado);


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
        public static void UPDATE(Puestos pPuestos)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_Puestos");
                    command.Parameters.AddWithValue("@Codigo", pPuestos.Codigo);
                    command.Parameters.AddWithValue("@NombrePuesto", pPuestos.NombrePuesto);
                    command.Parameters.AddWithValue("@Estado", pPuestos.Estado);

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

        #region DELETE
        public static void DELETE(string Id)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                   
                    var command = new SqlCommand("usp_DELETE_Puestos_ByID");
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
        public static List<Puestos> SelectAll()
        {

            try
            {
                // Declarar el DataSet para extraer los datos;
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    var command = new SqlCommand("usp_SELECT_Puestos_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Puestos");
                }

                List<Puestos> lista = new List<Puestos>();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Puestos oPuestos = new Puestos();
                        oPuestos.Codigo = int.Parse(dr["Codigo"].ToString());
                        oPuestos.NombrePuesto = dr["NombrePuesto"].ToString();
                        oPuestos.Estado = bool.Parse(dr["Estado"].ToString());

                        lista.Add(oPuestos);

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
        public static Puestos SelectById(string Id)
        {

            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    var command = new SqlCommand("usp_SELECT_Puestos_ByID");
                    command.Parameters.AddWithValue("@Codigo", Id);
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Puestos");
                }


                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Se crea el datatable
                    DataTable dt = ds.Tables[0];
                    Puestos oUsuarios = new Puestos();
                    oUsuarios.Codigo = int.Parse(dt.Rows[0]["Codigo"].ToString());
                    oUsuarios.NombrePuesto = dt.Rows[0]["NombrePuesto"].ToString();
                    oUsuarios.Estado = bool.Parse(dt.Rows[0]["Estado"].ToString());

                    return oUsuarios;

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


