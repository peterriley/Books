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
    }
}
