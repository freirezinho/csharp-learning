using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqStuff
{
  public class BookRepository
  {
    public IEnumerable<Book> GetBooks()
    {
      return new List<Book>
      {
        new Book() {Title = "Book 1", Price = 1},
        new Book() {Title = "Book 2", Price = 2},
        new Book() {Title = "Book 3", Price = 3},
        new Book() {Title = "Book 4", Price = 4},
        new Book() {Title = "Book 5", Price = 5},
        new Book() {Title = "Book 6", Price = 6},
    };
    }
  }
}