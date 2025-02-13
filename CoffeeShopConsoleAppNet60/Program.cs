// See https://aka.ms/new-console-template for more information
using CoffeeShopConsoleAppNet60;


List<Coffee> coffees = new List<Coffee>();
try
{
    coffees.Add(new Latte(0));
    coffees.Add(new Cortado(66));
    coffees.Add(new BlackCoffee(1));
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
foreach (Coffee coffee in coffees)
{

    Console.WriteLine($"Price: {coffee.Price()}");
    Console.WriteLine($"Price: {coffee.Strength()}");
    if (coffee is IMilk)
    {
        IMilk milkCof = (IMilk)coffee;
        Console.WriteLine($"Milk ML: {milkCof.MlMilk()}\n");
    }

}

