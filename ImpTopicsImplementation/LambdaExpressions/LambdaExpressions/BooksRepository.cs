using System;
using System.Collections.Generic;

namespace LambdaExpressions
{
    public class BooksRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Title 1", Price = 5},
                new Book() {Title = "Title 2", Price = 15},
                new Book() {Title = "Title 3", Price = 9},
                new Book() {Title = "Title 4", Price = 19},
                new Book() {Title = "Title 5", Price = 9},
                new Book() {Title = "Title 6", Price = 6},
            };
        }
    }
}
