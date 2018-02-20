using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Example;

namespace BusinessLogic
{
    public class TabBorrowModel
    {
        #region variable set
        private int _bid;
        private int _uid;
        private string _isbn;
        private string _borrowDate;
        private string _returnDate;
        private string _actualReturnDate;
        private decimal _lateFee;
        #endregion

        public int bid
        {
            get { return _bid; }
            set { _bid = value; }
        }

        public int uid
        {
            get { return _uid; }
            set { _uid = value; }
        }

        public string isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public string borrowDate
        {
            get { return _borrowDate; }
            set { _borrowDate = value; }
        }

        public string returnDate
        {
            get { return _returnDate; }
            set { _returnDate = value; }
        }

        public string actualReturnDate
        {
            get { return _actualReturnDate; }
            set { _actualReturnDate = value; }
        }

        public decimal lateFee
        {
            get { return _lateFee; }
            set { _lateFee = value; }
        }

        // Get the value from the dataset and stock them in tabBorrow
        public static TabBorrowModel Parse(DataSet1.TabBorrowRow BooksRow)
        {
            if (BooksRow == null)
            {
                return null;
            }
            else
            {
                TabBorrowModel tabBook = new TabBorrowModel();
                tabBook.bid = BooksRow.BID;
                tabBook.uid = BooksRow.UID;
                tabBook.isbn = BooksRow.ISBN;
                tabBook.borrowDate = BooksRow.BorrowDate.ToString();
                tabBook.returnDate = BooksRow.ReturnDate.ToString();
                tabBook.actualReturnDate = BooksRow.ActualReturnDate.ToString();
                tabBook.lateFee = BooksRow.LateFee;

                return tabBook;
            }
        }
    }
}
