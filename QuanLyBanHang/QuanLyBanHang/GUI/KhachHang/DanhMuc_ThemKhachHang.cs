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
using QuanLyBanHang.GUI.KhuVuc;

namespace QuanLyBanHang.GUI.KhachHang
{
    public partial class DanhMuc_ThemKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_ThemKhachHang()
        {
            InitializeComponent();
        }
        public delegate void ThemXongKhachHang();
        private ThemXongKhachHang eventThemXongKhachHangEvent;
        public event ThemXongKhachHang eventThemXongKhachHang
        {
            add
            {
                eventThemXongKhachHangEvent = (ThemXongKhachHang)System.Delegate.Combine(eventThemXongKhachHangEvent, value);
            }
            remove
            {
                eventThemXongKhachHangEvent = (ThemXongKhachHang)System.Delegate.Remove(eventThemXongKhachHangEvent, value);
            }
        }


        private void DanhMuc_ThemKhachHang_Load(object sender, EventArgs e)
        {
            LoadComboboxKhuVuc();
        }

        public void LoadComboboxKhuVuc()
        {
            List<KhuVucDTO> lKV = KhuVucBUS.LayToanBoKhuVuc();
            lkpKhuVuc.Properties.DataSource = lKV;
            lkpKhuVuc.Properties.DisplayMember = "TenKhuVuc";
            lkpKhuVuc.Properties.ValueMember = "MaKhuVuc";
        }

        public void lkpKhuVuc_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.ButtonEdit Editor = (DevExpress.XtraEditors.ButtonEdit)sender;
            int buttonIndex = System.Convert.ToInt32(Editor.Properties.Buttons.IndexOf(e.Button));
            if (buttonIndex == 1)
            {
                DanhMuc_ThemKhuVuc f = new DanhMuc_ThemKhuVuc();
                f.eventThemXong += LoadComboboxKhuVuc;
                f.ShowDialog();
            }
        }

        public void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnLuu_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.HoTen = Convert.ToString(txtTen.Text);
            kh.DiaChi = Convert.ToString(txtDiaChi.Text);
            kh.MaSoThue = Convert.ToString(txtMaSoThue.Text);
            kh.SoDienThoaiBan = Convert.ToString(txtDienThoai.Text);
            kh.Email = Convert.ToString(txtEmail.Text);
            kh.SoTaiKhoan = Convert.ToString(txtTaiKhoan.Text);
            kh.GioiHanNo = double.Parse(Convert.ToString(ceGioiHanNo.Value.ToString()));
            kh.ChietKhau = double.Parse(Convert.ToString(ceChietKhau.Value.ToString()));
            kh.NguoiLienHe = Convert.ToString(txtNguoiLienHe.Text);
            kh.Fax = Convert.ToString(txtFax.Text);
            kh.SoDiDong = Convert.ToString(txtMobile.Text);
            kh.Website = Convert.ToString(txtWebsite.Text);
            kh.NganHang = Convert.ToString(txtNganHang.Text);
            kh.NoHienTai = double.Parse(Convert.ToString(txtNoHienTai.Text));
            kh.NickYahoo = Convert.ToString(txtNickYahoo.Text);
            kh.NickSkype = Convert.ToString(txtNickSkype.Text);
            kh.KhuVuc = Convert.ToInt32(lkpKhuVuc.EditValue);
            if (rbDaiLy.Checked == true)
            {
                kh.LoaiKhachHang = 1;
            }
            else
            {
                kh.LoaiKhachHang = 2;
            }

            if (chkConQuanLy.Checked == true)
            {
                kh.ConQuanLy = true;
            }
            else
            {
                kh.ConQuanLy = false;
            }

            int test = KhachHangBUS.ThemKhachHang(kh);

            if (test == 0)
            {
                MessageBox.Show("Thêm thành công");
                Log_BUS.ThemNhatKy("Khách hàng", "Thêm khách hàng");
                if (eventThemXongKhachHangEvent != null)
                    eventThemXongKhachHangEvent();
            }
            else
            {
                MessageBox.Show("Dữ liệu thêm không đúng");
            }
        }
    }
}