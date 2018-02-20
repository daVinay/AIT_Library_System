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
    public partial class AddUser : Template
    {
        public AddUser()
        {
            InitializeComponent();
        }

        #region set variable
        string userLevel;
        #endregion

        //When the form Load show all the users
        private void AddUser_load(object sender, EventArgs e)
        {
            showAllUsers(null, e);

            //only Admin and Supervisor can see userAddDelete_panel
            if (staticUserLevel == 3)
            {
                userAddDelete_panel.Visible = true;
            }
            else
                userAddDelete_panel.Visible = false;
        }

        //Hide diferren Panel
        public override void hidePanel(object sender, MouseEventArgs e)
        {
            userAddDelete_panel.Visible = false;
        }

        /// <summary>
        /// Add User to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newUser_click(object sender, EventArgs e)
        {
            UserLogic ul = new UserLogic();

            int result = ul.InsertNewUser(userNameInput.Text, pwdInput.Text, levelBoxList.Text);

            MessageBox.Show(result.ToString() + " user added", "A message from AIT Library");

            //refresh list user
            dataGridView1.DataSource = ul.ListUser();
            this.dataGridView1.Columns[3].Visible = false;
        }

        /// <summary>
        /// Show all User from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showAllUsers(object sender, EventArgs e)
        {
            //dataGridView1.Visible = true;
            UserLogic ul = new UserLogic();
            dataGridView1.DataSource = ul.ListUser();
            this.dataGridView1.Columns[3].Visible = false;
        }

        /// <summary>
        /// Delete the selected user then refresh the dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteUserSelected_click(object sender, EventArgs e)
        {
            UserLogic ul = new UserLogic();

            int result = 0;

             DialogResult dialogResult = MessageBox.Show("Are you sure to delete user: "+dataGridView1.SelectedRows[0].Cells[1].Value.ToString()+" ?", "Please make a choice", MessageBoxButtons.YesNo);
             if (dialogResult == DialogResult.Yes)
             {
                 result = ul.DeleteSelectedUser(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                 MessageBox.Show("User: " + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + " deleted", "A message from AIT Library");
             }
             else if (dialogResult == DialogResult.No)
             {
                 //do nothing
             }
            //refresh list user
            dataGridView1.DataSource = ul.ListUser();
        }

        /// <summary>
        /// Search user by UID and UserName (int, string)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchUserByUIDUserName_Click(object sender, EventArgs e)
        {
            UserLogic ul = new UserLogic();
            string strUserID = userID_search.Text;
            if (strUserID == "")
            {
                strUserID = "0";
                int userID = Int32.Parse(strUserID);
                dataGridView1.DataSource = ul.GetUserByUserNameUID(userID, userName_search.Text);
                List<TabUserModel> _userInfo = ul.GetUserByUserNameUID(userID, userName_search.Text);
                if (_userInfo.Count > 0)
                {
                    userID_update.Text = _userInfo[0].UserID.ToString();
                    userNameInput_update.Text = _userInfo[0].UserName;
                    pwdInput_update.Text = _userInfo[0].Password;
                    if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "1")
                    {
                        userLevel = "User";
                    }
                    else if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "2")
                    {
                        userLevel = "Supervisor";
                    }
                    else
                    {
                        userLevel = "Administrator";
                    }
                    levelBoxList_update.SelectedIndex = levelBoxList_update.FindString(userLevel);
                }
            }
            else
            {//try to parse to int if error throw a message
                try
                {
                    int userID = Int32.Parse(strUserID);
                    dataGridView1.DataSource = ul.GetUserInfoByUID(userID);
                    List<TabUserModel> _userInfo = ul.GetUserInfoByUID(userID);
                    if (_userInfo.Count > 0)
                    {
                        userID_update.Text = _userInfo[0].UserID.ToString();
                        userNameInput_update.Text = _userInfo[0].UserName;
                        pwdInput_update.Text = _userInfo[0].Password;
                        if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "1")
                        {
                            userLevel = "User";
                        }
                        else if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "2")
                        {
                            userLevel = "Supervisor";
                        }
                        else
                        {
                            userLevel = "Administrator";
                        }
                        levelBoxList_update.SelectedIndex = levelBoxList_update.FindString(userLevel);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Must be a valid number", "A message from AIT Library");
                }
            }
            
        }

        /// <summary>
        /// load user information from datagridview for update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateSelectedUser_Click(object sender, EventArgs e)
        {
            userID_update.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            userNameInput_update.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            pwdInput_update.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "1")
            {
                userLevel = "User";
            }
            else if (dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == "2")
            {
                userLevel = "Supervisor";
            }
            else
            {
                userLevel = "Administrator";
            }
            levelBoxList_update.SelectedIndex = levelBoxList_update.FindString(userLevel);
        }

        /// <summary>
        /// Update user to Tab User
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateUser_Click(object sender, EventArgs e)
        {
            UserLogic ul = new UserLogic();
            int level = 0;

            if (levelBoxList_update.Text == "User")
                level = 1;
            else if (levelBoxList_update.Text == "Supervisor")
                level = 2;
            else if (levelBoxList_update.Text == "Administrator")
                level = 3;
            else
                level = 0;
            ul.UpdateFromTabUser(userNameInput_update.Text,pwdInput_update.Text, level, Int32.Parse(userID_update.Text));
            MessageBox.Show("User updated", "A message from AIT Library"); ;
            dataGridView1.DataSource = ul.ListUser();
        }
    }
}
