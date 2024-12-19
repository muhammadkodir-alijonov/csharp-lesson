using System.Diagnostics;
using System.Numerics;

namespace async_await
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var task1 = Calculate1Async(500, 200);
            var task2 = Calculate2Async(500, 5000);
            var task3 = Calculate3Async(500, 200000);

            Console.WriteLine("Result 1: ");
            if (task1.IsCompleted) Console.WriteLine(task1.Result);
            else
            {
                string result = await task1;
                Console.WriteLine(result.Substring(1,1000));
            }

            Console.WriteLine("Result 2: ");
            if (task2.IsCompleted) Console.WriteLine(task2.Result);
            else
            {
                string result = await task3;
                Console.WriteLine(result.Substring(1, 1000));
            }

            Console.WriteLine("Result 3: ");
            if (task3.IsCompleted) Console.WriteLine(task3.Result);
            else
            {
                string result = await task3;
                Console.WriteLine(result.Substring(1, 1000));
            }
            stopwatch.Stop();
            Console.WriteLine("Time:" + stopwatch.ElapsedMilliseconds);

        }

        public static async Task<string> Calculate1Async(int a, int d)
        {
            BigInteger bigInteger = 1;

            await Task.Run(() =>
            {
                for (int i = 0; i < d; i++)
                {
                    bigInteger *= a;
                }
            });
            return bigInteger.ToString();
        }
        public static async Task<string> Calculate2Async(int a, int d)
        {
            BigInteger bigInteger = 1;

            await Task.Run(() =>
            {
                for (int i = 0; i < d; i++)
                {
                    bigInteger *= a;
                }
            });
            return bigInteger.ToString();
        }
        public static async Task<string> Calculate3Async(int a, int d)
        {
            BigInteger bigInteger = 1;

            await Task.Run(() =>
            {
                for (int i = 0; i < d; i++)
                {
                    bigInteger *= a;
                }
            });
            return bigInteger.ToString();
        }
    }
}