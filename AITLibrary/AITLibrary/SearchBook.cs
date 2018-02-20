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
    public partial class SearchBook : Template
    {
        public SearchBook()
        {
            InitializeComponent();
        }
        #region Set Variable
        BookLogic bl = new BookLogic();
        public static string isbn_db;
        public static string bookName_db;
        public static string author_db;
        public static string category_db;
        public static string language_db;
        public static string publishYear_db;
        public static string pages_db;
        public static string publisher_db;
        int result = 0;
        int result1 = 0;
        int result2 = 0;
        #endregion

        //Hide diferren Panel
        public override void hidePanel(object sender, MouseEventArgs e)
        {
            panelSearch.Visible = false;
            DeleteEdit_panel.Visible = false;
        }

        //load when the form load
        private void SearchBook_load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bl.ListBooks();
            DeleteEdit_panel.Visible = false;

            //List of all the category
            catList.DataSource = bl.CategoryList();
            catList.DisplayMember = "CategoryName";

            //List of all the author
            authorList.DataSource = bl.AuthorList();
            authorList.DisplayMember = "AuthorName";

            //only Admin can edit delete a book
            if (staticUserLevel == 3)
            {
                DeleteEdit_panel.Visible = true;
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

        //Search an author when search button is clicked
        private void searchByAuthor_Click(object sender, EventArgs e)
        {
            //if author is from the author List
            if (authorList.Text != "Textbox Only")
            {
                authorValue.Text = authorList.Text;
            }
            if (bookAvailable_checkBox.Checked == true)
            {
                dataGridView1.DataSource = bl.SearchBooksAvailable(authorValue.Text, catList.Text, bookName.Text);

            }
            else
            {
                dataGridView1.DataSource = bl.SearchBooks(authorValue.Text, catList.Text, bookName.Text);
            }          
        }

        /// <summary>
        /// Delete a book from tabBook
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteSelectedBook_Click(object sender, EventArgs e)
        {
            //check if book has been returned
            List<ViewBookBorrowedModel> _bookBorrowed = bl.CheckBookSelected(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            if (_bookBorrowed.Count > 0)
            {
                //Book borrowed can't delete
                MessageBox.Show("You can't delete a book still borrowed");
            }
            else
            {
                List<TabReservedModel> _bookReserved = bl.ListBooksReservedByISBN(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                if (_bookReserved.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("WARNING ! Deleting this book \n" +
                    "will prevent " + _bookReserved.Count + " user(s) to borrowed it\n\n"+
                    "----- By deleting a book you will loose any stats relating to this book -----\n\nWould you like to proceed anyway ?", "Warning Message !...", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        MessageBox.Show("The book: " + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + " has been remove from the database", "A message from AIT Library");
                       // deleting a book will result to
                        //delete from TabReserve, TabBorrowed, TabBook
                        result2 = bl.DeleteFromTabReservedByISBN(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        result1 = bl.DeleteFromTabBorrowed(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        result = bl.DeleteFromTabBook(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        dataGridView1.DataSource = bl.ListBooks();
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        //do nothing
                    }
                }
                else
                {
                    int result = 0;
                    DialogResult dialogResult = MessageBox.Show("Are you sure ?\nThis book will be remove from the database\n\n----- By deleting a book you will loose any stats relating to this book -----", "Confirmation...", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show("The book: " + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + " has been remove from the database", "A message from AIT Library");
                        result2 = bl.DeleteFromTabReservedByISBN(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        result1 = bl.DeleteFromTabBorrowed(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        result = bl.DeleteFromTabBook(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        dataGridView1.DataSource = bl.ListBooks();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do nothing
                    }
                }
            }
            
        }

        private void btnUpdateSelectedBook_Click(object sender, EventArgs e)
        {
            bookStatus = "Update";
            //get all the information of the book and set them as static
            isbn_db = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            bookName_db = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            publisher_db = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            publishYear_db = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            pages_db = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            author_db = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            category_db = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            language_db = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(UpdateBookForm));
            t.Start();
            this.Close();      
        }

        public static void UpdateBookForm()
        {
            Application.Run(new AddBook());
        }
    }
}
