using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementBussiness;
using LibraryManagementEntity;


namespace LibraryManagement
{
    public class AdminPL
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
                "2) Press 2 to show user section\n" +
                "3) Press 3 to show request section\n" +
                "4) Press 4 to show accepted section\n" +
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
                            BookPL bookSection = new BookPL();
                            bookSection.BookSection();
                            break;
                        case 2:
                            UserPL userSection = new UserPL();
                            userSection.UserSection();
                            break;
                        case 3:
                            RequestedSection();
                            break;
                        case 4:
                            RecievedSection();
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
       
        public void AcceptRequest()
        {
            
                Console.Write("User Id: ");
                int userId = int.Parse(Console.ReadLine());
                Console.Write("Book Id: ");
                int bookId = int.Parse(Console.ReadLine());
                UserBLL userBLL = new UserBLL();
                userBLL.AcceptRequestBLL(userId, bookId);                      

        }
        
        private void RequestedSection()
        {
            bool reqLoop = true;
            while (reqLoop == true)
            {
                
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Welcome-to-Request-Section--------------");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1) Press 1 to show all book request\n" +
                        "2) Press 2 to accept requested books\n" +
                        "3) Press 3 to exit");
                    int reqCase = int.Parse(Console.ReadLine());
                    switch (reqCase)
                    {
                        case 1:
                            UserPL userPL = new UserPL();
                            userPL.GetRequestBook();
                            break;
                        case 2:
                            AcceptRequest();
                            break;
                        case 3:
                            Console.WriteLine("");
                            reqLoop = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input!!!");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
               
            }
        }
        
        public void DeleteRecieved()
        {
            
                Console.Write("User Id: ");
                int userId = int.Parse(Console.ReadLine());
                Console.Write("Book Id: ");
                int bookId = int.Parse(Console.ReadLine());
                UserBLL userBLL = new UserBLL();
                userBLL.DeleteRecievedBLL(bookId, userId);

            
        }
       
        private void RecievedSection()
        {
            bool recLoop = true;
            while (recLoop == true)
            {
                
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Welcome-to-Accepted-Section--------------");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1) Press 1 to show all book accepted\n" +
                        "2) Press 2 to takeback accepted books\n" +
                        "3) Press 3 to exit");
                    int recCase = int.Parse(Console.ReadLine());
                    switch (recCase)
                    {
                        case 1:
                            UserPL userPL = new UserPL();
                            userPL.GetRecievedBook();
                            break;
                        case 2:
                            DeleteRecieved();
                            break;
                        case 3:
                            Console.WriteLine();
                            recLoop = false;
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

