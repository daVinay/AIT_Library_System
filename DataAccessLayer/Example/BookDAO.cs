using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Example.DataSet1TableAdapters;

namespace Example
{
    public class BookDAO
    {
        
        //set variable for all the database access
        private DataSet1 _bookDataSet;
        private ViewBookTableAdapter _viewBookTableAdapter;
        private TabCategoryTableAdapter _tabCategoryTableAdaptater;
        private TabAuthorTableAdapter _tabAuthorTableAdaptater;
        private TabLanguageTableAdapter _tabLanguageTableAdapter;
        private TabBorrowTableAdapter _tabBorrowTableAdapter;
        private TabBookTableAdapter _tabBookTableAdapter;
        private ViewBookAvailableTableAdapter _viewBookAvailableTableAdapter;
        private ViewBookBorrowedTableAdapter _viewBookBorrowedTableAdapter;
        private TabReservedTableAdapter _tabReservedTableAdapter;

        public BookDAO()
        {
            _bookDataSet = new DataSet1();
            _viewBookTableAdapter = new ViewBookTableAdapter();
            _tabAuthorTableAdaptater = new TabAuthorTableAdapter();
            _tabCategoryTableAdaptater = new TabCategoryTableAdapter();
            _viewBookAvailableTableAdapter = new ViewBookAvailableTableAdapter();
            _viewBookBorrowedTableAdapter = new ViewBookBorrowedTableAdapter();
            _tabLanguageTableAdapter = new TabLanguageTableAdapter();
            _tabBorrowTableAdapter = new TabBorrowTableAdapter();
            _tabBookTableAdapter = new TabBookTableAdapter();
            _tabReservedTableAdapter = new TabReservedTableAdapter();
        }

