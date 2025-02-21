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
    public class CappuccinoTests
    {
        [TestMethod()]
        public void Cappuccino_Name_Test()
        {
            //Arrange
            Coffee cappuccino = new Cappuccino();

            //Act
            string result = cappuccino.CoffeeName;

            //Assert
            Assert.AreEqual("Cappuccino", result);
        }

        [TestMethod()]
        public void Cappuccino_Implements_IMilk_Test()
        {
            //Arrange
            Coffee cappuccino = new Cappuccino();

            //Act
            IMilk result = (IMilk)cappuccino;

            //Assert
            Assert.Equals(cappuccino, result);
        }

        [TestMethod()]
        public void Cappuccino_Milk_Method_Test()
        {
            //Arrange
            IMilk cappuccino = new Cappuccino();
            int expected = 180;

            //Act
            int result = cappuccino.MlMilk();

            //Assert
            Assert.AreEqual(expected, result);
        }

    }
}