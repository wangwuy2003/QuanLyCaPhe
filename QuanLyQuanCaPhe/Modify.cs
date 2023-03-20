using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QuanLyQuanCaPhe
{
    internal class Modify
    {
        public Modify()
        {
        }
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand; // dung de truy van cac cau lenh insert, update, delete...
        SqlDataReader dataReader; // dung de doc du lieu trong bang

        public DataTable Table(string query) // dung de tra ve bang du lieu 
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = Connection.getSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public void Command(string query)// dung de them, sua, xoa
        {
            using (SqlConnection sqlConnection = Connection.getSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public List<TaiKhoan> taiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.getSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(1), dataReader.GetString(2)));
                }
                sqlConnection.Close();
            }
            return taiKhoans;

        }
        public List<DoUong> DoUongs(string query)
        {
            List<DoUong> doUongs = new List<DoUong>();
            using (SqlConnection sqlConnection = Connection.getSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    doUongs.Add(new DoUong(dataReader.GetString(1), dataReader.GetFloat(3)));
                }
                sqlConnection.Close();
            }
            return doUongs;

        }
    }
}
