

namespace POS.Globals
{
    class GlobalCodeVO 
    {
        public static string getServerIp;
        public static string getDatabaseName;
        public static string getDatabaseUser;
        public static string getDatabasePassword;

        public static string setServerIp
        {
            get { return getServerIp; }
            set { getServerIp = value; }
        }
        public static string setDatabaseName
        {
            get { return getDatabaseName; }
            set { getDatabaseName = value; }
        }
        public static string setDatabaseUser
        {
            get { return getDatabaseUser; }
            set { getDatabaseUser = value; }
        }
        public static string setDatabasePassword
        {
            get { return getDatabasePassword; }
            set { getDatabasePassword = value; }
        }
    }
}