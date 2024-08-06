
namespace HotelSolEmmanuel.Categoria.Application.DTOs
{
    public abstract class CategoriaBaseModel
    {
        public string? Descripcion { get; set; }
        public bool? Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
