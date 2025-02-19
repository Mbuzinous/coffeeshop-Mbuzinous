using CoffeeShopConsoleAppNet60.Interfaces;

namespace CoffeeShopConsoleAppNet60.Coffees.MilkCoffees
{
    public class FlatWhite : Coffee, IMilk
    {
        private int MilkInMilliliter { get; set; } = 160;
        public FlatWhite() : base(40, "Medium", "Flat White") { }

        public int MlMilk()
        {
            return MilkInMilliliter;
        }
    }
}
