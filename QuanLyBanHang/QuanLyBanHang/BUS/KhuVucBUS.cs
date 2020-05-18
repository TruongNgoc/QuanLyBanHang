using QuanLyBanHang.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.DAO;

namespace QuanLyBanHang.BUS
{
    public class KhuVucBUS
    {
        public static List<KhuVucDTO> KiemTraLoad()
        {
            List<KhuVucDTO> lkv = KhuVucDAO.LayToanBoKhuVuc();
            if (lkv.Count == 0)
            {
                MessageBox.Show("Không tải được dữ liệu nào!");
            }
            return lkv;
        }
        public static bool KiemTraThem(KhuVucDTO kv)
        {
            KhuVucDAO.ThemKhuVuc(kv);
            return true;
        }
        public static bool KiemTraSua(KhuVucDTO kv)
        {
            if (string.IsNullOrEmpty(kv.TenKhuVuc.ToString()) || KhuVucDAO.SuaKhuVuc(kv) == 0)
            {
                return false;
            }
            return true;
        }
        public static bool KiemTraXoa(int makv)
        {
            if (KhuVucDAO.XoaKhuVuc(makv) == 0)
            {
                return false;
            }
            return true;
        }
        public static List<KhuVucDTO> LayToanBoKhuVuc()
        {
            List<KhuVucDTO> lKV = KhuVucDAO.LayToanBoKhuVuc();
            return lKV;
        }
    }
}
