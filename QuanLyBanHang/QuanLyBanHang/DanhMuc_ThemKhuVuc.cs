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
	public partial class DanhMuc_ThemKhuVuc
	{
		public delegate void ThemXong();
		public event ThemXong eventThemXong;
		private void btnDong_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			KhuVucDTO kv = new KhuVucDTO();
			kv.TenKhuVuc = txtTen.Text;
			kv.GhiChu = txtGhiChu.Text;
			if (chxConQuanLy.Checked == true) {
				kv.ConQuanLy = true;
			} else {
				kv.ConQuanLy = false;
			}
			bool check = KhuVucBUS.KiemTraThem(kv);
			if (check) {
				if (eventThemXong != null) {
					eventThemXong();
				}
				Interaction.MsgBox("Thêm thành công!");
				Log_BUS.ThemNhatKy("Khu vực", "Thêm khu vực");
			} else {
				Interaction.MsgBox("Thêm thất bại!");
			}
		}
		public DanhMuc_ThemKhuVuc()
		{
			InitializeComponent();
		}
	}
}
