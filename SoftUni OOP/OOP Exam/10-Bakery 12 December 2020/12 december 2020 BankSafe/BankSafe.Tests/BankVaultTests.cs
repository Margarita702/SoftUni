using NUnit.Framework;
using System;
using System.Linq;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private BankVault vault;
        private Item item;
        [SetUp]
        public void Setup()
        {
            vault=new BankVault();
            item = new Item("me", "1");
        }

        [Test]
        public void ThrowArgumentExceptionIfCellDoesNotExist()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.AddItem("go nqma", item);
            });
            Assert.AreEqual(ex.Message, "Cell doesn't exists!");
        }
        [Test]
        public void ThrowArgumentExceptionIfCellIsAlreadyTaken()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.AddItem("A2", item);
                vault.AddItem("A2", new Item("pesho", "3"));
            });
            Assert.AreEqual(ex.Message, "Cell is already taken!");
        }

        [Test]
        public void ThrowArgumentExceptionIfItemIsAlreadyInCell()
        {
            Exception ex = Assert.Throws<InvalidOperationException>(() =>
            {
                vault.AddItem("A2", item);
                vault.AddItem("B3", item);
            });
            Assert.AreEqual(ex.Message, "Item is already in cell!");
        }
        [Test]
        public void PassedTestWithNoExceprions()
        {
            string result = vault.AddItem("A2", item);
            Assert.AreEqual(result, $"Item:{item.ItemId} saved successfully!");
        }
        [Test]
        public void ThrowArgumentExceptionIfCellDoesNotExistForRemove()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.RemoveItem("go nqma", item);
            });
            Assert.AreEqual(ex.Message, "Cell doesn't exists!");
        }


        [Test]
        public void ThrowArgumentExceptionIfItemDoesNotExistForRemove()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.RemoveItem("A2", item);
            });
            Assert.AreEqual(ex.Message, "Item in that cell doesn't exists!");
        }

      
        [Test]
        public void PassedForRemove()
        {
            vault.AddItem("A2", item);

            string result = vault.RemoveItem("A2", item);

            Assert.AreEqual(result, $"Remove item:1 successfully!");
        }

   
    }
}