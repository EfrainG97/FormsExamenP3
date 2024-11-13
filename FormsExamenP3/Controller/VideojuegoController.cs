using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FormsExamenP3.Model;
using Newtonsoft.Json;

namespace FormsExamenP3.Controller
{
    internal class VideojuegoController : IVideojuego
    {
        private static HttpClient CrearCliente()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7138/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return httpClient;
        }

        private static readonly HttpClient client = CrearCliente();


        public async Task<bool> ActualizarJuego(int id, Videojuego videojuego)
        {
            var json = JsonConvert.SerializeObject(videojuego);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PutAsync($"api/Videojuego/{id}", content);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> AgregarJuego(Videojuego videojuego)
        {
            var json = JsonConvert.SerializeObject(videojuego);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("api/Videojuego", content);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> EliminarJuego(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"api/Videojuego/{id}");
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<List<Videojuego>> GetVideojuegos()
        {
            HttpResponseMessage response = await client.GetAsync("api/Videojuego");
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var juegos = JsonConvert.DeserializeObject<List<Videojuego>>(jsonResponse);
                return juegos;
            }
            return new List<Videojuego>();
        }

        public async Task<Videojuego> ObtenerVideojuegoID(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"api/Videojuego/{id}");
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var juegos = JsonConvert.DeserializeObject<Videojuego>(jsonResponse);
                return juegos;
            }
            return null;
        }
    }
}
