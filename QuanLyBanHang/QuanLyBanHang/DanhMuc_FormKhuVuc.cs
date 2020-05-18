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
	public partial class DanhMuc_FormKhuVuc
	{
		public void LoadTatCaKhuVuc()
		{
			GridControl1.DataSource = KhuVucBUS.KiemTraLoad();
		}
		private void DanhMuc_FormKhuVuc_Load(object sender, EventArgs e)
		{
			LoadTatCaKhuVuc();
			Log_BUS.ThemNhatKy("Khu vực", "Xem danh sách khu vực");
		}

		private void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			DanhMuc_ThemKhuVuc f = new DanhMuc_ThemKhuVuc();
			f.eventThemXong += LoadTatCaKhuVuc;
			f.ShowDialog();
		}

		private void BarButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			DanhMuc_SuaKhuVuc f = new DanhMuc_SuaKhuVuc();
			int[] i = GridView1.GetSelectedRows();
			KhuVucDTO kv = (List<KhuVucDTO>)GridControl1.DataSource[i[0]];
			f.txtMaKhuVuc.Text = kv.MaKhuVuc.ToString;
			f.txtTen.Text = kv.TenKhuVuc.ToString;
			f.txtGhiChu.Text = kv.GhiChu.ToString;
			if (kv.ConQuanLy) {
				f.chxConQuanLy.Checked = true;
			} else {
				f.chxConQuanLy.Checked = false;
			}
			f.eventSuaXong += LoadTatCaKhuVuc;
			f.ShowDialog();
		}

		private void BarButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			int[] i = GridView1.GetSelectedRows();
			int makv = Convert.ToInt32(GridView1.GetRowCellValue(i[0], "MaKhuVuc"));
			bool check = KhuVucBUS.KiemTraXoa(makv);
			if (check) {
				LoadTatCaKhuVuc();
				Interaction.MsgBox("Xóa thành công!");
				Log_BUS.ThemNhatKy("Khu vực", "Xóa khu vực");
			} else {
				Interaction.MsgBox("Xóa thất bại!");
			}
		}

		private void BarButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.Close();
		}
		public DanhMuc_FormKhuVuc()
		{
			Load += DanhMuc_FormKhuVuc_Load;
			InitializeComponent();
		}
	}
}
