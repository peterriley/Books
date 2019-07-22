using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class BookRepository
    {
        /// <summary>
        /// Method using recursion to return the total price of the basket of books
        /// </summary>
        /// <param name="books">a list of books</param>
        /// <param name="price">zero passed in</param>
        /// <returns>returns total basket price</returns>
        public static decimal GetBasketPrice(List<Book> books, decimal price)
        {
            var totDistinctBooks = books.Select(b => (int)b.BookType).Distinct().Count();
            List<decimal> discounts = new List<decimal> { 1m, 0.95m, 0.9m, 0.8m, 0.75m };

            decimal discount = discounts[totDistinctBooks - 1];
            for (int i = totDistinctBooks; i > 0; i--)
            {
                price += books.Select(b => b.BookPrice).Distinct().First() * discount;
                books.Remove(books.Select(b => b).Distinct().First());
            }

            // Use recursion to return a total price
            return (books.Count() == 0) ? price : GetBasketPrice(books, price);
        }
    }
}
