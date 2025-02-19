using CoffeeShopConsoleAppNet60.Interfaces;

namespace CoffeeShopConsoleAppNet60.Coffees.MilkCoffees
{
    public class Latte : Coffee, IMilk
    {
        private int MilkInMilliliter { get; set; } = 200;
        public Latte() : base(40, "Weak", "Latte") { }
        public int MlMilk()
        {
            return MilkInMilliliter;
        }
    }
}
