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
    public class EspressoTests
    {
        [TestMethod()]
        public void Espresso_Name_Test()
        {
            //Arrange
            Coffee espresso = new Espresso();

            //Act
            string result = espresso.CoffeeName;

            //Assert
            Assert.AreEqual("Espresso", result);
        }
    }
}