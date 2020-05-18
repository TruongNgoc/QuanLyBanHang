using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class TyGiaDTO
    {
        int _MaTyGia;
        public int MaTyGia
        {
            get { return _MaTyGia; }
            set { _MaTyGia = value; }
        }

        string _TenTyGia;
        public string TenTyGia
        {
            get { return _TenTyGia; }
            set { _TenTyGia = value; }
        }

        double _TyGiaQuyDoi;
        public double TyGiaQuyDoi
        {
            get { return _TyGiaQuyDoi; }
            set { _TyGiaQuyDoi = value; }
        }

        bool _ConQuanLy;
        public bool ConQuanLy
        {
            get { return _ConQuanLy; }
            set { _ConQuanLy = value; }
        }

    }
}
