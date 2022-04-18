namespace MinimalApiEventTests
{
    public class TickerService
    {
        private readonly TransientService _service;
        //

        //Evente constructor oluştururken abone oluyoruz
        public TickerService(TransientService service)
        {
            Ticked += OnEverySecondTicked;
            Ticked += OnEveryFiveSecondTicked;
            _service = service;
        }

        public void OnEverySecondTicked(object? sender, TickerEventArgs e)
        {
            Console.WriteLine(_service.Id);
            //Console.WriteLine(e.Time.ToLongTimeString());
        }

        public void OnEveryFiveSecondTicked(object? sender, TickerEventArgs e)
        {
            if(e.Time.Second % 5 == 0)
            {
                Console.WriteLine(e.Time.ToLongTimeString());
            }
            
        }

        //Eventi tanımlıyoruz
        public event EventHandler<TickerEventArgs>? Ticked;
        //Eventin çağırılacağı metodu yazıyoruz
        //public void OnTick(TimeOnly time, Guid guid) 
        //{
        //    Ticked?.Invoke(this, new TickerEventArgs(time,guid));
        //}

        public void OnTick(TimeOnly time)
        {
            Ticked?.Invoke(this, new TickerEventArgs(time));
        }

    }
}
