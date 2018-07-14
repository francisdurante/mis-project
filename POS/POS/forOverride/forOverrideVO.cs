using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.forOverride
{
    class forOverrideVO
    {
        public static string getFrmTitle;
        public static string getUserName;
        public static string getPassword;
        public static string getFullName;
        public static string getPosition;
        public static string getOverrideFor;
        public static string getOverrideNeedPosition;
        public static bool getResultInOverride;
        public static int getListViewItemIndex;
        public static string setFrmTitle
        {
            get { return getFrmTitle; }
            set { getFrmTitle = value; }
        }
        public static string setUserName
        {
            get { return getUserName; }
            set { getUserName = value; }
        }
        public static string setPassword
        {
            get { return getPassword; }
            set { getPassword = value; }
        }
        public static string setFullName
        {
            get { return getFullName; }
            set { getFullName = value; }
        }
        public static string setPosition
        {
            get { return getPosition; }
            set { getPosition = value; }
        }
        public static string setOverrideFor
        {
            get { return getOverrideFor; }
            set { getOverrideFor = value; }
        }
        public static string setOverrideNeedPosition
        {
            get { return getOverrideNeedPosition; }
            set { getOverrideNeedPosition = value; }
        }
        public static bool setResultInOverride
        {
            get { return getResultInOverride; }
            set { getResultInOverride = value; }
        }
        public static int setListviewItemIndex
        {
            get { return getListViewItemIndex; }
            set { getListViewItemIndex = value; }
        }
    }
}
