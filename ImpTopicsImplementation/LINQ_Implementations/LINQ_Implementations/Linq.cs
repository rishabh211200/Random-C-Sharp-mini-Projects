using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQ_Implementations
{
    class Linq
    {
        static  void Main(string[] args)
        {
            var books = new BooksRepository().getBooks();

            //Linq Query Operators - they always start with from and end with select
            var cheapBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;
            /*
            //Linq Extension Methods
            var cheapBooks = books
                .Where(b => b.Price < 10)  
                .OrderBy(b => b.Title)  
                .Select(b => b.Title) ; 
            */
            foreach(var book in cheapBooks)
                Console.WriteLine(book);
        }
    }
}
