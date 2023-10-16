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
    }
}
