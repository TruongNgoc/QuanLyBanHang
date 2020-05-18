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
    public class HangHoaDAO
    {
        public static List<HangHoaDTO> LayTatCaHangHoa()
        {
            List<HangHoaDTO> lst = new List<HangHoaDTO>();

            DataProvider p = new DataProvider();
            p.Connect();
            SqlDataReader r = p.GetReader("sp_LayTatCaHangHoa", CommandType.StoredProcedure);

            HangHoaDTO hh = null;
            while ((r.Read()))
            {
                hh = new HangHoaDTO();
                hh.MaHangHoa = Convert.ToInt32(r[0]);
                hh.TenHangHoa = r[1].ToString();
                hh.LoaiHangHoa = Convert.ToInt32(r[2]);
                hh.KhoMacDinh = Convert.ToInt32(r[3]);
                hh.PhanLoai = Convert.ToInt32(r[4]);
                hh.DonVi = Convert.ToInt32(r[5]);
                hh.XuatXu = r[6].ToString();
                hh.TonKhoToiThieu = Convert.ToInt32(r[7]);
                hh.TonKho = Convert.ToInt32(r[8]);
                hh.NhaCungCap = Convert.ToInt32(r[9]);
                hh.GiaMua = Convert.ToDouble(r[10]);
                hh.GiaBan = Convert.ToDouble(r[11]);
                hh.ConQuanLy = Convert.ToBoolean(r[12]);

                lst.Add(hh);
            }
            p.Disconnect();
            return lst;
        }
        public static List<HangHoaDTO> _LayTatCaHangHoa()
        {
            List<HangHoaDTO> lst = new List<HangHoaDTO>();

            DataProvider p = new DataProvider();
            p.Connect();
            SqlDataReader r = p.GetReader("LayTatCaHangHoa", CommandType.StoredProcedure);

            HangHoaDTO hh = null;
            while ((r.Read()))
            {
                hh = new HangHoaDTO();
                hh.MaHangHoa = Convert.ToInt32(r[0]);
                hh.TenHangHoa = r[1].ToString();
                hh.LoaiHangHoa = Convert.ToInt32(r[2]);
                hh.KhoMacDinh = Convert.ToInt32(r[3]);
                hh.PhanLoai = Convert.ToInt32(r[4]);
                hh.DonVi = Convert.ToInt32(r[5]);
                hh.XuatXu = r[6].ToString();
                hh.TonKhoToiThieu = Convert.ToInt32(r[7]);
                hh.TonKho = Convert.ToInt32(r[8]);
                hh.NhaCungCap = Convert.ToInt32(r[9]);
                hh.GiaMua = Convert.ToDouble(r[10]);
                hh.GiaBan = Convert.ToDouble(r[11]);
                hh.ConQuanLy = Convert.ToBoolean(r[12]);

                lst.Add(hh);
            }
            p.Disconnect();
            return lst;
        }

        public static List<LoaiHangDTO> LayTatCaLoaiHangHoa()
        {
            List<LoaiHangDTO> lst = new List<LoaiHangDTO>();

            DataProvider p = new DataProvider();
            p.Connect();
            SqlDataReader r = p.GetReader("sp_LayTatCaLoaiHang", CommandType.StoredProcedure);

            LoaiHangDTO hh = null;
            while ((r.Read()))
            {
                hh = new LoaiHangDTO();
                hh.MaLoaiHH = Convert.ToInt32(r[0]);
                hh.TenLoaiHH = r[1].ToString();
                lst.Add(hh);
            }
            p.Disconnect();
            return lst;
        }

        public static bool ThemHangHoa(HangHoaDTO hh)
        {
            DataProvider p = new DataProvider();
            p.Connect();

            SqlParameter p1 = new SqlParameter("@TenHangHoa", SqlDbType.NVarChar, 255) { Value = hh.TenHangHoa };
            SqlParameter p2 = new SqlParameter("@LoaiHangHoa", SqlDbType.Int) { Value = hh.LoaiHangHoa };
            SqlParameter p3 = new SqlParameter("@KhoMacDinh", SqlDbType.Int) { Value = hh.KhoMacDinh };
            SqlParameter p4 = new SqlParameter("@PhanLoai", SqlDbType.Int) { Value = hh.PhanLoai };
            SqlParameter p5 = new SqlParameter("@DonVi", SqlDbType.Int) { Value = hh.DonVi };
            SqlParameter p6 = new SqlParameter("@XuatXu", SqlDbType.NVarChar, 255) { Value = hh.XuatXu };
            SqlParameter p7 = new SqlParameter("@TonKhoToiThieu", SqlDbType.Int) { Value = hh.TonKhoToiThieu };
            SqlParameter p8 = new SqlParameter("@TonKho", SqlDbType.Int) { Value = hh.TonKho };
            SqlParameter p9 = new SqlParameter("@NhaCungCap", SqlDbType.Int) { Value = hh.NhaCungCap };
            SqlParameter p10 = new SqlParameter("@GiaMua", SqlDbType.Float) { Value = hh.GiaMua };
            SqlParameter p11 = new SqlParameter("@GiaBan", SqlDbType.Float) { Value = hh.GiaBan };
            SqlParameter p12 = new SqlParameter("@ConQuanLy", SqlDbType.Bit) { Value = hh.ConQuanLy };

            int n = p.ExecuteNonQuery("sp_ThemHangHoa", CommandType.StoredProcedure, p1, p2, p3, p4, p5, p6, p7, p8,
            p9, p10, p11, p12);

            p.Disconnect();
            if (n == 0)
            {
                return false;
            }
            return true;

        }
        public static int LayMaHangHoaMoiNhat()
        {
            DataProvider p = new DataProvider();
            p.Connect();

            SqlParameter p1 = new SqlParameter("@MaHangHoa", SqlDbType.Int);
            p1.Direction = ParameterDirection.Output;

            p.ExecuteNonQuery("sp_LayMaHangHoaMoiNhat", CommandType.StoredProcedure, p1);
            p.Disconnect();

            return Convert.ToInt32(p1.Value);
        }

        public static bool SuaHangHoa(HangHoaDTO hh)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter p0 = new SqlParameter("@MaHangHoa", SqlDbType.Int) { Value = hh.MaHangHoa };
            SqlParameter p1 = new SqlParameter("@TenHangHoa", SqlDbType.NVarChar, 255) { Value = hh.TenHangHoa };
            SqlParameter p2 = new SqlParameter("@LoaiHangHoa", SqlDbType.Int) { Value = hh.LoaiHangHoa };
            SqlParameter p3 = new SqlParameter("@KhoMacDinh", SqlDbType.Int) { Value = hh.KhoMacDinh };
            SqlParameter p4 = new SqlParameter("@PhanLoai", SqlDbType.Int) { Value = hh.PhanLoai };
            SqlParameter p5 = new SqlParameter("@DonVi", SqlDbType.Int) { Value = hh.DonVi };
            SqlParameter p6 = new SqlParameter("@XuatXu", SqlDbType.NVarChar, 255) { Value = hh.XuatXu };
            SqlParameter p7 = new SqlParameter("@TonKhoToiThieu", SqlDbType.Int) { Value = hh.TonKhoToiThieu };
            SqlParameter p8 = new SqlParameter("@TonKho", SqlDbType.Int) { Value = hh.TonKho };
            SqlParameter p9 = new SqlParameter("@NhaCungCap", SqlDbType.Int) { Value = hh.NhaCungCap };
            SqlParameter p10 = new SqlParameter("@GiaMua", SqlDbType.Float) { Value = hh.GiaMua };
            SqlParameter p11 = new SqlParameter("@GiaBan", SqlDbType.Float) { Value = hh.GiaBan };
            SqlParameter p12 = new SqlParameter("@ConQuanLy", SqlDbType.Bit) { Value = hh.ConQuanLy };

            int n = p.ExecuteNonQuery("sp_SuaHangHoa", CommandType.StoredProcedure, p0, p1, p2, p3, p4, p5, p6, p7,
            p8, p9, p10, p11, p12);

            p.Disconnect();
            if (n == 0)
            {
                return false;
            }
            return true;

        }

        public static bool XoaHangHoa(HangHoaDTO hh)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter p0 = new SqlParameter("@MaHangHoa", SqlDbType.Int) { Value = hh.MaHangHoa };
            int n = p.ExecuteNonQuery("sp_XoaHangHoa", CommandType.StoredProcedure, p0);
            p.Disconnect();
            if (n == 0)
            {
                return false;
            }
            return true;
        }

        public static HangHoaDTO LayThongTinHangHoaCanMuaTheoMa(int MaHangHoa)
        {
            HangHoaDTO hh = new HangHoaDTO();

            DataProvider p = new DataProvider();
            p.Connect();

            SqlParameter p1 = new SqlParameter("@MaHangHoa", SqlDbType.Int) { Value = MaHangHoa };
            SqlDataReader r = p.GetReader("sp_LayThongTinHangHoaCanMuaTheoMa", CommandType.StoredProcedure, p1);

            while((r.Read()))
            {
                hh.MaHangHoa = Convert.ToInt32(r[0]);
                hh.TenHangHoa = r[1].ToString();
                hh.DonVi = Convert.ToInt32(r[2]);
                hh.GiaMua = float.Parse(r[3].ToString());
            }

            p.Disconnect();
            return hh;
        }

    }
}
