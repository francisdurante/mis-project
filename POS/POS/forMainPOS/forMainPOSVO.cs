using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.forMainPOS
{
    class forMainPOSVO
    {
        public static double getTotalAmount;
        public static int getTotalItemCount;
        public static double setTotalAmount
        {
            get { return getTotalAmount; }
            set { getTotalAmount = value; }
        }
        
        public static int setTotalItemCount
        {
            get { return getTotalItemCount; }
            set { getTotalItemCount = value; }
        }
    }
}
