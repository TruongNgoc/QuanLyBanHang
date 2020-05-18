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
    public class BoPhanDAO
    {
        public static List<BoPhanDTO> LayToanBoBoPhan()
        {
            List<BoPhanDTO> lst = new List<BoPhanDTO>();

            DataProvider p = new DataProvider();
            p.Connect();
            SqlDataReader r = p.GetReader("sp_LayTatCaBoPhan", CommandType.StoredProcedure);

            BoPhanDTO bp ;
            while (r.Read())
            {
                bp = new BoPhanDTO();
                bp.MaBoPhan = Convert.ToInt32(r[0]);
                bp.TenBoPhan = r[1].ToString();
                bp.GhiChu = r[2].ToString();
                bp.ConQuanLy = Convert.ToBoolean(r[3]);

                lst.Add(bp);
            }

            p.Disconnect();
            return lst;
        }

        public static bool ThemBoPhan(BoPhanDTO bophanmoi)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter p1 = new SqlParameter("@TenBoPhan", SqlDbType.NVarChar, 255) { Value = bophanmoi.TenBoPhan };
            SqlParameter p2 = new SqlParameter("@GhiChu", SqlDbType.NVarChar, 255) { Value = bophanmoi.GhiChu };
            SqlParameter p3 = new SqlParameter("@ConQuanLy", SqlDbType.Bit) { Value = bophanmoi.ConQuanLy };

            int n = p.ExecuteNonQuery("sp_ThemBoPhan", CommandType.StoredProcedure, p1, p2, p3);

            p.Disconnect();
            if (n == 0)
            {
                return false;
            }
            return true;
        }

        public static bool SuaBoPhan(BoPhanDTO BoPhanSua)
        {

            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter p0 = new SqlParameter("@MaBoPhan", SqlDbType.Int) { Value = BoPhanSua.MaBoPhan };
            SqlParameter p1 = new SqlParameter("@TenBoPhan", SqlDbType.NVarChar, 255) { Value = BoPhanSua.TenBoPhan };
            SqlParameter p2 = new SqlParameter("@GhiChu", SqlDbType.NVarChar, 255) { Value = BoPhanSua.GhiChu };
            SqlParameter p3 = new SqlParameter("@ConQuanLy", SqlDbType.Bit) { Value = BoPhanSua.ConQuanLy };

            int n = p.ExecuteNonQuery("sp_SuaBoPhan", CommandType.StoredProcedure, p0, p1, p2, p3);

            p.Disconnect();
            if (n == 0)
            {
                return false;
            }
            return true;
        }

        public static bool XoaBoPhan(BoPhanDTO bophanxoa)
        {
            DataProvider p = new DataProvider();
            p.Connect();

            SqlParameter p0 = new SqlParameter("@MaBoPhan", SqlDbType.Int) { Value = bophanxoa.MaBoPhan };

            int n = p.ExecuteNonQuery("sp_XoaBoPhan", CommandType.StoredProcedure, p0);

            p.Disconnect();
            if (n == 0)
            {
                return false;
            }
            return true;
        }
    }

}
