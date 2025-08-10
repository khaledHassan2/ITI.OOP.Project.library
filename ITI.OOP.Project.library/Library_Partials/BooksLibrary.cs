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
            do
            {
                Console.Write("Enter Book ID: ");
            }
            while (!int.TryParse(Console.ReadLine(), out id));

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









        public bool RemoveBook(Book book)
        {
            bool found = false;

            foreach (Book existingBook in Books)
            {
                if (existingBook.ID == book.ID ||
                   (existingBook.Title == book.Title && existingBook.Author == book.Author))
                {
                    Books.Remove(existingBook); 
                    found = true;
                    break; 
                }
            }

            return found; 
        }

    }
}

