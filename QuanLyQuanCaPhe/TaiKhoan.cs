﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe
{
    internal class TaiKhoan
    {
        private string tenTaiKhoan;
        private string matKhau;

        public TaiKhoan()
        {
        }

        public TaiKhoan(string tenTaiKhoan, string matKhau)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
        }
    }
}
