namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {
        public string CoffeeName { get; private set; }
        private double CoffeePrice { get; set; } = 20;

        private string CoffeeStrength { get; set; }

        public Coffee(double price, string strength, string coffeeName)
        {
            CoffeePrice = price;
            CoffeeStrength = strength;
            CoffeeName = coffeeName;

        }

        public string Strength()
        {
            return CoffeeStrength;
        }
        public double Price(int discount)
        {
            if (discount < 5) 
            {
                return CoffeePrice - discount;
            }
            else
            {
                throw new Exception("Discount er for stort");
            }
            
        }
    }
}
