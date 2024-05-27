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
    class DALDeduccionPercepciones
    {
        #region CREATE
        public static void CREATE(DeduccionPercepciones pDeduccionPercepciones)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    //   string sql = @"Insert into Usuarios(Identificacion,NombreCompleto,Telefono,FechaNacimiento,Direccion,CorreoElectronico,SalarioCRC,SalarioUSD,Genero,Foto) values (@Identificacion,@NombreCompleto,@Telefono,@FechaNacimiento,@Direccion,@CorreoElectronico,@SalarioCRC,@SalarioUSD,@Genero,@Foto)";
                    //   SqlCommand command = new SqlCommand();
                    var command = new SqlCommand("usp_INSERT_DeduccionPercepciones");
                    command.Parameters.AddWithValue("@Codigo", pDeduccionPercepciones.Codigo);
                    command.Parameters.AddWithValue("@Nombre", pDeduccionPercepciones.Nombre);
                    command.Parameters.AddWithValue("@Tipo", pDeduccionPercepciones.Tipo);
                    command.Parameters.AddWithValue("@Valor", pDeduccionPercepciones.Valor);
                    command.Parameters.AddWithValue("@TipoValor", pDeduccionPercepciones.TipoValor);
                    


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
        public static void UPDATE(DeduccionPercepciones pDeduccionPercepciones)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    //   string sql = @"Insert into Usuarios(Identificacion,NombreCompleto,Telefono,FechaNacimiento,Direccion,CorreoElectronico,SalarioCRC,SalarioUSD,Genero,Foto) values (@Identificacion,@NombreCompleto,@Telefono,@FechaNacimiento,@Direccion,@CorreoElectronico,@SalarioCRC,@SalarioUSD,@Genero,@Foto)";
                    //   SqlCommand command = new SqlCommand();
                    var command = new SqlCommand("usp_UPDATE_DeduccionPercepciones");

                    command.Parameters.AddWithValue("@Codigo", pDeduccionPercepciones.Codigo);

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
                    var command = new SqlCommand("usp_DELETE_DeduccionPercepciones_ByID");
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
        public static List<DeduccionPercepciones> SelectAll()
        {

            try
            {
                // Declarar el DataSet para extraer los datos;
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    var command = new SqlCommand("usp_SELECT_DeduccionPercepciones_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "DeduccionPercepciones");
                }

                List<DeduccionPercepciones> lista = new List<DeduccionPercepciones>();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        DeduccionPercepciones oDeduccionPercepciones = new DeduccionPercepciones();
                        oDeduccionPercepciones.Codigo = int.Parse(dr["Codigo"].ToString());
                        oDeduccionPercepciones.Nombre = dr["Nombre"].ToString();
                        oDeduccionPercepciones.Tipo = int.Parse(dr["Tipo"].ToString());
                        oDeduccionPercepciones.Valor = double.Parse(dr["Valor"].ToString());
                        oDeduccionPercepciones.TipoValor = int.Parse(dr["TipoValor"].ToString());
                      

                        lista.Add(oDeduccionPercepciones);

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
        public static DeduccionPercepciones SelectById(string Id)
        {

            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    var command = new SqlCommand("usp_SELECT_DeduccionPercepciones_ByID");
                    command.Parameters.AddWithValue("@Codigo", Id);
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "DeduccionPercepciones");
                }


                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Se crea el datatable
                    DataTable dt = ds.Tables[0];
                    DeduccionPercepciones oDeduccionPercepciones = new DeduccionPercepciones();
                    oDeduccionPercepciones.Codigo = int.Parse(dt.Rows[0]["Codigo"].ToString());
                    oDeduccionPercepciones.Nombre = dt.Rows[0]["Nombre"].ToString();
                    oDeduccionPercepciones.Tipo = int.Parse(dt.Rows[0]["Tipo"].ToString());
                    oDeduccionPercepciones.Valor = double.Parse(dt.Rows[0]["Valor"].ToString());
                    oDeduccionPercepciones.TipoValor = int.Parse(dt.Rows[0]["TipoValor"].ToString());

                    return oDeduccionPercepciones;

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
