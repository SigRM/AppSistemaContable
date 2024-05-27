using AppSistemaContable.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Interfaces
{
    interface IDeduccionPercepcionesBLL
    {
        void CREATE(DeduccionPercepciones pDeduccionPercepciones);
        void UPDATE(DeduccionPercepciones pDeduccionPercepciones);
        void DELETE(string Id);
        List<DeduccionPercepciones> SelectAll();
        DeduccionPercepciones SelectById(string Id);
        bool Existe(String id);

    }
}
