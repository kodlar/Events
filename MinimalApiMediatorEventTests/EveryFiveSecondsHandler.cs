using MediatR;

namespace MinimalApiMediatorEventTests
{
    public class EveryFiveSecondsHandler : INotificationHandler<TimeNotification>
    {
        public Task Handle(TimeNotification notification, CancellationToken cancellationToken)
        {
            if (notification.Time.Second % 5 == 0)
            {
                Console.WriteLine(notification.Time.ToLongTimeString());
            }
            return Task.CompletedTask;
        }
    }
}
