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
    public partial class frmMain : MyForm
    {
        public frmMain()
        {
            InitializeComponent();
            // hide the message error (label)
            loginError.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            UserLogic ul = new UserLogic();
            List<TabUserModel> _user = ul.GetLogin(Usrname_textbox.Text, pwd_textbox.Text);
            
            // if a user correspond with the userName & Password do..
            if (_user.Count > 0)
            {
                staticUserName = _user[0].UserName;       // stock userName
                staticUserLevel = _user[0].UserLevel;   //stock level
                staticUID = _user[0].UserID; // stock UID
                loginError.Visible = true;
                loginError.Text = "Login Succes!!!";
                // open the 2nd form
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenForm2));
                t.Start();

                this.Close();
            }
            else
            {
                // Check is the userName is present in the datatable
                List<TabUserModel> _user1 = ul.GetLogin(Usrname_textbox.Text);
                // if present means the password only is incorrect
                if (_user1.Count > 0)
                {
                    if (Usrname_textbox.Text == _user1[0].UserName)
                    {
                        loginError.Visible = true;
                        loginError.Text = "Password Incorrect !";
                    }
                }
                else
                {
                    loginError.Visible = true;
                    loginError.Text = "Login Faill !";
                }
                
            }
        }

        public static void OpenForm2()
            {
                Application.Run(new SearchBook());
            }
    }
}
