using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class BoPhanDTO
    {
        private int _MaBoPhan;
        public int MaBoPhan
        {
            get { return _MaBoPhan; }
            set { _MaBoPhan = value; }
        }
        private string _TenBoPhan;
        public string TenBoPhan
        {

            get { return _TenBoPhan; }
            set { _TenBoPhan = value; }
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
