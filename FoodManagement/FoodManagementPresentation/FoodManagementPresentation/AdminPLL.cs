using System;
using System.Collections.Generic;
using System.Text;
using FoodManagementBussiness;
using FoodManagementData;

namespace FoodManagementPresentation
{
    public class AdminPLL
    {
        public void AdminLogin()
        {
            Console.WriteLine("enter admin email : ");
            string email = Console.ReadLine();
            Console.WriteLine("enter admin password : ");
            string password = Console.ReadLine();
            AdminBLL adminbll = new AdminBLL();
            bool status = adminbll.AdminLogin(email, password);
            if (status)
                Console.WriteLine("successfull!!!");
            else
                Console.WriteLine("invalid credentials");
        }
        private void GetAdminMenu()
        {
            Console.Write("1) Press 1 to show book section\n" +
                "2) Press 2 to show Food category\n" +
                "3) Press 3 to show FoodItem\n" +
                "4) Press 4 to show FoodSales\n" +
                "5) Press 5 to ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("logout");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void AdminSection()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome-to-Admin-Section--------------");
            Console.ForegroundColor = ConsoleColor.White;
            bool adminLoop = true;
            while (adminLoop == true)
            {
                GetAdminMenu();
                int adminCase = int.Parse(Console.ReadLine());
                switch (adminCase)
                {
                    case 1:
                       

                        break;
                    case 2:
                        
                        break;
                    case 3:
                       
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Logged out successfully..\nTada have a nice day...");
                        Console.ForegroundColor = ConsoleColor.White;
                        adminLoop = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }

            }
        }
    }
}
