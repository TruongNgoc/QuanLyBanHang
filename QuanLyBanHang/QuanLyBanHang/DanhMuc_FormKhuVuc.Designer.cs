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
namespace GUI
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	partial class DanhMuc_FormKhuVuc : System.Windows.Forms.Form
	{

		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try {
				if (disposing && components != null) {
					components.Dispose();
				}
			} finally {
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer

		private System.ComponentModel.IContainer components;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhMuc_FormKhuVuc));
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.MaKV = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TenKH = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ConQuanLy = new DevExpress.XtraGrid.Columns.GridColumn();
			this.BarManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.Bar2 = new DevExpress.XtraBars.Bar();
			this.BarButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.BarButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			this.BarButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
			this.Bar3 = new DevExpress.XtraBars.Bar();
			this.BarDockControl1 = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.LayoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.LayoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.LayoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.BarButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
			((System.ComponentModel.ISupportInitialize)this.BarManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.LayoutControlGroup1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.LayoutControl1).BeginInit();
			this.LayoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.GridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.LayoutControlItem1).BeginInit();
			this.SuspendLayout();
			//
			//barDockControlTop
			//
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 24);
			this.barDockControlTop.Size = new System.Drawing.Size(792, 0);
			//
			//MaKV
			//
			this.MaKV.Caption = "Mã KV";
			this.MaKV.FieldName = "MaKhuVuc";
			this.MaKV.Name = "MaKV";
			this.MaKV.Visible = true;
			this.MaKV.VisibleIndex = 0;
			//
			//TenKH
			//
			this.TenKH.Caption = "Tên Khu Vực";
			this.TenKH.FieldName = "TenKhuVuc";
			this.TenKH.Name = "TenKH";
			this.TenKH.Visible = true;
			this.TenKH.VisibleIndex = 1;
			//
			//GhiChu
			//
			this.GhiChu.Caption = "Ghi Chú";
			this.GhiChu.FieldName = "GhiChu";
			this.GhiChu.Name = "GhiChu";
			this.GhiChu.Visible = true;
			this.GhiChu.VisibleIndex = 2;
			//
			//ConQuanLy
			//
			this.ConQuanLy.Caption = "Còn Quản Lý";
			this.ConQuanLy.FieldName = "IsDelete";
			this.ConQuanLy.Name = "ConQuanLy";
			this.ConQuanLy.Visible = true;
			this.ConQuanLy.VisibleIndex = 3;
			//
			//BarManager1
			//
			this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
				this.Bar2,
				this.Bar3
			});
			this.BarManager1.DockControls.Add(this.BarDockControl1);
			this.BarManager1.DockControls.Add(this.barDockControlBottom);
			this.BarManager1.DockControls.Add(this.barDockControlLeft);
			this.BarManager1.DockControls.Add(this.barDockControlRight);
			this.BarManager1.Form = this;
			this.BarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
				this.BarButtonItem1,
				this.BarButtonItem2,
				this.BarButtonItem3,
				this.BarButtonItem4
			});
			this.BarManager1.MainMenu = this.Bar2;
			this.BarManager1.MaxItemId = 7;
			this.BarManager1.StatusBar = this.Bar3;
			//
			//Bar2
			//
			this.Bar2.BarName = "Main menu";
			this.Bar2.DockCol = 0;
			this.Bar2.DockRow = 0;
			this.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.Bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
				new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BarButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
				new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BarButtonItem2, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
				new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BarButtonItem3, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
				new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BarButtonItem4, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)
			});
			this.Bar2.OptionsBar.MultiLine = true;
			this.Bar2.OptionsBar.UseWholeRow = true;
			this.Bar2.Text = "Main menu";
			//
			//BarButtonItem1
			//
			this.BarButtonItem1.Caption = "Thêm";
			this.BarButtonItem1.Glyph = (System.Drawing.Image)resources.GetObject("BarButtonItem1.Glyph");
			this.BarButtonItem1.Id = 0;
			this.BarButtonItem1.LargeGlyph = (System.Drawing.Image)resources.GetObject("BarButtonItem1.LargeGlyph");
			this.BarButtonItem1.Name = "BarButtonItem1";
			//
			//BarButtonItem2
			//
			this.BarButtonItem2.Caption = "Sửa";
			this.BarButtonItem2.Glyph = (System.Drawing.Image)resources.GetObject("BarButtonItem2.Glyph");
			this.BarButtonItem2.Id = 1;
			this.BarButtonItem2.LargeGlyph = (System.Drawing.Image)resources.GetObject("BarButtonItem2.LargeGlyph");
			this.BarButtonItem2.Name = "BarButtonItem2";
			//
			//BarButtonItem3
			//
			this.BarButtonItem3.Caption = "Xóa";
			this.BarButtonItem3.Glyph = (System.Drawing.Image)resources.GetObject("BarButtonItem3.Glyph");
			this.BarButtonItem3.Id = 2;
			this.BarButtonItem3.LargeGlyph = (System.Drawing.Image)resources.GetObject("BarButtonItem3.LargeGlyph");
			this.BarButtonItem3.Name = "BarButtonItem3";
			//
			//Bar3
			//
			this.Bar3.BarName = "Status bar";
			this.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.Bar3.DockCol = 0;
			this.Bar3.DockRow = 0;
			this.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.Bar3.OptionsBar.AllowQuickCustomization = false;
			this.Bar3.OptionsBar.DrawDragBorder = false;
			this.Bar3.OptionsBar.UseWholeRow = true;
			this.Bar3.Text = "Status bar";
			//
			//BarDockControl1
			//
			this.BarDockControl1.CausesValidation = false;
			this.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.BarDockControl1.Location = new System.Drawing.Point(0, 0);
			this.BarDockControl1.Size = new System.Drawing.Size(792, 24);
			//
			//barDockControlBottom
			//
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 453);
			this.barDockControlBottom.Size = new System.Drawing.Size(792, 23);
			//
			//barDockControlLeft
			//
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 429);
			//
			//barDockControlRight
			//
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(792, 24);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 429);
			//
			//LayoutControlGroup1
			//
			this.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.LayoutControlGroup1.GroupBordersVisible = false;
			this.LayoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { this.LayoutControlItem1 });
			this.LayoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.LayoutControlGroup1.Name = "Root";
			this.LayoutControlGroup1.Size = new System.Drawing.Size(792, 429);
			this.LayoutControlGroup1.TextVisible = false;
			//
			//LayoutControl1
			//
			this.LayoutControl1.Controls.Add(this.GridControl1);
			this.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LayoutControl1.Location = new System.Drawing.Point(0, 24);
			this.LayoutControl1.Name = "LayoutControl1";
			this.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(572, 194, 250, 350);
			this.LayoutControl1.Root = this.LayoutControlGroup1;
			this.LayoutControl1.Size = new System.Drawing.Size(792, 429);
			this.LayoutControl1.TabIndex = 21;
			this.LayoutControl1.Text = "LayoutControl1";
			//
			//GridColumn1
			//
			this.GridColumn1.Caption = "Mã KV";
			this.GridColumn1.FieldName = "MaKhuVuc";
			this.GridColumn1.Name = "GridColumn1";
			this.GridColumn1.Visible = true;
			this.GridColumn1.VisibleIndex = 0;
			//
			//GridColumn2
			//
			this.GridColumn2.Caption = "Tên Khu Vực";
			this.GridColumn2.FieldName = "TenKhuVuc";
			this.GridColumn2.Name = "GridColumn2";
			this.GridColumn2.Visible = true;
			this.GridColumn2.VisibleIndex = 1;
			//
			//GridColumn3
			//
			this.GridColumn3.Caption = "Ghi Chú";
			this.GridColumn3.FieldName = "GhiChu";
			this.GridColumn3.Name = "GridColumn3";
			this.GridColumn3.Visible = true;
			this.GridColumn3.VisibleIndex = 2;
			//
			//GridColumn4
			//
			this.GridColumn4.Caption = "Còn Quản Lý";
			this.GridColumn4.FieldName = "IsDelete";
			this.GridColumn4.Name = "GridColumn4";
			this.GridColumn4.Visible = true;
			this.GridColumn4.VisibleIndex = 3;
			//
			//GridControl1
			//
			this.GridControl1.Location = new System.Drawing.Point(12, 12);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(768, 405);
			this.GridControl1.TabIndex = 4;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { this.GridView1 });
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
				this.GridColumn5,
				this.GridColumn6,
				this.GridColumn7,
				this.GridColumn8
			});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.Name = "GridView1";
			//
			//GridColumn5
			//
			this.GridColumn5.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn5.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn5.Caption = "Mã";
			this.GridColumn5.FieldName = "MaKhuVuc";
			this.GridColumn5.Name = "GridColumn5";
			this.GridColumn5.OptionsColumn.AllowEdit = false;
			this.GridColumn5.Visible = true;
			this.GridColumn5.VisibleIndex = 0;
			//
			//GridColumn6
			//
			this.GridColumn6.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn6.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn6.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn6.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn6.Caption = "Tên";
			this.GridColumn6.FieldName = "TenKhuVuc";
			this.GridColumn6.Name = "GridColumn6";
			this.GridColumn6.OptionsColumn.AllowEdit = false;
			this.GridColumn6.Visible = true;
			this.GridColumn6.VisibleIndex = 1;
			//
			//GridColumn7
			//
			this.GridColumn7.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn7.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn7.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn7.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn7.Caption = "Ghi chú";
			this.GridColumn7.FieldName = "GhiChu";
			this.GridColumn7.Name = "GridColumn7";
			this.GridColumn7.OptionsColumn.AllowEdit = false;
			this.GridColumn7.Visible = true;
			this.GridColumn7.VisibleIndex = 2;
			//
			//GridColumn8
			//
			this.GridColumn8.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn8.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn8.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn8.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn8.Caption = "Còn quản lý";
			this.GridColumn8.FieldName = "ConQuanLy";
			this.GridColumn8.Name = "GridColumn8";
			this.GridColumn8.OptionsColumn.AllowEdit = false;
			this.GridColumn8.Visible = true;
			this.GridColumn8.VisibleIndex = 3;
			//
			//LayoutControlItem1
			//
			this.LayoutControlItem1.Control = this.GridControl1;
			this.LayoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.LayoutControlItem1.Name = "LayoutControlItem1";
			this.LayoutControlItem1.Size = new System.Drawing.Size(772, 409);
			this.LayoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.LayoutControlItem1.TextVisible = false;
			//
			//BarButtonItem4
			//
			this.BarButtonItem4.Caption = "Đóng";
			this.BarButtonItem4.Glyph = (System.Drawing.Image)resources.GetObject("BarButtonItem4.Glyph");
			this.BarButtonItem4.Id = 6;
			this.BarButtonItem4.LargeGlyph = (System.Drawing.Image)resources.GetObject("BarButtonItem4.LargeGlyph");
			this.BarButtonItem4.Name = "BarButtonItem4";
			//
			//DanhMuc_FormKhuVuc
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 476);
			this.Controls.Add(this.LayoutControl1);
			this.Controls.Add(this.barDockControlTop);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.BarDockControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "DanhMuc_FormKhuVuc";
			this.Text = "Khu Vực";
			((System.ComponentModel.ISupportInitialize)this.BarManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.LayoutControlGroup1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.LayoutControl1).EndInit();
			this.LayoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.GridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.LayoutControlItem1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraGrid.Columns.GridColumn MaKV;
		internal DevExpress.XtraGrid.Columns.GridColumn TenKH;
		internal DevExpress.XtraGrid.Columns.GridColumn GhiChu;
		internal DevExpress.XtraGrid.Columns.GridColumn ConQuanLy;
		internal DevExpress.XtraBars.BarManager BarManager1;
		internal DevExpress.XtraBars.Bar Bar2;
		internal DevExpress.XtraBars.Bar Bar3;
		internal DevExpress.XtraBars.BarDockControl BarDockControl1;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarButtonItem withEventsField_BarButtonItem1;
		internal DevExpress.XtraBars.BarButtonItem BarButtonItem1 {
			get { return withEventsField_BarButtonItem1; }
			set {
				if (withEventsField_BarButtonItem1 != null) {
					withEventsField_BarButtonItem1.ItemClick -= BarButtonItem1_ItemClick;
				}
				withEventsField_BarButtonItem1 = value;
				if (withEventsField_BarButtonItem1 != null) {
					withEventsField_BarButtonItem1.ItemClick += BarButtonItem1_ItemClick;
				}
			}
		}
		private DevExpress.XtraBars.BarButtonItem withEventsField_BarButtonItem2;
		internal DevExpress.XtraBars.BarButtonItem BarButtonItem2 {
			get { return withEventsField_BarButtonItem2; }
			set {
				if (withEventsField_BarButtonItem2 != null) {
					withEventsField_BarButtonItem2.ItemClick -= BarButtonItem2_ItemClick;
				}
				withEventsField_BarButtonItem2 = value;
				if (withEventsField_BarButtonItem2 != null) {
					withEventsField_BarButtonItem2.ItemClick += BarButtonItem2_ItemClick;
				}
			}
		}
		private DevExpress.XtraBars.BarButtonItem withEventsField_BarButtonItem3;
		internal DevExpress.XtraBars.BarButtonItem BarButtonItem3 {
			get { return withEventsField_BarButtonItem3; }
			set {
				if (withEventsField_BarButtonItem3 != null) {
					withEventsField_BarButtonItem3.ItemClick -= BarButtonItem3_ItemClick;
				}
				withEventsField_BarButtonItem3 = value;
				if (withEventsField_BarButtonItem3 != null) {
					withEventsField_BarButtonItem3.ItemClick += BarButtonItem3_ItemClick;
				}
			}
		}
		internal DevExpress.XtraLayout.LayoutControl LayoutControl1;
		internal DevExpress.XtraLayout.LayoutControlGroup LayoutControlGroup1;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn4;
		private DevExpress.XtraBars.BarButtonItem withEventsField_BarButtonItem4;
		internal DevExpress.XtraBars.BarButtonItem BarButtonItem4 {
			get { return withEventsField_BarButtonItem4; }
			set {
				if (withEventsField_BarButtonItem4 != null) {
					withEventsField_BarButtonItem4.ItemClick -= BarButtonItem4_ItemClick;
				}
				withEventsField_BarButtonItem4 = value;
				if (withEventsField_BarButtonItem4 != null) {
					withEventsField_BarButtonItem4.ItemClick += BarButtonItem4_ItemClick;
				}
			}
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn5;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn6;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn7;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn8;
		internal DevExpress.XtraLayout.LayoutControlItem LayoutControlItem1;
	}
}
