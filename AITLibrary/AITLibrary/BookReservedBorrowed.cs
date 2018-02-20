using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;
using System.Globalization;

namespace AITLibrary
{
    public partial class BookReservedBorrowed : Template
    {
        public BookReservedBorrowed()
        {
            InitializeComponent();
        }
        #region Variable Set
        private string ISBN = "";
        BookLogic bl = new BookLogic();
        UserLogic ul = new UserLogic();
        DateTime todayDate = DateTime.Now;
        private int idSession;
        #endregion

        /// <summary>
        /// Load zhen form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BookReservedBorrowed_load(object sender, EventArgs e)
        {
            //hide the dataGridView1 from the template
            dataGridView1.Visible = false;

            //only Admin and Supervisor can see adminSup_panel
            if (staticUserLevel == 3 || staticUserLevel == 2)
            {
                adminSup_panel.Visible = true;
                returnBookBorrowedSelected.Visible = true;
            }
            else
            {
                adminSup_panel.Visible = false; //can't select a different user than him
                returnBookBorrowedSelected.Visible = false; //can't return a book
                returnImage.Visible = false;
                parseDataGridViewReserved(staticUID);
                parseDataGridViewBorrowed(staticUID);
                idSession = staticUID;
            }
        }

        //Hide diferrent Panel
        public override void hidePanel(object sender, MouseEventArgs e)
        {
            mainForm_panel.Visible = false;
            dataGridView1.Visible = true;
        }

