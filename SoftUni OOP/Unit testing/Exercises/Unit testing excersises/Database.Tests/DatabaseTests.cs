namespace Database.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class DatabaseTests
    {
        [TestCase(new[] { 1 })]
        [TestCase(new int[0])]
        [TestCase(new[] { 20, 14, 16, 100, 1000 })]
        [TestCase(new[] { int.MaxValue, int.MinValue })]
        public void Ctor_Should_Create_Data_When_Valid_And_Pass(int[] parametres)
        {
        Database database = new Database();
            Assert.AreEqual(parametres.Length,database.Count);
        }
     
        [TestCase(new[] { 1, 2 },
        new[] { 10, 15 }, 4
        )]
        [TestCase(new int[0],
            new[] { int.MaxValue, int.MinValue, 53535 },3)]
        [TestCase(new int[0],
            new[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16 },16)]
        public void Add_With_Valid_Data_Should_Work(int[] ctorParametres,
            int[] paramsToAdd, int expectedCount)
        {
            Database database = new Database(ctorParametres);
            for (int i = 0; i < paramsToAdd.Length; i++)
            {
                database.Add(paramsToAdd[i]);

            }

            Assert.AreEqual(expectedCount,database.Count);
        }
        [Test]
        public void AddMethodShouldThrowExceptionWhenAddingMoreThan17Items()
        {
            var elements = Enumerable.Range(1, 16).ToArray();
            Database database = new Database(elements);

            Assert.Throws<InvalidOperationException>(() => database.Add(1));
        }

        [Test]
        [TestCase(1, 4)]
        [TestCase(1, 15)]
        [TestCase(1, 16)]
        public void ConstructorShouldAddElementsWhileLessThan16(int start, int end)
        {
            var elements = Enumerable.Range(start, end).ToArray();

            Database database = new Database(elements);

            Assert.AreEqual(end, database.Count);
        }
        [Test]
        public void ConstructorShouldThrowExceptionIfElementsMoreThan16()
        {
            var elements = Enumerable.Range(1, 17).ToArray();

            Assert.Throws<InvalidOperationException>(() => new Database(elements));
        }


        [Test]
        [TestCase(16)]
        [TestCase(2)]
        [TestCase(1)]
        public void RemoveShouldRemoveItemsWhenCollectionHasMoreThan0Elements(int count)
        {
            var elements = Enumerable.Range(1, count).ToArray();
            Database database = new Database(elements);

            database.Remove();

            Assert.AreEqual(count - 1, database.Count);
        }

        [Test]
        public void RemoveShouldThrowExceptionWhenCollectionHas0Elements()
        {
            Database database = new Database();

            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void FetchShouldReturnAllValidItems()
        {
            Database database = new Database(1, 2, 3);
            database.Add(4);
            database.Add(5);
            database.Add(6);

            database.Remove();
            database.Remove();

            int[] fetched = database.Fetch();
            int[] expectedData = new int[] { 1, 2, 3, 4 };

            CollectionAssert.AreEqual(fetched, expectedData);
        }
    }
}
