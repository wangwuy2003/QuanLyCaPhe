using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyQuanCaPhe
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=DESKTOP-GQN6708\MSSQLSERVER01;Initial Catalog=QuanLyCaPhe;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static SqlConnection getSqlConnection()
        {
            return new SqlConnection(stringConnection); 
        }
    }
}
