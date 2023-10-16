using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/Usuarios")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly UsuarioBusiness usuarioBusiness;

        public UsuarioController()
        {
            usuarioBusiness = UsuarioBusiness.GetInstance();
        }

        [HttpGet(Name = "GetUsuarios")]
        public IEnumerable<Usuario> Get()
        {
            return usuarioBusiness.GetAllUsuariosBussines();
        }

        [HttpGet("{id}", Name = "GetUsuario")]
        public Usuario Get(int id)
        {
            return usuarioBusiness.GetUsuarioBussines(id);
        }

        [HttpPost(Name = "AddUsuario")]
        public void Post([FromBody] Usuario usuario)
        {
            usuarioBusiness.AddUsuarioBussines(usuario);
        }

        [HttpPut(Name = "UpdateUsuario")]
        public void Put([FromBody] Usuario usuario)
        {
            usuarioBusiness.UpdateUsuarioBussines(usuario);
        }

        [HttpDelete(Name = "DeleteUsuario")]
        public void Delete([FromBody] int Id)
        {
            usuarioBusiness.DeleteUsuarioBussines(Id);
        }


    }
}
