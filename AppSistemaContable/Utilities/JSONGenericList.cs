using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaContable.Utilities
{
    public class JSONGenericList<T>
    {
        /// <summary>
        /// Metodo Generic para crear lista de Objetos desde Json
        /// </summary>
        /// <param name="pDatos"></param>
        /// <returns></returns>
        public static List<T> JSonToList(string pDatos)
        {
            List<T> listaJSON = JsonConvert.DeserializeObject<List<T>>(pDatos);
            return listaJSON;
        }

        /// <summary>
        /// Convierte de Lista a string
        /// </summary>
        /// <param name="pLista"></param>
        /// <returns></returns>
        public static string ListToJson(List<T> pLista)
        {

            string datosJson = "";
            datosJson = JsonConvert.SerializeObject(pLista);

            return datosJson;

        }
    }
}
