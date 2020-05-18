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
    public class TaiKhoan_DAO
    {

        //chuoi ket noi backup & restore he thong
        public void Backup(string ten, string diachi)
        {
            SqlConnection conn = null;
            conn = DataProvider.Connection;
            conn.Open();
            string a = null;
            a = diachi + ten;
            var sCommand = "BACKUP DATABASE [QuanLyBanHang] TO DISK = N'" + a + "' WITH COPY_ONLY";
            using (SqlCommand sqlCmd = new SqlCommand(sCommand, conn))
            {
                sqlCmd.ExecuteNonQuery();
            }
            conn.Close();
        }
        public void Restore(string a)
        {
            SqlConnection conn = null;
            conn = DataProvider.Connection;
            conn.Open();
            var sCommand = "USE Master ALTER DATABASE [QuanLyBanHang] SET Single_User WITH Rollback Immediate Restore database [QuanLyBanHang] FROM disk = N'" + a + "' WITH REPLACE ALTER DATABASE [QuanLyBanHang] SET Multi_User";
            using (SqlCommand sqlCmd = new SqlCommand(sCommand, conn))
            {
                sqlCmd.ExecuteNonQuery();
            }
            conn.Close();
        }
        public static bool KiemTraDangNhap(string tk, string mk)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter p1 = new SqlParameter("@tk", SqlDbType.VarChar, 50) { Value = tk };
            SqlParameter p2 = new SqlParameter("@mk", SqlDbType.VarChar, 50) { Value = mk };
            SqlParameter p3 = new SqlParameter("@check", SqlDbType.Bit);
            p3.Direction = ParameterDirection.Output;
            p.ExecuteNonQuery("sp_KiemTraDangNhap", CommandType.StoredProcedure, p1, p2, p3);
            bool check = Convert.ToBoolean(p3.Value);
            p.Disconnect();
            if (check)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int ThayDoiMatKhau(string a, string b, string c, string d)
        {
            DataProvider p = new DataProvider();
            SqlConnection cn = null;
 //           int value = 0;
            cn = DataProvider.Connection;
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = cn;
            sqlComm.CommandText = "ThayDoiMatKhau";
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.AddWithValue("ten", a);
            sqlComm.Parameters.AddWithValue("matkhaucu", b);
            sqlComm.Parameters.AddWithValue("matkhaumoi", c);
            sqlComm.Parameters.AddWithValue("xacnhanmatkhaumoi", d);
            SqlParameter avgPriceParam = new SqlParameter("@a", SqlDbType.Int);
            avgPriceParam.Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add(avgPriceParam);
            p.Connect();
            SqlDataReader reader = sqlComm.ExecuteReader();
            int avgPrice = int.Parse(avgPriceParam.Value.ToString());
            return avgPrice;
        }
        public static List<TaiKhoan_DTO> LayHetNguoiDung()
        {
            List<TaiKhoan_DTO> lst = new List<TaiKhoan_DTO>();

            DataProvider p = new DataProvider();
            p.Connect();
            SqlDataReader r = p.GetReader("sp_LayHetNguoiDung", CommandType.StoredProcedure);

            TaiKhoan_DTO nd = null;
            while ((r.Read()))
            {
                nd = new TaiKhoan_DTO();
                nd.MaNguoiDung = Convert.ToInt32(r[0]);
                nd.Ten = r[1].ToString();
                nd.TaiKhoan = r[2].ToString();
                nd.MatKhau = r[3].ToString();
                nd.XacNhan = r[4].ToString();
                nd.MaVaiTro = Convert.ToInt32(r[5]);
                nd.GhiChu = r[6].ToString();
                lst.Add(nd);
            }
            p.Disconnect();
            return lst;
        }

        public static List<VaiTroDTO> LayHetVaiTro()
        {
            List<VaiTroDTO> lst = new List<VaiTroDTO>();
            DataProvider p = new DataProvider();
            p.Connect();
            SqlDataReader r = p.GetReader("sp_LayHetVaiTro", CommandType.StoredProcedure);

            VaiTroDTO vt = null;
            while ((r.Read()))
            {
                vt = new VaiTroDTO();
                vt.MaVaiTro = Convert.ToInt32(r[0]);
                vt.Ten = r[1].ToString();
                vt.PhanQuyen = Convert.ToBoolean(r[2]);
                vt.DoiMatKhau = Convert.ToBoolean(r[3]);
                vt.NhatKyHeThong = Convert.ToBoolean(r[4]);
                vt.SaoLuu = Convert.ToBoolean(r[5]);
                vt.PhucHoi = Convert.ToBoolean(r[6]);
                vt.KhuVuc = Convert.ToBoolean(r[7]);
                vt.KhachHang = Convert.ToBoolean(r[8]);
                vt.NhaCungCap = Convert.ToBoolean(r[9]);
                vt.KhoHang = Convert.ToBoolean(r[10]);
                vt.DonViTinh = Convert.ToBoolean(r[11]);
                vt.NhomHang = Convert.ToBoolean(r[12]);
                vt.HangHoa = Convert.ToBoolean(r[13]);
                vt.TyGia = Convert.ToBoolean(r[14]);
                vt.BoPhan = Convert.ToBoolean(r[15]);
                vt.NhanVien = Convert.ToBoolean(r[16]);
                vt.MuaHang = Convert.ToBoolean(r[17]);
                vt.BanHang = Convert.ToBoolean(r[18]);
                vt.TonKho = Convert.ToBoolean(r[19]);
                vt.ChuyenKho = Convert.ToBoolean(r[20]);
                vt.ThuTien = Convert.ToBoolean(r[21]);
                vt.TraTien = Convert.ToBoolean(r[22]);
                vt.BaoCaoKhoHang = Convert.ToBoolean(r[23]);
                vt.BaoCaoBanHang = Convert.ToBoolean(r[24]);
                lst.Add(vt);
            }
            p.Disconnect();
            return lst;
        }
        public static VaiTroDTO LayVaiTroTheoTaiKhoan(string TaiKhoan)
        {

            DataProvider p = new DataProvider();
            p.Connect();
            SqlDataReader r = p.GetReader("sp_LayVaiTroTheoTaiKhoan", CommandType.StoredProcedure, new SqlParameter("@TaiKhoan", SqlDbType.VarChar, 50) { Value = TaiKhoan });

            VaiTroDTO vt = new VaiTroDTO();
            while ((r.Read()))
            {
                vt.MaVaiTro = Convert.ToInt32(r[0]);
                vt.Ten = r[1].ToString();
                vt.PhanQuyen = Convert.ToBoolean(r[2]);
                vt.DoiMatKhau = Convert.ToBoolean(r[3]);
                vt.NhatKyHeThong = Convert.ToBoolean(r[4]);
                vt.SaoLuu = Convert.ToBoolean(r[5]);
                vt.PhucHoi = Convert.ToBoolean(r[6]);
                vt.KhuVuc = Convert.ToBoolean(r[7]);
                vt.KhachHang = Convert.ToBoolean(r[8]);
                vt.NhaCungCap = Convert.ToBoolean(r[9]);
                vt.KhoHang = Convert.ToBoolean(r[10]);
                vt.DonViTinh = Convert.ToBoolean(r[11]);
                vt.NhomHang = Convert.ToBoolean(r[12]);
                vt.HangHoa = Convert.ToBoolean(r[13]);
                vt.TyGia = Convert.ToBoolean(r[14]);
                vt.BoPhan = Convert.ToBoolean(r[15]);
                vt.NhanVien = Convert.ToBoolean(r[16]);
                vt.MuaHang = Convert.ToBoolean(r[17]);
                vt.BanHang = Convert.ToBoolean(r[18]);
                vt.TonKho = Convert.ToBoolean(r[19]);
                vt.ChuyenKho = Convert.ToBoolean(r[20]);
                vt.ThuTien = Convert.ToBoolean(r[21]);
                vt.TraTien = Convert.ToBoolean(r[22]);
                vt.BaoCaoKhoHang = Convert.ToBoolean(r[23]);
                vt.BaoCaoBanHang = Convert.ToBoolean(r[24]);
            }
            p.Disconnect();
            return vt;
        }
        public static bool ThemNguoiDung(TaiKhoan_DTO nd)
        {
            DataProvider p = new DataProvider();
            p.Connect();

            SqlParameter p1 = new SqlParameter("@Ten", SqlDbType.NVarChar, 255) { Value = nd.Ten };
            SqlParameter p2 = new SqlParameter("@TaiKhoan", SqlDbType.VarChar, 50) { Value = nd.TaiKhoan };
            SqlParameter p3 = new SqlParameter("@MatKhau", SqlDbType.VarChar, 50) { Value = nd.MatKhau };
            SqlParameter p4 = new SqlParameter("@VaiTro", SqlDbType.Int, 255) { Value = nd.MaVaiTro };
            SqlParameter p5 = new SqlParameter("@GhiChu", SqlDbType.NVarChar, 50) { Value = nd.GhiChu };

            int n = p.ExecuteNonQuery("sp_ThemNguoiDung", CommandType.StoredProcedure, p1, p2, p3, p4, p5);
            p.Disconnect();
            if (n == 0)
            {
                return false;
            }
            return true;

        }

        public static bool SuaNguoiDung(TaiKhoan_DTO nd)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter p0 = new SqlParameter("@MaNguoiDung", SqlDbType.Int) { Value = nd.MaNguoiDung };
            SqlParameter p1 = new SqlParameter("@Ten", SqlDbType.NVarChar, 255) { Value = nd.Ten };
            SqlParameter p2 = new SqlParameter("@TaiKhoan", SqlDbType.VarChar, 50) { Value = nd.TaiKhoan };
            SqlParameter p3 = new SqlParameter("@MatKhau", SqlDbType.VarChar, 50) { Value = nd.MatKhau };
            SqlParameter p4 = new SqlParameter("@VaiTro", SqlDbType.Int, 255) { Value = nd.MaVaiTro };
            SqlParameter p5 = new SqlParameter("@GhiChu", SqlDbType.NVarChar, 50) { Value = nd.GhiChu };
            int n = p.ExecuteNonQuery("sp_SuaNguoiDung", CommandType.StoredProcedure, p0, p1, p2, p3, p4, p5);
            p.Disconnect();
            if (n == 0)
            {
                return false;
            }
            return true;
        }

        public static bool XoaNguoiDung(TaiKhoan_DTO nd)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter p0 = new SqlParameter("@MaNguoiDung", SqlDbType.Int) { Value = nd.MaNguoiDung };
            int n = p.ExecuteNonQuery("sp_XoaNguoiDung", CommandType.StoredProcedure, p0);
            p.Disconnect();
            if (n == 0)
            {
                return false;
            }
            return true;
        }

        public static bool ThemVaiTro(VaiTroDTO vt)
        {
            DataProvider p = new DataProvider();
            p.Connect();

            SqlParameter p1 = new SqlParameter("@Ten", SqlDbType.NVarChar, 255) { Value = vt.Ten };
            SqlParameter p2 = new SqlParameter("@PhanQuyen", SqlDbType.Bit) { Value = vt.PhanQuyen };
            SqlParameter p3 = new SqlParameter("@DoiMatKhau", SqlDbType.Bit) { Value = vt.DoiMatKhau };
            SqlParameter p4 = new SqlParameter("@NhatKyHeThong", SqlDbType.Bit) { Value = vt.NhatKyHeThong };
            SqlParameter p5 = new SqlParameter("@SaoLuu", SqlDbType.Bit) { Value = vt.SaoLuu };
            SqlParameter p6 = new SqlParameter("@PhucHoi", SqlDbType.Bit) { Value = vt.PhucHoi };
            SqlParameter p7 = new SqlParameter("@KhuVuc", SqlDbType.Bit) { Value = vt.KhuVuc };
            SqlParameter p8 = new SqlParameter("@KhachHang", SqlDbType.Bit) { Value = vt.KhachHang };
            SqlParameter p9 = new SqlParameter("@NhaCungCap", SqlDbType.Bit) { Value = vt.NhaCungCap };
            SqlParameter p10 = new SqlParameter("@KhoHang", SqlDbType.Bit) { Value = vt.KhoHang };
            SqlParameter p11 = new SqlParameter("@DonViTinh", SqlDbType.Bit) { Value = vt.DonViTinh };
            SqlParameter p12 = new SqlParameter("@NhomHang", SqlDbType.Bit) { Value = vt.NhomHang };
            SqlParameter p13 = new SqlParameter("@HangHoa", SqlDbType.Bit) { Value = vt.HangHoa };
            SqlParameter p14 = new SqlParameter("@TyGia", SqlDbType.Bit) { Value = vt.TyGia };
            SqlParameter p15 = new SqlParameter("@BoPhan", SqlDbType.Bit) { Value = vt.BoPhan };
            SqlParameter p16 = new SqlParameter("@NhanVien", SqlDbType.Bit) { Value = vt.NhanVien };
            SqlParameter p17 = new SqlParameter("@MuaHang", SqlDbType.Bit) { Value = vt.MuaHang };
            SqlParameter p18 = new SqlParameter("@BanHang", SqlDbType.Bit) { Value = vt.BanHang };
            SqlParameter p19 = new SqlParameter("@TonKho", SqlDbType.Bit) { Value = vt.TonKho };
            SqlParameter p20 = new SqlParameter("@ChuyenKho", SqlDbType.Bit) { Value = vt.ChuyenKho };
            SqlParameter p21 = new SqlParameter("@ThuTien", SqlDbType.Bit) { Value = vt.ThuTien };
            SqlParameter p22 = new SqlParameter("@TraTien", SqlDbType.Bit) { Value = vt.TraTien };
            SqlParameter p23 = new SqlParameter("@BaoCaoKhohang", SqlDbType.Bit) { Value = vt.BaoCaoKhoHang };
            SqlParameter p24 = new SqlParameter("@BaoCaoBanHang", SqlDbType.Bit) { Value = vt.BaoCaoBanHang };

            int n = p.ExecuteNonQuery("sp_ThemVaiTro", CommandType.StoredProcedure, p1, p2, p3, p4, p5, p6, p7, p8,
            p9, p10, p11, p12, p13, p14, p15, p16, p17, p18,
            p19, p20, p21, p22, p23, p24);

            p.Disconnect();
            if (n == 0)
            {
                return false;
            }
            return true;
        }

        public static bool SuaVaiTro(VaiTroDTO vt)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter p0 = new SqlParameter("@MaVaiTro", SqlDbType.Int) { Value = vt.MaVaiTro };
            SqlParameter p1 = new SqlParameter("@Ten", SqlDbType.NVarChar, 255) { Value = vt.Ten };
            SqlParameter p2 = new SqlParameter("@PhanQuyen", SqlDbType.Bit) { Value = vt.PhanQuyen };
            SqlParameter p3 = new SqlParameter("@DoiMatKhau", SqlDbType.Bit) { Value = vt.DoiMatKhau };
            SqlParameter p4 = new SqlParameter("@NhatKyHeThong", SqlDbType.Bit) { Value = vt.NhatKyHeThong };
            SqlParameter p5 = new SqlParameter("@SaoLuu", SqlDbType.Bit) { Value = vt.SaoLuu };
            SqlParameter p6 = new SqlParameter("@PhucHoi", SqlDbType.Bit) { Value = vt.PhucHoi };
            SqlParameter p7 = new SqlParameter("@KhuVuc", SqlDbType.Bit) { Value = vt.KhuVuc };
            SqlParameter p8 = new SqlParameter("@KhachHang", SqlDbType.Bit) { Value = vt.KhachHang };
            SqlParameter p9 = new SqlParameter("@NhaCungCap", SqlDbType.Bit) { Value = vt.NhaCungCap };
            SqlParameter p10 = new SqlParameter("@KhoHang", SqlDbType.Bit) { Value = vt.KhoHang };
            SqlParameter p11 = new SqlParameter("@DonViTinh", SqlDbType.Bit) { Value = vt.DonViTinh };
            SqlParameter p12 = new SqlParameter("@NhomHang", SqlDbType.Bit) { Value = vt.NhomHang };
            SqlParameter p13 = new SqlParameter("@HangHoa", SqlDbType.Bit) { Value = vt.HangHoa };
            SqlParameter p14 = new SqlParameter("@TyGia", SqlDbType.Bit) { Value = vt.TyGia };
            SqlParameter p15 = new SqlParameter("@BoPhan", SqlDbType.Bit) { Value = vt.BoPhan };
            SqlParameter p16 = new SqlParameter("@NhanVien", SqlDbType.Bit) { Value = vt.NhanVien };
            SqlParameter p17 = new SqlParameter("@MuaHang", SqlDbType.Bit) { Value = vt.MuaHang };
            SqlParameter p18 = new SqlParameter("@BanHang", SqlDbType.Bit) { Value = vt.BanHang };
            SqlParameter p19 = new SqlParameter("@TonKho", SqlDbType.Bit) { Value = vt.TonKho };
            SqlParameter p20 = new SqlParameter("@ChuyenKho", SqlDbType.Bit) { Value = vt.ChuyenKho };
            SqlParameter p21 = new SqlParameter("@ThuTien", SqlDbType.Bit) { Value = vt.ThuTien };
            SqlParameter p22 = new SqlParameter("@TraTien", SqlDbType.Bit) { Value = vt.TraTien };
            SqlParameter p23 = new SqlParameter("@BaoCaoKhohang", SqlDbType.Bit) { Value = vt.BaoCaoKhoHang };
            SqlParameter p24 = new SqlParameter("@BaoCaoBanHang", SqlDbType.Bit) { Value = vt.BaoCaoBanHang };

            int n = p.ExecuteNonQuery("sp_SuaVaiTro", CommandType.StoredProcedure, p0, p1, p2, p3, p4, p5, p6, p7,
            p8, p9, p10, p11, p12, p13, p14, p15, p16, p17,
            p18, p19, p20, p21, p22, p23, p24);

            p.Disconnect();
            if (n == 0)
            {
                return false;
            }
            return true;
        }

        public static bool XoaVaiTro(VaiTroDTO vt)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter p0 = new SqlParameter("@MaVaiTro", SqlDbType.Int) { Value = vt.MaVaiTro };
            int n = p.ExecuteNonQuery("sp_XoaVaiTro", CommandType.StoredProcedure, p0);
            p.Disconnect();
            if (n == 0)
            {
                return false;
            }
            return true;
        }
    }
}
