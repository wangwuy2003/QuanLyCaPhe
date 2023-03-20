using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe
{
    internal class QuanLyThucDon
    {
        private int _idThucDon;
        private string _tenThucDon;
        private string _thucDonDanhMuc;
        private double _giaThucDon;

        public QuanLyThucDon()
        {
        }

        public QuanLyThucDon(int idThucDon, string tenThucDon, string thucDonDanhMuc, double giaThucDon)
        {
            _idThucDon = idThucDon;
            _tenThucDon = tenThucDon;
            _thucDonDanhMuc = thucDonDanhMuc;
            _giaThucDon = giaThucDon;
        }
        public int IdThucDon { get => _idThucDon; set => _idThucDon = value; }
        public string TenThucDon { get => _tenThucDon; set => _tenThucDon = value; }
        public string ThucDonDanhMuc { get => _thucDonDanhMuc; set => _thucDonDanhMuc = value; }
        public double GiaThucDon { get => _giaThucDon; set => _giaThucDon = value; }
    }

}
