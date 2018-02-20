namespace AITLibrary
{
    partial class ReserveBorrowBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bookName_label = new System.Windows.Forms.Label();
            this.AuthorByList = new System.Windows.Forms.Label();
            this.catList = new System.Windows.Forms.ComboBox();
            this.catLabel = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.TextBox();
            this.authorList = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.authorValue = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.btnBorrowBookSelected = new System.Windows.Forms.Button();
            this.searchForBook_panel = new System.Windows.Forms.GroupBox();
            this.bookAvailable_checkBox = new System.Windows.Forms.CheckBox();
            this.btnReserveBookSelected = new System.Windows.Forms.Button();
            this.showBooks_dataGridView = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.userID_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userID_panel = new System.Windows.Forms.Panel();
            this.searchForBook_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showBooks_dataGridView)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.userID_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookName_label
            // 
            this.bookName_label.AutoSize = true;
            this.bookName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookName_label.ForeColor = System.Drawing.Color.DimGray;
            this.bookName_label.Location = new System.Drawing.Point(24, 33);
            this.bookName_label.Name = "bookName_label";
            this.bookName_label.Size = new System.Drawing.Size(83, 16);
            this.bookName_label.TabIndex = 26;
            this.bookName_label.Text = "Book Name:";
            // 
            // AuthorByList
            // 
            this.AuthorByList.AutoSize = true;
            this.AuthorByList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorByList.ForeColor = System.Drawing.Color.DimGray;
            this.AuthorByList.Location = new System.Drawing.Point(364, 58);
            this.AuthorByList.Name = "AuthorByList";
            this.AuthorByList.Size = new System.Drawing.Size(90, 16);
            this.AuthorByList.TabIndex = 23;
            this.AuthorByList.Text = "Author by List:";
            // 
            // catList
            // 
            this.catList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catList.FormattingEnabled = true;
            this.catList.Location = new System.Drawing.Point(113, 58);
            this.catList.Name = "catList";
            this.catList.Size = new System.Drawing.Size(193, 21);
            this.catList.TabIndex = 8;
            // 
            // catLabel
            // 
            this.catLabel.AutoSize = true;
            this.catLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catLabel.ForeColor = System.Drawing.Color.DimGray;
            this.catLabel.Location = new System.Drawing.Point(41, 59);
            this.catLabel.Name = "catLabel";
            this.catLabel.Size = new System.Drawing.Size(66, 16);
            this.catLabel.TabIndex = 9;
            this.catLabel.Text = "Category:";
            // 
            // bookName
            // 
            this.bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookName.Location = new System.Drawing.Point(113, 32);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(193, 20);
            this.bookName.TabIndex = 25;
            // 
            // authorList
            // 
            this.authorList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorList.FormattingEnabled = true;
            this.authorList.Location = new System.Drawing.Point(460, 58);
            this.authorList.Name = "authorList";
            this.authorList.Size = new System.Drawing.Size(162, 21);
            this.authorList.TabIndex = 22;
            // 
            // searchBtn
            // 
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(641, 56);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchByAuthor_Click);
            // 
            // authorValue
            // 
            this.authorValue.BackColor = System.Drawing.Color.White;
            this.authorValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.authorValue.Location = new System.Drawing.Point(460, 29);
            this.authorValue.Name = "authorValue";
            this.authorValue.Size = new System.Drawing.Size(162, 20);
            this.authorValue.TabIndex = 5;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.ForeColor = System.Drawing.Color.DimGray;
            this.authorLabel.Location = new System.Drawing.Point(405, 32);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(49, 16);
            this.authorLabel.TabIndex = 6;
            this.authorLabel.Text = "Author:";
            // 
            // btnBorrowBookSelected
            // 
            this.btnBorrowBookSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowBookSelected.Location = new System.Drawing.Point(6, 16);
            this.btnBorrowBookSelected.Name = "btnBorrowBookSelected";
            this.btnBorrowBookSelected.Size = new System.Drawing.Size(180, 23);
            this.btnBorrowBookSelected.TabIndex = 23;
            this.btnBorrowBookSelected.Text = "Borrow book selected";
            this.btnBorrowBookSelected.UseVisualStyleBackColor = true;
            this.btnBorrowBookSelected.Click += new System.EventHandler(this.btnBorrowBookSelected_click);
            // 
            // searchForBook_panel
            // 
            this.searchForBook_panel.Controls.Add(this.bookAvailable_checkBox);
            this.searchForBook_panel.Controls.Add(this.bookName_label);
            this.searchForBook_panel.Controls.Add(this.bookName);
            this.searchForBook_panel.Controls.Add(this.AuthorByList);
            this.searchForBook_panel.Controls.Add(this.authorLabel);
            this.searchForBook_panel.Controls.Add(this.catList);
            this.searchForBook_panel.Controls.Add(this.authorValue);
            this.searchForBook_panel.Controls.Add(this.catLabel);
            this.searchForBook_panel.Controls.Add(this.searchBtn);
            this.searchForBook_panel.Controls.Add(this.authorList);
            this.searchForBook_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchForBook_panel.Location = new System.Drawing.Point(6, 65);
            this.searchForBook_panel.Name = "searchForBook_panel";
            this.searchForBook_panel.Size = new System.Drawing.Size(722, 111);
            this.searchForBook_panel.TabIndex = 24;
            this.searchForBook_panel.TabStop = false;
            this.searchForBook_panel.Text = "Search for a book";
            // 
            // bookAvailable_checkBox
            // 
            this.bookAvailable_checkBox.AutoSize = true;
            this.bookAvailable_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookAvailable_checkBox.ForeColor = System.Drawing.Color.Maroon;
            this.bookAvailable_checkBox.Location = new System.Drawing.Point(565, 84);
            this.bookAvailable_checkBox.Name = "bookAvailable_checkBox";
            this.bookAvailable_checkBox.Size = new System.Drawing.Size(151, 21);
            this.bookAvailable_checkBox.TabIndex = 26;
            this.bookAvailable_checkBox.Text = "Only book available";
            this.bookAvailable_checkBox.UseVisualStyleBackColor = true;
            // 
            // btnReserveBookSelected
            // 
            this.btnReserveBookSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserveBookSelected.Location = new System.Drawing.Point(229, 16);
            this.btnReserveBookSelected.Name = "btnReserveBookSelected";
            this.btnReserveBookSelected.Size = new System.Drawing.Size(180, 23);
            this.btnReserveBookSelected.TabIndex = 25;
            this.btnReserveBookSelected.Text = "Reserve book selected";
            this.btnReserveBookSelected.UseVisualStyleBackColor = true;
            this.btnReserveBookSelected.Click += new System.EventHandler(this.btnReserveBookSelected_Click);
            // 
            // showBooks_dataGridView
            // 
            this.showBooks_dataGridView.AllowUserToAddRows = false;
            this.showBooks_dataGridView.AllowUserToDeleteRows = false;
            this.showBooks_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showBooks_dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showBooks_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.showBooks_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.showBooks_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.showBooks_dataGridView.Location = new System.Drawing.Point(12, 41);
            this.showBooks_dataGridView.Name = "showBooks_dataGridView";
            this.showBooks_dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showBooks_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.showBooks_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showBooks_dataGridView.ShowRowErrors = false;
            this.showBooks_dataGridView.Size = new System.Drawing.Size(852, 341);
            this.showBooks_dataGridView.TabIndex = 26;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.userID_panel);
            this.panelSearch.Controls.Add(this.searchForBook_panel);
            this.panelSearch.Controls.Add(this.btnReserveBookSelected);
            this.panelSearch.Controls.Add(this.btnBorrowBookSelected);
            this.panelSearch.Location = new System.Drawing.Point(12, 388);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(852, 179);
            this.panelSearch.TabIndex = 27;
            // 
            // userID_input
            // 
            this.userID_input.Location = new System.Drawing.Point(58, 3);
            this.userID_input.Name = "userID_input";
            this.userID_input.Size = new System.Drawing.Size(55, 20);
            this.userID_input.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "User ID:";
            // 
            // userID_panel
            // 
            this.userID_panel.Controls.Add(this.userID_input);
            this.userID_panel.Controls.Add(this.label1);
            this.userID_panel.Location = new System.Drawing.Point(612, 16);
            this.userID_panel.Name = "userID_panel";
            this.userID_panel.Size = new System.Drawing.Size(116, 29);
            this.userID_panel.TabIndex = 28;
            // 
            // ReserveBorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 579);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.showBooks_dataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReserveBorrowBook";
            this.Text = "AIT Library System";
            this.Load += new System.EventHandler(this.ReserveBorrowBook_load);
            this.searchForBook_panel.ResumeLayout(false);
            this.searchForBook_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showBooks_dataGridView)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.userID_panel.ResumeLayout(false);
            this.userID_panel.PerformLayout();
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
        private System.Windows.Forms.Button btnBorrowBookSelected;
        private System.Windows.Forms.Label bookName_label;
        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.GroupBox searchForBook_panel;
        private System.Windows.Forms.Button btnReserveBookSelected;
        private System.Windows.Forms.DataGridView showBooks_dataGridView;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.CheckBox bookAvailable_checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userID_input;
        private System.Windows.Forms.Panel userID_panel;
    }
}
