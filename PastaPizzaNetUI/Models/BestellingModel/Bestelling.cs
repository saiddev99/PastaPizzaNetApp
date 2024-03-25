using PastaPizzaNetUI.Models.DessertModel;
using PastaPizzaNetUI.Models.GerechtModel;
using PastaPizzaNetUI.Models.DrankModel;
using PastaPizzaNetUI.Models.KlantModel;


namespace PastaPizzaNetUI.Models.BestellingModel
{
    internal class Bestelling:IBedrag
    {
        public static int Bestelnummer { get; private set; } = 0;
        public int Aantal { get; set; }    

        public BesteldGerecht? BesteldGerecht { get; set; }
        public Dessert? Dessert { get; set; }
        public Drank? Drank { get; set; }
        public Klant? Klant { get; set; }

        public string BerekenBedrag()
        {

               return $"Bestelling: {++Bestelnummer}" +
                    $"\nKlant: {Klant?.Naam??"Onbekende Klant"}" +
                    $"\n{BesteldGerecht.BerekenBedrag()}" +
                    $"\n{Drank.BerekenBedrag()}" +
                    $"\n{Dessert.BerekenBedrag()}" +
                    $"\nAantal: {Aantal}" +
                    $"\nBedrag van deze bestelling: {(BesteldGerecht.TotalePrijs + Dessert.Prijs + Drank.Prijs) * Aantal} euro.\n";
        }
    }
}
