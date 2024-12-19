using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_practice2.Models
{
    public class Bird : ITalkable, IFlyable
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Talk()
        {
            throw new NotImplementedException();
        }
    }
}
