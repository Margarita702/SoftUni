namespace Robots.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class RobotsTests
    {
        [Test]
        public void CtorInitialize()
        {
            int capacit = 1;
            RobotManager rob = new RobotManager(capacit);
            Assert.AreEqual(rob.Capacity, capacit);
        }
        [Test]
        public void CapacityThrowEx()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new RobotManager(-1);
            });
        }

        [Test]
        public void CountThrowEx()
        {
            RobotManager rob = new RobotManager(1);
            rob.Add(new Robot("a", 100));
            int expectedCount = 1;
            Assert.AreEqual(expectedCount, rob.Count);
        }
        [Test]
        public void AddMethodShouldThrowExceptionWhenAlreadyExist()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var rob = new RobotManager(2);
                rob.Add(new Robot("a", 100));
                rob.Add(new Robot("a", 100));

            });
        }
        [Test]
        public void AddMethodShouldThrowExceptionWhenFullCapacity()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var rob = new RobotManager(2);
                rob.Add(new Robot("a", 100));
                rob.Add(new Robot("a", 100));
                rob.Add(new Robot("a", 100));


            });
        }
        [Test]
        public void RemoveMethodShouldThrowExceptionIfRobotDoesNotExist()
        {
            RobotManager robotManager = new RobotManager(2);

            robotManager.Add(new Robot("R2-D2", 100));
            robotManager.Add(new Robot("Sam", 50));

            Assert.Throws<InvalidOperationException>(() => robotManager.Remove("Becky"));
        }
        [Test]
        public void WorkMethodShouldThrowExceptionIfRobotDoesNotExist()
        {
            RobotManager robotManager = new RobotManager(2);

            robotManager.Add(new Robot("R2-D2", 100));
            robotManager.Add(new Robot("Sam", 50));

            Assert.Throws<InvalidOperationException>(() => robotManager.Work("Becky", "Clean", 60));
        }

        [Test]
        public void WorkMethodShouldThrowExceptionIfBatteryNotEnough()
        {
            RobotManager robotManager = new RobotManager(2);

            robotManager.Add(new Robot("R2", 100));

            Assert.Throws<InvalidOperationException>(() => robotManager.Work("R2", "Clean", 105));
        }
        [Test]
        public void WorkMethodShouldReduceRobotBattery()
        {
            RobotManager robotManager = new RobotManager(2);
            Robot robot1 = new Robot("R2-D2", 100);

            robotManager.Add(robot1);

            robotManager.Work("R2-D2", "Clean", 40);
            Assert.AreEqual(60, robot1.Battery);
        }
        [Test]
        public void ChargeMethodShouldThrowExceptionIfRobotDoesNotExist()
        {
            RobotManager robotManager = new RobotManager(2);

            Assert.Throws<InvalidOperationException>(() => robotManager.Charge("Becky"));
        }
        [Test]
        public void ChargeMethodShouldIncreaseRobotBattery()
        {
            RobotManager robotManager = new RobotManager(2);
            Robot robot1 = new Robot("R2-D2", 100);

            robotManager.Add(robot1);

            robotManager.Work("R2-D2", "Clean", 40);
            robotManager.Work("R2-D2", "Clean", 40);

            Assert.AreEqual(20, robot1.Battery);

            robotManager.Charge("R2-D2");

            Assert.AreEqual(100, robot1.Battery);
        }

    }
}
