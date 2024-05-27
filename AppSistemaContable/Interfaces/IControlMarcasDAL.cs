using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Interfaces
{
    interface IControlMarcasDAL
    {
        List<ControlMarcas> SelectAll();
        void DELETE();
        void CREATE(ControlMarcas controlMarcas);
    }
}
