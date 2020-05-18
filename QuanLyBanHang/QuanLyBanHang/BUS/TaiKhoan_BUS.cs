using QuanLyBanHang.BUS;
using QuanLyBanHang.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class TaiKhoan_BUS
    {
        TaiKhoan_DAO TK = new TaiKhoan_DAO();
//        static string username;
        public static bool KiemTraDangNhap(string tk, string mk)
        {
            return TaiKhoan_DAO.KiemTraDangNhap(tk, mk);
        }
        public int ThayDoiMatKhau(string a, string b, string c, string d)
        {
            return TK.ThayDoiMatKhau(a, b, c, d);
        }
        public static VaiTroDTO LayVaiTroTheoTaiKhoan(string TaiKhoan)
        {
            return TaiKhoan_DAO.LayVaiTroTheoTaiKhoan(TaiKhoan);
        }
        public static List<VaiTroDTO> LayHetVaiTro()
        {
            return TaiKhoan_DAO.LayHetVaiTro();
        }
        public static List<TaiKhoan_DTO> LayHetNguoiDung()
        {
            return TaiKhoan_DAO.LayHetNguoiDung();
        }
        public void Backup(string ten, string diachi)
        {
            TK.Backup(ten, diachi);
        }
        public void Restore(string a)
        {
            TK.Restore(a);
        }

        public static string LayTenNguoiDungCuaTaiKhoan(string tk)
        {
            List<TaiKhoan_DTO> lnd = LayHetNguoiDung();
            foreach (TaiKhoan_DTO nd in lnd)
            {
                if (nd.TaiKhoan == tk)
                {
                    return nd.Ten;
                }
            }
            return "";
        }

        public static string LayTenTKNguoiDung(string tk)
        {
            List<TaiKhoan_DTO> lnd = LayHetNguoiDung();
            foreach (TaiKhoan_DTO nd in lnd)
            {
                if (nd.TaiKhoan == tk)
                {
                    return nd.TaiKhoan;
                }
            }
            return "";
        }

        public static int ThemNguoiDung(TaiKhoan_DTO nd)
        {
            List<TaiKhoan_DTO> lst = TaiKhoan_BUS.LayHetNguoiDung();
            foreach (TaiKhoan_DTO n in lst)
            {
                if (n.TaiKhoan == nd.TaiKhoan)
                {
                    return -1;
                }
            }

            bool test = TaiKhoan_DAO.ThemNguoiDung(nd);
            if (test == false)
            {
                return -2;
            }
            return 0;
        }

        public static int SuaNguoiDung(TaiKhoan_DTO NguoiDungSua)
        {
            List<TaiKhoan_DTO> lst = TaiKhoan_BUS.LayHetNguoiDung();
            foreach (TaiKhoan_DTO n in lst)
            {
                if (n.MaNguoiDung != NguoiDungSua.MaNguoiDung && n.TaiKhoan == NguoiDungSua.TaiKhoan)
                {
                    return -1;
                }
            }

            bool test = TaiKhoan_DAO.SuaNguoiDung(NguoiDungSua);
            if (test == false)
            {
                return -2;
            }
            return 0;
        }

        public static bool XoaNguoiDung(TaiKhoan_DTO nd)
        {
            return TaiKhoan_DAO.XoaNguoiDung(nd);
        }

        public static bool ThemVaiTro(VaiTroDTO vt)
        {
            return TaiKhoan_DAO.ThemVaiTro(vt);

        }

        public static bool SuaVaiTro(VaiTroDTO vaiTroDTO)
        {
            return TaiKhoan_DAO.SuaVaiTro(vaiTroDTO);
        }

        public static bool XoaVaiTro(VaiTroDTO vt)
        {
            return TaiKhoan_DAO.XoaVaiTro(vt);
        }
    }
}
