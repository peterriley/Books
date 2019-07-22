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

        //public static decimal GetBasketPrice(List<Book> books, decimal price)
        //{
        //    var totDistinctBooks = books.Select(b => (int)b.BookType).Distinct().Count();
        //    List<decimal> discounts = new List<decimal> { 1m, 0.95m, 0.9m, 0.8m, 0.75m };

        //    decimal discount = discounts[totDistinctBooks - 1];
        //    for (int i = totDistinctBooks; i > 0; i--)
        //    {
        //        price += books.Select(b => b.BookPrice).Distinct().First() * discount;
        //        books.Remove(books.Select(b => b).Distinct().First());
        //    }

        //    // Use recursion to return a total price
        //    return (books.Count() == 0) ? price : GetBasketPrice(books, price);
        //}
    }
}
