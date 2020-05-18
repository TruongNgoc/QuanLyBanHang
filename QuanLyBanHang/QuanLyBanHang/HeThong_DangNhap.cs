using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Threading.Tasks;
using BUS;
using DTO;
namespace GUI
{
	public partial class HeThong_DangNhap
	{
		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			if (IsEmpty()) {
				this.labelform.Text = "";
				this.noti.Text = "(*) Tên đăng nhập hoặc mật khẩu không được để trống";
			} else {
				string tk = txtdangnhap.Text;
				string mk = txtmatkhau.Text;
				bool check = TaiKhoan_BUS.KiemTraDangNhap(tk, mk);
				try {
					if (check) {
						FormMain frm = new FormMain();
						frm.txtuser.Text = TaiKhoan_BUS.LayTenTKNguoiDung(tk);
						ID_Class.ID = tk;
						Log_BUS.ThemNhatKy("Hệ thống", "Đăng nhập");
						frm.Show();
						this.Hide();
					} else {
						this.labelform.Text = "";
						this.noti.Text = "(*) Tên đăng nhập hoặc mật khẩu của bạn không đúng";
						this.txtmatkhau.Text = "";
						this.txtmatkhau.Focus();
					}
				} catch (Exception ex) {
					MessageBox.Show("Chuỗi kết nối tới Database không chính xác, vui lòng xem lại DataProvider", "Lỗi kết nối cơ sở dữ liệu");
				}
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//kiem tra gia tri rong
		private bool IsEmpty()
		{
			return string.IsNullOrEmpty(this.txtdangnhap.Text) || string.IsNullOrEmpty(this.txtmatkhau.Text);
		}

		private void HeThong_DangNhap_Load(object sender, EventArgs e)
		{
			this.AcceptButton = btnDangNhap;
			this.Show();
			txtdangnhap.Focus();
		}
		public HeThong_DangNhap()
		{
			Load += HeThong_DangNhap_Load;
			InitializeComponent();
		}
	}
}
