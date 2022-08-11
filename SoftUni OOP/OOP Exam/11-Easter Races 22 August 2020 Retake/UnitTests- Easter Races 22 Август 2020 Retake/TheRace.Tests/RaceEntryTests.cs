using NUnit.Framework;
using System;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddDriverMethodShouldThrowExceptionWhenNullIsPassed()
        {
            //When the driver is null 


            Assert.Throws<InvalidOperationException>(() =>
            {
                var raceEntry = new RaceEntry();
                raceEntry.AddDriver(null);
            });
        }
        [Test]
        public void AddDriverMethodShouldThrowExceptionWhenAlreadyExist()
        {
            //When there is already driver like this


            Assert.Throws<InvalidOperationException>(() =>
            {
                var raceEntry = new RaceEntry();
                var unitCar = new UnitCar("model", 10, 20);
                var unitDriver = new UnitDriver("Pesho", unitCar);
                raceEntry.AddDriver(unitDriver);
                raceEntry.AddDriver(unitDriver);
            });
        }
        [Test]
        public void AddDriverMethodShouldWork()
        {

            var raceEntry = new RaceEntry();
            var unitCar = new UnitCar("model", 10, 10);
            var unitDriver = new UnitDriver("Gosho", unitCar);

            var result = raceEntry.AddDriver(unitDriver);

            Assert.AreEqual("Driver Gosho added in race.", result);
            Assert.AreEqual(1, raceEntry.Counter);

        }
        [Test]
        public void CalculateAverageHorsePowerShouldThrowExceptionWhenThereAreNotEnoughPeople()
        {

            Assert.Throws<InvalidOperationException>(() =>
            {

                var raceEntry = new RaceEntry();
                var unitCar = new UnitCar("model", 10, 20);
                var unitDriver = new UnitDriver("Pesho", unitCar);

                var result = raceEntry.AddDriver(unitDriver);
                raceEntry.CalculateAverageHorsePower();

            });

        }
        [Test]
        public void CalculateAverageHorsePowerShouldWork()
        {

            var raceEntry = new RaceEntry();

            var unitCar = new UnitCar("VW", 100, 200);
            var unitDriver = new UnitDriver("Kiro", unitCar);

            var unitCar2 = new UnitCar("BMW", 100, 10000);
            var unitDriver2 = new UnitDriver("Ivan", unitCar);

            var unitCar3 = new UnitCar("Lada", 100, 2500);
            var unitDriver3 = new UnitDriver("Stoyan", unitCar);

            raceEntry.AddDriver(unitDriver);
            raceEntry.AddDriver(unitDriver2);
            raceEntry.AddDriver(unitDriver3);

            var result = raceEntry.CalculateAverageHorsePower();

            Assert.AreEqual(100, result);

        }
    }
}