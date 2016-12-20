using SecureApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoCT_e.Utils
{
    public class Crypto
    {
        public static string Decrypt(String s)
        {
            return new DTICrypto().Decifrar(s, "cte");
        }

        public static string Encrypt(String s)
        {
            return new DTICrypto().Cifrar(s, "cte");
        }
    }
}
