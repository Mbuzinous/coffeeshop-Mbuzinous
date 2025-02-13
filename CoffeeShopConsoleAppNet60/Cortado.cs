namespace CoffeeShopConsoleAppNet60
{
    public class Cortado : Coffee, IMilk
    {
        public Cortado(int discount) : base(discount)
        {
        }

        public int MlMilk()
        {
            return 40;
        }

        public override double Price()
        {
            return 25;
        }

        public override string Strength()
        {
            return "Medium";
        }
    }
}
