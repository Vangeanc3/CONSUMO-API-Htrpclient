using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace consumo
{
    public class GerenciaService
    {
        public async Task<Gerencia> GetGerenciaPorId(int id)
        {
            var url = "https://localhost:7051/Gerencia";
            HttpClient httpClient = new();
            var response = await httpClient.GetAsync($"{url}/{id}");
            var jsonstring = await response.Content.ReadAsStringAsync();
            var jsonobject = JsonConvert.DeserializeObject<Gerencia>(jsonstring);
        
            if (jsonobject != null)
            {
                return jsonobject;
            }
            return new Gerencia 
            {
                Verificacao = true
            };
        }
        public async Task PostGerencia()
        {
            using(var httpClient = new HttpClient())
            {
                var url = "https://localhost:7051/Gerencia";
                var response = await httpClient.PostAsJsonAsync(url, new Gerencia{Nome = "GECAL", Departamento = "SUSIS"});
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Ok");
                } 
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
        // public async Task GetGerencia()
        // {
        //     using(var httpClient = new HttpClient())
        //     {
        //         var url = "https://localhost:7051/Gerencia";
        //         var response = await httpClient.GetAsync(url);
        //         if (response.IsSuccessStatusCode)
        //         {
        //         var gerentes = JsonSerializer
        //         }
        //     }
        // }
    }
}