using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void GesBookReturnsDifferentObjects()
        {
            // arrange 
            var book1 =  GetBook("Book 1"); 
            var book2 =  GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);              
            Assert.Equal("Book 2", book2.Name);              
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            // arrange 
            var book1 =  GetBook("Book 1"); 
            Setname(book1, "New Name"); 

            Assert.Equal("New Name", book1.Name);        
        }

        private void Setname(Book book, string name)
        {
            book.Name = name;
        }

        public void TwoVarsCanReferenceSameObject()
        {
            // arrange 
            var book1 =  GetBook("Book 1"); 
            var book2 = book1; 

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2)); 

        }
        Book GetBook(string name)
        {
            return new Book(name); 
        }
    }
}
