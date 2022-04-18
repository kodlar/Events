using MediatR;

namespace MinimalApiMediatorEventTests
{
    public class EverySecondHandler : INotificationHandler<TimeNotification>
    {
        private readonly TransientService _transientService;

        public EverySecondHandler(TransientService transientService)
        {
            _transientService = transientService;
        }

        public Task Handle(TimeNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine(_transientService.Id.ToString());
            Console.WriteLine(notification.Time.ToLongTimeString());
            return Task.CompletedTask;
        }
    }
}
