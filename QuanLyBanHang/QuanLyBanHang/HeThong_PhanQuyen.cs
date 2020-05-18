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
	public partial class HeThong_PhanQuyen
	{
		public void LoadDuLieu()
		{
			LoadGridVaiTro();
			LoadGridColumnVaiTro();
			LoadGridNguoiDung();
		}

		private void LoadGridVaiTro()
		{
			gridVaiTro.DataSource = TaiKhoan_BUS.LayHetVaiTro();

		}

		private void LoadGridNguoiDung()
		{
			gridNguoiDung.DataSource = TaiKhoan_BUS.LayHetNguoiDung();
		}

		private void LoadGridColumnVaiTro()
		{
			RepositoryItemCheckedComboBoxEdit1.DataSource = TaiKhoan_BUS.LayHetVaiTro();
			RepositoryItemCheckedComboBoxEdit1.ValueMember = "MaVaiTro";
			RepositoryItemCheckedComboBoxEdit1.DisplayMember = "Ten";
		}
		private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.Close();
		}

		private void btnThemVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			HT_PhanQuyen_ThemVaiTro f = new HT_PhanQuyen_ThemVaiTro();
			f.eventThemXong += LoadDuLieu;
			f.ShowDialog();
		}

		private void btnSuaVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			int[] l = GridView1.GetSelectedRows();
			var index = l[0];
			HT_PhanQuyen_SuaVaiTro f = new HT_PhanQuyen_SuaVaiTro();
			f.VaiTroSua = (List<VaiTroDTO>)gridVaiTro.DataSource[index];
			f.eventThemXong += LoadDuLieu;
			f.ShowDialog();
		}

		private void btnXoaVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			int[] l = GridView1.GetSelectedRows();
			var index = l[0];
			switch (Interaction.MsgBox("Bạn có chắc chắn muốn xóa vai trò này không?", MsgBoxStyle.YesNo, "Xóa")) {
				case MsgBoxResult.Yes:
					VaiTroDTO vt = null;
					vt = (List<VaiTroDTO>)gridVaiTro.DataSource[index];
					bool test = TaiKhoan_BUS.XoaVaiTro(vt);

					if (test == true) {
						LoadGridVaiTro();
						Interaction.MsgBox("Xóa thành công");
					} else {
						Interaction.MsgBox("Xóa không thành công");
					}
					break;
				case MsgBoxResult.No:
					return;

					break;
			}
		}

		private void HeThong_PhanQuyen_Load(object sender, EventArgs e)
		{
			LoadDuLieu();
		}

		private void btnThemND_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			HT_PhanQuyen_ThemNguoiDung f = new HT_PhanQuyen_ThemNguoiDung();
			f.eventThemXong += LoadDuLieu;
			f.ShowDialog();
		}

		private void btnSuaND_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			int[] l = GridView2.GetSelectedRows();
			var index = l[0];
			HT_PhanQuyen_SuaNguoiDung f = new HT_PhanQuyen_SuaNguoiDung();
			f.NguoiDungSua = (List<TaiKhoan_DTO>)gridNguoiDung.DataSource[index];
			f.eventSuaXong += LoadDuLieu;
			f.ShowDialog();
		}

		private void btnXoaND_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			int[] l = GridView2.GetSelectedRows();
			var index = l[0];
			switch (Interaction.MsgBox("Bạn có chắc chắn muốn xóa người dùng này không?", MsgBoxStyle.YesNo, "Xóa")) {
				case MsgBoxResult.Yes:
					TaiKhoan_DTO nd = null;
					nd = (List<TaiKhoan_DTO>)gridNguoiDung.DataSource[index];
					bool test = TaiKhoan_BUS.XoaNguoiDung(nd);
					if (test == true) {
						LoadGridNguoiDung();

						Interaction.MsgBox("Xóa thành công");
					} else {
						Interaction.MsgBox("Xóa không thành công");
					}
					break;
				case MsgBoxResult.No:
					return;

					break;
			}
		}

		private void btnDong2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.Close();
		}
		public HeThong_PhanQuyen()
		{
			Load += HeThong_PhanQuyen_Load;
			InitializeComponent();
		}

	}
}
