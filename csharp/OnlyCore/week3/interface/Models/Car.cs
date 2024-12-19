using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_practise.Models
{
    public class Car : Electornic, Icoolable, IHeatable, IOilable
    {
        public override void TurnOn()
        {
            Console.WriteLine("mashina yondi");
        }
        public override void TurnOff()
        {
            Console.WriteLine("mashina o'chdi");
        }
        public void Freeze()
        {
            Console.WriteLine("Mashina sovutildi");
        }

        public void Heat()
        {
            Console.WriteLine("mashina isitildi");
        }

        public void MakeOi()
        {
            Console.WriteLine("Mashina moylandi");
        }
    }
}
