using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConfig
    {
        private static DBConfig instance = new();   
        public static DBConfig Instance {  
            get { return instance; } 
        }
        public SqlConnection SQLConnect()
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=LAPTOP-F45JGTQ4\HUNGDATABASE;Initial Catalog=Laptop_Store;User ID=sa;Password=20012004";
            cnn = new SqlConnection(connetionString);
            return cnn;
        }

    }
}
