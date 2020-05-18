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
	public partial class HeThong_PhucHoi
	{
		TaiKhoan_BUS TKBUS = new TaiKhoan_BUS();

		TaiKhoan_DTO TKDTO = new TaiKhoan_DTO();
		private void btnThucHien_Click(object sender, EventArgs e)
		{
			try {
				Timer1.Start();
				ProgressBar1.Visible = true;
				TKBUS.Restore(txtTen.Text);
			} catch (Exception ex) {
				Timer1.Stop();
				ProgressBar1.Visible = false;
				btnThucHien.Visible = true;
				btnHoanThanh.Visible = false;
				Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Lỗi Restore");
				this.labelthanhcong.Text = "(*) Phục hồi thất bại!";
				this.labelform.Text = "";
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtTen_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
			OpenFileDialog1.Title = "Chọn đường dẫn tới file Backup";
			OpenFileDialog1.Filter = "Backup Database File | *.bak";
			if (OpenFileDialog1.ShowDialog() == DialogResult.OK) {
				txtTen.EditValue = OpenFileDialog1.FileName.ToString();
			}
		}

		private void btnHoanThanh_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			ProgressBar1.Increment(1);
			if (ProgressBar1.Value == ProgressBar1.Maximum) {
				Timer1.Stop();
				this.labelthanhcong.Text = "Phục hồi thành công!";
				this.labelform.Text = "";
				ProgressBar1.Visible = false;
				btnThucHien.Visible = false;
				btnHoanThanh.Visible = true;
				this.btnHoanThanh.Focus();
				Log_BUS.ThemNhatKy("Dữ liệu", "Phục hồi dữ liệu");
			}
		}
		public HeThong_PhucHoi()
		{
			InitializeComponent();
		}
	}
}
