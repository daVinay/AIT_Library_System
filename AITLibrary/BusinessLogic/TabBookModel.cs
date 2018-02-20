using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Example;

// Initialise/set/return the variable and method for the datatable TabBookModel

namespace BusinessLogic
{
    public class TabBookModel
    {
        #region variable set

        private string _bookISBN;
        private string _bookName;
        private string _publisher;
        private int _publisherYear;
        private int _pages;
        private int _authorID;
        private int _categoryID;
        private int _languageID;

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

        public int AuthorID
        {
            get { return _authorID; }
            set { _authorID = value; }
        }

        public int CategoryID
        {
            get { return _categoryID; }
            set { _categoryID = value; }
        }

        public int LanguageID
        {
            get { return _languageID; }
            set { _languageID = value; }
        }

        // Get the value from the dataset and stock them in tabBook
        public static TabBookModel Parse(DataSet1.TabBookRow BooksRow)
        {
            if (BooksRow == null)
            {
                return null;
            }
            else
            {
                TabBookModel tabBook = new TabBookModel();
                tabBook.Isbn = BooksRow.ISBN;
                tabBook.Publisher = BooksRow.Publisher;
                tabBook.BookName = BooksRow.BookName;
                tabBook.PublisherYear = BooksRow.PublishYear;
                tabBook.Pages = BooksRow.Pages;
                tabBook.AuthorID = BooksRow.Author;
                tabBook.CategoryID = BooksRow.Category;
                tabBook.LanguageID = BooksRow.Language;

                return tabBook;
            }
        }
    }
}