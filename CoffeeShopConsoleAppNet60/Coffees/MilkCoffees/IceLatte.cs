using CoffeeShopConsoleAppNet60.Interfaces;

namespace CoffeeShopConsoleAppNet60.Coffees.MilkCoffees
{
    public class IceLatte : Coffee, IMilk
    {
        public int IcePieces { get; private set; } = 5;

        private int MilkInMilliliter { get; set; } = 150;
        public IceLatte() : base(40, "Weak", "IceLatte") { }

        public int MlMilk()
        {
            return MilkInMilliliter;
        }
    }
}
