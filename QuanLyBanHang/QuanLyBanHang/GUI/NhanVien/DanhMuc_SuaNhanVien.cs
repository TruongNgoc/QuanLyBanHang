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
using QuanLyBanHang.GUI.BoPhan;
using QuanLyBanHang.BUS;
using QuanLyBanHang.BUS;

namespace QuanLyBanHang.GUI.NhanVien
{
    public partial class DanhMuc_SuaNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_SuaNhanVien()
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


        private NhanVienDTO _nvSua;
        public NhanVienDTO NVSua
        {
            get
            {
                return _nvSua;
            }
            set
            {
                _nvSua = value;
            }
        }

        private void DanhMuc_SuaNhanVien_Load(object sender, EventArgs e)
        {
            LoadComboBoxBoPhan();
            LoadComboBoxQuanLy();
            LoadTheoNhanVienSua();
        }

        private void LoadComboBoxBoPhan()
        {
            lkpBoPhan.Properties.DataSource = BoPhanBUS.LayToanBoBoPhan();
            lkpBoPhan.Properties.DisplayMember = "TenBoPhan";
            lkpBoPhan.Properties.ValueMember = "MaBoPhan";
        }

        private void LoadComboBoxQuanLy()
        {
            lkpQuanLy.Properties.DataSource = NhanVienBUS.LayToanBoNhanVien();
            lkpQuanLy.Properties.DisplayMember = "HoTen";
            lkpQuanLy.Properties.ValueMember = "MaNhanVien";
        }

        private void LoadTheoNhanVienSua()
        {
            txtTen.Text = NVSua.HoTen;
            txtChucVu.Text = NVSua.ChucVu;
            txtDiaChi.Text = NVSua.DiaChi;
            txtEmail.Text = NVSua.Email;
            txtDienThoaiBan.Text = NVSua.DienThoai;
            txtDiDong.Text = NVSua.DiDong;
            if (NVSua.BoPhan.ToString() != null)
            {
                lkpBoPhan.EditValue = NVSua.BoPhan;
            }
            if (NVSua.QuanLy.ToString() != null)
            {
                lkpQuanLy.EditValue = NVSua.QuanLy;
            }

            if (NVSua.ConQuanLy == true)
            {
                chkConQuanLy.Checked = true;
            }
            else
            {
                chkConQuanLy.Checked = false;
            }
        }

        public void btnLuu_Click(object sender, EventArgs e)
        {
            NVSua.HoTen = Convert.ToString(txtTen.Text);
            NVSua.ChucVu = Convert.ToString(txtChucVu.Text);
            NVSua.DiaChi = Convert.ToString(txtDiaChi.Text);
            NVSua.Email = Convert.ToString(txtEmail.Text);
            NVSua.DienThoai = Convert.ToString(txtDienThoaiBan.Text);
            NVSua.DiDong = Convert.ToString(txtDiDong.Text);
            if (lkpBoPhan.EditValue != null)
            {
                NVSua.BoPhan = Convert.ToInt32(lkpBoPhan.EditValue);
            }
            if (lkpQuanLy.EditValue != null)
            {
                NVSua.QuanLy = Convert.ToInt32(lkpQuanLy.EditValue);
            }
            if (chkConQuanLy.Checked == true)
            {
                NVSua.ConQuanLy = true;
            }
            else
            {
                NVSua.ConQuanLy = false;
            }
            bool test = NhanVienBUS.SuaNhanVien(NVSua);
            if (test == true)
            {
                MessageBox.Show("Sửa thành công");
                Log_BUS.ThemNhatKy("Nhân viên", "Sửa thông tin nhân viên");
                if (eventSuaXongEvent != null)
                    eventSuaXongEvent();
            }
            else
            {
                MessageBox.Show("Sửa không thành công, dữ liệu sửa chưa đúng");
            }
        }
        public void lkpBoPhan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.ButtonEdit editor = (DevExpress.XtraEditors.ButtonEdit)sender;
            int buttonindex = System.Convert.ToInt32(editor.Properties.Buttons.IndexOf(e.Button));
            if (buttonindex == 1)
            {
                DanhMuc_ThemBoPhan f = new DanhMuc_ThemBoPhan();
                f.eventThemXongBoPhan += LoadComboBoxBoPhan;
                f.ShowDialog();
            }
        }
        public void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}