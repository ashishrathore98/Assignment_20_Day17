using System;



class Program
{
    private static bool isavailable;

    static void Main(string[] args)
    {
        Library library = new Library();

        while (true)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. View all books");
            Console.WriteLine("3. Search by ID");
            Console.WriteLine("4. Search by title");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Input Book ID: ");
                    int bookId = int.Parse(Console.ReadLine());

                    Console.Write("Input Title: ");
                    string title = Console.ReadLine();

                    Console.Write("Input Author: ");
                    string author = Console.ReadLine();

                    Console.Write("Input Genre: ");
                    string genre = Console.ReadLine();

                    Book newBook = new Book(bookId, title, author, genre);
                    library.AddBook(newBook);
                    Console.WriteLine("Book added to the shelf successfully!");
                    break;

                case 2:
                    library.ViewAllBooks();
                    break;

                case 3:
                    Console.Write("Input Book ID to search: ");
                    int searchId = int.Parse(Console.ReadLine());
                    library.SearchBookById(searchId);
                    break;

                case 4:
                    Console.Write("Input Title to search: ");
                    string searchTitle = Console.ReadLine();
                    library.SearchBookByTitle(searchTitle);
                    break;

                case 5:
                    Console.WriteLine("Exiting the program..Visit again");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}