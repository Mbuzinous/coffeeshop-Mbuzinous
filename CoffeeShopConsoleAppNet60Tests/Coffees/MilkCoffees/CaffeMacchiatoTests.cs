using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeShopConsoleAppNet60.Coffees.MilkCoffees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopConsoleAppNet60.Coffees.BlackCoffees;
using CoffeeShopConsoleAppNet60.Interfaces;

namespace CoffeeShopConsoleAppNet60.Coffees.MilkCoffees.Test
{
    [TestClass()]
    public class CaffeMacchiatoTests
    {
        [TestMethod()]
        public void CaffeMacchiato_Name_Test()
        {
            //Arrange
            Coffee caffeMacchiato = new CaffeMacchiato();

            //Act
            string result = caffeMacchiato.CoffeeName;

            //Assert
            Assert.AreEqual("CaffeMacchiato", result);
        }

        [TestMethod()]
        public void CaffeMacchiato_Implements_IMilk_Test()
        {
            //Arrange
            Coffee caffeMacchiato = new CaffeMacchiato();

            //Act
            IMilk result = (IMilk)caffeMacchiato;

            //Assert
            Assert.Equals(caffeMacchiato, result);
        }

        [TestMethod()]
        public void CaffeMacchiato_Milk_Method_Test()
        {
            //Arrange
            IMilk caffeMacchiato = new CaffeMacchiato();
            int expected = 30;

            //Act
            int result = caffeMacchiato.MlMilk();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}