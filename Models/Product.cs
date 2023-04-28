using System.Text.Json.Serialization;

namespace MauiRecipe.Models;

public class Product
{
    public string Code { get; set; }

    public string Url { get; set; }

    [JsonPropertyName("product_name")]
    public string ProductName { get; set; }

    public string GenericName { get; set; }

    public string Quantity { get; set; }

    [JsonPropertyName("ingredients_text")]
    public string IngredientsText { get; set; }

    public string Brands { get; set; }

    [JsonPropertyName("nutriscore_grade")]
    public string NustriscoreGrade { get; set; }

    public string NustriscoreGradeImage
    {
        get => $"nutriscore_{NustriscoreGrade}.png";
    }

    [JsonPropertyName("image_url")]
    public string ImageUrl { get; set; }
}    




    //public partial class Recipe
    //{
    //    [JsonProperty("title")]
    //    public string Title { get; set; }

    //    [JsonProperty("ingredients")]
    //    public string Ingredients { get; set; }

    //    [JsonProperty("servings")]
    //    public string Servings { get; set; }

    //    [JsonProperty("instructions")]
    //    public string Instructions { get; set; }
    //}


