using System;
using System.Collections.Concurrent;

namespace Presents.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class PresentsTests
    {
        [Test]
        public void ThrowExceptionIfPresentIsNullWhenCreatingABag()
        {
            Bag bag = new Bag();
            Present present = null;
            Assert.Throws<ArgumentNullException>(() =>
            { bag.Create(present);});
        }
        [Test]
        public void CreateMethodShouldThrowExceptionWhenAlreadyExist()
        {
            //When there is already present like this

            Assert.Throws<InvalidOperationException>(() =>
            {
              var bag=new Bag();
                var present = new Present("Misho", 25.5);
                bag.Create(present);
                bag.Create(present);

            });
        }
        [Test]
        public void CreateMethodShouldWork()
        {

            var bag = new Bag();
            var present = new Present("Misho", 25.5);


            var result =bag.Create(present);

            Assert.AreEqual("Successfully added present Misho.", result);
           
        }
        [Test]
      
        public void RemoveShouldReturnFalseIfPresentNotInBag()
        {
            Bag bag = new Bag();
            Present present = new Present("Socks", 5.8);

            bool result = bag.Remove(present);

            Assert.AreEqual(false, result);
        }

        [Test]
        public void RemoveShouldReturnTrueIfPresentInBag()
        {
            Bag bag = new Bag();
            Present present = new Present("Socks", 5.8);

            bag.Create(present);

            bool result = bag.Remove(present);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void GetPresentWithLeastMagicShouldWork()
        {
            Bag bag = new Bag();
            Present present1 = new Present("So", 5.8);
            Present present2 = new Present("Soc", 5.9);
            Present present3 = new Present("Sock", 6.8);


            bag.Create(present1);
            bag.Create(present2);
            bag.Create(present3);

            Present leastMagical = bag.GetPresentWithLeastMagic();

            Assert.AreEqual(present1, leastMagical);

        }
        [Test]
        public void GetPresentByGivenName()
        {
            Bag bag = new Bag();
            Present present1 = new Present("So", 5.8);
            Present present2 = new Present("Soc", 5.9);
            Present present3 = new Present("Sock", 6.8);


            bag.Create(present1);
            bag.Create(present2);
            bag.Create(present3);

            Present leastMagical = bag.GetPresent("So");

            Assert.AreEqual(present1, leastMagical);

        }
        [Test]
        public void GetPresentsShouldreturnCollectionOfPresents()
        {
            Bag bag = new Bag();

            Present present1 = new Present("Socks", 5.8);
            Present present2 = new Present("Earrings", 10.5);
            Present present3 = new Present("Toy Truck", 15.8);

            bag.Create(present1);
            bag.Create(present2);
            bag.Create(present3);

            var presents = bag.GetPresents();

            Assert.AreEqual(3, presents.Count);
        }
    }
}
