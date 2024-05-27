using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Entidades
{
    public class PlanillaEncabezado
    {
        public int Id { set; get; }
        public int IdPlanillaPago { set; get; }
        public int TipoCambio { set; get; }
        public double TotalIngresos { set; get; }
        public double TotalGastos { set; get; }
        public double TotalPagar { set; get; }
        public double SalarioNeto { set; get; }
        public double TotalPagarUSD { set; get; }

        public decimal CalcularSalarioNeto(decimal salarioBruto, decimal deducciones)
        {
            // Cálculo de ejemplo, reemplazar con la lógica real
            return salarioBruto - deducciones;
        }

        public decimal CalcularDeducciones(decimal salarioBruto)
        {
            // Espacio reservado: implementar los cálculos de deducciones reales
            return salarioBruto * 0.09M;  // Tasa de deducción de ejemplo
        }


    }
}
