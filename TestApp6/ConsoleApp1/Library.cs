using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace andestech.learning2022.krasn
{
    public delegate void NewBookHandler(string messageText);
    internal class Library
    {
        
        public event NewBookHandler NewBook;

        public List<Book> Books { get; private set; }
        public Library(List<Book> books)
        {
            Books = books;
        }

        // Add, Remove, 
        [Role(Roles.Writer)]
        public void Add(Book book)
        { 
         Books.Add(book);
         NewBook?.Invoke($"New book \"{book.Title}\" arrived! Hurry UP!"); 
        }
        


    }
}
