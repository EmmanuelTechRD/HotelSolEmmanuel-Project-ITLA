
using HotelSolEmmanuel.Infrastructure.Base;

namespace HotelSolEmmanuel.Infrastructure.Notification.Interfaces
{
    public interface INotificationService<Tmodel> where Tmodel : class
    {
        public Task<NotificationResult> Send(Tmodel model);
    }
}
