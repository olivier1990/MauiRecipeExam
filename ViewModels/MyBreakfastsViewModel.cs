using CommunityToolkit.Mvvm.ComponentModel;
using MauiRecipe.Models;


namespace MauiRecipe.ViewModels;
// Contient la List/le Data qui se retrouve dans la VIEW
// ObservableObject Build la propriété public pour nous
// partial de la classe, permet de divisé la classe en 2 définition par exemple une struct et une interface
// Utilisé quand ? lorsqu'on génère du source code automatiquement comme dans ce fichier-ci. 
public partial class MyBreakfastsViewModel : ObservableObject
{
    [ObservableProperty]
    List<Breakfast> breakfasts;

    public MyBreakfastsViewModel()
    {
        LoadBreakfasts();
    }

    private void LoadBreakfasts()
    {
        //vient de ligne 14[observableproperty]
        Breakfasts = new()
        {
            new Breakfast(
                Title: "italian wedding soup",
                Ingredients: "1/2 lb ground beef|1/2 lb ground veal|1/4 c italian seasoned bread crumb|1 egg|1 tb parsley|salt and pepper to taste|4 c chicken broth|2 c spinach leaves cut into piec|1/4 c grated pecorino romano chees",
                Servings: "1 servings",
                Instructions: "combine the ground meat, bread crumbs, egg, parsley, salt and pepper in a bowl. mix well and form into tiny meat balls. bake on a cookie sheet for 30 minutes at 350f. meanwhile, bring broth to a boil and add spinach. cover and boil for 5 minutes. add the meatballs to the hot broth, bring to a simmer. stir in the cheese and serve immediately. rita in scottsdale 01/02/92 01:41 am",
                Image: new Uri("C:\\Users\\olivi\\source\\repos\\MauiRecipe\\MauiRecipe\\Resources\\")
            ),
            new Breakfast(
                Title: "stracciatella (italian wedding soup)",
                Ingredients: "1 lb fresh spinach, washed and chopped|1 egg|1 c parmesan cheese, * see note|salt, to taste|pepper, to taste",
                Servings: "6 servings",
                Instructions: "bring 1 cup of the broth to a boil. add spinach and cook until softened but still bright green. remove spinach with a slotted spoon and set aside. add remaining broth to pot. bring to a boil. meanwhile, beat egg lightly with a fork. beat in 1/4 cup of cheese. when broth boils pour in egg mixture, stirring constantly for a few seconds until it cooks into rags. add reserved spinach, salt and pepper. serve immediately, passing remaining cheese.",
                Image: new Uri("C:\\Users\\olivi\\source\\repos\\MauiRecipe\\MauiRecipe\\Resources\\")
            )
        };




    }
}

