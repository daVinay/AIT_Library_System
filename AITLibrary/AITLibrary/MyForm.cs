using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace AITLibrary
{
    public class MyForm : Form
    {
        public static string staticUserName;
        public static int staticUID;
        public static string bookStatus = "Add";                //only for form SearchBook and UpdateBook
        public static int staticUserLevel;

        private void InitializeComponent()
        {

        }      
    }
}
