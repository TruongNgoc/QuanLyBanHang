using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class LoaiHangDTO
    {
        private int _MaLoaiHH;
        public int MaLoaiHH
        {
            get { return _MaLoaiHH; }
            set { _MaLoaiHH = value; }
        }
        private string _TenLoaiHH;
        public string TenLoaiHH
        {
            get { return _TenLoaiHH; }
            set { _TenLoaiHH = value; }
        }
    }
}
