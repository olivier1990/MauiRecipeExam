namespace MauiRecipe.ViewModels;

// Contient la List/le Data qui se retrouve dans la VIEW
// ObservableObject Build la propriété public pour nous
// partial de la classe, permet de divisé la classe en 2 définition par exemple une struct et une interface
// Utilisé quand ? lorsqu'on génère du source code automatiquement comme dans ce fichier-ci. 
public partial class BaseViewModel: ObservableObject
{
    public BaseViewModel()
    {

    }
    //Si notre page est occupé ou pas
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;

    [ObservableProperty]
    string title;
    //Contraire de isBusy
    public bool IsNotBusy => !isBusy;
}