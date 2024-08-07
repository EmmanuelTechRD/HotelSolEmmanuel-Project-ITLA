
using HotelSolEmmanuel.Common.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelSolEmmanuel.Categoria.Domain.Entities
{
    public class Categoria : AuditEntity<int>
    {
        [Column("IdCategoria")]
        public override int Id { get; set; }
        public int IdCategoria { get; set; }
        public string? Descripcion { get; set; }
        public bool? Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
