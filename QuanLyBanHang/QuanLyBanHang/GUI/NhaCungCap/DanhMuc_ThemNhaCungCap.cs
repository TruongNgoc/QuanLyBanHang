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
using QuanLyBanHang.GUI.KhuVuc;
using QuanLyBanHang.BUS;
using QuanLyBanHang.BUS;

namespace QuanLyBanHang.GUI.NhaCungCap
{
    public partial class DanhMuc_ThemNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_ThemNhaCungCap()
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

        public void LoadKhuVuc()
        {
            List<KhuVucDTO> lKV = KhuVucBUS.LayToanBoKhuVuc();
            lkpKhuVuc.Properties.DataSource = lKV;
            lkpKhuVuc.Properties.DisplayMember = "TenKhuVuc";
            lkpKhuVuc.Properties.ValueMember = "MaKhuVuc";
        }
        private void DanhMuc_ThemNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadKhuVuc();
        }

        public void btnLuu_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO ncc = new NhaCungCapDTO();
            ncc.KhuVuc = System.Convert.ToInt32(lkpKhuVuc.EditValue);
            ncc.TenNhaPhanPhoi = txtTen.Text.Trim();
            ncc.DiaChi = System.Convert.ToString(txtDiaChi.Text.Trim());
            ncc.MaSoThue = txtMaSoThue.Text.Trim();
            ncc.SoDienThoaiBan = System.Convert.ToString(txtDienThoai.Text.Trim());
            ncc.Email = txtEmail.Text.Trim();
            ncc.SoTaiKhoan = txtSoTaiKhoan.Text.Trim();
            ncc.GioiHanNo = (double)ceGioiHanNo.Value;
            ncc.ChietKhau = System.Convert.ToDouble(ceChietKhau.Value);
            ncc.NguoiLienHe = txtNguoiLienHe.Text.Trim();
            ncc.Fax = txtFax.Text.Trim();
            ncc.SoDiDong = txtMobile.Text.Trim();
            ncc.Website = txtWebsite.Text.Trim();
            ncc.NganHang = txtNganHang.Text.Trim();
            ncc.NoHienTai = 0;
            ncc.ChucVu = txtChucVu.Text.Trim();
            if (chxConQuanLy.Checked == true)
            {
                ncc.ConQuanLy = true;
            }
            else
            {
                ncc.ConQuanLy = false;
            }
            bool check = NhaCungCapBUS.KiemTraThem(ncc);

            if (check)
            {
                MessageBox.Show("Thêm thành công!");
                Log_BUS.ThemNhatKy("Nhà cung cấp", "Thêm nhà cung cấp");
                if (eventThemXongEvent != null)
                    eventThemXongEvent();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }
        public void lkpKhuVuc_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.ButtonEdit Editor = (DevExpress.XtraEditors.ButtonEdit)sender;
            int buttonIndex = System.Convert.ToInt32(Editor.Properties.Buttons.IndexOf(e.Button));
            if (buttonIndex == 1)
            {
                DanhMuc_ThemKhuVuc f = new DanhMuc_ThemKhuVuc();
                f.eventThemXong += LoadKhuVuc;
                f.ShowDialog();
            }
        }

        public void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}