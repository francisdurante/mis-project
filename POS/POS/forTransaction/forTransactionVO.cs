using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.forTransaction
{
    class forTransactionVO
    {
        public static string getTransactionCode;
        public static string getTransactionDate;
        public static string getItemCode;
        public static string getItemName;
        public static double getItemTotal;
        public static double getPriceAt;
        public static double getGrandTotal;
        public static int getItemQuantity;
        public static int getItemCount;

        public static string setTransactionCode
        {
            get { return getTransactionCode; }
            set { getTransactionCode = value; }
        }
        public static string setTransactionDate
        {
            get { return getTransactionDate; }
            set { getTransactionDate = value; }
        }
        public static string setItemCode
        {
            get { return getItemCode; }
            set { getItemCode = value; }
        }
        public static string setItemName
        {
            get { return getItemName; }
            set { getItemName = value; }
        }
        public static double setItemTotal
        {
            get { return getItemTotal; }
            set { getItemTotal = value; }
        }
        public static double setPriceAt
        {
            get { return getPriceAt; }
            set { getPriceAt = value; }
        }
        public static double setGrandTotal
        {
            get { return getGrandTotal; }
            set { getGrandTotal = value; }
        }
        public static int setItemQuantity
        {
            get { return getItemQuantity; }
            set { getItemQuantity = value; }
        }
        public static int setItemCount
        {
            get { return getItemCount; }
            set { getItemCount = value; }
        }
    }
}
