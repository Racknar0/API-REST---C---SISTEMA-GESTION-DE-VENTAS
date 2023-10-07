
namespace Proyecto_Coder.Models
{
    public class ProductoVendido
    {
        public int Id { get; set; } = 0;
        public int IdProducto { get; set; } = 0;
        public int Stock { get; set; } = 0;
        public int IdVenta { get; set; } = 0;

        public ProductoVendido() { }

        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            Id = id;
            IdProducto = idProducto;
            Stock = stock;
            IdVenta = idVenta;
        }
    }
}
