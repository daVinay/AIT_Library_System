using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Example;

namespace BusinessLogic
{
    public class UserLogic
    {
        //set the variable for Dataset1 with the different datatable
        private UserDAO _userDao;
        private DataSet1.TabUserDataTable _userTable;

        public UserLogic(){
            _userDao = new UserDAO();
            _userTable = new DataSet1.TabUserDataTable();
        }

        /// <summary>
        /// Read all the users stocked in the dataset and returns the rows
        /// </summary>
        /// <returns></returns>
        public List<TabUserModel> ListUser(){
           
            List<TabUserModel> _users = new List<TabUserModel>();
            
            _userTable = _userDao.GetUser();
           
            foreach (DataSet1.TabUserRow minionRow in _userTable.Rows){
                TabUserModel tempRow = TabUserModel.Parse(minionRow);
                _users.Add(tempRow);
            }

            return _users;
        }

        /// <summary>
        /// Get login and password from datatable with the value passed through
        /// </summary>
        /// <param name="userName">String Username</param>
        /// <param name="pwd">String Password</param>
        /// <returns>Return the value from the datatable</returns>
        public List<TabUserModel> GetLogin(string userName, string pwd)
        {
            List<TabUserModel> _users = new List<TabUserModel>();

            _userTable = _userDao.GetUserNamePassword(userName, pwd);

            foreach (DataSet1.TabUserRow minionRow in _userTable.Rows)
            {
                TabUserModel tempRow = TabUserModel.Parse(minionRow);
                _users.Add(tempRow);
            }

            return _users;
        }


        /// <summary>
        /// Get login from datatable with the value passed through
        /// </summary>
        /// <param name="userName">String Username</param>
        /// <returns>Return the value from the datatable</returns>
        public List<TabUserModel> GetLogin(string userName)
        {
            List<TabUserModel> _users = new List<TabUserModel>();

            _userTable = _userDao.GetUserName(userName);

            foreach (DataSet1.TabUserRow minionRow in _userTable.Rows)
            {
                TabUserModel tempRow = TabUserModel.Parse(minionRow);
                _users.Add(tempRow);
            }

            return _users;
        }

        /// <summary>
        /// Get user from tabUser by UDID
        /// </summary>
        /// <param name="UID"></param>
        /// <returns></returns>
        public List<TabUserModel> GetUserInfoByUID(int UID)
        {
            List<TabUserModel> _users = new List<TabUserModel>();

            _userTable = _userDao.GetInfoByUID(UID);

            foreach (DataSet1.TabUserRow minionRow in _userTable.Rows)
            {
                TabUserModel tempRow = TabUserModel.Parse(minionRow);
                _users.Add(tempRow);
            }

            return _users;
        }

        /// <summary>
        /// Get user from datatable with 2 parameters UID OR UserName
        /// </summary>
        /// <param name="userName">String Username</param>
        /// <param name="UID">Int</param>
        /// <returns>Return the value from the datatable</returns>
        public List<TabUserModel> GetUserByUserNameUID(int UID, string userName)
        {
            int? UIDCheck = UID;
            if (UIDCheck == null && userName != "")
            {
                List<TabUserModel> _users = new List<TabUserModel>();

                _userTable = _userDao.GetUserName(userName);

                foreach (DataSet1.TabUserRow minionRow in _userTable.Rows)
                {
                    TabUserModel tempRow = TabUserModel.Parse(minionRow);
                    _users.Add(tempRow);
                }

                return _users;
            }
            else if (UIDCheck != null && userName != "")
            {
                List<TabUserModel> _users = new List<TabUserModel>();

                _userTable = _userDao.GetUserByUserNameUID(UID, userName);

                foreach (DataSet1.TabUserRow minionRow in _userTable.Rows)
                {
                    TabUserModel tempRow = TabUserModel.Parse(minionRow);
                    _users.Add(tempRow);
                }

                return _users;
            }
            else if (UIDCheck != null && userName == "")
            {
                List<TabUserModel> _users = new List<TabUserModel>();

                _userTable = _userDao.GetUserByUserNameUID(UID, "");

                foreach (DataSet1.TabUserRow minionRow in _userTable.Rows)
                {
                    TabUserModel tempRow = TabUserModel.Parse(minionRow);
                    _users.Add(tempRow);
                }

                return _users;
            }
            else
            {
                List<TabUserModel> _users = new List<TabUserModel>();
            
                _userTable = _userDao.GetUser();
           
                foreach (DataSet1.TabUserRow minionRow in _userTable.Rows)
                {
                    TabUserModel tempRow = TabUserModel.Parse(minionRow);
                    _users.Add(tempRow);
                }

                return _users;
            }
        }
            
        /// <summary>
        /// Insert user in TabUser
        /// </summary>
        /// <param name="UserName">string</param>
        /// <param name="pwd">string</param>
        /// <param name="userLevel">string</param>
        /// <returns></returns>
        public int InsertNewUser(string UserName, string pwd, string userLevel)
        {
            int level = 0;

            if (userLevel == "User")
                level = 1;
            else if (userLevel == "Supervisor")
                level = 2;
            else if (userLevel == "Administrator")
                level = 3;
            else
                level = 0;

            return _userDao.InsertUser(UserName, pwd, level);

        }

        /// <summary>
        /// Update an user in TabUser (with UID)
        /// </summary>
        /// <param name="userName">string</param>
        /// <param name="pwd">string</param>
        /// <param name="userLevel">int</param>
        /// <param name="UID">int</param>
        /// <returns></returns>
        public int UpdateFromTabUser(string userName, string pwd, int userLevel, int UID)
        {
            try
            {
                return _userDao.UpdateFromTabUser(userName, pwd, userLevel, UID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Delete an user in TabUSer (with UID)
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public int DeleteSelectedUser(string uid)
        {
            try
            {
                return _userDao.DeleteUser(Int32.Parse(uid));
            }
            catch (FormatException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Number of user in the TabUser
        /// </summary>
        /// <returns>return an integer</returns>
        public int NumberOfUsers()
        {
            try
            {
                int count = Convert.ToInt32(_userDao.NumberOfUsers());
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
