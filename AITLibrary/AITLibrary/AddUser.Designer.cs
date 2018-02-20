namespace AITLibrary
{
    partial class AddUser
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
            this.addUserGroup = new System.Windows.Forms.GroupBox();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.pwdInput = new System.Windows.Forms.TextBox();
            this.btnAddUserDatabase = new System.Windows.Forms.Button();
            this.levelBoxList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteSelectedUser = new System.Windows.Forms.Button();
            this.userAddDelete_panel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateUser = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.userID_update = new System.Windows.Forms.TextBox();
            this.userNameInput_update = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pwdInput_update = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.levelBoxList_update = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.userID_search = new System.Windows.Forms.TextBox();
            this.userName_search = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addUserGroup.SuspendLayout();
            this.userAddDelete_panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addUserGroup
            // 
            this.addUserGroup.Controls.Add(this.userNameInput);
            this.addUserGroup.Controls.Add(this.pwdInput);
            this.addUserGroup.Controls.Add(this.btnAddUserDatabase);
            this.addUserGroup.Controls.Add(this.levelBoxList);
            this.addUserGroup.Controls.Add(this.label4);
            this.addUserGroup.Controls.Add(this.label1);
            this.addUserGroup.Controls.Add(this.label3);
            this.addUserGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserGroup.Location = new System.Drawing.Point(3, 105);
            this.addUserGroup.Name = "addUserGroup";
            this.addUserGroup.Size = new System.Drawing.Size(365, 114);
            this.addUserGroup.TabIndex = 31;
            this.addUserGroup.TabStop = false;
            this.addUserGroup.Text = "Add an user to the database";
            // 
            // userNameInput
            // 
            this.userNameInput.Location = new System.Drawing.Point(75, 27);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(100, 23);
            this.userNameInput.TabIndex = 21;
            this.userNameInput.Enter += new System.EventHandler(this.showAllUsers);
            // 
            // pwdInput
            // 
            this.pwdInput.Location = new System.Drawing.Point(75, 53);
            this.pwdInput.Name = "pwdInput";
            this.pwdInput.Size = new System.Drawing.Size(100, 23);
            this.pwdInput.TabIndex = 22;
            this.pwdInput.Enter += new System.EventHandler(this.showAllUsers);
            // 
            // btnAddUserDatabase
            // 
            this.btnAddUserDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUserDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUserDatabase.Location = new System.Drawing.Point(217, 82);
            this.btnAddUserDatabase.Name = "btnAddUserDatabase";
            this.btnAddUserDatabase.Size = new System.Drawing.Size(75, 23);
            this.btnAddUserDatabase.TabIndex = 27;
            this.btnAddUserDatabase.Text = "Add";
            this.btnAddUserDatabase.UseVisualStyleBackColor = true;
            this.btnAddUserDatabase.Click += new System.EventHandler(this.newUser_click);
            // 
            // levelBoxList
            // 
            this.levelBoxList.FormattingEnabled = true;
            this.levelBoxList.Items.AddRange(new object[] {
            "User",
            "Supervisor",
            "Administrator"});
            this.levelBoxList.Location = new System.Drawing.Point(75, 79);
            this.levelBoxList.Name = "levelBoxList";
            this.levelBoxList.Size = new System.Drawing.Size(121, 25);
            this.levelBoxList.TabIndex = 23;
            this.levelBoxList.Enter += new System.EventHandler(this.showAllUsers);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Password";
            // 
            // btnDeleteSelectedUser
            // 
            this.btnDeleteSelectedUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelectedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedUser.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteSelectedUser.Location = new System.Drawing.Point(200, 9);
            this.btnDeleteSelectedUser.Name = "btnDeleteSelectedUser";
            this.btnDeleteSelectedUser.Size = new System.Drawing.Size(168, 23);
            this.btnDeleteSelectedUser.TabIndex = 13;
            this.btnDeleteSelectedUser.Text = "Delete selected user";
            this.btnDeleteSelectedUser.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedUser.Click += new System.EventHandler(this.deleteUserSelected_click);
            // 
            // userAddDelete_panel
            // 
            this.userAddDelete_panel.Controls.Add(this.button3);
            this.userAddDelete_panel.Controls.Add(this.groupBox1);
            this.userAddDelete_panel.Controls.Add(this.btnDeleteSelectedUser);
            this.userAddDelete_panel.Controls.Add(this.groupBox2);
            this.userAddDelete_panel.Controls.Add(this.addUserGroup);
            this.userAddDelete_panel.Location = new System.Drawing.Point(12, 381);
            this.userAddDelete_panel.Name = "userAddDelete_panel";
            this.userAddDelete_panel.Size = new System.Drawing.Size(884, 223);
            this.userAddDelete_panel.TabIndex = 34;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(3, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "Update selected user";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.updateSelectedUser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateUser);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.userID_update);
            this.groupBox1.Controls.Add(this.userNameInput_update);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pwdInput_update);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.levelBoxList_update);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(482, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 137);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update user to the database";
            // 
            // updateUser
            // 
            this.updateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateUser.Location = new System.Drawing.Point(224, 108);
            this.updateUser.Name = "updateUser";
            this.updateUser.Size = new System.Drawing.Size(75, 23);
            this.updateUser.TabIndex = 29;
            this.updateUser.Text = "Update";
            this.updateUser.UseVisualStyleBackColor = true;
            this.updateUser.Click += new System.EventHandler(this.updateUser_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "User ID";
            // 
            // userID_update
            // 
            this.userID_update.Location = new System.Drawing.Point(85, 27);
            this.userID_update.Name = "userID_update";
            this.userID_update.ReadOnly = true;
            this.userID_update.Size = new System.Drawing.Size(60, 23);
            this.userID_update.TabIndex = 35;
            // 
            // userNameInput_update
            // 
            this.userNameInput_update.Location = new System.Drawing.Point(85, 53);
            this.userNameInput_update.Name = "userNameInput_update";
            this.userNameInput_update.Size = new System.Drawing.Size(100, 23);
            this.userNameInput_update.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "UserName";
            // 
            // pwdInput_update
            // 
            this.pwdInput_update.Location = new System.Drawing.Point(85, 79);
            this.pwdInput_update.Name = "pwdInput_update";
            this.pwdInput_update.Size = new System.Drawing.Size(100, 23);
            this.pwdInput_update.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Password";
            // 
            // levelBoxList_update
            // 
            this.levelBoxList_update.FormattingEnabled = true;
            this.levelBoxList_update.Items.AddRange(new object[] {
            "User",
            "Supervisor",
            "Administrator"});
            this.levelBoxList_update.Location = new System.Drawing.Point(85, 105);
            this.levelBoxList_update.Name = "levelBoxList_update";
            this.levelBoxList_update.Size = new System.Drawing.Size(121, 25);
            this.levelBoxList_update.TabIndex = 31;
            this.levelBoxList_update.Enter += new System.EventHandler(this.showAllUsers);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Level";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.userID_search);
            this.groupBox2.Controls.Add(this.userName_search);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 55);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search for an user";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(192, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "OR";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(355, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.searchUserByUIDUserName_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(226, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "User ID";
            // 
            // userID_search
            // 
            this.userID_search.Location = new System.Drawing.Point(275, 22);
            this.userID_search.Name = "userID_search";
            this.userID_search.Size = new System.Drawing.Size(60, 23);
            this.userID_search.TabIndex = 37;
            // 
            // userName_search
            // 
            this.userName_search.Location = new System.Drawing.Point(76, 22);
            this.userName_search.Name = "userName_search";
            this.userName_search.Size = new System.Drawing.Size(100, 23);
            this.userName_search.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "UserName";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 616);
            this.Controls.Add(this.userAddDelete_panel);
            this.Name = "AddUser";
            this.Text = "AIT Library System";
            this.Load += new System.EventHandler(this.AddUser_load);
            this.addUserGroup.ResumeLayout(false);
            this.addUserGroup.PerformLayout();
            this.userAddDelete_panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addUserGroup;
        private System.Windows.Forms.TextBox userNameInput;
        private System.Windows.Forms.TextBox pwdInput;
        private System.Windows.Forms.Button btnAddUserDatabase;
        private System.Windows.Forms.ComboBox levelBoxList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteSelectedUser;
        private System.Windows.Forms.Panel userAddDelete_panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button updateUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userID_update;
        private System.Windows.Forms.TextBox userNameInput_update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pwdInput_update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox levelBoxList_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox userID_search;
        private System.Windows.Forms.TextBox userName_search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
    }
}