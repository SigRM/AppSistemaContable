using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Interfaces
{
    interface IRolesBLL
    {
        void CREATE(Roles proles);
        void UPDATE(Roles proles);
        void DELETE(string Id);
        List<Roles> SelectAll();
        Roles SelectById(string Id);
        bool Existe(String id);
    }
}
