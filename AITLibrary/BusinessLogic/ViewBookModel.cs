using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Example;

// Initialise/set/return the variable and method for the datatable TabBookModel

namespace BusinessLogic
{
    public class ViewBookModel
    {
        #region variable set

        private string _bookISBN;
        private string _bookName;
        private string _publisher;
        private int _publisherYear;
        private int _pages;
        private string _authorName;
        private string _categoryName;
        private string _languageName;

        #endregion 
    
        public string Isbn
        {
            get { return _bookISBN; }
            set { _bookISBN = value; }
        }

        public string BookName
        {
            get { return _bookName; }
            set { _bookName = value; }
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

        // Get the value from the dataset and stock them in tabBook
        public static ViewBookModel Parse(DataSet1.ViewBookRow BooksRow)
        {
            if (BooksRow == null)
            {
                return null;
            }
            else
            {
                ViewBookModel tabBook = new ViewBookModel();
                tabBook.Isbn = BooksRow.ISBN;
                tabBook.Publisher = BooksRow.Publisher;
                tabBook.BookName = BooksRow.BookName;
                tabBook.PublisherYear = BooksRow.PublishYear;
                tabBook.Pages = BooksRow.Pages;
                tabBook.AuthorName = BooksRow.AuthorName;
                tabBook.CategoryName = BooksRow.CategoryName;
                tabBook.LanguageName = BooksRow.LanguageName;

                return tabBook;
            }
        }
    }
}