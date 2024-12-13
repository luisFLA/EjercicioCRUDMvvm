using EjercicioCRUDMvvm.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace EjercicioCRUDMvvm.ViewModels
{
    public partial class ProveedoresPageViewModel : ObservableObject
    {
        private readonly ProveedorDatabase _proveedorDatabase;

        public ObservableCollection<Proveedor> Proveedores { get; } = new ObservableCollection<Proveedor>();

        public ProveedoresPageViewModel(ProveedorDatabase proveedorDatabase)
        {
            _proveedorDatabase = proveedorDatabase;
            LoadProveedores();
        }

        private async void LoadProveedores()
        {
            var proveedores = await _proveedorDatabase.GetProveedoresAsync();
            foreach (var proveedor in proveedores)
            {
                Proveedores.Add(proveedor);
            }
        }
    }
}
