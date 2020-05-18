namespace QuanLyBanHang.GUI.BoPhan
{
    partial class DanhMuc_SuaBoPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhMuc_SuaBoPhan));
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.RibbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.txtTenBoPhan = new DevExpress.XtraEditors.TextEdit();
            this.txtDong = new DevExpress.XtraEditors.SimpleButton();
            this.txtLuu = new DevExpress.XtraEditors.SimpleButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.chkConQuanLy = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenBoPhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkConQuanLy.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelControl1
            // 
            this.PanelControl1.Controls.Add(this.txtGhiChu);
            this.PanelControl1.Controls.Add(this.txtTenBoPhan);
            this.PanelControl1.Controls.Add(this.txtDong);
            this.PanelControl1.Controls.Add(this.txtLuu);
            this.PanelControl1.Controls.Add(this.Label1);
            this.PanelControl1.Controls.Add(this.Label2);
            this.PanelControl1.Controls.Add(this.chkConQuanLy);
            this.PanelControl1.Location = new System.Drawing.Point(-3, 3);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(312, 155);
            this.PanelControl1.TabIndex = 4;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(85, 57);
            this.txtGhiChu.MenuManager = this.RibbonControl1;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(203, 20);
            this.txtGhiChu.TabIndex = 69;
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
            this.RibbonControl1.Size = new System.Drawing.Size(306, 25);
            // 
            // txtTenBoPhan
            // 
            this.txtTenBoPhan.Location = new System.Drawing.Point(85, 25);
            this.txtTenBoPhan.MenuManager = this.RibbonControl1;
            this.txtTenBoPhan.Name = "txtTenBoPhan";
            this.txtTenBoPhan.Size = new System.Drawing.Size(204, 20);
            this.txtTenBoPhan.TabIndex = 68;
            // 
            // txtDong
            // 
            this.txtDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtDong.ImageOptions.Image")));
            this.txtDong.Location = new System.Drawing.Point(209, 121);
            this.txtDong.Name = "txtDong";
            this.txtDong.Size = new System.Drawing.Size(80, 23);
            this.txtDong.TabIndex = 67;
            this.txtDong.Text = "Đóng";
            this.txtDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // txtLuu
            // 
            this.txtLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtLuu.ImageOptions.Image")));
            this.txtLuu.Location = new System.Drawing.Point(85, 121);
            this.txtLuu.Name = "txtLuu";
            this.txtLuu.Size = new System.Drawing.Size(82, 23);
            this.txtLuu.TabIndex = 66;
            this.txtLuu.Text = "Lưu";
            this.txtLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(67, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Tên bộ phận";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(37, 60);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(42, 13);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Ghi chú";
            // 
            // chkConQuanLy
            // 
            this.chkConQuanLy.EditValue = true;
            this.chkConQuanLy.Location = new System.Drawing.Point(85, 84);
            this.chkConQuanLy.Name = "chkConQuanLy";
            this.chkConQuanLy.Properties.Caption = "Còn quản lý";
            this.chkConQuanLy.Size = new System.Drawing.Size(94, 19);
            this.chkConQuanLy.TabIndex = 7;
            // 
            // DanhMuc_SuaBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 158);
            this.Controls.Add(this.PanelControl1);
            this.Controls.Add(this.RibbonControl1);
            this.Name = "DanhMuc_SuaBoPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Bộ Phận";
            this.Load += new System.EventHandler(this.DanhMuc_SuaBoPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            this.PanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenBoPhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkConQuanLy.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraEditors.TextEdit txtGhiChu;
        internal DevExpress.XtraBars.Ribbon.RibbonControl RibbonControl1;
        internal DevExpress.XtraEditors.TextEdit txtTenBoPhan;
        internal DevExpress.XtraEditors.SimpleButton txtDong;
        internal DevExpress.XtraEditors.SimpleButton txtLuu;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal DevExpress.XtraEditors.CheckEdit chkConQuanLy;
    }
}