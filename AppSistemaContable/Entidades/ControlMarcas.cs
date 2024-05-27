using AppSistemaContable.Utilitarios;
using AppSistemaContable.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSistemaContable.Entidades
{
    public class ControlMarcas
    {

        public int Id { set; get; }
        public string Fecha { set; get; }
        public int IdColaborador { set; get; }
        public string HoraEntrada { set; get; }
        public string HoraSalida { set; get; }
        public double HrsTrabajadas { set; get; }


        public void ObtenerMarcas(string ruta)
        {
            int contador = 0;
            List<ControlMarcas> lista = new List<ControlMarcas>();

            string jsonDatos = "";
            jsonDatos = File.ReadAllText(ruta);
            lista = JSONGenericObject<List<ControlMarcas>>.JSonToObject(jsonDatos);

            //Se borra el contenido de la tabla de control de marcas
            BLL.BLLControlMarcas.DELETE();
            //Se recorre la lista pra enviar a guardar
            foreach(var item in lista)
            {
                ControlMarcas control = new ControlMarcas();
                control.Id = item.Id;
                control.Fecha = item.Fecha;
                control.IdColaborador = item.IdColaborador;
                control.HoraEntrada = item.HoraEntrada;
                control.HoraSalida = item.HoraSalida;
                control.HrsTrabajadas = item.HrsTrabajadas;

                DateTime tiempo1 = Convert.ToDateTime(item.HoraEntrada);
                DateTime tiempo2 = Convert.ToDateTime(item.HoraSalida);
                double horas = Math.Abs(Math.Round(tiempo2.Subtract(tiempo1).TotalHours, 1));

                control.HrsTrabajadas = horas;
                BLL.BLLControlMarcas.CREATE(control);
                contador++;
            }
            MessageBox.Show("Se procesaron " + contador + " registros");

        }
            
         


        }

    }


