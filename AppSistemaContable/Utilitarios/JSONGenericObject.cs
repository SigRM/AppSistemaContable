using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Utilitarios
{
    class JSONGenericObject<T>
    {
        public static T JSonToObject(string pDatos)
        {

            T @object = (T)JsonConvert.DeserializeObject<T>(pDatos);

            return @object;

        }
    }
}
