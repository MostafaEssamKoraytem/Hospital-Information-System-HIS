using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Infrastructure.Events
{
    public interface INotificationWrapper<out T> : INotification
    {
        T Notification { get; }
    }

    public class NotificationWrapper<T> : INotificationWrapper<T>
    {
        public NotificationWrapper(T notification)
        {
            Notification = notification;
        }

        public T Notification { get; }
    }
}
