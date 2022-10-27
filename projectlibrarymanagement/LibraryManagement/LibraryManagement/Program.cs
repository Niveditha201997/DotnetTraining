using LibraryManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Program
    {
        static void Main(string[] args)
        {

            bool logLoop = true;
            while (logLoop == true)
            {

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Welcome to ABC Library Management System");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1) Press 1 to login as Admin\n" +
                "2) Press 2 to login as User\n" +
                "3) Press 3 to exit");

                int logCase = int.Parse(Console.ReadLine());
                switch (logCase)
                {
                    case 1:
                        AdminPL adminPL = new AdminPL();
                        adminPL.AdminLogin();
                        adminPL.AdminSection();
                        break;
                    case 2:
                        UserPL userPL = new UserPL();
                        userPL.UserLogin();
                        userPL.UserSection();
                        break;
                    case 3:
                        logLoop = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter a valid input...");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }

            }
        }

        ////Reflection
        //Type type = typeof(Book);
        //var members = type.GetMembers();
        //var methods = type.GetMethods();
        //var propInfo = type.GetProperties();
        //foreach (var item in methods)
        //{
        //    var obj = Activator.CreateInstance(type);
        //    if(item.Name=="AddBook")
        //        item.Invoke(obj,null);
        //}

        //var t = "";



        //BookPL bookPL = new BookPL();
        //bookPL.AddBook();
        //bookPL.GetAllBooks();
        //Console.Read();
    }
    
}
