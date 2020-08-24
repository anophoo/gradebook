using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void ShouldReturnDifferentObjects()
        {
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            // assert
            Assert.NotSame(book1, book2);
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }

        [Fact]
        public void ShouldReferenceSameObjects()
        {
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;

            // assert
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        [Fact]
        public void ShouldReturnChangedName()
        {
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;

            // act
            book1.Name = "Book other";

            // assert
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
            Assert.Equal("Book other", book2.Name);
        }

        [Fact]
        public void ShouldReturnDifferentReferences()
        {
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 1");

            // assert
            Assert.NotSame(book1, book2);
            Assert.False(Object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
