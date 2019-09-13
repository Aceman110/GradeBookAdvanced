using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            // arrange section - This where you put together all your test data
            // and you arrange the objects and the values that you are going to use
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");


            // act section - This is where you invoke a method to perform a 
            // computation or perform a calculation


            //assert section - This is where you assert something about the
            //value generated in the act section
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            // arrange section - This where you put together all your test data
            // and you arrange the objects and the values that you are going to use
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");
            


            // act section - This is where you invoke a method to perform a 
            // computation or perform a calculation


            //assert section - This is where you assert something about the
            //value generated in the act section
            Assert.Equal("New Name", book1.Name);
            
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

               [Fact]
        public void Test1()
        {
            // arrange section - This where you put together all your test data
            // and you arrange the objects and the values that you are going to use
            var book1 = GetBook("Book 1");
            GetBookSetName1(book1, "New Name");
            


            // act section - This is where you invoke a method to perform a 
            // computation or perform a calculation


            //assert section - This is where you assert something about the
            //value generated in the act section
            Assert.Equal("New Name", book1.Name);
            
        }

        private void GetBookSetName1(Book book, string name)
        {
            book = new Book(name);
        }

                       [Fact]
        public void Test2()
        {
            // arrange section - This where you put together all your test data
            // and you arrange the objects and the values that you are going to use
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");
            


            // act section - This is where you invoke a method to perform a 
            // computation or perform a calculation


            //assert section - This is where you assert something about the
            //value generated in the act section
            Assert.Equal("New Name", book1.Name);
            
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}