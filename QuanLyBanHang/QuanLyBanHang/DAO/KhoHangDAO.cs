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
    public class KhoHangDAO
    {
        public static List<KhoHangDTO> LayDanhSachKhoHang()
        {
            List<KhoHangDTO> lst = new List<KhoHangDTO>();

            DataProvider p = new DataProvider();
            p.Connect();
            SqlDataReader r = p.GetReader("sp_LayTatCaKhoHang", CommandType.StoredProcedure);

            KhoHangDTO kh = null;
            while ((r.Read()))
            {
                kh = new KhoHangDTO();
                kh.MaKho = Convert.ToInt32(r[0]);
                kh.TenKho = r[1].ToString();
                kh.NVQuanLy = Convert.ToInt32(r[2]);
                kh.NguoiLienHe = r[3].ToString();
                kh.DiaChi = r[4].ToString();
                kh.DienThoai = r[5].ToString();
                kh.Fax = r[6].ToString();
                kh.Email = r[7].ToString();
                kh.DienGiai = r[8].ToString();
                kh.ConQuanLy = Convert.ToBoolean(r[9]);
                lst.Add(kh);
            }

            p.Disconnect();
            return lst;
        }
        public static int LayMaKhoMoiNhat()
        {
            DataProvider p = new DataProvider();
            p.Connect();

            SqlParameter pMaKho = new SqlParameter("@MaKho", SqlDbType.Int);
            pMaKho.Direction = ParameterDirection.Output;

            p.ExecuteNonQuery("sp_LayMaKhoMoiNhat", CommandType.StoredProcedure, pMaKho);
            p.Disconnect();
            return Convert.ToInt32(pMaKho.Value);
        }

        public static bool ThemKhoHang(KhoHangDTO kh)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter p1 = new SqlParameter("@TenKho", SqlDbType.NVarChar, 255) { Value = kh.TenKho };
            SqlParameter p2 = new SqlParameter("@NVQuanLy", SqlDbType.Int) { Value = kh.NVQuanLy };
            SqlParameter p3 = new SqlParameter("@NguoiLienHe", SqlDbType.NVarChar, 255) { Value = kh.NguoiLienHe };
            SqlParameter p4 = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 255) { Value = kh.DiaChi };
            SqlParameter p5 = new SqlParameter("@DienThoai", SqlDbType.Char, 20) { Value = kh.DienThoai };
            SqlParameter p6 = new SqlParameter("@Fax", SqlDbType.Char, 20) { Value = kh.Fax };
            SqlParameter p7 = new SqlParameter("@Email", SqlDbType.Char, 255) { Value = kh.Email };
            SqlParameter p8 = new SqlParameter("@DienGiai", SqlDbType.NVarChar, 255) { Value = kh.DienGiai };
            SqlParameter p9 = new SqlParameter("@ConQuanLy", SqlDbType.Bit) { Value = kh.ConQuanLy };

            int n = p.ExecuteNonQuery("sp_ThemKhoHang", CommandType.StoredProcedure, p1, p2, p3, p4, p5, p6, p7, p8,
            p9);

            p.Disconnect();
            if (n == 0)
            {
                return false;
            }
            return true;
        }

        public static void SuaKhoHang(KhoHangDTO kh)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter p0 = new SqlParameter("@MaKho", SqlDbType.Int) { Value = kh.MaKho };
            SqlParameter p1 = new SqlParameter("@TenKho", SqlDbType.NVarChar, 255) { Value = kh.TenKho };
            SqlParameter p2 = new SqlParameter("@NVQuanLy", SqlDbType.Int) { Value = kh.NVQuanLy };
            SqlParameter p3 = new SqlParameter("@NguoiLienHe", SqlDbType.NVarChar, 255) { Value = kh.NguoiLienHe };
            SqlParameter p4 = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 255) { Value = kh.DiaChi };
            SqlParameter p5 = new SqlParameter("@DienThoai", SqlDbType.Char, 20) { Value = kh.DienThoai };
            SqlParameter p6 = new SqlParameter("@Fax", SqlDbType.Char, 20) { Value = kh.Fax };
            SqlParameter p7 = new SqlParameter("@Email", SqlDbType.Char, 255) { Value = kh.Email };
            SqlParameter p8 = new SqlParameter("@DienGiai", SqlDbType.NVarChar, 255) { Value = kh.DienGiai };
            SqlParameter p9 = new SqlParameter("@ConQuanLy", SqlDbType.Bit) { Value = kh.ConQuanLy };

            p.ExecuteNonQuery("sp_SuaKhoHang", CommandType.StoredProcedure, p0, p1, p2, p3, p4, p5, p6, p7,
            p8, p9);

            p.Disconnect();
        }

        public static void XoaKhoHang(KhoHangDTO khXoa)
        {
            DataProvider p = new DataProvider();
            p.Connect();

            p.ExecuteNonQuery("sp_XoaKhoHang", CommandType.StoredProcedure, new SqlParameter("@MaKho", SqlDbType.Int) { Value = khXoa.MaKho });

            p.Disconnect();
        }

        public static bool ThemHangHoaVaoTungKho(int MaHangHoa)
        {
            DataProvider p = new DataProvider();
            p.Connect();

            SqlParameter pMaHangHoa = new SqlParameter("@MaHangHoa", SqlDbType.Int) { Value = MaHangHoa };

            int n = p.ExecuteNonQuery("sp_ThemHangHoaVaoKho", CommandType.StoredProcedure, pMaHangHoa);

            p.Disconnect();
            if (n == 0)
            {
                return false;
            }
            return true;
        }

        public static bool ThemTatCaHangHoaVaoKho(int MaKho)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter pMaKho = new SqlParameter("@MaKho", SqlDbType.Int) { Value = MaKho };
            int n = p.ExecuteNonQuery("sp_ThemTatCaHangHoaVaoKho", CommandType.StoredProcedure, pMaKho);
            p.Disconnect();
            if (n == 0)
            {
                return false;
            }
            return true;
        }

        public static DataTable LayHangHoaTheoKho(int MaKho)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            DataTable dt = new DataTable();
            SqlParameter p1 = new SqlParameter("@MaKho", SqlDbType.Int) { Value = MaKho };
            dt = p.SL("sp_LayHangHoaTheoKHo", CommandType.StoredProcedure, p1);

            p.Disconnect();
            return dt;
        }

        public static DataTable XemTonKho()
        {
            DataProvider p = new DataProvider();
            p.Connect();

            DataTable dt = p.SL("sp_XemTonKho", CommandType.StoredProcedure);

            p.Disconnect();
            return dt;

        }
        public static DataTable XemTonKhoTheoKho(int MaKho)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter p1 = new SqlParameter("@MaKho", SqlDbType.Int) { Value = MaKho };
            DataTable dt = p.SL("sp_XemTonKhoTheoKho", CommandType.StoredProcedure, p1);
            p.Disconnect();
            return dt;
        }
    }
}
