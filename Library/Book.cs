using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
       public string title;
       public string author;
       public int isbn;

        // Paramaterised constructor
        public Book(string bookTitle, string bookAuthor, int bookIsbn)
        { 
            title = bookTitle;
            author = bookAuthor;
            isbn = bookIsbn;
        }



        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"ISBN: {isbn}");
            Console.WriteLine("-------------------------");
        }



    }

    }
