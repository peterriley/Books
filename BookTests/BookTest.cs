using Microsoft.VisualStudio.TestTools.UnitTesting;
using Books;
using System.Collections.Generic;

namespace BookTests
{
    [TestClass]
    public class BookTest
    {

        /// <summary>
        /// This test to satisfy the Kata
        /// </summary>
        [TestMethod]
        public void GetTotalPriceWithDiscountsKata()
        {
            //-- Act
            List<Book> bookList = new List<Book>();
            Book singleBook1_1 = new Book
            {
                Id = 1,
                BookType = BookType.FirstBook,
                BookPrice = 8
            };
            bookList.Add(singleBook1_1);
            Book singleBook1_2 = new Book
            {
                Id = 2,
                BookType = BookType.FirstBook,
                BookPrice = 8
            };
            bookList.Add(singleBook1_2);
            Book singleBook2_1 = new Book
            {
                Id = 3,
                BookType = BookType.SecondBook,
                BookPrice = 8
            };
            bookList.Add(singleBook2_1);
            Book singleBook2_2 = new Book
            {
                Id = 4,
                BookType = BookType.SecondBook,
                BookPrice = 8
            };
            bookList.Add(singleBook2_2);
            Book singleBook3_1 = new Book
            {
                Id = 5,
                BookType = BookType.ThirdBook,
                BookPrice = 8
            };
            bookList.Add(singleBook3_1);
            Book singleBook3_2 = new Book
            {
                Id = 6,
                BookType = BookType.ThirdBook,
                BookPrice = 8
            };
            bookList.Add(singleBook3_2);
            Book singleBook4 = new Book
            {
                Id = 7,
                BookType = BookType.FourthBook,
                BookPrice = 8
            };
            bookList.Add(singleBook4);
            Book singleBook5 = new Book
            {
                Id = 8,
                BookType = BookType.FifthBook,
                BookPrice = 8
            };
            bookList.Add(singleBook5);

            var expected = 51.60m;

            //-- Arrange
            var actual = Book.GetTotalPriceWithDiscounts(bookList);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test to check discounts on all 5 books ( 1 of each )
        /// </summary>
        [TestMethod]
        public void GetTotalPriceWithDiscountsAll5Test()
        {
            //-- Act
            List<Book> bookList = new List<Book>();
            Book singleBook1 = new Book
            {
                BookType = BookType.FirstBook,
                BookPrice = 8
            };
            bookList.Add(singleBook1);
            Book singleBook2 = new Book
            {
                BookType = BookType.SecondBook,
                BookPrice = 8
            };
            bookList.Add(singleBook2);
            Book singleBook3 = new Book
            {
                BookType = BookType.ThirdBook,
                BookPrice = 8
            };
            bookList.Add(singleBook3);
            Book singleBook4 = new Book
            {
                BookType = BookType.FourthBook,
                BookPrice = 8
            };
            bookList.Add(singleBook4);
            Book singleBook5 = new Book
            {
                BookType = BookType.FifthBook,
                BookPrice = 8
            };
            bookList.Add(singleBook5);

            var expected = 30m;

            //-- Arrange
            var actual = Book.GetTotalPriceWithDiscounts(bookList);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test to check discounts of 20% for 4 different books & one extra at full price
        /// </summary>
        [TestMethod]
        public void GetTotalPriceWithDiscounts4Test()
        {
            //-- Act
            List<Book> bookList = new List<Book>();
            Book singleBook1 = new Book
            {
                BookType = BookType.FirstBook,
                BookPrice = 8
            };
            bookList.Add(singleBook1);
            Book singleBook2 = new Book
            {
                BookType = BookType.SecondBook,
                BookPrice = 8
            };
            bookList.Add(singleBook2);
            Book singleBook3 = new Book
            {
                BookType = BookType.ThirdBook,
                BookPrice = 8
            };
            bookList.Add(singleBook3);
            Book singleBook4 = new Book
            {
                BookType = BookType.FourthBook,
                BookPrice = 8
            };
            bookList.Add(singleBook4);
            Book singleBook5 = new Book
            {
                BookType = BookType.FirstBook,
                BookPrice = 8
            };
            bookList.Add(singleBook5);

            var expected = 33.60m;

            //-- Arrange
            var actual = Book.GetTotalPriceWithDiscounts(bookList);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test to check discounts of 20% for 4 different books & one extra at full price
        /// </summary>
        [TestMethod]
        public void GetTotalPriceWithDiscounts4Test_2()
        {
            //-- Act
            List<Book> bookList = new List<Book>();
            Book singleBook1 = new Book
            {
                BookType = BookType.FirstBook,
                BookPrice = 8
            };
            bookList.Add(singleBook1);
            Book singleBook2 = new Book
            {
                BookType = BookType.SecondBook,
                BookPrice = 8
            };
            bookList.Add(singleBook2);
            Book singleBook3 = new Book
            {
                BookType = BookType.ThirdBook,
                BookPrice = 8
            };
            bookList.Add(singleBook3);
            Book singleBook4 = new Book
            {
                BookType = BookType.FifthBook,
                BookPrice = 8
            };
            bookList.Add(singleBook4);
            Book singleBook5 = new Book
            {
                BookType = BookType.FirstBook,
                BookPrice = 8
            };
            bookList.Add(singleBook5);

            var expected = 33.60m;

            //-- Arrange
            var actual = Book.GetTotalPriceWithDiscounts(bookList);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test to check discounts of 20% for 4 different books & one extra at full price
        /// </summary>
        [TestMethod]
        public void GetTotalPriceWithDiscounts4Test_3()
        {
            //-- Act
            List<Book> bookList = new List<Book>();
            Book singleBook1 = new Book
            {
                BookType = BookType.FirstBook,
                BookPrice = 8
            };
            bookList.Add(singleBook1);
            Book singleBook2 = new Book
            {
                BookType = BookType.SecondBook,
                BookPrice = 8
            };
            bookList.Add(singleBook2);
            Book singleBook3 = new Book
            {
                BookType = BookType.FourthBook,
                BookPrice = 8
            };
            bookList.Add(singleBook3);
            Book singleBook4 = new Book
            {
                BookType = BookType.FifthBook,
                BookPrice = 8
            };
            bookList.Add(singleBook4);
            Book singleBook5 = new Book
            {
                BookType = BookType.FirstBook,
                BookPrice = 8
            };
            bookList.Add(singleBook5);

            var expected = 33.60m;

            //-- Arrange
            var actual = Book.GetTotalPriceWithDiscounts(bookList);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test to check discounts of 20% for 4 different books & one extra at full price
        /// </summary>
        [TestMethod]
        public void GetTotalPriceWithDiscounts4Test_4()
        {
            //-- Act
            List<Book> bookList = new List<Book>();
            Book singleBook1 = new Book
            {
                BookType = BookType.FirstBook,
                BookPrice = 8
            };
            bookList.Add(singleBook1);
            Book singleBook2 = new Book
            {
                BookType = BookType.ThirdBook,
                BookPrice = 8
            };
            bookList.Add(singleBook2);
            Book singleBook3 = new Book
            {
                BookType = BookType.FourthBook,
                BookPrice = 8
            };
            bookList.Add(singleBook3);
            Book singleBook4 = new Book
            {
                BookType = BookType.FifthBook,
                BookPrice = 8
            };
            bookList.Add(singleBook4);
            Book singleBook5 = new Book
            {
                BookType = BookType.FirstBook,
                BookPrice = 8
            };
            bookList.Add(singleBook5);

            var expected = 33.60m;

            //-- Arrange
            var actual = Book.GetTotalPriceWithDiscounts(bookList);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test to check discounts of 20% for 4 different books & one extra at full price
        /// </summary>
        [TestMethod]
        public void GetTotalPriceWithDiscounts4Test_5()
        {
            //-- Act
            List<Book> bookList = new List<Book>();
            Book singleBook1 = new Book
            {
                BookType = BookType.SecondBook,
                BookPrice = 8
            };
            bookList.Add(singleBook1);
            Book singleBook2 = new Book
            {
                BookType = BookType.ThirdBook,
                BookPrice = 8
            };
            bookList.Add(singleBook2);
            Book singleBook3 = new Book
            {
                BookType = BookType.FourthBook,
                BookPrice = 8
            };
            bookList.Add(singleBook3);
            Book singleBook4 = new Book
            {
                BookType = BookType.FifthBook,
                BookPrice = 8
            };
            bookList.Add(singleBook4);
            Book singleBook5 = new Book
            {
                BookType = BookType.SecondBook,
                BookPrice = 8
            };
            bookList.Add(singleBook5);

            var expected = 33.60m;

            //-- Arrange
            var actual = Book.GetTotalPriceWithDiscounts(bookList);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
