using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Interfaces
{
    interface IColaboradorDAL
    {
        void CREATE(Colaboradores colaboradores);
        void UPDATE(Colaboradores colaboradores);
        void DELETE(string Id);
        List<Colaboradores> SelectAll();
        Colaboradores SelectById(string Id);
    }
}
