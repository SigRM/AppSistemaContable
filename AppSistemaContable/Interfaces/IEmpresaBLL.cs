using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Interfaces
{
    interface IEmpresaBLL
    {
        void CREATE(Empresa pEmpresa);
        void UPDATE(Empresa pEmpresa);
        void DELETE(string Id);
        List<Empresa> SelectAll();
        Empresa SelectById(string Id);
        bool Existe(String id);
    }
}
