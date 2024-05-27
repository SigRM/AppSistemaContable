using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Interfaces
{
    interface IPuestosDAL
    {
        void CREATE(Puestos pPuestos);
        void UPDATE(Puestos pPuestos);
        void DELETE(string Id);
        List<Puestos> SelectAll();
        Puestos SelectById(string Id);

    }
}
