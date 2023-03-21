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
        SqlDataAdapter dataAdapter; // truy xuat du lieu vao dataTable
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


        //dataTable tra ve 1 bang
        //lay du lieu nhan vien
        public DataTable getAllNhanVien()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from NhanVien";
            using(SqlConnection sqlConnection = Connection.getSqlConnection())
            {               
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public bool insert(NhanVien nhanvien)
        {
            SqlConnection sqlConnection = Connection.getSqlConnection();
            //string query = "insert into NhanVien values (" + nhanvien.MaNV + ", N'" + nhanvien.tenNV + "', N'" + nhanvien.GioiTinh + "', '" + nhanvien.NgaySinh + "', '" + nhanvien.SoDienThoai + "')";
            string query = "insert into NhanVien values (@maNV, @tenNV, @gioiTinh, @ngaySinh, @soDienThoai)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@maNV", SqlDbType.VarChar).Value = nhanvien.MaNV;
                sqlCommand.Parameters.Add("@tenNV", SqlDbType.VarChar).Value = nhanvien.TenNV;
                sqlCommand.Parameters.Add("@gioiTinh", SqlDbType.VarChar).Value = nhanvien.GioiTinh;
                sqlCommand.Parameters.Add("@ngaySinh", SqlDbType.VarChar).Value = nhanvien.NgaySinh.ToShortDateString(); // chỉ lấy ngày tháng năm
                sqlCommand.Parameters.Add("@soDienThoai", SqlDbType.VarChar).Value = nhanvien.SoDienThoai;
                sqlCommand.ExecuteNonQuery();//thuc thi lenh truy van
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public bool update(NhanVien nhanvien)
        {
            SqlConnection sqlConnection = Connection.getSqlConnection();
            string query = "update NhanVien set tenNV = @tenNV, gioiTinh = @gioiTinh, ngaySinh = @ngaySinh, soDienThoai = @soDienThoai where maNV = @maNV";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@maNV", SqlDbType.VarChar).Value = nhanvien.MaNV;
                sqlCommand.Parameters.Add("@tenNV", SqlDbType.NVarChar).Value = nhanvien.TenNV;
                sqlCommand.Parameters.Add("@gioiTinh", SqlDbType.NVarChar).Value = nhanvien.GioiTinh;
                sqlCommand.Parameters.Add("@ngaySinh", SqlDbType.VarChar).Value = nhanvien.NgaySinh.ToShortDateString(); // chỉ lấy ngày tháng năm
                sqlCommand.Parameters.Add("@soDienThoai", SqlDbType.VarChar).Value = nhanvien.SoDienThoai;
                sqlCommand.ExecuteNonQuery();//thuc thi lenh truy van
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        //delete function nhanvien
        public bool delete(string ma)
        {
            SqlConnection sqlConnection = Connection.getSqlConnection();
            string query = "delete NhanVien where maNV = @maNV";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@maNV", SqlDbType.VarChar).Value = ma;
                sqlCommand.ExecuteNonQuery();//thuc thi lenh truy van
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
    }
}


// sql có thể chứa thêm tham số, tham số trong chuỗi câu lệnh được ký hiệu @+tên tham số
// gán tham số = sqlcommand, sqldbtype là xác định dữ liệu kiểu thuộc tính trong database