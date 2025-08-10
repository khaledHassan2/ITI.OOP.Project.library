namespace oopProject.Library_Partials
{
    public partial class Library
    {
        public void ListBooks()
        {
            foreach (var book in Books)
            {

                Console.WriteLine($"ID: {book.ID}, Title: {book.Title}, Author: {book.Author}, Available: {book.Availability}");
            }
        }
        public void ListMembers()
        {
            foreach (var member in Members)
            {
                Console.WriteLine($"ID: {member.ID}, Name: {member.Name}, Borrowed Books:{member.borrowedBooks}");
            }

        }
    }
}
