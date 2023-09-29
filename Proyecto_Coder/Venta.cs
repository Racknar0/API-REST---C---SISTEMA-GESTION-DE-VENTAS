using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Coder
{
    public class Venta
    {
        public int Id { get; set; } = 0;
        public string Comentarios { get; set; } = String.Empty;
        public int IdUsuario { get; set; } = 0;

        public Venta() { }

        public Venta(int id, string comentarios, int idUsuario)
        {
            this.Id = id;
            this.Comentarios = comentarios;
            this.IdUsuario = idUsuario;
        }
    }
}
