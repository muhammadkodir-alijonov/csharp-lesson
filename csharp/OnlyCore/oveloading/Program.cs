//oberloading
//namespace oveloading
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            int sum1 = Add(2,4);
//            int sum2 = Add(2,4,5);
//            Console.WriteLine(sum1);
//            Console.WriteLine(sum2);
//        }

//        static int Add(int a, int b)
//        {
//            return a + b;
//        }

//        static int Add(int a, int b, int c)
//        {
//            return a + b + c;
//        }
//        static string Add(string a, string b)
//        {
//            return a + b;
//        }
//    }
//}


//params
using System;

class Program
{
    static void Main()
    {
        int sum1 = CalculateSum(1, 2, 3);
        int sum2 = CalculateSum(4, 5, 6, 7, 8);

        Console.WriteLine(sum1); // 6
        Console.WriteLine(sum2); // 30
    }

    static int CalculateSum(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}
