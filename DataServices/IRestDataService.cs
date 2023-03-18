using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiRecipe.Models;

namespace exam_poo.DataServices
{
    public interface IRestDataService
    {
        //On fetch les données de l'api
        Task<List<Recipe>> GetAllRecipeAsync();
        //Ajout en Favoris
        Task AddRecipeAsync(Recipe recipe);
        Task UpdateRecipeAsync(Recipe recipe);
        Task DeleteRecipeAsync(int id);
    }
}
