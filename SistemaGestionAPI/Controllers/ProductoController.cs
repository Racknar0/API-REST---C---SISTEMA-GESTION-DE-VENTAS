using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/Productos")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        //! Atributo de la clase ProductoController
        private readonly ProductoBusiness productoBusiness;

        //! Constructor de la clase ProductoController que inicializa el atributo productoBusiness
        public ProductoController()
        {
            productoBusiness = ProductoBusiness.GetInstance();
        }


        //! Obtener todos los productos
        [HttpGet(Name = "GetProductos")]
        public IEnumerable<Producto> Get()
        {
            return productoBusiness.GetAllProductosBussines();
        }


        //! Obtener un producto por su Id
        [HttpGet("{id}", Name = "GetProducto")]
        public Producto Get(int id)
        {
            return productoBusiness.GetProductoBussines(id);
        }


        //! Agregar un producto
        [HttpPost(Name = "AddProducto")]
        public void Post([FromBody] Producto producto)
        {
            productoBusiness.AddProductoBussines(producto);
        }


        //! Actualizar un producto
        [HttpPut(Name = "UpdateProducto")]
        public void Put([FromBody] Producto producto)
        {
            productoBusiness.UpdateProductoBussines(producto);
        }


        //! Eliminar un producto por su Id
        [HttpDelete(Name = "DeleteProducto")]
        public void Delete([FromBody] int Id)
        {
            productoBusiness.DeleteProductoBussines(Id);
        }


    }
}
