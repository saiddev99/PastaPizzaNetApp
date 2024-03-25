using PastaPizzaNetUI.Models;
using PastaPizzaNetUI.Models.BestellingModel;
using PastaPizzaNetUI.Models.DessertModel;
using PastaPizzaNetUI.Models.DessertModel.Enums;
using PastaPizzaNetUI.Models.DrankModel;
using PastaPizzaNetUI.Models.DrankModel.Enums;
using PastaPizzaNetUI.Models.GerechtModel;
using PastaPizzaNetUI.Models.GerechtModel.Enums;
using PastaPizzaNetUI.Models.KlantModel;


Klant klant = new() { Naam = "Jan Janssen", KlantId = 1};
Pizza pizza = new Pizza() { Naam = "Mozzarella", Prijs = 5.00M, Onderdelen = new List<string> {"Tomatensaus - Mozzarella"} };
BesteldGerecht besteldGerecht = new BesteldGerecht() {Gerecht = pizza, Extra = new Extra[] {Extra.Saus, Extra.Kaas}, Grootte = Grootte.Groot};
Frisdrank drank = new Frisdrank(DrankEnum.Water);
Dessert dessert = new Dessert(DessertEnum.Ijs);


IBedrag[] bedrag =
{
    new Bestelling() 
    {
        Klant = klant,
        BesteldGerecht = besteldGerecht,
        Drank = drank,
        Dessert = dessert,
        Aantal = 4
    },


};

foreach (var item in bedrag)
{
    Console.WriteLine(item.BerekenBedrag());
}