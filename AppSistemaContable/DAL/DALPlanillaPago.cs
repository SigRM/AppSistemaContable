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
    class DALPlanillaPago
    {
        #region CREATE
        public static void CREATE(PlanillaPago pPlanillaPago)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    //   string sql = @"Insert into Usuarios(Identificacion,NombreCompleto,Telefono,FechaNacimiento,Direccion,CorreoElectronico,SalarioCRC,SalarioUSD,Genero,Foto) values (@Identificacion,@NombreCompleto,@Telefono,@FechaNacimiento,@Direccion,@CorreoElectronico,@SalarioCRC,@SalarioUSD,@Genero,@Foto)";
                    //   SqlCommand command = new SqlCommand();
                    var command = new SqlCommand("usp_INSERT_PlanillasPago");
                    command.Parameters.AddWithValue("@Id", pPlanillaPago.Id);
                    command.Parameters.AddWithValue("@NombrePlanilla", pPlanillaPago.NombrePlanilla);
                    command.Parameters.AddWithValue("@FechaDesde", pPlanillaPago.FechaDesde);
                    command.Parameters.AddWithValue("@FechaHasta", pPlanillaPago.FechaHasta);
                    command.Parameters.AddWithValue("@FechaPago", pPlanillaPago.FechaPago);
                    command.Parameters.AddWithValue("@EmpresaId", pPlanillaPago.EmpresaId);
                    command.Parameters.AddWithValue("@Estado", pPlanillaPago.Estado);


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
        public static void UPDATE(PlanillaPago pPlanillaPago)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    //   string sql = @"Insert into Usuarios(Identificacion,NombreCompleto,Telefono,FechaNacimiento,Direccion,CorreoElectronico,SalarioCRC,SalarioUSD,Genero,Foto) values (@Identificacion,@NombreCompleto,@Telefono,@FechaNacimiento,@Direccion,@CorreoElectronico,@SalarioCRC,@SalarioUSD,@Genero,@Foto)";
                    //   SqlCommand command = new SqlCommand();
                    var command = new SqlCommand("usp_UPDATE_PlanillasPago");

                    command.Parameters.AddWithValue("@Id", pPlanillaPago.Id);

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
                    var command = new SqlCommand("usp_DELETE_PlanillasPago_ByID");
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
        public static List<PlanillaPago> SelectAll()
        {

            try
            {
                // Declarar el DataSet para extraer los datos;
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    var command = new SqlCommand("usp_SELECT_PlanillasPago_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "PlanillaPago");
                }

                List<PlanillaPago> lista = new List<PlanillaPago>();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        PlanillaPago oPlanillaPago = new PlanillaPago();
                        oPlanillaPago.Id = int.Parse(dr["Id"].ToString());
                        oPlanillaPago.NombrePlanilla = dr["NombrePlanilla"].ToString();
                        oPlanillaPago.FechaDesde = DateTime.Parse(dr["FechaDesde"].ToString());
                        oPlanillaPago.FechaHasta = DateTime.Parse(dr["FechaHasta"].ToString());
                        oPlanillaPago.FechaPago = DateTime.Parse(dr["FechaPago "].ToString());
                        oPlanillaPago.EmpresaId = int.Parse(dr["EmpresaId"].ToString());
                        oPlanillaPago.Estado = bool.Parse(dr["Estado"].ToString());

                        lista.Add(oPlanillaPago);

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
        public static PlanillaPago SelectById(string Id)
        {

            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    var command = new SqlCommand("usp_SELECT_PlanillasPago_ByID");
                    command.Parameters.AddWithValue("@Id", Id);
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "PlanillaPago");
                }


                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Se crea el datatable
                    DataTable dt = ds.Tables[0];
                    PlanillaPago oPlanillaPago = new PlanillaPago();
                    oPlanillaPago.Id = int.Parse(dt.Rows[0]["Id"].ToString());
                    oPlanillaPago.NombrePlanilla = dt.Rows[0]["NombrePlanilla"].ToString();
                    oPlanillaPago.FechaDesde = DateTime.Parse(dt.Rows[0]["FechaDesde"].ToString());
                    oPlanillaPago.FechaHasta = DateTime.Parse(dt.Rows[0]["FechaHasta"].ToString());
                    oPlanillaPago.FechaPago = DateTime.Parse(dt.Rows[0]["FechaPago "].ToString());
                    oPlanillaPago.EmpresaId = int.Parse(dt.Rows[0]["EmpresaId"].ToString());
                    oPlanillaPago.Estado = bool.Parse(dt.Rows[0]["Estado"].ToString());


                    return oPlanillaPago;

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
