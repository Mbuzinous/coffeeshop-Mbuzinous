using CoffeeShopConsoleAppNet60.Interfaces;

namespace CoffeeShopConsoleAppNet60.Coffees.MilkCoffees
{
    public class Cortado : Coffee, IMilk
    {
        private int MilkInMilliliter { get; set; } = 40;
        public Cortado() : base(25, "Strong", "Cortado") { }

        public int MlMilk()
        {
            return MilkInMilliliter;
        }
    }
}
