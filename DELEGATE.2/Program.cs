using DELEGATE._2.Models;
using System;

namespace DELEGATE._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            User user = new User("Cinayet","quliyeva52@gmail.com",Utils.Enums.Role.Admin);
            User user1 = new User("Ceza", "quliyev@gmail.com", Utils.Enums.Role.Admin);
            User user2= new User("Sehr", "azizoff@gmail.com", Utils.Enums.Role.Admin);
            user.ShowInfo();
            byte Role;
            bool isNum;
            do
            {
                Console.WriteLine("Role(1.Admin 2.Member):");
                string role = Console.ReadLine();
                isNum = byte.TryParse(role, out Role);

            } while (!isNum || Enum.IsDefined(typeof(string), Role));

            Library library = new Library(2);
            

           

            

            Console.WriteLine("----MENU----");
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Get book by id  ");
            Console.WriteLine("3. Get all books ");
            Console.WriteLine("4. Delete book by id ");
            Console.WriteLine("5. Edit book name ");
            Console.WriteLine("6. Filter by page count ");
            Console.WriteLine("0. Quit ");

            switch ("1")
            {
                default:
            }
            switch ("2")
            {
                default:
            }
            switch ("3")
            {
                default:
            }
            switch ("4")
            {
                default:
            }
            switch ("5")
            {
                default:
            }
            switch ("6")
            {
                default:
            }
            switch ("0")
            {
                default:
            }







        }
    }
}
