using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Example;

namespace BusinessLogic
{
    public class TabCategoryModel
    {
        //create the variable
        #region Variable Set
        private int _cid;
        private string _categoryName;
        #endregion

        //initialise variable (Cid = Category ID)
        public int Cid
        {
            get { return _cid; }
            set { _cid = value; }
        }

        public string CategoryName
        {
            get { return _categoryName; }
            set { _categoryName = value; }
        }

        /// <summary>
        /// Get the value from TabCategory
        /// </summary>
        /// <param name="CategoryRows">Name of the rows</param>
        /// <returns>Return the value from the rows selected</returns>
        public static TabCategoryModel Parse(DataSet1.TabCategoryRow CategoryRows)
        {
            if (CategoryRows == null)
            {
                return null;
            }
            else
            {
                TabCategoryModel Tabcategory = new TabCategoryModel();
                Tabcategory.Cid = CategoryRows.CID;
                Tabcategory.CategoryName = CategoryRows.CategoryName;

                return Tabcategory;
            }
        }

    }
}
