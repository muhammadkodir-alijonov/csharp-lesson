using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_practice2.Models
{
    public class Lion : Animal, IJumpable, IHuntable, ISwimable
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Hunt()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
}
