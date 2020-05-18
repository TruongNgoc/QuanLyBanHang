using QuanLyBanHang.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.DAO;

namespace QuanLyBanHang.BUS
{
    public class HangHoaBUS
    {
        public static List<HangHoaDTO> LayToanBoHangHoa()
        {
            return HangHoaDAO.LayTatCaHangHoa();
        }
        public static List<LoaiHangDTO> LayToanBoLoaiHang()
        {
            return HangHoaDAO.LayTatCaLoaiHangHoa();
        }

        public static bool ThemHangHoa(HangHoaDTO hh)
        {
            if (string.IsNullOrEmpty(hh.TenHangHoa))
            {
                return false;
            }

            bool test = HangHoaDAO.ThemHangHoa(hh);
            if (test == true)
            {
                int MaHangHoa = 0;
                MaHangHoa = HangHoaDAO.LayMaHangHoaMoiNhat();
                KhoHangBUS.ThemHangHoaVaoTungKho(MaHangHoa);
            }
            return test;
        }

        public static bool SuaHangHoa(HangHoaDTO hh)
        {
            if (string.IsNullOrEmpty(hh.TenHangHoa))
            {
                return false;
            }
            bool test = HangHoaDAO.SuaHangHoa(hh);
            return test;
        }

        public static bool XoaKhoHang(HangHoaDTO hh)
        {
            return HangHoaDAO.XoaHangHoa(hh);
        }


        public static HangHoaDTO LayChiTietHangHoa(int MaHangHoa)
        {
            HangHoaDTO hanghoa = null;
            List<HangHoaDTO> lst = new List<HangHoaDTO>();
            lst = HangHoaDAO.LayTatCaHangHoa();
            foreach (HangHoaDTO hh in lst)
            {
                if (hh.MaHangHoa == MaHangHoa)
                {
                    hanghoa = hh;
                    break;
                }
            }
            return hanghoa;
        }

        public static HangHoaDTO LayThongTinHangHoaCanMuaTheoMa(int MaHangHoa)
        {
            return HangHoaDAO.LayThongTinHangHoaCanMuaTheoMa(MaHangHoa);
        }
    }

}
