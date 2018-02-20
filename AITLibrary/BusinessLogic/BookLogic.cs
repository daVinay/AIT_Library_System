using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Example;

namespace BusinessLogic
{
    public class BookLogic
    {
        #region Set Variable
        //Set the different variable who are going to be used for storing the datatable in the dataset
        private BookDAO _bookDao;
        private DataSet1.ViewBookDataTable _bookTable;
        private DataSet1.TabCategoryDataTable _categorytable;
        private DataSet1.ViewBookAvailableDataTable _bookAvailableTable;
        private DataSet1.TabLanguageDataTable _languageTable;
        private DataSet1.TabAuthorDataTable _authorTable;
        private DataSet1.ViewBookBorrowedDataTable _borrowTable;
        private DataSet1.TabBookDataTable _tabBookTable;
        private DataSet1.TabReservedDataTable _tabReservedTable;
        private DataSet1.TabBorrowDataTable _tableBorrowedTable;
        #endregion

        public BookLogic(){
            _bookDao = new BookDAO();
            _bookTable = new DataSet1.ViewBookDataTable();
            _categorytable = new DataSet1.TabCategoryDataTable();
            _bookAvailableTable = new DataSet1.ViewBookAvailableDataTable();
            _authorTable = new DataSet1.TabAuthorDataTable();
            _languageTable = new DataSet1.TabLanguageDataTable();
            _borrowTable = new DataSet1.ViewBookBorrowedDataTable();
            _tabBookTable = new DataSet1.TabBookDataTable();
            _tabReservedTable = new DataSet1.TabReservedDataTable();
            _tableBorrowedTable = new DataSet1.TabBorrowDataTable();
        }

        #region viewBook DataTable
        /// <summary>
        ///  Get all the Books
        /// </summary>
        /// <returns>Return list of all the book in tabBook</returns>
        public List<ViewBookModel> ListBooks()
        {
            List<ViewBookModel> _books = new List<ViewBookModel>();

            _bookTable = _bookDao.GetBook();

            foreach (DataSet1.ViewBookRow booksRow in _bookTable.Rows)
            {
                ViewBookModel tempRow = ViewBookModel.Parse(booksRow);
                _books.Add(tempRow);
            }

            return _books;
        }


