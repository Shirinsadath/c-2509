using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_ASSIGNMENT4_abstract__partial__interface
{
    public class Book
    {
        //Defining properties 
        public string Title { get; set; }
        public string Author { get; set; }
        //cunstructor to initialize the properties
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
    public class Library
    {
        private Book[] books;
        //Constructor for the class library
        public Library(int size) 
        {
            books = new Book[size];
        }
        //To get and set book by index
        public Book this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; } 
        }
        //method to display details
        public void DisplayBooks()
        {
            foreach (var book in books) 
            {
                if (book != null)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}"); 
                }
            }
        }
    }
}
