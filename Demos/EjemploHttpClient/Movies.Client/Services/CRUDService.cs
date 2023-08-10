using Movies.Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Client.Services
{
    // 1-Crear clase para la respuesta
    // 2-Crear httpclient
    // 3-Establecer ruta base -> http://www.boredapi.com
    // 4-GetAsync("/api/activity/")
    // 5-Deserializar



    public class CRUDService : IIntegrationService
    {
        private static HttpClient _httpClient = new HttpClient();

        public CRUDService()
        {
          _httpClient.BaseAddress = new Uri("http://www.boredapi.com");
        }


        public async Task Run()
        {
            await EjemploGet();
        }

        private async Task EjemploGet()
        {
            //var response = await _httpClient.GetAsync("api/movies");

            var response = await _httpClient.GetAsync("/api/activity/");

             response.EnsureSuccessStatusCode();

               var content = await response.Content.ReadAsStringAsync();

            //var movies = new List<Movie>();

            // movies = JsonConvert.DeserializeObject<List<Movie>>(content);

            var actividad = new Actividad();

            actividad = JsonConvert.DeserializeObject<Actividad>(content);

        }
    }
}
