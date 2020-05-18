using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class NhanVienDTO
    {
        private int _MaNhanVien;
        public int MaNhanVien
        {

            get { return _MaNhanVien; }
            set { _MaNhanVien = value; }
        }
        private string _HoTen;
        public string HoTen
        {
            get { return _HoTen; }

            set { _HoTen = value; }
        }
        private string _ChucVu;
        public string ChucVu
        {
            get { return _ChucVu; }
            set { _ChucVu = value; }
        }
        private string _DiaChi;
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _DienThoai;
        private string _DiDong;
        private int _BoPhan;
        private int _QuanLy;
        private bool _ConQuanLy;
        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }
        public string DiDong
        {
            get { return _DiDong; }
            set { _DiDong = value; }
        }
        public int BoPhan
        {
            get { return _BoPhan; }

            set { _BoPhan = value; }
        }
        public int QuanLy
        {
            get { return _QuanLy; }
            set { _QuanLy = value; }
        }
        public bool ConQuanLy
        {
            get { return _ConQuanLy; }

            set { _ConQuanLy = value; }
        }
    }
}
