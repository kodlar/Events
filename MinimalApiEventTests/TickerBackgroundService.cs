using MinimalApiEventTests;

public class TickerBackgroundService : BackgroundService
{
    private readonly TickerService _tickerService;
    //private readonly TransientService _transientService;
    public TickerBackgroundService(TickerService tickerService 
        //TransientService transientService
        )
    {
        _tickerService = tickerService;
        //_transientService = transientService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _tickerService.OnTick(TimeOnly.FromDateTime(DateTime.Now));
            //_tickerService.OnTick(TimeOnly.FromDateTime(DateTime.Now),_transientService.Id);
            //_tickerService.OnTick(TimeOnly.FromDateTime(DateTime.Now), Guid.NewGuid());
            await Task.Delay(1000, stoppingToken);
        }
    }
}