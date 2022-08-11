namespace Aquariums.Tests
{
    using System;
    using NUnit.Framework;
    //В решението на тази задача не се проверяват дали съобщенията 
    //от тестовете съвпадат с тези от главния файл

    [TestFixture]
    public class AquariumsTests
    {
        [Test]
        public void CtorInitialize()
        {
            string name = "aname";
            int capacit = 1;
            Aquarium aquarium = new Aquarium(name, capacit);
            Assert.AreEqual( aquarium.Name, name);
            Assert.AreEqual(aquarium.Capacity,capacit);
        }
        [Test]
        public void SetNameThrowException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {new Aquarium(null, 1);});
            Assert.Throws<ArgumentNullException>(() =>
            { new Aquarium(string.Empty, 1); });
        }
        [Test]
        public void CapacityThrowEx()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new Aquarium("a",-1);   
            });
        }
        [Test]

        public void CountThrowEx()
        {
            Aquarium aquarium = new Aquarium("a", 1);
            aquarium.Add(new Fish("a"));
            int expectedCount = 1;
            Assert.AreEqual(expectedCount,aquarium.Count);
        }
        [Test]
        public void AddSHouldThrowEx()
        {
            //!!!
            Aquarium aquarium = new Aquarium("ta", 0);
            Assert.Throws<InvalidOperationException>(() =>
            { aquarium.Add(new Fish("fishy")); });
        }
        [Test]
        public void RemoveSHouldThrowEx()
        {
            //!!!
            Aquarium aquarium = new Aquarium("a", 1);
            Assert.Throws<InvalidOperationException>(() =>
            { aquarium.RemoveFish(null); });
        }
        [Test]
        public void Remove()
        {
            
            Aquarium aquarium = new Aquarium("a", 1);
             aquarium.Add(new Fish("fiy"));

            aquarium.RemoveFish("fiy");
            Assert.AreEqual(aquarium.Count,0);
        }
        [Test]
        public void SellFishShouldThrowEx()
        {

            Aquarium aquarium = new Aquarium("a", 1);
            Assert.Throws<InvalidOperationException>(() =>
            { aquarium.SellFish(null); });

        }
        [Test]
        public void SellFish()
        {
            Aquarium aquarium = new Aquarium("a", 1);
            aquarium.Add(new Fish("fiy"));

            Fish fish=aquarium.SellFish("fiy");
            Assert.AreEqual(fish.Name, "fiy");
            Assert.AreEqual(fish.Available, false);

        }
        
        [Test]
        public void CheckReport()
        {
            Aquarium aquarium = new Aquarium("a", 1);
            aquarium.Add(new Fish("fiy"));
            string expMess = "Fish available at a: fiy";

            Assert.AreEqual(expMess, aquarium.Report());
           
        }

    }
}
