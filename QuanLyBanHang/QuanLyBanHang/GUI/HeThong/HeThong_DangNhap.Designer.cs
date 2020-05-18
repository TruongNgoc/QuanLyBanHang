namespace QuanLyBanHang.GUI.HeThong
{
    partial class HeThong_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeThong_DangNhap));
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chkNhoTaiKhoanMatKhau = new System.Windows.Forms.CheckBox();
            this.txtmatkhau = new DevExpress.XtraEditors.TextEdit();
            this.RibbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.txtdangnhap = new DevExpress.XtraEditors.TextEdit();
            this.noti = new System.Windows.Forms.Label();
            this.labelform = new System.Windows.Forms.Label();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmatkhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdangnhap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelControl1
            // 
            this.PanelControl1.Controls.Add(this.chkNhoTaiKhoanMatKhau);
            this.PanelControl1.Controls.Add(this.txtmatkhau);
            this.PanelControl1.Controls.Add(this.txtdangnhap);
            this.PanelControl1.Controls.Add(this.noti);
            this.PanelControl1.Controls.Add(this.labelform);
            this.PanelControl1.Controls.Add(this.btnThoat);
            this.PanelControl1.Controls.Add(this.btnDangNhap);
            this.PanelControl1.Controls.Add(this.Label2);
            this.PanelControl1.Controls.Add(this.Label1);
            this.PanelControl1.Location = new System.Drawing.Point(-3, 5);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(376, 290);
            this.PanelControl1.TabIndex = 4;
            // 
            // chkNhoTaiKhoanMatKhau
            // 
            this.chkNhoTaiKhoanMatKhau.AutoSize = true;
            this.chkNhoTaiKhoanMatKhau.Location = new System.Drawing.Point(130, 115);
            this.chkNhoTaiKhoanMatKhau.Name = "chkNhoTaiKhoanMatKhau";
            this.chkNhoTaiKhoanMatKhau.Size = new System.Drawing.Size(154, 17);
            this.chkNhoTaiKhoanMatKhau.TabIndex = 15;
            this.chkNhoTaiKhoanMatKhau.Text = "Nhớ tài khoản và mật khẩu";
            this.chkNhoTaiKhoanMatKhau.UseVisualStyleBackColor = true;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.EditValue = "";
            this.txtmatkhau.Location = new System.Drawing.Point(130, 69);
            this.txtmatkhau.MenuManager = this.RibbonControl1;
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhau.Properties.Appearance.Options.UseFont = true;
            this.txtmatkhau.Properties.UseSystemPasswordChar = true;
            this.txtmatkhau.Size = new System.Drawing.Size(171, 20);
            this.txtmatkhau.TabIndex = 14;
            // 
            // RibbonControl1
            // 
            this.RibbonControl1.ExpandCollapseItem.Id = 0;
            this.RibbonControl1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RibbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RibbonControl1.ExpandCollapseItem});
            this.RibbonControl1.Location = new System.Drawing.Point(0, 0);
            this.RibbonControl1.MaxItemId = 1;
            this.RibbonControl1.Name = "RibbonControl1";
            this.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOffice;
            this.RibbonControl1.Size = new System.Drawing.Size(370, 25);
            // 
            // txtdangnhap
            // 
            this.txtdangnhap.EditValue = "admin";
            this.txtdangnhap.Location = new System.Drawing.Point(130, 36);
            this.txtdangnhap.MenuManager = this.RibbonControl1;
            this.txtdangnhap.Name = "txtdangnhap";
            this.txtdangnhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdangnhap.Properties.Appearance.Options.UseFont = true;
            this.txtdangnhap.Size = new System.Drawing.Size(171, 20);
            this.txtdangnhap.TabIndex = 13;
            // 
            // noti
            // 
            this.noti.AutoSize = true;
            this.noti.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noti.ForeColor = System.Drawing.Color.Firebrick;
            this.noti.Location = new System.Drawing.Point(33, 159);
            this.noti.Name = "noti";
            this.noti.Size = new System.Drawing.Size(0, 14);
            this.noti.TabIndex = 12;
            // 
            // labelform
            // 
            this.labelform.AutoSize = true;
            this.labelform.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelform.Location = new System.Drawing.Point(101, 242);
            this.labelform.Name = "labelform";
            this.labelform.Size = new System.Drawing.Size(162, 14);
            this.labelform.TabIndex = 11;
            this.labelform.Text = "(User: admin, Pass: 123456)";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(217, 200);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 27);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.Image")));
            this.btnDangNhap.Location = new System.Drawing.Point(69, 200);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(103, 27);
            this.btnDangNhap.TabIndex = 8;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(35, 72);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(57, 14);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Mật khẩu";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(33, 39);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(91, 14);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Tên đăng nhập";
            // 
            // HeThong_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 293);
            this.Controls.Add(this.PanelControl1);
            this.Controls.Add(this.RibbonControl1);
            this.Name = "HeThong_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.HeThong_DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            this.PanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmatkhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdangnhap.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraEditors.TextEdit txtmatkhau;
        internal DevExpress.XtraBars.Ribbon.RibbonControl RibbonControl1;
        internal DevExpress.XtraEditors.TextEdit txtdangnhap;
        internal System.Windows.Forms.Label noti;
        internal System.Windows.Forms.Label labelform;
        internal DevExpress.XtraEditors.SimpleButton btnThoat;
        internal DevExpress.XtraEditors.SimpleButton btnDangNhap;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.CheckBox chkNhoTaiKhoanMatKhau;
    }
}