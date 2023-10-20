using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBusiness
{
    public class UsuarioBusiness
    {
        private static UsuarioBusiness _instance;
        private static readonly object _lock = new object();

        private UsuarioBusiness()
        {
            // Constructor privado para evitar la instanciación directa
        }

        public static UsuarioBusiness GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new UsuarioBusiness();
                }
            }
            return _instance;
        }

        public Usuario GetUsuarioBussines(int Id)
        {
            return UsuarioDAO.GetUsuario(Id);
        }

        public List<Usuario> GetAllUsuariosBussines()
        {
            return UsuarioDAO.GetAllUsuarios();
        }

        public int AddUsuarioBussines(Usuario usuario)
        {
            return UsuarioDAO.AddUsuario(usuario);
        }

        public Usuario UpdateUsuarioBussines(Usuario usuario)
        {
            return UsuarioDAO.UpdateUsuario(usuario);
        }

        public int DeleteUsuarioBussines(int Id)
        {
            return UsuarioDAO.DeleteUsuario(Id);
        }

        public string GetUserNameBussines(int Id)
        {
            return UsuarioDAO.GetUsername(Id);
        }

        public Usuario LoginUsuarioBussines(string nombreUsuario, string contrasenia)
        {
            try
            {
                Usuario usuario = UsuarioDAO.LoginUsuario(nombreUsuario, contrasenia);

                if (usuario != null)
                {
                    // La autenticación fue exitosa, puedes realizar acciones adicionales aquí si es necesario
                    Console.WriteLine("Autenticación exitosa para el usuario: " + usuario.NombreUsuario);
                    return usuario;
                } else
                {
                    // La autenticación falló, lanzar una excepción con un mensaje de error específico
                    throw new Exception("Autenticación fallida. El usuario no existe o las credenciales son incorrectas.");
                }
            } catch (Exception ex)
            {
                // Loguear el error
                Console.WriteLine("Se produjo un error durante el proceso de autenticación: " + ex.Message);
                throw new Exception("Error de autenticación. Por favor, verifique sus credenciales.");
            }
        }

    }
}
