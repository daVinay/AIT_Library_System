namespace AITLibrary
{
    partial class BookReservedBorrowed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookReservedBorrowed));
            this.mainForm_panel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.returnImage = new System.Windows.Forms.PictureBox();
            this.returnBookBorrowedSelected = new System.Windows.Forms.Button();
            this.deleteBookReservedSelected = new System.Windows.Forms.Button();
            this.adminSup_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.isbn_txtbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelectUser = new System.Windows.Forms.Button();
            this.userID_label = new System.Windows.Forms.Label();
            this.userId_txtBox = new System.Windows.Forms.TextBox();
            this.listBookReserved = new System.Windows.Forms.GroupBox();
            this.bookReserved_dataGridView = new System.Windows.Forms.DataGridView();
            this.listBookBorrowed = new System.Windows.Forms.GroupBox();
            this.bookBorrowed_dataGridView = new System.Windows.Forms.DataGridView();
            this.mainForm_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnImage)).BeginInit();
            this.adminSup_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.listBookReserved.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookReserved_dataGridView)).BeginInit();
            this.listBookBorrowed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBorrowed_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainForm_panel
            // 
            this.mainForm_panel.Controls.Add(this.pictureBox3);
            this.mainForm_panel.Controls.Add(this.returnImage);
            this.mainForm_panel.Controls.Add(this.returnBookBorrowedSelected);
            this.mainForm_panel.Controls.Add(this.deleteBookReservedSelected);
            this.mainForm_panel.Controls.Add(this.adminSup_panel);
            this.mainForm_panel.Controls.Add(this.listBookReserved);
            this.mainForm_panel.Controls.Add(this.listBookBorrowed);
            this.mainForm_panel.Location = new System.Drawing.Point(12, 43);
            this.mainForm_panel.Name = "mainForm_panel";
            this.mainForm_panel.Size = new System.Drawing.Size(832, 530);
            this.mainForm_panel.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::AITLibrary.Properties.Resources.delete_icon;
            this.pictureBox3.Location = new System.Drawing.Point(18, 509);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // returnImage
            // 
            this.returnImage.BackColor = System.Drawing.Color.Transparent;
            this.returnImage.Image = global::AITLibrary.Properties.Resources._return;
            this.returnImage.Location = new System.Drawing.Point(19, 255);
            this.returnImage.Name = "returnImage";
            this.returnImage.Size = new System.Drawing.Size(20, 15);
            this.returnImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.returnImage.TabIndex = 3;
            this.returnImage.TabStop = false;
            // 
            // returnBookBorrowedSelected
            // 
            this.returnBookBorrowedSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBookBorrowedSelected.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBookBorrowedSelected.Location = new System.Drawing.Point(9, 250);
            this.returnBookBorrowedSelected.Name = "returnBookBorrowedSelected";
            this.returnBookBorrowedSelected.Size = new System.Drawing.Size(249, 23);
            this.returnBookBorrowedSelected.TabIndex = 2;
            this.returnBookBorrowedSelected.Text = "Return book selected from the list   ";
            this.returnBookBorrowedSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.returnBookBorrowedSelected.UseVisualStyleBackColor = true;
            this.returnBookBorrowedSelected.Click += new System.EventHandler(this.returnBookBorrowedSelected_Click);
            // 
            // deleteBookReservedSelected
            // 
            this.deleteBookReservedSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBookReservedSelected.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBookReservedSelected.Location = new System.Drawing.Point(9, 504);
            this.deleteBookReservedSelected.Name = "deleteBookReservedSelected";
            this.deleteBookReservedSelected.Size = new System.Drawing.Size(249, 23);
            this.deleteBookReservedSelected.TabIndex = 1;
            this.deleteBookReservedSelected.Text = "Remove book selected from the list";
            this.deleteBookReservedSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBookReservedSelected.UseVisualStyleBackColor = true;
            this.deleteBookReservedSelected.Click += new System.EventHandler(this.deleteBookReservedSelected_Click);
            // 
            // adminSup_panel
            // 
            this.adminSup_panel.Controls.Add(this.label1);
            this.adminSup_panel.Controls.Add(this.button1);
            this.adminSup_panel.Controls.Add(this.isbn_txtbox);
            this.adminSup_panel.Controls.Add(this.pictureBox1);
            this.adminSup_panel.Controls.Add(this.btnSelectUser);
            this.adminSup_panel.Controls.Add(this.userID_label);
            this.adminSup_panel.Controls.Add(this.userId_txtBox);
            this.adminSup_panel.Location = new System.Drawing.Point(3, 6);
            this.adminSup_panel.Name = "adminSup_panel";
            this.adminSup_panel.Size = new System.Drawing.Size(826, 29);
            this.adminSup_panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(491, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select an ISBN:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Location = new System.Drawing.Point(768, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnIsbn_Click);
            // 
            // isbn_txtbox
            // 
            this.isbn_txtbox.Location = new System.Drawing.Point(600, 6);
            this.isbn_txtbox.Name = "isbn_txtbox";
            this.isbn_txtbox.Size = new System.Drawing.Size(162, 20);
            this.isbn_txtbox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnSelectUser
            // 
            this.btnSelectUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectUser.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSelectUser.Location = new System.Drawing.Point(226, 4);
            this.btnSelectUser.Name = "btnSelectUser";
            this.btnSelectUser.Size = new System.Drawing.Size(52, 23);
            this.btnSelectUser.TabIndex = 4;
            this.btnSelectUser.Text = "select";
            this.btnSelectUser.UseVisualStyleBackColor = true;
            this.btnSelectUser.Click += new System.EventHandler(this.btnSelectUser_Click);
            // 
            // userID_label
            // 
            this.userID_label.AutoSize = true;
            this.userID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userID_label.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.userID_label.Location = new System.Drawing.Point(44, 6);
            this.userID_label.Name = "userID_label";
            this.userID_label.Size = new System.Drawing.Size(103, 17);
            this.userID_label.TabIndex = 3;
            this.userID_label.Text = "Select an user:";
            // 
            // userId_txtBox
            // 
            this.userId_txtBox.Location = new System.Drawing.Point(153, 6);
            this.userId_txtBox.Name = "userId_txtBox";
            this.userId_txtBox.Size = new System.Drawing.Size(67, 20);
            this.userId_txtBox.TabIndex = 2;
            // 
            // listBookReserved
            // 
            this.listBookReserved.Controls.Add(this.bookReserved_dataGridView);
            this.listBookReserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBookReserved.Location = new System.Drawing.Point(3, 289);
            this.listBookReserved.Name = "listBookReserved";
            this.listBookReserved.Size = new System.Drawing.Size(826, 212);
            this.listBookReserved.TabIndex = 1;
            this.listBookReserved.TabStop = false;
            this.listBookReserved.Text = "List of books reserved";
            // 
            // bookReserved_dataGridView
            // 
            this.bookReserved_dataGridView.AllowUserToAddRows = false;
            this.bookReserved_dataGridView.AllowUserToDeleteRows = false;
            this.bookReserved_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookReserved_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.bookReserved_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookReserved_dataGridView.Location = new System.Drawing.Point(6, 22);
            this.bookReserved_dataGridView.Name = "bookReserved_dataGridView";
            this.bookReserved_dataGridView.ReadOnly = true;
            this.bookReserved_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookReserved_dataGridView.Size = new System.Drawing.Size(814, 184);
            this.bookReserved_dataGridView.TabIndex = 1;
            // 
            // listBookBorrowed
            // 
            this.listBookBorrowed.Controls.Add(this.bookBorrowed_dataGridView);
            this.listBookBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBookBorrowed.Location = new System.Drawing.Point(3, 38);
            this.listBookBorrowed.Name = "listBookBorrowed";
            this.listBookBorrowed.Size = new System.Drawing.Size(826, 212);
            this.listBookBorrowed.TabIndex = 0;
            this.listBookBorrowed.TabStop = false;
            this.listBookBorrowed.Text = "List of books borrowed";
            // 
            // bookBorrowed_dataGridView
            // 
            this.bookBorrowed_dataGridView.AllowUserToAddRows = false;
            this.bookBorrowed_dataGridView.AllowUserToDeleteRows = false;
            this.bookBorrowed_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookBorrowed_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.bookBorrowed_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookBorrowed_dataGridView.Location = new System.Drawing.Point(6, 22);
            this.bookBorrowed_dataGridView.Name = "bookBorrowed_dataGridView";
            this.bookBorrowed_dataGridView.ReadOnly = true;
            this.bookBorrowed_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookBorrowed_dataGridView.Size = new System.Drawing.Size(814, 184);
            this.bookBorrowed_dataGridView.TabIndex = 0;
            // 
            // BookReservedBorrowed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 579);
            this.Controls.Add(this.mainForm_panel);
            this.Name = "BookReservedBorrowed";
            this.Text = "AIT Library System";
            this.Load += new System.EventHandler(this.BookReservedBorrowed_load);
            this.mainForm_panel.ResumeLayout(false);
            this.mainForm_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnImage)).EndInit();
            this.adminSup_panel.ResumeLayout(false);
            this.adminSup_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.listBookReserved.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookReserved_dataGridView)).EndInit();
            this.listBookBorrowed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookBorrowed_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainForm_panel;
        private System.Windows.Forms.Panel adminSup_panel;
        private System.Windows.Forms.Button btnSelectUser;
        private System.Windows.Forms.Label userID_label;
        private System.Windows.Forms.TextBox userId_txtBox;
        private System.Windows.Forms.GroupBox listBookReserved;
        private System.Windows.Forms.DataGridView bookReserved_dataGridView;
        private System.Windows.Forms.GroupBox listBookBorrowed;
        private System.Windows.Forms.DataGridView bookBorrowed_dataGridView;
        private System.Windows.Forms.Button deleteBookReservedSelected;
        private System.Windows.Forms.Button returnBookBorrowedSelected;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox returnImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox isbn_txtbox;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}