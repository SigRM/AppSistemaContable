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
    class DALPlanillaEncabezado
    {
        #region CREATE
        public static void CREATE(PlanillaEncabezado pPlanillaEncabezado)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    //   string sql = @"Insert into Usuarios(Identificacion,NombreCompleto,Telefono,FechaNacimiento,Direccion,CorreoElectronico,SalarioCRC,SalarioUSD,Genero,Foto) values (@Identificacion,@NombreCompleto,@Telefono,@FechaNacimiento,@Direccion,@CorreoElectronico,@SalarioCRC,@SalarioUSD,@Genero,@Foto)";
                    //   SqlCommand command = new SqlCommand();
                    var command = new SqlCommand("usp_INSERT_PlanillaEncabezado");
                    command.Parameters.AddWithValue("@Id", pPlanillaEncabezado.Id);
                    command.Parameters.AddWithValue("@IdPlanillaPago", pPlanillaEncabezado.IdPlanillaPago);
                    command.Parameters.AddWithValue("@TipoCambio", pPlanillaEncabezado.TipoCambio);
                    command.Parameters.AddWithValue("@TotalIngresos", pPlanillaEncabezado.TotalIngresos);
                    command.Parameters.AddWithValue("@TotalGastos", pPlanillaEncabezado.TotalGastos);
                    command.Parameters.AddWithValue("@TotalPagar", pPlanillaEncabezado.TotalPagar);
                    command.Parameters.AddWithValue("@SalarioNeto", pPlanillaEncabezado.SalarioNeto);
                    command.Parameters.AddWithValue("@TotalPagarUSD", pPlanillaEncabezado.TotalPagarUSD);


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
        public static void UPDATE(PlanillaEncabezado pPlanillaEncabezado)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    //   string sql = @"Insert into Usuarios(Identificacion,NombreCompleto,Telefono,FechaNacimiento,Direccion,CorreoElectronico,SalarioCRC,SalarioUSD,Genero,Foto) values (@Identificacion,@NombreCompleto,@Telefono,@FechaNacimiento,@Direccion,@CorreoElectronico,@SalarioCRC,@SalarioUSD,@Genero,@Foto)";
                    //   SqlCommand command = new SqlCommand();
                    var command = new SqlCommand("usp_UPDATE_PlanillaEncabezado");

                    command.Parameters.AddWithValue("@Id", pPlanillaEncabezado.Id);

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
                    var command = new SqlCommand("usp_DELETE_PlanillaEncabezado_ByID");
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
        public static List<PlanillaEncabezado> SelectAll()
        {

            try
            {
                // Declarar el DataSet para extraer los datos;
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    var command = new SqlCommand("usp_SELECT_PlanillaEncabezado_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "PlanillaEncabezado");
                }

                List<PlanillaEncabezado> lista = new List<PlanillaEncabezado>();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        PlanillaEncabezado oPlanillaEncabezado = new PlanillaEncabezado();
                        oPlanillaEncabezado.Id = int.Parse(dr["Id"].ToString());
                        oPlanillaEncabezado.IdPlanillaPago = int.Parse(dr["IdPlanillaPago"].ToString());
                        oPlanillaEncabezado.TipoCambio = int.Parse(dr["TipoCambio"].ToString());
                        oPlanillaEncabezado.TotalIngresos = double.Parse(dr["TotalIngresos"].ToString());
                        oPlanillaEncabezado.TotalGastos = double.Parse(dr["TotalGastos"].ToString());
                        oPlanillaEncabezado.TotalPagar = double.Parse(dr["TotalPagar"].ToString());
                        oPlanillaEncabezado.SalarioNeto = double.Parse(dr["SalarioNeto"].ToString());
                        oPlanillaEncabezado.TotalPagarUSD = double.Parse(dr["TotalPagarUSD"].ToString());

                        lista.Add(oPlanillaEncabezado);

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
        public static PlanillaEncabezado SelectById(string Id)
        {

            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    var command = new SqlCommand("usp_SELECT_PlanillaEncabezado_ByID");
                    command.Parameters.AddWithValue("@Id", Id);
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "PlanillaEncabezado");
                }


                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Se crea el datatable
                    DataTable dt = ds.Tables[0];
                    PlanillaEncabezado oPlanillaEncabezado = new PlanillaEncabezado();
                    oPlanillaEncabezado.Id = int.Parse(dt.Rows[0]["Id"].ToString());
                    oPlanillaEncabezado.IdPlanillaPago = int.Parse(dt.Rows[0]["IdPlanillaPago"].ToString());
                    oPlanillaEncabezado.TipoCambio = int.Parse(dt.Rows[0]["TipoCambio"].ToString());
                    oPlanillaEncabezado.TotalIngresos = double.Parse(dt.Rows[0]["TotalIngresos"].ToString());
                    oPlanillaEncabezado.TotalGastos = double.Parse(dt.Rows[0]["TotalGastos"].ToString());
                    oPlanillaEncabezado.TotalPagar = double.Parse(dt.Rows[0]["TotalPagar"].ToString());
                    oPlanillaEncabezado.SalarioNeto = double.Parse(dt.Rows[0]["SalarioNeto"].ToString());
                    oPlanillaEncabezado.TotalPagarUSD = double.Parse(dt.Rows[0]["TotalPagarUSD"].ToString());

                    return oPlanillaEncabezado;

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
