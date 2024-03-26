using PastaPizzaNetUI.Models.DessertModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNetUI.Models.DessertModel
{
    internal class Dessert:IBedrag
    {
        public DessertEnum DessertEnum { get; set; }
        public decimal Prijs { get; private set; }

        public Dessert(DessertEnum dessertEnum)
        {
            DessertEnum = dessertEnum;
        }

        public void BerekenBedrag()
        {
            Prijs = DessertEnum switch
            {
                DessertEnum.Cake => 2.00M,
                DessertEnum.Ijs => 3.00M,
                DessertEnum.Tiramisu => 3.00M,
                _ => throw new NotImplementedException(),
            };
        }

        public override string ToString()
        {
            return $"Dessert: {DessertEnum} ({Prijs} euro)\n";
        }
    }
}