        /// <summary>
        /// show user data by UID (reserved book & borrowed book)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnSelectUser_Click(object sender, EventArgs e)
        {
            if (userId_txtBox.Text == "")
            {
                MessageBox.Show("Field empty", "A message from AIT Library");
            }
            else
            {
                try
                {
                    List<TabUserModel> _userSearch = ul.GetUserInfoByUID(Int32.Parse(userId_txtBox.Text.ToString()));
                    if (_userSearch.Count > 0)
                    {
                        idSession = Int32.Parse(userId_txtBox.Text);
                        parseDataGridViewReserved(idSession);
                        parseDataGridViewBorrowed(idSession);
                    }
                    else
                    {
                        MessageBox.Show("No user correspond to your criteria", "Warning !");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("No user correspond to your criteria", "Warning !");
                }
                
            }
        }

        /// <summary>
        /// List books reserved by ISBN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnIsbn_Click(object sender, EventArgs e)
        {
            idSession = 0;
            List<TabReservedModel> _reservedISBN = bl.ListBooksReservedByISBN(isbn_txtbox.Text);
            if (_reservedISBN.Count > 0)
            {
                int UID = _reservedISBN[0].uid;
                parseDataGridViewReserved(UID);
                parseDataGridViewBorrowed(UID);
            }
            else
            {
                MessageBox.Show("No book correspond to your criteria", "Warning !");
            }
        }

        /// <summary>
        /// join table TabReserve (uid - >isbn) and ViewBook (isbn) and add to datagridview
        /// </summary>
        /// <param name="UID">int, condition</param>
        private void parseDataGridViewReserved(int UID)
        {
            //create a datatable to store all the data
            DataTable dtable = new DataTable();
            DataRow dRow;
            if (isbn_txtbox.Text != "")
            {
                //Get list of all the book reserved by the user (UID)
                List<TabReservedModel> _bookReserved = bl.ListBooksReservedByISBN(isbn_txtbox.Text);
                //Add the name of the colum for display
                dtable.Columns.Add(new DataColumn("RID"));
                dtable.Columns.Add(new DataColumn("Date"));
                dtable.Columns.Add(new DataColumn("UID"));
                dtable.Columns.Add(new DataColumn("User Name"));
                dtable.Columns.Add(new DataColumn("Isbn"));
                dtable.Columns.Add(new DataColumn("Book Name"));
                dtable.Columns.Add(new DataColumn("Author"));
                dtable.Columns.Add(new DataColumn("Publisher"));
                dtable.Columns.Add(new DataColumn("Language"));
                dtable.Columns.Add(new DataColumn("Category"));

                for (int i = 0; i < _bookReserved.Count(); i++)
                {
                    List<ViewBookModel> _bookReservedd = bl.GetBookInfo(isbn_txtbox.Text);
                    List<TabUserModel> _userInfo = ul.GetUserInfoByUID(_bookReserved[i].uid);
                    dRow = dtable.NewRow();
                    string aaa = _bookReserved[i].reservedDate;
                    //DateTime.ParseExact(aaa, "yy/MM/dd HH:mm:ss").ToString("MMM. dd, yyyy HH:mm:ss");
                    aaa = Convert.ToDateTime(aaa).ToString("dd MMM yyyy");
                    dRow["RID"] = _bookReserved[i].rid;
                    dRow["UID"] = _userInfo[0].UserID;
                    dRow["User Name"] = _userInfo[0].UserName;
                    dRow["Date"] = aaa;
                    dRow["Isbn"] = _bookReservedd[0].Isbn;
                    dRow["Book Name"] = _bookReservedd[0].BookName;
                    dRow["Author"] = _bookReservedd[0].AuthorName;
                    dRow["Publisher"] = _bookReservedd[0].Publisher;
                    dRow["Language"] = _bookReservedd[0].LanguageName;
                    dRow["Category"] = _bookReservedd[0].CategoryName;
                    dtable.Rows.Add(dRow);
                }
            }
            else
            {
                //Get list of all the book reserved by the user (UID)
                List<TabReservedModel> _bookReserved = bl.ListBooksReservedByUID(UID);
                //Add the name of the colum for display
                dtable.Columns.Add(new DataColumn("RID"));
                dtable.Columns.Add(new DataColumn("Date"));
                dtable.Columns.Add(new DataColumn("Isbn"));
                dtable.Columns.Add(new DataColumn("Book Name"));
                dtable.Columns.Add(new DataColumn("Author"));
                dtable.Columns.Add(new DataColumn("Publisher"));
                dtable.Columns.Add(new DataColumn("Language"));
                dtable.Columns.Add(new DataColumn("Category"));

                for (int i = 0; i < _bookReserved.Count(); i++)
                {
                    ISBN = _bookReserved[i].isbn;
                    //Get name of the book from ViewBook with ISBN
                    List<ViewBookModel> _bookReservedd = bl.GetBookInfo(ISBN);
                    dRow = dtable.NewRow();
                    string aaa = _bookReserved[i].reservedDate;
                    aaa = Convert.ToDateTime(aaa).ToString("dd MMM yyyy");
                    dRow["RID"] = _bookReserved[i].rid;
                    dRow["Date"] = aaa;
                    dRow["Isbn"] = _bookReservedd[0].Isbn;
                    dRow["Book Name"] = _bookReservedd[0].BookName;
                    dRow["Author"] = _bookReservedd[0].AuthorName;
                    dRow["Publisher"] = _bookReservedd[0].Publisher;
                    dRow["Language"] = _bookReservedd[0].LanguageName;
                    dRow["Category"] = _bookReservedd[0].CategoryName;
                    dtable.Rows.Add(dRow);
                }
            }
            //Add datatable to datagridview
            bookReserved_dataGridView.DataSource = dtable;
            this.bookReserved_dataGridView.Columns[0].Visible = false;
        }

        /// <summary>
        /// join table TabBorrowed (uid - >isbn) and ViewBook (isbn) and add to datagridview
        /// </summary>
        /// <param name="UID">int, condition</param>
        private void parseDataGridViewBorrowed(int UID)
        {
            //Get list of all the book borrowed by the user (UID)
            List<TabBorrowModel> _bookBorrowed = bl.ListBooksBorrowedByUID(UID);
            //create a datatable to store all the data
            DataTable dtable = new DataTable();
            DataRow dRow;
            //Add the name of the colum for display
            dtable.Columns.Add(new DataColumn("BID"));
            dtable.Columns.Add(new DataColumn("Borrow on"));
            dtable.Columns.Add(new DataColumn("Return date"));
            dtable.Columns.Add(new DataColumn("Isbn"));
            dtable.Columns.Add(new DataColumn("Book Name"));
            dtable.Columns.Add(new DataColumn("Author"));
            dtable.Columns.Add(new DataColumn("Language"));
            dtable.Columns.Add(new DataColumn("Category"));

            if (isbn_txtbox.Text != "")
            {
                //check if book has been return or still borrowed
                List<ViewBookBorrowedModel> _bookBorrowedRunning = bl.CheckBookSelected(isbn_txtbox.Text);
                    if (_bookBorrowedRunning.Count > 0)
                    {
                        //Get name of the book from ViewBook with ISBN
                        List<ViewBookModel> _bookBorrowed2 = bl.GetBookInfo(isbn_txtbox.Text);
                        dRow = dtable.NewRow();
                        string borrowDate = _bookBorrowed[0].borrowDate;
                        borrowDate = Convert.ToDateTime(borrowDate).ToString("dd MMM yyyy");
                        string returnDate = _bookBorrowed[0].returnDate;
                        returnDate = Convert.ToDateTime(returnDate).ToString("dd MMM yyyy");
                        dRow["BID"] = _bookBorrowed[0].bid;
                        dRow["Borrow on"] = borrowDate;
                        dRow["Return date"] = returnDate;
                        dRow["Isbn"] = _bookBorrowed2[0].Isbn;
                        dRow["Book Name"] = _bookBorrowed2[0].BookName;
                        dRow["Author"] = _bookBorrowed2[0].AuthorName;
                        dRow["Language"] = _bookBorrowed2[0].LanguageName;
                        dRow["Category"] = _bookBorrowed2[0].CategoryName;
                        dtable.Rows.Add(dRow);
                    }
            }
            else
            {
                for (int i = 0; i < _bookBorrowed.Count(); i++)
                {
                    ISBN = _bookBorrowed[i].isbn;

                    //check if book has been return or still borrowed
                    List<ViewBookBorrowedModel> _bookBorrowedRunning = bl.CheckBookSelected(ISBN);
                    if (_bookBorrowedRunning.Count > 0)
                    {
                        //Get name of the book from ViewBook with ISBN
                        List<ViewBookModel> _bookBorrowed2 = bl.GetBookInfo(ISBN);
                        dRow = dtable.NewRow();
                        string borrowDate = _bookBorrowed[i].borrowDate;
                        borrowDate = Convert.ToDateTime(borrowDate).ToString("dd MMM yyyy");
                        string returnDate = _bookBorrowed[i].returnDate;
                        returnDate = Convert.ToDateTime(returnDate).ToString("dd MMM yyyy");
                        dRow["BID"] = _bookBorrowed[i].bid;
                        dRow["Borrow on"] = borrowDate;
                        dRow["Return date"] = returnDate;
                        dRow["Isbn"] = _bookBorrowed2[0].Isbn;
                        dRow["Book Name"] = _bookBorrowed2[0].BookName;
                        dRow["Author"] = _bookBorrowed2[0].AuthorName;
                        dRow["Language"] = _bookBorrowed2[0].LanguageName;
                        dRow["Category"] = _bookBorrowed2[0].CategoryName;
                        dtable.Rows.Add(dRow);
                    }
                }
            }
            //Add datatable to datagridview
            bookBorrowed_dataGridView.DataSource = dtable;
            this.bookBorrowed_dataGridView.Columns[0].Visible = false;
        }

        //Delete book from TabReserved (with RID)
        private void deleteBookReservedSelected_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure ?\nYou will loose your place in the waiting list.", "Confirmation...", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Book Reservation canceled for: "+bookReserved_dataGridView.SelectedRows[0].Cells[3].Value.ToString(), "A message from AIT Library");
                bl.DeleteFromTabReserved(Int32.Parse(bookReserved_dataGridView.SelectedRows[0].Cells[0].Value.ToString()));
                parseDataGridViewReserved(idSession);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            } 
        }

        //Update book from TabBorrowed (with BID)
        private void returnBookBorrowedSelected_Click(object sender, EventArgs e)
        {
            //check if day left
            List<TabBorrowModel> _books = bl.ListBooksBorrowedByBID(Int32.Parse(bookBorrowed_dataGridView.SelectedRows[0].Cells[0].Value.ToString()));
            string strReturnDate = _books[0].returnDate;
            string borrowDate = _books[0].borrowDate;
            borrowDate = Convert.ToDateTime(borrowDate).ToString("dd MMM yyyy");
            string returnDateNice = Convert.ToDateTime(strReturnDate).ToString("dd MMM yyyy");
            string actualReturnDate = Convert.ToDateTime(todayDate).ToString("dd MMM yyyy");
            string bookName = bookBorrowed_dataGridView.SelectedRows[0].Cells[4].Value.ToString();
            string aaa = _books[0].isbn;
            DateTime returnDate = Convert.ToDateTime(strReturnDate);
            int Days = (returnDate.Date - todayDate.Date).Days;
            int DaysFee = Days * -1; //to convert to a positive number
            
            //if Days > 0
            if (Days > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure ?\nYou still have " + Days + " days left", "Confirmation...", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Book \"" + bookName + "\" returned !", "A message from AIT Library");
                    //update TabBorrowed
                    bl.UpdateFromTabBorrowed(todayDate.ToString(), 0, Int32.Parse(bookBorrowed_dataGridView.SelectedRows[0].Cells[0].Value.ToString()));
                    //bl.DeleteFromTabReserved(Int32.Parse(bookReserved_dataGridView.SelectedRows[0].Cells[0].Value.ToString()));
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    //do nothing
                }
            }
            //Just on time
            else if (Days == 0)
            {
                MessageBox.Show("Book \"" + bookName + "\" returned !\nThank you..", "A message from AIT Library");
                bl.UpdateFromTabBorrowed(todayDate.ToString(), 0, Int32.Parse(bookBorrowed_dataGridView.SelectedRows[0].Cells[0].Value.ToString()));
            }
            //Late return
            else
            {
                decimal fee = 0;
                fee = DaysFee * 2;
                DialogResult dialogResult = MessageBox.Show("You have overtake the return date !\n\n Fee will be charge", "A message from AIT Library", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    bl.UpdateFromTabBorrowed(todayDate.ToString(), fee, Int32.Parse(bookBorrowed_dataGridView.SelectedRows[0].Cells[0].Value.ToString()));
                    MessageBox.Show("Book \"" + bookName + "\" returned !\n\n----- Details -----\nBorowed Date: " + borrowDate + "\nPresume Return Date: " + returnDateNice + "\n\nActual Return Date: " + actualReturnDate + "\nDays over: " + DaysFee + "days\nFees: " + DaysFee + " x 2$ = $"+ fee + " AUD", "A message from AIT Library");
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    //do nothing
                }
            }
            //refresh List
            parseDataGridViewBorrowed(idSession);
        }
    }
}
