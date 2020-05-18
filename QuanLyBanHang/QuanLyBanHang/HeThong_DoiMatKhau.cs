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
	public partial class HeThong_DoiMatKhau
	{

		TaiKhoan_BUS TKBUS = new TaiKhoan_BUS();
		string a;
		string b;
		string c;
		string d;
		private void btnDongY_Click_1(object sender, EventArgs e)
		{
			if (IsEmpty()) {
				this.labelform.Text = "";
				this.labelthanhcong.Text = "(*) Thông tin bắt buộc không được để trống";
			} else {
				a = txtuser.Text;
				b = txtmatkhaucudmk.Text;
				c = txtmatkhaumoidmk.Text;
				d = txtnhaplaimatkhaudmk.Text;
				if (txtmatkhaumoidmk.Text == txtnhaplaimatkhaudmk.Text) {
					if (txtmatkhaucudmk.Text != txtmatkhaumoidmk.Text) {
						if ((TKBUS.ThayDoiMatKhau(a, b, c, d) == 1)) {
							this.labelform.Text = "";
							this.labelthanhcong.Text = "Bạn đã thay đổi mật khẩu thành công";
							this.labeltrung.Text = "";
						} else {
							this.labeltrung.Text = "";
							this.labelform.Text = "";
							this.labelthanhcong.Text = "(*) Mật khẩu cũ không chính xác";
						}
					} else {
						this.labelform.Text = "";
						this.labeltrung.Text = "(*) Mật khẩu mới không được trùng với mật khẩu cũ";
						this.labelthanhcong.Text = "";
					}
				} else {
					this.labelform.Text = "";
					this.labelthanhcong.Text = "(*) Nhập lại mật khẩu không chính xác";
					this.labeltrung.Text = "";
				}
			}
		}
		private void frmdoimatkhau_Load(System.Object sender, System.EventArgs e)
		{
			Log_BUS.ThemNhatKy("Hệ thống", "Đổi mật khẩu");
			this.AcceptButton = btnDongY;
		}
		private void btnThoat_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}
		private bool IsEmpty()
		{
			return string.IsNullOrEmpty(this.txtmatkhaucudmk.Text) || string.IsNullOrEmpty(this.txtmatkhaumoidmk.Text) || string.IsNullOrEmpty(this.txtnhaplaimatkhaudmk.Text);
		}
		public HeThong_DoiMatKhau()
		{
			Load += frmdoimatkhau_Load;
			InitializeComponent();
		}
	}
}
