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
    public class NhanVienDAO
    {
        public static List<NhanVienDTO> LayToanBoNhanVien()
        {
            List<NhanVienDTO> lst = new List<NhanVienDTO>();
            DataProvider p = new DataProvider();
            p.Connect();
            SqlDataReader r = p.GetReader("sp_LayTatCaNhanVien", CommandType.StoredProcedure);
            NhanVienDTO nv = null;
            while ((r.Read()))
            {
                nv = new NhanVienDTO();
                nv.MaNhanVien = Convert.ToInt32(r[0]);
                nv.HoTen = r[1].ToString();
                nv.ChucVu = r[2].ToString();
                nv.DiaChi = r[3].ToString();
                nv.Email = r[4].ToString();
                nv.DienThoai = r[5].ToString();
                nv.DiDong = r[6].ToString();
                // kiểm tra xem có dữ liệu không? 
                if (r[7].ToString()!=null)
                {
                    nv.BoPhan = Convert.ToInt32(r[7]);
                }
                if (r[8].ToString() != null)
                {
                    nv.QuanLy = Convert.ToInt32(r[8]);
                }
                nv.ConQuanLy = Convert.ToBoolean(r[9]);
                lst.Add(nv);
            }
            p.Disconnect();
            return lst;
        }

        public static bool ThemNhanVien(NhanVienDTO nv)
        {
            DataProvider p = new DataProvider();
            p.Connect();

            SqlParameter p1 = new SqlParameter("@HoTen", SqlDbType.NVarChar, 255) { Value = nv.HoTen };
            SqlParameter p2 = new SqlParameter("@ChucVu", SqlDbType.NVarChar, 255) { Value = nv.ChucVu };
            SqlParameter p3 = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 255) { Value = nv.DiaChi };
            SqlParameter p4 = new SqlParameter("@Email", SqlDbType.Char, 255) { Value = nv.Email };
            SqlParameter p5 = new SqlParameter("@DienThoai", SqlDbType.Char, 20) { Value = nv.DienThoai };
            SqlParameter p6 = new SqlParameter("@DiDong", SqlDbType.NVarChar, 20) { Value = nv.DiDong };
            SqlParameter p7 = new SqlParameter("@BoPhan", SqlDbType.Int) { Value = nv.BoPhan };
            SqlParameter p8 = new SqlParameter("@QuanLy", SqlDbType.Int) { Value = nv.QuanLy };
            SqlParameter p9 = new SqlParameter("@ConQuanLy", SqlDbType.Bit) { Value = nv.ConQuanLy };
            int n = p.ExecuteNonQuery("sp_ThemNhanVien", CommandType.StoredProcedure, p1, p2, p3, p4, p5, p6, p7, p8,
            p9);

            p.Disconnect();
            if (n == 0)
            {
                return false;
            }
            return true;
        }
        public static bool SuaNhanVien(NhanVienDTO nv)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter p0 = new SqlParameter("@MaNhanVien", SqlDbType.Int) { Value = nv.MaNhanVien };
            SqlParameter p1 = new SqlParameter("@HoTen", SqlDbType.NVarChar, 255) { Value = nv.HoTen };
            SqlParameter p2 = new SqlParameter("@ChucVu", SqlDbType.NVarChar, 255) { Value = nv.ChucVu };
            SqlParameter p3 = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 255) { Value = nv.DiaChi };
            SqlParameter p4 = new SqlParameter("@Email", SqlDbType.Char, 255) { Value = nv.Email };
            SqlParameter p5 = new SqlParameter("@DienThoai", SqlDbType.Char, 20) { Value = nv.DienThoai };
            SqlParameter p6 = new SqlParameter("@DiDong", SqlDbType.NVarChar, 20) { Value = nv.DiDong };
            SqlParameter p7 = new SqlParameter("@BoPhan", SqlDbType.Int) { Value = nv.BoPhan };
            SqlParameter p8 = new SqlParameter("@QuanLy", SqlDbType.Int) { Value = nv.QuanLy };
            SqlParameter p9 = new SqlParameter("@ConQuanLy", SqlDbType.Bit) { Value = nv.ConQuanLy };
            int n = p.ExecuteNonQuery("sp_SuaNhanVien", CommandType.StoredProcedure, p0, p1, p2, p3, p4, p5, p6, p7,
            p8, p9);

            p.Disconnect();
            if (n == 0)
            {
                return false;
            }
            return true;
        }

        public static bool XoaNhanVien(NhanVienDTO nv)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter p0 = new SqlParameter("@MaNhanVien", SqlDbType.Int) { Value = nv.MaNhanVien };
            int n = p.ExecuteNonQuery("sp_XoaNhanVien", CommandType.StoredProcedure, p0);

            p.Disconnect();
            if (n == 0)
            {
                return false;
            }
            return true;
        }
    }
}
