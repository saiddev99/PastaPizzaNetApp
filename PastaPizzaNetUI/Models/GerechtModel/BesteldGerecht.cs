using PastaPizzaNetUI.Models.DessertModel.Enums;
using PastaPizzaNetUI.Models.GerechtModel.Enums;
using System.Text;

namespace PastaPizzaNetUI.Models.GerechtModel
{
    internal class BesteldGerecht:IBedrag
    {
        public Gerecht? Gerecht { get; set; }
        public Grootte? Grootte{ get; set; }
        public Extra[]? Extra{ get; set; }
        public decimal TotalePrijs { get;private set; }

        public string BerekenBedrag()
        {
            decimal extraPrijs = 0.00M;
            StringBuilder extras = new();
            StringBuilder text = new();

            Pizza? pizza = Gerecht as Pizza;
            Pasta? pasta = Gerecht as Pasta;

            extraPrijs += Extra.Length;
            extraPrijs += Grootte.Value == Enums.Grootte.Groot ? 3.00M : 0.00M;
            TotalePrijs = Gerecht.Prijs + extraPrijs;

            if (Gerecht is Pizza)
            {
                foreach (var item in pizza.Onderdelen)
                {
                    text.Append(item + " ");
                }
            }
            else
            {
                text.Append(pasta.Omschrijving);
            }

            foreach (var item in Extra)
            {
                extras.Append(item + " ");
            }

            return $"Gerecht: {Gerecht.Naam} ({Gerecht.Prijs} euro) {text}({Grootte}) extra: {extras}(bedrag: {TotalePrijs} euro)";
        }
    }
}
