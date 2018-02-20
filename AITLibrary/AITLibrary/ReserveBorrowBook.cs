using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace AITLibrary
{
    public partial class ReserveBorrowBook : Template
    {
        public ReserveBorrowBook()
        {
            InitializeComponent();
        }

        #region set variable
        public string ISBN;
        #endregion
        BookLogic bl = new BookLogic();

        //Hide diferren Panel
        public override void hidePanel(object sender, MouseEventArgs e)
        {
            panelSearch.Visible = false;
            showBooks_dataGridView.Visible = false;
            dataGridView1.Visible = true;
        }

        /// <summary>
        /// Loading script when form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReserveBorrowBook_load(object sender, EventArgs e)
        {
            panelSearch.Visible = true;
            dataGridView1.Visible = false;

            loadDataGridViewWithImage(null, e);

            catList.DataSource = bl.CategoryList();
            catList.DisplayMember = "CategoryName";

            //BookLogic bl2 = new BookLogic();
            authorList.DataSource = bl.AuthorList();
            authorList.DisplayMember = "AuthorName";

            if (staticUserLevel == 2 || staticUserLevel == 3)
            {
                userID_panel.Visible = true;
            }
            else
            {
                userID_panel.Visible = false;
            }
        }

        /// <summary>
        /// Show table ViewBook with icon image for books available and the one already borrowed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadDataGridViewWithImage(object sender, EventArgs e)
        {
            showBooks_dataGridView.Columns.Clear();
            showBooks_dataGridView.Refresh();
            showBooks_dataGridView.DataSource = bl.ListBooks();

            //Add new column for image propose
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Name = "img";
            img.HeaderText = "Dispo";
            showBooks_dataGridView.Columns.Add(img);

            List<ViewBookAvailableModel> _books = bl.ListBooksAvailable();
            int number_of_rows = showBooks_dataGridView.RowCount;
            for (int i = 0; i < number_of_rows; i++)
            {
                for (int j = 0; j < _books.Count; j++)
                {
                    if (showBooks_dataGridView.Rows[i].Cells[0].Value.ToString() == _books[j].Isbn)
                    {
                        //book available
                        Icon image = AITLibrary.Properties.Resources.available3;
                        showBooks_dataGridView.Rows[i].Cells["img"].Value = image;
                        j = _books.Count;
                    }
                    else
                    {
                        //book not available
                        Icon image = AITLibrary.Properties.Resources.not_available2;
                        showBooks_dataGridView.Rows[i].Cells["img"].Value = image;
                    }
                }
            }
        }

        // When authorList is clicked clear the authorTxtBox value
        private void AuthorList_Click(object sender, MouseEventArgs e)
        {
            authorValue.Text = "";
        }

        // When the authorBox is clicked select the index 0 in the authorList
        private void AuthorTxtBox_Click(object sender, MouseEventArgs e)
        {
            authorList.SelectedIndex = 0;
        }

        /// <summary>
        /// Search by Author
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchByAuthor_Click(object sender, EventArgs e)
        {
            BookLogic bl = new BookLogic();
            if (authorList.Text != "Textbox Only")
            {
                authorValue.Text = authorList.Text;
            }
            showBooks_dataGridView.Columns.Clear();
            showBooks_dataGridView.Refresh();
            if (bookAvailable_checkBox.Checked == true)
            {
                showBooks_dataGridView.DataSource = bl.SearchBooksAvailable(authorValue.Text, catList.Text, bookName.Text);
            }
            else
            {
                showBooks_dataGridView.DataSource = bl.SearchBooks(authorValue.Text, catList.Text, bookName.Text);
            }

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Name = "img";
            img.HeaderText = "Dispo";
            showBooks_dataGridView.Columns.Add(img);

            List<ViewBookAvailableModel> _books = bl.ListBooksAvailable();
            int number_of_rows = showBooks_dataGridView.RowCount;
            for (int i = 0; i < number_of_rows; i++)
            {
                for (int j = 0; j < _books.Count; j++)
                {
                    if (showBooks_dataGridView.Rows[i].Cells[0].Value.ToString() == _books[j].Isbn)
                    {
                        Icon image = AITLibrary.Properties.Resources.available3;
                        showBooks_dataGridView.Rows[i].Cells["img"].Value = image;
                        j = _books.Count;
                    }
                    else
                    {
                        Icon image = AITLibrary.Properties.Resources.not_available2;
                        showBooks_dataGridView.Rows[i].Cells["img"].Value = image;
                    }
                }
            }
        }

        /// <summary>
        /// Borrow a book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrowBookSelected_click(object sender, EventArgs e)
        {
            bool borrowedAllowed = true;
            BookLogic bl = new BookLogic();

            List<ViewBookBorrowedModel> _bookBorrowed = bl.CheckBookSelected(showBooks_dataGridView.SelectedRows[0].Cells[0].Value.ToString());

            if (staticUserLevel == 2 || staticUserLevel == 3)
            {
                try
                {
                    //check if userID is not empty
                    if (userID_input.Text == "")
                    {
                        MessageBox.Show("User ID is empty, you need to fill it first", "A message from AIT Library");
                        borrowedAllowed = false;
                    }
                    else
                    {
                        //check if user exist
                        UserLogic ul = new UserLogic();
                        List<TabUserModel> _userSearch = ul.GetUserInfoByUID(Int32.Parse(userID_input.Text));
                        if (_userSearch.Count > 0)
                        {
                            //try to parse to INT
                            staticUID = Int32.Parse(userID_input.Text);
                        }
                        else
                        {
                            MessageBox.Show("No user correspond to your criteria", "Warning !");
                            borrowedAllowed = false;
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("User ID must be a valid number", "A message from AIT Library");
                    borrowedAllowed = false;
                }
            }
            //If no error then we proceed to the rest of the script
            if (borrowedAllowed == true)
            {
                if (_bookBorrowed.Count < 1)
                {
                    List<ViewBookModel> _book = bl.GetBookInfo(showBooks_dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    ISBN = _book[0].Isbn;
                    string BookName = _book[0].BookName;
                    string CategoryName = _book[0].CategoryName;
                    string Publisher = _book[0].Publisher;
                    int PublishYear = _book[0].PublisherYear;
                    int Page = _book[0].Pages;
                    string AuthorName = _book[0].AuthorName;
                    string LanguageName = _book[0].LanguageName;

                    List<TabBookModel> _bookID = bl.GetTabBookInfo(showBooks_dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    int Author = _bookID[0].AuthorID;
                    int Category = _bookID[0].CategoryID;
                    int Language = _bookID[0].LanguageID;

                    //string BorrowDate = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
                    DateTime borrowDate = DateTime.Now;
                    DateTime returnDate = borrowDate.AddDays(3);
                    string BorrowDate = borrowDate.ToString("dddd, dd MMMM yyyy HH:mm:ss");
                    string ReturnDate = returnDate.ToString("dddd, dd MMMM yyyy HH:mm:ss");

                    MessageBox.Show("Book Borrowed: " + showBooks_dataGridView.SelectedRows[0].Cells[1].Value.ToString() +
                        "\n-----------------------\nBorrow date: " + BorrowDate + "\nReturn Date: " + ReturnDate, "Book Confirmation");
                    bl.InsertBookTabBorrow(staticUID, ISBN, BorrowDate, ReturnDate, "2000-01-01", 0);
                }
                //Book not available so we ask the user if he want to reserve it
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Sorry ! This book is not available.\n\nWould you like to reserved it ?", "Please make a choice", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //we check if user not have already the book in his possession
                        List<TabBorrowModel> _bookBorrowedAlready = bl.ListBooksBorrowedByUIDIsbnActual(staticUID, showBooks_dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                        if (_bookBorrowedAlready.Count > 0)
                        {
                            MessageBox.Show("Sorry ! You can't reserved a book in your possession", "A message from AIT Library");
                        }
                        else
                        {
                            //get isbn
                            List<ViewBookModel> _book = bl.GetBookInfo(showBooks_dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                            ISBN = _book[0].Isbn;
                            //check if user already has reserved this book
                            List<TabReservedModel> _bookReserved = bl.CheckBooksReserved(staticUID, ISBN);
                            if (_bookReserved.Count > 0)
                            {
                                string reservedDate = _bookReserved[0].reservedDate;
                                DateTime dateReserved = DateTime.Parse(reservedDate);
                                MessageBox.Show("Sorry, You have already reserved this book on " + dateReserved.ToString("dddd, dd MMMM yyyy"), "Error");
                            }
                            else
                            {
                                //add book to tabReserved
                                DateTime todayDate = DateTime.Now;
                                string todayReservedDate = todayDate.ToString("dddd, dd MMMM yyyy HH:mm:ss");
                                bl.InsertBookTabReserved(staticUID, ISBN, todayReservedDate);
                                MessageBox.Show("You just reserved the book " + showBooks_dataGridView.SelectedRows[0].Cells[1].Value.ToString(), "Reservation Confirmation");
                            }
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do nothing
                    }
                }

                //refresh list user with image
                loadDataGridViewWithImage(null, e);
            }
        }

        public void btnReserveBookSelected_Click(object sender, EventArgs e)
        {
            bool borrowedAllowed = true;
            BookLogic bl = new BookLogic();
            //check if the book is not available, if available we can reserve it
             List<ViewBookBorrowedModel> _bookBorrowed = bl.CheckBookSelected(showBooks_dataGridView.SelectedRows[0].Cells[0].Value.ToString());
             
            //only admin and supervisor
            if (staticUserLevel == 2 || staticUserLevel == 3)
            {
                try
                {
                    //check if userID is not empty
                    if (userID_input.Text == "")
                    {
                        MessageBox.Show("User ID is empty, you need to fill it first", "A message from AIT Library");
                        borrowedAllowed = false;
                    }
                    else
                    {
                        //check if user exist
                        UserLogic ul = new UserLogic();
                        List<TabUserModel> _userSearch = ul.GetUserInfoByUID(Int32.Parse(userID_input.Text));
                        if (_userSearch.Count > 0)
                        {
                            //try to parse to INT
                            staticUID = Int32.Parse(userID_input.Text);
                        }
                        else
                        {
                            MessageBox.Show("No user correspond to your criteria", "Warning !");
                            borrowedAllowed = false;
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("User ID must be a valid number", "A message from AIT Library");
                    borrowedAllowed = false;
                }
            }
            if (borrowedAllowed == true)
            {
                if (_bookBorrowed.Count < 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Sorry ! You can't reserve a book available.\n\nWould you like to borrowed it ?", "Please make a choice", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        btnBorrowBookSelected_click(null, e);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do nothing
                    }
                }
                else
                {
                    //we check if user not have already the book in his possession
                    List<TabBorrowModel> _bookBorrowedAlready = bl.ListBooksBorrowedByUIDIsbnActual(staticUID, showBooks_dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    if (_bookBorrowedAlready.Count > 0)
                    {
                        MessageBox.Show("Sorry ! You can't reserved a book in your possession", "A message from AIT Library");
                    }
                    else
                    {
                        //get isbn
                        List<ViewBookModel> _book = bl.GetBookInfo(showBooks_dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                        ISBN = _book[0].Isbn;
                        //check if user already has reserved this book
                        List<TabReservedModel> _bookReserved = bl.CheckBooksReserved(staticUID, ISBN);
                        if (_bookReserved.Count > 0)
                        {
                            string reservedDate = _bookReserved[0].reservedDate;
                            DateTime dateReserved = DateTime.Parse(reservedDate);
                            MessageBox.Show("Sorry, You have already reserved this book on " + dateReserved.ToString("dddd, dd MMMM yyyy"), "Error");
                        }
                        else
                        {
                            //add book to tabReserved
                            DateTime todayDate = DateTime.Now;
                            string todayReservedDate = todayDate.ToString("dddd, dd MMMM yyyy HH:mm:ss");
                            bl.InsertBookTabReserved(staticUID, ISBN, todayReservedDate);
                            MessageBox.Show("You just reserved the book " + showBooks_dataGridView.SelectedRows[0].Cells[1].Value.ToString(), "Reservation Confirmation");
                        }
                    }
                }
            }
        }
    }
}
