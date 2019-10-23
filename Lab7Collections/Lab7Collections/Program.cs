using System;

namespace Lab7Collections
{
    enum Genre
    {
        Fantasy,
        Western,
        Romance,
        Thriller,
        Mystery
    }

    class Program
    {
  
        static void Main(string[] args)
        {
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
                Console.Clear();
                Console.WriteLine("1");
                Console.ReadLine();
                    return true;
            }
            else if (userResponse == "2")
            {
                Console.Clear();
                Console.WriteLine("2");
                Console.ReadLine();
                AddABook();
                return true;
            }
            else if (userResponse == "3")
            {
                Console.Clear();
                Console.WriteLine("3");
                Console.ReadLine();
                return true;
            }
            else if (userResponse == "4")
            {
                Console.Clear();
                Console.WriteLine("4");
                Console.ReadLine();
                return true;
            }
            else if (userResponse == "5")
            {
                Console.Clear();
                Console.WriteLine("5");
                Console.ReadLine();
                return true;
            }
            else
             {
                Console.WriteLine("6");
                Console.ReadLine();
                return false;
            }

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









    }
}
