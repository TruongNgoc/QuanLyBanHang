using QuanLyBanHang.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.DAO;
using System.Windows.Forms;

namespace QuanLyBanHang.BUS
{
    public class NhaCungCapBUS
    {
        public static List<NhaCungCapDTO> KiemTraLoad()
        {
            List<NhaCungCapDTO> lncc = new List<NhaCungCapDTO>();
            lncc = NhaCungCapDAO.LayDanhSachNhaCungCap();
            if (lncc.Count == 0)
            {
                MessageBox.Show("Không tải được dữ liệu nào!");
            }
            return lncc;
        }
        public static bool KiemTraThem(NhaCungCapDTO ncc)
        {
            if (ncc.TenNhaPhanPhoi.ToString() == "")
            {
                return false;
            }
            int index = NhaCungCapDAO.ThemNhaCungCap(ncc);
            if (index == 0)
            {
                return false;
            }
            return true;
        }
        public static bool KiemTraXoa(int mancc)
        {
            if (NhaCungCapDAO.XoaNhaCungCap(mancc) == 0)
            {
                return false;
            }
            return true;
        }
        public static bool KiemTraSua(NhaCungCapDTO ncc)
        {
            if (NhaCungCapDAO.SuaNhaCungCap(ncc) == 0)
            {
                return false;
            }
            return true;
        }
        public static NhaCungCapDTO LayChiTietNCC(int mncc)
        {
            NhaCungCapDTO nhacungcap = null;
            List<NhaCungCapDTO> lncc = NhaCungCapDAO.LayDanhSachNhaCungCap();
            foreach (NhaCungCapDTO ncc in lncc)
            {
                if (System.Convert.ToInt32(ncc.MaNhaCungCap) == mncc)
                {
                    nhacungcap = ncc;
                    break;
                }
            }
            return nhacungcap;
        }
    }

}
