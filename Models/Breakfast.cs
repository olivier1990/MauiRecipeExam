namespace MauiRecipe.Models;

// PQ record ? Parce que son Seul objectif est de contenir du data
public record Breakfast(
    string Title,
    string Ingredients,
    string Servings,
    string Instructions,
    Uri Image
    //DateTime StartDateTime,
    //DateTime EndDateTime,

    //List<string> Savory,
    //List<string> Sweet
    );


