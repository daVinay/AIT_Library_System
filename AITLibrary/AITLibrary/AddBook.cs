using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;
using System.Text.RegularExpressions;

namespace AITLibrary
{
    public partial class AddBook : Template
    {
        public AddBook()
        {
            InitializeComponent();
        }

        #region set variable
        private string errorReturn;
        private int counterError = 0;
        #endregion

        //when the form is load
        private void AddBook_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;

            BookLogic bl = new BookLogic();

            //Get List of Category/Language/Author
            Category_List.DataSource = bl.ListCategory();
            Category_List.DisplayMember = "PairName";
            Category_List.ValueMember = "PairID";

            Language_List.DataSource = bl.ListLanguage();
            Language_List.DisplayMember = "PairName";
            Language_List.ValueMember = "PairID";

            Author_List.DataSource = bl.ListAuthor();
            Author_List.DisplayMember = "PairName";
            Author_List.ValueMember = "PairID";

            //If it's an update we change some information on the form
            if (bookStatus == "Update")
            {
                book_group.Text = "Update a book";              //name of the group box
                //We got the value from SearchBook
                Isbn_txtBox.Text = SearchBook.isbn_db;
                Isbn_txtBox.Enabled = false;
                BookName_txtBox.Text = SearchBook.bookName_db;
                Publisher_txtBox.Text = SearchBook.publisher_db;
                PublisherYear_txtBox.Text = SearchBook.publishYear_db;
                Pages_txtBox.Text = SearchBook.pages_db;
                Author_List.SelectedIndex = Author_List.FindString(SearchBook.author_db);
                Category_List.SelectedIndex = Category_List.FindString(SearchBook.category_db);
                Language_List.SelectedIndex = Language_List.FindString(SearchBook.language_db);
                //We update the function after clicking on the button
                btnAddBook.Text = "Update book";
                btnAddBook.Click -= btnAddBook_Click;
                btnAddBook.Click += btnUpdateBook_Click;
            }
        }


        //Hide diferren Panel
        public override void hidePanel(object sender, MouseEventArgs e)
        {
            dataGridView1.Visible = true;
            addBook_panel.Visible = false;

        }

