using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoCT_e
{
    public class Singleton
    {
        private static user us = null;
        private static business bs = null;

        public static void setCurrentUser(user u)
        {
            us = u;
        }

        public static user getCurrentUser()
        {
            return us;
        }

        public static void setCurrentBusiness(business b)
        {
            bs = b;
        }

        public static business getCurrentBusiness()
        {
            return bs;
        }
    }
}
