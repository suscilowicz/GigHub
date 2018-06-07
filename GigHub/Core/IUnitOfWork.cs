using GigHub.Core.Repositories;

namespace GigHub.Core
{
    public interface IUnitOfWork
    {
        IGigRepository Gigs { get; }
        IAttendanceRepository Attendance { get; }
        IGenreRepository Genre { get; }
        IFollowingRepository Following { get; }
        IUserNotificationRepository UserNotification {get;}
        void Complete();
    }
}