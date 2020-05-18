using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class NhomHangDTO
    {
        int _MaNhomHang;
        public int MaNhomHang
        {
            get { return _MaNhomHang; }
            set { _MaNhomHang = value; }
        }

        string _TenNhomHang;
        public string TenNhomHang
        {
            get { return _TenNhomHang; }
            set { _TenNhomHang = value; }
        }

        string _GhiChu;
        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }
        bool _ConQuanLy;
        public bool ConQuanLy
        {
            get { return _ConQuanLy; }
            set { _ConQuanLy = value; }
        }
    }
}
