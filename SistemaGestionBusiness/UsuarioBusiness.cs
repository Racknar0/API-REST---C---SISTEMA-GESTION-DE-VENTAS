using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBusiness
{
    public class UsuarioBusiness
    {
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