        #region ViewBook DataTable
        /// <summary>
        /// get all the books from the datatable ViewBook
        /// </summary>
        /// <returns>Stock all the book in the dataset</returns>
        /// <exception cref="Exception"></exception>
        public DataSet1.ViewBookDataTable GetBook()
        {
            try
            {
                _viewBookTableAdapter.Fill(_bookDataSet.ViewBook);

                return _bookDataSet.ViewBook;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        /// <summary>
        /// Get only the book from the datatable ViewBook where the condition are respected
        /// </summary>
        /// <param name="authorName">string authorName</param>
        /// <param name="categoryName">string categoryName</param>
        /// <returns>Returns what's found to the dataset</returns>
        /// <exception cref="Exception"></exception>
        public DataSet1.ViewBookDataTable GetBookByAuthor(string authorName, string categoryName)
        {
            try
            {
                _viewBookTableAdapter.FillByAuthor(_bookDataSet.ViewBook, authorName, categoryName);

                return _bookDataSet.ViewBook;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Get only the book from the datatable ViewBook where the condition are respected
        /// </summary>
        /// <param name="authorName">string authorName</param>
        /// <returns>Returns what's found to the dataset</returns>
        /// <exception cref="Exception"></exception>
        public DataSet1.ViewBookDataTable GetBookByAuthorOnly(string authorName)
        {
            try
            {
                _viewBookTableAdapter.FillByAuthorOnly(_bookDataSet.ViewBook, authorName);

                return _bookDataSet.ViewBook;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get only the book who respects the condition "bookname"
        /// </summary>
        /// <param name="bookName">string must me equal</param>
        /// <returns></returns>
        public DataSet1.ViewBookDataTable GetBookByBookNameOnly(string bookName)
        {
            try
            {
                _viewBookTableAdapter.FillByBookNameOnly(_bookDataSet.ViewBook, bookName);

                return _bookDataSet.ViewBook;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get only the book from the datatable ViewBook where the condition are respected
        /// </summary>
        /// <param name="ISBN">string ISBN</param>
        /// <returns>Returns what's found to the dataset</returns>
        /// <exception cref="Exception"></exception>
        public DataSet1.ViewBookDataTable GetBookByISBN(string ISBN)
        {
            try
            {
                _viewBookTableAdapter.CheckBookInfo(_bookDataSet.ViewBook, ISBN);

                return _bookDataSet.ViewBook;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get only the book from the datatable ViewBook where the condition are respected
        /// </summary>
        /// <param name="BookName">string and equal</param>
        /// <param name="AuthorName">string and equal</param>
        /// <param name="CategoryName">string and equal</param>
        /// <exception cref="Exception">all error</exception>
        /// <returns>Returns what's found to the dataset</returns>
        public DataSet1.ViewBookDataTable GetBookByBookNameAuthorNameCategoryName(string BookName, string AuthorName, string CategoryName)
        {
            try
            {
                _viewBookTableAdapter.FillByBookNameAuthorNameCategoryName(_bookDataSet.ViewBook, BookName, AuthorName, CategoryName);

                return _bookDataSet.ViewBook;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get only the book from the datatable ViewBook where the condition are respected
        /// </summary>
        /// <param name="BookName">string and equal</param>
        /// <param name="AuthorName">string and equal</param>
        /// <exception cref="Exception">all error</exception>
        /// <returns>List of book selected by BookName and AuthorName</returns>
        public DataSet1.ViewBookDataTable GetBookByBookNameAuthorName(string BookName, string AuthorName)
        {
            try
            {
                _viewBookTableAdapter.FillByBookNameAuthorName(_bookDataSet.ViewBook, BookName, AuthorName);

                return _bookDataSet.ViewBook;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet1.ViewBookDataTable GetBookByBookNameCategoryName(string BookName, string CategoryName)
        {
            try
            {
                _viewBookTableAdapter.FillByBookNameCategoryName(_bookDataSet.ViewBook, BookName, CategoryName);

                return _bookDataSet.ViewBook;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        /// <summary>
        /// Get only the book from the datatable TabBook where the condition are respected
        /// </summary>
        /// <param name="ISBN">string ISBN</param>
        /// <returns>Returns what's found to the dataset</returns>
        /// <exception cref="Exception"></exception>
        public DataSet1.TabBookDataTable GetTabBookByISBN(string ISBN)
        {
            try
            {
                _tabBookTableAdapter.FillByISBN(_bookDataSet.TabBook, ISBN);

                return _bookDataSet.TabBook;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Delete a book with an ISBN
        /// </summary>
        /// <param name="ISBN">string identique</param>
        /// <returns></returns>
        public int DeleteFromTabBook(string ISBN)
        {
            try
            {
                return _tabBookTableAdapter.DeleteBookByISBN(ISBN);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Number of books in English
        /// </summary>
        /// <returns>int</returns>
        public int NbOfEnglishBook()
        {
            try
            {
                int count = Convert.ToInt32(_tabBookTableAdapter.NbOfEnglishBook());
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateFromTabBook(string bookName, int author, int category, int language, int publishYear, int pages, string publisher, string ISBN)
        {
            try
            {
                return _tabBookTableAdapter.UpdateBookByISBN(bookName, author, category, language, publishYear, pages, publisher, ISBN);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get the category name from the database TabCategory
        /// </summary>
        /// <returns>stock value to the dataset</returns>
        /// <exception cref="Exception"></exception>
        public DataSet1.TabCategoryDataTable GetCategory()
        {
            try
            {
                _tabCategoryTableAdaptater.FillByCategory(_bookDataSet.TabCategory);

                return _bookDataSet.TabCategory;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        //Insert category to tabCategory
        public int InsertCategoryTabCategory(string Category)
        {
            try
            {
                return _tabCategoryTableAdaptater.InsertCategory(Category);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get the author name from the database TabAuthor
        /// </summary>
        /// <returns>stock value to the dataset</returns>
        /// <exception cref="Exception"></exception>
        public DataSet1.TabAuthorDataTable GetAuthor()
        {
            try
            {
                _tabAuthorTableAdaptater.FillByAuthorName(_bookDataSet.TabAuthor);

                return _bookDataSet.TabAuthor;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Insert author to tabAuthor
        public int InsertAuthorTabAuthor(string AuthorName)
        {
            try
            {
                return _tabAuthorTableAdaptater.InsertAuthor(AuthorName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region ViewBookAvailable DataTable
        // get all the book available from the datatable ViewBook and stock them to the dataset
        public DataSet1.ViewBookAvailableDataTable GetBookAvailable()
        {
            try
            {
                _viewBookAvailableTableAdapter.Fill(_bookDataSet.ViewBookAvailable);

                return _bookDataSet.ViewBookAvailable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        /// <summary>
        /// Get only the book from the datatable ViewBook where the condition are respected
        /// </summary>
        /// <param name="authorName">string authorName</param>
        /// <param name="categoryName">string categoryName</param>
        /// <returns>Returns what's found to the dataset</returns>
        /// <exception cref="Exception"></exception>
        public DataSet1.ViewBookAvailableDataTable GetBookAvailableByAuthor(string authorName, string categoryName)
        {
            try
            {
                _viewBookAvailableTableAdapter.FillByAuthor(_bookDataSet.ViewBookAvailable, authorName, categoryName);

                return _bookDataSet.ViewBookAvailable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Get only the book from the datatable ViewBook where the condition are respected
        /// </summary>
        /// <param name="authorName">string authorName</param>
        /// <returns>Returns what's found to the dataset</returns>
        /// <exception cref="Exception"></exception>
        public DataSet1.ViewBookAvailableDataTable GetBookAvailableByAuthorOnly(string authorName)
        {
            try
            {
                _viewBookAvailableTableAdapter.FillByAuthorOnly(_bookDataSet.ViewBookAvailable, authorName);

                return _bookDataSet.ViewBookAvailable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get only the book who respects the condition "bookname"
        /// </summary>
        /// <param name="bookName">string must me equal</param>
        /// <returns></returns>
        public DataSet1.ViewBookAvailableDataTable GetBookAvailableByBookNameOnly(string bookName)
        {
            try
            {
                _viewBookAvailableTableAdapter.FillByBookNameOnly(_bookDataSet.ViewBookAvailable, bookName);

                return _bookDataSet.ViewBookAvailable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get only the book from the datatable ViewBook where the condition are respected
        /// </summary>
        /// <param name="BookName">string and equal</param>
        /// <param name="AuthorName">string and equal</param>
        /// <param name="CategoryName">string and equal</param>
        /// <exception cref="Exception">all error</exception>
        /// <returns>Returns what's found to the dataset</returns>
        public DataSet1.ViewBookAvailableDataTable GetBookAvailableByBookNameAuthorNameCategoryName(string BookName, string AuthorName, string CategoryName)
        {
            try
            {
                _viewBookAvailableTableAdapter.FillByBookNameAuthorNameCategoryName(_bookDataSet.ViewBookAvailable, BookName, AuthorName, CategoryName);

                return _bookDataSet.ViewBookAvailable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get only the book from the datatable ViewBook where the condition are respected
        /// </summary>
        /// <param name="BookName">string and equal</param>
        /// <param name="AuthorName">string and equal</param>
        /// <exception cref="Exception">all error</exception>
        /// <returns>List of book selected by BookName and AuthorName</returns>
        public DataSet1.ViewBookAvailableDataTable GetBookAvailableByBookNameAuthorName(string BookName, string AuthorName)
        {
            try
            {
                _viewBookAvailableTableAdapter.FillByBookNameAuthorName(_bookDataSet.ViewBookAvailable, BookName, AuthorName);

                return _bookDataSet.ViewBookAvailable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet1.ViewBookAvailableDataTable GetBookAvailableByBookNameCategoryName(string BookName, string CategoryName)
        {
            try
            {
                _viewBookAvailableTableAdapter.FillByBookNameCategoryName(_bookDataSet.ViewBookAvailable, BookName, CategoryName);

                return _bookDataSet.ViewBookAvailable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        /// <summary>
        /// List the language
        /// </summary>
        /// <returns></returns>
        public DataSet1.TabLanguageDataTable ListLanguage()
        {
            try
            {
                _tabLanguageTableAdapter.Fill(_bookDataSet.TabLanguage);
                return _bookDataSet.TabLanguage;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Insert language to tabLanguage
        public int InsertLanguageTabLanguage(string Language)
        {
            try
            {
                return _tabLanguageTableAdapter.InsertLanguage(Language);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //++++++++++++++++++++ VIEW BOOK BORROWED ++++++++++++++++++++++++++++
        #region ViewBook DataTable
        /// <summary>
        /// View Book Borrowed
        /// </summary>
        /// <param name="ISBN">string</param>
        /// <returns></returns>
        public DataSet1.ViewBookBorrowedDataTable ListBooksBorrowed()
        {
            try
            {
                _viewBookBorrowedTableAdapter.Fill(_bookDataSet.ViewBookBorrowed);

                return _bookDataSet.ViewBookBorrowed;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Check if the book is already borrow
        /// </summary>
        /// <param name="ISBN"></param>
        /// <returns></returns>
        public DataSet1.ViewBookBorrowedDataTable CheckBookBorrowed(string ISBN)
        {
            try
            {
                _viewBookBorrowedTableAdapter.CheckBookBorrowed(_bookDataSet.ViewBookBorrowed, ISBN);

                return _bookDataSet.ViewBookBorrowed;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        // ++++++++++++++++ END VIEW BOOK BORROWED +++++++++++++++++++++++++++


        // ++++++++++++++++ START TAB BOOK BORROWED ++++++++++++++++++++++++++
        #region TabBook DataTable
        //Get all books from TabBorrow
        public DataSet1.TabBorrowDataTable GetBookBorrowed()
        {
            try
            {
                _tabBorrowTableAdapter.Fill(_bookDataSet.TabBorrow);

                return _bookDataSet.TabBorrow;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Get all books from TabBorrowed by UID
        public DataSet1.TabBorrowDataTable GetBookBorrowedByUID(int UID)
        {
            try
            {
                _tabBorrowTableAdapter.FillByUID(_bookDataSet.TabBorrow, UID);

                return _bookDataSet.TabBorrow;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Get info with isbn (actualRetunDate = 1/1/2000) means not returned yet
        /// </summary>
        /// <param name="ISBN">string</param>
        /// <param name="ActualReturnDate">1/1/2000</param>
        /// <returns></returns>
        public DataSet1.TabBorrowDataTable GetBookBorrowedByISBNActual(string ISBN)
        {
            try
            {
                _tabBorrowTableAdapter.FillByISBNActual(_bookDataSet.TabBorrow, ISBN);

                return _bookDataSet.TabBorrow;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //get book borrowed by UID and ISBN ActualReturnDate is also set as 1/1/2000 so no return means book still borrowed
        public DataSet1.TabBorrowDataTable GetBookBorrowedByUIDIsbnActual(int UID, string ISBN)
        {
            try
            {
                _tabBorrowTableAdapter.FillByUIDIsbnActual(_bookDataSet.TabBorrow, UID, ISBN);

                return _bookDataSet.TabBorrow;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Get all books from TabBorrowed by ISBN
        public DataSet1.TabBorrowDataTable GetBookBorrowedByISBN(string ISBN)
        {
            try
            {
                _tabBorrowTableAdapter.FillByISBN(_bookDataSet.TabBorrow, ISBN);

                return _bookDataSet.TabBorrow;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Get all books from TabBorrowed by BID
        public DataSet1.TabBorrowDataTable GetBookBorrowedByBID(int BID)
        {
            try
            {
                _tabBorrowTableAdapter.FillByBID(_bookDataSet.TabBorrow, BID);

                return _bookDataSet.TabBorrow;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Delete Book borrowed
        /// </summary>
        /// <param name="ISBN">string must be identique</param>
        /// <returns></returns>
        public int DeleteFromTabBorrowed(string ISBN)
        {
            try
            {
                return _tabBorrowTableAdapter.DeleteBookBorrowed(ISBN);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateFromTabBorrowed(string ActualReturnDate, decimal LateFee, int BID)
        {
            try
            {
                return _tabBorrowTableAdapter.UpdateActualReturnDateLateFee(ActualReturnDate, LateFee, BID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Sum the column LateFee from TabBorrowed
        /// </summary>
        /// <returns>decimal</returns>
        public decimal SumLateFee()
        {
            try
            {
                decimal count = Convert.ToDecimal(_tabBorrowTableAdapter.SumLateFee());
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Number of books borrowed from the beginning
        /// </summary>
        /// <returns>int</returns>
        public int NbOfBooksBorrowedStart()
        {
            try
            {
                int count = Convert.ToInt32(_tabBorrowTableAdapter.NbOfBooksBorrowedStart());
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Nb of book returned late
        /// </summary>
        /// <returns>int</returns>
        public int NbBookReturnLate()
        {
            try
            {
                int count = Convert.ToInt32(_tabBorrowTableAdapter.NbBookReturnLate());
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Insert Book to TabBorrow
        /// </summary>
        /// <param name="UID"></param>
        /// <param name="ISBN"></param>
        /// <param name="BorrowDate"></param>
        /// <param name="ReturnDate"></param>
        /// <param name="ActualReturnDate"></param>
        /// <param name="LateFee"></param>
        /// <returns></returns>
        public int InsertBookTabBorrow(int UID, string ISBN, string BorrowDate, string ReturnDate, string ActualReturnDate, decimal LateFee)
        {
            try
            {
                return _tabBorrowTableAdapter.InsertBookBorrow(UID, ISBN, BorrowDate, ReturnDate, ActualReturnDate, LateFee);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        // +++++++++++++++++ END TAB BOOK BORROWED +++++++++++++++++++++++++++

        /// <summary>
        /// Insert new book to tabBook
        /// </summary>
        /// <param name="ISBN"></param>
        /// <param name="bookName"></param>
        /// <param name="author"></param>
        /// <param name="category"></param>
        /// <param name="language"></param>
        /// <param name="publishYear"></param>
        /// <param name="pages"></param>
        /// <param name="publisher"></param>
        /// <returns></returns>
        public int InsertBookTabBook(string ISBN, string bookName, int author, int category, int language, int publishYear, int pages, string publisher)
        {
            try
            {
                return _tabBookTableAdapter.InsertNewBook(ISBN, bookName, author, category, language, publishYear, pages, publisher);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Get all books from TabReserved
        public DataSet1.TabReservedDataTable GetBookReserved()
        {
            try
            {
                _tabReservedTableAdapter.Fill(_bookDataSet.TabReserved);

                return _bookDataSet.TabReserved;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Get all books from TabReserved by UID
        public DataSet1.TabReservedDataTable GetBookReservedByUID(int UID)
        {
            try
            {
                _tabReservedTableAdapter.FillByUID(_bookDataSet.TabReserved, UID);

                return _bookDataSet.TabReserved;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Get all books from TabReserved by ISBN
        public DataSet1.TabReservedDataTable GetBookReservedByISBN(string ISBN)
        {
            try
            {
                _tabReservedTableAdapter.FillByISBN(_bookDataSet.TabReserved, ISBN);

                return _bookDataSet.TabReserved;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// check TabReserved with UID and ISBN
        /// </summary>
        /// <param name="UID">int must be different</param>
        /// <param name="ISBN">string must be identique</param>
        /// <returns></returns>
        public DataSet1.TabReservedDataTable CheckBookReserved(int UID, string ISBN)
        {
            try
            {
                _tabReservedTableAdapter.CheckBookReserved(_bookDataSet.TabReserved, ISBN, UID);

                return _bookDataSet.TabReserved;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Insert a book in the TabReserved
        /// </summary>
        /// <param name="UID"></param>
        /// <param name="ISBN"></param>
        /// <param name="ReservedDate"></param>
        /// <returns></returns>
        public int InsertBookTabReserved(int UID, string ISBN, string ReservedDate)
        {
            try
            {
                return _tabReservedTableAdapter.InsertBookReserved(UID, ISBN, ReservedDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Delete Book reserved
        /// </summary>
        /// <param name="RID">int must be identique</param>
        /// <returns></returns>
        public int DeleteFromTabReserved(int RID)
        {
            try
            {
                return _tabReservedTableAdapter.DeleteBookReserved(RID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Delete book from tab Reserved with ISBN
        /// </summary>
        /// <param name="ISBN">string</param>
        /// <returns></returns>
        public int DeleteFromTabReservedByISBN(string ISBN)
        {
            try
            {
                return _tabReservedTableAdapter.DeleteBookByISBN(ISBN);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
            
    }
}
