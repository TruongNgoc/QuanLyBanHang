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
    public partial class DanhMuc_SuaNhomHang : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_SuaNhomHang()
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
            NhomHangDTO nh = new NhomHangDTO();
            nh.MaNhomHang = Convert.ToInt32(txtMa.Text);
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
            bool check = NhomHangBUS.KiemTraSua(nh);
            if (check)
            {
                if (eventSuaXongEvent != null)
                    eventSuaXongEvent();
                MessageBox.Show("Sửa thành công!");
                Log_BUS.ThemNhatKy("Nhóm hàng", "Sửa thông tin nhóm hàng");
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