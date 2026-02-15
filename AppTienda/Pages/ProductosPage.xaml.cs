using AppTienda.PageModels;
using AppTienda.ProductosModel;

namespace AppTienda.Pages;

public partial class ProductosPage : ContentPage
{
    private readonly ProductosPageModel _pageModel;

    public ProductosPage()
    {
        InitializeComponent();
        _pageModel = new ProductosPageModel();
        BindingContext = _pageModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        try
        {
            await _pageModel.CargarProductosAsync();
        }
        catch (Exception)
        {
            // Si falla la conexión, navega a la pantalla de error
            await Navigation.PushAsync(new ErrorConexionPage());
        }
    }
}
