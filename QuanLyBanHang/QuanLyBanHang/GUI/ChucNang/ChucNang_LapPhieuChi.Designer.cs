namespace QuanLyBanHang.GUI.ChucNang
{
    partial class ChucNang_LapPhieuChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChucNang_LapPhieuChi));
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtpNgay = new DevExpress.XtraEditors.DateEdit();
            this.ceSoTienChi = new DevExpress.XtraEditors.CalcEdit();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lkpNCC = new DevExpress.XtraEditors.LookUpEdit();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.RibbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSoTienChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelControl1
            // 
            this.PanelControl1.Controls.Add(this.LabelControl2);
            this.PanelControl1.Controls.Add(this.LabelControl1);
            this.PanelControl1.Controls.Add(this.dtpNgay);
            this.PanelControl1.Controls.Add(this.ceSoTienChi);
            this.PanelControl1.Controls.Add(this.LabelControl3);
            this.PanelControl1.Controls.Add(this.lkpNCC);
            this.PanelControl1.Controls.Add(this.btnDong);
            this.PanelControl1.Controls.Add(this.btnLuu);
            this.PanelControl1.Location = new System.Drawing.Point(-3, 2);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(365, 184);
            this.PanelControl1.TabIndex = 4;
            // 
            // LabelControl2
            // 
            this.LabelControl2.Location = new System.Drawing.Point(30, 91);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(25, 13);
            this.LabelControl2.TabIndex = 19;
            this.LabelControl2.Text = "Ngày";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(30, 31);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(65, 13);
            this.LabelControl1.TabIndex = 14;
            this.LabelControl1.Text = "Nhà cung cấp";
            // 
            // dtpNgay
            // 
            this.dtpNgay.EditValue = null;
            this.dtpNgay.Location = new System.Drawing.Point(101, 88);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgay.Size = new System.Drawing.Size(221, 20);
            this.dtpNgay.TabIndex = 18;
            // 
            // ceSoTienChi
            // 
            this.ceSoTienChi.Location = new System.Drawing.Point(101, 57);
            this.ceSoTienChi.Name = "ceSoTienChi";
            this.ceSoTienChi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ceSoTienChi.Size = new System.Drawing.Size(221, 20);
            this.ceSoTienChi.TabIndex = 17;
            // 
            // LabelControl3
            // 
            this.LabelControl3.Location = new System.Drawing.Point(30, 60);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(49, 13);
            this.LabelControl3.TabIndex = 15;
            this.LabelControl3.Text = "Số tiền chi";
            // 
            // lkpNCC
            // 
            this.lkpNCC.Location = new System.Drawing.Point(101, 28);
            this.lkpNCC.Name = "lkpNCC";
            this.lkpNCC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpNCC.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaNhaCungCap", "Mã NCC"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNhaPhanPhoi", "Tên NCC")});
            this.lkpNCC.Properties.NullText = "";
            this.lkpNCC.Size = new System.Drawing.Size(221, 20);
            this.lkpNCC.TabIndex = 16;
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(232, 134);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(90, 23);
            this.btnDong.TabIndex = 13;
            this.btnDong.Text = "Đóng";
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(101, 134);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 23);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            // 
            // RibbonControl1
            // 
            this.RibbonControl1.ExpandCollapseItem.Id = 0;
            this.RibbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RibbonControl1.ExpandCollapseItem});
            this.RibbonControl1.Location = new System.Drawing.Point(0, 0);
            this.RibbonControl1.MaxItemId = 1;
            this.RibbonControl1.Name = "RibbonControl1";
            this.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOffice;
            this.RibbonControl1.Size = new System.Drawing.Size(359, 25);
            // 
            // ChucNang_LapPhieuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 186);
            this.Controls.Add(this.PanelControl1);
            this.Controls.Add(this.RibbonControl1);
            this.Name = "ChucNang_LapPhieuChi";
            this.Text = "Lập Phiếu Thu Tiền";
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            this.PanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSoTienChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.DateEdit dtpNgay;
        internal DevExpress.XtraEditors.CalcEdit ceSoTienChi;
        internal DevExpress.XtraEditors.LabelControl LabelControl3;
        internal DevExpress.XtraEditors.LookUpEdit lkpNCC;
        internal DevExpress.XtraEditors.SimpleButton btnDong;
        internal DevExpress.XtraEditors.SimpleButton btnLuu;
        internal DevExpress.XtraBars.Ribbon.RibbonControl RibbonControl1;
    }
}