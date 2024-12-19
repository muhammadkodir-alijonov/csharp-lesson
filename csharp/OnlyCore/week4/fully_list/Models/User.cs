using fully_list.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fully_list.Models
{
    public class User
    {
        public string FirstName { get; set; } = String.Empty;

        public string LastName { get; set; } = String.Empty;
        public Role Role { get; set; }

        public string Email { get; set; } = String.Empty;

        public string Password { get; set; } = String.Empty;
    }
}
