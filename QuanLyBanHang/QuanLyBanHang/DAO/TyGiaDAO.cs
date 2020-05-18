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
    public class TyGiaDAO
    {
        public static List<TyGiaDTO> LoadTatCaTyGia()
        {
            List<TyGiaDTO> ltg = new List<TyGiaDTO>();
            TyGiaDTO tg = null;
            DataProvider p = new DataProvider();
            p.Connect();
            SqlDataReader r = p.GetReader("sp_LayTatCaTyGia", CommandType.StoredProcedure);
            while (r.Read())
            {
                tg = new TyGiaDTO();
                tg.MaTyGia = Convert.ToInt32(r[0]);
                tg.TenTyGia = r[1].ToString();
                tg.TyGiaQuyDoi = Convert.ToDouble(r[2]);
                tg.ConQuanLy = Convert.ToBoolean(r[3]);
                ltg.Add(tg);
            }
            p.Disconnect();
            return ltg;
        }
        public static int ThemTyGia(TyGiaDTO tg)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@tentygia", SqlDbType.NVarChar, 50) { Value = tg.TenTyGia },
                new SqlParameter("@tygiaquydoi", SqlDbType.Float) { Value = tg.TyGiaQuyDoi },
                new SqlParameter("@conquanly", SqlDbType.Bit) { Value = tg.ConQuanLy }
            };
            int n = p.ExecuteNonQuery("sp_ThemTyGia", CommandType.StoredProcedure, para);
            p.Disconnect();
            return n;
        }
        public static int SuaTyGia(TyGiaDTO tg)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@matg", SqlDbType.Int) { Value = tg.MaTyGia },
                new SqlParameter("@tentg", SqlDbType.NVarChar, 50) { Value = tg.TenTyGia },
                new SqlParameter("@tygiaquydoi", SqlDbType.Float) { Value = tg.TyGiaQuyDoi },
                new SqlParameter("@conquanly", SqlDbType.Bit) { Value = tg.ConQuanLy }
            };
            int n = p.ExecuteNonQuery("sp_SuaTyGia", CommandType.StoredProcedure, para);
            p.Disconnect();
            return n;
        }
        public static int XoaTyGia(int matg)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter[] para = new SqlParameter[] { new SqlParameter("@matg", SqlDbType.Int) { Value = matg } };
            int n = p.ExecuteNonQuery("sp_XoaTyGia", CommandType.StoredProcedure, para);
            p.Disconnect();
            return n;
        }
    }
}
