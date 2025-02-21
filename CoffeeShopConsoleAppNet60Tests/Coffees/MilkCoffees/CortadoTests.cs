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
    public class CortadoTests
    {
        [TestMethod()]
        public void Cortado_Name_Test()
        {
            //Arrange
            Coffee cortado = new Cortado();

            //Act
            string result = cortado.CoffeeName;

            //Assert
            Assert.AreEqual("Cortado", result);
        }

        [TestMethod()]
        public void Cortado_Implements_IMilk_Test()
        {
            //Arrange
            Coffee cortado = new Cortado();

            //Act
            IMilk result = (IMilk)cortado;

            //Assert
            Assert.Equals(cortado, result);
        }
    }
}