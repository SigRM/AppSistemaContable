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
    class DALRoles
    {
        #region CREATE
        public static void CREATE(Roles pRoles)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    //   string sql = @"Insert into Usuarios(Identificacion,NombreCompleto,Telefono,FechaNacimiento,Direccion,CorreoElectronico,SalarioCRC,SalarioUSD,Genero,Foto) values (@Identificacion,@NombreCompleto,@Telefono,@FechaNacimiento,@Direccion,@CorreoElectronico,@SalarioCRC,@SalarioUSD,@Genero,@Foto)";
                    //   SqlCommand command = new SqlCommand();
                    var command = new SqlCommand("usp_INSERT_Roles");
                    command.Parameters.AddWithValue("@Codigo", pRoles.Codigo);
                    command.Parameters.AddWithValue("@Nombre", pRoles.Nombre);
                    command.Parameters.AddWithValue("@Estado", pRoles.Estado);


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
        public static void UPDATE(Roles pRoles)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    //   string sql = @"Insert into Usuarios(Identificacion,NombreCompleto,Telefono,FechaNacimiento,Direccion,CorreoElectronico,SalarioCRC,SalarioUSD,Genero,Foto) values (@Identificacion,@NombreCompleto,@Telefono,@FechaNacimiento,@Direccion,@CorreoElectronico,@SalarioCRC,@SalarioUSD,@Genero,@Foto)";
                    //   SqlCommand command = new SqlCommand();
                    var command = new SqlCommand("usp_UPDATE_Roles");
          
                    command.Parameters.AddWithValue("@Codigo", pRoles.Codigo);
                                

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
                    var command = new SqlCommand("usp_DELETE_Roles_ByID");
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
        public static List<Roles> SelectAll()
        {

            try
            {
                // Declarar el DataSet para extraer los datos;
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    var command = new SqlCommand("usp_SELECT_Roles_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Roles");
                }

                List<Roles> lista = new List<Roles>();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Roles oUsuarios = new Roles();
                        oUsuarios.Codigo = int.Parse(dr["Codigo"].ToString());
                        oUsuarios.Nombre = dr["Nombre"].ToString();
                        oUsuarios.Estado = bool.Parse(dr["Estado"].ToString());
                      
                        lista.Add(oUsuarios);

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
        public static Roles SelectById(string Id)
        {

            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    var command = new SqlCommand("usp_SELECT_Roles_ByID");
                    command.Parameters.AddWithValue("@Codigo", Id);
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Roles");
                }


                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Se crea el datatable
                    DataTable dt = ds.Tables[0];
                    Roles oUsuarios = new Roles();
                    oUsuarios.Codigo = int.Parse(dt.Rows[0]["Codigo"].ToString());
                    oUsuarios.Nombre = dt.Rows[0]["Nombre"].ToString();
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
