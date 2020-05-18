using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class KhuVucDTO
    {
        private int _MaKhuVuc;
        public int MaKhuVuc
        {
            get { return _MaKhuVuc; }
            set { _MaKhuVuc = value; }
        }
        private string _TenKhuVuc;
        public string TenKhuVuc
        {
            get { return _TenKhuVuc; }
            set { _TenKhuVuc = value; }
        }
        private string _GhiChu;
        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }
        private bool _ConQuanLy;
        public bool ConQuanLy
        {
            get { return _ConQuanLy; }
            set { _ConQuanLy = value; }
        }
    }
}