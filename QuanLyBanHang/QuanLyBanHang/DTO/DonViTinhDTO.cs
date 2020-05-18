using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class DonViTinhDTO
    {
        private int _MaDV;
        public int MaDV
        {
            get { return _MaDV; }
            set { _MaDV = value; }
        }

        private string _TenDonVi;
        public string TenDonVi
        {
            get { return _TenDonVi; }
            set { _TenDonVi = value; }
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
