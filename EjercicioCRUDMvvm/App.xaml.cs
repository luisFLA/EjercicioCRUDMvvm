using EjercicioCRUDMvvm.Services;
using Microsoft.Maui.Controls;
using System.IO;

namespace EjercicioCRUDMvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Definir la ruta de la base de datos en el dispositivo
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "proveedores.db3");
            DependencyService.Register<ProveedorDatabase>(dbPath);

            MainPage = new NavigationPage(new MainPage());
        }
    }
}



