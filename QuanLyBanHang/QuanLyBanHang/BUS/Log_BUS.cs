using QuanLyBanHang.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.DAO;

namespace QuanLyBanHang.BUS
{
    public class Log_BUS
    {
        public static List<Log_DTO> KiemTraLoad()
        {
            return Log_DAO.LoadNhatKyHoatDong();
        }
        public static void ThemNhatKy(string cn, string hd)
        {
            Log_DTO nk = new Log_DTO();
            nk.TenND = ID_Class.ID;
            nk.ChucNang = cn;
            nk.HanhDong = hd;
            nk.ThoiGian = DateTime.Now.ToString();
            Log_DAO.ThemNhatKy(nk);
        }
        public static bool XoaNhatKy(string tg)
        {
            return Log_DAO.XoaNhatKy(tg);
        }
        public static bool XoaHetNhatKy()
        {
            return Log_DAO.XoaTatCa();
        }
    }
}
