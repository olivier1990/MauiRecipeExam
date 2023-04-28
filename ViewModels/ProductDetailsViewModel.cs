namespace MauiRecipe.ViewModels;

[QueryProperty("Product", "Product")]
public partial class ProductDetailsViewModel : BaseViewModel
{
    //equivalent de  get => product; set => SetProperty(ref product, value);    Reduce the amount of boilerplate
    [ObservableProperty]
    Product product;
    //Implementation Icommand   Permet de lier les viewmodel avec les élements ui, dans la views lier au Command=""
    [RelayCommand]
    async Task OpenProductAsync(Product product)
    {
        if (product is null)
            return;

        try
        {
            Uri uri = new(product.Url);
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("Error", "Impossible d'ouvrir le browser", "OK");
        }
    }
}
