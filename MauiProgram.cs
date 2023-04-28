namespace MauiRecipe;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        //Mettre la page detail en AddTransient peut être ? pour ne pas l'avoir enregistré
        builder.Services.AddSingleton<ProductService>();

        builder.Services.AddSingleton<ProductsViewModel>();
        builder.Services.AddTransient<MainPage>();

        builder.Services.AddSingleton<ProductsSearchViewModel>();
        builder.Services.AddSingleton<SearchPage>();

        builder.Services.AddTransient<ProductDetailsViewModel>();
        builder.Services.AddTransient<DetailsPage>();


//Faut-il enlever ceci lorsque l'app est released ?
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
