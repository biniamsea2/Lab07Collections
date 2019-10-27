using System;
using System.Collections.Generic;

namespace Lab7Collections
{


    public class Program
    {
        static void Main(string[] args)
        {
            loadBooks();
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = UserInterface();
            }
        }
        public static Library<Book> Library = new Library<Book>();
        public static List<Book> BookBag = new List<Book>();
        public static Genre bookGenre = new Genre();
        public static bool UserInterface()
        {
            Console.WriteLine("Welcome to my library");
            Console.WriteLine("Please select an option\n");
            Console.WriteLine("1) View all Books");
            Console.WriteLine("2) Add a Book");
            Console.WriteLine("3) Borrow a Book");
            Console.WriteLine("4) Return a Book");
            Console.WriteLine("5) View Book Bag");
            Console.WriteLine("6) Exit");
            string userResponse = Console.ReadLine();

            if (userResponse == "1")
            {
                ViewAllBooks();
                return true;
            }
            else if (userResponse == "2")
            {
                Console.Clear();
                Console.WriteLine("Please enter your book's information");
                Console.WriteLine("What is the title of your book?");
                string title = Console.ReadLine();
                Console.WriteLine("Please enter the author's first name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Please enter the author's last name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Please select the book's genre: ");
                Console.WriteLine("0) Fantasy");
                Console.WriteLine("1) Western");
                Console.WriteLine("2) Romance");
                Console.WriteLine("3) Thriller");
                Console.WriteLine("4) Mystery");
                Console.WriteLine("5) Self");
                Console.WriteLine("6) Fiction");
                Console.WriteLine("7) Biography");
                string genre = Console.ReadLine();
                Console.WriteLine("Please enter the number of pages in this book: ");
                string numberOfpages = Console.ReadLine();
                Console.WriteLine($"{title} has successfully been added. Please press 'Enter' to return to the main menu.");
                string userAnswer = Console.ReadLine();
                if (userAnswer == "1")
                {
                    UserInterface();
                }

                AddABook(title,firstName, lastName, (Genre)Convert.ToInt32(genre), Convert.ToInt32(numberOfpages));
                return true;
            }
            else if (userResponse == "3")
            {
                borrowAbook();
                return true;
            }
            else if (userResponse == "4")
            {
                returnAbook();
                return true;
            }
            else if (userResponse == "5")
            {
                viewBookbag();
                return true;
            }
            else
            {
                Console.WriteLine("6");
                Console.ReadLine();
                return false;
            }

        }


        public static void loadBooks()
        {
            Book Contagious = new Book("Contagious: Why things catch on", new Author("Jonah", "Berger"), Genre.Self, 256);
            Book Power = new Book("48 Laws of Power", new Author("Robert", "Greene"), Genre.Self, 452);
            Book Between = new Book("Between the World and Me", new Author("Ta-Nehisi", "Coates"), Genre.Biography, 176);
            Book Outliers = new Book("Outliers", new Author("Malcolm", "Gladwell"), Genre.Self, 304);
            Book Agreements = new Book("The Four Agreements", new Author("Author: Don Miguel", "Ruiz"), Genre.Self, 160);
            Book[] loadedBooks = new Book[] { Contagious, Power, Between, Outliers, Agreements };
            foreach (Book book in loadedBooks)
            {
                Library.Add(book);
            }
        }

        public static void ViewAllBooks()
        {
            Console.Clear();
            Console.WriteLine("All Books:\n");
            foreach (Book book in Library)
            {
                Console.WriteLine($"Title: {book.Title}\nAuthor: {book.Author.FirstName} {book.Author.LastName}\nGenre: {book.Genre}\nNumber of pages: {book.NumberOfPages}\n\n");
            }

        }


        public static void AddABook(string title, string firstName, string lastName, Genre genre, int numberOfPages)
        {
            Author author = new Author(firstName, lastName);
            Book book = new Book(title, author, genre, numberOfPages);
            Library.Add(book);
        }


        static void returnAbook()
        {
            Dictionary<int, Book> books = new Dictionary<int, Book>();
            Console.WriteLine("Which book would you like to return");
            int counter = 1;
            foreach (var item in BookBag)
            {
                books.Add(counter, item);
                Console.WriteLine($"{counter++}. {item.Title} - {item.Author.FirstName} {item.Author.LastName}");

            }

            string response = Console.ReadLine();
            int.TryParse(response, out int selection);
            books.TryGetValue(selection, out Book returnedBook);
            BookBag.Remove(returnedBook);
            Library.Add(returnedBook);
        }

        public static void borrowAbook()
        {
            Dictionary<int, Book> books = new Dictionary<int, Book>();
            Console.WriteLine("Which book would you like to borrow");
            int counter = 1;
            foreach (var item in Library)
            {
                books.Add(counter, item);
                Console.WriteLine($"{counter++}. {item.Title} - {item.Author.FirstName} {item.Author.LastName}");

            }

            string response = Console.ReadLine();
            int.TryParse(response, out int selection);
            books.TryGetValue(selection, out Book bookBorrowed);
            Library.Remove(bookBorrowed);
            BookBag.Add(bookBorrowed);
        }


        public static void viewBookbag()
        {
            int counter = 1;
            foreach (var item in BookBag)
            {
                Console.WriteLine($"{counter++}. {item.Title} - {item.Author.FirstName} {item.Author.LastName}");
            }
        }

    }









}

