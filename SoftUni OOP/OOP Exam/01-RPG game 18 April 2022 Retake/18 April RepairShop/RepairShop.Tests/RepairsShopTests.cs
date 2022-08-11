using NUnit.Framework;
using System;

namespace RepairShop.Tests
{
    [TestFixture]

    public class Tests
    {
        public class RepairsShopTests
        {
            [Test]
            public void CtorInitialize()
            {
                string name = "aname";
                int capacit = 1;
                Garage garage = new Garage(name, capacit);
                Assert.AreEqual(garage.Name, name);
                Assert.AreEqual(garage.MechanicsAvailable, capacit);
            }
            [Test]
            public void SetNameThrowException()
            {
                Assert.Throws<ArgumentNullException>(() =>
                { new Garage(null, 1); });
                Assert.Throws<ArgumentNullException>(() =>
                { new Garage(string.Empty, 1); });
            }
            [Test]
            public void CapacityThrowEx()
            {
                Assert.Throws<ArgumentException>(() =>
                {
                    new Garage("a", -1);
                });
                Assert.Throws<ArgumentException>(() =>
                {
                    new Garage("a", 0);
                });
            }
            [Test]

            public void CountThrowEx()
            {
                Garage garage = new Garage("a", 1);
                garage.AddCar(new Car("a",1));
                int expectedCount = 1;
                Assert.AreEqual(expectedCount, garage.CarsInGarage);
            }
            [Test]
            public void AddMethodShouldThrowExceptionIfGarageFull()
            {
                Garage fullGarage;
                fullGarage = new Garage("Bobby's", 3);
                fullGarage.AddCar(new Car("Opel", 2));
                fullGarage.AddCar(new Car("Toyota", 3));
                fullGarage.AddCar(new Car("BMW", 3));
                Car car = new Car("KIA", 3);
                Assert.Throws<InvalidOperationException>(() => fullGarage.AddCar(car));
            }

            [Test]
            public void FixCarShouldThrowExceptionIfCarNotInGarage()
            {
                Garage fullGarage;
                fullGarage = new Garage("Bobby's", 3);
                fullGarage.AddCar(new Car("Opel", 2));
                fullGarage.AddCar(new Car("Toyota", 3));
                fullGarage.AddCar(new Car("BMW", 3));

                Assert.Throws<InvalidOperationException>(() => fullGarage.FixCar("Honda"));
            }

            [Test]
            public void FixCarShouldFixTheCar()
            {
                Garage garage = new Garage("Bill's", 2);
                Car car = new Car("Opel", 3);
                garage.AddCar(car);

                garage.FixCar("Opel");

                Assert.AreEqual(0, car.NumberOfIssues);
            }

            [Test]
            public void RemoveFixedCarsShouldReduceCarsCount()
            {
                Garage fullGarage;
                fullGarage = new Garage("Bobby's", 3);
                fullGarage.AddCar(new Car("Opel", 2));
                fullGarage.AddCar(new Car("Toyota", 3));
                fullGarage.AddCar(new Car("BMW", 3));
                fullGarage.FixCar("Opel");
                fullGarage.FixCar("Toyota");

                fullGarage.RemoveFixedCar();

                Assert.AreEqual(1, fullGarage.CarsInGarage);
            }

            [Test]
            public void RemoveFixedCarsShouldThrowExceptionIfNoFixedCars()
            {
                Garage fullGarage ;
                fullGarage = new Garage("Bobby's", 3);
                fullGarage.AddCar(new Car("Opel", 2));
                fullGarage.AddCar(new Car("Toyota", 3));
                fullGarage.AddCar(new Car("BMW", 3));
                Assert.Throws<InvalidOperationException>(() => fullGarage.RemoveFixedCar());
            }

            [Test]
            public void ReportMethodShodReturnInformationAboutCarsThatAreNotFixed()
            {
                Garage fullGarage;
                fullGarage = new Garage("Bobby's", 3);
                fullGarage.AddCar(new Car("Opel", 2));
                fullGarage.AddCar(new Car("Toyota", 3));
                fullGarage.AddCar(new Car("BMW", 3));
                fullGarage.FixCar("Toyota");

                string report = fullGarage.Report();

                Assert.AreEqual("There are 2 which are not fixed: Opel, BMW.", report);
            }
        }
    }
}