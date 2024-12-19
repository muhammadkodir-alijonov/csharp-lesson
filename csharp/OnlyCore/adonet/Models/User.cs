using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonet.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string PhoneNUmber { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
        public string Adress { get; set; } = string.Empty;
    }
}
