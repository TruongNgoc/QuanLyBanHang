using QuanLyBanHang.DAO;
using QuanLyBanHang.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class BoPhanBUS
    {
        public static List<BoPhanDTO> LayToanBoBoPhan()
        {
            return BoPhanDAO.LayToanBoBoPhan();
        }

        public static int ThemBoPhan(BoPhanDTO bophanmoi)
        {
            if (string.IsNullOrEmpty(bophanmoi.TenBoPhan))
            {
                return -1;
            }

            bool test = BoPhanDAO.ThemBoPhan(bophanmoi);
            if (test == false)
            {
                return -1;
            }
            return 0;
        }

        public static bool SuaBoPhan(BoPhanDTO BoPhanSua)
        {
            if (string.IsNullOrEmpty(BoPhanSua.TenBoPhan))
            {
                return false;
            }

            bool test = BoPhanDAO.SuaBoPhan(BoPhanSua);
            if (test == false)
            {
                return false;
            }
            return true;
        }

        public static bool XoaKhoHang(BoPhanDTO bophanxoa)
        {

            bool test = BoPhanDAO.XoaBoPhan(bophanxoa);
            if (test == false)
            {
                return false;
            }
            return true;
        }

        public static bool XoaNhanVien(NhanVienDTO nv)
        {
            bool test = NhanVienDAO.XoaNhanVien(nv);
            if (test == false)
            {
                return false;
            }
            return true;
        }
    }
}
