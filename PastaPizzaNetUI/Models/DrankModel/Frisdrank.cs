using PastaPizzaNetUI.Models.DrankModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNetUI.Models.DrankModel
{
    internal class Frisdrank : Drank
    {
        public Frisdrank(DrankEnum drankEnum) : base(drankEnum)
        {
            base.Prijs = 2.00M;

            if (drankEnum != DrankEnum.Water && drankEnum != DrankEnum.Limonade && drankEnum != DrankEnum.Cocacola)
            {
                throw new ArgumentException("Deze drank behoort bij warmedranken");
            }
        }
    }
}
