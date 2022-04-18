using MediatR;

namespace MinimalApiMediatorEventTests
{
    public class TimeNotification : INotification
    {
        public TimeNotification(TimeOnly time)
        {
            Time = time;
        }
        public TimeOnly Time { get;}
    }
}
