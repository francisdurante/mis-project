using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.forBrowseUser
{
    class forAddUserVO
    {
        public static int getID;
        public static int getUserID;
        public static int getFunctionFor; //1 for AddUser 2 For Edit User
        public static string getFullName;
        public static string getPosition;
        public static string getState;
        public static string getStatus;
        public static string getFormText;

        public static int setID
        {
            get { return getID; }
            set { getID = value; }
        }
        public static int setUserID
        {
            get { return getUserID; }
            set { getUserID = value; }
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
        public static string setState
        {
            get { return getState; }
            set { getState = value; }
        }
        public static string setStatus
        {
            get { return getStatus; }
            set { getStatus = value; }
        }
        public static int setFunctionFor
        {
            get { return getFunctionFor; }
            set { getFunctionFor = value; }
        }
        public static string setFormText
        {
            get { return getFormText; }
            set { getFormText = value; }
        }
    }
}
