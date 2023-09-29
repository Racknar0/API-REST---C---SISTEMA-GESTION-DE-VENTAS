using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Coder
{
    public class Usuario
    {
        public int Id { get; set; } = 0;
        public string Nombre { get; set; } = String.Empty;
        public string Apellido { get; set; } = String.Empty;
        public string NombreUsuario { get; set; } = String.Empty;
        public string Contrasenia { get; set; } = String.Empty;
        public string Mail { get; set; } = String.Empty;

        public Usuario(){}

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasenia, string mail)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreUsuario = nombreUsuario;
            this.Contrasenia = contrasenia;
            this.Mail = mail;
        }
    }
}
