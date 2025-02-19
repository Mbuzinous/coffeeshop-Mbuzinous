using CoffeeShopConsoleAppNet60.Interfaces;

namespace CoffeeShopConsoleAppNet60.Coffees.MilkCoffees
{
    public class CaffeMacchiato : Coffee, IMilk
    {
        private int MilkInMilliliter { get; set; } = 30;
        public CaffeMacchiato() : base(25, "Strong", "Caffe Macchiato") { }

        public int MlMilk()
        {
            return MilkInMilliliter;
        }
    }
}
