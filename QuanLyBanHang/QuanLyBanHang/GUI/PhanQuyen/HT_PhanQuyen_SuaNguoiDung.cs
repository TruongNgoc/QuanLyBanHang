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
    public partial class HT_PhanQuyen_SuaNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public HT_PhanQuyen_SuaNguoiDung()
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

        private TaiKhoan_DTO _NguoiDungSua;
        public TaiKhoan_DTO NguoiDungSua
        {
            get
            {
                return _NguoiDungSua;
            }
            set
            {
                _NguoiDungSua = value;
            }
        }
        private void HT_PhanQuyen_SuaNguoiDung_Load(object sender, EventArgs e)
        {
            LoadVaiTro();
            LoadTheoNguoiDung();

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

        private void LoadTheoNguoiDung()
        {
            txtNguoiDung.Text = NguoiDungSua.Ten;
            txtTaiKhoan.Text = NguoiDungSua.TaiKhoan;
            txtMatKhau.Text = NguoiDungSua.MatKhau;
            txtMatKhau2.Text = NguoiDungSua.MatKhau;
            lkpVaiTro.EditValue = NguoiDungSua.MaVaiTro;
            txtGhiChu.Text = NguoiDungSua.GhiChu;
        }

        public void btnLuu_Click(object sender, EventArgs e)
        {
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
            NguoiDungSua.MatKhau = Convert.ToString(txtMatKhau.Text);
            NguoiDungSua.Ten = Convert.ToString(txtNguoiDung.Text);
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Tài khoản không được trống");
            }
            NguoiDungSua.TaiKhoan = Convert.ToString(txtTaiKhoan.Text);
            NguoiDungSua.MaVaiTro = Convert.ToInt32(lkpVaiTro.EditValue);
            NguoiDungSua.GhiChu = Convert.ToString(txtGhiChu.Text);

            int test = TaiKhoan_BUS.SuaNguoiDung(NguoiDungSua);
            switch (test)
            {
                case 0:
                    MessageBox.Show("Sửa người dùng thành công");
                    if (eventSuaXongEvent != null)
                        eventSuaXongEvent();
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

        public void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}