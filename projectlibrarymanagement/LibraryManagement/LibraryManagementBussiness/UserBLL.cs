using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementEntity;
using LibraryManagementData;
using System.Text.RegularExpressions;

namespace LibraryManagementBussiness
{
    public class UserBLL
    {

        private bool UserValidation(User user)
        {
            bool userValid;

            if (user.UserId == 0 || user.UserId >= 100000)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid User id!!!, user id should be in between 1 to 100000");
                Console.ForegroundColor = ConsoleColor.White;

                userValid = false;
            }
            else if (user.UserName.Length <= 3 || user.UserName.Length > 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid User name!!!, minimum 2 maximum 30 characters are allowed");
                Console.ForegroundColor = ConsoleColor.White;

                userValid = false;
            }
            else if (user.UserName.Any(char.IsDigit))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid User name!!!, name should not contains digit");
                Console.ForegroundColor = ConsoleColor.White;
                userValid = false;
            }
            else if (!(new Regex("([\\w\\.\\-_]+)?\\w+@[\\w-_]+(\\.\\w+){1,}").IsMatch(user.UserEmail)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Email!!!, email should be an email");
                Console.ForegroundColor = ConsoleColor.White;
                userValid = false;
            }
            else if (user.UserPassword.Length <= 7 || user.UserPassword.Length > 15)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Password!!!, minimum 8 maximum 15 characters are allowed");
                Console.ForegroundColor = ConsoleColor.White;

                userValid = false;
            }
            else
            {
                userValid = true;
            }
            return userValid;
        }

        UserDAL userDAL = new UserDAL();


        public List<User> GetAllUsersBLL()
        {
            List<User> users = userDAL.GetAllUserssDAL();
            return users;
        }

        public void AddUsersBLL(User user)
        {
            bool isValidated = UserValidation(user);
            if (isValidated)
            {

                bool isDone = userDAL.AddUsersDAL(user);
                if (isDone == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("User added successfully...");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Try again...");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Try again...");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void UpdateUsersBLL(User user)
        {
            bool isValidated = UserValidation(user);
            if (isValidated)
            {
                UserDAL userDAL = new UserDAL();
                bool isDone = userDAL.UpdateUsersDAL(user);
                if (isDone == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("User updated successfully...");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Try again...");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Try again...");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void RemoveUsersBLL(int userId)
        {
            if (userId == 0 || userId >= 100000)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid User Id...");
                Console.WriteLine("Try again...");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {

                bool status = userDAL.RemoveUsersDAL(userId);
                if (status)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("User deleted successfully...");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Try again...");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }



        }

        public bool UserLogin(string userEmail, string userPass)
        {
            UserDAL userDAL = new UserDAL();
            List<User> users = userDAL.GetAllUserssDAL();
            bool status = users.Exists(u => u.UserEmail == userEmail && u.UserPassword == userPass);
            if (status)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Logged in successfully...");
                Console.ForegroundColor = ConsoleColor.White;
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Invalid Email Id or Password...");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
        }

        public int GetUserIdBLL(string userEmail)
        {
            List<User> users = userDAL.GetAllUserssDAL();
            User user = users.Find(u => u.UserEmail == userEmail);
            return user.UserId;
        }

        public void RequestBookBLL(int bookId, int userId)
        {
            Book book = BookDAL.books.Find(b => b.BookId == bookId);
            if (book.BookCopies > 0)
            {
                bool status = userDAL.RequestBookDAL(bookId, userId);
                if (status)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Requested successfully...");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Try again...");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry book is empty...");
                Console.WriteLine("Try again...");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        public List<RequestedBook> GetRequestBookBL()
        {
            return userDAL.GetRequestBookDAL();
        }

        public void AcceptRequestBLL(int userId, int bookId)
        {
            bool isDone = userDAL.AcceptRequestDAL(userId, bookId);
            if (isDone)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Accepted successfully...");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Try again...");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public List<RecievedBook> GetRecievedBookBLL()
        {
            return userDAL.GetRecievedBookDAL();
        }

        public void DeleteRecievedBLL(int bookId, int userId)
        {
            bool isDone = userDAL.DeleteRecievedDAL(bookId, userId);
            if (isDone)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Book deleted successfully...");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Try again...");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
