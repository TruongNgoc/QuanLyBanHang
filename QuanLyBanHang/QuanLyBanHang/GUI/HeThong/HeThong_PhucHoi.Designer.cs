namespace QuanLyBanHang.GUI.HeThong
{
    partial class HeThong_PhucHoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeThong_PhucHoi));
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnHoanThanh = new DevExpress.XtraEditors.SimpleButton();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtTen = new DevExpress.XtraEditors.ButtonEdit();
            this.labelthanhcong = new System.Windows.Forms.Label();
            this.labelform = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.labelten = new System.Windows.Forms.Label();
            this.btnThucHien = new DevExpress.XtraEditors.SimpleButton();
            this.RibbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelControl1
            // 
            this.PanelControl1.Controls.Add(this.btnHoanThanh);
            this.PanelControl1.Controls.Add(this.ProgressBar1);
            this.PanelControl1.Controls.Add(this.txtTen);
            this.PanelControl1.Controls.Add(this.labelthanhcong);
            this.PanelControl1.Controls.Add(this.labelform);
            this.PanelControl1.Controls.Add(this.Label1);
            this.PanelControl1.Controls.Add(this.btnThoat);
            this.PanelControl1.Controls.Add(this.labelten);
            this.PanelControl1.Controls.Add(this.btnThucHien);
            this.PanelControl1.Location = new System.Drawing.Point(-3, 5);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(344, 180);
            this.PanelControl1.TabIndex = 23;
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHoanThanh.ImageOptions.Image")));
            this.btnHoanThanh.Location = new System.Drawing.Point(62, 126);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(95, 29);
            this.btnHoanThanh.TabIndex = 30;
            this.btnHoanThanh.Text = "Hoàn thành";
            this.btnHoanThanh.Visible = false;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(62, 126);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(95, 29);
            this.ProgressBar1.TabIndex = 26;
            this.ProgressBar1.Visible = false;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(82, 63);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTen.Properties.Appearance.Options.UseBackColor = true;
            this.txtTen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.txtTen.Properties.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(215, 20);
            this.txtTen.TabIndex = 25;
            this.txtTen.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtTen_ButtonClick);
            // 
            // labelthanhcong
            // 
            this.labelthanhcong.AutoSize = true;
            this.labelthanhcong.ForeColor = System.Drawing.Color.Firebrick;
            this.labelthanhcong.Location = new System.Drawing.Point(110, 96);
            this.labelthanhcong.Name = "labelthanhcong";
            this.labelthanhcong.Size = new System.Drawing.Size(0, 13);
            this.labelthanhcong.TabIndex = 24;
            // 
            // labelform
            // 
            this.labelform.AutoSize = true;
            this.labelform.Location = new System.Drawing.Point(100, 96);
            this.labelform.Name = "labelform";
            this.labelform.Size = new System.Drawing.Size(158, 13);
            this.labelform.TabIndex = 23;
            this.labelform.Text = "Chọn đường dẫn tới File Backup";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label1.Location = new System.Drawing.Point(85, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(206, 24);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "PHỤC HỒI HỆ THỐNG";
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(204, 126);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 29);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // labelten
            // 
            this.labelten.AutoSize = true;
            this.labelten.Location = new System.Drawing.Point(17, 66);
            this.labelten.Name = "labelten";
            this.labelten.Size = new System.Drawing.Size(59, 13);
            this.labelten.TabIndex = 15;
            this.labelten.Text = "Tên tập tin";
            // 
            // btnThucHien
            // 
            this.btnThucHien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThucHien.ImageOptions.Image")));
            this.btnThucHien.Location = new System.Drawing.Point(62, 126);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(95, 29);
            this.btnThucHien.TabIndex = 19;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
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
            this.RibbonControl1.Size = new System.Drawing.Size(338, 25);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // HeThong_PhucHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 167);
            this.Controls.Add(this.PanelControl1);
            this.Controls.Add(this.RibbonControl1);
            this.Name = "HeThong_PhucHoi";
            this.Text = "Phục Hồi Hệ Thống";
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            this.PanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraEditors.SimpleButton btnHoanThanh;
        internal System.Windows.Forms.ProgressBar ProgressBar1;
        internal DevExpress.XtraEditors.ButtonEdit txtTen;
        internal System.Windows.Forms.Label labelthanhcong;
        internal System.Windows.Forms.Label labelform;
        internal System.Windows.Forms.Label Label1;
        internal DevExpress.XtraEditors.SimpleButton btnThoat;
        internal System.Windows.Forms.Label labelten;
        internal DevExpress.XtraEditors.SimpleButton btnThucHien;
        internal DevExpress.XtraBars.Ribbon.RibbonControl RibbonControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}