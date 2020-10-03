using System;
using Xunit;
using src;

namespace test
{
    public class TypeTests
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var book1 = GetBook("Mariam");
            var book2 = GetBook("Nesiem");

            //assert 
            Assert.Equal("Mariam", book1.Name);
            Assert.Equal("Nesiem", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void Test2()
        {
            //arrange
            var book1 = GetBook("Mariam");
            var book2 = book1;

            //assert 
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
            Assert.Equal("Mariam", book2.Name);
        }


        [Fact]
        //pass by value
        public void Test3()
        {
            //arrange
            var book1 = GetBook("Mariam");
            SetName(book1, "New Name");

            //assert 
            Assert.Equal("New Name", book1.Name);
            Assert.NotEqual("Mariam", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            /*book = book1 all of 2 are point to the same object*/
            book.Name = name;
        }

        [Fact]
        //pass by value 2
        public void Test4()
        {
            //arrange
            var book1 = GetBook("Mariam");
            SetName2(book1, "New Name");

            //assert 
            Assert.Equal("Mariam", book1.Name);
            Assert.NotEqual("New Name", book1.Name);
        }

        private void SetName2(Book book, string name)
        {
            /*all of 2 are point to defferent objects*/
            book = new Book(name);
        }

        [Fact]
        //pass by reference
        public void Test5()
        {
            //arrange
            var book1 = GetBook("Mariam");
            SetName3(ref book1, "New Name");

            //assert 
            Assert.Equal("New Name", book1.Name);
            Assert.NotEqual("Mariam", book1.Name);
        }

        private void SetName3(ref Book book, string name)
        {
            /*book point to book1 and book1 point to object*/
            book = new Book(name);
        }

        [Fact]
        public void Test6()
        {
            //arrange
            var x = 3;
            SetX(x);

            var z = 3;
            SetZ(ref z);

            //assert 
            Assert.Equal(3, x);
            Assert.NotEqual(5, x);
            Assert.Equal(5, z);
            Assert.NotEqual(3, z);
        }

        private void SetX(int x)
        {
            x = 5;
        }
        private void SetZ(ref int z)
        {
            z = 5;
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
