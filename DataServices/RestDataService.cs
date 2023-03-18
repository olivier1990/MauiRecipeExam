using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MauiRecipe.Models;


namespace exam_poo.DataServices
{
    public class RestDataService : IRestDataService
    {

        private readonly HttpClient _httpClient;
        private readonly string _baseAddress;
        private readonly string _url;
        private readonly JsonSerializerOptions _jsonSerializerOptions;

        public RestDataService(HttpClient httpClient)
        {
            //_httpClient = new HttpClient();
            _httpClient = httpClient;
            //Nom serveur jusqu'au Port,    TOFix sans guillement fonctionne pas, PQ ?
            _baseAddress = $"https://api.api-ninjas.com";
            //Contient l'ip + /api
            _url = $"{_baseAddress}/api";

            _jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
        }

        public async Task<List<Recipe>> GetAllRecipeAsync()
        {
            List<Recipe> recipes = new List<Recipe>();

            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
            {
                Debug.WriteLine("---> Pas d'access internet...");
                return recipes;
            }

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"{_url}/v1/recipe?query=\r\n");

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();

                    recipes = JsonSerializer.Deserialize<List<Recipe>>(content, _jsonSerializerOptions);
                }
                else
                {
                    Debug.WriteLine("---> Pas de réponse Http 2xx ");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"error exception: {ex.Message}");
            }

            return recipes;
        }



        public async Task AddRecipeAsync(Recipe recipe)
        {


        }

        public async Task DeleteRecipeAsync(int id)
        {

        }



        public async Task UpdateRecipeAsync(Recipe recipe)
        {

        }
    }
}