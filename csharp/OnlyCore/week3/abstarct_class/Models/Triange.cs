using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstarct_class.Models
{
    public class Triange : Shape
    {
        public override void Draw()
        {
            Console.WriteLine(@"|\");
            Console.WriteLine(@"| \");
            Console.WriteLine(@"|  \");
            Console.WriteLine(@"|   \");
            Console.WriteLine(@"|    \");
            Console.WriteLine(@"|     \");
            Console.WriteLine(@"|______\");
        }
    }
}
