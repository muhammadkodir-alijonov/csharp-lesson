using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_practice2.Models
{
    public class Fish : Animal, ISwimable
    {
        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
}
