using fully_list.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fully_list.Interface
{
    public interface IAudentificationManager
    {
        public User Verify(string email, string password);
    }
}
