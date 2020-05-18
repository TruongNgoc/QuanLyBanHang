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
	partial class DanhMuc_SuaKhuVuc : DevExpress.XtraBars.Ribbon.RibbonForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhMuc_SuaKhuVuc));
			this.RibbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.txtMaKhuVuc = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
			this.btnDong = new DevExpress.XtraEditors.SimpleButton();
			this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
			this.txtTen = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.chxConQuanLy = new DevExpress.XtraEditors.CheckEdit();
			((System.ComponentModel.ISupportInitialize)this.RibbonControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.PanelControl1).BeginInit();
			this.PanelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.txtMaKhuVuc.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.txtGhiChu.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.txtTen.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.chxConQuanLy.Properties).BeginInit();
			this.SuspendLayout();
			//
			//RibbonControl1
			//
			this.RibbonControl1.ExpandCollapseItem.Id = 0;
			this.RibbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { this.RibbonControl1.ExpandCollapseItem });
			this.RibbonControl1.Location = new System.Drawing.Point(0, 0);
			this.RibbonControl1.MaxItemId = 1;
			this.RibbonControl1.Name = "RibbonControl1";
			this.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOffice;
			this.RibbonControl1.Size = new System.Drawing.Size(281, 27);
			//
			//PanelControl1
			//
			this.PanelControl1.Controls.Add(this.txtMaKhuVuc);
			this.PanelControl1.Controls.Add(this.LabelControl1);
			this.PanelControl1.Controls.Add(this.btnLuu);
			this.PanelControl1.Controls.Add(this.btnDong);
			this.PanelControl1.Controls.Add(this.txtGhiChu);
			this.PanelControl1.Controls.Add(this.txtTen);
			this.PanelControl1.Controls.Add(this.LabelControl3);
			this.PanelControl1.Controls.Add(this.LabelControl2);
			this.PanelControl1.Controls.Add(this.chxConQuanLy);
			this.PanelControl1.Location = new System.Drawing.Point(0, 27);
			this.PanelControl1.Name = "PanelControl1";
			this.PanelControl1.Size = new System.Drawing.Size(281, 218);
			this.PanelControl1.TabIndex = 4;
			//
			//txtMaKhuVuc
			//
			this.txtMaKhuVuc.Location = new System.Drawing.Point(69, 20);
			this.txtMaKhuVuc.Name = "txtMaKhuVuc";
			this.txtMaKhuVuc.Properties.ReadOnly = true;
			this.txtMaKhuVuc.Size = new System.Drawing.Size(180, 20);
			this.txtMaKhuVuc.TabIndex = 16;
			//
			//LabelControl1
			//
			this.LabelControl1.Location = new System.Drawing.Point(22, 23);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(14, 13);
			this.LabelControl1.TabIndex = 15;
			this.LabelControl1.Text = "Mã";
			//
			//btnLuu
			//
			this.btnLuu.Image = (System.Drawing.Image)resources.GetObject("btnLuu.Image");
			this.btnLuu.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
			this.btnLuu.Location = new System.Drawing.Point(69, 167);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(84, 23);
			this.btnLuu.TabIndex = 14;
			this.btnLuu.Text = "Lưu";
			//
			//btnDong
			//
			this.btnDong.Image = (System.Drawing.Image)resources.GetObject("btnDong.Image");
			this.btnDong.Location = new System.Drawing.Point(165, 167);
			this.btnDong.Name = "btnDong";
			this.btnDong.Size = new System.Drawing.Size(84, 23);
			this.btnDong.TabIndex = 13;
			this.btnDong.Text = "Đóng";
			//
			//txtGhiChu
			//
			this.txtGhiChu.Location = new System.Drawing.Point(69, 94);
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new System.Drawing.Size(180, 20);
			this.txtGhiChu.TabIndex = 12;
			//
			//txtTen
			//
			this.txtTen.Location = new System.Drawing.Point(69, 60);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(180, 20);
			this.txtTen.TabIndex = 11;
			//
			//LabelControl3
			//
			this.LabelControl3.Location = new System.Drawing.Point(22, 97);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(35, 13);
			this.LabelControl3.TabIndex = 10;
			this.LabelControl3.Text = "Ghi chú";
			//
			//LabelControl2
			//
			this.LabelControl2.Location = new System.Drawing.Point(22, 63);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(18, 13);
			this.LabelControl2.TabIndex = 9;
			this.LabelControl2.Text = "Tên";
			//
			//chxConQuanLy
			//
			this.chxConQuanLy.EditValue = true;
			this.chxConQuanLy.Location = new System.Drawing.Point(69, 120);
			this.chxConQuanLy.Name = "chxConQuanLy";
			this.chxConQuanLy.Properties.Caption = "Còn quản lý";
			this.chxConQuanLy.Size = new System.Drawing.Size(84, 19);
			this.chxConQuanLy.TabIndex = 8;
			//
			//DanhMuc_SuaKhuVuc
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(281, 230);
			this.Controls.Add(this.PanelControl1);
			this.Controls.Add(this.RibbonControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "DanhMuc_SuaKhuVuc";
			this.Ribbon = this.RibbonControl1;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sửa Khu Vực";
			((System.ComponentModel.ISupportInitialize)this.RibbonControl1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.PanelControl1).EndInit();
			this.PanelControl1.ResumeLayout(false);
			this.PanelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.txtMaKhuVuc.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.txtGhiChu.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.txtTen.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.chxConQuanLy.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		internal DevExpress.XtraBars.Ribbon.RibbonControl RibbonControl1;
		internal DevExpress.XtraEditors.PanelControl PanelControl1;
		internal DevExpress.XtraEditors.TextEdit txtMaKhuVuc;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		private DevExpress.XtraEditors.SimpleButton withEventsField_btnLuu;
		internal DevExpress.XtraEditors.SimpleButton btnLuu {
			get { return withEventsField_btnLuu; }
			set {
				if (withEventsField_btnLuu != null) {
					withEventsField_btnLuu.Click -= btnLuu_Click;
				}
				withEventsField_btnLuu = value;
				if (withEventsField_btnLuu != null) {
					withEventsField_btnLuu.Click += btnLuu_Click;
				}
			}
		}
		private DevExpress.XtraEditors.SimpleButton withEventsField_btnDong;
		internal DevExpress.XtraEditors.SimpleButton btnDong {
			get { return withEventsField_btnDong; }
			set {
				if (withEventsField_btnDong != null) {
					withEventsField_btnDong.Click -= btnDong_Click;
				}
				withEventsField_btnDong = value;
				if (withEventsField_btnDong != null) {
					withEventsField_btnDong.Click += btnDong_Click;
				}
			}
		}
		internal DevExpress.XtraEditors.TextEdit txtGhiChu;
		internal DevExpress.XtraEditors.TextEdit txtTen;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.CheckEdit chxConQuanLy;
	}
}
