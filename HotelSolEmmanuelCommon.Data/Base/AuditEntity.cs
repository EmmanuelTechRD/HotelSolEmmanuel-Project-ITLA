using HotelSolEmmanuelCommon.Data.Base;

namespace HotelSolEmmanuel.Common.Data.Base
{
    public abstract class AuditEntity <TType> : BaseEntity <TType>
    {
        public DateTime FechaCreacion { get; set; }
        public int Estado { get; set; }
    }
}
