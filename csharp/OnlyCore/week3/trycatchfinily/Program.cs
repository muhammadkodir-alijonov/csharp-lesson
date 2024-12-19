namespace trycatchfinally
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(a/b);
                return;
            }
            catch
            {
                Console.WriteLine("Xatolik");
                return;
            }
            finally
            { 
            }
        }
        public void Run(int n)
        {
            if (n == 0) throw new Exception("Nolga bo'linmasligi kerak!");
            else if (n == 1) throw new NotSupportedException();
        }
    }
}