using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace AITLibrary
{
    public abstract partial class Template : MyForm
    {
        public Template()
        {
            InitializeComponent();
        }

        // load the Form
        private void test_load(object sender, EventArgs e)
        {
            Console.WriteLine("Today: {0}", DateTime.Today);

            //only Admin can see all user (level 3 only)
            if (staticUserLevel == 3)
            {
                UsersSearch.Visible = true;
            }
            if (staticUserLevel == 3 || staticUserLevel == 2)
            {
                btnManageBook.Text = "         Manage Books";
                btnBorrowBook.Text = "         Borrow/reserve a book";
            }
            if (staticUserLevel == 2)
            {
                btnAddUser.Enabled = false;
                btnAddNewBook.Enabled = false;
            }
            if (staticUserLevel == 1)
            {
                UsersSearch.Visible = false;
                adminBook.Visible = false;
                btnStats.Visible = false; //no stats displayed
            }

            // name of the user to show on the form
            userName.Text = staticUserName;

            // create a timer for showings the seconds
            System.Windows.Forms.Timer tmr = null;

            tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;

        }

        // display the date & time
        void tmr_Tick(object sender, EventArgs e)
        {
            dateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        //Hide diferren Panel
        public abstract void hidePanel(object sender, MouseEventArgs e);

        //Occur when clicking on the "Add/Delete User" button
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(AddUserForm));
            t.Start();

            this.Close();
        }

        //Occur when clicking on the "Search Book" button
        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(SearchBookForm));
            t.Start();

            this.Close();
        }

        //Occur when clicking on the "Borrow book" button
        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ReserveBorrowBookForm));
            t.Start();

            this.Close();
        }

        //Occur when clicking on the "View book Reserved/Borrowed" button
        private void btnViewBookReservedBorrowed_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(BookReservedBorrowedForm));
            t.Start();

            this.Close();
        }

        //Occur when clicking on the "Add New Book" button
        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(AddBookForm));
            t.Start();

            this.Close();
        }

        //AddUser Form Load
        public static void AddUserForm()
        {
            Application.Run(new AddUser());
        }

        //SearchBook Form Load
        public static void SearchBookForm()
        {
            Application.Run(new SearchBook());
        }

        //ReserveBorrowBook Form Load
        public static void ReserveBorrowBookForm()
        {
            Application.Run(new ReserveBorrowBook());
        }

        //BookReservedBorrowed Form Load
        public static void BookReservedBorrowedForm()
        {
            Application.Run(new BookReservedBorrowed());
        }

        //AddBook Form Load
        public static void AddBookForm()
        {
            Application.Run(new AddBook());
        }

        //Show all books
        public void btnShowBooks_Click(object sender, EventArgs e)
        {
            //panelSearch.Visible = false;
            BookLogic bl = new BookLogic();
            dataGridView1.DataSource = bl.ListBooks();
        }

        //show books available
        public void btnShowBooksAvailable_Click(object sender, EventArgs e)
        {
            BookLogic bl = new BookLogic();
            dataGridView1.DataSource = bl.ListBooksAvailable();
        }

        /// <summary>
        /// Show book borrowed (from BorrowedAndUser Model)
        /// with userName
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnViewBookBorrowed_Click(object sender, EventArgs e)
        {
            BookLogic bl = new BookLogic();
            dataGridView1.DataSource = bl.GetBorrowAndUser();
        }

        /// <summary>
        /// Get all stats (report)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewStats_Click(object sender, EventArgs e)
        {
            UserLogic ul = new UserLogic();
            BookLogic bl = new BookLogic();
            //Nb users
            int nbUser = ul.NumberOfUsers();
            //nb Books
            List<ViewBookModel> _nbBook = bl.ListBooks();
            int nbBook = _nbBook.Count;
            //nb book available
            List<ViewBookAvailableModel> _nbBookAvailable = bl.ListBooksAvailable();
            int nbBookAvailable = _nbBookAvailable.Count;
            //nb book borrowed
            List<ViewBookBorrowedModel> _nbBookBorrowed = bl.ListBooksBorrowed();
            int nbBookBorrowed = _nbBookBorrowed.Count;
            //total book borrowed (all the time)
            int NbOfBooksBorrowedStart = bl.NbOfBooksBorrowedStart();
            //total fee received
            decimal nbFee = bl.SumLateFee();
            //number of books reserved
            List<TabReservedModel> _nbBookReserved = bl.ListBooksReserved();
            int nbBookReserved = _nbBookReserved.Count;
            //number of english books
            int nbEnglishBook = bl.NbOfEnglishBooks();
            //number book in other language
            int nbOtherBook = nbBook - nbEnglishBook;
            //number of books returned late
            int nbBookReturnedLate = bl.NbBookreturnLate();

            MessageBox.Show("Stats of AIT Library on " + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") +
                "\n\nTotal Users: "+nbUser+
                "\n---------------"+
                "\nNumber of books: "+nbBook+
                "\nNumber of books available: "+nbBookAvailable+
                "\nNumber of books in english: "+nbEnglishBook+
                "\nNumber of books in other language: "+nbOtherBook+
                "\nNumber of books borrowed: "+nbBookBorrowed+
                "\nTotal books borrowed (since 1st day): "+NbOfBooksBorrowedStart+
                "\nNumber of books returned late: "+nbBookReturnedLate+
                "\nTotal fee received: $"+nbFee+"AUD"+
                "\nNumber of books reserved: "+nbBookReserved+
                "");
        }

        //Logout
        private void logOut_Click(object sender, EventArgs e)
        {
            // open the Main form (frmMain) and close the form 2
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenMainForm));
            t.Start();

            this.Close();
        }

        // open Main Form
        public static void OpenMainForm()
        {
            Application.Run(new frmMain());
        }
   }
}
