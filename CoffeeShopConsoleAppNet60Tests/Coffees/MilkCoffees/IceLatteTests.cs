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
    public class IceLatteTests
    {
        [TestMethod()]
        public void IceLatte_Name_Test()
        {
            //Arrange
            Coffee iceLatte = new IceLatte();

            //Act
            string result = iceLatte.CoffeeName;

            //Assert
            Assert.AreEqual("IceLatte", result);
        }

        [TestMethod()]
        public void IceLatte_Implements_IMilk_Test()
        {
            //Arrange
            Coffee iceLatte = new IceLatte();

            //Act
            IMilk result = (IMilk)iceLatte;

            //Assert
            Assert.Equals(iceLatte, result);
        }
    }
}