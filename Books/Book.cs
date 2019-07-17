using System.Collections.Generic;
using System.Linq;

namespace Books
{
    public class Book
    {
        public Book()
        {

        }

        public Book(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        public BookType BookType { get; set; }
        public decimal BookPrice { get; set; }

        /// <summary>
        /// Method to return the total price of the basket
        /// </summary>
        /// <param name="bookList"></param>
        /// <returns></returns>
        public static decimal GetTotalPriceWithDiscounts(List<Book> bookList)
        {
            decimal totalPrice = 0m;

            var enumBookList = bookList.Select(bl => (int)bl.BookType).ToList();

            totalPrice = GetTotalPrice(enumBookList, totalPrice);

            return totalPrice;
            
        }

        /// <summary>
        /// Method using recursion to return the total price of the basket of books
        /// </summary>
        /// <param name="tempEnumBookList">a list of ints representing BookType</param>
        /// <param name="totalPrice">total price initialized to zero</param>
        /// <returns>total discounted price to return</returns>
        private static decimal GetTotalPrice(List<int> tempEnumBookList, decimal totalPrice)
        {
            var totDistinct5Books = tempEnumBookList.Where(tebl => tebl == 5).Select(tebl => tebl).Count();
            var totDistinct4Books = tempEnumBookList.Where(tebl => tebl == 4).Select(tebl => tebl).Count();
            var totDistinct3Books = tempEnumBookList.Where(tebl => tebl == 3).Select(tebl => tebl).Count();
            var totDistinct2Books = tempEnumBookList.Where(tebl => tebl == 2).Select(tebl => tebl).Count();
            var totDistinct1Books = tempEnumBookList.Where(tebl => tebl == 1).Select(tebl => tebl).Count();
            var totDistinctBooks = tempEnumBookList.Select(tebl => tebl).Distinct().Count();
            decimal bookPrice = 8m;
            decimal noDiscount = 1m;
            decimal twoDiscount = 0.95m;
            decimal threeDiscount = 0.9m;
            decimal fourDiscount = 0.8m;
            decimal fiveDiscount = 0.75m;

            if (totDistinctBooks == 5)
            {
                totalPrice += bookPrice * fiveDiscount * 5;
            }
            else if (totDistinctBooks == 4)
            {
                totalPrice += bookPrice * fourDiscount * 4;
            }
            else if (totDistinctBooks == 3)
            {
                totalPrice += bookPrice * threeDiscount * 3;
            }
            else if (totDistinctBooks == 2)
            {
                totalPrice += bookPrice * twoDiscount * 2;
            }
            else
            {
                totalPrice += bookPrice * noDiscount;
            }

            //Add newTempEnumBookList but not neccessary
            var newTempEnumBookList = tempEnumBookList;
            if (totDistinct5Books > 0)
            {
                var item5ToRemove = newTempEnumBookList.First(r => r == 5);
                newTempEnumBookList.Remove(item5ToRemove);
            }
            if (totDistinct4Books > 0)
            {
                var item4ToRemove = newTempEnumBookList.First(r => r == 4);
                newTempEnumBookList.Remove(item4ToRemove);
            }
            if (totDistinct3Books > 0)
            {
                var item3ToRemove = newTempEnumBookList.First(r => r == 3);
                newTempEnumBookList.Remove(item3ToRemove);
            }
            if (totDistinct2Books > 0)
            {
                var item2ToRemove = newTempEnumBookList.First(r => r == 2);
                newTempEnumBookList.Remove(item2ToRemove);
            }
            if (totDistinct1Books > 0)
            {
                var item1ToRemove = newTempEnumBookList.First(r => r == 1);
                newTempEnumBookList.Remove(item1ToRemove);
            }

            // Use recursion to return a total price
            return (newTempEnumBookList.Count() == 0) ? totalPrice : GetTotalPrice(newTempEnumBookList, totalPrice);
        }
    }

    /// <summary>
    /// enum to set values for each BookType
    /// </summary>
    public enum BookType
    {
        FirstBook = 1,
        SecondBook = 2,
        ThirdBook = 3,
        FourthBook = 4,
        FifthBook = 5
    }
}
