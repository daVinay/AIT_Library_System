using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Example;

namespace BusinessLogic
{
    public class BorrowedAndUser
    {
        private string _userName;
        private string _bookName;
        private string _bookISBN;
        private string _publisher;
        private int _publisherYear;
        private int _pages;
        private string _authorName;
        private string _categoryName;
        private string _languageName;

        public string userName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string bookName
        {
            get { return _bookName; }
            set { _bookName = value; }
        }

        public string Isbn
        {
            get { return _bookISBN; }
            set { _bookISBN = value; }
        }

        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        public int PublisherYear
        {
            get { return _publisherYear; }
            set { _publisherYear = value; }
        }

        public int Pages
        {
            get { return _pages; }
            set { _pages = value; }
        }

        public string AuthorName
        {
            get { return _authorName; }
            set { _authorName = value; }
        }

        public string CategoryName
        {
            get { return _categoryName; }
            set { _categoryName = value; }
        }

        public string LanguageName
        {
            get { return _languageName; }
            set { _languageName = value; }
        }

        /// <summary>
        /// get list of book borrowed with userName from TabUser
        /// </summary>
        /// <param name="BorrowRows"></param>
        /// <returns></returns>
        public static BorrowedAndUser Parse(DataSet1.TabBorrowRow BorrowRows)
        {
            if (BorrowRows == null)
            {
                return null;
            }
            else
            {
                BorrowedAndUser data = new BorrowedAndUser();

                data.userName = GetUserInfoByUID(BorrowRows.UID);

                ViewBookModel tempBook = new ViewBookModel();
                tempBook = GetBookByISBN(BorrowRows.ISBN);

                data.bookName = tempBook.BookName;
                data.AuthorName = tempBook.AuthorName;
                data.CategoryName = tempBook.CategoryName;
                data.Isbn = tempBook.Isbn;
                data.LanguageName = tempBook.LanguageName;
                data.Pages = tempBook.Pages;
                data.Publisher = tempBook.Publisher;
                data.PublisherYear = tempBook.PublisherYear;

                return data;
            }
        }

        /// <summary>
        /// Get book information
        /// </summary>
        /// <param name="ISBN">string</param>
        /// <returns></returns>
        public static ViewBookModel GetBookByISBN(string ISBN)
        {
            List<ViewBookModel> _books = new List<ViewBookModel>();

            BookDAO _bookDao = new BookDAO();
            DataSet1.ViewBookDataTable _borrowTable = _bookDao.GetBookByISBN(ISBN);

            foreach (DataSet1.ViewBookRow bookRows in _borrowTable.Rows)
            {
                ViewBookModel tempRow = ViewBookModel.Parse(bookRows);
                _books.Add(tempRow);
            }

            return _books[0];
        }

        /// <summary>
        /// Get user Information
        /// </summary>
        /// <param name="UID">int</param>
        /// <returns></returns>
        public static String GetUserInfoByUID(int UID)
        {
            List<TabUserModel> _users = new List<TabUserModel>();

            UserDAO _userDao = new UserDAO();
            DataSet1.TabUserDataTable _userTable = _userDao.GetInfoByUID(UID);

            foreach (DataSet1.TabUserRow minionRow in _userTable.Rows)
            {
                TabUserModel tempRow = TabUserModel.Parse(minionRow);
                _users.Add(tempRow);
            }

            return _users[0].UserName;
        }
    }
}