using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoCT_e.Utils
{
    public class Unique
    {
        public static bool CnpjBusinessIsUnique(business c)
        {
            try
            {
                string s = MonoCTeRepo.GetInstance().ExecuteScalar<string>
                    ("SELECT COUNT(id) FROM business WHERE cnpj=@0", c.cnpj);
                int count;
                if (s.Equals(DBNull.Value) || String.IsNullOrEmpty(s))
                    count = 0;
                else
                    count = Convert.ToInt32(s);

                if (count == 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
