using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProject.Components
{
    public class Book
    {
        public int ID {  get; set; } 
        public  string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public bool Availability { get; set; } = true;
    }
}
