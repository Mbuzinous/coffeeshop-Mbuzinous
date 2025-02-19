using CoffeeShopConsoleAppNet60.Coffees.BlackCoffees;
using CoffeeShopConsoleAppNet60.Coffees.MilkCoffees;
using CoffeeShopConsoleAppNet60.Interfaces;
using CoffeeShopConsoleAppNet60.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CoffeeShopConsoleAppNet60.CoffeeMachine
{
    public class CoffeeMachine
    {
        public int MilkCapacity { get; private set; }
        public Dictionary<int, Coffee> coffeesDictionary { get; private set; }

        public CoffeeMachine()
        {
            MilkCapacity = 3000;
            coffeesDictionary = new Dictionary<int, Coffee>();

            for (int i = 1; i <= 8; i++)
            {
                coffeesDictionary.Add(i, CreateCoffee(i));
            }
        }

        private Coffee CreateCoffee(int number)
        {
            switch (number)
            {
                case 1:
                    return new Americano();
                case 2:
                    return new Espresso();
                case 3:
                    return new CaffeMacchiato();
                case 4:
                    return new Cappuccino();
                case 5:
                    return new Cortado();
                case 6:
                    return new FlatWhite();
                case 7:
                    return new IceLatte();
                case 8:
                    return new Latte();
                default:
                    throw new ArgumentException("Ugyldig kaffetype");
            }
        }
        public Coffee ChooseCoffee(int choice)
        {
            var chosenCoffee = coffeesDictionary[choice];
            if (chosenCoffee is IMilk)
            {
                IMilk milkCoffee = (IMilk)chosenCoffee;
                MilkCapacity = MilkService.ExtractMilk(MilkCapacity, milkCoffee.MlMilk());
            }

            coffeesDictionary.Remove(choice);
            coffeesDictionary.Add(choice, CreateCoffee(choice));
            return chosenCoffee;
        }
    }
}
