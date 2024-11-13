using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsExamenP3.Model;

namespace FormsExamenP3.Controller
{
    internal interface IVideojuego
    {
        Task<List<Videojuego>> GetVideojuegos();

        Task<bool> AgregarJuego(Videojuego videojuego);

        Task<bool> EliminarJuego(int id);

        Task<bool> ActualizarJuego(int id, Videojuego videojuego);

        Task<Videojuego> ObtenerVideojuegoID(int id);
    }
}
