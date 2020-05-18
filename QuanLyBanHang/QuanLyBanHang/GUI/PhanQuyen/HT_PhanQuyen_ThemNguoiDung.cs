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

namespace QuanLyBanHang.GUI.PhanQuyen
{
    public partial class HT_PhanQuyen_ThemNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public HT_PhanQuyen_ThemNguoiDung()
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

        private void HT_PhanQuyen_ThemNguoiDung_Load(object sender, EventArgs e)
        {
            LoadVaiTro();
        }

        private void LoadVaiTro()
        {
            lkpVaiTro.Properties.DataSource = TaiKhoan_BUS.LayHetVaiTro();
            lkpVaiTro.Properties.DisplayMember = "Ten";
            lkpVaiTro.Properties.ValueMember = "MaVaiTro";

            if (!ReferenceEquals(((List<VaiTroDTO>)lkpVaiTro.Properties.DataSource)[0], null))
            {
                lkpVaiTro.EditValue = ((List<VaiTroDTO>)lkpVaiTro.Properties.DataSource)[0].MaVaiTro;
            }
        }

        public void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnLuu_Click(object sender, EventArgs e)
        {
            TaiKhoan_DTO nd = new TaiKhoan_DTO();
            if (txtMatKhau.Text != txtMatKhau2.Text)
            {
                MessageBox.Show("Mật khẩu không trùng nhau");
                return;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống");
                return;
            }
            nd.MatKhau = Convert.ToString(txtMatKhau.Text);
            nd.Ten = Convert.ToString(txtNguoiDung.Text);
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Tài khoản không được trống");
            }
            nd.TaiKhoan = Convert.ToString(txtTaiKhoan.Text);
            nd.MaVaiTro = Convert.ToInt32(lkpVaiTro.EditValue);
            nd.GhiChu = Convert.ToString(txtGhiChu.Text);

            int test = TaiKhoan_BUS.ThemNguoiDung(nd);
            switch (test)
            {
                case 0:
                    MessageBox.Show("Thêm người dùng thành công");
                    if (eventThemXongEvent != null)
                        eventThemXongEvent();
                    break;
                case -1:
                    MessageBox.Show("Tài khoản này đã tồn tại, xin chọn tài khoản khác");
                    return;
                case -2:
                    MessageBox.Show("Lỗi khi lưu xuống cơ sở dữ liệu");
                    return;
            }
        }

        public void lkpVaiTro_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.ButtonEdit editor = (DevExpress.XtraEditors.ButtonEdit)sender;
            int buttonindex = System.Convert.ToInt32(editor.Properties.Buttons.IndexOf(e.Button));
            if (buttonindex == 1)
            {
                HT_PhanQuyen_ThemVaiTro f = new HT_PhanQuyen_ThemVaiTro();
                f.eventThemXong += LoadVaiTro;
                f.ShowDialog();
            }
        }
    }
}