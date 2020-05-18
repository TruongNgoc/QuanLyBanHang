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
using QuanLyBanHang.GUI.BoPhan;

namespace QuanLyBanHang.GUI.NhanVien
{
    public partial class DanhMuc_ThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_ThemNhanVien()
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


        private void DanhMuc_ThemNhanVien_Load(object sender, EventArgs e)
        {
            LoadComboBoxBoPhan();
            LoadComboBoxQuanLy();
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
        public void lkpBoPhan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.ButtonEdit editor = (DevExpress.XtraEditors.ButtonEdit)sender;
            int buttonindex = Convert.ToInt32(editor.Properties.Buttons.IndexOf(e.Button));
            if (buttonindex == 1)
            {
                DanhMuc_ThemBoPhan f = new DanhMuc_ThemBoPhan();
                f.eventThemXongBoPhan += LoadComboBoxBoPhan;
                f.ShowDialog();
            }
        }

        public void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = default(NhanVienDTO);
            nv = new NhanVienDTO();
            nv.HoTen = Convert.ToString(txtTen.Text);
            nv.ChucVu = Convert.ToString(txtChucVu.Text);
            nv.DiaChi = Convert.ToString(txtDiaChi.Text);
            nv.Email = Convert.ToString(txtEmail.Text);
            nv.DienThoai = Convert.ToString(txtDienThoaiBan.Text);
            nv.DiDong = Convert.ToString(txtDiDong.Text);
            if (lkpBoPhan.EditValue != null)
            {
                nv.BoPhan = System.Convert.ToInt32(lkpBoPhan.EditValue);
            }
            if (lkpQuanLy.EditValue != null)
            {
                nv.QuanLy = Convert.ToInt32(lkpQuanLy.EditValue);
            }
            if (chkConQuanLy.Checked == true)
            {
                nv.ConQuanLy = true;
            }
            else
            {
                nv.ConQuanLy = false;
            }
            bool test = NhanVienBUS.ThemNhanVien(nv);
            if (test == true)
            {
                MessageBox.Show("Thêm thành công");
                Log_BUS.ThemNhatKy("Nhân viên", "Thêm nhân viên");
                if (eventThemXongEvent != null)
                    eventThemXongEvent();
            }
            else
            {
                MessageBox.Show("Thêm không thành công, dữ liệu thêm chưa đúng");
            }
        }
        public void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}