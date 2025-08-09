using oopProject.Components;

namespace oopProject.Library_Partials
{
    public partial class Library
    {
        public void BorrowBook()
        {
            try
            {
                int bookId;
                do
                {
                    Console.Write("Enter Book ID: ");
                } while (!int.TryParse(Console.ReadLine(), out bookId));

                Book? book = null;
                foreach (Book b in Books)
                {
                    if (b.ID == bookId)
                    {
                        book = b;
                        break;
                    }
                }
                if (book == null)
                {
                    Console.WriteLine("Book Id is not found");
                    return;
                }
                int memberId;
                do
                {
                    Console.Write("Enter Member ID: ");
                } while (!int.TryParse(Console.ReadLine(), out memberId));

                Member? member = null;
                foreach (Member m in Members)
                {
                    if (m.ID == memberId)
                    {
                        member = m;
                        break;
                    }
                }
                if (member == null)
                {
                    Console.WriteLine("Member Id Is Not Found");
                    return;
                }

                if (!book.Availability)
                {
                    Console.WriteLine("Book Is Not Available");
                    return;
                }

                book.Availability = false;
                member.borrowedBooks.Add(book);
                Console.WriteLine($"{member.Name} borrowed {book.Title}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
        public void ReturnBook()
        {
            try
            {
               
                int memberId;
                do
                {
                    Console.Write("Enter Member ID: ");
                } while (!int.TryParse(Console.ReadLine(), out memberId));

                Member? member = null;
                foreach (Member m in Members)
                {
                    if (m.ID == memberId)
                    {
                        member = m;
                        break;
                    }
                }
                if (member == null)
                {
                    Console.WriteLine("Member Id Is Not Found");
                    return;
                }
                int bookId;
                do
                {
                    Console.Write("Enter Book ID: ");
                } while (!int.TryParse(Console.ReadLine(), out bookId));

                if (member.borrowedBooks == null || member.borrowedBooks.Count == 0)
                {
                    Console.WriteLine("This Member Has Not Borrowed Any Books");
                    return;
                }

                Book? book = null;
                foreach (Book b in member.borrowedBooks)
                {
                    if (b.ID == bookId)
                    {
                        book = b;
                        break;
                    }
                }
                if (book == null)
                {
                    Console.WriteLine("This member did not borrow this book");
                    return;
                }
                book.Availability = true;
                member.borrowedBooks.Remove(book);
                Console.WriteLine($"{member.Name} returned {book.Title}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
