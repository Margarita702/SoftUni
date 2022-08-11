using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Computers.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CtorShouldInitializeAllCollections()
        {
            ComputerManager compMan = new ComputerManager();
            Assert.NotNull(compMan.Computers);
        }
        [Test]
        public void CountThrowEx()
        {
            ComputerManager compMan = new ComputerManager();
            compMan.AddComputer(new Computer("Asus", "Hoh", 200));
            int expectedCount = 1;
            Assert.AreEqual(expectedCount, compMan.Count);
        }

        [Test]
        public void ValidateCompAdd()
        {
            ComputerManager compMan = new ComputerManager();

            Assert.Throws<ArgumentNullException>(() =>
            {
                compMan.AddComputer(null);
            });
        }

        [Test]
        public void AddComputerMethodShouldWorkProperly()
        {
            var manager = new ComputerManager();
            manager.AddComputer(new Computer("Dell", "S50", 1000));

            Assert.AreEqual(1, manager.Count);
        }

        [Test]
        public void AddComputerShouldThrowExceptionIfComputerAlreadyExists()
        {
            var manager = new ComputerManager();
            Computer computer = new Computer("Dell", "S50", 1000);
            manager.AddComputer(computer);

            Assert.Throws<ArgumentException>(() => manager.AddComputer(computer));
        }

        [Test]
        public void ThrowArgumentExceptionIfItemDoesNotExistForRemove()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                ComputerManager compMan = new ComputerManager();

                var computer = new Computer("Pesho", "Asus", 2500);
                compMan.RemoveComputer("Pesho", "Asus");

            });
            Assert.AreEqual(ex.Message, "There is no computer with this manufacturer and model.");
        }

        [Test]
        public void RemoveComputerShouldReduceCount()
        {
            var manager = new ComputerManager();

            Computer computer1 = new Computer("Assus", "S50", 1000);
            Computer computer2 = new Computer("Dell", "S50", 1000);
            Computer computer3 = new Computer("Lenovo", "S50", 1000);

            manager.AddComputer(computer1);
            manager.AddComputer(computer2);
            manager.AddComputer(computer3);

            Assert.AreEqual(3, manager.Count);

            manager.RemoveComputer("Dell", "S50");

            Assert.AreEqual(2, manager.Count);
        }

        [Test]
        public void RemoveComputerShouldReturnRemovedComputer()
        {
            var manager = new ComputerManager();

            Computer computer1 = new Computer("Assus", "S50", 1000);
            Computer computer2 = new Computer("Dell", "S50", 1000);

            manager.AddComputer(computer1);
            manager.AddComputer(computer2);

            var removed = manager.RemoveComputer("Dell", "S50");

            Assert.AreEqual(removed, computer2);
        }


        [Test]
        public void GetComputerShouldThrowExceptionIfComputerNotInCollection()
        {
            var manager = new ComputerManager();

            Computer computer1 = new Computer("Assus", "S50", 1000);

            manager.AddComputer(computer1);

            Assert.Throws<ArgumentException>(() => manager.GetComputer("Dell", "S50"));
        }


        [Test]
        public void GetComputerShouldWorkCorrectly()
        {
            ComputerManager computerManager = new ComputerManager();
            var computer = new Computer("Pesho", "Asus", 2500);

            computerManager.AddComputer(computer);
     
            var result = computerManager.GetComputer("Pesho", "Asus");

            Assert.AreSame(computer, result);
        }
        [Test]
        public void GetComputersByManufacturerShouldWorkProperly()
        {
            var manager = new ComputerManager();

            Computer computer1 = new Computer("Dell", "S10", 1000);
            Computer computer2 = new Computer("Lenovo", "S20", 1000);
            Computer computer3 = new Computer("Dell", "S30", 1000);
            Computer computer4 = new Computer("Assus", "S50", 1000);

            manager.AddComputer(computer1);
            manager.AddComputer(computer2);
            manager.AddComputer(computer3);
            manager.AddComputer(computer4);
            var computersByManufacturer = manager.GetComputersByManufacturer("Dell");
            List<Computer> computers = new List<Computer> { computer1, computer3 };

            CollectionAssert.AreEqual(computers, computersByManufacturer);
        }

        [Test]

        public void ValidateMethodShouldWorkProperly()
        {
            var manager = new ComputerManager();

            Computer computer1 = new Computer("Assus", "S50", 1000);
            Computer computer2 = new Computer("Dell", "S50", 1000);

            manager.AddComputer(computer1);
            manager.AddComputer(computer2);

            Assert.Throws<ArgumentNullException>(() => manager.RemoveComputer(null, null));
            Assert.That(() => manager.AddComputer(null), Throws.ArgumentNullException.With.Message.EqualTo("Can not be null! (Parameter 'computer')"));

        }

        [Test]
        public void ComputersPropertyShouldBeReadOnly()
        {
            var type = typeof(ComputerManager);
            var propertyInfo = type.GetProperty("Computers");
            Assert.That(propertyInfo.CanWrite == false);
        }

    }
}