using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNetUI.Models.DrankModel
{
    internal class WarmeDrank: Drank
    {
        public WarmeDrank() : base()
        {
            base.Prijs = 2.50M;
        }
    }
}
