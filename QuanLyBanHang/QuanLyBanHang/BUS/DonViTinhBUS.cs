using QuanLyBanHang.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.DAO;

namespace QuanLyBanHang.BUS
{
    public class DonViTinhBUS
    {
        public static List<DonViTinhDTO> LayTatCaDonVi()
        {
            return DonViTinhDAO.LayToanBoDonVi();
        }

        public static bool ThemDonVi(DonViTinhDTO dv)
        {
            if (string.IsNullOrEmpty(dv.TenDonVi))
            {
                return false;
            }

            bool test = DonViTinhDAO.ThemDonVi(dv);
            return test;
        }

        public static bool SuaDonVi(DonViTinhDTO dv)
        {
            if (string.IsNullOrEmpty(dv.TenDonVi))
            {
                return false;
            }
            bool test = DonViTinhDAO.SuaDonVi(dv);
            return test;
        }

        public static bool XoaDonVi(DonViTinhDTO dv)
        {
            return DonViTinhDAO.XoaDonVi(dv);
        }
    }

}
