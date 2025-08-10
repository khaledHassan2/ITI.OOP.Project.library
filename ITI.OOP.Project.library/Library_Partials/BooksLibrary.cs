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




        public bool AddBook(Book book)
        {
            
            if (string.IsNullOrWhiteSpace(book.Title))
            {
                Console.WriteLine("Book title cannot be empty.");
                return false;
            }

            Books.Add(book); 
            return true;
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

