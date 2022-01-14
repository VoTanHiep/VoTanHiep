using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cau1.Model;

namespace Cau1.DAL
{
    public class DBConnection
    {
        public DBConnection()
        {
        }
        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=LAPTOP-UBH8O6TK\SQLEXPRESS;Initial Catalog=HR01;Integrated Security=True";
            return conn;
        }
    }
}