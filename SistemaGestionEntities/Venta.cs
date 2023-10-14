namespace SistemaGestionEntities
{
    public class Venta
    {
        public int Id { get; set; } = 0;
        public string Comentarios { get; set; } = string.Empty;
        public int IdUsuario { get; set; } = 0;

        public Venta() { }

        public Venta(int id, string comentarios, int idUsuario)
        {
            Id = id;
            Comentarios = comentarios;
            IdUsuario = idUsuario;
        }
    }
}