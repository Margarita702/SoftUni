using NUnit.Framework;
using System;

namespace SmartphoneShop.Tests
{
    [TestFixture]
    public class SmartphoneShopTests
    {
        [Test]
        public void CtorInitialize()
        {
         
            int capacit = 1;
            Shop shop = new Shop(capacit);        
            Assert.AreEqual(shop.Capacity, capacit);
        }
    
        [Test]
        public void CapacityThrowEx()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new Shop(-1);
            });
        }
        [Test]

        public void CountThrowEx()
        {
            Shop shop = new Shop(1);
            shop.Add(new Smartphone("iPhone",100));
            int expectedCount = 1;
            Assert.AreEqual(expectedCount, shop.Count);
        }
        [Test]
        public void AddSHouldThrowEx()
        {
            //!!!
             Shop shop = new Shop(2);
            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.Add(new Smartphone("Samsung", 29));
                shop.Add(new Smartphone("Samsung", 29));
            });
       

            Assert.Throws<InvalidOperationException>(() =>
            { shop.Add(new Smartphone("Samsung",29)); });
        }
        [Test]
        public void RemoveSHouldThrowEx()
        {
            //!!!
            Shop shop = new Shop( 1);
            Assert.Throws<InvalidOperationException>(() =>
            { shop.Remove(null); });
        }
        [Test]
        public void Remove()
        {

            Shop shop = new Shop(1);
            shop.Add(new Smartphone("Sams",34));

            shop.Remove("Sams");
            Assert.AreEqual(shop.Count, 0);
        }
        [Test]
        public void TestPhoneMethodShouldThrowExceptionIfDoesNotExist()
        {
            Shop shop = new Shop(2);

            shop.Add(new Smartphone("R2-D2", 100));
            shop.Add(new Smartphone("Sam", 50));

            Assert.Throws<InvalidOperationException>(() => shop.TestPhone("Becky", 60));
        }

        [Test]
        public void TestMethodShouldThrowExceptionIfBatteryNotEnough()
        {
            Shop shop = new Shop(2);

            shop.Add(new Smartphone("R2", 100));

            Assert.Throws<InvalidOperationException>(() => shop.TestPhone("R2", 105));
        }
        [Test]
        public void TestMethodShouldReduceBattery()
        {
            Shop shop = new Shop(2);
            Smartphone sm = new Smartphone("R2-D2", 100);

            shop.Add(sm);

            shop.TestPhone("R2-D2", 40);
            Assert.AreEqual(60, sm.CurrentBateryCharge);
        }

        [Test]
        public void ChargeMethodShouldThrowExceptionIfDoesNotExist()
        {
            Shop shop = new Shop(2);

            Assert.Throws<InvalidOperationException>(() => shop.ChargePhone("Becky"));
        }
        [Test]
        public void ChargeMethodShouldIncreaseBattery()
        {
            Shop shop = new Shop(2);
            Smartphone smartphone = new Smartphone("R2-D2", 100);

            shop.Add(smartphone);

            shop.TestPhone("R2-D2", 40);
            shop.TestPhone("R2-D2", 40);

            Assert.AreEqual(20, smartphone.CurrentBateryCharge);

            shop.ChargePhone("R2-D2");

            Assert.AreEqual(100, smartphone.CurrentBateryCharge);
        }
    }
}