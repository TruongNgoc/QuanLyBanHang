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
    public class KhuVucDAO
    {
        public static List<KhuVucDTO> LayToanBoKhuVuc()
        {
            List<KhuVucDTO> lst = new List<KhuVucDTO>();

            DataProvider p = new DataProvider();
            p.Connect();
            SqlDataReader r = p.GetReader("sp_LayTatCaKhuVuc", CommandType.StoredProcedure);

            KhuVucDTO kv = null;
            while ((r.Read()))
            {
                kv = new KhuVucDTO();
                kv.MaKhuVuc = Convert.ToInt32(r[0]);
                kv.TenKhuVuc = r[1].ToString();
                kv.GhiChu = r[2].ToString();
                kv.ConQuanLy = Convert.ToBoolean(r[3]);
                lst.Add(kv);
            }

            p.Disconnect();
            return lst;
        }
        public static void ThemKhuVuc(KhuVucDTO kv)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@tenkv", SqlDbType.NVarChar, 255) { Value = kv.TenKhuVuc },
                new SqlParameter("@ghichu", SqlDbType.NVarChar, 1000) { Value = kv.GhiChu },
                new SqlParameter("@conquanly", SqlDbType.Bit) { Value = kv.ConQuanLy }
            };
            p.ExecuteNonQuery("sp_ThemKhuVuc", CommandType.StoredProcedure, para);
            p.Disconnect();
        }
        public static int SuaKhuVuc(KhuVucDTO kv)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@makv", SqlDbType.Int) { Value = kv.MaKhuVuc },
                new SqlParameter("@tenkv", SqlDbType.NVarChar, 255) { Value = kv.TenKhuVuc },
                new SqlParameter("@ghichu", SqlDbType.NVarChar, 1000) { Value = kv.GhiChu },
                new SqlParameter("@conquanly", SqlDbType.Bit) { Value = kv.ConQuanLy }
            };
            int n = p.ExecuteNonQuery("sp_SuaKhuVuc", CommandType.StoredProcedure, para);
            p.Disconnect();
            return n;
        }

        public static int XoaKhuVuc(int makv)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter[] para = new SqlParameter[] { new SqlParameter("@makv", SqlDbType.Int) { Value = makv } };
            int n = p.ExecuteNonQuery("sp_XoaKhuVuc", CommandType.StoredProcedure, para);
            p.Disconnect();
            return n;
        }
    }
}
