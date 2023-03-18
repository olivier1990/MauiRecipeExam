using MauiRecipe.ViewModels;

namespace MauiRecipe;

public partial class MainPage : ContentPage
{
	//Contient Page principale et les méthodes
	public MainPage()
	{
		InitializeComponent();

		BindingContext = new MyBreakfastsViewModel();
	}

	
}

