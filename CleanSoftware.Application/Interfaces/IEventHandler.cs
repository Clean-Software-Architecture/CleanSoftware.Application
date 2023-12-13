using MediatR;

namespace CleanSoftware.Application.Interfaces
{
    public interface IEventHandler<TEvent> : INotificationHandler<TEvent>
        where TEvent : INotification 
    {
    }
}
