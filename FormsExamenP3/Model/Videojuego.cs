using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsExamenP3.Model
{
    internal class Videojuego
    {
        public Videojuego(int iD, string nombre, string genero, string plataforma, double precio)
        {
            ID = iD;
            Titulo = nombre;
            Genero = genero;
            Plataforma = plataforma;
            Precio = precio;
        }

        public Videojuego() { }

        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Plataforma { get; set; }
        public double Precio { get; set; }
    }
}
