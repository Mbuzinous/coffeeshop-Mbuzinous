namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {
        public int Discount { get; set; }
        private int CoffePrice { get; set; } = 20;

        public Coffee(int discount)
        {
            Discount = discount;
        }
        public abstract string Strength();
        public virtual double Price()
        {
            if (ValidateDiscount(Discount)) 
            {
                return CoffePrice;
            }
            
        }
        protected bool ValidateDiscount(int discount)
        {
            if (discount < 5) { return true; }
            return false;
        }


    }
}
