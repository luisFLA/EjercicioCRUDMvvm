using EjercicioCRUDMvvm.ViewModels;
using Microsoft.Maui.Controls;

namespace EjercicioCRUDMvvm.Views
{
    public partial class ProveedorFormPage : ContentPage
    {
        public ProveedorFormPage()
        {
            InitializeComponent();
            BindingContext = new ProveedorFormPageViewModel();
        }
    }
}

