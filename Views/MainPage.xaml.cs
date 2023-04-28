namespace MauiRecipe.Views;

public partial class MainPage : ContentPage
{

    ProductsViewModel viewModel;

    //Contient Page principale et les méthodes
    public MainPage(ProductsViewModel viewModel)
    {
        InitializeComponent();


        this.viewModel = viewModel;
        BindingContext = viewModel;
    }

    protected override async void OnAppearing()
    {
        productsCollection.ItemsSource = viewModel.Products;

        if (viewModel.FirstRun && viewModel.GetRandomProductsCommand.CanExecute(null))
        {
            await viewModel.GetRandomProductsCommand.ExecuteAsync(null);
            viewModel.FirstRun = false;
        }

        base.OnAppearing();
    }

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        if (!string.IsNullOrEmpty(viewModel.SearchTerm))
        {
            await viewModel.SearchProductsCommand.ExecuteAsync(null);
        }

        if (Parent is ShellSection && ((ShellSection)Parent).Route == nameof(SearchPage))
        {
            viewModel.Title = viewModel.SearchedTitle;
            productsCollection.ItemsSource = viewModel.SearchedProducts;
        }
        else
        {
            viewModel.Title = "Produits";
            productsCollection.ItemsSource = viewModel.Products;
        }

        base.OnNavigatedTo(args);
    }
}

