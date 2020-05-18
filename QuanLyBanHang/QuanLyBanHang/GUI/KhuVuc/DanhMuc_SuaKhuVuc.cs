using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBanHang.BUS;
using QuanLyBanHang.BUS;

namespace QuanLyBanHang.GUI.KhuVuc
{
    public partial class DanhMuc_SuaKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_SuaKhuVuc()
        {
            InitializeComponent();
        }
        public delegate void SuaXong();
        private SuaXong eventSuaXongEvent;
        public event SuaXong eventSuaXong
        {
            add
            {
                eventSuaXongEvent = (SuaXong)System.Delegate.Combine(eventSuaXongEvent, value);
            }
            remove
            {
                eventSuaXongEvent = (SuaXong)System.Delegate.Remove(eventSuaXongEvent, value);
            }
        }

        public void btnLuu_Click(object sender, EventArgs e)
        {
            KhuVucDTO kv = new KhuVucDTO();
            kv.MaKhuVuc = int.Parse(txtMaKhuVuc.Text.Trim());
            kv.TenKhuVuc = txtTen.Text.Trim();
            kv.GhiChu = txtGhiChu.Text.Trim();
            if (chxConQuanLy.Checked == true)
            {
                kv.ConQuanLy = true;
            }
            else
            {
                kv.ConQuanLy = false;
            }
            bool check = KhuVucBUS.KiemTraSua(kv);
            if (check)
            {
                if (eventSuaXongEvent != null)
                {
                    eventSuaXongEvent();
                }
                Log_BUS.ThemNhatKy("Khu vực", "Sửa thông tin khu vực");
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        public void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}