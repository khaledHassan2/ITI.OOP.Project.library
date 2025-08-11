using oopProject.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace oopProject.Library_Partials
{
    public partial class Library
    {




        public void AddBook()
        {
            


            int id;
            bool flag =false ;
            do
            {
                Console.Write("Enter Book ID: ");
                flag = int.TryParse(Console.ReadLine(), out id);
                if (flag)
                {
                    foreach(Book b in Books)
                    {
                        if (b.ID == id)
                        {
                            Console.WriteLine("Book ID already exists. Please enter a unique ID.");
                            flag = false;
                            break;
                        }
                    }
                }
            } while (!flag);


            string title;
            do
            {
                Console.Write("Enter Book Title: ");
                title = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(title));

            string author;
            
            do
            {
                Console.Write("Enter Author Name: ");
                author = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(author));

            Book book = new Book();
            book.ID = id;
            book.Title = title;
            book.Author = author;

            Books.Add(book);

            Console.WriteLine($"Book '{title}' by {author} added successfully!");
        }









        public void RemoveBook()
        {
            int bookId;

            
            do
            {
                Console.Write("Enter Book ID: ");
            } while (!int.TryParse(Console.ReadLine(), out bookId));

            
            Book bookToRemove = null;
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].ID == bookId)
                {
                    bookToRemove = Books[i];
                    break;
                }
            }

            
            if (bookToRemove != null)
            {
                Books.Remove(bookToRemove);
                Console.WriteLine("Book removed successfully.");
            }
            else
            {
                Console.WriteLine("Book ID does not exist.");
            }
        }


    }
}

