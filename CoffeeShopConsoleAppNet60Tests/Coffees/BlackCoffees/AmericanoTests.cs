using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeShopConsoleAppNet60.Coffees.BlackCoffees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60.Coffees.BlackCoffees.Test
{
    [TestClass()]
    public class AmericanoTests
    {
        [TestMethod()]
        public void Americano_Name_Test()
        {
            //Arrange
            Coffee americano = new Americano();

            //Act
            string result = americano.CoffeeName;

            //Assert
            Assert.AreEqual("Americano", result);
        }
    }
}