namespace QuanLyBanHang.GUI.HeThong
{
    partial class HeThong_SaoLuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeThong_SaoLuu));
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnHoanThanh = new DevExpress.XtraEditors.SimpleButton();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.RibbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.txtDuongDan = new DevExpress.XtraEditors.ButtonEdit();
            this.labelthanhcong = new System.Windows.Forms.Label();
            this.labelform = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.labelten = new System.Windows.Forms.Label();
            this.btnThucHien = new DevExpress.XtraEditors.SimpleButton();
            this.labelduongdan = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelControl1
            // 
            this.PanelControl1.Controls.Add(this.btnHoanThanh);
            this.PanelControl1.Controls.Add(this.ProgressBar1);
            this.PanelControl1.Controls.Add(this.txtTen);
            this.PanelControl1.Controls.Add(this.txtDuongDan);
            this.PanelControl1.Controls.Add(this.labelthanhcong);
            this.PanelControl1.Controls.Add(this.labelform);
            this.PanelControl1.Controls.Add(this.Label1);
            this.PanelControl1.Controls.Add(this.btnThoat);
            this.PanelControl1.Controls.Add(this.labelten);
            this.PanelControl1.Controls.Add(this.btnThucHien);
            this.PanelControl1.Controls.Add(this.labelduongdan);
            this.PanelControl1.Location = new System.Drawing.Point(-3, 4);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(336, 219);
            this.PanelControl1.TabIndex = 9;
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHoanThanh.ImageOptions.Image")));
            this.btnHoanThanh.Location = new System.Drawing.Point(56, 165);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(95, 29);
            this.btnHoanThanh.TabIndex = 29;
            this.btnHoanThanh.Text = "Hoàn thành";
            this.btnHoanThanh.Visible = false;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(56, 165);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(95, 29);
            this.ProgressBar1.TabIndex = 27;
            this.ProgressBar1.Visible = false;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(110, 63);
            this.txtTen.MenuManager = this.RibbonControl1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(182, 20);
            this.txtTen.TabIndex = 26;
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
            this.RibbonControl1.Size = new System.Drawing.Size(330, 25);
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Location = new System.Drawing.Point(110, 104);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDuongDan.Properties.Appearance.Options.UseBackColor = true;
            this.txtDuongDan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.txtDuongDan.Properties.ReadOnly = true;
            this.txtDuongDan.Size = new System.Drawing.Size(182, 20);
            this.txtDuongDan.TabIndex = 25;
            // 
            // labelthanhcong
            // 
            this.labelthanhcong.AutoSize = true;
            this.labelthanhcong.ForeColor = System.Drawing.Color.Firebrick;
            this.labelthanhcong.Location = new System.Drawing.Point(78, 138);
            this.labelthanhcong.Name = "labelthanhcong";
            this.labelthanhcong.Size = new System.Drawing.Size(0, 13);
            this.labelthanhcong.TabIndex = 8;
            // 
            // labelform
            // 
            this.labelform.AutoSize = true;
            this.labelform.Location = new System.Drawing.Point(77, 138);
            this.labelform.Name = "labelform";
            this.labelform.Size = new System.Drawing.Size(215, 13);
            this.labelform.TabIndex = 7;
            this.labelform.Text = "Chọn đường dẫn tới ổ D, E (trừ ổ hệ thống)";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label1.Location = new System.Drawing.Point(77, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(197, 24);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "SAO LƯU HỆ THỐNG";
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(198, 165);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 29);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // labelten
            // 
            this.labelten.AutoSize = true;
            this.labelten.Location = new System.Drawing.Point(34, 66);
            this.labelten.Name = "labelten";
            this.labelten.Size = new System.Drawing.Size(25, 13);
            this.labelten.TabIndex = 1;
            this.labelten.Text = "Tên";
            // 
            // btnThucHien
            // 
            this.btnThucHien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThucHien.ImageOptions.Image")));
            this.btnThucHien.Location = new System.Drawing.Point(56, 165);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(95, 29);
            this.btnThucHien.TabIndex = 5;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // labelduongdan
            // 
            this.labelduongdan.AutoSize = true;
            this.labelduongdan.Location = new System.Drawing.Point(34, 107);
            this.labelduongdan.Name = "labelduongdan";
            this.labelduongdan.Size = new System.Drawing.Size(61, 13);
            this.labelduongdan.TabIndex = 2;
            this.labelduongdan.Text = "Đường dẫn";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // HeThong_SaoLuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 207);
            this.Controls.Add(this.PanelControl1);
            this.Controls.Add(this.RibbonControl1);
            this.Name = "HeThong_SaoLuu";
            this.Text = "Sao Lưu";
            this.Load += new System.EventHandler(this.HeThong_SaoLuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            this.PanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraEditors.SimpleButton btnHoanThanh;
        internal System.Windows.Forms.ProgressBar ProgressBar1;
        internal DevExpress.XtraEditors.TextEdit txtTen;
        internal DevExpress.XtraBars.Ribbon.RibbonControl RibbonControl1;
        internal DevExpress.XtraEditors.ButtonEdit txtDuongDan;
        internal System.Windows.Forms.Label labelthanhcong;
        internal System.Windows.Forms.Label labelform;
        internal System.Windows.Forms.Label Label1;
        internal DevExpress.XtraEditors.SimpleButton btnThoat;
        internal System.Windows.Forms.Label labelten;
        internal DevExpress.XtraEditors.SimpleButton btnThucHien;
        internal System.Windows.Forms.Label labelduongdan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}