        /// <summary>
        /// Search Books by authorName and categoryName
        /// </summary>
        /// <param name="authorName">Name of the author (string)</param>
        /// <param name="categoryName">Name of the Category</param>
        /// <returns>Return list of books according to the value passed</returns>
        public List<ViewBookModel> SearchBooks(string authorName, string categoryName, string bookName)
        {
            //if user enter book name
            if (bookName != "")
            {
                if (categoryName == "All Categories" && authorName != "")
                {
                    //search book with bookName and authorName in all categories
                    List<ViewBookModel> _books = new List<ViewBookModel>();

                    _bookTable = _bookDao.GetBookByBookNameAuthorName(bookName, authorName);

                    foreach (DataSet1.ViewBookRow booksRow in _bookTable.Rows)
                    {
                        ViewBookModel tempRow = ViewBookModel.Parse(booksRow);
                        _books.Add(tempRow);
                    }

                    return _books;
                }
                else if (categoryName != "All Categories" && authorName != "")
                {
                    //search book with bookName and authorName and categoryName
                    List<ViewBookModel> _books = new List<ViewBookModel>();

                    _bookTable = _bookDao.GetBookByBookNameAuthorNameCategoryName(bookName, authorName, categoryName);

                    foreach (DataSet1.ViewBookRow booksRow in _bookTable.Rows)
                    {
                        ViewBookModel tempRow = ViewBookModel.Parse(booksRow);
                        _books.Add(tempRow);
                    }

                    return _books;
                }
                else if (categoryName != "All Categories" && authorName == "")
                {
                    //search book with bookName and authorName and categoryName
                    List<ViewBookModel> _books = new List<ViewBookModel>();

                    _bookTable = _bookDao.GetBookByBookNameCategoryName(bookName, categoryName);

                    foreach (DataSet1.ViewBookRow booksRow in _bookTable.Rows)
                    {
                        ViewBookModel tempRow = ViewBookModel.Parse(booksRow);
                        _books.Add(tempRow);
                    }

                    return _books;
                }
                else
                {
                    List<ViewBookModel> _books = new List<ViewBookModel>();

                    _bookTable = _bookDao.GetBookByBookNameOnly(bookName);

                    foreach (DataSet1.ViewBookRow booksRow in _bookTable.Rows)
                    {
                        ViewBookModel tempRow = ViewBookModel.Parse(booksRow);
                        _books.Add(tempRow);
                    }

                    return _books;
                }
            }
            else
            {
                // if all categories and no author we display all the books
                if (categoryName == "All Categories" && authorName == "")
                {
                    List<ViewBookModel> _books = new List<ViewBookModel>();

                    _bookTable = _bookDao.GetBook();

                    foreach (DataSet1.ViewBookRow booksRow in _bookTable.Rows)
                    {
                        ViewBookModel tempRow = ViewBookModel.Parse(booksRow);
                        _books.Add(tempRow);
                    }

                    return _books;
                }
                // If the user select all categories we use only one parameter
                else if (categoryName == "All Categories" && authorName != "")
                {
                    List<ViewBookModel> _books = new List<ViewBookModel>();

                    _bookTable = _bookDao.GetBookByAuthorOnly(authorName);

                    foreach (DataSet1.ViewBookRow booksRow in _bookTable.Rows)
                    {
                        ViewBookModel tempRow = ViewBookModel.Parse(booksRow);
                        _books.Add(tempRow);
                    }

                    return _books;
                }
                else
                {
                    List<ViewBookModel> _books = new List<ViewBookModel>();

                    _bookTable = _bookDao.GetBookByAuthor(authorName, categoryName);

                    foreach (DataSet1.ViewBookRow booksRow in _bookTable.Rows)
                    {
                        ViewBookModel tempRow = ViewBookModel.Parse(booksRow);
                        _books.Add(tempRow);
                    }

                    return _books;
                }
            }
        }

        //Get book info from ViewBook with ISBN
        public List<ViewBookModel> GetBookInfo(string ISBN)
        {
            List<ViewBookModel> _books = new List<ViewBookModel>();

            _bookTable = _bookDao.GetBookByISBN(ISBN);

            foreach (DataSet1.ViewBookRow booksRow in _bookTable.Rows)
            {
                ViewBookModel tempRow = ViewBookModel.Parse(booksRow);
                _books.Add(tempRow);
            }

            return _books;
        }

        #endregion

        #region TabBook DataTable
        //Get Book info from TabBook with ISBN
        public List<TabBookModel> GetTabBookInfo(string ISBN)
        {
            List<TabBookModel> _books = new List<TabBookModel>();

            _tabBookTable = _bookDao.GetTabBookByISBN(ISBN);

            foreach (DataSet1.TabBookRow booksRow in _tabBookTable.Rows)
            {
                TabBookModel tempRow = TabBookModel.Parse(booksRow);
                _books.Add(tempRow);
            }

            return _books;
        }

