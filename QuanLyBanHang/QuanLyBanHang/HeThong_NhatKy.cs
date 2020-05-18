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
namespace GUI
{
	public partial class HeThong_NhatKy
	{
		public void LoadDuLieu()
		{
			GridControl1.DataSource = Log_BUS.KiemTraLoad();
		}

		private void HeThong_NhatKy_Load(object sender, EventArgs e)
		{
			LoadDuLieu();
			string cn = "Nhật ký hệ thống";
			string hd = "Xem nhật ký";
			Log_BUS.ThemNhatKy(cn, hd);
		}

		private void BarButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			int[] i = GridView1.GetSelectedRows();
			if (GridView1.GetRowCellValue(i[0], "ThoiGian") == null) {
				return;
			}
			string tg = GridView1.GetRowCellValue(i[0], "ThoiGian").ToString();
			bool check = Log_BUS.XoaNhatKy(tg);
			if (!check) {
				MessageBox.Show("Xóa không thành công! Vui lòng thử lại!", "Thông báo");
			} else {
				LoadDuLieu();
				MessageBox.Show("Xóa nhật ký thành công!", "Thông báo");
			}
		}

		private void BarButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			switch (Interaction.MsgBox("Bạn có chắc chắn muốn xóa hết nhật ký không?", MsgBoxStyle.YesNo, "Dọn dẹp nhật ký")) {
				case MsgBoxResult.Yes:
					bool check = Log_BUS.XoaHetNhatKy();
					if (check) {
						LoadDuLieu();
						MessageBox.Show("Xóa thành công!");
						Log_BUS.ThemNhatKy("Nhật ký hệ thống", "Xóa sạch nhật ký");
					} else {
						MessageBox.Show("Xóa thất bại");
					}
					break;
				case MsgBoxResult.No:
					return;

					break;
			}
		}

		private void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LoadDuLieu();
		}

		private void BarButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.Close();
		}
		public HeThong_NhatKy()
		{
			Load += HeThong_NhatKy_Load;
			InitializeComponent();
		}
	}
}
