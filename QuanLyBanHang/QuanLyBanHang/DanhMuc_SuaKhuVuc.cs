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
	public partial class DanhMuc_SuaKhuVuc
	{
		public delegate void SuaXong();
		public event SuaXong eventSuaXong;
		private void btnLuu_Click(object sender, EventArgs e)
		{
			KhuVucDTO kv = new KhuVucDTO();
			kv.MaKhuVuc = txtMaKhuVuc.Text.Trim();
			kv.TenKhuVuc = txtTen.Text.Trim();
			kv.GhiChu = txtGhiChu.Text.Trim();
			if (chxConQuanLy.Checked == true) {
				kv.ConQuanLy = true;
			} else {
				kv.ConQuanLy = false;
			}
			bool check = KhuVucBUS.KiemTraSua(kv);
			if (check) {
				if (eventSuaXong != null) {
					eventSuaXong();
				}
				Log_BUS.ThemNhatKy("Khu vực", "Sửa thông tin khu vực");
				Interaction.MsgBox("Sửa thành công!");
			} else {
				Interaction.MsgBox("Sửa thất bại!");
			}
		}

		private void btnDong_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		public DanhMuc_SuaKhuVuc()
		{
			InitializeComponent();
		}
	}
}
