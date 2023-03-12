using exam_poo.DataServices;
using exam_poo.ViewModel;
using Microsoft.Maui.Controls;

namespace exam_poo;

public partial class MainPage : ContentPage
{
    private IRestDataService _dataService;

    public MainPage(IRestDataService dataService)
	{
		InitializeComponent();

        _dataService = dataService;

		BindingContext = new RecipeViewModel();
    }
	//private void searchbar_textchanged(object sender, textchangedeventargs e)
	//{
	//	mylistview.itemssource mylist.where(s => s.name.startswith(e.newtextvalue));
	//}
	
}

