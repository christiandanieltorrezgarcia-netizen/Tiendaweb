using AppTienda.Models;
using AppTienda.PageModels;

namespace AppTienda.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}