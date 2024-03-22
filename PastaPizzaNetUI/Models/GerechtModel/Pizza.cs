using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNetUI.Models.GerechtModel
{
    internal class Pizza:Gerecht
    {
        public List<string>? Onderdelen { get; set; }
    }
}
