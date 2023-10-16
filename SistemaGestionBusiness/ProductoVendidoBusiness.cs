using SistemaGestionEntities;
using SistemaGestionData;

namespace SistemaGestionBusiness
{
    public class ProductoVendidoBusiness
    {
        private static ProductoVendidoBusiness _instance;
        private static readonly object _lock = new object();

        private ProductoVendidoBusiness() { }

        public static ProductoVendidoBusiness GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new ProductoVendidoBusiness();
                }
            }
            return _instance;
        }

        public ProductoVendido GetProductoVendidoBussines(int Id)
        {
            return ProductoVendidoDAO.GetProductoVendido(Id);
        }

        public List<ProductoVendido> GetAllProductosVendidosBussines()
        {
            return ProductoVendidoDAO.GetAllProductosVendidos();
        }

        public int AddProductoVendidoBussines(ProductoVendido productoVendido)
        {
            return ProductoVendidoDAO.AddProductoVendido(productoVendido);
        }

        public ProductoVendido UpdateProductoVendidoBussines(ProductoVendido productoVendido)
        {
            return ProductoVendidoDAO.UpdateProductoVendido(productoVendido);
        }

        public int DeleteProductoVendidoBussines(int Id)
        {
            return ProductoVendidoDAO.DeleteProductoVendido(Id);
        }
    }
}
