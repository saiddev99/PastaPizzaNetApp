using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNetUI.Models.DrankModel
{
    internal class Frisdrank : Drank
    {
        public Frisdrank():base()
        {
            base.Prijs = 2.00M;
        }
    }
}
