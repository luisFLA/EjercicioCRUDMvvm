using EjercicioCRUDMvvm.ViewModels;
using Microsoft.Maui.Controls;

namespace EjercicioCRUDMvvm.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}
