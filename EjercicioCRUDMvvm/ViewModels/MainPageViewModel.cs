using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace EjercicioCRUDMvvm.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        public ICommand VerProveedoresCommand { get; }
        public ICommand AgregarProveedorCommand { get; }

        public MainPageViewModel()
        {
            VerProveedoresCommand = new RelayCommand(OnVerProveedores);
            AgregarProveedorCommand = new RelayCommand(OnAgregarProveedor);
        }

        private async void OnVerProveedores()
        {
            // Navegar a la página de proveedores (ajustar según tu estructura)
            await Shell.Current.GoToAsync("//ProveedoresPage");
        }

        private async void OnAgregarProveedor()
        {
            // Navegar a la página de agregar proveedor (ajustar según tu estructura)
            await Shell.Current.GoToAsync("//ProveedorFormPage");
        }
    }
}
