
namespace HotelSolEmmanuelCommon.Data.Base
{
    public abstract class BaseEntity<TType>
    {
        public required TType Id { get; set; }
    }
}
