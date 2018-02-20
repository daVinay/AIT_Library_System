namespace AITLibrary
{
    partial class AddBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.Isbn_txtBox = new System.Windows.Forms.TextBox();
            this.BookName_txtBox = new System.Windows.Forms.TextBox();
            this.Publisher_txtBox = new System.Windows.Forms.TextBox();
            this.PublisherYear_txtBox = new System.Windows.Forms.TextBox();
            this.Author_List = new System.Windows.Forms.ComboBox();
            this.Category_List = new System.Windows.Forms.ComboBox();
            this.Language_List = new System.Windows.Forms.ComboBox();
            this.Pages_txtBox = new System.Windows.Forms.TextBox();
            this.isbn_label = new System.Windows.Forms.Label();
            this.bookName_label = new System.Windows.Forms.Label();
            this.publisher_label = new System.Windows.Forms.Label();
            this.publisherYear_label = new System.Windows.Forms.Label();
            this.author_label = new System.Windows.Forms.Label();
            this.category_label = new System.Windows.Forms.Label();
            this.language_label = new System.Windows.Forms.Label();
            this.pages_label = new System.Windows.Forms.Label();
            this.AddNewAuthor_group = new System.Windows.Forms.GroupBox();
            this.addAuthor_return = new System.Windows.Forms.Label();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.authorName_add = new System.Windows.Forms.TextBox();
            this.AddNewCategory_group = new System.Windows.Forms.GroupBox();
            this.addCategory_return = new System.Windows.Forms.Label();
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            this.category_add = new System.Windows.Forms.TextBox();
            this.book_group = new System.Windows.Forms.GroupBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddNewLanguage_group = new System.Windows.Forms.GroupBox();
            this.addLanguage_return = new System.Windows.Forms.Label();
            this.btnAddNewLanguage = new System.Windows.Forms.Button();
            this.language_add = new System.Windows.Forms.TextBox();
            this.addBook_panel = new System.Windows.Forms.Panel();
            this.AddNewAuthor_group.SuspendLayout();
            this.AddNewCategory_group.SuspendLayout();
            this.book_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.AddNewLanguage_group.SuspendLayout();
            this.addBook_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Isbn_txtBox
            // 
            this.Isbn_txtBox.Location = new System.Drawing.Point(254, 37);
            this.Isbn_txtBox.Name = "Isbn_txtBox";
            this.Isbn_txtBox.Size = new System.Drawing.Size(168, 23);
            this.Isbn_txtBox.TabIndex = 0;
            this.Isbn_txtBox.Enter += new System.EventHandler(this.RemoveISBNLabel);
            // 
            // BookName_txtBox
            // 
            this.BookName_txtBox.Location = new System.Drawing.Point(254, 77);
            this.BookName_txtBox.Name = "BookName_txtBox";
            this.BookName_txtBox.Size = new System.Drawing.Size(168, 23);
            this.BookName_txtBox.TabIndex = 1;
            this.BookName_txtBox.Enter += new System.EventHandler(this.RemoveBookNameLabel);
            // 
            // Publisher_txtBox
            // 
            this.Publisher_txtBox.Location = new System.Drawing.Point(254, 117);
            this.Publisher_txtBox.Name = "Publisher_txtBox";
            this.Publisher_txtBox.Size = new System.Drawing.Size(168, 23);
            this.Publisher_txtBox.TabIndex = 2;
            this.Publisher_txtBox.Enter += new System.EventHandler(this.RemovePublisherLabel);
            // 
            // PublisherYear_txtBox
            // 
            this.PublisherYear_txtBox.Location = new System.Drawing.Point(254, 157);
            this.PublisherYear_txtBox.Name = "PublisherYear_txtBox";
            this.PublisherYear_txtBox.Size = new System.Drawing.Size(168, 23);
            this.PublisherYear_txtBox.TabIndex = 3;
            this.PublisherYear_txtBox.Enter += new System.EventHandler(this.removePublisherYearLabel);
            // 
            // Author_List
            // 
            this.Author_List.FormattingEnabled = true;
            this.Author_List.Location = new System.Drawing.Point(618, 35);
            this.Author_List.Name = "Author_List";
            this.Author_List.Size = new System.Drawing.Size(168, 25);
            this.Author_List.TabIndex = 4;
            // 
            // Category_List
            // 
            this.Category_List.FormattingEnabled = true;
            this.Category_List.Location = new System.Drawing.Point(618, 77);
            this.Category_List.Name = "Category_List";
            this.Category_List.Size = new System.Drawing.Size(168, 25);
            this.Category_List.TabIndex = 5;
            // 
            // Language_List
            // 
            this.Language_List.FormattingEnabled = true;
            this.Language_List.Location = new System.Drawing.Point(618, 117);
            this.Language_List.Name = "Language_List";
            this.Language_List.Size = new System.Drawing.Size(168, 25);
            this.Language_List.TabIndex = 6;
            // 
            // Pages_txtBox
            // 
            this.Pages_txtBox.Location = new System.Drawing.Point(618, 154);
            this.Pages_txtBox.Name = "Pages_txtBox";
            this.Pages_txtBox.Size = new System.Drawing.Size(168, 23);
            this.Pages_txtBox.TabIndex = 7;
            this.Pages_txtBox.Enter += new System.EventHandler(this.RemovePagesLabel);
            // 
            // isbn_label
            // 
            this.isbn_label.AutoSize = true;
            this.isbn_label.Location = new System.Drawing.Point(205, 38);
            this.isbn_label.Name = "isbn_label";
            this.isbn_label.Size = new System.Drawing.Size(43, 17);
            this.isbn_label.TabIndex = 8;
            this.isbn_label.Text = "*Isbn:";
            // 
            // bookName_label
            // 
            this.bookName_label.AutoSize = true;
            this.bookName_label.Location = new System.Drawing.Point(158, 80);
            this.bookName_label.Name = "bookName_label";
            this.bookName_label.Size = new System.Drawing.Size(90, 17);
            this.bookName_label.TabIndex = 9;
            this.bookName_label.Text = "*Book Name:";
            // 
            // publisher_label
            // 
            this.publisher_label.AutoSize = true;
            this.publisher_label.Location = new System.Drawing.Point(172, 120);
            this.publisher_label.Name = "publisher_label";
            this.publisher_label.Size = new System.Drawing.Size(76, 17);
            this.publisher_label.TabIndex = 10;
            this.publisher_label.Text = "*Publisher:";
            // 
            // publisherYear_label
            // 
            this.publisherYear_label.AutoSize = true;
            this.publisherYear_label.Location = new System.Drawing.Point(138, 157);
            this.publisherYear_label.Name = "publisherYear_label";
            this.publisherYear_label.Size = new System.Drawing.Size(110, 17);
            this.publisherYear_label.TabIndex = 11;
            this.publisherYear_label.Text = "*Publisher Year:";
            // 
            // author_label
            // 
            this.author_label.AutoSize = true;
            this.author_label.Location = new System.Drawing.Point(550, 40);
            this.author_label.Name = "author_label";
            this.author_label.Size = new System.Drawing.Size(59, 17);
            this.author_label.TabIndex = 12;
            this.author_label.Text = "*Author:";
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Location = new System.Drawing.Point(535, 80);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(74, 17);
            this.category_label.TabIndex = 13;
            this.category_label.Text = "*Category:";
            // 
            // language_label
            // 
            this.language_label.AutoSize = true;
            this.language_label.Location = new System.Drawing.Point(528, 120);
            this.language_label.Name = "language_label";
            this.language_label.Size = new System.Drawing.Size(81, 17);
            this.language_label.TabIndex = 14;
            this.language_label.Text = "*Language:";
            // 
            // pages_label
            // 
            this.pages_label.AutoSize = true;
            this.pages_label.Location = new System.Drawing.Point(552, 157);
            this.pages_label.Name = "pages_label";
            this.pages_label.Size = new System.Drawing.Size(57, 17);
            this.pages_label.TabIndex = 15;
            this.pages_label.Text = "*Pages:";
            // 
            // AddNewAuthor_group
            // 
            this.AddNewAuthor_group.Controls.Add(this.addAuthor_return);
            this.AddNewAuthor_group.Controls.Add(this.btnAddAuthor);
            this.AddNewAuthor_group.Controls.Add(this.authorName_add);
            this.AddNewAuthor_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewAuthor_group.Location = new System.Drawing.Point(3, 262);
            this.AddNewAuthor_group.Name = "AddNewAuthor_group";
            this.AddNewAuthor_group.Size = new System.Drawing.Size(248, 64);
            this.AddNewAuthor_group.TabIndex = 16;
            this.AddNewAuthor_group.TabStop = false;
            this.AddNewAuthor_group.Text = "Add a new Author";
            // 
            // addAuthor_return
            // 
            this.addAuthor_return.AutoSize = true;
            this.addAuthor_return.ForeColor = System.Drawing.Color.DarkRed;
            this.addAuthor_return.Location = new System.Drawing.Point(10, 43);
            this.addAuthor_return.Name = "addAuthor_return";
            this.addAuthor_return.Size = new System.Drawing.Size(46, 17);
            this.addAuthor_return.TabIndex = 18;
            this.addAuthor_return.Text = "return";
            this.addAuthor_return.Visible = false;
            this.addAuthor_return.Enter += new System.EventHandler(this.addAuthorReturn_Focus);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.Location = new System.Drawing.Point(185, 18);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(57, 23);
            this.btnAddAuthor.TabIndex = 17;
            this.btnAddAuthor.Text = "Add";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // authorName_add
            // 
            this.authorName_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorName_add.Location = new System.Drawing.Point(10, 20);
            this.authorName_add.Name = "authorName_add";
            this.authorName_add.Size = new System.Drawing.Size(168, 20);
            this.authorName_add.TabIndex = 17;
            this.authorName_add.Enter += new System.EventHandler(this.addAuthorReturn_Focus);
            // 
            // AddNewCategory_group
            // 
            this.AddNewCategory_group.Controls.Add(this.addCategory_return);
            this.AddNewCategory_group.Controls.Add(this.btnAddNewCategory);
            this.AddNewCategory_group.Controls.Add(this.category_add);
            this.AddNewCategory_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewCategory_group.Location = new System.Drawing.Point(285, 262);
            this.AddNewCategory_group.Name = "AddNewCategory_group";
            this.AddNewCategory_group.Size = new System.Drawing.Size(248, 64);
            this.AddNewCategory_group.TabIndex = 18;
            this.AddNewCategory_group.TabStop = false;
            this.AddNewCategory_group.Text = "Add a new Category";
            // 
            // addCategory_return
            // 
            this.addCategory_return.AutoSize = true;
            this.addCategory_return.ForeColor = System.Drawing.Color.DarkRed;
            this.addCategory_return.Location = new System.Drawing.Point(7, 43);
            this.addCategory_return.Name = "addCategory_return";
            this.addCategory_return.Size = new System.Drawing.Size(46, 17);
            this.addCategory_return.TabIndex = 19;
            this.addCategory_return.Text = "return";
            this.addCategory_return.Visible = false;
            this.addCategory_return.Enter += new System.EventHandler(this.addCategoryReturn_Focus);
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCategory.Location = new System.Drawing.Point(185, 18);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(57, 23);
            this.btnAddNewCategory.TabIndex = 17;
            this.btnAddNewCategory.Text = "Add";
            this.btnAddNewCategory.UseVisualStyleBackColor = true;
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // category_add
            // 
            this.category_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_add.Location = new System.Drawing.Point(10, 20);
            this.category_add.Name = "category_add";
            this.category_add.Size = new System.Drawing.Size(168, 20);
            this.category_add.TabIndex = 17;
            this.category_add.Enter += new System.EventHandler(this.addCategoryReturn_Focus);
            // 
            // book_group
            // 
            this.book_group.Controls.Add(this.btnAddBook);
            this.book_group.Controls.Add(this.pictureBox1);
            this.book_group.Controls.Add(this.label2);
            this.book_group.Controls.Add(this.author_label);
            this.book_group.Controls.Add(this.Isbn_txtBox);
            this.book_group.Controls.Add(this.Language_List);
            this.book_group.Controls.Add(this.BookName_txtBox);
            this.book_group.Controls.Add(this.publisherYear_label);
            this.book_group.Controls.Add(this.Publisher_txtBox);
            this.book_group.Controls.Add(this.Category_List);
            this.book_group.Controls.Add(this.Pages_txtBox);
            this.book_group.Controls.Add(this.pages_label);
            this.book_group.Controls.Add(this.category_label);
            this.book_group.Controls.Add(this.publisher_label);
            this.book_group.Controls.Add(this.PublisherYear_txtBox);
            this.book_group.Controls.Add(this.Author_List);
            this.book_group.Controls.Add(this.bookName_label);
            this.book_group.Controls.Add(this.isbn_label);
            this.book_group.Controls.Add(this.language_label);
            this.book_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_group.Location = new System.Drawing.Point(3, 3);
            this.book_group.Name = "book_group";
            this.book_group.Size = new System.Drawing.Size(818, 221);
            this.book_group.TabIndex = 19;
            this.book_group.TabStop = false;
            this.book_group.Text = "Add a New Book";
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.White;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Location = new System.Drawing.Point(668, 189);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(118, 23);
            this.btnAddBook.TabIndex = 20;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "* All field required";
            // 
            // AddNewLanguage_group
            // 
            this.AddNewLanguage_group.Controls.Add(this.addLanguage_return);
            this.AddNewLanguage_group.Controls.Add(this.btnAddNewLanguage);
            this.AddNewLanguage_group.Controls.Add(this.language_add);
            this.AddNewLanguage_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewLanguage_group.Location = new System.Drawing.Point(573, 262);
            this.AddNewLanguage_group.Name = "AddNewLanguage_group";
            this.AddNewLanguage_group.Size = new System.Drawing.Size(248, 64);
            this.AddNewLanguage_group.TabIndex = 19;
            this.AddNewLanguage_group.TabStop = false;
            this.AddNewLanguage_group.Text = "Add a new Language";
            // 
            // addLanguage_return
            // 
            this.addLanguage_return.AutoSize = true;
            this.addLanguage_return.ForeColor = System.Drawing.Color.DarkRed;
            this.addLanguage_return.Location = new System.Drawing.Point(7, 43);
            this.addLanguage_return.Name = "addLanguage_return";
            this.addLanguage_return.Size = new System.Drawing.Size(46, 17);
            this.addLanguage_return.TabIndex = 20;
            this.addLanguage_return.Text = "return";
            this.addLanguage_return.Visible = false;
            // 
            // btnAddNewLanguage
            // 
            this.btnAddNewLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewLanguage.Location = new System.Drawing.Point(185, 18);
            this.btnAddNewLanguage.Name = "btnAddNewLanguage";
            this.btnAddNewLanguage.Size = new System.Drawing.Size(57, 23);
            this.btnAddNewLanguage.TabIndex = 17;
            this.btnAddNewLanguage.Text = "Add";
            this.btnAddNewLanguage.UseVisualStyleBackColor = true;
            this.btnAddNewLanguage.Click += new System.EventHandler(this.btnAddLanguage_Click);
            // 
            // language_add
            // 
            this.language_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.language_add.Location = new System.Drawing.Point(10, 20);
            this.language_add.Name = "language_add";
            this.language_add.Size = new System.Drawing.Size(168, 20);
            this.language_add.TabIndex = 17;
            this.language_add.Enter += new System.EventHandler(this.addLanguage_Focus);
            // 
            // addBook_panel
            // 
            this.addBook_panel.BackColor = System.Drawing.Color.Transparent;
            this.addBook_panel.Controls.Add(this.book_group);
            this.addBook_panel.Controls.Add(this.AddNewLanguage_group);
            this.addBook_panel.Controls.Add(this.AddNewAuthor_group);
            this.addBook_panel.Controls.Add(this.AddNewCategory_group);
            this.addBook_panel.Location = new System.Drawing.Point(12, 71);
            this.addBook_panel.Name = "addBook_panel";
            this.addBook_panel.Size = new System.Drawing.Size(824, 342);
            this.addBook_panel.TabIndex = 20;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1127, 579);
            this.Controls.Add(this.addBook_panel);
            this.Name = "AddBook";
            this.Text = "AIT Library System";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.AddNewAuthor_group.ResumeLayout(false);
            this.AddNewAuthor_group.PerformLayout();
            this.AddNewCategory_group.ResumeLayout(false);
            this.AddNewCategory_group.PerformLayout();
            this.book_group.ResumeLayout(false);
            this.book_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.AddNewLanguage_group.ResumeLayout(false);
            this.AddNewLanguage_group.PerformLayout();
            this.addBook_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Isbn_txtBox;
        private System.Windows.Forms.TextBox BookName_txtBox;
        private System.Windows.Forms.TextBox Publisher_txtBox;
        private System.Windows.Forms.TextBox PublisherYear_txtBox;
        private System.Windows.Forms.ComboBox Author_List;
        private System.Windows.Forms.ComboBox Category_List;
        private System.Windows.Forms.ComboBox Language_List;
        private System.Windows.Forms.TextBox Pages_txtBox;
        private System.Windows.Forms.Label isbn_label;
        private System.Windows.Forms.Label bookName_label;
        private System.Windows.Forms.Label publisher_label;
        private System.Windows.Forms.Label publisherYear_label;
        private System.Windows.Forms.Label author_label;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Label language_label;
        private System.Windows.Forms.Label pages_label;
        private System.Windows.Forms.GroupBox AddNewAuthor_group;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.TextBox authorName_add;
        private System.Windows.Forms.GroupBox AddNewCategory_group;
        private System.Windows.Forms.Button btnAddNewCategory;
        private System.Windows.Forms.TextBox category_add;
        private System.Windows.Forms.GroupBox book_group;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox AddNewLanguage_group;
        private System.Windows.Forms.Button btnAddNewLanguage;
        private System.Windows.Forms.TextBox language_add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Panel addBook_panel;
        private System.Windows.Forms.Label addAuthor_return;
        private System.Windows.Forms.Label addCategory_return;
        private System.Windows.Forms.Label addLanguage_return;
    }
}