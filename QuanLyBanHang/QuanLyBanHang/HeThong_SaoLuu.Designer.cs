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
	partial class HeThong_SaoLuu : DevExpress.XtraBars.Ribbon.RibbonForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeThong_SaoLuu));
			this.Label1 = new System.Windows.Forms.Label();
			this.labelten = new System.Windows.Forms.Label();
			this.labelduongdan = new System.Windows.Forms.Label();
			this.btnThucHien = new DevExpress.XtraEditors.SimpleButton();
			this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
			this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
			this.txtTen = new DevExpress.XtraEditors.TextEdit();
			this.RibbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.txtDuongDan = new DevExpress.XtraEditors.ButtonEdit();
			this.labelthanhcong = new System.Windows.Forms.Label();
			this.labelform = new System.Windows.Forms.Label();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.btnHoanThanh = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)this.PanelControl1).BeginInit();
			this.PanelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.txtTen.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.RibbonControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.txtDuongDan.Properties).BeginInit();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(77, 26);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(197, 24);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "SAO LƯU HỆ THỐNG";
			//
			//labelten
			//
			this.labelten.AutoSize = true;
			this.labelten.Location = new System.Drawing.Point(34, 66);
			this.labelten.Name = "labelten";
			this.labelten.Size = new System.Drawing.Size(25, 13);
			this.labelten.TabIndex = 1;
			this.labelten.Text = "Tên";
			//
			//labelduongdan
			//
			this.labelduongdan.AutoSize = true;
			this.labelduongdan.Location = new System.Drawing.Point(34, 107);
			this.labelduongdan.Name = "labelduongdan";
			this.labelduongdan.Size = new System.Drawing.Size(61, 13);
			this.labelduongdan.TabIndex = 2;
			this.labelduongdan.Text = "Đường dẫn";
			//
			//btnThucHien
			//
			this.btnThucHien.Image = (System.Drawing.Image)resources.GetObject("btnThucHien.Image");
			this.btnThucHien.Location = new System.Drawing.Point(56, 165);
			this.btnThucHien.Name = "btnThucHien";
			this.btnThucHien.Size = new System.Drawing.Size(95, 29);
			this.btnThucHien.TabIndex = 5;
			this.btnThucHien.Text = "Thực hiện";
			//
			//btnThoat
			//
			this.btnThoat.Image = (System.Drawing.Image)resources.GetObject("btnThoat.Image");
			this.btnThoat.Location = new System.Drawing.Point(198, 165);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(103, 29);
			this.btnThoat.TabIndex = 6;
			this.btnThoat.Text = "Thoát";
			//
			//PanelControl1
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
			this.PanelControl1.Location = new System.Drawing.Point(0, 27);
			this.PanelControl1.Name = "PanelControl1";
			this.PanelControl1.Size = new System.Drawing.Size(336, 219);
			this.PanelControl1.TabIndex = 7;
			//
			//ProgressBar1
			//
			this.ProgressBar1.Location = new System.Drawing.Point(56, 165);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new System.Drawing.Size(95, 29);
			this.ProgressBar1.TabIndex = 27;
			this.ProgressBar1.Visible = false;
			//
			//txtTen
			//
			this.txtTen.Location = new System.Drawing.Point(110, 63);
			this.txtTen.MenuManager = this.RibbonControl1;
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(182, 20);
			this.txtTen.TabIndex = 26;
			//
			//RibbonControl1
			//
			this.RibbonControl1.ExpandCollapseItem.Id = 0;
			this.RibbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { this.RibbonControl1.ExpandCollapseItem });
			this.RibbonControl1.Location = new System.Drawing.Point(0, 0);
			this.RibbonControl1.MaxItemId = 1;
			this.RibbonControl1.Name = "RibbonControl1";
			this.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOffice;
			this.RibbonControl1.Size = new System.Drawing.Size(336, 52);
			//
			//txtDuongDan
			//
			this.txtDuongDan.Location = new System.Drawing.Point(110, 104);
			this.txtDuongDan.Name = "txtDuongDan";
			this.txtDuongDan.Properties.Appearance.BackColor = System.Drawing.Color.White;
			this.txtDuongDan.Properties.Appearance.Options.UseBackColor = true;
			this.txtDuongDan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search) });
			this.txtDuongDan.Properties.ReadOnly = true;
			this.txtDuongDan.Size = new System.Drawing.Size(182, 20);
			this.txtDuongDan.TabIndex = 25;
			//
			//labelthanhcong
			//
			this.labelthanhcong.AutoSize = true;
			this.labelthanhcong.ForeColor = System.Drawing.Color.Firebrick;
			this.labelthanhcong.Location = new System.Drawing.Point(78, 138);
			this.labelthanhcong.Name = "labelthanhcong";
			this.labelthanhcong.Size = new System.Drawing.Size(0, 13);
			this.labelthanhcong.TabIndex = 8;
			//
			//labelform
			//
			this.labelform.AutoSize = true;
			this.labelform.Location = new System.Drawing.Point(77, 138);
			this.labelform.Name = "labelform";
			this.labelform.Size = new System.Drawing.Size(215, 13);
			this.labelform.TabIndex = 7;
			this.labelform.Text = "Chọn đường dẫn tới ổ D, E (trừ ổ hệ thống)";
			//
			//Timer1
			//
			this.Timer1.Interval = 5;
			//
			//btnHoanThanh
			//
			this.btnHoanThanh.Image = (System.Drawing.Image)resources.GetObject("btnHoanThanh.Image");
			this.btnHoanThanh.Location = new System.Drawing.Point(56, 165);
			this.btnHoanThanh.Name = "btnHoanThanh";
			this.btnHoanThanh.Size = new System.Drawing.Size(95, 29);
			this.btnHoanThanh.TabIndex = 29;
			this.btnHoanThanh.Text = "Hoàn thành";
			this.btnHoanThanh.Visible = false;
			//
			//HeThong_SaoLuu
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(336, 235);
			this.Controls.Add(this.PanelControl1);
			this.Controls.Add(this.RibbonControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "HeThong_SaoLuu";
			this.Ribbon = this.RibbonControl1;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sao Lưu Hệ Thống";
			((System.ComponentModel.ISupportInitialize)this.PanelControl1).EndInit();
			this.PanelControl1.ResumeLayout(false);
			this.PanelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.txtTen.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.RibbonControl1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.txtDuongDan.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		internal Label Label1;
		internal Label labelten;
		internal Label labelduongdan;
		private DevExpress.XtraEditors.SimpleButton withEventsField_btnThucHien;
		internal DevExpress.XtraEditors.SimpleButton btnThucHien {
			get { return withEventsField_btnThucHien; }
			set {
				if (withEventsField_btnThucHien != null) {
					withEventsField_btnThucHien.Click -= btnThucHien_Click;
				}
				withEventsField_btnThucHien = value;
				if (withEventsField_btnThucHien != null) {
					withEventsField_btnThucHien.Click += btnThucHien_Click;
				}
			}
		}
		private DevExpress.XtraEditors.SimpleButton withEventsField_btnThoat;
		internal DevExpress.XtraEditors.SimpleButton btnThoat {
			get { return withEventsField_btnThoat; }
			set {
				if (withEventsField_btnThoat != null) {
					withEventsField_btnThoat.Click -= btnThoat_Click;
				}
				withEventsField_btnThoat = value;
				if (withEventsField_btnThoat != null) {
					withEventsField_btnThoat.Click += btnThoat_Click;
				}
			}
		}
		internal FolderBrowserDialog FolderBrowserDialog1;
		internal DevExpress.XtraEditors.PanelControl PanelControl1;
		internal DevExpress.XtraBars.Ribbon.RibbonControl RibbonControl1;
		internal Label labelthanhcong;
		internal Label labelform;
		private DevExpress.XtraEditors.ButtonEdit withEventsField_txtDuongDan;
		internal DevExpress.XtraEditors.ButtonEdit txtDuongDan {
			get { return withEventsField_txtDuongDan; }
			set {
				if (withEventsField_txtDuongDan != null) {
					withEventsField_txtDuongDan.ButtonClick -= txtDuongDan_ButtonClick;
				}
				withEventsField_txtDuongDan = value;
				if (withEventsField_txtDuongDan != null) {
					withEventsField_txtDuongDan.ButtonClick += txtDuongDan_ButtonClick;
				}
			}
		}
		internal DevExpress.XtraEditors.TextEdit txtTen;
		private Timer withEventsField_Timer1;
		internal Timer Timer1 {
			get { return withEventsField_Timer1; }
			set {
				if (withEventsField_Timer1 != null) {
					withEventsField_Timer1.Tick -= Timer1_Tick;
				}
				withEventsField_Timer1 = value;
				if (withEventsField_Timer1 != null) {
					withEventsField_Timer1.Tick += Timer1_Tick;
				}
			}
		}
		internal ProgressBar ProgressBar1;
		private DevExpress.XtraEditors.SimpleButton withEventsField_btnHoanThanh;
		internal DevExpress.XtraEditors.SimpleButton btnHoanThanh {
			get { return withEventsField_btnHoanThanh; }
			set {
				if (withEventsField_btnHoanThanh != null) {
					withEventsField_btnHoanThanh.Click -= btnHoanThanh_Click;
				}
				withEventsField_btnHoanThanh = value;
				if (withEventsField_btnHoanThanh != null) {
					withEventsField_btnHoanThanh.Click += btnHoanThanh_Click;
				}
			}
		}
	}
}
