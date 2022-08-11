using NUnit.Framework;
using System;
namespace Gyms.Tests
{
    [TestFixture]

    public class GymsTests
    {
        // Implement unit tests here
        [Test]
        public void CtorInitialize()
        {
            string name = "Gosho";
            int capacit = 1;
            Gym newGym = new Gym(name, capacit);
            Assert.AreEqual(newGym.Name, name);
            Assert.AreEqual(newGym.Capacity, capacit);
        }
        [Test]
        public void SetNameThrowException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            { new Gym(null, 1); });
            Assert.Throws<ArgumentNullException>(() =>
            { new Gym(string.Empty, 1); });
        }
        [Test]
        public void CapacityThrowEx()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new Gym("g", -1);
            });
        }
        [Test]

        public void CountThrowEx()
        {
            Gym newgym = new Gym("a", 1);
            newgym.AddAthlete(new Athlete("a"));
            int expectedCount = 1;
            Assert.AreEqual(expectedCount, newgym.Count);
        }

        [Test]
        public void AddSHouldThrowEx()
        {
            //!!!
            Gym gym = new Gym("ta", 0);
            Assert.Throws<InvalidOperationException>(() =>
            { gym.AddAthlete(new Athlete("Sasho")); });
        }
        [Test]
        public void RemoveSHouldThrowEx()
        {
            //!!!
            Gym gym = new Gym("a", 1);
            Assert.Throws<InvalidOperationException>(() =>
            { gym.RemoveAthlete(null); });
        }
        [Test]
        public void Remove()
        {

            Gym gym = new Gym("a", 1);
            gym.AddAthlete(new Athlete("fiy"));

            gym.RemoveAthlete("fiy");
            Assert.AreEqual(gym.Count, 0);
        }

        [Test]
        public void InjuredAthleteThrowEx()
        {

            Gym gym = new Gym("a", 1);
            Assert.Throws<InvalidOperationException>(() =>
            { gym.InjureAthlete(null); });

        }
        [Test]
        public void InjAth()
        {
            Gym gym = new Gym("a", 1);
            gym.AddAthlete(new Athlete("fiy"));

            Athlete athlete = gym.InjureAthlete("fiy");
            Assert.AreEqual(athlete.FullName, "fiy");
            Assert.AreEqual(athlete.IsInjured, true);

        }

        [Test]
        public void CheckReport()
        {
            Gym gym = new Gym("a", 1);
            gym.AddAthlete(new Athlete("fiy"));
            string expMess = "Active athletes at a: fiy";

            Assert.AreEqual(expMess, gym.Report());

        }

    }
}