        //Add author to tabBook
        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            //check the field Author
            if (!checkEmpty(authorName_add.Text, "Author Name", null))
            {
                bool authorNameCheck = checkIfProperWord(authorName_add.Text);
                if (!authorNameCheck)
                {
                    counterError++;
                    addAuthor_return.Visible = true;
                    addAuthor_return.Text = "This Author Name is incorrect";
                }
            }
            else
            {
                counterError++;
                addAuthor_return.Visible = true;
                addAuthor_return.Text = "This field is empty";
            }
            if (counterError == 0)
            {
                BookLogic bl = new BookLogic();

                int result = bl.InsertAuthorTabAuthor(authorName_add.Text);
                MessageBox.Show("New author added !", "A message from AIT Library");

                //refresh author list
                Author_List.DataSource = bl.ListAuthor();
                Author_List.DisplayMember = "PairName";
                Author_List.ValueMember = "PairID";
            }
        }

        //Add Category to tabCategory
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            //check the field Category
            if (!checkEmpty(category_add.Text, "Category Name", null))
            {
                bool categoryNameCheck = checkIfProperWord(category_add.Text);
                if (!categoryNameCheck)
                {
                    addCategory_return.Visible = true;
                    addCategory_return.Text = "This Category Name is incorrect"; 
                    counterError++;
                }
            }
            else
            {
                counterError++;
                addCategory_return.Visible = true;
                addCategory_return.Text = "This field is empty";
            }
            if (counterError == 0)
            {
                BookLogic bl = new BookLogic();

                int result = bl.InsertCategoryTabCategory(category_add.Text);

                MessageBox.Show("New category added !", "A message from AIT Library");

                //refresh author list
                Category_List.DataSource = bl.ListCategory();
                Category_List.DisplayMember = "PairName";
                Category_List.ValueMember = "PairID";
            }
        }

        //Add language to tabLanguage
        private void btnAddLanguage_Click(object sender, EventArgs e)
        {
            //check the field Category
            if (!checkEmpty(language_add.Text, "Language Name", null))
            {
                bool languageNameCheck = checkIfProperWord(language_add.Text);
                if (!languageNameCheck)
                {
                    addLanguage_return.Visible = true;
                    addLanguage_return.Text = "This Language Name is incorrect"; 
                    counterError++;
                }
            }
            else
            {
                counterError++;
                addLanguage_return.Visible = true;
                addLanguage_return.Text = "This field is empty";
            }
            if (counterError == 0)
            {
                BookLogic bl = new BookLogic();

                int result = bl.InsertLanguageTabLanguage(language_add.Text);

                MessageBox.Show("New language added !", "A message from AIT Library");

                //refresh author list
                Language_List.DataSource = bl.ListLanguage();
                Language_List.DisplayMember = "PairName";
                Language_List.ValueMember = "PairID";
            }
        }

        /// <summary>
        /// Check all the field and stock error in errorReturn
        /// </summary>
        private void checkField()
        {
            errorReturn = "The following field are incorrect: \n";

            //check the field ISBN
            if (!checkEmpty(Isbn_txtBox.Text, "Isbn", isbn_label))
            {
                bool isbnCheck = checkIfNumber(Isbn_txtBox.Text);
                if (!isbnCheck) { errorReturn += "-Isbn must be a number\n"; counterError++; isbn_label.ForeColor = System.Drawing.Color.Red; }
                if (Isbn_txtBox.Text.Length != 13) { errorReturn += "-Isbn must be 13 characters\n"; counterError++; isbn_label.ForeColor = System.Drawing.Color.Red; }
            }

            //check the field bookName
            if (!checkEmpty(BookName_txtBox.Text, "Book Name", bookName_label))
            {
                bool bookNameCheck = checkIfProperWord(BookName_txtBox.Text);
                if (!bookNameCheck) { errorReturn += "-Book Name is incorrect (must be a correct name)\n"; counterError++; bookName_label.ForeColor = System.Drawing.Color.Red; }
            }

            //check the field publisher
            if (!checkEmpty(Publisher_txtBox.Text, "Publisher", publisher_label))
            {
                bool publisherCheck = checkIfProperWord(Publisher_txtBox.Text);
                if (!publisherCheck) { errorReturn += "-Publisher is incorrect (must be a correct name)\n"; counterError++; publisher_label.ForeColor = System.Drawing.Color.Red; }
            }

            //check the field publisher year
            if (!checkEmpty(PublisherYear_txtBox.Text, "Publisher Year", publisherYear_label))
            {
                bool publisherYearCheck = checkIfYear(PublisherYear_txtBox.Text);
                if (!publisherYearCheck) { errorReturn += "-Publisher Year must be a valid year (1990 - 2016)\n"; counterError++; publisherYear_label.ForeColor = System.Drawing.Color.Red; }
            }

            //check the field pages
            if (!checkEmpty(Pages_txtBox.Text, "Pages", pages_label))
            {
                bool pagesCheck = checkIfNumber(Pages_txtBox.Text);
                if (!pagesCheck) { errorReturn += "-Pages must be a number\n"; counterError++; pages_label.ForeColor = System.Drawing.Color.Red; }
            }
        }

        /// <summary>
        /// /// Add New Book to datatabse and parse all the string value into int 
        /// if necessary and then trim all the value for removing space
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            checkField();

            if (counterError > 0) 
            { 
                MessageBox.Show(errorReturn); counterError = 0; 
            } 
            else 
            {
                try
                {
                    BookLogic bl = new BookLogic();
                    int result = bl.InsertBookTabBook(Isbn_txtBox.Text.Trim(), BookName_txtBox.Text.Trim(), Int32.Parse(Author_List.SelectedValue.ToString()), Int32.Parse(Category_List.SelectedValue.ToString()), Int32.Parse(Language_List.SelectedValue.ToString()), Int32.Parse(PublisherYear_txtBox.Text.Trim()), Int32.Parse(Pages_txtBox.Text.Trim()), Publisher_txtBox.Text.Trim());                 
                    MessageBox.Show("New Book added to the database !\n---------------\nIsbn: " + Isbn_txtBox.Text.Trim() + 
                        "\nBook Name: " + BookName_txtBox.Text.Trim() +
                        "\nAuthor: " + Author_List.Text +
                        "\nCategory: "+Category_List.Text+
                        "\nLanguage: "+Language_List.Text+
                        "\nPublisher: "+Publisher_txtBox.Text.Trim()+
                        "\nPublisher Year: "+Int32.Parse(PublisherYear_txtBox.Text.Trim())+
                        "\nPages: "+Int32.Parse(Pages_txtBox.Text.Trim())); 
                }
                catch (Exception ex)
                {
                   throw ex;
                }
            }
        }

        //if update
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            checkField();

            if (counterError > 0)
            {
                MessageBox.Show(errorReturn); counterError = 0;
            }
            else
            {
                try
                {
                    BookLogic bl = new BookLogic();
                    int result = bl.UpdateFromTabBook(BookName_txtBox.Text.Trim(), Int32.Parse(Author_List.SelectedValue.ToString()), Int32.Parse(Category_List.SelectedValue.ToString()), Int32.Parse(Language_List.SelectedValue.ToString()), Int32.Parse(PublisherYear_txtBox.Text.Trim()), Int32.Parse(Pages_txtBox.Text.Trim()), Publisher_txtBox.Text.Trim(), Isbn_txtBox.Text.Trim());
                    MessageBox.Show("Book Update to the database !\n---------------\nIsbn: " + Isbn_txtBox.Text.Trim() +
                        "\nBook Name: " + BookName_txtBox.Text.Trim() +
                        "\nAuthor: " + Author_List.Text + 
                        "\nCategory: " + Category_List.Text +
                        "\nLanguage: " + Language_List.Text +
                        "\nPublisher: " + Publisher_txtBox.Text.Trim() +
                        "\nPublisher Year: " + Int32.Parse(PublisherYear_txtBox.Text.Trim()) +
                        "\nPages: " + Int32.Parse(Pages_txtBox.Text.Trim()));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        //check if value is a number
        private bool checkIfNumber(string value)
        {
            bool answer = Regex.IsMatch(value, @"^\d+$");
            return answer;
        }

        //check if value is a number
        private bool checkIfYear(string value)
        {
            //1990 - 2016 in this case
            bool answer = Regex.IsMatch(value, @"^(199\d|200\d|2016)$");
            return answer;
        }

        //check if it's a proper name
        private bool checkIfProperWord(string value)
        {
            bool answer = Regex.IsMatch(value, @"^(\s)*(.)?[A-Za-z]+((\s)?((\'|\-|\.|\&)?(\s)?([A-Za-z])+))*(\s)*$");
            return answer;
        }

        //check if value is not empty
        private bool checkEmpty(string value, string name, Label label)
        {
            if (String.IsNullOrEmpty(value))
            {
                errorReturn += "-"+name + " is empty\n";
                //label.ForeColor = System.Drawing.Color.Red;
                counterError++;
                return true;
            }
            return false;
        }

        //Change color for all label who had an error (when the user enter inside the textBox)
        private void removePublisherYearLabel(object sender, EventArgs e)
        {
            publisherYear_label.ForeColor = System.Drawing.Color.Black;
        }

        private void RemovePublisherLabel(object sender, EventArgs e)
        {
            publisher_label.ForeColor = System.Drawing.Color.Black;
        }

        private void RemoveBookNameLabel(object sender, EventArgs e)
        {
            bookName_label.ForeColor = System.Drawing.Color.Black;
        }

        private void RemoveISBNLabel(object sender, EventArgs e)
        {
            isbn_label.ForeColor = System.Drawing.Color.Black;
        }

        private void RemovePagesLabel(object sender, EventArgs e)
        {
            pages_label.ForeColor = System.Drawing.Color.Black;
        }

        private void addLanguage_Focus(object sender, EventArgs e)
        {
            addLanguage_return.Visible = false;
        }

        private void addCategoryReturn_Focus(object sender, EventArgs e)
        {
            addCategory_return.Visible = false;
        }

        private void addAuthorReturn_Focus(object sender, EventArgs e)
        {
            addAuthor_return.Visible = false;
        }
    }
}
