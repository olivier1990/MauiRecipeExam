namespace MauiRecipe;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        //Route
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
    }
}