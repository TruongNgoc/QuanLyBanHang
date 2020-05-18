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
using QuanLyBanHang.GUI.NhanVien;
using QuanLyBanHang.BUS;
using QuanLyBanHang.BUS;

namespace QuanLyBanHang.GUI.KhoHang
{
    public partial class DanhMuc_ThemKhoHang : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_ThemKhoHang()
        {
            InitializeComponent();
        }
        public delegate void ThemXongKho();
        private ThemXongKho eventThemXongKhoEvent;
        public event ThemXongKho eventThemXongKho
        {
            add
            {
                eventThemXongKhoEvent = (ThemXongKho)System.Delegate.Combine(eventThemXongKhoEvent, value);
            }
            remove
            {
                eventThemXongKhoEvent = (ThemXongKho)System.Delegate.Remove(eventThemXongKhoEvent, value);
            }
        }


        private void DanhMuc_ThemKhoHang_Load(object sender, EventArgs e)
        {
            LoadComboboxNhanVien();
        }
        private void LoadComboboxNhanVien()
        {
            lkpNguoiQuanLy.Properties.DataSource = NhanVienBUS.LayToanBoNhanVien();
            lkpNguoiQuanLy.Properties.DisplayMember = "HoTen";
            lkpNguoiQuanLy.Properties.ValueMember = "MaNhanVien";
        }

        public void btnLuu_Click(object sender, EventArgs e)
        {
            KhoHangDTO kh = new KhoHangDTO();
            kh.TenKho = System.Convert.ToString(txtTenKhoHang.Text);
            kh.NVQuanLy = System.Convert.ToInt32(lkpNguoiQuanLy.EditValue);
            kh.NguoiLienHe = System.Convert.ToString(txtNguoiLienHe.Text);
            kh.DiaChi = System.Convert.ToString(txtDiaChi.Text);
            kh.DienThoai = System.Convert.ToString(txtDienThoai.Text);
            kh.Fax = System.Convert.ToString(txtFax.Text);
            kh.Email = System.Convert.ToString(txtEmail.Text);
            kh.DienGiai = System.Convert.ToString(txtDienGiai.Text);
            if (chkConQuanLy.Checked == true)
            {
                kh.ConQuanLy = true;
            }
            else
            {
                kh.ConQuanLy = false;
            }

            bool test = KhoHangBUS.ThemKhoHang(kh);
            if (test == false)
            {
                MessageBox.Show("Dữ liệu thêm sai");
            }
            else
            {
                Log_BUS.ThemNhatKy("Kho hàng", "Thêm kho hàng");
                MessageBox.Show("Thêm thành công");
                if (eventThemXongKhoEvent != null)
                    eventThemXongKhoEvent();
            }
        }

        public void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void lkpNguoiQuanLy_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.ButtonEdit editor = (DevExpress.XtraEditors.ButtonEdit)sender;
            int buttonindex = System.Convert.ToInt32(editor.Properties.Buttons.IndexOf(e.Button));
            if (buttonindex == 1)
            {
                DanhMuc_ThemNhanVien f = new DanhMuc_ThemNhanVien();
                f.eventThemXong += LoadComboboxNhanVien;
                f.ShowDialog();
            }
        }
    }
}