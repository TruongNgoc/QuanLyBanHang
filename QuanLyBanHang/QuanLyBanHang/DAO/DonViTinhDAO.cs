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
    public class DonViTinhDAO
    {
        public static List<DonViTinhDTO> LayToanBoDonVi()
        {
            List<DonViTinhDTO> lst = new List<DonViTinhDTO>();

            DataProvider p = new DataProvider();
            p.Connect();
            SqlDataReader r = p.GetReader("sp_LayTatCaDonVi", CommandType.StoredProcedure);

            DonViTinhDTO dv = null;
            while ((r.Read()))
            {
                dv = new DonViTinhDTO();
                dv.MaDV = Convert.ToInt32(r[0]);
                dv.TenDonVi = r[1].ToString();
                dv.GhiChu = r[2].ToString();
                dv.ConQuanLy = Convert.ToBoolean(r[3]);
                lst.Add(dv);
            }
            p.Disconnect();
            return lst;
        }

        public static bool ThemDonVi(DonViTinhDTO dv)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter p1 = new SqlParameter("@TenDonVi", SqlDbType.NVarChar, 255) { Value = dv.TenDonVi };
            SqlParameter p2 = new SqlParameter("@GhiChu", SqlDbType.NVarChar, 255) { Value = dv.GhiChu };
            SqlParameter p3 = new SqlParameter("@ConQuanLy", SqlDbType.Bit) { Value = dv.ConQuanLy };
            int n = p.ExecuteNonQuery("sp_ThemDonVi", CommandType.StoredProcedure, p1, p2, p3);
            p.Disconnect();
            if (n == 0)
            {
                return false;
            }
            return true;

        }

        public static bool SuaDonVi(DonViTinhDTO dv)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter p0 = new SqlParameter("@MaDV", SqlDbType.Int) { Value = dv.MaDV };
            SqlParameter p1 = new SqlParameter("@TenDonVi", SqlDbType.NVarChar, 255) { Value = dv.TenDonVi };
            SqlParameter p2 = new SqlParameter("@GhiChu", SqlDbType.NVarChar, 255) { Value = dv.GhiChu };
            SqlParameter p3 = new SqlParameter("@ConQuanLy", SqlDbType.Bit) { Value = dv.ConQuanLy };
            int n = p.ExecuteNonQuery("sp_SuaDonVi", CommandType.StoredProcedure, p0, p1, p2, p3);
            p.Disconnect();
            if (n == 0)
            {
                return false;
            }
            return true;
        }

        public static bool XoaDonVi(DonViTinhDTO dv)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter p0 = new SqlParameter("@MaDV", SqlDbType.Int) { Value = dv.MaDV };
            int n = p.ExecuteNonQuery("sp_XoaDonVi", CommandType.StoredProcedure, p0);
            p.Disconnect();
            if (n == 0)
            {
                return false;
            }
            return true;
        }
    }
}
