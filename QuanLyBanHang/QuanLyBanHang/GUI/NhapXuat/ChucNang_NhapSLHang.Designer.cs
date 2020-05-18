namespace QuanLyBanHang.GUI.NhapXuat
{
    partial class ChucNang_NhapSLHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChucNang_NhapSLHang));
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnHuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.btnDongY = new DevExpress.XtraEditors.SimpleButton();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ceSoLuong = new DevExpress.XtraEditors.CalcEdit();
            this.txtSoLuongCon = new DevExpress.XtraEditors.TextEdit();
            this.txtTenHang = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.RibbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongCon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelControl1
            // 
            this.PanelControl1.Controls.Add(this.btnHuyBo);
            this.PanelControl1.Controls.Add(this.btnDongY);
            this.PanelControl1.Controls.Add(this.LabelControl1);
            this.PanelControl1.Controls.Add(this.ceSoLuong);
            this.PanelControl1.Controls.Add(this.txtSoLuongCon);
            this.PanelControl1.Controls.Add(this.txtTenHang);
            this.PanelControl1.Controls.Add(this.LabelControl3);
            this.PanelControl1.Controls.Add(this.LabelControl2);
            this.PanelControl1.Location = new System.Drawing.Point(-3, 2);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(359, 182);
            this.PanelControl1.TabIndex = 3;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyBo.ImageOptions.Image")));
            this.btnHuyBo.Location = new System.Drawing.Point(249, 148);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(63, 23);
            this.btnHuyBo.TabIndex = 11;
            this.btnHuyBo.Text = "Hủy bỏ";
            // 
            // btnDongY
            // 
            this.btnDongY.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDongY.ImageOptions.Image")));
            this.btnDongY.Location = new System.Drawing.Point(141, 148);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(61, 23);
            this.btnDongY.TabIndex = 10;
            this.btnDongY.Text = "Đồng ý";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(24, 109);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(98, 13);
            this.LabelControl1.TabIndex = 8;
            this.LabelControl1.Text = "Số lượng muốn nhập";
            // 
            // ceSoLuong
            // 
            this.ceSoLuong.Location = new System.Drawing.Point(145, 106);
            this.ceSoLuong.Name = "ceSoLuong";
            this.ceSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ceSoLuong.Size = new System.Drawing.Size(167, 20);
            this.ceSoLuong.TabIndex = 9;
            // 
            // txtSoLuongCon
            // 
            this.txtSoLuongCon.Location = new System.Drawing.Point(145, 66);
            this.txtSoLuongCon.Name = "txtSoLuongCon";
            this.txtSoLuongCon.Properties.ReadOnly = true;
            this.txtSoLuongCon.Size = new System.Drawing.Size(167, 20);
            this.txtSoLuongCon.TabIndex = 7;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(145, 31);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Properties.ReadOnly = true;
            this.txtTenHang.Size = new System.Drawing.Size(167, 20);
            this.txtTenHang.TabIndex = 6;
            // 
            // LabelControl3
            // 
            this.LabelControl3.Location = new System.Drawing.Point(24, 69);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(62, 13);
            this.LabelControl3.TabIndex = 5;
            this.LabelControl3.Text = "Số lượng còn";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Location = new System.Drawing.Point(24, 31);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(45, 13);
            this.LabelControl2.TabIndex = 4;
            this.LabelControl2.Text = "Tên hàng";
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
            this.RibbonControl1.Size = new System.Drawing.Size(353, 25);
            // 
            // ChucNang_NhapSLHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 185);
            this.Controls.Add(this.PanelControl1);
            this.Controls.Add(this.RibbonControl1);
            this.Name = "ChucNang_NhapSLHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChucNang_NhapSLHang";
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            this.PanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongCon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraEditors.SimpleButton btnHuyBo;
        internal DevExpress.XtraEditors.SimpleButton btnDongY;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.CalcEdit ceSoLuong;
        internal DevExpress.XtraEditors.TextEdit txtSoLuongCon;
        internal DevExpress.XtraEditors.TextEdit txtTenHang;
        internal DevExpress.XtraEditors.LabelControl LabelControl3;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraBars.Ribbon.RibbonControl RibbonControl1;
    }
}