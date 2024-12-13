using EjercicioCRUDMvvm.Services;

namespace EjercicioCRUDMvvm
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp() =>
            MauiApp.CreateBuilder()
                .UseMauiApp<App>()
                .ConfigureServices(services =>
                {
                    string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "proveedores.db3");
                    services.AddSingleton<ProveedorDatabase>(s => new ProveedorDatabase(dbPath));
                })
                .Build();
    }
}

