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
    public partial class DanhMuc_ThemKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_ThemKhuVuc()
        {
            InitializeComponent();
        }
        public delegate void ThemXong();
        private ThemXong eventThemXongEvent;
        public event ThemXong eventThemXong
        {
            add
            {
                eventThemXongEvent = (ThemXong)System.Delegate.Combine(eventThemXongEvent, value);
            }
            remove
            {
                eventThemXongEvent = (ThemXong)System.Delegate.Remove(eventThemXongEvent, value);
            }
        }

        public void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnLuu_Click(object sender, EventArgs e)
        {
            KhuVucDTO kv = new KhuVucDTO();
            kv.TenKhuVuc = txtTen.Text;
            kv.GhiChu = txtGhiChu.Text;
            if (chxConQuanLy.Checked == true)
            {
                kv.ConQuanLy = true;
            }
            else
            {
                kv.ConQuanLy = false;
            }
            bool check = KhuVucBUS.KiemTraThem(kv);
            if (check)
            {
                if (eventThemXongEvent != null)
                {
                    eventThemXongEvent();
                }
                MessageBox.Show("Thêm thành công!");
                Log_BUS.ThemNhatKy("Khu vực", "Thêm khu vực");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }
    }
}