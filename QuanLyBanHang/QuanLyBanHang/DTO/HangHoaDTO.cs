using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class HangHoaDTO
    {
        private int _MaHangHoa;
        public int MaHangHoa
        {
            get { return _MaHangHoa; }
            set { _MaHangHoa = value; }
        }
        private string _TenHangHoa;
        public string TenHangHoa
        {
            get { return _TenHangHoa; }
            set { _TenHangHoa = value; }
        }
        private int _LoaiHangHoa;
        public int LoaiHangHoa
        {
            get { return _LoaiHangHoa; }
            set { _LoaiHangHoa = value; }
        }
        private int _KhoMacDinh;
        public int KhoMacDinh
        {
            get { return _KhoMacDinh; }
            set { _KhoMacDinh = value; }
        }
        private int _PhanLoai;
        public int PhanLoai
        {
            get { return _PhanLoai; }
            set { _PhanLoai = value; }
        }
        private int _DonVi;
        public int DonVi
        {
            get { return _DonVi; }
            set { _DonVi = value; }
        }
        private string _XuatXu;
        public string XuatXu
        {
            get { return _XuatXu; }
            set { _XuatXu = value; }
        }
        private int _TonKhoToiThieu;
        public int TonKhoToiThieu
        {
            get { return _TonKhoToiThieu; }
            set { _TonKhoToiThieu = value; }
        }
        private int _TonKho;
        public int TonKho
        {
            get { return _TonKho; }
            set { _TonKho = value; }
        }
        private int _NhaCungCap;
        public int NhaCungCap
        {
            get { return _NhaCungCap; }
            set { _NhaCungCap = value; }
        }
        private double _GiaMua;
        public double GiaMua
        {
            get { return _GiaMua; }
            set { _GiaMua = value; }
        }
        private double _GiaBan;
        public double GiaBan
        {
            get { return _GiaBan; }
            set { _GiaBan = value; }
        }
        private bool _ConQuanLy;
        public bool ConQuanLy
        {
            get { return _ConQuanLy; }
            set { _ConQuanLy = value; }
        }

        public void LayDuLieuCanThiet(int MaHangHoa, string TenHangHoa, int LoaiHangHoa, int PhanLoai, int DonVi, int TonKhoToiThieu, int TonKho, double GiaMua, double GiaBan, bool ConQuanLy)
        {
            _MaHangHoa = MaHangHoa;
            _TenHangHoa = TenHangHoa;
            _LoaiHangHoa = LoaiHangHoa;
            _PhanLoai = PhanLoai;
            _DonVi = DonVi;
            _TonKhoToiThieu = TonKhoToiThieu;
            _TonKho = TonKho;
            _GiaMua = GiaMua;
            _GiaBan = GiaBan;
            _ConQuanLy = ConQuanLy;
        }

        public void LayDuLieu(int MaHangHoa, string TenHangHoa, int LoaiHangHoa, int KhoMacDinh, int PhanLoai, int DonVi,
    string XuatXu, int TonKhoToiThieu, int TonKho, int NhaCungCap, double GiaMua, double GiaBan, bool ConQuanLy)
        {
            _MaHangHoa = MaHangHoa;
            _TenHangHoa = TenHangHoa;
            _LoaiHangHoa = LoaiHangHoa;
            _KhoMacDinh = KhoMacDinh;
            _PhanLoai = PhanLoai;
            _DonVi = DonVi;
            _XuatXu = XuatXu;
            _TonKhoToiThieu = TonKhoToiThieu;
            _TonKho = TonKho;
            _NhaCungCap = NhaCungCap;
            _GiaMua = GiaMua;
            _GiaBan = GiaBan;
            _ConQuanLy = ConQuanLy;
        }
    }

}