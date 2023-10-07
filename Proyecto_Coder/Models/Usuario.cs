namespace Proyecto_Coder.Models
{
    public class Usuario
    {
        public int Id { get; set; } = 0;
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string NombreUsuario { get; set; } = string.Empty;
        public string Contrasenia { get; set; } = string.Empty;
        public string Mail { get; set; } = string.Empty;

        public Usuario() { }

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasenia, string mail)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
            Mail = mail;
        }
    }
}
