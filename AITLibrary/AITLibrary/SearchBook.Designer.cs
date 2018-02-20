namespace AITLibrary
{
    partial class SearchBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bookName_label = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.TextBox();
            this.AuthorByList = new System.Windows.Forms.Label();
            this.authorList = new System.Windows.Forms.ComboBox();
            this.catList = new System.Windows.Forms.ComboBox();
            this.authorValue = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.catLabel = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.bookAvailable_checkBox = new System.Windows.Forms.CheckBox();
            this.panelSearch = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteSelectedBook = new System.Windows.Forms.Button();
            this.DeleteEdit_panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSearch.SuspendLayout();
            this.DeleteEdit_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookName_label
            // 
            this.bookName_label.AutoSize = true;
            this.bookName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookName_label.ForeColor = System.Drawing.Color.DimGray;
            this.bookName_label.Location = new System.Drawing.Point(24, 25);
            this.bookName_label.Name = "bookName_label";
            this.bookName_label.Size = new System.Drawing.Size(83, 16);
            this.bookName_label.TabIndex = 24;
            this.bookName_label.Text = "Book Name:";
            // 
            // bookName
            // 
            this.bookName.Location = new System.Drawing.Point(113, 22);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(193, 23);
            this.bookName.TabIndex = 23;
            // 
            // AuthorByList
            // 
            this.AuthorByList.AutoSize = true;
            this.AuthorByList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorByList.ForeColor = System.Drawing.Color.DimGray;
            this.AuthorByList.Location = new System.Drawing.Point(358, 54);
            this.AuthorByList.Name = "AuthorByList";
            this.AuthorByList.Size = new System.Drawing.Size(90, 16);
            this.AuthorByList.TabIndex = 23;
            this.AuthorByList.Text = "Author by List:";
            // 
            // authorList
            // 
            this.authorList.FormattingEnabled = true;
            this.authorList.Location = new System.Drawing.Point(453, 51);
            this.authorList.Name = "authorList";
            this.authorList.Size = new System.Drawing.Size(121, 25);
            this.authorList.TabIndex = 22;
            // 
            // catList
            // 
            this.catList.FormattingEnabled = true;
            this.catList.Location = new System.Drawing.Point(113, 47);
            this.catList.Name = "catList";
            this.catList.Size = new System.Drawing.Size(193, 25);
            this.catList.TabIndex = 8;
            // 
            // authorValue
            // 
            this.authorValue.BackColor = System.Drawing.Color.White;
            this.authorValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.authorValue.Location = new System.Drawing.Point(453, 22);
            this.authorValue.Name = "authorValue";
            this.authorValue.Size = new System.Drawing.Size(121, 23);
            this.authorValue.TabIndex = 5;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.ForeColor = System.Drawing.Color.DimGray;
            this.authorLabel.Location = new System.Drawing.Point(399, 25);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(49, 16);
            this.authorLabel.TabIndex = 6;
            this.authorLabel.Text = "Author:";
            // 
            // catLabel
            // 
            this.catLabel.AutoSize = true;
            this.catLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catLabel.ForeColor = System.Drawing.Color.DimGray;
            this.catLabel.Location = new System.Drawing.Point(39, 51);
            this.catLabel.Name = "catLabel";
            this.catLabel.Size = new System.Drawing.Size(66, 16);
            this.catLabel.TabIndex = 9;
            this.catLabel.Text = "Category:";
            // 
            // searchBtn
            // 
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(527, 85);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchByAuthor_Click);
            // 
            // bookAvailable_checkBox
            // 
            this.bookAvailable_checkBox.AutoSize = true;
            this.bookAvailable_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookAvailable_checkBox.ForeColor = System.Drawing.Color.Maroon;
            this.bookAvailable_checkBox.Location = new System.Drawing.Point(27, 78);
            this.bookAvailable_checkBox.Name = "bookAvailable_checkBox";
            this.bookAvailable_checkBox.Size = new System.Drawing.Size(151, 21);
            this.bookAvailable_checkBox.TabIndex = 23;
            this.bookAvailable_checkBox.Text = "Only book available";
            this.bookAvailable_checkBox.UseVisualStyleBackColor = true;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.bookName_label);
            this.panelSearch.Controls.Add(this.bookAvailable_checkBox);
            this.panelSearch.Controls.Add(this.bookName);
            this.panelSearch.Controls.Add(this.AuthorByList);
            this.panelSearch.Controls.Add(this.searchBtn);
            this.panelSearch.Controls.Add(this.authorList);
            this.panelSearch.Controls.Add(this.catLabel);
            this.panelSearch.Controls.Add(this.catList);
            this.panelSearch.Controls.Add(this.authorLabel);
            this.panelSearch.Controls.Add(this.authorValue);
            this.panelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSearch.Location = new System.Drawing.Point(12, 447);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(608, 111);
            this.panelSearch.TabIndex = 24;
            this.panelSearch.TabStop = false;
            this.panelSearch.Text = "Search for a book";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(194, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Edit selected book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnUpdateSelectedBook_Click);
            // 
            // btnDeleteSelectedBook
            // 
            this.btnDeleteSelectedBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelectedBook.Location = new System.Drawing.Point(3, 5);
            this.btnDeleteSelectedBook.Name = "btnDeleteSelectedBook";
            this.btnDeleteSelectedBook.Size = new System.Drawing.Size(157, 23);
            this.btnDeleteSelectedBook.TabIndex = 26;
            this.btnDeleteSelectedBook.Text = "Delete selected book";
            this.btnDeleteSelectedBook.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedBook.Click += new System.EventHandler(this.btnDeleteSelectedBook_Click);
            // 
            // DeleteEdit_panel
            // 
            this.DeleteEdit_panel.Controls.Add(this.pictureBox2);
            this.DeleteEdit_panel.Controls.Add(this.pictureBox1);
            this.DeleteEdit_panel.Controls.Add(this.button1);
            this.DeleteEdit_panel.Controls.Add(this.btnDeleteSelectedBook);
            this.DeleteEdit_panel.Location = new System.Drawing.Point(12, 410);
            this.DeleteEdit_panel.Name = "DeleteEdit_panel";
            this.DeleteEdit_panel.Size = new System.Drawing.Size(353, 31);
            this.DeleteEdit_panel.TabIndex = 27;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::AITLibrary.Properties.Resources.edit_icon_net;
            this.pictureBox2.Location = new System.Drawing.Point(200, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AITLibrary.Properties.Resources.trash_icon_net;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // SearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 579);
            this.Controls.Add(this.DeleteEdit_panel);
            this.Controls.Add(this.panelSearch);
            this.Name = "SearchBook";
            this.Text = "AIT Library System";
            this.Load += new System.EventHandler(this.SearchBook_load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.DeleteEdit_panel.ResumeLayout(false);
            this.DeleteEdit_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AuthorByList;
        private System.Windows.Forms.ComboBox authorList;
        private System.Windows.Forms.ComboBox catList;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox authorValue;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label catLabel;
        private System.Windows.Forms.Label bookName_label;
        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.CheckBox bookAvailable_checkBox;
        private System.Windows.Forms.GroupBox panelSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDeleteSelectedBook;
        private System.Windows.Forms.Panel DeleteEdit_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
