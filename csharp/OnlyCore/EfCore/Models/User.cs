using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Models
{
    public class User
    {
        public long Id { get; set; }
        [MaxLength(60)]
        [MinLength(2)]
        public string Firstname { get; set; } = string.Empty;
        [MaxLength(60)]
        [MinLength(2)]
        public string Lastname { get; set; } = string.Empty;
        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public override string ToString()
        {
            return Firstname + " " +Lastname + " " + PhoneNumber + " " + Address;
        }
    }
}
