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

namespace QuanLyBanHang.GUI.NhomHang
{
    public partial class DanhMuc_ThemNhomHang : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_ThemNhomHang()
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


        public void btnLuu_Click(object sender, EventArgs e)
        {
            NhomHangDTO nh = new NhomHangDTO();
            nh.TenNhomHang = Convert.ToString(txtTen.Text.TrimEnd());
            nh.GhiChu = Convert.ToString(txtGhiChu.Text.TrimEnd());
            if (chxConQuanLy.Checked == true)
            {
                nh.ConQuanLy = true;
            }
            else
            {
                nh.ConQuanLy = false;
            }
            bool check = NhomHangBUS.KiemTraThem(nh);
            if (check)
            {
                if (eventThemXongEvent != null)
                    eventThemXongEvent();
                MessageBox.Show("Thêm thành công!");
                Log_BUS.ThemNhatKy("Nhóm hàng", "Thêm nhóm hàng");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        public void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}