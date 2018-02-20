using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Example;

namespace BusinessLogic
{
    public class PairModel
    {
        private string _pairID;
        private string _pairName;
        private string _pairAuthor;

        public string PairID
        {
            set { _pairID = value; }
            get { return _pairID; }
        }

        public string PairName
        {
            get { return _pairName; }
            set { _pairName = value; }
        }

        public string PairAuthor
        {
            get { return _pairAuthor; }
            set { _pairAuthor = value; }
        }

        //function overlooding TabCategory
        public static PairModel Parse(DataSet1.TabCategoryRow uglyRow)
        {
            if (uglyRow == null)
                return null;

            PairModel tempModel = new PairModel();

            tempModel.PairID = uglyRow.CID.ToString();
            tempModel.PairName = uglyRow.CategoryName;

            return tempModel;
        }

        //function overlooding TabLanguage
        public static PairModel Parse(DataSet1.TabLanguageRow uglyRow)
        {
            if (uglyRow == null)
                return null;

            PairModel tempModel = new PairModel();

            tempModel.PairID = uglyRow.LID.ToString();
            tempModel.PairName = uglyRow.LanguageName;

            return tempModel;
        }

        //function overlooding TabAuthor
        public static PairModel Parse(DataSet1.TabAuthorRow uglyRow)
        {
            if (uglyRow == null)
                return null;

            PairModel tempModel = new PairModel();

            tempModel.PairID = uglyRow.AID.ToString();
            tempModel.PairName = uglyRow.AuthorName;

            return tempModel;
        }
    }
}
