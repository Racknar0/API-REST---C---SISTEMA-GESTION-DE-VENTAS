
namespace Proyecto_Coder.Models
{
    public class Producto
    {
        public int Id { get; set; } = 0;
        public string Descripcion { get; set; } = string.Empty;
        public double Costo { get; set; } = 0;
        public double PrecioVenta { get; set; } = 0;
        public int Stock { get; set; } = 0;
        public int IdUsuario { get; set; } = 0;

        public Producto() { }

        public Producto(int id, string descripcion, double costo, double precioVenta, int stock, int idUsuario)
        {
            Id = id;
            Descripcion = descripcion;
            Costo = costo;
            PrecioVenta = precioVenta;
            Stock = stock;
            IdUsuario = idUsuario;
        }
    }
}
