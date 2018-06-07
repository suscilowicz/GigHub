using System.Collections.Generic;
using GigHub.Core.Models;

namespace GigHub.Core.Repositories
{
    public interface IUserNotificationRepository
    {
        IEnumerable<Notification> GetNotificationsForUser(string userId);
        IEnumerable<UserNotification> GetUnreadNotificationsForUser(string userId);
    }
}