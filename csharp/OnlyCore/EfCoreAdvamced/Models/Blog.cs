using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreAdvamced.Models
{
    public class Blog : BaseEntity
    {
        public string Titile { get; set; } = string.Empty;
        public string Info { get; set; } = string.Empty;
        public DateTime DateTime { get; set; }
        public long UserID  { get; set; }
        public virtual User User { get; set; } = default!;
    }
}
