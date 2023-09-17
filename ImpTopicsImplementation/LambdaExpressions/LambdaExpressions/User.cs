/*
Lambda Expressions
It's an anonymous method with no access modifier, no name
and no return statement.

Syntax : args => expression "We can read this as arguments
pointing towards expression"

If we have no arguments we can write  "() => expression"
If we have 1 argument we can write  "x => expression"
If we have multiple arguments we can write  "(x,y,z,..) => expression"

*/


using System;

namespace LambdaExpressions
{
    class User
        //Implementation with Lambda Expressions
    {
        static void Main(string[] args)
        {
            var books = new BooksRepository().GetBooks(); // Our var is pointing to generics list of T and T is Book here
            var cheapBooks = books.FindAll(b => b.Price < 10); //Here we are going to use lambda expression.

            // Using foreach loop for iterating through list of books
            foreach(var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }


        /*
         * We can achieve this functionality with Lmabda Expressions
         * The Lambda expression b is exactly equal to method named IsCheaperThan10Dollars
        
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }

        */
    }
}
