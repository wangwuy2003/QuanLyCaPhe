using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe
{
    internal class NhanVien
    {
        private string _maNV;
        private string _tenNV;
        private string _gioiTinh;
        private DateTime _ngaySinh;
        private string _soDienThoai;

        public NhanVien()
        {
        }

        public NhanVien(string maNV, string tenNV, string gioiTinh, DateTime ngaySinh, string soDienThoai)
        {
            _maNV = maNV;
            _tenNV = tenNV;
            _gioiTinh = gioiTinh;
            _ngaySinh = ngaySinh;
            _soDienThoai = soDienThoai;
        }

        public string MaNV { get => _maNV; set => _maNV = value; }
        public string TenNV { get => _tenNV; set => _tenNV = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public DateTime NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string SoDienThoai { get => _soDienThoai; set => _soDienThoai = value; }
    }
}
