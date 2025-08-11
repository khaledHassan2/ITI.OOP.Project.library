using oopProject.Enums;
using oopProject.Library_Partials;

namespace ITI.OOP.Project.library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            int option = 0;
            do
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("");

                Console.WriteLine("Library Management System");
                Console.WriteLine("1.Add Book");
                Console.WriteLine("2.Remove Book");
                Console.WriteLine("3.Add Member");
                Console.WriteLine("4.Remove Member");
                Console.WriteLine("5.Borrow Book");
                Console.WriteLine("6.Return Book");
                Console.WriteLine("7.List Books");
                Console.WriteLine("8.List Members");
                Console.WriteLine("9.Exit");
                Console.Write("Select an option: ");
                if (int.TryParse(Console.ReadLine(), out option))
                {


                    switch ((Options)option)
                    {
                        case Options.AddBook: library.AddBook(); break;
                        case Options.RemoveBook: library.RemoveBook(); break;
                        case Options.AddMember: library.AddMember(); break;
                        case Options.RemoveMember: library.RemoveMember(); break;
                        case Options.BorrowBook: library.BorrowBook(); break;
                        case Options.ReturnBook: library.ReturnBook(); break;
                        case Options.ListBooks: library.ListBooks(); break;
                        case Options.ListMembers: library.ListMembers(); break;
                        case Options.Exit: Console.WriteLine("thanks you ..."); return;
                        default: Console.WriteLine("Please enter Valid input"); break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter Valid input");
                }



            } while (option != 9);
        }
    }
}
