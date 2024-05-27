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
    class DALColaboradores
    {
        #region CREATE
        public static void CREATE(Colaboradores colaboradores)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    //   string sql = @"Insert into Usuarios(Identificacion,NombreCompleto,Telefono,FechaNacimiento,Direccion,CorreoElectronico,SalarioCRC,SalarioUSD,Genero,Foto) values (@Identificacion,@NombreCompleto,@Telefono,@FechaNacimiento,@Direccion,@CorreoElectronico,@SalarioCRC,@SalarioUSD,@Genero,@Foto)";
                    //   SqlCommand command = new SqlCommand();
                    var command = new SqlCommand("usp_INSERT_Colaboradores");
                    command.Parameters.AddWithValue("@Identificacion", colaboradores.Identificacion);
                    command.Parameters.AddWithValue("@Nombre", colaboradores.Nombre);
                    command.Parameters.AddWithValue("@Apellidos", colaboradores.Apellidos);
                    command.Parameters.AddWithValue("@FechaNacimiento", colaboradores.FechaNacimiento);
                    command.Parameters.AddWithValue("@Direccion", colaboradores.Direccion);
                    command.Parameters.AddWithValue("@FechaIngreso", colaboradores.FechaIngreso);
                    command.Parameters.AddWithValue("@Departamento", colaboradores.Departamento);
                    command.Parameters.AddWithValue("@SalarioHora", colaboradores.SalarioHora);
                    command.Parameters.AddWithValue("@Fotografia", colaboradores.Fotografia);
                    command.Parameters.AddWithValue("@CorreoElectronico", colaboradores.CorreoElectronico);
                    command.Parameters.AddWithValue("@SupervisorACargo", colaboradores.SupervisorACargo);
                    command.Parameters.AddWithValue("@CuentaIBAN", colaboradores.CuentaIBAN);
                    command.Parameters.AddWithValue("@Usuario", colaboradores.Usuario);
                    command.Parameters.AddWithValue("@Contrasena", colaboradores.Contrasena);
                    command.Parameters.AddWithValue("@Estado", colaboradores.Estado);
                    command.Parameters.AddWithValue("@Rol", colaboradores.Rol.Codigo);
                    command.Parameters.AddWithValue("@Puesto", colaboradores.Puesto.Codigo);
                    

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
        public static void UPDATE(Colaboradores colaboradores)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    //   string sql = @"Insert into Usuarios(Identificacion,NombreCompleto,Telefono,FechaNacimiento,Direccion,CorreoElectronico,SalarioCRC,SalarioUSD,Genero,Foto) values (@Identificacion,@NombreCompleto,@Telefono,@FechaNacimiento,@Direccion,@CorreoElectronico,@SalarioCRC,@SalarioUSD,@Genero,@Foto)";
                    //   SqlCommand command = new SqlCommand();
                    var command = new SqlCommand("usp_UPDATE_Colaboradores");
                    command.Parameters.AddWithValue("@Identificacion", colaboradores.Identificacion);
                    command.Parameters.AddWithValue("@Nombre", colaboradores.Nombre);
                    command.Parameters.AddWithValue("@Apellidos", colaboradores.Apellidos);
                    command.Parameters.AddWithValue("@FechaNacimiento", colaboradores.FechaNacimiento);
                    command.Parameters.AddWithValue("@Direccion", colaboradores.Direccion);
                    command.Parameters.AddWithValue("@FechaIngreso", colaboradores.FechaIngreso);
                    command.Parameters.AddWithValue("@Departamento", colaboradores.Departamento);
                    command.Parameters.AddWithValue("@SalarioHora", colaboradores.SalarioHora);
                    command.Parameters.AddWithValue("@Fotografia", colaboradores.Fotografia);
                    command.Parameters.AddWithValue("@CorreoElectronico", colaboradores.CorreoElectronico);
                    command.Parameters.AddWithValue("@SupervisorACargo", colaboradores.SupervisorACargo);
                    command.Parameters.AddWithValue("@CuentaIBAN", colaboradores.CuentaIBAN);
                    command.Parameters.AddWithValue("@Usuario", colaboradores.Usuario);
                    command.Parameters.AddWithValue("@Contrasena", colaboradores.Contrasena);
                    command.Parameters.AddWithValue("@Estado", colaboradores.Estado);
                    command.Parameters.AddWithValue("@Rol", colaboradores.Rol.Codigo);
                    command.Parameters.AddWithValue("@Puesto", colaboradores.Puesto.Codigo);


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
                    var command = new SqlCommand("usp_DELETE_Colaboradores_ByID");
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
        public static List<Colaboradores> SelectAll()
        {

            try
            {
                // Declarar el DataSet para extraer los datos;
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    var command = new SqlCommand("usp_SELECT_Colaboradores_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Colaboradores");
                }

                List<Colaboradores> lista = new List<Colaboradores>();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Colaboradores oUsuarios = new Colaboradores();
                        oUsuarios.Identificacion = dr["Identificacion"].ToString();
                        oUsuarios.Nombre = dr["Nombre"].ToString();
                        oUsuarios.Apellidos = dr["Apellidos"].ToString();
                        oUsuarios.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                        oUsuarios.Direccion = dr["Direccion"].ToString();
                        oUsuarios.FechaIngreso = DateTime.Parse(dr["FechaIngreso"].ToString());
                        oUsuarios.Departamento = dr["Departamento"].ToString();
                        oUsuarios.SalarioHora = decimal.Parse(dr["SalarioHora"].ToString());
                        oUsuarios.Fotografia = (byte[])dr["Fotografia"];
                        oUsuarios.CorreoElectronico = dr["CorreoElectronico"].ToString();
                        oUsuarios.SupervisorACargo = int.Parse(dr["SupervisorACargo"].ToString());
                        oUsuarios.CuentaIBAN = dr["CuentaIBAN"].ToString();
                        oUsuarios.Usuario = dr["Usuario"].ToString();
                        oUsuarios.Contrasena = dr["Usuario"].ToString();
                        oUsuarios.Estado = bool.Parse(dr["Estado"].ToString());
                        oUsuarios.Rol = BLL.BLLRoles.SelectById(dr["Rol "].ToString());
                        oUsuarios.Puesto = BLL.BLLPuestos.SelectById(dr["Puesto"].ToString());
                        
                        lista.Add(oUsuarios);

                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw; //o return null
            }
        }

        #endregion

        #region SELECT BY ID
        public static Colaboradores SelectById(string Id)
        {

            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    var command = new SqlCommand("usp_SELECT_Colaboradores_ByID");
                    command.Parameters.AddWithValue("@Identificacion", Id);
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "Colaboradores");
                }
                

                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Se crea el datatable
                    DataTable dt = ds.Tables[0];
                    Colaboradores oUsuarios = new Colaboradores();
                    oUsuarios.Identificacion = dt.Rows[0]["Identificacion"].ToString();
                    oUsuarios.Identificacion = dt.Rows[0]["Identificacion"].ToString();
                    oUsuarios.Nombre = dt.Rows[0]["Nombre"].ToString();
                    oUsuarios.Apellidos = dt.Rows[0]["Apellidos"].ToString();
                    oUsuarios.FechaNacimiento = DateTime.Parse(dt.Rows[0]["FechaNacimiento"].ToString());
                    oUsuarios.Direccion = dt.Rows[0]["Direccion"].ToString();
                    oUsuarios.FechaIngreso = DateTime.Parse(dt.Rows[0]["FechaIngreso"].ToString());
                    oUsuarios.Departamento = dt.Rows[0]["Departamento"].ToString();
                    oUsuarios.SalarioHora = decimal.Parse(dt.Rows[0]["SalarioHora"].ToString());
                    oUsuarios.Fotografia = (byte[])dt.Rows[0]["Fotografia"];
                    oUsuarios.CorreoElectronico = dt.Rows[0]["CorreoElectronico"].ToString();
                    oUsuarios.SupervisorACargo = int.Parse(dt.Rows[0]["SupervisorACargo"].ToString());
                    oUsuarios.CuentaIBAN = dt.Rows[0]["CuentaIBAN"].ToString();
                    oUsuarios.Usuario = dt.Rows[0]["Usuario"].ToString();
                    oUsuarios.Contrasena = dt.Rows[0]["Usuario"].ToString();
                    oUsuarios.Estado = bool.Parse(dt.Rows[0]["Estado"].ToString());
                    oUsuarios.Rol = BLL.BLLRoles.SelectById(dt.Rows[0]["Rol "].ToString());
                    oUsuarios.Puesto = BLL.BLLPuestos.SelectById(dt.Rows[0]["Puesto"].ToString());
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
