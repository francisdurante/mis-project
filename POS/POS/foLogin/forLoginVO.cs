using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.foLogin
{
    class forLoginVO
    {
        public static int getUserID;
        public static int getUserLoggedIn;
        public static string getPassword;
        public static string getFullName;
        public static string getPosition;
        public static string getStatus;
        public static string getState;

        public static int setUserID
        {
            get { return getUserID; }
            set { getUserID = value; }
        }
        public static int setUserLoggedIn
        {
            get { return getUserLoggedIn; }
            set { getUserLoggedIn = value; }
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
        public static string setStatus
        {
            get { return getStatus; }
            set { getStatus = value; }
        }
        public static string setState
        {
            get { return getState; }
            set { getState = value; }
        }
    }
}
