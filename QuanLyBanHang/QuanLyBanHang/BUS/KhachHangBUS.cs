using QuanLyBanHang.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.DAO;

namespace QuanLyBanHang.BUS
{
    public class KhachHangBUS
    {
        public static int ThemKhachHang(KhachHangDTO kh)
        {
            if (kh.HoTen == "")
            {
                return -1;
            }
            KhachHangDAO.ThemKhachHang(kh);
            return 0;
        }
        public static int SuaKhachHang(KhachHangDTO kh)
        {
            if (kh.HoTen == "")
            {
                return -1;
            }
            KhachHangDAO.SuaKhachHang(kh);

            return 0;
        }

        public static void XoaKhachHang(KhachHangDTO khXoa)
        {
            KhachHangDAO.XoaKhachHang(khXoa);
        }

        public static KhachHangDTO LayChiTietKhachHang(int MaKH)
        {
            KhachHangDTO khachang = null;
            List<KhachHangDTO> lst = KhachHangDAO.LayDanhSachKhachHang();
            foreach (KhachHangDTO kh in lst)
            {
                if (kh.MaKH == MaKH)
                {
                    khachang = kh;
                    break;
                }
            }
            return khachang;
        }
        public static List<KhachHangDTO> LayDanhSachKhachHang()
        {
            List<KhachHangDTO> lKH = KhachHangDAO.LayDanhSachKhachHang();
            return lKH;
        }
    }
}
