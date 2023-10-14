using SistemaGestionEntities;
using SistemaGestionData;

namespace SistemaGestionBusiness
{
    public class ProductoBusiness
    {
        public Producto GetProductoBussines(int Id)
        {
            return ProductoDAO.GetProducto(Id);
        }

        public List<Producto> GetAllProductosBussines()
        {
            return ProductoDAO.GetAllProductos();
        }

        public int AddProductoBussines(Producto producto)
        {
            return ProductoDAO.AddProducto(producto);
        }

        public Producto UpdateProductoBussines(Producto producto)
        {
            return ProductoDAO.UpdateProducto(producto);
        }

        public int DeleteProductoBussines(int Id)
        {
            return ProductoDAO.DeleteProducto(Id);
        }
    }
}
