using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace DbHelperSQLLib
{
    public class PubConstant
    {
        public static string ConnectionString
        {
            get
            {
                string _connectionString = ConfigurationManager.AppSettings["ConnectionString"];
                //string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
                //if (ConStringEncrypt == "true")
                //{
                //    _connectionString = DESEncrypt.Decrypt(_connectionString);
                //}
                return _connectionString;
            }
        }

        public static string GetConnectionString(string configName)
        {
            string connectionString = ConfigurationManager.AppSettings[configName];
            //string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
            //if (ConStringEncrypt == "true")
            //{
            //    connectionString = DESEncrypt.Decrypt(connectionString);
            //}
            return connectionString;
        }
    }
}
