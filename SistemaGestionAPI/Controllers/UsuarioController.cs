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

        [HttpGet("GetUserName/{id}", Name = "GetUserName")]
        public string GetUserName(int id)
        {
            return usuarioBusiness.GetUserNameBussines(id);
        }

        [HttpPost("Login", Name = "LoginUsuario")]
        // Pedir usuario y contraseña en el body
        public IActionResult LoginUsuario([FromForm] string nombreUsuario, [FromForm] string contrasenia)
        {

            try
            {
                Usuario usuario = usuarioBusiness.LoginUsuarioBussines(nombreUsuario, contrasenia);
                if (usuario != null)
                {
                    return Ok(usuario);
                } else
                {
                    // Autenticación fallida
                    return StatusCode(401, "Autenticación fallida. El usuario no existe o las credenciales son incorrectas.");
                }
            } catch (Exception ex)
            {
                // Manejar la excepción
                Console.WriteLine("Error durante el proceso de autenticación: " + ex.Message);
                return StatusCode(401, "Error de autenticación. Por favor, verifique sus credenciales.");
            }

        }


    }
}
