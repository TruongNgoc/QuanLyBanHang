﻿namespace QuanLyBanHang.GUI.ChucNang
{
    partial class ChucNang_TonKho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChucNang_TonKho));
            this.LayoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.GridControl1 = new DevExpress.XtraGrid.GridControl();
            this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkpKhoHang = new DevExpress.XtraEditors.LookUpEdit();
            this.LayoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LayoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LayoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControl1)).BeginInit();
            this.LayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpKhoHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // LayoutControl1
            // 
            this.LayoutControl1.Controls.Add(this.GridControl1);
            this.LayoutControl1.Controls.Add(this.lkpKhoHang);
            this.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutControl1.Location = new System.Drawing.Point(0, 24);
            this.LayoutControl1.Name = "LayoutControl1";
            this.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(380, 280, 250, 350);
            this.LayoutControl1.Root = this.LayoutControlGroup1;
            this.LayoutControl1.Size = new System.Drawing.Size(727, 361);
            this.LayoutControl1.TabIndex = 9;
            this.LayoutControl1.Text = "LayoutControl1";
            // 
            // GridControl1
            // 
            this.GridControl1.Location = new System.Drawing.Point(12, 36);
            this.GridControl1.MainView = this.GridView1;
            this.GridControl1.Name = "GridControl1";
            this.GridControl1.Size = new System.Drawing.Size(703, 313);
            this.GridControl1.TabIndex = 5;
            this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView1});
            // 
            // GridView1
            // 
            this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn1,
            this.GridColumn2,
            this.GridColumn3,
            this.GridColumn4,
            this.GridColumn5,
            this.GridColumn6,
            this.GridColumn7});
            this.GridView1.GridControl = this.GridControl1;
            this.GridView1.Name = "GridView1";
            // 
            // GridColumn1
            // 
            this.GridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumn1.Caption = "Tên kho";
            this.GridColumn1.FieldName = "MaKho";
            this.GridColumn1.Name = "GridColumn1";
            this.GridColumn1.OptionsColumn.AllowEdit = false;
            this.GridColumn1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.GridColumn1.Visible = true;
            this.GridColumn1.VisibleIndex = 0;
            // 
            // GridColumn2
            // 
            this.GridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumn2.Caption = "Mã hàng hóa";
            this.GridColumn2.FieldName = "MaHangHoa";
            this.GridColumn2.Name = "GridColumn2";
            this.GridColumn2.OptionsColumn.AllowEdit = false;
            this.GridColumn2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.GridColumn2.Visible = true;
            this.GridColumn2.VisibleIndex = 1;
            // 
            // GridColumn3
            // 
            this.GridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumn3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumn3.Caption = "Tên hàng hóa";
            this.GridColumn3.FieldName = "TenHangHoa";
            this.GridColumn3.Name = "GridColumn3";
            this.GridColumn3.OptionsColumn.AllowEdit = false;
            this.GridColumn3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.GridColumn3.Visible = true;
            this.GridColumn3.VisibleIndex = 2;
            // 
            // GridColumn4
            // 
            this.GridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumn4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumn4.Caption = "Số lượng tồn";
            this.GridColumn4.FieldName = "SoLuongTon";
            this.GridColumn4.Name = "GridColumn4";
            this.GridColumn4.OptionsColumn.AllowEdit = false;
            this.GridColumn4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.GridColumn4.Visible = true;
            this.GridColumn4.VisibleIndex = 3;
            // 
            // GridColumn5
            // 
            this.GridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumn5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumn5.Caption = "Phân loại hàng";
            this.GridColumn5.FieldName = "TenNhomHang";
            this.GridColumn5.Name = "GridColumn5";
            this.GridColumn5.OptionsColumn.AllowEdit = false;
            this.GridColumn5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.GridColumn5.Visible = true;
            this.GridColumn5.VisibleIndex = 4;
            // 
            // GridColumn6
            // 
            this.GridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumn6.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumn6.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumn6.Caption = "Đơn vị";
            this.GridColumn6.FieldName = "TenDonVi";
            this.GridColumn6.Name = "GridColumn6";
            this.GridColumn6.OptionsColumn.AllowEdit = false;
            this.GridColumn6.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.GridColumn6.Visible = true;
            this.GridColumn6.VisibleIndex = 5;
            // 
            // GridColumn7
            // 
            this.GridColumn7.AppearanceCell.Options.UseTextOptions = true;
            this.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumn7.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumn7.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumn7.Caption = "Còn quản lý";
            this.GridColumn7.FieldName = "ConQuanLy";
            this.GridColumn7.Name = "GridColumn7";
            this.GridColumn7.OptionsColumn.AllowEdit = false;
            this.GridColumn7.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.GridColumn7.Visible = true;
            this.GridColumn7.VisibleIndex = 6;
            // 
            // lkpKhoHang
            // 
            this.lkpKhoHang.Location = new System.Drawing.Point(89, 12);
            this.lkpKhoHang.Name = "lkpKhoHang";
            this.lkpKhoHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpKhoHang.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKho", "Tên kho"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKho", "Mã kho")});
            this.lkpKhoHang.Size = new System.Drawing.Size(626, 20);
            this.lkpKhoHang.StyleController = this.LayoutControl1;
            this.lkpKhoHang.TabIndex = 4;
            // 
            // LayoutControlGroup1
            // 
            this.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.LayoutControlGroup1.GroupBordersVisible = false;
            this.LayoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LayoutControlItem1,
            this.LayoutControlItem2});
            this.LayoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.LayoutControlGroup1.Name = "Root";
            this.LayoutControlGroup1.Size = new System.Drawing.Size(727, 361);
            this.LayoutControlGroup1.TextVisible = false;
            // 
            // LayoutControlItem1
            // 
            this.LayoutControlItem1.Control = this.lkpKhoHang;
            this.LayoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.LayoutControlItem1.Name = "LayoutControlItem1";
            this.LayoutControlItem1.Size = new System.Drawing.Size(707, 24);
            this.LayoutControlItem1.Text = "Chọn Kho Hàng";
            this.LayoutControlItem1.TextSize = new System.Drawing.Size(74, 13);
            // 
            // LayoutControlItem2
            // 
            this.LayoutControlItem2.Control = this.GridControl1;
            this.LayoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.LayoutControlItem2.Name = "LayoutControlItem2";
            this.LayoutControlItem2.Size = new System.Drawing.Size(707, 317);
            this.LayoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.LayoutControlItem2.TextVisible = false;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = null;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 361);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(727, 24);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 361);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 385);
            this.barDockControlBottom.Manager = null;
            this.barDockControlBottom.Size = new System.Drawing.Size(727, 0);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 24);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Size = new System.Drawing.Size(727, 0);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Xem Tất Cả";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Đóng";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(727, 24);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 385);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(727, 23);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 24);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Size = new System.Drawing.Size(0, 361);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(727, 24);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Size = new System.Drawing.Size(0, 361);
            // 
            // ChucNang_TonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 408);
            this.Controls.Add(this.LayoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "ChucNang_TonKho";
            this.Text = "Tồn Kho";
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControl1)).EndInit();
            this.LayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpKhoHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraLayout.LayoutControl LayoutControl1;
        internal DevExpress.XtraGrid.GridControl GridControl1;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn4;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn5;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn6;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn7;
        internal DevExpress.XtraEditors.LookUpEdit lkpKhoHang;
        internal DevExpress.XtraLayout.LayoutControlGroup LayoutControlGroup1;
        internal DevExpress.XtraLayout.LayoutControlItem LayoutControlItem1;
        internal DevExpress.XtraLayout.LayoutControlItem LayoutControlItem2;
        internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
        internal DevExpress.XtraBars.BarDockControl barDockControlRight;
        internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
        internal DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        public DevExpress.XtraBars.BarButtonItem barButtonItem1;
        public DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}