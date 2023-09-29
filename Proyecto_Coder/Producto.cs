using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Coder
{
    public class Producto
    {
        public int Id { get; set; } = 0;
        public string Descripcion { get; set; } = String.Empty;
        public double Costo { get; set; } = 0;
        public double PrecioVenta { get; set; } = 0;
        public int Stock { get; set; } = 0;
        public int IdUsuario { get; set; } = 0;

        public Producto() { }

        public Producto(int id, string descripcion, double costo, double precioVenta, int stock, int idUsuario)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.Costo = costo;
            this.PrecioVenta = precioVenta;
            this.Stock = stock;
            this.IdUsuario = idUsuario;
        }
    }
}
