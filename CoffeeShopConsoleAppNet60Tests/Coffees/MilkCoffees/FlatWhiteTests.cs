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
    public class FlatWhiteTests
    {
        [TestMethod()]
        public void FlatWhite_Name_Test()
        {
            //Arrange
            Coffee flatWhite = new FlatWhite();

            //Act
            string result = flatWhite.CoffeeName;

            //Assert
            Assert.AreEqual("FlatWhite", result);
        }

        [TestMethod()]
        public void FlatWhite_Implements_IMilk_Test()
        {
            //Arrange
            Coffee flatWhite = new FlatWhite();

            //Act
            IMilk result = (IMilk)flatWhite;

            //Assert
            Assert.Equals(flatWhite, result);
        }
    }
}