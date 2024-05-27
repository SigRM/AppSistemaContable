using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Interfaces
{
    interface IRolesDAL
    {
        void CREATE(Roles pRoles);
        void UPDATE(Roles pRoles);
        void DELETE(string Id);
        List<Roles> SelectAll();
        Roles SelectById(string Id);
    }
}
