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
	partial class HeThong_PhucHoi : DevExpress.XtraBars.Ribbon.RibbonForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeThong_PhucHoi));
			this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
			this.btnThucHien = new DevExpress.XtraEditors.SimpleButton();
			this.labelten = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.btnHoanThanh = new DevExpress.XtraEditors.SimpleButton();
			this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
			this.txtTen = new DevExpress.XtraEditors.ButtonEdit();
			this.labelthanhcong = new System.Windows.Forms.Label();
			this.labelform = new System.Windows.Forms.Label();
			this.RibbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)this.PanelControl1).BeginInit();
			this.PanelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.txtTen.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.RibbonControl1).BeginInit();
			this.SuspendLayout();
			//
			//btnThoat
			//
			this.btnThoat.Image = (System.Drawing.Image)resources.GetObject("btnThoat.Image");
			this.btnThoat.Location = new System.Drawing.Point(204, 126);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(103, 29);
			this.btnThoat.TabIndex = 20;
			this.btnThoat.Text = "Thoát";
			//
			//btnThucHien
			//
			this.btnThucHien.Image = (System.Drawing.Image)resources.GetObject("btnThucHien.Image");
			this.btnThucHien.Location = new System.Drawing.Point(62, 126);
			this.btnThucHien.Name = "btnThucHien";
			this.btnThucHien.Size = new System.Drawing.Size(95, 29);
			this.btnThucHien.TabIndex = 19;
			this.btnThucHien.Text = "Thực hiện";
			//
			//labelten
			//
			this.labelten.AutoSize = true;
			this.labelten.Location = new System.Drawing.Point(17, 66);
			this.labelten.Name = "labelten";
			this.labelten.Size = new System.Drawing.Size(59, 13);
			this.labelten.TabIndex = 15;
			this.labelten.Text = "Tên tập tin";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(85, 23);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(206, 24);
			this.Label1.TabIndex = 14;
			this.Label1.Text = "PHỤC HỒI HỆ THỐNG";
			//
			//OpenFileDialog1
			//
			this.OpenFileDialog1.FileName = "OpenFileDialog1";
			//
			//PanelControl1
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
			this.PanelControl1.Location = new System.Drawing.Point(0, 27);
			this.PanelControl1.Name = "PanelControl1";
			this.PanelControl1.Size = new System.Drawing.Size(344, 180);
			this.PanelControl1.TabIndex = 21;
			//
			//btnHoanThanh
			//
			this.btnHoanThanh.Image = (System.Drawing.Image)resources.GetObject("btnHoanThanh.Image");
			this.btnHoanThanh.Location = new System.Drawing.Point(62, 126);
			this.btnHoanThanh.Name = "btnHoanThanh";
			this.btnHoanThanh.Size = new System.Drawing.Size(95, 29);
			this.btnHoanThanh.TabIndex = 30;
			this.btnHoanThanh.Text = "Hoàn thành";
			this.btnHoanThanh.Visible = false;
			//
			//ProgressBar1
			//
			this.ProgressBar1.Location = new System.Drawing.Point(62, 126);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new System.Drawing.Size(95, 29);
			this.ProgressBar1.TabIndex = 26;
			this.ProgressBar1.Visible = false;
			//
			//txtTen
			//
			this.txtTen.Location = new System.Drawing.Point(82, 63);
			this.txtTen.Name = "txtTen";
			this.txtTen.Properties.Appearance.BackColor = System.Drawing.Color.White;
			this.txtTen.Properties.Appearance.Options.UseBackColor = true;
			this.txtTen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search) });
			this.txtTen.Properties.ReadOnly = true;
			this.txtTen.Size = new System.Drawing.Size(215, 20);
			this.txtTen.TabIndex = 25;
			//
			//labelthanhcong
			//
			this.labelthanhcong.AutoSize = true;
			this.labelthanhcong.ForeColor = System.Drawing.Color.Firebrick;
			this.labelthanhcong.Location = new System.Drawing.Point(110, 96);
			this.labelthanhcong.Name = "labelthanhcong";
			this.labelthanhcong.Size = new System.Drawing.Size(0, 13);
			this.labelthanhcong.TabIndex = 24;
			//
			//labelform
			//
			this.labelform.AutoSize = true;
			this.labelform.Location = new System.Drawing.Point(100, 96);
			this.labelform.Name = "labelform";
			this.labelform.Size = new System.Drawing.Size(158, 13);
			this.labelform.TabIndex = 23;
			this.labelform.Text = "Chọn đường dẫn tới File Backup";
			//
			//RibbonControl1
			//
			this.RibbonControl1.ExpandCollapseItem.Id = 0;
			this.RibbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { this.RibbonControl1.ExpandCollapseItem });
			this.RibbonControl1.Location = new System.Drawing.Point(0, 0);
			this.RibbonControl1.MaxItemId = 1;
			this.RibbonControl1.Name = "RibbonControl1";
			this.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOffice;
			this.RibbonControl1.Size = new System.Drawing.Size(344, 27);
			//
			//Timer1
			//
			this.Timer1.Interval = 5;
			//
			//HeThong_PhucHoi
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 196);
			this.Controls.Add(this.PanelControl1);
			this.Controls.Add(this.RibbonControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "HeThong_PhucHoi";
			this.Ribbon = this.RibbonControl1;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phục Hồi Hệ Thống";
			((System.ComponentModel.ISupportInitialize)this.PanelControl1).EndInit();
			this.PanelControl1.ResumeLayout(false);
			this.PanelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.txtTen.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.RibbonControl1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		internal Label labelten;
		internal Label Label1;
		internal OpenFileDialog OpenFileDialog1;
		internal DevExpress.XtraEditors.PanelControl PanelControl1;
		internal DevExpress.XtraBars.Ribbon.RibbonControl RibbonControl1;
		internal Label labelform;
		internal Label labelthanhcong;
		private DevExpress.XtraEditors.ButtonEdit withEventsField_txtTen;
		internal DevExpress.XtraEditors.ButtonEdit txtTen {
			get { return withEventsField_txtTen; }
			set {
				if (withEventsField_txtTen != null) {
					withEventsField_txtTen.ButtonClick -= txtTen_ButtonClick;
				}
				withEventsField_txtTen = value;
				if (withEventsField_txtTen != null) {
					withEventsField_txtTen.ButtonClick += txtTen_ButtonClick;
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
	}
}
