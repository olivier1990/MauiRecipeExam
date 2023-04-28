namespace MauiRecipe.Views;

public partial class DetailsPage : ContentPage
{
    public DetailsPage(ProductDetailsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}