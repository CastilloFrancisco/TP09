using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP09.Models;
using Newtonsoft.Json;

namespace TP09.Models
{
    public class Palabra
    {
        [JsonProperty]
        public string texto { get; set; }

        [JsonProperty]
        public int dificultad { get; set; }

        public Palabra(int pDificultad, string pTexto)
        {
            texto = pTexto;
            dificultad = pDificultad;
        }

    }
}