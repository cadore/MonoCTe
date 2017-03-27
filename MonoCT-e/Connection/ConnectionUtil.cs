using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoCT_e.Connection
{
    public class ConnectionUtil
    {
        public static string Host { get; private set; }
        public static string Port { get; private set; }
        public static string DataBase { get; private set; }
        public static string User { get; private set; }
        public static string Password { get; private set; }

        public static string InvariantName { get; private set; }
        public static string ConnectionString { get; private set; }

        public ConnectionUtil()
        {
            try
            {
                Host = "localhost"; //Util.Decrypt(INI.ReadValue("CONNECTION", "host"));
                Port = "5432"; // Util.Decrypt(INI.ReadValue("CONNECTION", "port"));
                DataBase = "monocte_db"; // Util.Decrypt(INI.ReadValue("CONNECTION", "db"));
                User = "postgres"; //Util.Decrypt(INI.ReadValue("CONNECTION", "user"));
                Password = "p@ssw0rd"; //Util.Decrypt(INI.ReadValue("CONNECTION", "password"));
                InvariantName = "Npgsql"; // Util.Decrypt(INI.ReadValue("CONNECTION", "invariantName"));

                ConnectionString = String.Format("Server={0};Port={1};User id={2};password={3};Database={4};",
                Host, Port, User, Password, DataBase);

            }
            catch (Exception ex)
            {
                ConnectionString = null;
                InvariantName = null;
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
