using System;

namespace Lab7Collections
{
    public enum Genre
    {
        Fantasy,
        Western,
        Romance,
        Thriller,
        Mystery,
        Self,
        Fiction,
        Biography
    }

    class Program
    {
        public static Library<Book> Library = new Library<Book>();
        public static List<Book> BookBag = new Library<Book>();
        static void Main(string[] args)
        {
            loadBooks();
            bool displayMenu = true;
            while(displayMenu)
            {
                displayMenu = UserInterface();
            }
        }
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
                AddABook();
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
            Book Contagious = new Book("Contagious:Why things catch on", new Author("Jonah", "Berger"), Genre.Self,256);
            Book Power = new Book("48 Laws of Power", new Author("Robert", "Greene"), Genre.Self,452);
            Book Between = new Book("Between the World and Me", new Author("Ta-Nehisi", "Coates"), Genre.Biography,176);
            Book Outliers = new Book("Outliers", new Author("Malcolm", "Gladwell"), Genre.Self,304);
            Book Agreements = new Book("The Four Agreements", new Author("Don Miguel", "Ruiz"), Genre.Self,160);
        }





        static void AddABook(string title, string firstName, string lastName, int numberOfPages, Genre genre)
        {
            Book book = new Book()
            {
                Title = title,
                Author = new Author()
                {
                    FirstName = firstName,
                    LastName = lastName
                },
                NumberOfPages = numberOfPages,
                Genre = genre
            };

            Library.Add(book);
        }

        static void ReturnBook()
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









    }
}
