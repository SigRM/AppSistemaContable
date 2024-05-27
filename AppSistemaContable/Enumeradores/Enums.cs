using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Enumeradores
{
    class Enums
    {
        public enum Estado
        {
            Activo = 'A',
            Inactivo = 'I'
        }

        public enum EstadoVacaciones
        {
            Activo = 'A',
            Inactivo = 'I'
        }

        public enum Genero
        {
            Femenino = 'F',
            Masculino = 'M'
        }

        public enum CRUD
        {
            Create = 'C',
            Read = 'R',
            Update = 'U',
            Delete = 'D'
        }

        public enum EstadoPlanilla
        {
            Activo,
            Inactivo,
            Enviada,
            PorEnviar
        }

        public enum TipoIdentificacion
        {
            Juridica,
            Fisica
        }

        public enum TipoValor
        {
            Porcentaje , //calculo como ejemplo la CSS 9.67 tipo porcentual
            Absoluto //valor monetario unico fijo
        }

        public enum TipoDeduccionPercepcion
        {
            Percepcion,//Ingreso que percibe el colaborador como salario ordinario, horas extras, bonos, comisiones
            Deduccion //Gastos - Salidas como la caja --pension, embargo **caja y asociacion para project defensa***
        }

        public enum Prioridad
        {
            Alta = '1',
            Media = '2',
            Baja = '3'
           
        }

        public enum RolesColaborador
        {
            Administrador,
            Supervisor,
            Colaborador 
        }

        public enum Puesto
        {
            Gerente,
            Asistente,
            Analista,
            SoporteTecnico,
            Contador,
            // Los espacios no son válidos en nombres de enum, se usan CamelCase o guiones bajos
        }



    }
}
