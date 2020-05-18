using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class TaiKhoan_DTO
    {
        private int _MaNguoiDung;
        public int MaNguoiDung
        {
            get { return _MaNguoiDung; }
            set { _MaNguoiDung = value; }
        }
        private string _Ten;
        public string Ten
        {
            get { return _Ten; }
            set { _Ten = value; }
        }
        private string _TaiKhoan;
        public string TaiKhoan
        {
            get { return _TaiKhoan; }
            set { _TaiKhoan = value; }
        }
        private string _MatKhau;
        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }
        private int _MaVaiTro;
        public int MaVaiTro
        {
            get { return _MaVaiTro; }
            set { _MaVaiTro = value; }
        }
        private string _XacNhan;
        public string XacNhan
        {
            get { return _XacNhan; }
            set { _XacNhan = value; }
        }
        private string _GhiChu;
        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }
    }
}
