using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Example;

namespace BusinessLogic
{
    public class TabAuthorModel
    {
        //create the variable
        #region Variable Set
        private int _aid;
        private string _authorName;
        #endregion

        //initialise variable (aid = Author ID)
        public int Aid
        {
            get { return _aid; }
            set { _aid = value; }
        }

        public string AuthorName
        {
            get { return _authorName; }
            set { _authorName = value; }
        }

        /// <summary>
        /// Get the value from TabAuthor
        /// </summary>
        /// <param name="AuthorRows">Name of the rows</param>
        /// <returns>Return the value from the rows selected</returns>
        public static TabAuthorModel Parse(DataSet1.TabAuthorRow AuthorRows)
        {
            if (AuthorRows == null)
            {
                return null;
            }
            else
            {
                TabAuthorModel TabAuthor = new TabAuthorModel();
                TabAuthor.Aid = AuthorRows.AID;
                TabAuthor.AuthorName = AuthorRows.AuthorName;

                return TabAuthor;
            }
        }

    }
}
