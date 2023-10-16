using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/ProductosVendidos")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {

        private readonly ProductoVendidoBusiness productoVendidoBusiness;

        public ProductoVendidoController()
        {
            productoVendidoBusiness = ProductoVendidoBusiness.GetInstance();
        }

        //! istar todos los productos vendidos
        [HttpGet(Name = "GetProductosVendidos")]
        public IEnumerable<ProductoVendido> Get()
        {
            return productoVendidoBusiness.GetAllProductosVendidosBussines();
        }

        //! Obtener un producto vendido por su Id
        [HttpGet("{id}", Name = "GetProductoVendido")]
        public ProductoVendido Get(int id)
        {
            return productoVendidoBusiness.GetProductoVendidoBussines(id);
        }

        //! Agregar un producto vendido
        [HttpPost(Name = "AddProductoVendido")]
        public void Post([FromBody] ProductoVendido productoVendido)
        {
            productoVendidoBusiness.AddProductoVendidoBussines(productoVendido);
        }

        //! Actualizar un producto vendido
        [HttpPut(Name = "UpdateProductoVendido")]
        public void Put([FromBody] ProductoVendido productoVendido)
        {
            productoVendidoBusiness.UpdateProductoVendidoBussines(productoVendido);
        }

        //! Eliminar un producto vendido por su Id
        [HttpDelete(Name = "DeleteProductoVendido")]
        public void Delete([FromBody] int Id)
        {
            productoVendidoBusiness.DeleteProductoVendidoBussines(Id);
        }

    }
}
