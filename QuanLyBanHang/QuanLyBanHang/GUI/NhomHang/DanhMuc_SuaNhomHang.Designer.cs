﻿namespace QuanLyBanHang.GUI.NhomHang
{
    partial class DanhMuc_SuaNhomHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhMuc_SuaNhomHang));
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.chxConQuanLy = new DevExpress.XtraEditors.CheckEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.RibbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxConQuanLy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelControl1
            // 
            this.PanelControl1.Controls.Add(this.txtMa);
            this.PanelControl1.Controls.Add(this.LabelControl3);
            this.PanelControl1.Controls.Add(this.btnDong);
            this.PanelControl1.Controls.Add(this.btnLuu);
            this.PanelControl1.Controls.Add(this.chxConQuanLy);
            this.PanelControl1.Controls.Add(this.txtTen);
            this.PanelControl1.Controls.Add(this.txtGhiChu);
            this.PanelControl1.Controls.Add(this.LabelControl1);
            this.PanelControl1.Controls.Add(this.LabelControl2);
            this.PanelControl1.Location = new System.Drawing.Point(-3, 4);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(303, 177);
            this.PanelControl1.TabIndex = 4;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(56, 19);
            this.txtMa.Name = "txtMa";
            this.txtMa.Properties.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(212, 20);
            this.txtMa.TabIndex = 77;
            // 
            // LabelControl3
            // 
            this.LabelControl3.Location = new System.Drawing.Point(15, 22);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(14, 13);
            this.LabelControl3.TabIndex = 76;
            this.LabelControl3.Text = "Mã";
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(188, 141);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(80, 23);
            this.btnDong.TabIndex = 73;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(55, 141);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 23);
            this.btnLuu.TabIndex = 72;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // chxConQuanLy
            // 
            this.chxConQuanLy.Location = new System.Drawing.Point(56, 106);
            this.chxConQuanLy.Name = "chxConQuanLy";
            this.chxConQuanLy.Properties.Caption = "Còn quản lý";
            this.chxConQuanLy.Size = new System.Drawing.Size(85, 19);
            this.chxConQuanLy.TabIndex = 9;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(56, 51);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(212, 20);
            this.txtTen.TabIndex = 7;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(56, 80);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(212, 20);
            this.txtGhiChu.TabIndex = 8;
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(15, 54);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(18, 13);
            this.LabelControl1.TabIndex = 5;
            this.LabelControl1.Text = "Tên";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Location = new System.Drawing.Point(15, 83);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(35, 13);
            this.LabelControl2.TabIndex = 6;
            this.LabelControl2.Text = "Ghi chú";
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
            this.RibbonControl1.Size = new System.Drawing.Size(297, 25);
            // 
            // DanhMuc_SuaNhomHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 181);
            this.Controls.Add(this.PanelControl1);
            this.Controls.Add(this.RibbonControl1);
            this.Name = "DanhMuc_SuaNhomHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Nhóm Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            this.PanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxConQuanLy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraEditors.TextEdit txtMa;
        internal DevExpress.XtraEditors.LabelControl LabelControl3;
        internal DevExpress.XtraEditors.SimpleButton btnDong;
        internal DevExpress.XtraEditors.SimpleButton btnLuu;
        internal DevExpress.XtraEditors.CheckEdit chxConQuanLy;
        internal DevExpress.XtraEditors.TextEdit txtTen;
        internal DevExpress.XtraEditors.TextEdit txtGhiChu;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraBars.Ribbon.RibbonControl RibbonControl1;
    }
}