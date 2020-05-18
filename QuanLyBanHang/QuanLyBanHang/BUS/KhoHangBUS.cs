using QuanLyBanHang.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.DAO;
using System.Data;
using System.ComponentModel;

namespace QuanLyBanHang.BUS
{
    public class KhoHangBUS
    {
        public static List<KhoHangDTO> LayToanBoKhoHang()
        {
            return KhoHangDAO.LayDanhSachKhoHang();
        }

//        private BindingList<KhachHangDTO> lstChiTiet;

        public static bool ThemKhoHang(KhoHangDTO kh)
        {
            if (string.IsNullOrEmpty(kh.TenKho))
            {
                return false;
            }
            bool test = KhoHangDAO.ThemKhoHang(kh);
            if (test == true)
            {
                int MaKho = KhoHangDAO.LayMaKhoMoiNhat();
                KhoHangDAO.ThemTatCaHangHoaVaoKho(MaKho);
            }
            return test;
        }

        public static int SuaKhohang(KhoHangDTO kh)
        {
            if (string.IsNullOrEmpty(kh.TenKho))
            {
                return -1;
            }
            KhoHangDAO.SuaKhoHang(kh);
            return 0;
        }

        public static int XoaKhoHang(KhoHangDTO khXoa)
        {
            KhoHangDAO.XoaKhoHang(khXoa);
            return 0;
        }
        public static bool ThemHangHoaVaoTungKho(int MaHangHoa)
        {
            bool test = KhoHangDAO.ThemHangHoaVaoTungKho(MaHangHoa);
            return test;
        }
        public static bool ThemTatCaHangHoaVaoKho(int MaKho)
        {
            bool test = KhoHangDAO.ThemTatCaHangHoaVaoKho(MaKho);
            return test;
        }

        public static DataTable LayHangHoaTheoKho(int MaKho)
        {
            return KhoHangDAO.LayHangHoaTheoKho(MaKho);
        }

        public static DataTable XemTonKho()
        {
            return KhoHangDAO.XemTonKho();

        }

        public static DataTable XemTonKhoTheoKho(int MaKho)
        {
            return KhoHangDAO.XemTonKhoTheoKho(MaKho);
        }
    }
}
