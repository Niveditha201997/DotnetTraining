using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementEntity;

namespace LibraryManagementData
{
    public  class UserDAL
    {
       
        private static List<User> users = new List<User>();

        
        public List<User> GetAllUserssDAL()
        {
            return users;
        }
        
        public bool AddUsersDAL(User user)
        {
            bool status = false;
            
                User addUser = new User()
                {
                    UserId = user.UserId,
                    UserEmail = user.UserEmail,
                    UserName = user.UserName,
                    UserPassword = user.UserPassword
                };
                users.Add(addUser);
                status = true;            
            return status;
        }
       
        public bool UpdateUsersDAL(User user)
        {
            bool status = false;
            
                User updateUser = users.Find(s => s.UserId == user.UserId);
                updateUser.UserEmail = user.UserEmail;
                updateUser.UserName = user.UserName;
                updateUser.UserPassword = user.UserPassword;
                status = true;                     
            return status;
        }
       
        public bool RemoveUsersDAL(int userId)
        {
            bool status = false;
            
                User removeUser = users.Find(s => s.UserId == userId);

                users.Remove(removeUser);
                status = true;            
            return status;
        }

       
        public static List<RequestedBook> requestedBooks = new List<RequestedBook>();
        
        public static List<RecievedBook> recievedBooks = new List<RecievedBook>();

        
        public bool RequestBookDAL(int bookId, int userId)
        {
            bool status = false;
            
                User user = users.Find(u => u.UserId == userId);
                Book book = BookDAL.books.Find(b => b.BookId == bookId);
                book.BookCopies = book.BookCopies - 1;
                requestedBooks.Add(new RequestedBook()
                {
                    BookId = book.BookId,
                    BookName = book.BookName,
                    DateRequested = DateTime.Now.Date,
                    UserId = user.UserId,
                    UserName = user.UserName
                });
                status = true;
             return status;
        }
        
        public List<RequestedBook> GetRequestBookDAL()
        {
            return requestedBooks;
        }
        
        public bool AcceptRequestDAL(int userId, int bookId)
        {
            bool status = false;
            
                RequestedBook requestBook = requestedBooks.Find(r => r.UserId == userId && r.BookId == bookId);
                RecievedBook recievedBook = new RecievedBook()
                {
                    BookId = requestBook.BookId,
                    BookName = requestBook.BookName,
                    DateRecieved = DateTime.Now.Date,
                    UserId = requestBook.UserId,
                    UserName = requestBook.UserName
                };
                recievedBooks.Add(recievedBook);
                requestedBooks.Remove(requestBook);
                status = true;            
            return status;
        }
        
        public List<RecievedBook> GetRecievedBookDAL()
        {
            return recievedBooks;
        }
        
        public bool DeleteRecievedDAL(int bookId, int userId)
        {
            bool status = false;
            
                RecievedBook delRecievedBook = recievedBooks.Find(d => d.BookId == bookId && d.UserId == userId);
                recievedBooks.Remove(delRecievedBook);
                Book book = BookDAL.books.Find(b => b.BookId == bookId);
                book.BookCopies = book.BookCopies + 1;
                status = true;            
            return status;
        }
    }
}
