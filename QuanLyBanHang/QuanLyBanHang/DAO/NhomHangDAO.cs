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
    public class NhomHangDAO
    {
        public static List<NhomHangDTO> LoadNhomHang()
        {
            List<NhomHangDTO> lnh = new List<NhomHangDTO>();
            NhomHangDTO nh = default(NhomHangDTO);
            DataProvider p = new DataProvider();
            p.Connect();
            SqlDataReader r = p.GetReader("sp_LayTatCaNhomHang", CommandType.StoredProcedure);
            while (r.Read())
            {
                nh = new NhomHangDTO();
                nh.MaNhomHang = Convert.ToInt32(r[0]);
                nh.TenNhomHang = Convert.ToString(r[1].ToString());
                nh.GhiChu = Convert.ToString(r[2].ToString());
                nh.ConQuanLy = Convert.ToBoolean(r[3]);
                lnh.Add(nh);
            }
            p.Disconnect();
            return lnh;
        }
        public static void ThemNhomHang(NhomHangDTO nh)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@tennh", SqlDbType.NVarChar, 50) {Value = nh.TenNhomHang},
                    new SqlParameter("@ghichu", SqlDbType.NVarChar, 255) {Value = nh.GhiChu},
                    new SqlParameter("@conquanly", SqlDbType.Bit) {Value = nh.ConQuanLy}
                };
            p.ExecuteNonQuery("sp_ThemNhomHang", CommandType.StoredProcedure, para);
            p.Disconnect();
        }
        public static void SuaNhomHang(NhomHangDTO nh)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@manh", SqlDbType.Int) {Value = nh.MaNhomHang},
                    new SqlParameter("@tennh", SqlDbType.NVarChar, 50) {Value = nh.TenNhomHang},
                    new SqlParameter("@ghichu", SqlDbType.NVarChar, 255) {Value = nh.GhiChu},
                    new SqlParameter("@conquanly", SqlDbType.Bit) {Value = nh.ConQuanLy}
                };
            p.ExecuteNonQuery("sp_SuaNhomHang", CommandType.StoredProcedure, para);
            p.Disconnect();
        }
        public static void XoaNhomHang(int index)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter para = new SqlParameter("@manh", SqlDbType.Int) { Value = index };
            p.ExecuteNonQuery("sp_XoaNhomHang", CommandType.StoredProcedure, para);
            p.Disconnect();
        }
    }
}
