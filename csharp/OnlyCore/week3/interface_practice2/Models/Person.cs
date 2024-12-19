using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_practice2.Models
{
    public class Person : IBreathable, ITalkable, IJumpable,
                          IEatable, IHuntable, ISwimable, IMoveable
    {
        public void Breath()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Hunt()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }

        public void Talk()
        {
            throw new NotImplementedException();
        }
    }
}
