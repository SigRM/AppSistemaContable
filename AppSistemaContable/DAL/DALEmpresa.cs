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
    class DALEmpresa
    {
        #region CREATE
        public static void CREATE(Empresa pEmpresa)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    //   string sql = @"Insert into Usuarios(Identificacion,NombreCompleto,Telefono,FechaNacimiento,Direccion,CorreoElectronico,SalarioCRC,SalarioUSD,Genero,Foto) values (@Identificacion,@NombreCompleto,@Telefono,@FechaNacimiento,@Direccion,@CorreoElectronico,@SalarioCRC,@SalarioUSD,@Genero,@Foto)";
                    //   SqlCommand command = new SqlCommand();
                    var command = new SqlCommand("usp_INSERT_Empresa");
                    command.Parameters.AddWithValue("@Identificacion", pEmpresa.Identificacion);
                    command.Parameters.AddWithValue("@TipoIdentificacion", pEmpresa.TipoIdentificacion);
                    command.Parameters.AddWithValue("@Nombre", pEmpresa.Nombre);
                    command.Parameters.AddWithValue("@Telefono", pEmpresa.Telefono);
                    command.Parameters.AddWithValue("@Direccion", pEmpresa.Direccion);
                    command.Parameters.AddWithValue("@Logo", pEmpresa.Logo);
                    command.Parameters.AddWithValue("@Estado", pEmpresa.Estado);


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
        public static void UPDATE(Empresa pEmpresa)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    //   string sql = @"Insert into Usuarios(Identificacion,NombreCompleto,Telefono,FechaNacimiento,Direccion,CorreoElectronico,SalarioCRC,SalarioUSD,Genero,Foto) values (@Identificacion,@NombreCompleto,@Telefono,@FechaNacimiento,@Direccion,@CorreoElectronico,@SalarioCRC,@SalarioUSD,@Genero,@Foto)";
                    //   SqlCommand command = new SqlCommand();
                    var command = new SqlCommand("usp_UPDATE_Empresa");

                    command.Parameters.AddWithValue("@Identificacion", pEmpresa.Identificacion);

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
                    var command = new SqlCommand("usp_DELETE_Empresa_ByID");
                    command.Parameters.AddWithValue("@Identificacion", Id);
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
        public static List<Empresa> SelectAll()
        {

            try
            {
                // Declarar el DataSet para extraer los datos;
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    var command = new SqlCommand("usp_SELECT_Empresa_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Empresa");
                }

                List<Empresa> lista = new List<Empresa>();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Empresa oEmpresa = new Empresa();
                        oEmpresa.Identificacion = int.Parse(dr["Identificacion"].ToString());
                        oEmpresa.TipoIdentificacion = dr["Identificacion"].ToString();
                        oEmpresa.Nombre = dr["Nombre"].ToString();
                        oEmpresa.Telefono = dr["Telefono"].ToString();
                        oEmpresa.Direccion = dr["Direccion"].ToString();
                        oEmpresa.Logo = (byte[])dr["Logo"];
                        oEmpresa.Estado = bool.Parse(dr["Estado"].ToString());

                        lista.Add(oEmpresa);

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
        public static Empresa SelectById(string Id)
        {

            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    var command = new SqlCommand("usp_SELECT_Empresa_ByID");
                    command.Parameters.AddWithValue("@Identificacion", Id);
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Empresa");
                }


                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Se crea el datatable
                    DataTable dt = ds.Tables[0];
                    Empresa oEmpresa = new Empresa();
                    oEmpresa.Identificacion = int.Parse(dt.Rows[0]["Identificacion"].ToString());
                    oEmpresa.TipoIdentificacion = dt.Rows[0]["Identificacion"].ToString();
                    oEmpresa.Nombre = dt.Rows[0]["Nombre"].ToString();
                    oEmpresa.Telefono = dt.Rows[0]["Telefono"].ToString();
                    oEmpresa.Direccion = dt.Rows[0]["Direccion"].ToString();
                    oEmpresa.Logo = (byte[])dt.Rows[0]["Logo"];
                    oEmpresa.Estado = bool.Parse(dt.Rows[0]["Estado"].ToString());

                    return oEmpresa;

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
