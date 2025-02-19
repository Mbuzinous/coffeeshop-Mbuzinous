using CoffeeShopConsoleAppNet60;
using CoffeeShopConsoleAppNet60.CoffeeMachine;
using CoffeeShopConsoleAppNet60.Model;
using System.Security.Cryptography;

internal class Program
{
    public static void Main(string[] args)
    {
        CoffeeMachine coffeeMachine = new CoffeeMachine();
        Dictionary<int, User> users = new Dictionary<int, User>();


        Console.WriteLine("Hello, please write your first name");
        string firstName = Console.ReadLine() ?? "No first name";

        Console.WriteLine($"\n\n");

        Console.WriteLine("Now please write your last name");
        string lastName = Console.ReadLine() ?? "No last name";

        Console.WriteLine($"\n\n");

        users.Add(1, new User(firstName, lastName));
        Console.WriteLine($"Welcome {users[1].FirstName} {users[1].LastName} - ID: {users[1].Id}");
        int coffeeChoice = 0;
        while (true)
        {
            while (true)
            {
                Console.WriteLine($"\n\n");

                Console.WriteLine("---------- Coffee Machine ----------");
                Console.WriteLine($"Milk Capacity: {coffeeMachine.MilkCapacity}");
                Console.WriteLine("Press the number of the coffee you would like to choose.");
                Console.WriteLine($"\n");
                for (int coffeeNr = 1; coffeeNr <= coffeeMachine.coffeesDictionary.Count; coffeeNr++)
                {
                    Console.WriteLine($"{coffeeNr}: {coffeeMachine.coffeesDictionary[coffeeNr].CoffeeName.PadRight(20)}" +
                        $"{coffeeMachine.coffeesDictionary[coffeeNr].Strength().PadRight(20)} " +
                        $"Price: {coffeeMachine.coffeesDictionary[coffeeNr].Price(0)}");
                }
                Console.WriteLine("------------------------------------");

                Console.WriteLine($"\n\n");

                bool coffeeChoiceBool = true;

                while (coffeeChoiceBool)
                {

                    try
                    {
                        coffeeChoice = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"You have chosen nr: {coffeeChoice}: {coffeeMachine.coffeesDictionary[coffeeChoice].CoffeeName}");
                        coffeeChoiceBool = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }

                Console.WriteLine("Are you sure you want to choose this?\n1. Yes or 2. No");
                int confirmChoice = 0;
                bool confirmChoiceBool = true;
                while (confirmChoiceBool)
                {
                    try
                    {
                        confirmChoice = Convert.ToInt32(Console.ReadLine());

                        if (confirmChoice == 1 || confirmChoice == 2)
                        {
                            confirmChoiceBool = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{ex.Message}");
                    }

                    Console.WriteLine("Please write: 1. Yes or 2. No");
                }
                if (confirmChoice != 2)
                {
                    break;
                }
            }
            Console.WriteLine($"\n\n");

            Console.WriteLine($"Brewing...");
            for (int i = 0; i < 100; i += RandomNumberGenerator.GetInt32(16))
            {

                Console.WriteLine($"{i}%");

                Thread.Sleep(100);
            }

            coffeeMachine.ChooseCoffee(coffeeChoice);
            Console.WriteLine($"Here is your {coffeeMachine.coffeesDictionary[coffeeChoice].CoffeeName.PadRight(10)}{coffeeMachine.coffeesDictionary[coffeeChoice].Strength()}");
        }
    }
}