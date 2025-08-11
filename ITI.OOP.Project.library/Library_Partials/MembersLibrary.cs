
using oopProject.Components;

namespace oopProject.Library_Partials
{
    public partial class Library
    {
        public void AddMember()
        {
            
            int x;
            bool flag = false;
            do 
            {
               
                 Console.Write("Enter Member ID: ");
                flag = int.TryParse(Console.ReadLine(), out x);

                
                if (flag) 
                {
                    foreach(Member m in Members)
                    {
                        if(m.ID == x)
                        {
                            Console.WriteLine("ID is already taken");
                            flag = false;
                        }
                    }

                }

			} while (!flag);
            
            string N;
            do
            {
                Console.Write("Enter Name: ");

                N = Console.ReadLine();

            }
            while (N == null || N.Length ==0);

			Member member = new Member();
			member.ID = x;
			member.Name = N;
			Members.Add(member);

			Console.WriteLine($"Member {N} added successfully");


		}
        public void RemoveMember()
        {
			int x;
			do
			{

				Console.Write("Enter Member ID: ");


			} while (!int.TryParse(Console.ReadLine(), out x));

            Member member = null; ;
            for (int i = 0; i < Members.Count; i++)
            {
                if (Members[i].ID == x)
                {
                    member = Members[i];
                    break;
                }
            }
            if (member != null)
            {
                for(int i =0;i<member.borrowedBooks.Count;i++)
                {
                    member.borrowedBooks[i].Availability = true;
                }
                Members.Remove(member);
            }
            else
            {
                Console.WriteLine("ID is not exist");
            }

		}
    }
}
