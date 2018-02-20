using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Example;

namespace BusinessLogic
{
    public class ViewBookAvailableModel
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

        // initialise/return/set the variable and method
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

        // Get the value from the dataset and stock them in viewBook
        public static ViewBookAvailableModel Parse(DataSet1.ViewBookAvailableRow BooksRow)
        {
            if (BooksRow == null)
            {
                return null;
            }
            else
            {
                ViewBookAvailableModel viewBook = new ViewBookAvailableModel();
                viewBook.Isbn = BooksRow.ISBN;
                viewBook.Publisher = BooksRow.Publisher;
                viewBook.BookName = BooksRow.BookName;
                viewBook.PublisherYear = BooksRow.PublishYear;
                viewBook.Pages = BooksRow.Pages;
                viewBook.AuthorName = BooksRow.AuthorName;
                viewBook.CategoryName = BooksRow.CategoryName;
                viewBook.LanguageName = BooksRow.LanguageName;

                return viewBook;
            }
        }
    }
}