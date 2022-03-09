using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib.Tests
{
    [TestClass()]
    public class CarTests
    {
        private Car car1;
        private Car car2;
        [TestInitialize]
        public void init()
        {
            car1 = new Car("Volvo", 125000, "AC 955", 1);
            car2 = new Car("Fiat", 89000, "KY 876", 2);
        }

        [TestMethod()]
        public void ConstructorTest()
        {
            Assert.AreEqual(1, car1.Id);
            Assert.AreEqual(2, car2.Id);
        }

        [TestMethod()]
        public void CarModelTest()
        {
            Assert.AreEqual("Volvo" , car1.Model);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car1.Model = "Kia");
        }

        [TestMethod()]
        public void PriceTest()
        {
            Assert.AreEqual(125000, car1.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car1.Price = -1);
        }

        [TestMethod()]
        public void LicensePlateTest()
        {
            Assert.AreEqual("AC 955", car1.LicensePlate);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car1.LicensePlate = "12345678");
        }
    }
}