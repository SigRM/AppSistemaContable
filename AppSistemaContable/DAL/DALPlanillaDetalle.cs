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
    class DALPlanillaDetalle
    {
        #region CREATE
        public static void CREATE(PlanillaDetalle pPlanillaDetalle)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    //   string sql = @"Insert into Usuarios(Identificacion,NombreCompleto,Telefono,FechaNacimiento,Direccion,CorreoElectronico,SalarioCRC,SalarioUSD,Genero,Foto) values (@Identificacion,@NombreCompleto,@Telefono,@FechaNacimiento,@Direccion,@CorreoElectronico,@SalarioCRC,@SalarioUSD,@Genero,@Foto)";
                    //   SqlCommand command = new SqlCommand();
                    var command = new SqlCommand("usp_INSERT_PlanillasDetalle");
                    command.Parameters.AddWithValue("@Id", pPlanillaDetalle.Id);
                    command.Parameters.AddWithValue("@IdEncabezado", pPlanillaDetalle.IdEncabezado);
                    command.Parameters.AddWithValue("@IdColaborador", pPlanillaDetalle.IdColaborador);
                    command.Parameters.AddWithValue("@NombreColaborador", pPlanillaDetalle.NombreColaborador);
                    command.Parameters.AddWithValue("@Tipo", pPlanillaDetalle.Tipo);
                    command.Parameters.AddWithValue("@Codigo", pPlanillaDetalle.Codigo);
                    command.Parameters.AddWithValue("@MontoDeducciones", pPlanillaDetalle.MontoDeducciones);


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
        public static void UPDATE(PlanillaDetalle pPlanillaDetalle)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    //   string sql = @"Insert into Usuarios(Identificacion,NombreCompleto,Telefono,FechaNacimiento,Direccion,CorreoElectronico,SalarioCRC,SalarioUSD,Genero,Foto) values (@Identificacion,@NombreCompleto,@Telefono,@FechaNacimiento,@Direccion,@CorreoElectronico,@SalarioCRC,@SalarioUSD,@Genero,@Foto)";
                    //   SqlCommand command = new SqlCommand();
                    var command = new SqlCommand("usp_UPDATE_PlanillasDetalle");

                    command.Parameters.AddWithValue("@Id", pPlanillaDetalle.Id);

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
                    var command = new SqlCommand("usp_DELETE_PlanillasDetalle_ByID");
                    command.Parameters.AddWithValue("@Id", Id);
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
        public static List<PlanillaDetalle> SelectAll()
        {

            try
            {
                // Declarar el DataSet para extraer los datos;
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    var command = new SqlCommand("usp_SELECT_PlanillasDetalle_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "PlanillaDetalle");
                }

                List<PlanillaDetalle> lista = new List<PlanillaDetalle>();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        PlanillaDetalle oPlanillaDetalle = new PlanillaDetalle();
                        oPlanillaDetalle.Id = int.Parse(dr["Id"].ToString());
                        oPlanillaDetalle.IdEncabezado = int.Parse(dr["IdEncabezado"].ToString());
                        oPlanillaDetalle.IdEncabezado = int.Parse(dr["IdEncabezado"].ToString());
                        oPlanillaDetalle.NombreColaborador = dr["NombreColaborador"].ToString();
                        oPlanillaDetalle.Tipo = int.Parse(dr["Tipo"].ToString());
                        oPlanillaDetalle.Codigo = int.Parse(dr["Codigo"].ToString());
                        oPlanillaDetalle.MontoDeducciones = double.Parse(dr["MontoDeducciones"].ToString());

                        lista.Add(oPlanillaDetalle);

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
        public static PlanillaDetalle SelectById(string Id)
        {

            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    var command = new SqlCommand("usp_SELECT_PlanillasDetalle_ByID");
                    command.Parameters.AddWithValue("@Identificacion", Id);
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "PlanillaDetalle");
                }


                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Se crea el datatable
                    DataTable dt = ds.Tables[0];
                    PlanillaDetalle oPlanillaDetalle = new PlanillaDetalle();
                    oPlanillaDetalle.Id = int.Parse(dt.Rows[0]["Id"].ToString());
                    oPlanillaDetalle.IdEncabezado = int.Parse(dt.Rows[0]["IdEncabezado"].ToString());
                    oPlanillaDetalle.IdEncabezado = int.Parse(dt.Rows[0]["IdEncabezado"].ToString());
                    oPlanillaDetalle.NombreColaborador = dt.Rows[0]["NombreColaborador"].ToString();
                    oPlanillaDetalle.Tipo = int.Parse(dt.Rows[0]["Tipo"].ToString());
                    oPlanillaDetalle.Codigo = int.Parse(dt.Rows[0]["Codigo"].ToString());
                    oPlanillaDetalle.MontoDeducciones = double.Parse(dt.Rows[0]["MontoDeducciones"].ToString());

                    return oPlanillaDetalle;

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
