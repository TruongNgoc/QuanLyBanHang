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
	public partial class HeThong_SaoLuu
	{
		TaiKhoan_BUS TKBUS = new TaiKhoan_BUS();
		TaiKhoan_DTO TKDTO = new TaiKhoan_DTO();
		private void HeThong_SaoLuu_Load(object sender, EventArgs e)
		{
			txtTen.Text = "QuanLyBanHang";
			txtDuongDan.Text = "D:\\";
		}

		private void btnThucHien_Click(object sender, EventArgs e)
		{
			try {
				if (string.IsNullOrEmpty(txtTen.Text)) {
					this.labelthanhcong.Text = "(*) Bạn chưa đặt tên cho file backup!";
					this.labelform.Text = "";
					return;
				}
				string ten = "\\" + txtTen.Text + " " + System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString() + " " + System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString() + "-" + System.DateTime.Now.Second.ToString() + ".bak";
				string duongdan = txtDuongDan.Text;
				Timer1.Start();
				ProgressBar1.Visible = true;
				TKBUS.Backup(ten, duongdan);
			} catch (Exception ex) {
				Timer1.Stop();
				ProgressBar1.Visible = false;
				btnThucHien.Visible = true;
				btnHoanThanh.Visible = false;
				Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Lỗi Backup");
				this.labelthanhcong.Text = "(*) Bạn vui lòng chọn lại đường dẫn hợp lệ";
				this.labelform.Text = "";
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtDuongDan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			FolderBrowserDialog1.Description = "Chọn đường dẫn tới ổ D, E (trừ ổ hệ thống)";
			if (FolderBrowserDialog1.ShowDialog() == DialogResult.OK) {
				txtDuongDan.EditValue = FolderBrowserDialog1.SelectedPath.ToString();
			}
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			ProgressBar1.Increment(1);
			if (ProgressBar1.Value == ProgressBar1.Maximum) {
				Timer1.Stop();
				this.labelthanhcong.Text = "Cơ sở dữ liệu đã được Backup thành công";
				this.labelform.Text = "";
				ProgressBar1.Visible = false;
				btnThucHien.Visible = false;
				btnHoanThanh.Visible = true;
				this.btnHoanThanh.Focus();
				Log_BUS.ThemNhatKy("Dữ liệu", "Sao lưu dữ liệu");
			}
		}

		private void btnHoanThanh_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		public HeThong_SaoLuu()
		{
			Load += HeThong_SaoLuu_Load;
			InitializeComponent();
		}
	}
}
