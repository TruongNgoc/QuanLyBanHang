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
    public partial class DanhMuc_SuaNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_SuaNhaCungCap()
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

        public void LoadKhuVuc()
        {
            List<KhuVucDTO> lKV = KhuVucBUS.LayToanBoKhuVuc();
            lkpKhuVuc.Properties.DataSource = lKV;
            lkpKhuVuc.Properties.DisplayMember = "TenKhuVuc";
            lkpKhuVuc.Properties.ValueMember = "MaKhuVuc";
        }

        private void DanhMuc_SuaNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadKhuVuc();
        }
        public void btnLuu_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO ncc = new NhaCungCapDTO();
            ncc.MaNhaCungCap = Convert.ToInt32(txtMa.Text.TrimEnd());
            ncc.KhuVuc = Convert.ToInt32(lkpKhuVuc.EditValue);
            ncc.TenNhaPhanPhoi = txtTen.Text.Trim();
            ncc.DiaChi = Convert.ToString(txtDiaChi.Text.Trim());
            ncc.MaSoThue = txtMaSoThue.Text.Trim();
            ncc.SoDienThoaiBan = Convert.ToString(txtDienThoai.Text.Trim());
            ncc.Email = txtEmail.Text.Trim();
            ncc.SoTaiKhoan = txtSoTaiKhoan.Text.Trim();
            ncc.GioiHanNo = (double)ceGioiHanNo.Value;
            ncc.ChietKhau = Convert.ToDouble(ceChietKhau.Value);
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
            bool check = NhaCungCapBUS.KiemTraSua(ncc);

            if (check)
            {
                MessageBox.Show("Sửa thành công!");
                Log_BUS.ThemNhatKy("Nhà cung cấp", "Sửa thông tin nhà cung cấp");
                if (eventSuaXongEvent != null)
                    eventSuaXongEvent();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
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