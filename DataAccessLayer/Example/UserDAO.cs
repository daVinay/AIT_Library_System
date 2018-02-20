using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Example.DataSet1TableAdapters;

namespace Example
{
    public class UserDAO
    {
        //set variable for all the database access
        private DataSet1 _userDataSet;
        private TabUserTableAdapter _tableUserTableAdapter;

        public UserDAO()
        {
            _userDataSet = new DataSet1();
            _tableUserTableAdapter = new TabUserTableAdapter();
        }

        /// <summary>
        /// Get all data from TabUser
        /// </summary>
        /// <returns>Return the data to the dataset</returns>
        /// <exception cref="Exception"></exception>
        public DataSet1.TabUserDataTable GetUser()
        {
            try
            {
                _tableUserTableAdapter.Fill(_userDataSet.TabUser);

                return _userDataSet.TabUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        /// <summary>
        /// Total number of user in the TabUser
        /// </summary>
        /// <returns>returns integer</returns>
        public int NumberOfUsers()
        {
            try
            {
                int count = Convert.ToInt32(_tableUserTableAdapter.NumberOfUsers());
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get data from TabUser 
        /// </summary>
        /// <param name="username">string username</param>
        /// <param name="password">string password</param>
        /// <returns>Return the data selected to the dataset</returns>
        /// <exception cref="Exception"></exception>
        public DataSet1.TabUserDataTable GetUserNamePassword(string username, string password)
        {
            try
            {
                _tableUserTableAdapter.FillByUserNamePassword(_userDataSet.TabUser, username, password);

                return _userDataSet.TabUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        // Datatable TabUser only with UserName check
        public DataSet1.TabUserDataTable GetUserName(string username)
        {
            try
            {
                _tableUserTableAdapter.FillByUserName(_userDataSet.TabUser, username);

                return _userDataSet.TabUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // Datatable TabUser only with UID check
        public DataSet1.TabUserDataTable GetInfoByUID(int UID)
        {
            try
            {
                _tableUserTableAdapter.FillByUID(_userDataSet.TabUser, UID);

                return _userDataSet.TabUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // Datatable TabUser only with UserName and UID check
        public DataSet1.TabUserDataTable GetUserByUserNameUID(int UID, string username)
        {
            try
            {
                _tableUserTableAdapter.FillByUIDUserName(_userDataSet.TabUser, UID, username);

                return _userDataSet.TabUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Update user into TabUser
        public int UpdateFromTabUser(string userName, string pwd, int userLevel, int UID)
        {
            try
            {
                return _tableUserTableAdapter.UpdateUser(userName, pwd, userLevel, UID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        /// <summary>
        /// create query for insert user
        /// </summary>
        /// <param name="UserName">string</param>
        /// <param name="pwd">string</param>
        /// <param name="userLevel">int</param>
        /// <returns></returns>
        public int InsertUser(string UserName, string pwd, int userLevel)
        {
            try
            {
                return _tableUserTableAdapter.InsertUser(UserName, pwd, userLevel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// delete user with UID
        /// </summary>
        /// <param name="uid">int</param>
        /// <returns></returns>
        public int DeleteUser(int uid)
        {
            return _tableUserTableAdapter.DeleteUser(uid);
        }
    }
}