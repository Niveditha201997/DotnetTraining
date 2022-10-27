using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementEntity;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Serialization;
using System.IO;

namespace LibraryManagementData
{
    public class BookDAL
    {
        //public static string sqlcon = "Data source = VDC01LTC2013;Initial Catalog = LibraryManagementEntity;Integrated Security = True;";
        //public List<Book> books;

        //public string AddBooksDAL(Book Book)
        //{
        //connected approach

        #region connected approach
        //string msg = "";
        //SqlConnection con = new SqlConnection(sqlcon);
        //SqlCommand cmd = new SqlCommand("insert into book values(" + Book.BookId + ",'" + Book.BookAuthor + "'," + Book.BookCopies + ",'" + Book.BookName + "')", con);
        //con.Open();
        //int row = cmd.ExecuteNonQuery();
        //con.Close();
        //if (row > 0)
        //  msg = "Inserted";
        //return msg;
        #endregion

        //    #region disconnected approach
        //    string msg = "";
        //    SqlConnection con = new SqlConnection(sqlcon);
        //    SqlDataAdapter adp = new SqlDataAdapter("insert into book values(" + Book.BookId + ",'" + Book.BookAuthor + "'," + Book.BookCopies + ",'" + Book.BookName + "')", con);
        //    DataTable dt = new DataTable();
        //    DataSet ds = new DataSet();
        //    adp.Fill(dt);
        //    msg = "Inserted";
        //    return msg;
        //    #endregion
        //}

        //public List<Book> GetAllBooksDAL()
        //{
        //    # region connected
        //    SqlConnection con = new SqlConnection(sqlcon);
        //    SqlCommand cmd = new SqlCommand("Select * from book", con);
        //    con.Open();
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    books = new List<Book>();
        //    while (dr.Read())
        //    {
        //        books.Add(new Book
        //        {
        //            BookId = Convert.ToInt32(dr["BookId"]),
        //            BookName = dr["BookName"].ToString(),
        //            BookAuthor = dr["BookAuthor"].ToString(),
        //            BookCopies = Convert.ToInt32(dr["BookCopies"])
        //        });
        //    }
        //    con.Close();
        //    return books;
        //    #endregion
        //}

        //    #region disconnected
        //    SqlConnection con = new SqlConnection(sqlcon);
        //    SqlDataAdapter adp = new SqlDataAdapter("Select * from book", con);
        //    DataTable dt = new DataTable();
        //    List<Book> books = new List<Book>();
        //    adp.Fill(dt);
        //    if (dt != null && dt.Rows.Count > 0)
        //    {
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            books.Add(new Book
        //            {
        //                BookId = Convert.ToInt32(dt.Rows[i]["BookId"]),
        //                BookName = dt.Rows[i]["BookName"].ToString(),
        //                BookAuthor = dt.Rows[i]["BookAuthor"].ToString(),
        //                BookCopies = Convert.ToInt32(dt.Rows[i]["BookCopies"])
        //            });
        //        }
        //    }
        //    XmlSerializer xmlSerialiZer = new XmlSerializer(typeof(List<Book>));
        //    FileStream fileStream = new FileStream("books.xml",FileMode.Create);
        //    xmlSerialiZer.Serialize(fileStream, books);
        //    return books;
        //    #endregion
        //}


        public static List<Book> books = new List<Book>();


        public List<Book> GetAllBooksDAL()
        {
            return books;
        }

        public bool AddBooksDAL(int bookId, string bookName, string bookAuthor, int bookCopies)
        {
            bool status = false;


            Book addBook = new Book() { BookId = bookId, BookName = bookName, BookAuthor = bookAuthor, BookCopies = bookCopies };
            books.Add(addBook);
            status = true;
            return status;
        }

        public bool UpdateBooksDAL(int bookId, string bookName, string bookAuthor, int bookCopies)
        {
            bool status = false;

            Book updateBook = books.Find(s => s.BookId == bookId);
            updateBook.BookName = bookName;
            updateBook.BookAuthor = bookAuthor;
            updateBook.BookCopies = bookCopies;
            status = true;

            return status;
        }

        public bool RemoveBooksDAL(int bookId)
        {
            bool status = false;

            Book removeBook = books.Find(s => s.BookId == bookId);
            books.Remove(removeBook);
            status = true;
            return status;
        }

    }
}
