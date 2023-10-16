using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/Ventas")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly VentaBusiness ventaBusiness;

        public VentaController()
        {
            ventaBusiness = VentaBusiness.GetInstance();
        }

        [HttpGet(Name = "GetVentas")]
        public IEnumerable<Venta> Get()
        {
            return ventaBusiness.GetAllVentasBussines();
        }

        [HttpGet("{id}", Name = "GetVenta")]
        public Venta Get(int id)
        {
            return ventaBusiness.GetVentaBussines(id);
        }

        [HttpPost(Name = "AddVenta")]
        public void Post([FromBody] Venta venta)
        {
            ventaBusiness.AddVentaBussines(venta);
        }

        [HttpPut(Name = "UpdateVenta")]
        public void Put([FromBody] Venta venta)
        {
            ventaBusiness.UpdateVentaBussines(venta);
        }

        [HttpDelete(Name = "DeleteVenta")]
        public void Delete([FromBody] int Id)
        {
            ventaBusiness.DeleteVentaBussines(Id);
        }
    }

}
