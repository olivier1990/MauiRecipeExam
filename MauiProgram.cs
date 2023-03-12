using exam_poo.DataServices;
using Microsoft.Extensions.Logging;

namespace exam_poo;

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

        //builder.Services.AddHttpClient<IRestDataService, RestDataService>();

        //Ajout en Global Interface du RestData et class RestData
        builder.Services.AddSingleton<IRestDataService, RestDataService>();

		//Ajout en singleton pour injection dépendance
		builder.Services.AddSingleton<MainPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
