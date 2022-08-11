namespace Book.Tests
{
    using System;

    using NUnit.Framework;
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CtorInitialize()
        {
            string name = "Kniga";
            string author = "Ivan";
            Book book = new Book(name, author);
            Assert.AreEqual(book.BookName, name);
            Assert.AreEqual(book.Author, author);
        }
        [Test]
        public void CountThrowEx()
        {
            Book book = new Book("aza", "Ico");
            book.AddFootnote(1, "Text");
            int expectedCount = 1;
            Assert.AreEqual(expectedCount, book.FootnoteCount);
        }
        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void BookNameSetterShouldThrowExceptionIfNameNullOrEmpty(string bookName)
        {
            Assert.Throws<ArgumentException>(() => new Book(bookName, "Douglas Adams"));
        }


        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void AuthorSetterShouldThrowExceptionIfNameNullOrEmpty(string authorName)
        {
            Assert.Throws<ArgumentException>(() => new Book("Alice in Wonderland", authorName));
        }

        [Test]
        public void AddFootnoteMethodShouldThrowExceptionIfDuplicateFootnoteNumber()
        {
           Book book = new Book("Lord of the Rings", "J.R.R.Talkin");
            book.AddFootnote(1, "blah blah");
            Assert.Throws<InvalidOperationException>(() => book.AddFootnote(1, "someText"));
        }

        [Test]
        public void AddFootnoteMethodShouldIncreaseCountOfFootnotes()
        {
            Book book = new Book("Lord of the Rings", "J.R.R.Talkin");
            book.AddFootnote(1, "blah blah");
            book.AddFootnote(2, "someText");
            book.AddFootnote(3, "someOtherText");

            Assert.AreEqual(3, book.FootnoteCount);
        }

        [Test]
        public void FindFootnoteMethodShouldThrowExceptionIfFootnoteDoesNotExist()
        {
            Book book = new Book("Lord of the Rings", "J.R.R.Talkin");
            book.AddFootnote(1, "blah blah");
            Assert.Throws<InvalidOperationException>(() => book.FindFootnote(3));
        }

        [Test]
        public void FindFootnoteMethodShouldReturnInformationAboutFootnote()
        {
            Book book = new Book("Lord of the Rings", "J.R.R.Talkin");
            book.AddFootnote(1, "blah blah");
            string footnote = book.FindFootnote(1);

            Assert.AreEqual("Footnote #1: blah blah", footnote);
        }

        [Test]
        public void AlterFootnoteMethodShouldThrowExceptionIfFootnoteDoesNotExist()
        {
            Book book = new Book("Lord of the Rings", "J.R.R.Talkin");
            book.AddFootnote(1, "blah blah");
            Assert.Throws<InvalidOperationException>(() => book.AlterFootnote(3, "alteredText"));
        }

        [Test]
        public void AlterFootnoteShouldChangeTextOfExistingFootnote()
        {
            Book book = new Book("Lord of the Rings", "J.R.R.Talkin");
            book.AddFootnote(1, "blah blah");
            book.AlterFootnote(1, "alteredText");

            Assert.AreEqual("Footnote #1: alteredText", book.FindFootnote(1));
        }
    }

}
