using System.Collections.Generic;



namespace LINQ_Implementations
{
    public class BooksRepository
    {
        public IEnumerable<Books> getBooks()
        {
            return new List<Books>
            {
                new Books(){ Title = "ADO.NET STEP BY STEP", Price = 5},
                new Books(){ Title = "ASP.NET MVC", Price = 9.99f},
                new Books(){ Title = "ASP.NET WEB API", Price = 12},
                new Books(){ Title = "C# ADVANCED TOPICS", Price = 7},
                new Books(){ Title = "C3 ADVANCED TOPICS", Price = 9},
            };
        }
    }
}
