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

namespace QuanLyBanHang.GUI.HeThong
{
    public partial class HeThong_DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public HeThong_DangNhap()
        {
            InitializeComponent();
        }

        public void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                this.labelform.Text = "";
                this.noti.Text = "(*) Tên đăng nhập hoặc mật khẩu không được để trống";
            }
            else
            {
                string tk = Convert.ToString(txtdangnhap.Text);
                string mk = Convert.ToString(txtmatkhau.Text);
                bool check = TaiKhoan_BUS.KiemTraDangNhap(tk, mk);
                try
                {
                    if (check)
                    {
                        if (chkNhoTaiKhoanMatKhau.Checked== false)
                        {
                            txtdangnhap.Text = "";
                            txtmatkhau.Text = "";
                            txtdangnhap.Focus();
                        }


                        //this.Close();
                        frmMain frm = new frmMain();
                        // nhận tên người dùng để hiển thị trong form chính sau khi đăng nhập.
                        frm.txtuser.Text = tk;
                        frm.TenTKDangNhap.Caption = TaiKhoan_BUS.LayTenNguoiDungCuaTaiKhoan(tk);


                        //frm.txtuser.Text = TaiKhoan_BUS.LayTenNguoiDungCuaTaiKhoan(tk);
                        //frm.TenTKDangNhap.Caption += tk;
                        ID_Class.ID = tk;
                        Log_BUS.ThemNhatKy("Hệ thống", "Đăng nhập");
                        frm.ShowDialog();
                        // this.Hide();
                        //this.Close();
                    }
                    else
                    {
                        this.labelform.Text = "";
                        this.noti.Text = "(*) Tên đăng nhập hoặc mật khẩu của bạn không đúng";
                        this.txtmatkhau.Text = "";
                        this.txtmatkhau.Focus();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Chuỗi kết nối tới Database không chính xác, vui lòng xem lại DataProvider", "Lỗi kết nối cơ sở dữ liệu");
                }
            }
        }

        public void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //kiem tra gia tri rong
        private bool IsEmpty()
        {
            return string.IsNullOrEmpty(Convert.ToString(this.txtdangnhap.Text)) || string.IsNullOrEmpty(Convert.ToString(this.txtmatkhau.Text));
        }

        private void HeThong_DangNhap_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnDangNhap;
            this.Show();
            txtdangnhap.Focus();
        }
    }
}