using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementEntity;
using LibraryManagementBussiness;

namespace LibraryManagement
{
    public class BookPL
    {

        // Book book = null;
        //public void AddBook()
        //{
        //    book = new Book();
        //    Console.WriteLine("Enter BookId");
        //    book.BookName = Console.ReadLine();
        //    Console.WriteLine("Enter BookAuthor : ");
        //    book.BookAuthor = Console.ReadLine();
        //    Console.WriteLine("Enter BookCopies : ");
        //    book.BookCopies = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter BookName : ");
        //    book.BookName = Console.ReadLine();
        //    BookBLL bookBLL = new BookBLL();
        //    string msg = bookBLL.AddBookBLL(book);
        //    Console.WriteLine(msg);
        //}
        //public List<Book> GetAllBooks()
        //{
        //    BookBLL bookBLL=new BookBLL();
        //    return GetAllBooks();
        //}

        private Book book = new Book();
        
        private void GetBookMenu()
        {
            Console.WriteLine("1) Press 1 to add a book\n" +
                "2) Press 2 to update a book\n" +
                "3) Press 3 to delete a book\n" +
                "4) Press 4 to show all book\n" +
                "5) Press 5 to exit");
        }
        
        private void AddBook()
        {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Enter book details..");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Book Id: ");
                book.BookId = int.Parse(Console.ReadLine());
                Console.Write("Book Name: ");
                book.BookName = Console.ReadLine();
                Console.Write("Book Author: ");
                book.BookAuthor = Console.ReadLine();
                Console.Write("Book Copies: ");
                book.BookCopies = int.Parse(Console.ReadLine());
                BookBLL addBook = new BookBLL();
                addBook.AddBookBLL(book.BookId, book.BookName, book.BookAuthor, book.BookCopies);
                     
        }
       
        private void UpdateBook()
        {
            
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Enter book details..");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Book Id: ");
                book.BookId = int.Parse(Console.ReadLine());
                Console.Write("Book Name: ");
                book.BookName = Console.ReadLine();
                Console.Write("Book Author: ");
                book.BookAuthor = Console.ReadLine();
                Console.Write("Book Copies: ");
                book.BookCopies = int.Parse(Console.ReadLine());
                BookBLL updateBook = new BookBLL();
                updateBook.UpdateBookBLL(book.BookId, book.BookName, book.BookAuthor, book.BookCopies);           
            
        }
       
        private void RemoveBook()
        {
           
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Enter book details..");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Book Id: ");
                book.BookId = int.Parse(Console.ReadLine());
                BookBLL removeBook = new BookBLL();
                removeBook.RemoveBookBLL(book.BookId);
           
        }
       
        public void GetAllBook()
        {
            List<Book> books = new List<Book>();
            BookBLL bookTemp = new BookBLL();
            books = bookTemp.GetAllBookBLL();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------Books-List---------------------------");

            Console.WriteLine("--Id-----Name---------------Author-------------------Copies-----");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Book book in books)
            {
                Console.WriteLine("  " + book.BookId + "\t" + book.BookName + "\t  " + book.BookAuthor + "\t\t\t" + book.BookCopies);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        public void BookSection()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome-to-Book-Section-------------");
            Console.ForegroundColor = ConsoleColor.White;
            bool bookLoop = true;
            while (bookLoop == true)
            {
               
                    GetBookMenu();
                    int bookCase = int.Parse(Console.ReadLine());
                    switch (bookCase)
                    {
                        case 1:
                            AddBook();
                            break;
                        case 2:
                            UpdateBook();
                            break;
                        case 3:
                            RemoveBook();
                            break;
                        case 4:
                            GetAllBook();
                            break;
                        case 5:
                            Console.WriteLine("");
                            bookLoop = false;
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
