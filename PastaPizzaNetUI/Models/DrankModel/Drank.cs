using PastaPizzaNetUI.Models.DrankModel.Enums;
namespace PastaPizzaNetUI.Models.DrankModel
{
    internal class Drank
    {
        private DrankEnum drankEnum;

        public DrankEnum DrankEnum
        {
            get
            {
                return drankEnum;
            }

            set
            {
                if (!Enum.IsDefined(typeof(DrankEnum), value)) 
                {
                    throw new ArgumentException("Foutieve invoer, probeer opnieuw");
                }
            }
        }
        public decimal Prijs { get; protected set;}
    }
}
