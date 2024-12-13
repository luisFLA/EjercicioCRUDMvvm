using EjercicioCRUDMvvm.Services;
using Microsoft.Maui.Controls;
using System.Collections.Generic;
using System.Linq;

namespace EjercicioCRUDMvvm
{
    public partial class MainPage : ContentPage
    {
        private readonly ProveedorDatabase _proveedorDatabase;

        public MainPage()
        {
            InitializeComponent();
            _proveedorDatabase = DependencyService.Get<ProveedorDatabase>();

            // Cargar los proveedores desde la base de datos
            LoadProveedores();
        }

        private async void LoadProveedores()
        {
            var proveedores = await _proveedorDatabase.GetProveedoresAsync();
            proveedoresListView.ItemsSource = proveedores;
        }

        private async void OnSaveProveedorClicked(object sender, EventArgs e)
        {
            string nombre = nombreEntry.Text;
            string direccion = direccionEntry.Text;
            string telefono = telefonoEntry.Text;
            string correo = correoEntry.Text;

            // Validación de campos no vacíos (excepto los numéricos)
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(direccion))
            {
                await DisplayAlert("Error", "Los campos Nombre y Dirección son obligatorios.", "OK");
                return;
            }

            var proveedor = new Proveedor
            {
                Nombre = nombre,
                Direccion = direccion,
                Telefono = telefono,
                Correo = correo
            };

            await _proveedorDatabase.SaveProveedorAsync(proveedor);
            LoadProveedores(); // Recargar la lista de proveedores

            // Limpiar los campos de entrada
            nombreEntry.Text = string.Empty;
            direccionEntry.Text = string.Empty;
            telefonoEntry.Text = string.Empty;
            correoEntry.Text = string.Empty;
        }
    }
}
