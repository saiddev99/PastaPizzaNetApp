using PastaPizzaNetUI.Models.DessertModel.Enums;
using PastaPizzaNetUI.Models.DrankModel.Enums;
namespace PastaPizzaNetUI.Models.DrankModel
{
    internal abstract class Drank: IBedrag
    {
        public DrankEnum DrankEnum { get; set; }
        public decimal Prijs { get; protected set;}

        public Drank(DrankEnum drankEnum)
        {
            DrankEnum = drankEnum;
        }

        public string BerekenBedrag()
        {
            return $"Drank: {DrankEnum} ({Prijs} euro)";
        }
    }
}
