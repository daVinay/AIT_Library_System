using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Example;

namespace BusinessLogic
{
    public class TabReservedModel
    {
        //create the variable
        #region Variable Set
        private int _rid;
        private int _uid;
        private string _isbn;
        private string _reservedDate;
        #endregion

        public int rid
        {
            get { return _rid; }
            set { _rid = value; }
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

        public string reservedDate
        {
            get { return _reservedDate; }
            set { _reservedDate = value; }
        }

        // Get the value from the dataset and stock them in tabReserved
        public static TabReservedModel Parse(DataSet1.TabReservedRow BooksRow)
        {
            if (BooksRow == null)
            {
                return null;
            }
            else
            {
                TabReservedModel tabReserved = new TabReservedModel();
                tabReserved.rid = BooksRow.RID;
                tabReserved.uid = BooksRow.UID;
                tabReserved.isbn = BooksRow.ISBN;
                tabReserved.reservedDate = BooksRow.ReservedDate.ToString();

                return tabReserved;
            }
        }
    }
}
