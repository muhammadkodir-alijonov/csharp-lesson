using System.Diagnostics;
using System.Text;

namespace string_stringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //string str = "";
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 5000; i++)
            {
                stringBuilder.Append("sdnjjfnw wfdjkwsnwfkjnwcwe wekfwke214234 4234                ");
            }
            stopwatch.Stop();
            Console.Write(stopwatch.ElapsedMilliseconds);

            //string str = "soli, sali, sodiq";
            //string[] str2 = str.Split('s');
            //foreach (string str3 in str2)
            //    Console.Write(str3);

            //string str = "Hello Word";
            //string str2 = " ";
            //Console.WriteLine(str.IndexOf(str2));

            //string str = "Salom";
            //string str2 = "m";
            //Console.WriteLine(str.Contains(str2));

            //string str = "Salom";
            //string str2 = str.Substring(0,3).ToString();
            //Console.WriteLine(str2);

            //string str = "salom dunyo";
            //string str2 = str.Insert(6, "emas ");
            //Console.WriteLine(str2);



        }
    }
}