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

namespace QuanLyBanHang.GUI.KhachHang
{
    public partial class DanhMuc_SuaKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_SuaKhachHang()
        {
            InitializeComponent();
        }
        public delegate void SuaXongKhachHang();
        private SuaXongKhachHang eventSuaXongKhachHangEvent;
        public event SuaXongKhachHang eventSuaXongKhachHang
        {
            add
            {
                eventSuaXongKhachHangEvent = (SuaXongKhachHang)System.Delegate.Combine(eventSuaXongKhachHangEvent, value);
            }
            remove
            {
                eventSuaXongKhachHangEvent = (SuaXongKhachHang)System.Delegate.Remove(eventSuaXongKhachHangEvent, value);
            }
        }

        private KhachHangDTO _KhachHangSua;
        public KhachHangDTO KhachHangSua
        {
            get
            {
                return _KhachHangSua;
            }
            set
            {
                _KhachHangSua = value;
            }
        }

        private void DanhMuc_SuaKhachHang_Load(object sender, EventArgs e)
        {
            LoadComboboxKhuVuc();
            LoadTheoKhachHangSua();
        }
        private void LoadTheoKhachHangSua()
        {
            if (KhachHangSua.LoaiKhachHang == 1)
            {
                rbDaiLy.Checked = true;
            }
            else
            {
                rbKhachLe.Checked = true;
            }

            txtTen.Text = KhachHangSua.HoTen;
            lkpKhuVuc.EditValue = KhachHangSua.KhuVuc.ToString();
            txtDiaChi.Text = KhachHangSua.DiaChi;
            txtMaSoThue.Text = KhachHangSua.MaSoThue;
            txtDienThoai.Text = KhachHangSua.SoDienThoaiBan;
            txtMobile.Text = KhachHangSua.SoDiDong;
            txtFax.Text = KhachHangSua.Fax;
            txtEmail.Text = KhachHangSua.Email;
            txtWebsite.Text = KhachHangSua.Website;
            txtTaiKhoan.Text = KhachHangSua.SoTaiKhoan;
            ceGioiHanNo.Value = decimal.Parse(KhachHangSua.GioiHanNo.ToString());
            ceChietKhau.Value = decimal.Parse(KhachHangSua.ChietKhau.ToString());
            txtNguoiLienHe.Text = KhachHangSua.NguoiLienHe;
            txtNganHang.Text = KhachHangSua.NganHang;
            txtNoHienTai.Text = KhachHangSua.NoHienTai.ToString();
            txtNickYahoo.Text = KhachHangSua.NickYahoo;
            txtNickSkype.Text = KhachHangSua.NickSkype;
        }
        public void LoadComboboxKhuVuc()
        {
            List<KhuVucDTO> lKV = KhuVucBUS.LayToanBoKhuVuc();
            lkpKhuVuc.Properties.DataSource = lKV;
            lkpKhuVuc.Properties.DisplayMember = "TenKhuVuc";
            lkpKhuVuc.Properties.ValueMember = "MaKhuVuc";
        }

        public void btnLuu_Click(object sender, EventArgs e)
        {
            KhachHangSua.HoTen = Convert.ToString(txtTen.Text);
            KhachHangSua.DiaChi = Convert.ToString(txtDiaChi.Text);
            KhachHangSua.MaSoThue = Convert.ToString(txtMaSoThue.Text);
            KhachHangSua.SoDienThoaiBan = Convert.ToString(txtDienThoai.Text);
            KhachHangSua.Email = Convert.ToString(txtEmail.Text);
            KhachHangSua.SoTaiKhoan = Convert.ToString(txtTaiKhoan.Text);
            KhachHangSua.GioiHanNo = double.Parse(Convert.ToString(ceGioiHanNo.Value.ToString()));
            KhachHangSua.ChietKhau = double.Parse(Convert.ToString(ceChietKhau.Value.ToString()));
            KhachHangSua.NguoiLienHe = Convert.ToString(txtNguoiLienHe.Text);
            KhachHangSua.Fax = Convert.ToString(txtFax.Text);
            KhachHangSua.SoDiDong = Convert.ToString(txtMobile.Text);
            KhachHangSua.Website = Convert.ToString(txtWebsite.Text);
            KhachHangSua.NganHang = Convert.ToString(txtNganHang.Text);
            KhachHangSua.NoHienTai = double.Parse(System.Convert.ToString(txtNoHienTai.Text));
            KhachHangSua.NickYahoo = Convert.ToString(txtNickYahoo.Text);
            KhachHangSua.NickSkype = Convert.ToString(txtNickSkype.Text);
            KhachHangSua.KhuVuc = Convert.ToInt32(lkpKhuVuc.EditValue);
            if (rbDaiLy.Checked == true)
            {
                KhachHangSua.LoaiKhachHang = 1;
            }
            else
            {
                KhachHangSua.LoaiKhachHang = 2;
            }

            if (chkConQuanLy.Checked == true)
            {
                KhachHangSua.ConQuanLy = true;
            }
            else
            {
                KhachHangSua.ConQuanLy = false;
            }

            int test = KhachHangBUS.SuaKhachHang(KhachHangSua);

            if (test == 0)
            {
                MessageBox.Show("Sửa thành công");
                Log_BUS.ThemNhatKy("Khách hàng", "Sửa thông tin khách hàng");
                if (eventSuaXongKhachHangEvent != null)
                    eventSuaXongKhachHangEvent();
            }
            else
            {
                MessageBox.Show("Dữ liệu thêm không đúng");
            }
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
    }
}