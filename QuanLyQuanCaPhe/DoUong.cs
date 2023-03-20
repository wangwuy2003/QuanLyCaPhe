using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe
{
    internal class DoUong
    {
        private string tenDoUong;
        private float giaBan;

        public DoUong()
        {
        }

        public DoUong(string tenDoUong, float giaBan)
        {
            this.tenDoUong = tenDoUong;
            this.giaBan = giaBan;
        }
    }
}
