using SQLite;

namespace EjercicioCRUDMvvm
{
    public class Proveedor
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        public string Nombre { get; set; }

        [NotNull]
        public string Direccion { get; set; }

        public string Telefono { get; set; }
        public string Correo { get; set; }
    }
}
