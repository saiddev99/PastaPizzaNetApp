using PastaPizzaNetUI.Models.DessertModel;
using PastaPizzaNetUI.Models.GerechtModel;
using PastaPizzaNetUI.Models.DrankModel;
using PastaPizzaNetUI.Models.KlantModel;


namespace PastaPizzaNetUI.Models.BestellingModel
{
    internal class Bestelling:IBedrag
    {
        public int Bestelnummer { get; set; }
        public int Aantal { get; set; }    

        public BesteldGerecht? BesteldGerecht { get; set; }
        public Dessert? Dessert { get; set; }
        public Drank? Drank { get; set; }
        public Klant? Klant { get; set; }


        public decimal TotalePrijs { get;private set; }
        public void BerekenBedrag()
        {
            BesteldGerecht?.BerekenBedrag();
            Drank?.BerekenBedrag();
            Dessert?.BerekenBedrag();

            if (BesteldGerecht is null || Drank is null || Dessert is null)
            {
                decimal nullBesteldGerecht = BesteldGerecht?.TotalePrijs ?? 0;
                decimal nullDessert = Dessert?.Prijs ?? 0;
                decimal nullDrank = Drank?.Prijs ?? 0;

                TotalePrijs = (nullBesteldGerecht + nullDessert + nullDrank) * Aantal;
            }
            else
            {
                TotalePrijs = ((BesteldGerecht.TotalePrijs + Dessert.Prijs + Drank.Prijs) * Aantal) * 0.90M;
            }
        }

        public override string ToString()
        {
            return $"Bestelling: {Bestelnummer}\n" +
                    $"{Klant}" +
                    $"{BesteldGerecht}" +
                    $"{Drank}" +
                    $"{Dessert}" +
                    $"Aantal: {Aantal}\n" +
                    $"Bedrag van deze bestelling: {Math.Round(TotalePrijs,2)} euro.";
        }
    }
}
