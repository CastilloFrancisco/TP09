using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP09.Models;
using Newtonsoft.Json;

namespace TP09.Models
{
    public class Juego
    {
        [JsonProperty]
        public List<Usuario> Jugadores { get; set; }

        [JsonProperty]
        public string Palabra { get; set; }

        [JsonProperty]
        public List<Palabra> ListaPalabras { get; set; }

        [JsonProperty]
        public Usuario JugadorActual;

        public Juego()
        {
            Jugadores = new List<Usuario>();
            llenarListaPalabras();
        }

        private void llenarListaPalabras()
        {
            ListaPalabras = new List<Palabra>();

            // Dificultad 1
            ListaPalabras.Add(new Palabra(1, "sol"));
            ListaPalabras.Add(new Palabra(1, "luna"));
            ListaPalabras.Add(new Palabra(1, "flor"));
            ListaPalabras.Add(new Palabra(1, "cielo"));
            ListaPalabras.Add(new Palabra(1, "gato"));
            ListaPalabras.Add(new Palabra(1, "perro"));
            ListaPalabras.Add(new Palabra(1, "agua"));
            ListaPalabras.Add(new Palabra(1, "pan"));
            ListaPalabras.Add(new Palabra(1, "casa"));
            ListaPalabras.Add(new Palabra(1, "mesa"));

            // Dificultad 2
            ListaPalabras.Add(new Palabra(2, "raton"));
            ListaPalabras.Add(new Palabra(2, "computadora"));
            ListaPalabras.Add(new Palabra(2, "pelicula"));
            ListaPalabras.Add(new Palabra(2, "jardin"));
            ListaPalabras.Add(new Palabra(2, "tornado"));
            ListaPalabras.Add(new Palabra(2, "montar"));
            ListaPalabras.Add(new Palabra(2, "avion"));
            ListaPalabras.Add(new Palabra(2, "estrella"));
            ListaPalabras.Add(new Palabra(2, "coche"));
            ListaPalabras.Add(new Palabra(2, "ventana"));

            // Dificultad 3
            ListaPalabras.Add(new Palabra(3, "arqueologia"));
            ListaPalabras.Add(new Palabra(3, "astronauta"));
            ListaPalabras.Add(new Palabra(3, "fotografia"));
            ListaPalabras.Add(new Palabra(3, "hormona"));
            ListaPalabras.Add(new Palabra(3, "desarrollo"));
            ListaPalabras.Add(new Palabra(3, "psicologia"));
            ListaPalabras.Add(new Palabra(3, "superficie"));
            ListaPalabras.Add(new Palabra(3, "tormenta"));
            ListaPalabras.Add(new Palabra(3, "hipoteca"));
            ListaPalabras.Add(new Palabra(3, "escalera"));

            // Dificultad 4
            ListaPalabras.Add(new Palabra(4, "neurociencia"));
            ListaPalabras.Add(new Palabra(4, "biocompatibilidad"));
            ListaPalabras.Add(new Palabra(4, "quimioterapia"));
            ListaPalabras.Add(new Palabra(4, "hiperbole"));
            ListaPalabras.Add(new Palabra(4, "transcendental"));
            ListaPalabras.Add(new Palabra(4, "concomitante"));
            ListaPalabras.Add(new Palabra(4, "morfologia"));
            ListaPalabras.Add(new Palabra(4, "metafisica"));
            ListaPalabras.Add(new Palabra(4, "heterogeneo"));
            ListaPalabras.Add(new Palabra(4, "ortografia"));
        }


        public void inicializarJuego(string usuario, int dificultad)
        {

            Usuario j = new Usuario(0, usuario);
            JugadorActual = j;
            Palabra = cargarPalabra(dificultad);

        }

        private string cargarPalabra(int dificultad)
        {
            Palabra p;
            do
            {
                Random r = new Random();
                p = ListaPalabras[r.Next(1, ListaPalabras.Count)];

            } while (p.dificultad != dificultad);

            return p.texto;
        }

        public void FinJuego(int intentos)
        {
            int n = 0;
            bool encontrado = false;
            do
            {

                if (Jugadores[n].cantidadDeIntentos >= intentos)
                {
                    n++;
                }
                else
                {
                    encontrado = true;
                }

            } while (encontrado || Jugadores[n] == null);

            Jugadores.Insert(n, JugadorActual);
        }



        public List<Usuario> DevolverListaUsuarios()
        {
            return Jugadores.OrderByDescending(a => a.cantidadDeIntentos).ToList();
        }

    }
}