        /// <summary>
        /// Insert Book to TabBook
        /// </summary>
        /// <param name="ISBN">string</param>
        /// <param name="bookName">string</param>
        /// <param name="author">int</param>
        /// <param name="category">int</param>
        /// <param name="language">int</param>
        /// <param name="publishYear">int</param>
        /// <param name="pages">int</param>
        /// <param name="publisher">string</param>
        /// <returns>int</returns>
        public int InsertBookTabBook(string ISBN, string bookName, int author, int category, int language, int publishYear, int pages, string publisher)
        {
            try
            {
                return _bookDao.InsertBookTabBook(ISBN, bookName, author, category, language, publishYear, pages, publisher);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Delete a book from TabBook
        /// </summary>
        /// <param name="ISBN">ISBN (string) must be identique</param>
        /// <returns></returns>
        public int DeleteFromTabBook(string ISBN)
        {
            try
            {
                return _bookDao.DeleteFromTabBook(ISBN);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Nb of books in English in TabBook
        /// </summary>
        /// <returns>int</returns>
        public int NbOfEnglishBooks()
        {
            try
            {
                int count = Convert.ToInt32(_bookDao.NbOfEnglishBook());
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Update a book from Tab Book
        /// </summary>
        /// <param name="bookName">string</param>
        /// <param name="author">int</param>
        /// <param name="category">int</param>
        /// <param name="language">int</param>
        /// <param name="publishYear">int</param>
        /// <param name="pages">int</param>
        /// <param name="publisher">string</param>
        /// <param name="ISBN">string must be identique</param>
        /// <returns></returns>
        public int UpdateFromTabBook(string bookName, int author, int category, int language, int publishYear, int pages, string publisher, string ISBN)
        {
            try
            {
                return _bookDao.UpdateFromTabBook(bookName, author, category, language, publishYear, pages, publisher, ISBN);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region TabCategory DataTable
        /// <summary>
        /// Get all the category
        /// </summary>
        /// <returns>List of all the categories</returns>
        public List<TabCategoryModel> CategoryList()
        {
            List<TabCategoryModel> _books = new List<TabCategoryModel>();

            _categorytable = _bookDao.GetCategory();

            // Create a new object and add a new rows to _books
            TabCategoryModel booksCat = new TabCategoryModel();
            booksCat.Cid = 0;
            booksCat.CategoryName = "All Categories";
            _books.Add(booksCat);

            foreach (DataSet1.TabCategoryRow booksRow in _categorytable.Rows)
            {
                TabCategoryModel tempRow = TabCategoryModel.Parse(booksRow);
                _books.Add(tempRow);
            }

            return _books;
        }

        //Insert an Category in TabCategory
        public int InsertCategoryTabCategory(string category)
        {
            try
            {
                return _bookDao.InsertCategoryTabCategory(category);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// List category from TabCategory
        /// </summary>
        /// <returns></returns>
        public List<PairModel> ListCategory()
        {
            List<PairModel> _lists = new List<PairModel>();

            _categorytable = _bookDao.GetCategory();

            foreach (DataSet1.TabCategoryRow uglyRow in _categorytable.Rows)
            {
                PairModel tempRow = PairModel.Parse(uglyRow);

                _lists.Add(tempRow);
            }

            return _lists;
        }
        #endregion

        #region TabAuthor DataTable
        /// <summary>
        /// Get all the AuthorName
        /// </summary>
        /// <returns>List of all the Author Name</returns>
        public List<TabAuthorModel> AuthorList()
        {
            List<TabAuthorModel> _books = new List<TabAuthorModel>();

            _authorTable = _bookDao.GetAuthor();

            // Create a new object and add a new rows to _books
            TabAuthorModel booksAuthor = new TabAuthorModel();
            booksAuthor.Aid = 0;
            booksAuthor.AuthorName = "Textbox Only";
            _books.Add(booksAuthor);

            foreach (DataSet1.TabAuthorRow booksRow in _authorTable.Rows)
            {
                TabAuthorModel tempRow = TabAuthorModel.Parse(booksRow);
                _books.Add(tempRow);
            }

            return _books;
        }
        #endregion

        #region ViewBookAvailable DataTable
        /// <summary>
        /// List all the books avaialable
        /// </summary>
        /// <returns>Return all the books available</returns>
        public List<ViewBookAvailableModel> ListBooksAvailable()
        {
            List<ViewBookAvailableModel> _books = new List<ViewBookAvailableModel>();

            _bookAvailableTable = _bookDao.GetBookAvailable();

            foreach (DataSet1.ViewBookAvailableRow booksRow in _bookAvailableTable.Rows)
            {
                ViewBookAvailableModel tempRow = ViewBookAvailableModel.Parse(booksRow);
                _books.Add(tempRow);
            }

            return _books;
        }

        /// <summary>
        /// Search Books by authorName and categoryName
        /// </summary>
        /// <param name="authorName">Name of the author (string)</param>
        /// <param name="categoryName">Name of the Category</param>
        /// <returns>Return list of books according to the value passed</returns>
        public List<ViewBookAvailableModel> SearchBooksAvailable(string authorName, string categoryName, string bookName)
        {
            //if user enter book name
            if (bookName != "")
            {
                if (categoryName == "All Categories" && authorName != "")
                {
                    //search book with bookName and authorName in all categories
                    List<ViewBookAvailableModel> _books = new List<ViewBookAvailableModel>();

                    _bookAvailableTable = _bookDao.GetBookAvailableByBookNameAuthorName(bookName, authorName);

                    foreach (DataSet1.ViewBookAvailableRow booksRow in _bookAvailableTable.Rows)
                    {
                        ViewBookAvailableModel tempRow = ViewBookAvailableModel.Parse(booksRow);
                        _books.Add(tempRow);
                    }

                    return _books;
                }
                else if (categoryName != "All Categories" && authorName != "")
                {
                    //search book with bookName and authorName and categoryName
                    List<ViewBookAvailableModel> _books = new List<ViewBookAvailableModel>();

                    _bookAvailableTable = _bookDao.GetBookAvailableByBookNameAuthorNameCategoryName(bookName, authorName, categoryName);

                    foreach (DataSet1.ViewBookAvailableRow booksRow in _bookAvailableTable.Rows)
                    {
                        ViewBookAvailableModel tempRow = ViewBookAvailableModel.Parse(booksRow);
                        _books.Add(tempRow);
                    }

                    return _books;
                }
                else if (categoryName != "All Categories" && authorName == "")
                {
                    //search book with bookName and authorName and categoryName
                    List<ViewBookAvailableModel> _books = new List<ViewBookAvailableModel>();

                    _bookAvailableTable = _bookDao.GetBookAvailableByBookNameCategoryName(bookName, categoryName);

                    foreach (DataSet1.ViewBookAvailableRow booksRow in _bookAvailableTable.Rows)
                    {
                        ViewBookAvailableModel tempRow = ViewBookAvailableModel.Parse(booksRow);
                        _books.Add(tempRow);
                    }

                    return _books;
                }
                else
                {
                    List<ViewBookAvailableModel> _books = new List<ViewBookAvailableModel>();

                    _bookAvailableTable = _bookDao.GetBookAvailableByBookNameOnly(bookName);

                    foreach (DataSet1.ViewBookAvailableRow booksRow in _bookAvailableTable.Rows)
                    {
                        ViewBookAvailableModel tempRow = ViewBookAvailableModel.Parse(booksRow);
                        _books.Add(tempRow);
                    }

                    return _books;
                }
            }
            else
            {
                // if all categories and no author we display all the books
                if (categoryName == "All Categories" && authorName == "")
                {
                    List<ViewBookAvailableModel> _books = new List<ViewBookAvailableModel>();

                    _bookAvailableTable = _bookDao.GetBookAvailable();

                    foreach (DataSet1.ViewBookAvailableRow booksRow in _bookAvailableTable.Rows)
                    {
                        ViewBookAvailableModel tempRow = ViewBookAvailableModel.Parse(booksRow);
                        _books.Add(tempRow);
                    }

                    return _books;
                }
                // If the user select all categories we use only one parameter
                else if (categoryName == "All Categories" && authorName != "")
                {
                    List<ViewBookAvailableModel> _books = new List<ViewBookAvailableModel>();

                    _bookAvailableTable = _bookDao.GetBookAvailableByAuthorOnly(authorName);

                    foreach (DataSet1.ViewBookAvailableRow booksRow in _bookAvailableTable.Rows)
                    {
                        ViewBookAvailableModel tempRow = ViewBookAvailableModel.Parse(booksRow);
                        _books.Add(tempRow);
                    }

                    return _books;
                }
                else
                {
                    List<ViewBookAvailableModel> _books = new List<ViewBookAvailableModel>();

                    _bookAvailableTable = _bookDao.GetBookAvailableByAuthor(authorName, categoryName);

                    foreach (DataSet1.ViewBookAvailableRow booksRow in _bookAvailableTable.Rows)
                    {
                        ViewBookAvailableModel tempRow = ViewBookAvailableModel.Parse(booksRow);
                        _books.Add(tempRow);
                    }

                    return _books;
                }
            }
        }

        #endregion

        #region ViewBookBorrowed DataTable
        public List<ViewBookBorrowedModel> ListBooksBorrowed()
        {
            List<ViewBookBorrowedModel> _books = new List<ViewBookBorrowedModel>();

            _borrowTable = _bookDao.ListBooksBorrowed();

            foreach (DataSet1.ViewBookBorrowedRow bookRows in _borrowTable.Rows)
            {
                ViewBookBorrowedModel tempRow = ViewBookBorrowedModel.Parse(bookRows);
                _books.Add(tempRow);
            }

            return _books;
        }

        /// <summary>
        /// Check if the ISBN if present in the viewBookBorrowed table
        /// </summary>
        /// <param name="ISBN">string</param>
        /// <returns></returns>
        public List<ViewBookBorrowedModel> CheckBookSelected(string ISBN)
        {
            List<ViewBookBorrowedModel> _books = new List<ViewBookBorrowedModel>();

            _borrowTable = _bookDao.CheckBookBorrowed(ISBN);

            foreach (DataSet1.ViewBookBorrowedRow booksRow in _borrowTable.Rows)
            {
                ViewBookBorrowedModel tempRow = ViewBookBorrowedModel.Parse(booksRow);
                _books.Add(tempRow);
            }

            return _books;
        }
        #endregion

        #region TabLanguage DataTable
        /// <summary>
        /// List language from TabLanguage
        /// </summary>
        /// <returns></returns>
        public List<PairModel> ListLanguage()
        {
            List<PairModel> _lists = new List<PairModel>();

            _languageTable = _bookDao.ListLanguage();

            foreach (DataSet1.TabLanguageRow uglyRow in _languageTable.Rows)
            {
                PairModel tempRow = PairModel.Parse(uglyRow);

                _lists.Add(tempRow);
            }

            return _lists;
        }

        //Insert an Language in TabLanguage
        public int InsertLanguageTabLanguage(string language)
        {
            try
            {
                return _bookDao.InsertLanguageTabLanguage(language);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region TabAuthor DataTable
        //List all the author in TabAuthor
        public List<PairModel> ListAuthor()
        {
            List<PairModel> _lists = new List<PairModel>();

            _authorTable = _bookDao.GetAuthor();

            foreach (DataSet1.TabAuthorRow uglyRow in _authorTable.Rows)
            {
                PairModel tempRow = PairModel.Parse(uglyRow);

                _lists.Add(tempRow);
            }

            return _lists;
        }

        //Insert an Author in TabAuthor
        public int InsertAuthorTabAuthor(string authorName)
        {
            try
            {
                return _bookDao.InsertAuthorTabAuthor(authorName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region TabBorrowed
        //Get all the books borrowed from TabBorrowed
        public List<TabBorrowModel> ListBooksBorrowedByUID(int UID)
        {
            List<TabBorrowModel> _books = new List<TabBorrowModel>();

            _tableBorrowedTable = _bookDao.GetBookBorrowedByUID(UID);

            foreach (DataSet1.TabBorrowRow booksRow in _tableBorrowedTable.Rows)
            {
                TabBorrowModel tempRow = TabBorrowModel.Parse(booksRow);
                _books.Add(tempRow);
            }

            return _books;
        }

        /// <summary>
        /// Get all the books borrowed from TabBorrowed by ISBN
        /// </summary>
        /// <param name="ISBN">string</param>
        /// <returns></returns>
        public List<TabBorrowModel> ListBooksBorrowedByISBN(string ISBN)
        {
            List<TabBorrowModel> _books = new List<TabBorrowModel>();

            _tableBorrowedTable = _bookDao.GetBookBorrowedByISBN(ISBN);

            foreach (DataSet1.TabBorrowRow booksRow in _tableBorrowedTable.Rows)
            {
                TabBorrowModel tempRow = TabBorrowModel.Parse(booksRow);
                _books.Add(tempRow);
            }

            return _books;
        }

        /// <summary>
        /// Get info with isbn (actualRetunDate = 1/1/2000) means not returned yet
        /// </summary>
        /// <param name="ISBN">string</param>
        /// <param name="ActualReturnDate">1/1/2000</param>
        /// <returns>book borrowed not return</returns>
        public List<TabBorrowModel> GetBookBorrowedByISBNActual(string ISBN)
        {
            List<TabBorrowModel> _books = new List<TabBorrowModel>();

            _tableBorrowedTable = _bookDao.GetBookBorrowedByISBNActual(ISBN);

            foreach (DataSet1.TabBorrowRow booksRow in _tableBorrowedTable.Rows)
            {
                TabBorrowModel tempRow = TabBorrowModel.Parse(booksRow);
                _books.Add(tempRow);
            }

            return _books;
        }

        /// <summary>
        /// get book borrowed by UID and ISBN ActualReturnDate is also set as 1/1/2000 so no return means book still borrowed
        /// </summary>
        /// <param name="UID">int</param>
        /// <param name="ISBN">string</param>
        /// <returns></returns>
        public List<TabBorrowModel> ListBooksBorrowedByUIDIsbnActual(int UID, string ISBN)
        {
            List<TabBorrowModel> _books = new List<TabBorrowModel>();

            _tableBorrowedTable = _bookDao.GetBookBorrowedByUIDIsbnActual(UID, ISBN);

            foreach (DataSet1.TabBorrowRow booksRow in _tableBorrowedTable.Rows)
            {
                TabBorrowModel tempRow = TabBorrowModel.Parse(booksRow);
                _books.Add(tempRow);
            }

            return _books;
        }

        /// <summary>
        /// Get all the books borrowed from TabBorrowed by BID
        /// </summary>
        /// <param name="BID">int</param>
        /// <returns></returns>
        public List<TabBorrowModel> ListBooksBorrowedByBID(int BID)
        {
            List<TabBorrowModel> _books = new List<TabBorrowModel>();

            _tableBorrowedTable = _bookDao.GetBookBorrowedByBID(BID);

            foreach (DataSet1.TabBorrowRow booksRow in _tableBorrowedTable.Rows)
            {
                TabBorrowModel tempRow = TabBorrowModel.Parse(booksRow);
                _books.Add(tempRow);
            }

            return _books;
        }

        /// <summary>
        /// Delete a book from TabBorrowed with ISBN
        /// </summary>
        /// <param name="ISBN"></param>
        /// <returns>int</returns>
        public int DeleteFromTabBorrowed(string ISBN)
        {
            try
            {
                return _bookDao.DeleteFromTabBorrowed(ISBN);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Sum LateFee from TabBorrowed
        /// </summary>
        /// <returns>decimal</returns>
        public decimal SumLateFee()
        {
            try
            {
                decimal count = Convert.ToDecimal(_bookDao.SumLateFee());
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
        public int NbBookreturnLate()
        {
            try
            {
                int count = Convert.ToInt32(_bookDao.NbBookReturnLate());
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
                int count = Convert.ToInt32(_bookDao.NbOfBooksBorrowedStart());
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Update the tabBorrowed
        /// </summary>
        /// <param name="ActualReturnDate">string updated</param>
        /// <param name="LateFee">decimal updated</param>
        /// <param name="BID">int for select the rowID</param>
        /// <exception cref="">Catch any error</exception>
        /// <returns></returns>
        public int UpdateFromTabBorrowed(string ActualReturnDate, decimal LateFee, int BID)
        {
            try
            {
                return _bookDao.UpdateFromTabBorrowed(ActualReturnDate, LateFee, BID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Insert book to the TabBorrow
        /// </summary>
        /// <param name="UID">int</param>
        /// <param name="ISBN">string</param>
        /// <param name="BorrowDate">string(date)</param>
        /// <param name="ReturnDate">string(date)</param>
        /// <param name="ActualReturnDate">string(date)</param>
        /// <param name="LateFee">decimal</param>
        /// <returns></returns>
        public int InsertBookTabBorrow(int UID, string ISBN, string BorrowDate, string ReturnDate, string ActualReturnDate, decimal LateFee)
        {
            try
            {
                return _bookDao.InsertBookTabBorrow(UID, ISBN, BorrowDate, ReturnDate, ActualReturnDate, LateFee);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get Book borrowed from tabBoorow (only the one who haven't been returned yet)
        /// </summary>
        /// <returns></returns>
        public List<BorrowedAndUser> GetBorrowAndUser()
        {
            List<BorrowedAndUser> _borrowUser = new List<BorrowedAndUser>();

            _tableBorrowedTable = _bookDao.GetBookBorrowed();

            foreach (DataSet1.TabBorrowRow booksRow in _tableBorrowedTable.Rows)
            {
                BorrowedAndUser tempRow = BorrowedAndUser.Parse(booksRow);
                _borrowUser.Add(tempRow);
            }

            return _borrowUser;
        }
        #endregion

        #region TabReserved DataTable
        /// <summary>
        /// Get all the books reserved from TabReserved
        /// </summary>
        /// <returns></returns>
        public List<TabReservedModel> ListBooksReserved()
        {
            List<TabReservedModel> _books = new List<TabReservedModel>();

            _tabReservedTable = _bookDao.GetBookReserved();

            foreach (DataSet1.TabReservedRow booksRow in _tabReservedTable.Rows)
            {
                TabReservedModel tempRow = TabReservedModel.Parse(booksRow);
                _books.Add(tempRow);
            }

            return _books;
        }

        /// <summary>
        /// Get all the books reserved from TabReserved with a specific UID
        /// </summary>
        /// <param name="UID">identique (int)</param>
        /// <returns></returns>
        public List<TabReservedModel> ListBooksReservedByUID(int UID)
        {
            List<TabReservedModel> _books = new List<TabReservedModel>();

            _tabReservedTable = _bookDao.GetBookReservedByUID(UID);

            foreach (DataSet1.TabReservedRow booksRow in _tabReservedTable.Rows)
            {
                TabReservedModel tempRow = TabReservedModel.Parse(booksRow);
                _books.Add(tempRow);
            }

            return _books;
        }

        //Get all the books reserved from TabReserved with a specific ISBN
        public List<TabReservedModel> ListBooksReservedByISBN(string ISBN)
        {
            List<TabReservedModel> _books = new List<TabReservedModel>();

            _tabReservedTable = _bookDao.GetBookReservedByISBN(ISBN);

            foreach (DataSet1.TabReservedRow booksRow in _tabReservedTable.Rows)
            {
                TabReservedModel tempRow = TabReservedModel.Parse(booksRow);
                _books.Add(tempRow);
            }

            return _books;
        }

        //Check if book is reserved from TabReserved with UID and ISBN
        public List<TabReservedModel> CheckBooksReserved(int UID, string ISBN)
        {
            List<TabReservedModel> _books = new List<TabReservedModel>();

            _tabReservedTable = _bookDao.CheckBookReserved(UID, ISBN);

            foreach (DataSet1.TabReservedRow booksRow in _tabReservedTable.Rows)
            {
                TabReservedModel tempRow = TabReservedModel.Parse(booksRow);
                _books.Add(tempRow);
            }

            return _books;
        }

        //Delete a book from TabReserved with rid (reserved id)
        public int DeleteFromTabReserved(int RID)
        {
            try
            {
                return _bookDao.DeleteFromTabReserved(RID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Delete a book from TabReserved with ISBN
        public int DeleteFromTabReservedByISBN(string ISBN)
        {
            try
            {
                return _bookDao.DeleteFromTabReservedByISBN(ISBN);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Insert a book in TabReserved
        /// </summary>
        /// <param name="UID">int</param>
        /// <param name="ISBN">string</param>
        /// <param name="reservedDate">string (date)</param>
        /// <returns></returns>
        public int InsertBookTabReserved(int UID, string ISBN, string reservedDate)
        {
            try
            {
                return _bookDao.InsertBookTabReserved(UID, ISBN, reservedDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
        
}
