using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        // Private fields
        private string _title;
        private string _author;
        private int _isbn;

        // Public properties
        public string title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        // Constructor
        public Book(string bookTitle, string bookAuthor, int bookIsbn)
        {
            title = bookTitle;
            author = bookAuthor;
            isbn = bookIsbn;
        }
        // Methods

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"ISBN: {isbn}");
            Console.WriteLine("-------------------------");
        }

    }

    }
