using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Collections
{
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; }
        public int NumberOfPages { get; set; }

        public Book(string title, Author author, Genre genre, int numberOfPages)
        {
            Title = title;
            Author = author;
            Genre = genre;
            NumberOfPages = numberOfPages;
        }
    }
}
