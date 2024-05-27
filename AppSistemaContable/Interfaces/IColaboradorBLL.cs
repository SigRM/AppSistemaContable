using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Interfaces
{
    interface IColaboradorBLL
    {
        void CREATE(Colaboradores usuarios);
        void UPDATE(Colaboradores pColaboradores);
        void DELETE(string Id);
        List<Colaboradores> SelectAll();
        Colaboradores SelectById(string Id);
        bool Existe(String id);

    }
}
