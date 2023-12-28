namespace Features.Models
{
    public class Count
    {
        public int Value { get; private set; }
        public void Inc() => Value++;

        public static Count Instance { get; } = new Count();
    }
}
