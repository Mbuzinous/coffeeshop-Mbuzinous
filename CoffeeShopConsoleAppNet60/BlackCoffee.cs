namespace CoffeeShopConsoleAppNet60
{
    public class BlackCoffee : Coffee
    {
        public BlackCoffee(int discount) : base(discount) { }

        public override string Strength()
        {
            return "Strong";
        }
    }
}
