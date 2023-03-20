using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe
{
    internal class QuanLyTaiKhoan
    {
        private string _tenNguoiDung;
        private string _tenHienThi;
        private string _matKhau;
        private int _loaiTaiKhoan;

        public QuanLyTaiKhoan()
        {
        }

        private bool loaiTaiKhoan;
      

        

        public QuanLyTaiKhoan(string tenNguoiDung, string tenHienThi, string matKhau, int loaiTaiKhoan)
        {
            _tenNguoiDung = tenNguoiDung;
            _tenHienThi = tenHienThi;
            _matKhau = matKhau;
            _loaiTaiKhoan = loaiTaiKhoan;
        }

        public string TenNguoiDung { get => _tenNguoiDung; set => _tenNguoiDung = value; }
        public string TenHienThi { get => _tenHienThi; set => _tenHienThi = value; }
        public string MatKhau { get => _matKhau; set => _matKhau = value; }
        public int LoaiTaiKhoan { get => _loaiTaiKhoan; set => _loaiTaiKhoan = value; }

        public bool LoaiTaiKhoan1 { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }
    }
}
