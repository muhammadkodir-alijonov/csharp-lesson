namespace demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            A.Add(1,2);
        }
    }
    public static class A
    {
        public static void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
    }
}