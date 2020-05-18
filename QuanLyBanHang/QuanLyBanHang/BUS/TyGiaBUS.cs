using QuanLyBanHang.BUS;
using QuanLyBanHang.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class TyGiaBUS
    {
        public static bool KiemTraThem(TyGiaDTO tg)
        {
            if (tg.TenTyGia == "" || TyGiaDAO.ThemTyGia(tg) == 0)
            {
                return false;
            }

            return true;
        }
        public static bool KiemTraSua(TyGiaDTO tg)
        {
            if (tg.TenTyGia == "" || TyGiaDAO.SuaTyGia(tg) == 0)
            {
                return false;
            }

            return true;
        }
        public static bool KiemTraXoa(int matg)
        {
            if (TyGiaDAO.XoaTyGia(matg) == 0)
            {
                return false;
            }
            return true;
        }

        public static List<TyGiaDTO> LoadTatCaTyGia()
        {
            List<TyGiaDTO> ltg = TyGiaDAO.LoadTatCaTyGia();
            return ltg;
        }
    }
}
