using PastaPizzaNetUI.Models.GerechtModel.Enums;

namespace PastaPizzaNetUI.Models.GerechtModel
{
    internal class BesteldGerecht
    {
        private Grootte? grootte;
        private Extra[]? extra;

        public Gerecht? Gerecht { get; set; }
        public Grootte? Grootte
        {
            get
            {
                return grootte;
            }

            set
            {
                grootte = value;
                if (value == Enums.Grootte.Groot)
                {
                    Gerecht.Prijs += 3M;
                }
            }
        }
        public Extra[]? Extra
        {
            get
            {
                return extra;
            }

            set
            {
                extra = value;
                Gerecht.Prijs += extra.Length;
            }
        }
    }
}
