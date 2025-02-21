using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeShopConsoleAppNet60.Coffees.MilkCoffees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopConsoleAppNet60.Interfaces;

namespace CoffeeShopConsoleAppNet60.Coffees.MilkCoffees.Test
{
    [TestClass()]
    public class LatteTests
    {
        [TestMethod()]
        public void Latte_Name_Test()
        {
            //Arrange
            Coffee latte = new Latte();

            //Act
            string result = latte.CoffeeName;

            //Assert
            Assert.AreEqual("Latte", result);
        }

        [TestMethod()]
        public void Latte_Implements_IMilk_Test()
        {
            //Arrange
            Coffee latte = new Latte();

            //Act
            IMilk result = (IMilk)latte;

            //Assert
            Assert.Equals(latte, result);
        }
    }
}