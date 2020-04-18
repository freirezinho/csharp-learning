using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqStuff
{
  class Program
  {
    static void Main(string[] args)
    {
      var Books = new BookRepository().GetBooks();

      // LINQ Extension Methods
      //   var cheapBooks = Books
      //                     .Where(book => book.Price < 3)
      //                     .OrderBy(book => book.Title)
      //                     .Select(book => book.Title);
      // LINQ Query Operators
      //   var cheapBooks = from book in Books
      //                    where book.Price < 3
      //                    orderby book.Title
      //                    select book;
      //   var result = Books.Single(book => book.Title == "Book 2++");
      //   var result = Books.SingleOrDefault(book => book.Title == "Book 2 ++");
      //   var result = Books.First(book => book.Title == "Book 4");
      //   var result = Books.FirstOrDefault(book => book.Title == "Book 4++");
      //   var result = Books.Last(book => book.Title == "Book 4");
      //   var result = Books.LastOrDefault(book => book.Title == "Book 4++");
      //   var result = Books.Max(book => book.Price);
      //   var result = Books.Min(book => book.Price);
      //   var result = Books.Sum(book => book.Price);

      //   var result = Books.Average(book => book.Price);

      //   Console.WriteLine(result);
      //   Console.WriteLine(result != null ? ("Title : " + result.Title) : "No book found");
      //   Console.WriteLine(result);
      //   foreach (var book in cheapBooks)
      //   {
      //     Console.WriteLine("Book = " + book.Title + "\nPrice: " + book.Price + "\n");
      //     // Console.WriteLine("Book = " + book);

      //   }
    }
  }
}

