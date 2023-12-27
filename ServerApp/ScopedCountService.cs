namespace ServerApp
{
    public class ScopedCountService
    {
        public int Count { get; set; }

        public void Increase() => Count++;
    }
}
