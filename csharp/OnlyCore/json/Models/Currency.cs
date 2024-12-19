using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json.Models;

public class Currency
{
    public string Title { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public double cb_price { get; set; }
    public string date { get; set; } = string.Empty;
}
