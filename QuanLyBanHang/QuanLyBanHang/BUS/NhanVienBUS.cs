using QuanLyBanHang.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.DAO;

namespace QuanLyBanHang.BUS
{
    public class NhanVienBUS
    {
        public static List<NhanVienDTO> LayToanBoNhanVien()
        {
            return NhanVienDAO.LayToanBoNhanVien();

        }
        public static bool ThemNhanVien(NhanVienDTO nv)
        {
            if (nv.HoTen == "")
            {
                return false;
            }

            if (nv.BoPhan.ToString() == null)
            {
                return false;
            }
            if (nv.QuanLy.ToString() == null)
            {
                return false;
            }

            bool test = NhanVienDAO.ThemNhanVien(nv);
            if (test == false)
            {
                return false;
            }
            return true;
        }

        public static bool SuaNhanVien(NhanVienDTO nv)
        {
            if (nv.HoTen == "")
            {
                return false;
            }

            if (nv.BoPhan.ToString()==null)
            {
                return false;
            }
            if (nv.QuanLy.ToString() == null)
            {
                return false;
            }

            bool test = NhanVienDAO.SuaNhanVien(nv);
            if (test == false)
            {
                return false;
            }
            return true;
        }
    }

}
