using QuanLyBanHang.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.DAO;


namespace QuanLyBanHang.BUS
{
    public class NhomHangBUS
    {
        public static List<NhomHangDTO> LoadNhomHang()
        {
            List<NhomHangDTO> lnh = new List<NhomHangDTO>();
            lnh = NhomHangDAO.LoadNhomHang();
            return lnh;
        }
        public static bool KiemTraThem(NhomHangDTO nh)
        {
            if (nh.TenNhomHang == "")
            {
                return false;

            }
            NhomHangDAO.ThemNhomHang(nh);
            return true;
        }
        public static bool KiemTraSua(NhomHangDTO nh)
        {
            if (nh.TenNhomHang == "")
            {
                return false;

            }
            NhomHangDAO.SuaNhomHang(nh);
            return true;
        }
        public static bool KiemTraXoa(int manh)
        {
            NhomHangDAO.XoaNhomHang(manh);
            return true;
        }
    }

}
