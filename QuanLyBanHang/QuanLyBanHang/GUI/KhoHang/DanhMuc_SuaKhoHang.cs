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
using QuanLyBanHang.GUI.NhanVien;

namespace QuanLyBanHang.GUI.KhoHang
{
    public partial class DanhMuc_SuaKhoHang : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_SuaKhoHang()
        {
            InitializeComponent();
        }
        private KhoHangDTO _KhoHangSua;
        public KhoHangDTO KhoHangSua
        {

            get
            {
                return _KhoHangSua;
            }
            set
            {
                _KhoHangSua = value;
            }
        }

        public delegate void SuaXongKho();
        private SuaXongKho eventSuaXongChoEvent;
        public event SuaXongKho eventSuaXongCho
        {
            add
            {
                eventSuaXongChoEvent = (SuaXongKho)System.Delegate.Combine(eventSuaXongChoEvent, value);
            }
            remove
            {
                eventSuaXongChoEvent = (SuaXongKho)System.Delegate.Remove(eventSuaXongChoEvent, value);
            }
        }


        private void DanhMuc_SuaKhoHang_Load(object sender, EventArgs e)
        {
            LoadComboboxNhanVien();
            LoadTheoKhoSua();
        }
        private void LoadComboboxNhanVien()
        {
            lkpNguoiQuanLy.Properties.DataSource = NhanVienBUS.LayToanBoNhanVien();
            lkpNguoiQuanLy.Properties.DisplayMember = "HoTen";
            lkpNguoiQuanLy.Properties.ValueMember = "MaNhanVien";
        }

        private void LoadTheoKhoSua()
        {
            txtTenKhoHang.Text = KhoHangSua.TenKho;
            lkpNguoiQuanLy.EditValue = KhoHangSua.NVQuanLy;
            txtNguoiLienHe.Text = KhoHangSua.NguoiLienHe;
            txtDiaChi.Text = KhoHangSua.DiaChi;
            txtDienThoai.Text = KhoHangSua.DienThoai;
            txtFax.Text = KhoHangSua.Fax;
            txtEmail.Text = KhoHangSua.Email;
            txtDienGiai.Text = KhoHangSua.DienGiai;
            if (KhoHangSua.ConQuanLy == true)
            {
                chkConQuanLy.Checked = true;
            }
            else
            {
                chkConQuanLy.Checked = false;
            }
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

        public void btnLuu_Click(object sender, EventArgs e)
        {
            KhoHangSua.TenKho = Convert.ToString(txtTenKhoHang.Text);
            KhoHangSua.NVQuanLy = Convert.ToInt32(lkpNguoiQuanLy.EditValue);
            KhoHangSua.NguoiLienHe = Convert.ToString(txtNguoiLienHe.Text);
            KhoHangSua.DiaChi = Convert.ToString(txtDiaChi.Text);
            KhoHangSua.DienThoai = Convert.ToString(txtDienThoai.Text);
            KhoHangSua.Fax = Convert.ToString(txtFax.Text);
            KhoHangSua.Email = Convert.ToString(txtEmail.Text);
            KhoHangSua.DienGiai = Convert.ToString(txtDienGiai.Text);
            if (chkConQuanLy.Checked == true)
            {
                KhoHangSua.ConQuanLy = true;
            }
            else
            {
                KhoHangSua.ConQuanLy = false;
            }

            int test = KhoHangBUS.SuaKhohang(KhoHangSua);
            if (test == -1)
            {
                MessageBox.Show("Dữ liệu sửa không đúng");
            }
            else
            {
                Log_BUS.ThemNhatKy("Kho hàng", "Sửa thông tin kho hàng");
                MessageBox.Show("Sửa thành công");
                if (eventSuaXongChoEvent != null)
                    eventSuaXongChoEvent();
            }
        }

        public void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}