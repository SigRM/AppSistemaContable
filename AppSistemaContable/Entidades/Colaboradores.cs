using AppSistemaContable.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Entidades
{
    public class Colaboradores
    {
        public string Identificacion { set; get; }
        public string Nombre { set; get; }
        public string Apellidos { set; get; }
        public DateTime FechaNacimiento { set; get; }
        public string Direccion { set; get; }
        public DateTime FechaIngreso { set; get; }
        public string Departamento { set; get; }
        public decimal SalarioHora { set; get; }
        public byte[] Fotografia { set; get; }
        public string CorreoElectronico { set; get; }
        public int SupervisorACargo { set; get; }
        public string CuentaIBAN { set; get; }
        public string Usuario { set; get; }
        public string Contrasena { set; get; }
        public bool Estado { set; get; }
        public Roles Rol { set; get; }
        public Puestos Puesto { set; get; }
        public string rol1 { set; get; }

        public static Colaboradores _Usuario;


        public Colaboradores() { }

        public static Colaboradores GetInstance()
        {
            if (_Usuario == null)
                _Usuario = new Colaboradores();
            return _Usuario;
        }

        public override string ToString()
        {
            return this.Rol.ToString();
        }

        public String mostrarPuestoGrid
        {
            get
            {
                return this.Puesto.Codigo.ToString();
            }
        }

        public String mostrarRolesGrid
        {
            get
            {
                return this.Rol.Codigo.ToString();
            }
        }
        public decimal CalcularSalarioTotal(Colaboradores colaborador, int horasTrabajadas)
        {
            return colaborador.SalarioHora * horasTrabajadas;
        }

    }
}
