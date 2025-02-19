using CoffeeShopConsoleAppNet60;
using CoffeeShopConsoleAppNet60.Coffees.BlackCoffees;

namespace CoffeeShopTest
{
    [TestClass]
    public sealed class PriceTest
    {
        [DataTestMethod]
        [DataRow(1, 19)]
        [DataRow(2, 18)]
        [DataRow(3, 17)]
        [DataRow(4, 16)]
        public void Test_Price_Method_Americano(int discount, int expected)
        {
            //Arrange
            Coffee americano = new Americano();

            //Act
            double result = americano.Price(discount);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(1, 15)]
        [DataRow(2, 14)]
        [DataRow(3, 13)]
        [DataRow(4, 12)]
        public void Test_Not_Price_Method_Americano(int discount, int expected)
        {
            //Arrange
            Coffee americano = new Americano();

            //Act
            double result = americano.Price(discount);

            //Assert
            Assert.AreNotEqual(expected, result);
        }
    }
}
