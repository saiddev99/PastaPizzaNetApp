using PastaPizzaNetUI.Models;
using PastaPizzaNetUI.Models.BestellingModel;
using PastaPizzaNetUI.Models.DessertModel;
using PastaPizzaNetUI.Models.DessertModel.Enums;
using PastaPizzaNetUI.Models.DrankModel;
using PastaPizzaNetUI.Models.DrankModel.Enums;
using PastaPizzaNetUI.Models.GerechtModel;
using PastaPizzaNetUI.Models.GerechtModel.Enums;
using PastaPizzaNetUI.Models.KlantModel;

Klant[] klanten =
{
    new Klant {Naam = "Jan Janssen", KlantId = 1},
    new Klant {Naam = "Piet Pieters", KlantId = 2}
};

int bestelNummer = 1;

Bestelling[] bedrag =
{
    new Bestelling() 
    {
        Klant = klanten[0],
        BesteldGerecht = new() 
            {
                Gerecht = new Pizza(){ Naam = "Pizza Margherita", Prijs = 8.00M, Onderdelen = new List<string> {"Tomatensaus - Mozzarella"}}, 
                Extra = new Extra[] {Extra.Kaas, Extra.Look}, 
                Grootte = Grootte.Groot
            },
        Drank = new Frisdrank(DrankEnum.Water),
        Dessert = new(DessertEnum.Ijs),
        Aantal = 2
    },

    new Bestelling()
    {
        Klant = klanten[1],
        BesteldGerecht = new()
            {
                Gerecht = new Pizza(){ Naam = "Pizza Margherita", Prijs = 8.00M, Onderdelen = new List<string> {"Tomatensaus - Mozzarella"}},
                Grootte = Grootte.Klein
            },
        Drank = new Frisdrank(DrankEnum.Water),
        Dessert = new(DessertEnum.Tiramisu),
        Aantal = 1
    },

    new Bestelling()
    {
        Klant = klanten[1],
        BesteldGerecht = new()
            {
                Gerecht = new Pizza(){ Naam = "Pizza Napoli", Prijs = 10.00M, Onderdelen = new List<string> {"Tomatensaus - Mozzarella - Ansjovis - Kappers - Olijven"}},
                Grootte = Grootte.Groot
            },
        Drank = new WarmeDrank(DrankEnum.Thee),
        Dessert = new(DessertEnum.Ijs),
        Aantal = 1
    },

    new Bestelling()
    {
        BesteldGerecht = new()
            {
                Gerecht = new Pasta(){ Naam = "Lasagne", Prijs = 15.00M, Omschrijving = ""},
                Extra = new Extra[] {Extra.Look},
                Grootte = Grootte.Klein
            },
        Aantal = 1
    },

    new Bestelling()
    {
        Klant = klanten[0],
        BesteldGerecht = new()
            {
                Gerecht = new Pasta(){ Naam = "Spaghetti Carbonara", Prijs = 13.00M, Omschrijving = "spek, roomsaus en parmezaanse kaas"},
                Grootte = Grootte.Klein
            },
        Drank = new Frisdrank(DrankEnum.Water),
        Aantal = 1
    },

    new Bestelling()
    {
        Klant = klanten[1],
        BesteldGerecht = new()
            {
                Gerecht = new Pasta(){ Naam = "Spaghetti Bolognese", Prijs = 12.00M, Omschrijving = "met gehaktsays"},
                Extra = new Extra[] {Extra.Kaas},
                Grootte = Grootte.Groot
            },
        Drank = new Frisdrank(DrankEnum.Cocacola),
        Dessert = new(DessertEnum.Cake),
        Aantal = 1
    },

    new Bestelling()
    {
        Klant = klanten[1],
        Drank = new WarmeDrank(DrankEnum.Koffie),
        Aantal = 3
    },

    new Bestelling()
    {
        Klant = klanten[0],
        Dessert = new(DessertEnum.Tiramisu),
        Aantal = 1
    },
};


//Overzicht alle bestellingen*/
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Alle bestellingen");
Console.WriteLine("************************************************************************************************************************");
Console.ForegroundColor = ConsoleColor.Gray;


foreach (var item in bedrag)
{
    item.Bestelnummer = bestelNummer++;
    item.BerekenBedrag();
    Console.WriteLine(item);
    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
}



//Overzicht bestellingen Jan Jannsens*/
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Bestellingen van Jan Jannsen");
Console.WriteLine("************************************************************************************************************************");
Console.ForegroundColor = ConsoleColor.Gray;


var janBestellingen =
    from b in bedrag
    where b.Klant?.KlantId == 1
    select b;


decimal totaleBedrag = 0;
foreach (var bestelling in janBestellingen)
{
    Console.WriteLine(bestelling);
    totaleBedrag += bestelling.TotalePrijs;
    Console.WriteLine("=====================================================================================================================");
}
Console.WriteLine("Totaal bedrag van alle bestellingen van klant Jan Janssen: " + Math.Round(totaleBedrag,2));



//Overzicht bestellingen gegroepeerd per klant
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Bestellingen gegroepeerd per klant");
Console.WriteLine("************************************************************************************************************************");
Console.ForegroundColor = ConsoleColor.Gray;


var groepBestellingen =
    from b in bedrag
    group b by b.Klant?.Naam??"onbekende Klanten: "
    into c
    select c;


totaleBedrag = 0;
foreach (var bestelling in groepBestellingen)
{
    Console.WriteLine("Bestellingen van " + bestelling.Key);
    Console.WriteLine();
    foreach (var item in bestelling)
    {
        totaleBedrag += item.TotalePrijs;
        Console.WriteLine(item);
        Console.WriteLine();
    }
    Console.WriteLine($"Totaal bedrag van alle bestellingen van {bestelling.Key}: " + Math.Round(totaleBedrag, 2));
    Console.WriteLine("********************************************************************************************************************");
    Console.WriteLine();

    totaleBedrag = 0;
}





