using DELEGATE._2.Models;
using System;
using Utils.Enums;

namespace DELEGATE._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Username");
            string username=Console.ReadLine();
            Console.WriteLine("Email");
            string email=Console.ReadLine();

            
            byte Role;
            bool isNum;
            do
            {
                Console.WriteLine("Role(1.Admin 2.Member):");
                string roleStr = Console.ReadLine();
                isNum = byte.TryParse(roleStr, out Role);

            } while (!isNum || !Enum.IsDefined(typeof(Role), role));

            User user = new User(username, email, (Role)role);
            Library library = new Library(4);
           
            

           

            

            Console.WriteLine("----MENU----");
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Get book by id  ");
            Console.WriteLine("3. Get all books ");
            Console.WriteLine("4. Delete book by id ");
            Console.WriteLine("5. Edit book name ");
            Console.WriteLine("6. Filter by page count ");
            Console.WriteLine("0. Quit ");

            string selection = Console.ReadLine();


            switch (selection)
            {
                case "1":

                   
                    break;

                case "2":

                    
                    break;
                case "3":

                    
                    break;

                case "4":

                    
                    break;

                case "5":

                   
                    break;

                case "6":

                   
                    break;

                case "0":


                default:
                    Console.WriteLine("Not found");
                    break;
            }







        }
    }
}
