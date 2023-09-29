using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Coder
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
            this.Id = id;
            this.IdProducto = idProducto;
            this.Stock = stock;
            this.IdVenta = idVenta;
        }
    }
}
