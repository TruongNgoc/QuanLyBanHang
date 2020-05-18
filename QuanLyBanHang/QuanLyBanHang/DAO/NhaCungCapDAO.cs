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
    public class NhaCungCapDAO
    {

        public static int ThemNhaCungCap(NhaCungCapDTO ncc)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@tenncc", SqlDbType.NVarChar, 255) { Value = ncc.TenNhaPhanPhoi },
                new SqlParameter("@diachi", SqlDbType.NVarChar, 255) { Value = ncc.DiaChi },
                new SqlParameter("@masothue", SqlDbType.Char, 20) { Value = ncc.MaSoThue },
                new SqlParameter("@sodidong", SqlDbType.Char, 20) { Value = ncc.SoDiDong },
                new SqlParameter("@sodienthoaiban", SqlDbType.Char, 20) { Value = ncc.SoDienThoaiBan },
                new SqlParameter("@email", SqlDbType.Char, 255) { Value = ncc.Email },
                new SqlParameter("@fax", SqlDbType.Char, 20) { Value = ncc.Fax },
                new SqlParameter("@website", SqlDbType.Char, 255) { Value = ncc.Website },
                new SqlParameter("@sotaikhoan", SqlDbType.Char, 30) { Value = ncc.SoTaiKhoan },
                new SqlParameter("@nganhang", SqlDbType.NVarChar, 255) { Value = ncc.NganHang },
                new SqlParameter("@gioihanno", SqlDbType.Float) { Value = ncc.GioiHanNo },
                new SqlParameter("@chietkhau", SqlDbType.Float) { Value = ncc.ChietKhau },
                new SqlParameter("@nguoilienhe", SqlDbType.NVarChar, 255) { Value = ncc.NguoiLienHe },
                new SqlParameter("@chucvu", SqlDbType.NVarChar, 255) { Value = ncc.ChucVu },
                new SqlParameter("@nohientai", SqlDbType.Float) { Value = ncc.NoHienTai },
                new SqlParameter("@khuvuc", SqlDbType.Int) { Value = ncc.KhuVuc },
                new SqlParameter("@conquanly", SqlDbType.Bit) { Value = ncc.ConQuanLy }
            };
            // không biết có nên disconect trước không đây vì nếu đóg trước thì store không được thực hiện
             p.Disconnect();
            return p.ExecuteNonQuery("sp_ThemNhaCungCap", CommandType.StoredProcedure, para);

           // p.Disconnect();
        }

        public static List<NhaCungCapDTO> LayDanhSachNhaCungCap()
        {
            List<NhaCungCapDTO> lst = new List<NhaCungCapDTO>();

            DataProvider p = new DataProvider();
            p.Connect();
            SqlDataReader r = p.GetReader("sp_LayDuLieuNhaCungCap", CommandType.StoredProcedure);

            NhaCungCapDTO ncc = null;
            while ((r.Read()))
            {
                ncc = new NhaCungCapDTO();
                ncc.MaNhaCungCap = Convert.ToInt32(r[0]);
                ncc.TenNhaPhanPhoi = r[1].ToString();
                ncc.DiaChi = r[2].ToString();
                ncc.MaSoThue = r[3].ToString();
                ncc.SoDiDong = r[4].ToString();
                ncc.SoDienThoaiBan = r[5].ToString();
                ncc.Email = r[6].ToString();
                ncc.Fax = r[7].ToString();
                ncc.Website = r[8].ToString();
                ncc.SoTaiKhoan = r[9].ToString();
                ncc.NganHang = r[10].ToString();
                ncc.GioiHanNo = Convert.ToDouble(r[11]);
                ncc.ChietKhau = Convert.ToDouble(r[12]);
                ncc.NguoiLienHe = r[13].ToString();
                ncc.ChucVu = r[14].ToString();
                ncc.NoHienTai = Convert.ToDouble(r[15]);
                ncc.KhuVuc = Convert.ToInt32(r[16]);
                ncc.ConQuanLy = Convert.ToBoolean(r[17]);
                lst.Add(ncc);
            }

            p.Disconnect();
            return lst;
        }
        public static int SuaNhaCungCap(NhaCungCapDTO ncc)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@mancc", SqlDbType.Int) { Value = ncc.MaNhaCungCap },
                new SqlParameter("@tenncc", SqlDbType.NVarChar, 255) { Value = ncc.TenNhaPhanPhoi },
                new SqlParameter("@diachi", SqlDbType.NVarChar, 255) { Value = ncc.DiaChi },
                new SqlParameter("@masothue", SqlDbType.Char, 20) { Value = ncc.MaSoThue },
                new SqlParameter("@sodidong", SqlDbType.Char, 20) { Value = ncc.SoDiDong },
                new SqlParameter("@sodienthoaiban", SqlDbType.Char, 20) { Value = ncc.SoDienThoaiBan },
                new SqlParameter("@email", SqlDbType.Char, 255) { Value = ncc.Email },
                new SqlParameter("@fax", SqlDbType.Char, 20) { Value = ncc.Fax },
                new SqlParameter("@website", SqlDbType.Char, 255) { Value = ncc.Website },
                new SqlParameter("@sotaikhoan", SqlDbType.Char, 30) { Value = ncc.SoTaiKhoan },
                new SqlParameter("@nganhang", SqlDbType.NVarChar, 255) { Value = ncc.NganHang },
                new SqlParameter("@gioihanno", SqlDbType.Float) { Value = ncc.GioiHanNo },
                new SqlParameter("@chietkhau", SqlDbType.Float) { Value = ncc.ChietKhau },
                new SqlParameter("@nguoilienhe", SqlDbType.NVarChar, 255) { Value = ncc.NguoiLienHe },
                new SqlParameter("@chucvu", SqlDbType.NVarChar, 255) { Value = ncc.ChucVu },
                new SqlParameter("@nohientai", SqlDbType.Float) { Value = ncc.NoHienTai },
                new SqlParameter("@khuvuc", SqlDbType.Int) { Value = ncc.KhuVuc },
                new SqlParameter("@conquanly", SqlDbType.Bit) { Value = ncc.ConQuanLy }
            };
            int kq= p.ExecuteNonQuery("sp_SuaNhaCungCap", CommandType.StoredProcedure, para);
            p.Disconnect();
            return kq;
        }
        public static int XoaNhaCungCap(int mancc)
        {
            DataProvider p = new DataProvider();
            p.Connect();
            SqlParameter[] para = new SqlParameter[] { new SqlParameter("@mancc", SqlDbType.Int) { Value = mancc } };
            int kq= p.ExecuteNonQuery("sp_XoaNhaCungCap", CommandType.StoredProcedure, para);
            p.Disconnect();
            return kq;
        }
    }

}
