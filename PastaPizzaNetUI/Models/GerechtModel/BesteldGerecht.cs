using PastaPizzaNetUI.Models.DessertModel.Enums;
using PastaPizzaNetUI.Models.GerechtModel.Enums;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace PastaPizzaNetUI.Models.GerechtModel
{
    internal class BesteldGerecht:IBedrag
    {
        public Gerecht? Gerecht { get; set; }
        public Grootte? Grootte{ get; set; }
        public Extra[]? Extra{ get; set; }

        public decimal TotalePrijs { get;private set; }

        private decimal extraPrijs = 0.00M;
        private StringBuilder extras = new();
        private StringBuilder text = new();

        public void BerekenBedrag()
        {
            Pizza? pizza = Gerecht as Pizza;
            Pasta? pasta = Gerecht as Pasta;

            extraPrijs += Extra?.Length??0;
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

            if (Extra is not null)
            {
                foreach (var item in Extra)
                {
                    extras.Append(item + " ");
                }
            }

        }

        public override string ToString()
        {
            if (Extra is not null)
            {
                return $"Gerecht: {Gerecht.Naam} ({Gerecht.Prijs} euro) {text}({Grootte}) extra: {extras}(bedrag: {TotalePrijs} euro)\n";
            }
            else
            {
                return $"Gerecht: {Gerecht.Naam} ({Gerecht.Prijs} euro) {text}({Grootte}) (bedrag: {TotalePrijs} euro)\n";
            }
            
        }
    }
}
