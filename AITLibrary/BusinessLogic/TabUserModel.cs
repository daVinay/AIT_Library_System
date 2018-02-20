using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Example;

// Initialise/set/return the variable and method for the datatable TabUser

namespace BusinessLogic
{
    public class TabUserModel
    {
        #region field

        private int _userId;
        private string _userName;
        private int _userLevel;
        private string _userPwd;

        #endregion

        public int UserID{
            get { return _userId; }
            set { _userId = value; }
        }

        public string UserName{
            get { return _userName; }
            set { _userName = value; }
        }

        public int UserLevel{
            get { return _userLevel; }
            set { _userLevel = value; }
        }

        public string Password
        {
            get { return _userPwd; }
            set { _userPwd = value; }
        }

        // Get the value from the dataset and stock them in tempModel
        public static TabUserModel Parse(DataSet1.TabUserRow minionRow){
            if (minionRow == null){
                return null;
            } else{
                TabUserModel tempModel = new TabUserModel();
                tempModel.UserID = minionRow.UID;
                tempModel.UserName = minionRow.UserName;
                tempModel.UserLevel = minionRow.UserLevel;
                tempModel.Password = minionRow.Password;
                return tempModel;
            }
        }
    }
}
