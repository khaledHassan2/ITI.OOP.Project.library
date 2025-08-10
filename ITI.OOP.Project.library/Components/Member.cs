using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProject.Components
{
    public class Member
    {
        public int ID {  get; set; }
        public string Name{  get; set; } = string.Empty; 
        public List<Book> borrowedBooks { get; set; } = new List<Book>();

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Borrowed Books:{borrowedBooks.Count}";
        }
    }
}
