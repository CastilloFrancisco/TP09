using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP09.Models;
using Newtonsoft.Json;

namespace TP09.Models
{
    public class Usuario
    {
        [JsonProperty]
        public string nombre { get; set; }

        [JsonProperty]
        public int cantidadDeIntentos { get; set; }

        public Usuario(int pIntentos, string pNombre)
        {
            nombre = pNombre;

            cantidadDeIntentos = pIntentos;

        }

    }
}