using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EjercicioCRUDMvvm.Services
{
    public class ProveedorDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        public ProveedorDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Proveedor>().Wait(); // Crear la tabla si no existe
        }

        public Task<List<Proveedor>> GetProveedoresAsync()
        {
            return _database.Table<Proveedor>().ToListAsync();
        }

        public Task<int> SaveProveedorAsync(Proveedor proveedor)
        {
            if (proveedor.Id != 0)
                return _database.UpdateAsync(proveedor);
            else
                return _database.InsertAsync(proveedor);
        }

        public Task<int> DeleteProveedorAsync(Proveedor proveedor)
        {
            return _database.DeleteAsync(proveedor);
        }
    }
}
