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
            bool found = false;

            foreach (Book existingBook in Books)
            {
                if (existingBook.ID == book.ID ||
                   (existingBook.Title == book.Title && existingBook.Author == book.Author))
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                return false; 
            }

            Books.Add(book);
            return true; 
        }

            
           
        
        public void RemoveBook()
        {
        }
    }
}
