using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Interfaces
{
    interface IDeduccionesPercepcionesColaboradorBLL
    {
        void CREATE(DeduccionesPercepcionesColaborador pDeduccionesPercepcionesColaborador);
        void UPDATE(DeduccionesPercepcionesColaborador pDeduccionesPercepcionesColaborador);
        void DELETE(string Id);
        List<DeduccionesPercepcionesColaborador> SelectAll();
        DeduccionesPercepcionesColaborador SelectById(string Id);
        bool Existe(String id);
    }
}
