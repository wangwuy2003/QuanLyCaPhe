using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe
{
    internal class QuanLyDanhMuc
    {
        private string _idDanhMuc;
        private string _tenDanhMuc;

        public QuanLyDanhMuc()
        {
        }

        public QuanLyDanhMuc(string idDanhMuc, string tenDanhMuc)
        {
            _idDanhMuc = idDanhMuc;
            _tenDanhMuc = tenDanhMuc;
        }

        public string IdDanhMuc { get => _idDanhMuc; set => _idDanhMuc = value; }
        public string TenDanhMuc { get => _tenDanhMuc; set => _tenDanhMuc = value; }
    }
}
