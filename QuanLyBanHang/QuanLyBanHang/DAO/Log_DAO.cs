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
    public class Log_DAO
    {
        public static List<Log_DTO> LoadNhatKyHoatDong()
        {
            DataProvider p = new DataProvider();
            p.Connect();
            List<Log_DTO> lnk = new List<Log_DTO>();
            Log_DTO nk = null;
            SqlDataReader r = p.GetReader("sp_LoadLog", CommandType.StoredProcedure);
            while (r.Read())
            {
                nk = new Log_DTO();
                nk.Ma = Convert.ToInt32(r[0]);
                nk.TenND = r[1].ToString();
                nk.ChucNang = r[2].ToString();
                nk.HanhDong = r[3].ToString();
                nk.ThoiGian = r[4].ToString();
                lnk.Add(nk);
            }
            p.Disconnect();
            return lnk;
        }
        public static void ThemNhatKy(Log_DTO nk)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@tennd", SqlDbType.VarChar, 50) { Value = nk.TenND },
                new SqlParameter("@chucnang", SqlDbType.NVarChar, 255) { Value = nk.ChucNang },
                new SqlParameter("@hanhdong", SqlDbType.NVarChar, 255) { Value = nk.HanhDong },
                new SqlParameter("@thoigian", SqlDbType.VarChar, 50) { Value = nk.ThoiGian }
            };
            int n = p.ExecuteNonQuery("sp_ThemNhatKy", CommandType.StoredProcedure, para);
            p.Disconnect();
        }
        public static bool XoaNhatKy(string tg)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter para = new SqlParameter("@tg", SqlDbType.VarChar, 50) { Value = tg };
            int n = p.ExecuteNonQuery("sp_XoaNhatKy", CommandType.StoredProcedure, para);
            if (n == 0)
            {
                p.Disconnect();
                return false;
            }
            p.Disconnect();
            return true;
        }
        public static bool XoaTatCa()
        {
            DataProvider p = new DataProvider();
            p.Connect();
            int n = p.ExecuteNonQuery("sp_XoaHetNhatKy", CommandType.StoredProcedure);
            if (n == 0)
            {
                p.Disconnect();
                return false;
            }
            p.Disconnect();
            return true;
        }
    }
}
