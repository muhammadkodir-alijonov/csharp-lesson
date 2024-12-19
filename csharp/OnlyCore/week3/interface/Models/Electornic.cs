using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_practise.Models
{
    public class Electornic : ISwitable
    {
        public string Name { get; set; } = String.Empty;
        public virtual void TurnOff()
        {
            Console.WriteLine("O'chdi");
        }

        public virtual void TurnOn()
        {
            Console.WriteLine("Yondi");
        }
    }
}
