using CoffeeShopConsoleAppNet60.Interfaces;

namespace CoffeeShopConsoleAppNet60.Coffees.MilkCoffees
{
    public class Cappuccino : Coffee, IMilk
    {
        private int MilkInMilliliter { get; set; } = 180;
        public Cappuccino() : base(40, "Weak", "Cappuccino") { }

        public int MlMilk()
        {
            return MilkInMilliliter;
        }
    }
}
