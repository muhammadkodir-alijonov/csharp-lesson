using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_practise.Models
{
    public class Laptop : Electornic, Icoolable
    {
        public void Freeze()
        {
            Console.WriteLine("Sovitdi");
        }
    }
}
