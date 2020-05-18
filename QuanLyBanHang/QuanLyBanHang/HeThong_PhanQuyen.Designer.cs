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
	partial class HeThong_PhanQuyen : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeThong_PhanQuyen));
			this.BarManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.Bar2 = new DevExpress.XtraBars.Bar();
			this.btnThemVT = new DevExpress.XtraBars.BarButtonItem();
			this.btnSuaVT = new DevExpress.XtraBars.BarButtonItem();
			this.btnXoaVT = new DevExpress.XtraBars.BarButtonItem();
			this.btnDong = new DevExpress.XtraBars.BarButtonItem();
			this.Bar3 = new DevExpress.XtraBars.Bar();
			this.btnThemND = new DevExpress.XtraBars.BarButtonItem();
			this.btnSuaND = new DevExpress.XtraBars.BarButtonItem();
			this.btnXoaND = new DevExpress.XtraBars.BarButtonItem();
			this.btnDong2 = new DevExpress.XtraBars.BarButtonItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.DockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
			this.DockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
			this.DockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
			this.LayoutControl5 = new DevExpress.XtraLayout.LayoutControl();
			this.gridVaiTro = new DevExpress.XtraGrid.GridControl();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn30 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.LayoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.LayoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.DockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
			this.DockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
			this.LayoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.gridNguoiDung = new DevExpress.XtraGrid.GridControl();
			this.GridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumnVaiTro = new DevExpress.XtraGrid.Columns.GridColumn();
			this.RepositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
			this.GridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.RepositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.LayoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.LayoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)this.BarManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.DockManager1).BeginInit();
			this.DockPanel1.SuspendLayout();
			this.DockPanel1_Container.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.LayoutControl5).BeginInit();
			this.LayoutControl5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.gridVaiTro).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.GridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.LayoutControlGroup5).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.LayoutControlItem1).BeginInit();
			this.DockPanel2.SuspendLayout();
			this.DockPanel2_Container.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.LayoutControl1).BeginInit();
			this.LayoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.gridNguoiDung).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.GridView2).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemCheckedComboBoxEdit1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemTextEdit1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.LayoutControlGroup1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.LayoutControlItem2).BeginInit();
			this.SuspendLayout();
			//
			//BarManager1
			//
			this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
				this.Bar2,
				this.Bar3
			});
			this.BarManager1.DockControls.Add(this.barDockControlTop);
			this.BarManager1.DockControls.Add(this.barDockControlBottom);
			this.BarManager1.DockControls.Add(this.barDockControlLeft);
			this.BarManager1.DockControls.Add(this.barDockControlRight);
			this.BarManager1.DockManager = this.DockManager1;
			this.BarManager1.Form = this;
			this.BarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
				this.btnThemVT,
				this.btnSuaVT,
				this.btnXoaVT,
				this.btnDong,
				this.btnThemND,
				this.btnSuaND,
				this.btnXoaND,
				this.btnDong2
			});
			this.BarManager1.MainMenu = this.Bar2;
			this.BarManager1.MaxItemId = 8;
			this.BarManager1.StatusBar = this.Bar3;
			//
			//Bar2
			//
			this.Bar2.BarName = "Main menu";
			this.Bar2.DockCol = 0;
			this.Bar2.DockRow = 0;
			this.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.Bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
				new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
				new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaVT, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
				new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaVT, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
				new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)
			});
			this.Bar2.OptionsBar.MultiLine = true;
			this.Bar2.OptionsBar.UseWholeRow = true;
			this.Bar2.Text = "Main menu";
			//
			//btnThemVT
			//
			this.btnThemVT.Caption = "Thêm Vai Trò";
			this.btnThemVT.Id = 0;
			this.btnThemVT.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnThemVT.ImageOptions.Image");
			this.btnThemVT.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnThemVT.ImageOptions.LargeImage");
			this.btnThemVT.Name = "btnThemVT";
			//
			//btnSuaVT
			//
			this.btnSuaVT.Caption = "Sửa";
			this.btnSuaVT.Id = 1;
			this.btnSuaVT.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnSuaVT.ImageOptions.Image");
			this.btnSuaVT.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnSuaVT.ImageOptions.LargeImage");
			this.btnSuaVT.Name = "btnSuaVT";
			//
			//btnXoaVT
			//
			this.btnXoaVT.Caption = "Xóa";
			this.btnXoaVT.Id = 2;
			this.btnXoaVT.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnXoaVT.ImageOptions.Image");
			this.btnXoaVT.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnXoaVT.ImageOptions.LargeImage");
			this.btnXoaVT.Name = "btnXoaVT";
			//
			//btnDong
			//
			this.btnDong.Caption = "Đóng";
			this.btnDong.Id = 3;
			this.btnDong.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnDong.ImageOptions.Image");
			this.btnDong.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnDong.ImageOptions.LargeImage");
			this.btnDong.Name = "btnDong";
			//
			//Bar3
			//
			this.Bar3.BarName = "Status bar";
			this.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.Bar3.DockCol = 0;
			this.Bar3.DockRow = 0;
			this.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.Bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
				new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemND, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
				new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaND, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
				new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaND, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
				new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong2, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)
			});
			this.Bar3.OptionsBar.AllowQuickCustomization = false;
			this.Bar3.OptionsBar.DrawDragBorder = false;
			this.Bar3.OptionsBar.UseWholeRow = true;
			this.Bar3.Text = "Status bar";
			//
			//btnThemND
			//
			this.btnThemND.Caption = "Thêm Người Dùng";
			this.btnThemND.Id = 4;
			this.btnThemND.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnThemND.ImageOptions.Image");
			this.btnThemND.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnThemND.ImageOptions.LargeImage");
			this.btnThemND.Name = "btnThemND";
			//
			//btnSuaND
			//
			this.btnSuaND.Caption = "Sửa";
			this.btnSuaND.Id = 5;
			this.btnSuaND.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnSuaND.ImageOptions.Image");
			this.btnSuaND.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnSuaND.ImageOptions.LargeImage");
			this.btnSuaND.Name = "btnSuaND";
			//
			//btnXoaND
			//
			this.btnXoaND.Caption = "Xóa";
			this.btnXoaND.Id = 6;
			this.btnXoaND.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnXoaND.ImageOptions.Image");
			this.btnXoaND.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnXoaND.ImageOptions.LargeImage");
			this.btnXoaND.Name = "btnXoaND";
			//
			//btnDong2
			//
			this.btnDong2.Caption = "Đóng";
			this.btnDong2.Id = 7;
			this.btnDong2.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnDong2.ImageOptions.Image");
			this.btnDong2.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnDong2.ImageOptions.LargeImage");
			this.btnDong2.Name = "btnDong2";
			//
			//barDockControlTop
			//
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.BarManager1;
			this.barDockControlTop.Size = new System.Drawing.Size(1362, 24);
			//
			//barDockControlBottom
			//
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 486);
			this.barDockControlBottom.Manager = this.BarManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(1362, 27);
			//
			//barDockControlLeft
			//
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
			this.barDockControlLeft.Manager = this.BarManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 462);
			//
			//barDockControlRight
			//
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(1362, 24);
			this.barDockControlRight.Manager = this.BarManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 462);
			//
			//DockManager1
			//
			this.DockManager1.Form = this;
			this.DockManager1.MenuManager = this.BarManager1;
			this.DockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
				this.DockPanel1,
				this.DockPanel2
			});
			this.DockManager1.TopZIndexControls.AddRange(new string[] {
				"DevExpress.XtraBars.BarDockControl",
				"DevExpress.XtraBars.StandaloneBarDockControl",
				"System.Windows.Forms.StatusBar",
				"System.Windows.Forms.MenuStrip",
				"System.Windows.Forms.StatusStrip",
				"DevExpress.XtraBars.Ribbon.RibbonStatusBar",
				"DevExpress.XtraBars.Ribbon.RibbonControl",
				"DevExpress.XtraBars.Navigation.OfficeNavigationBar",
				"DevExpress.XtraBars.Navigation.TileNavPane",
				"DevExpress.XtraBars.TabFormControl"
			});
			//
			//DockPanel1
			//
			this.DockPanel1.Controls.Add(this.DockPanel1_Container);
			this.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
			this.DockPanel1.FloatVertical = true;
			this.DockPanel1.ID = new System.Guid("e87681b8-6682-4229-a112-6ab538b52746");
			this.DockPanel1.Location = new System.Drawing.Point(0, 24);
			this.DockPanel1.Name = "DockPanel1";
			this.DockPanel1.OriginalSize = new System.Drawing.Size(200, 161);
			this.DockPanel1.Size = new System.Drawing.Size(1362, 161);
			this.DockPanel1.Text = "Vai Trò";
			//
			//DockPanel1_Container
			//
			this.DockPanel1_Container.Controls.Add(this.LayoutControl5);
			this.DockPanel1_Container.Location = new System.Drawing.Point(4, 23);
			this.DockPanel1_Container.Name = "DockPanel1_Container";
			this.DockPanel1_Container.Size = new System.Drawing.Size(1354, 133);
			this.DockPanel1_Container.TabIndex = 0;
			//
			//LayoutControl5
			//
			this.LayoutControl5.Controls.Add(this.gridVaiTro);
			this.LayoutControl5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LayoutControl5.Location = new System.Drawing.Point(0, 0);
			this.LayoutControl5.Name = "LayoutControl5";
			this.LayoutControl5.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(282, 190, 250, 350);
			this.LayoutControl5.Root = this.LayoutControlGroup5;
			this.LayoutControl5.Size = new System.Drawing.Size(1354, 133);
			this.LayoutControl5.TabIndex = 0;
			this.LayoutControl5.Text = "LayoutControl5";
			//
			//gridVaiTro
			//
			this.gridVaiTro.Location = new System.Drawing.Point(12, 12);
			this.gridVaiTro.MainView = this.GridView1;
			this.gridVaiTro.Name = "gridVaiTro";
			this.gridVaiTro.Size = new System.Drawing.Size(1330, 109);
			this.gridVaiTro.TabIndex = 13;
			this.gridVaiTro.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { this.GridView1 });
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
				this.GridColumn5,
				this.GridColumn7,
				this.GridColumn8,
				this.GridColumn9,
				this.GridColumn10,
				this.GridColumn11,
				this.GridColumn12,
				this.GridColumn13,
				this.GridColumn14,
				this.GridColumn15,
				this.GridColumn16,
				this.GridColumn17,
				this.GridColumn18,
				this.GridColumn19,
				this.GridColumn20,
				this.GridColumn21,
				this.GridColumn22,
				this.GridColumn23,
				this.GridColumn24,
				this.GridColumn25,
				this.GridColumn26,
				this.GridColumn27,
				this.GridColumn28,
				this.GridColumn29,
				this.GridColumn30
			});
			this.GridView1.GridControl = this.gridVaiTro;
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.OptionsView.ShowGroupPanel = false;
			//
			//GridColumn5
			//
			this.GridColumn5.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn5.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn5.Caption = "Mã vai trò";
			this.GridColumn5.FieldName = "MaVaiTro";
			this.GridColumn5.Name = "GridColumn5";
			this.GridColumn5.OptionsColumn.AllowEdit = false;
			this.GridColumn5.Visible = true;
			this.GridColumn5.VisibleIndex = 0;
			//
			//GridColumn7
			//
			this.GridColumn7.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn7.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn7.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn7.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn7.Caption = "Tên";
			this.GridColumn7.FieldName = "Ten";
			this.GridColumn7.Name = "GridColumn7";
			this.GridColumn7.OptionsColumn.AllowEdit = false;
			this.GridColumn7.Visible = true;
			this.GridColumn7.VisibleIndex = 1;
			//
			//GridColumn8
			//
			this.GridColumn8.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn8.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn8.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn8.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn8.Caption = "Phân quyền";
			this.GridColumn8.FieldName = "PhanQuyen";
			this.GridColumn8.Name = "GridColumn8";
			this.GridColumn8.OptionsColumn.AllowEdit = false;
			this.GridColumn8.Visible = true;
			this.GridColumn8.VisibleIndex = 2;
			//
			//GridColumn9
			//
			this.GridColumn9.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn9.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn9.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn9.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn9.Caption = "Đổi mật khẩu";
			this.GridColumn9.FieldName = "DoiMatKhau";
			this.GridColumn9.Name = "GridColumn9";
			this.GridColumn9.OptionsColumn.AllowEdit = false;
			this.GridColumn9.Visible = true;
			this.GridColumn9.VisibleIndex = 3;
			//
			//GridColumn10
			//
			this.GridColumn10.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn10.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn10.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn10.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn10.Caption = "Nhật ký";
			this.GridColumn10.FieldName = "NhatKyHeThong";
			this.GridColumn10.Name = "GridColumn10";
			this.GridColumn10.OptionsColumn.AllowEdit = false;
			this.GridColumn10.Visible = true;
			this.GridColumn10.VisibleIndex = 4;
			//
			//GridColumn11
			//
			this.GridColumn11.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn11.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn11.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn11.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn11.Caption = "Sao lưu";
			this.GridColumn11.FieldName = "SaoLuu";
			this.GridColumn11.Name = "GridColumn11";
			this.GridColumn11.OptionsColumn.AllowEdit = false;
			this.GridColumn11.Visible = true;
			this.GridColumn11.VisibleIndex = 5;
			//
			//GridColumn12
			//
			this.GridColumn12.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn12.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn12.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn12.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn12.Caption = "Phục hồi";
			this.GridColumn12.FieldName = "PhucHoi";
			this.GridColumn12.Name = "GridColumn12";
			this.GridColumn12.OptionsColumn.AllowEdit = false;
			this.GridColumn12.Visible = true;
			this.GridColumn12.VisibleIndex = 6;
			//
			//GridColumn13
			//
			this.GridColumn13.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn13.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn13.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn13.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn13.Caption = "Khu vực";
			this.GridColumn13.FieldName = "KhuVuc";
			this.GridColumn13.Name = "GridColumn13";
			this.GridColumn13.OptionsColumn.AllowEdit = false;
			this.GridColumn13.Visible = true;
			this.GridColumn13.VisibleIndex = 7;
			//
			//GridColumn14
			//
			this.GridColumn14.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn14.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn14.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn14.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn14.Caption = "Khách hàng";
			this.GridColumn14.FieldName = "KhachHang";
			this.GridColumn14.Name = "GridColumn14";
			this.GridColumn14.OptionsColumn.AllowEdit = false;
			this.GridColumn14.Visible = true;
			this.GridColumn14.VisibleIndex = 8;
			//
			//GridColumn15
			//
			this.GridColumn15.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn15.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn15.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn15.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn15.Caption = "Nhà cung cấp";
			this.GridColumn15.FieldName = "NhaCungCap";
			this.GridColumn15.Name = "GridColumn15";
			this.GridColumn15.OptionsColumn.AllowEdit = false;
			this.GridColumn15.Visible = true;
			this.GridColumn15.VisibleIndex = 9;
			//
			//GridColumn16
			//
			this.GridColumn16.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn16.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn16.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn16.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn16.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn16.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn16.Caption = "Kho hàng";
			this.GridColumn16.FieldName = "KhoHang";
			this.GridColumn16.Name = "GridColumn16";
			this.GridColumn16.OptionsColumn.AllowEdit = false;
			this.GridColumn16.Visible = true;
			this.GridColumn16.VisibleIndex = 10;
			//
			//GridColumn17
			//
			this.GridColumn17.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn17.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn17.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn17.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn17.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn17.Caption = "Đơn vị tính";
			this.GridColumn17.FieldName = "DonViTinh";
			this.GridColumn17.Name = "GridColumn17";
			this.GridColumn17.OptionsColumn.AllowEdit = false;
			this.GridColumn17.Visible = true;
			this.GridColumn17.VisibleIndex = 11;
			//
			//GridColumn18
			//
			this.GridColumn18.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn18.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn18.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn18.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn18.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn18.Caption = "Nhóm hàng";
			this.GridColumn18.FieldName = "NhomHang";
			this.GridColumn18.Name = "GridColumn18";
			this.GridColumn18.OptionsColumn.AllowEdit = false;
			this.GridColumn18.Visible = true;
			this.GridColumn18.VisibleIndex = 12;
			//
			//GridColumn19
			//
			this.GridColumn19.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn19.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn19.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn19.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn19.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn19.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn19.Caption = "Hàng hóa";
			this.GridColumn19.FieldName = "HangHoa";
			this.GridColumn19.Name = "GridColumn19";
			this.GridColumn19.OptionsColumn.AllowEdit = false;
			this.GridColumn19.Visible = true;
			this.GridColumn19.VisibleIndex = 13;
			//
			//GridColumn20
			//
			this.GridColumn20.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn20.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn20.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn20.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn20.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn20.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn20.Caption = "Tỷ giá";
			this.GridColumn20.FieldName = "TyGia";
			this.GridColumn20.Name = "GridColumn20";
			this.GridColumn20.OptionsColumn.AllowEdit = false;
			this.GridColumn20.Visible = true;
			this.GridColumn20.VisibleIndex = 14;
			//
			//GridColumn21
			//
			this.GridColumn21.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn21.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn21.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn21.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn21.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn21.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn21.Caption = "Bộ phận";
			this.GridColumn21.FieldName = "BoPhan";
			this.GridColumn21.Name = "GridColumn21";
			this.GridColumn21.OptionsColumn.AllowEdit = false;
			this.GridColumn21.Visible = true;
			this.GridColumn21.VisibleIndex = 15;
			//
			//GridColumn22
			//
			this.GridColumn22.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn22.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn22.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn22.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn22.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn22.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn22.Caption = "Nhân viên";
			this.GridColumn22.FieldName = "NhanVien";
			this.GridColumn22.Name = "GridColumn22";
			this.GridColumn22.OptionsColumn.AllowEdit = false;
			this.GridColumn22.Visible = true;
			this.GridColumn22.VisibleIndex = 16;
			//
			//GridColumn23
			//
			this.GridColumn23.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn23.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn23.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn23.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn23.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn23.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn23.Caption = "Mua hàng";
			this.GridColumn23.FieldName = "MuaHang";
			this.GridColumn23.Name = "GridColumn23";
			this.GridColumn23.OptionsColumn.AllowEdit = false;
			this.GridColumn23.Visible = true;
			this.GridColumn23.VisibleIndex = 17;
			//
			//GridColumn24
			//
			this.GridColumn24.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn24.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn24.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn24.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn24.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn24.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn24.Caption = "Bán hàng";
			this.GridColumn24.FieldName = "BanHang";
			this.GridColumn24.Name = "GridColumn24";
			this.GridColumn24.OptionsColumn.AllowEdit = false;
			this.GridColumn24.Visible = true;
			this.GridColumn24.VisibleIndex = 18;
			//
			//GridColumn25
			//
			this.GridColumn25.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn25.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn25.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn25.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn25.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn25.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn25.Caption = "Tồn kho";
			this.GridColumn25.FieldName = "TonKho";
			this.GridColumn25.Name = "GridColumn25";
			this.GridColumn25.OptionsColumn.AllowEdit = false;
			this.GridColumn25.Visible = true;
			this.GridColumn25.VisibleIndex = 19;
			//
			//GridColumn26
			//
			this.GridColumn26.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn26.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn26.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn26.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn26.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn26.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn26.Caption = "Chuyển kho";
			this.GridColumn26.FieldName = "ChuyenKho";
			this.GridColumn26.Name = "GridColumn26";
			this.GridColumn26.OptionsColumn.AllowEdit = false;
			this.GridColumn26.Visible = true;
			this.GridColumn26.VisibleIndex = 20;
			//
			//GridColumn27
			//
			this.GridColumn27.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn27.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn27.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn27.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn27.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn27.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn27.Caption = "Thu tiền";
			this.GridColumn27.FieldName = "ThuTien";
			this.GridColumn27.Name = "GridColumn27";
			this.GridColumn27.OptionsColumn.AllowEdit = false;
			this.GridColumn27.Visible = true;
			this.GridColumn27.VisibleIndex = 21;
			//
			//GridColumn28
			//
			this.GridColumn28.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn28.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn28.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn28.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn28.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn28.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn28.Caption = "Trả tiền";
			this.GridColumn28.FieldName = "TraTien";
			this.GridColumn28.Name = "GridColumn28";
			this.GridColumn28.OptionsColumn.AllowEdit = false;
			this.GridColumn28.Visible = true;
			this.GridColumn28.VisibleIndex = 22;
			//
			//GridColumn29
			//
			this.GridColumn29.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn29.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn29.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn29.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn29.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn29.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn29.Caption = "Báo cáo kho hàng";
			this.GridColumn29.FieldName = "BaoCaoKhoHang";
			this.GridColumn29.Name = "GridColumn29";
			this.GridColumn29.OptionsColumn.AllowEdit = false;
			this.GridColumn29.Visible = true;
			this.GridColumn29.VisibleIndex = 23;
			//
			//GridColumn30
			//
			this.GridColumn30.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn30.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn30.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn30.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn30.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn30.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn30.Caption = "Báo cáo bán hàng";
			this.GridColumn30.FieldName = "BaoCaoBanHang";
			this.GridColumn30.Name = "GridColumn30";
			this.GridColumn30.OptionsColumn.AllowEdit = false;
			this.GridColumn30.Visible = true;
			this.GridColumn30.VisibleIndex = 24;
			//
			//LayoutControlGroup5
			//
			this.LayoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.LayoutControlGroup5.GroupBordersVisible = false;
			this.LayoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { this.LayoutControlItem1 });
			this.LayoutControlGroup5.Location = new System.Drawing.Point(0, 0);
			this.LayoutControlGroup5.Name = "Root";
			this.LayoutControlGroup5.Size = new System.Drawing.Size(1354, 133);
			this.LayoutControlGroup5.TextVisible = false;
			//
			//LayoutControlItem1
			//
			this.LayoutControlItem1.Control = this.gridVaiTro;
			this.LayoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.LayoutControlItem1.Name = "LayoutControlItem1";
			this.LayoutControlItem1.Size = new System.Drawing.Size(1334, 113);
			this.LayoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.LayoutControlItem1.TextVisible = false;
			//
			//DockPanel2
			//
			this.DockPanel2.Controls.Add(this.DockPanel2_Container);
			this.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
			this.DockPanel2.FloatVertical = true;
			this.DockPanel2.ID = new System.Guid("4d8a376f-b76c-421a-b7af-70aa8fec7893");
			this.DockPanel2.Location = new System.Drawing.Point(0, 190);
			this.DockPanel2.Name = "DockPanel2";
			this.DockPanel2.OriginalSize = new System.Drawing.Size(200, 296);
			this.DockPanel2.Size = new System.Drawing.Size(1362, 296);
			this.DockPanel2.Text = "Người Dùng";
			//
			//DockPanel2_Container
			//
			this.DockPanel2_Container.Controls.Add(this.LayoutControl1);
			this.DockPanel2_Container.Location = new System.Drawing.Point(4, 24);
			this.DockPanel2_Container.Name = "DockPanel2_Container";
			this.DockPanel2_Container.Size = new System.Drawing.Size(1354, 268);
			this.DockPanel2_Container.TabIndex = 0;
			//
			//LayoutControl1
			//
			this.LayoutControl1.Controls.Add(this.gridNguoiDung);
			this.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LayoutControl1.Location = new System.Drawing.Point(0, 0);
			this.LayoutControl1.Name = "LayoutControl1";
			this.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(650, 244, 250, 350);
			this.LayoutControl1.Root = this.LayoutControlGroup1;
			this.LayoutControl1.Size = new System.Drawing.Size(1354, 268);
			this.LayoutControl1.TabIndex = 0;
			this.LayoutControl1.Text = "LayoutControl1";
			//
			//gridNguoiDung
			//
			this.gridNguoiDung.Location = new System.Drawing.Point(12, 12);
			this.gridNguoiDung.MainView = this.GridView2;
			this.gridNguoiDung.Name = "gridNguoiDung";
			this.gridNguoiDung.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
				this.RepositoryItemCheckedComboBoxEdit1,
				this.RepositoryItemTextEdit1
			});
			this.gridNguoiDung.Size = new System.Drawing.Size(1330, 244);
			this.gridNguoiDung.TabIndex = 13;
			this.gridNguoiDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { this.GridView2 });
			//
			//GridView2
			//
			this.GridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
				this.GridColumn1,
				this.GridColumn2,
				this.GridColumn3,
				this.GridColumnVaiTro,
				this.GridColumn6,
				this.GridColumn4
			});
			this.GridView2.GridControl = this.gridNguoiDung;
			this.GridView2.Name = "GridView2";
			this.GridView2.OptionsBehavior.Editable = false;
			//
			//GridColumn1
			//
			this.GridColumn1.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn1.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn1.Caption = "Mã người dùng";
			this.GridColumn1.FieldName = "MaNguoiDung";
			this.GridColumn1.Name = "GridColumn1";
			this.GridColumn1.OptionsColumn.AllowEdit = false;
			this.GridColumn1.Visible = true;
			this.GridColumn1.VisibleIndex = 0;
			//
			//GridColumn2
			//
			this.GridColumn2.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn2.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn2.Caption = "Tên";
			this.GridColumn2.FieldName = "Ten";
			this.GridColumn2.Name = "GridColumn2";
			this.GridColumn2.OptionsColumn.AllowEdit = false;
			this.GridColumn2.Visible = true;
			this.GridColumn2.VisibleIndex = 1;
			//
			//GridColumn3
			//
			this.GridColumn3.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn3.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn3.Caption = "Tài khoản";
			this.GridColumn3.FieldName = "TaiKhoan";
			this.GridColumn3.Name = "GridColumn3";
			this.GridColumn3.OptionsColumn.AllowEdit = false;
			this.GridColumn3.Visible = true;
			this.GridColumn3.VisibleIndex = 2;
			//
			//GridColumnVaiTro
			//
			this.GridColumnVaiTro.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumnVaiTro.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumnVaiTro.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumnVaiTro.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumnVaiTro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumnVaiTro.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumnVaiTro.Caption = "Vai Trò";
			this.GridColumnVaiTro.ColumnEdit = this.RepositoryItemCheckedComboBoxEdit1;
			this.GridColumnVaiTro.FieldName = "MaVaiTro";
			this.GridColumnVaiTro.Name = "GridColumnVaiTro";
			this.GridColumnVaiTro.OptionsColumn.AllowEdit = false;
			this.GridColumnVaiTro.Visible = true;
			this.GridColumnVaiTro.VisibleIndex = 4;
			//
			//RepositoryItemCheckedComboBoxEdit1
			//
			this.RepositoryItemCheckedComboBoxEdit1.AutoHeight = false;
			this.RepositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			this.RepositoryItemCheckedComboBoxEdit1.Name = "RepositoryItemCheckedComboBoxEdit1";
			//
			//GridColumn6
			//
			this.GridColumn6.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn6.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn6.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn6.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn6.Caption = "Ghi chú";
			this.GridColumn6.FieldName = "GhiChu";
			this.GridColumn6.Name = "GridColumn6";
			this.GridColumn6.OptionsColumn.AllowEdit = false;
			this.GridColumn6.Visible = true;
			this.GridColumn6.VisibleIndex = 5;
			//
			//GridColumn4
			//
			this.GridColumn4.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn4.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GridColumn4.Caption = "Mật khẩu";
			this.GridColumn4.ColumnEdit = this.RepositoryItemTextEdit1;
			this.GridColumn4.FieldName = "MatKhau";
			this.GridColumn4.Name = "GridColumn4";
			this.GridColumn4.OptionsColumn.AllowEdit = false;
			this.GridColumn4.Visible = true;
			this.GridColumn4.VisibleIndex = 3;
			//
			//RepositoryItemTextEdit1
			//
			this.RepositoryItemTextEdit1.AutoHeight = false;
			this.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1";
			this.RepositoryItemTextEdit1.PasswordChar = Strings.ChrW(42);
			//
			//LayoutControlGroup1
			//
			this.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.LayoutControlGroup1.GroupBordersVisible = false;
			this.LayoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { this.LayoutControlItem2 });
			this.LayoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.LayoutControlGroup1.Name = "Root";
			this.LayoutControlGroup1.Size = new System.Drawing.Size(1354, 268);
			this.LayoutControlGroup1.TextVisible = false;
			//
			//LayoutControlItem2
			//
			this.LayoutControlItem2.Control = this.gridNguoiDung;
			this.LayoutControlItem2.Location = new System.Drawing.Point(0, 0);
			this.LayoutControlItem2.Name = "LayoutControlItem2";
			this.LayoutControlItem2.Size = new System.Drawing.Size(1334, 248);
			this.LayoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.LayoutControlItem2.TextVisible = false;
			//
			//HeThong_PhanQuyen
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1362, 513);
			this.Controls.Add(this.DockPanel2);
			this.Controls.Add(this.DockPanel1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "HeThong_PhanQuyen";
			this.Text = "Phân Quyền";
			((System.ComponentModel.ISupportInitialize)this.BarManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.DockManager1).EndInit();
			this.DockPanel1.ResumeLayout(false);
			this.DockPanel1_Container.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.LayoutControl5).EndInit();
			this.LayoutControl5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.gridVaiTro).EndInit();
			((System.ComponentModel.ISupportInitialize)this.GridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.LayoutControlGroup5).EndInit();
			((System.ComponentModel.ISupportInitialize)this.LayoutControlItem1).EndInit();
			this.DockPanel2.ResumeLayout(false);
			this.DockPanel2_Container.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.LayoutControl1).EndInit();
			this.LayoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.gridNguoiDung).EndInit();
			((System.ComponentModel.ISupportInitialize)this.GridView2).EndInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemCheckedComboBoxEdit1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemTextEdit1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.LayoutControlGroup1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.LayoutControlItem2).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		internal DevExpress.XtraBars.BarManager BarManager1;
		internal DevExpress.XtraBars.Bar Bar2;
		internal DevExpress.XtraBars.Bar Bar3;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarButtonItem withEventsField_btnThemVT;
		internal DevExpress.XtraBars.BarButtonItem btnThemVT {
			get { return withEventsField_btnThemVT; }
			set {
				if (withEventsField_btnThemVT != null) {
					withEventsField_btnThemVT.ItemClick -= btnThemVT_ItemClick;
				}
				withEventsField_btnThemVT = value;
				if (withEventsField_btnThemVT != null) {
					withEventsField_btnThemVT.ItemClick += btnThemVT_ItemClick;
				}
			}
		}
		private DevExpress.XtraBars.BarButtonItem withEventsField_btnSuaVT;
		internal DevExpress.XtraBars.BarButtonItem btnSuaVT {
			get { return withEventsField_btnSuaVT; }
			set {
				if (withEventsField_btnSuaVT != null) {
					withEventsField_btnSuaVT.ItemClick -= btnSuaVT_ItemClick;
				}
				withEventsField_btnSuaVT = value;
				if (withEventsField_btnSuaVT != null) {
					withEventsField_btnSuaVT.ItemClick += btnSuaVT_ItemClick;
				}
			}
		}
		private DevExpress.XtraBars.BarButtonItem withEventsField_btnXoaVT;
		internal DevExpress.XtraBars.BarButtonItem btnXoaVT {
			get { return withEventsField_btnXoaVT; }
			set {
				if (withEventsField_btnXoaVT != null) {
					withEventsField_btnXoaVT.ItemClick -= btnXoaVT_ItemClick;
				}
				withEventsField_btnXoaVT = value;
				if (withEventsField_btnXoaVT != null) {
					withEventsField_btnXoaVT.ItemClick += btnXoaVT_ItemClick;
				}
			}
		}
		private DevExpress.XtraBars.BarButtonItem withEventsField_btnDong;
		internal DevExpress.XtraBars.BarButtonItem btnDong {
			get { return withEventsField_btnDong; }
			set {
				if (withEventsField_btnDong != null) {
					withEventsField_btnDong.ItemClick -= btnDong_ItemClick;
				}
				withEventsField_btnDong = value;
				if (withEventsField_btnDong != null) {
					withEventsField_btnDong.ItemClick += btnDong_ItemClick;
				}
			}
		}
		private DevExpress.XtraBars.BarButtonItem withEventsField_btnThemND;
		internal DevExpress.XtraBars.BarButtonItem btnThemND {
			get { return withEventsField_btnThemND; }
			set {
				if (withEventsField_btnThemND != null) {
					withEventsField_btnThemND.ItemClick -= btnThemND_ItemClick;
				}
				withEventsField_btnThemND = value;
				if (withEventsField_btnThemND != null) {
					withEventsField_btnThemND.ItemClick += btnThemND_ItemClick;
				}
			}
		}
		private DevExpress.XtraBars.BarButtonItem withEventsField_btnSuaND;
		internal DevExpress.XtraBars.BarButtonItem btnSuaND {
			get { return withEventsField_btnSuaND; }
			set {
				if (withEventsField_btnSuaND != null) {
					withEventsField_btnSuaND.ItemClick -= btnSuaND_ItemClick;
				}
				withEventsField_btnSuaND = value;
				if (withEventsField_btnSuaND != null) {
					withEventsField_btnSuaND.ItemClick += btnSuaND_ItemClick;
				}
			}
		}
		private DevExpress.XtraBars.BarButtonItem withEventsField_btnXoaND;
		internal DevExpress.XtraBars.BarButtonItem btnXoaND {
			get { return withEventsField_btnXoaND; }
			set {
				if (withEventsField_btnXoaND != null) {
					withEventsField_btnXoaND.ItemClick -= btnXoaND_ItemClick;
				}
				withEventsField_btnXoaND = value;
				if (withEventsField_btnXoaND != null) {
					withEventsField_btnXoaND.ItemClick += btnXoaND_ItemClick;
				}
			}
		}
		private DevExpress.XtraBars.BarButtonItem withEventsField_btnDong2;
		internal DevExpress.XtraBars.BarButtonItem btnDong2 {
			get { return withEventsField_btnDong2; }
			set {
				if (withEventsField_btnDong2 != null) {
					withEventsField_btnDong2.ItemClick -= btnDong2_ItemClick;
				}
				withEventsField_btnDong2 = value;
				if (withEventsField_btnDong2 != null) {
					withEventsField_btnDong2.ItemClick += btnDong2_ItemClick;
				}
			}
		}
		internal DevExpress.XtraBars.Docking.DockManager DockManager1;
		internal DevExpress.XtraBars.Docking.DockPanel DockPanel1;
		internal DevExpress.XtraBars.Docking.ControlContainer DockPanel1_Container;
		internal DevExpress.XtraLayout.LayoutControl LayoutControl5;
		internal DevExpress.XtraLayout.LayoutControlGroup LayoutControlGroup5;
		internal DevExpress.XtraBars.Docking.DockPanel DockPanel2;
		internal DevExpress.XtraBars.Docking.ControlContainer DockPanel2_Container;
		internal DevExpress.XtraLayout.LayoutControl LayoutControl1;
		internal DevExpress.XtraLayout.LayoutControlGroup LayoutControlGroup1;
		internal DevExpress.XtraGrid.GridControl gridNguoiDung;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView2;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumnVaiTro;
		internal DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit RepositoryItemCheckedComboBoxEdit1;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn6;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn4;
		internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit1;
		internal DevExpress.XtraLayout.LayoutControlItem LayoutControlItem2;
		internal DevExpress.XtraGrid.GridControl gridVaiTro;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn5;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn7;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn8;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn9;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn10;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn11;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn12;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn13;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn14;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn15;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn16;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn17;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn18;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn19;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn20;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn21;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn22;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn23;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn24;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn25;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn26;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn27;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn28;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn29;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn30;
		internal DevExpress.XtraLayout.LayoutControlItem LayoutControlItem1;
	}
}
