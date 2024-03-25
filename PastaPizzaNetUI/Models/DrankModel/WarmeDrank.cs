using PastaPizzaNetUI.Models.DrankModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNetUI.Models.DrankModel
{
    internal class WarmeDrank: Drank
    {
        public WarmeDrank(DrankEnum drankEnum) : base(drankEnum)
        {
            base.Prijs = 2.50M;

            if (drankEnum != DrankEnum.Thee && drankEnum != DrankEnum.Koffie)
            {
                throw new ArgumentException("Deze drank behoort bij frisdranken");
            }
        }
    }
}
