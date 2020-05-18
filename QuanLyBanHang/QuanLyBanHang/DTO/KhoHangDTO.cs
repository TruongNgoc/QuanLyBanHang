using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class KhoHangDTO
    {
        private int _MaKho;
        public int MaKho
        {
            get { return _MaKho; }
            set { _MaKho = value; }
        }
        private string _TenKho;
        public string TenKho
        {
            get { return _TenKho; }
            set { _TenKho = value; }
        }
        private int _NVQuanLy;
        public int NVQuanLy
        {
            get { return _NVQuanLy; }
            set { _NVQuanLy = value; }
        }
        private string _NguoiLienHe;
        public string NguoiLienHe
        {
            get { return _NguoiLienHe; }
            set { _NguoiLienHe = value; }
        }

        private string _DiaChi;
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private string _DienThoai;
        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }
        private string _Fax;
        public string Fax
        {
            get { return _Fax; }
            set { _Fax = value; }
        }
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _DienGiai;
        public string DienGiai
        {
            get { return _DienGiai; }
            set { _DienGiai = value; }
        }
        private bool _ConQuanLy;
        public bool ConQuanLy
        {
            get { return _ConQuanLy; }
            set { _ConQuanLy = value; }
        }
    }
}
