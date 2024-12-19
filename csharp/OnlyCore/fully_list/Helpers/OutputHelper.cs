using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fully_list.Helpers
{
    public class OutputHelper
    {
        public static void WriteSuccessuful(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nSuccessful");
            Console.WriteLine("\n" + "      " +  message + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void WriteInformation(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Information");
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void WriteError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nError");
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
