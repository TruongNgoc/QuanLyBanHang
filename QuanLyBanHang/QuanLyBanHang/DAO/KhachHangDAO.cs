using QuanLyBanHang.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAO
{
    public class KhachHangDAO
    {
        public static void ThemKhachHang(KhachHangDTO kh)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            string sql = string.Format("insert KHACHHANG values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}','{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}','{17}', '{18}')", kh.HoTen, kh.DiaChi, kh.MaSoThue, kh.SoDiDong, kh.SoDienThoaiBan, kh.Email, kh.Fax, kh.Website, kh.SoTaiKhoan,
            kh.NganHang, kh.GioiHanNo, kh.ChietKhau, kh.NguoiLienHe, kh.NoHienTai, kh.NickYahoo, kh.LoaiKhachHang, kh.KhuVuc, kh.NickSkype, kh.ConQuanLy);
            p.ExecuteNonQuery(sql, CommandType.Text);

            p.Disconnect();
        }
        public static List<KhachHangDTO> LayDanhSachKhachHang()
        {
            List<KhachHangDTO> lKH = new List<KhachHangDTO>();
            DataProvider p = new DataProvider();
            p.Connect();
            SqlDataReader dr = p.GetReader("sp_ChonKhachHang", CommandType.StoredProcedure);
            KhachHangDTO kh = null;
            while (dr.Read())
            {
                kh = new KhachHangDTO();
                kh.MaKH = Convert.ToInt32(dr[0]);
                kh.HoTen = dr[1].ToString().TrimEnd();
                kh.DiaChi = dr[2].ToString().TrimEnd();
                kh.MaSoThue = dr[3].ToString().TrimEnd();
                kh.SoDiDong = dr[4].ToString().TrimEnd();
                kh.SoDienThoaiBan = dr[5].ToString().TrimEnd();
                kh.Email = dr[6].ToString().TrimEnd();
                kh.Fax = dr[7].ToString().TrimEnd();
                kh.Website = dr[8].ToString().TrimEnd();
                kh.SoTaiKhoan = dr[9].ToString().TrimEnd();
                kh.NganHang = dr[10].ToString().TrimEnd();
                kh.GioiHanNo = Convert.ToDouble(dr[11]);
                kh.ChietKhau = Convert.ToDouble(dr[12]);
                kh.NguoiLienHe = dr[13].ToString().TrimEnd();
                kh.NoHienTai = Convert.ToDouble(dr[14]);
                kh.NickYahoo = dr[15].ToString().TrimEnd();
                kh.LoaiKhachHang = Convert.ToInt32(dr[16]);
                kh.KhuVuc = Convert.ToInt32(dr[17]);
                kh.NickSkype = dr[18].ToString().TrimEnd();
                kh.ConQuanLy = Convert.ToBoolean(dr[19]);
                lKH.Add(kh);
            }
            p.Disconnect();
            return lKH;
        }

        public static void SuaKhachHang(KhachHangDTO kh)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            string sql = string.Format("update KHACHHANG set HoTen = '{0}', DiaChi = '{1}', MaSoThue = '{2}', SoDiDong = '{3}', SoDienThoaiBan = '{4}', Email = '{5}', Fax = '{6}', Website = '{7}', SoTaiKhoan = '{8}', NganHang = '{9}', GioiHanNo = '{10}', ChietKhau = '{11}', NguoiLenHe = '{12}', NoHienTai = '{13}', NickYahoo = '{14}', LoaiKhachHang = '{15}', KhuVuc = '{16}', NickSkype = '{17}', ConQuanLy = '{18}' where MaKH = '{19}'", kh.HoTen, kh.DiaChi, kh.MaSoThue, kh.SoDiDong, kh.SoDienThoaiBan, kh.Email, kh.Fax, kh.Website, kh.SoTaiKhoan,
            kh.NganHang, kh.GioiHanNo, kh.ChietKhau, kh.NguoiLienHe, kh.NoHienTai, kh.NickYahoo, kh.LoaiKhachHang, kh.KhuVuc, kh.NickSkype, kh.ConQuanLy,
            kh.MaKH);
            p.ExecuteNonQuery(sql, CommandType.Text);

            p.Disconnect();
        }

        public static void XoaKhachHang(KhachHangDTO khXoa)
        {
            DataProvider p = new DataProvider();
            p.Connect();

            string sql = string.Format("delete KHACHHANG where MaKH = {0}", khXoa.MaKH);
            p.ExecuteNonQuery(sql, CommandType.Text);

            p.Disconnect();
        }

    }
}
