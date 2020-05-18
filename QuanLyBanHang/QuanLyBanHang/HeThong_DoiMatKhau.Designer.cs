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
	partial class HeThong_DoiMatKhau : DevExpress.XtraBars.Ribbon.RibbonForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeThong_DoiMatKhau));
			this.txtmatkhaucudmk = new DevExpress.XtraEditors.TextEdit();
			this.txtmatkhaumoidmk = new DevExpress.XtraEditors.TextEdit();
			this.txtnhaplaimatkhaudmk = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.btnDongY = new DevExpress.XtraEditors.SimpleButton();
			this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
			this.txtuser = new System.Windows.Forms.TextBox();
			this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.labelthanhcong = new System.Windows.Forms.Label();
			this.labelform = new System.Windows.Forms.Label();
			this.RibbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.labeltrung = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)this.txtmatkhaucudmk.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.txtmatkhaumoidmk.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.txtnhaplaimatkhaudmk.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.PanelControl1).BeginInit();
			this.PanelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.RibbonControl1).BeginInit();
			this.SuspendLayout();
			//
			//txtmatkhaucudmk
			//
			this.txtmatkhaucudmk.Location = new System.Drawing.Point(147, 57);
			this.txtmatkhaucudmk.Name = "txtmatkhaucudmk";
			this.txtmatkhaucudmk.Properties.UseSystemPasswordChar = true;
			this.txtmatkhaucudmk.Size = new System.Drawing.Size(171, 20);
			this.txtmatkhaucudmk.TabIndex = 1;
			//
			//txtmatkhaumoidmk
			//
			this.txtmatkhaumoidmk.Location = new System.Drawing.Point(147, 88);
			this.txtmatkhaumoidmk.Name = "txtmatkhaumoidmk";
			this.txtmatkhaumoidmk.Properties.UseSystemPasswordChar = true;
			this.txtmatkhaumoidmk.Size = new System.Drawing.Size(171, 20);
			this.txtmatkhaumoidmk.TabIndex = 2;
			//
			//txtnhaplaimatkhaudmk
			//
			this.txtnhaplaimatkhaudmk.Location = new System.Drawing.Point(147, 121);
			this.txtnhaplaimatkhaudmk.Name = "txtnhaplaimatkhaudmk";
			this.txtnhaplaimatkhaudmk.Properties.UseSystemPasswordChar = true;
			this.txtnhaplaimatkhaudmk.Size = new System.Drawing.Size(171, 20);
			this.txtnhaplaimatkhaudmk.TabIndex = 3;
			//
			//LabelControl1
			//
			this.LabelControl1.Location = new System.Drawing.Point(37, 60);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(58, 13);
			this.LabelControl1.TabIndex = 1;
			this.LabelControl1.Text = "Mật khẩu cũ";
			//
			//LabelControl2
			//
			this.LabelControl2.Location = new System.Drawing.Point(37, 91);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(63, 13);
			this.LabelControl2.TabIndex = 1;
			this.LabelControl2.Text = "Mật khẩu mới";
			//
			//LabelControl3
			//
			this.LabelControl3.Location = new System.Drawing.Point(37, 124);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(85, 13);
			this.LabelControl3.TabIndex = 1;
			this.LabelControl3.Text = "Nhập lại mật khẩu";
			//
			//LabelControl4
			//
			this.LabelControl4.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 16f);
			this.LabelControl4.Appearance.Options.UseFont = true;
			this.LabelControl4.Location = new System.Drawing.Point(87, 12);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(186, 27);
			this.LabelControl4.TabIndex = 3;
			this.LabelControl4.Text = "Thay Đổi Mật Khẩu";
			//
			//btnDongY
			//
			this.btnDongY.Image = (System.Drawing.Image)resources.GetObject("btnDongY.Image");
			this.btnDongY.Location = new System.Drawing.Point(61, 180);
			this.btnDongY.Name = "btnDongY";
			this.btnDongY.Size = new System.Drawing.Size(102, 28);
			this.btnDongY.TabIndex = 5;
			this.btnDongY.Text = "Đồng ý";
			//
			//btnThoat
			//
			this.btnThoat.Image = (System.Drawing.Image)resources.GetObject("btnThoat.Image");
			this.btnThoat.Location = new System.Drawing.Point(212, 180);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(106, 28);
			this.btnThoat.TabIndex = 6;
			this.btnThoat.Text = "Thoát";
			//
			//txtuser
			//
			this.txtuser.Location = new System.Drawing.Point(12, 240);
			this.txtuser.Name = "txtuser";
			this.txtuser.Size = new System.Drawing.Size(44, 21);
			this.txtuser.TabIndex = 7;
			//
			//PanelControl1
			//
			this.PanelControl1.Controls.Add(this.labeltrung);
			this.PanelControl1.Controls.Add(this.labelthanhcong);
			this.PanelControl1.Controls.Add(this.txtuser);
			this.PanelControl1.Controls.Add(this.labelform);
			this.PanelControl1.Controls.Add(this.btnThoat);
			this.PanelControl1.Controls.Add(this.btnDongY);
			this.PanelControl1.Controls.Add(this.LabelControl4);
			this.PanelControl1.Controls.Add(this.LabelControl3);
			this.PanelControl1.Controls.Add(this.LabelControl2);
			this.PanelControl1.Controls.Add(this.LabelControl1);
			this.PanelControl1.Controls.Add(this.txtnhaplaimatkhaudmk);
			this.PanelControl1.Controls.Add(this.txtmatkhaumoidmk);
			this.PanelControl1.Controls.Add(this.txtmatkhaucudmk);
			this.PanelControl1.Location = new System.Drawing.Point(0, 27);
			this.PanelControl1.Name = "PanelControl1";
			this.PanelControl1.Size = new System.Drawing.Size(356, 231);
			this.PanelControl1.TabIndex = 2;
			//
			//labelthanhcong
			//
			this.labelthanhcong.AutoSize = true;
			this.labelthanhcong.ForeColor = System.Drawing.Color.Firebrick;
			this.labelthanhcong.Location = new System.Drawing.Point(89, 154);
			this.labelthanhcong.Name = "labelthanhcong";
			this.labelthanhcong.Size = new System.Drawing.Size(0, 13);
			this.labelthanhcong.TabIndex = 9;
			//
			//labelform
			//
			this.labelform.AutoSize = true;
			this.labelform.Location = new System.Drawing.Point(94, 154);
			this.labelform.Name = "labelform";
			this.labelform.Size = new System.Drawing.Size(201, 13);
			this.labelform.TabIndex = 8;
			this.labelform.Text = "(*) Bạn có chắc chắn thay đổi mật khẩu?";
			//
			//RibbonControl1
			//
			this.RibbonControl1.ExpandCollapseItem.Id = 0;
			this.RibbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { this.RibbonControl1.ExpandCollapseItem });
			this.RibbonControl1.Location = new System.Drawing.Point(0, 0);
			this.RibbonControl1.MaxItemId = 1;
			this.RibbonControl1.Name = "RibbonControl1";
			this.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOffice;
			this.RibbonControl1.Size = new System.Drawing.Size(356, 52);
			//
			//labeltrung
			//
			this.labeltrung.AutoSize = true;
			this.labeltrung.ForeColor = System.Drawing.Color.Firebrick;
			this.labeltrung.Location = new System.Drawing.Point(63, 154);
			this.labeltrung.Name = "labeltrung";
			this.labeltrung.Size = new System.Drawing.Size(0, 13);
			this.labeltrung.TabIndex = 10;
			//
			//HeThong_DoiMatKhau
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 251);
			this.Controls.Add(this.PanelControl1);
			this.Controls.Add(this.RibbonControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "HeThong_DoiMatKhau";
			this.Ribbon = this.RibbonControl1;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đổi Mật Khẩu";
			((System.ComponentModel.ISupportInitialize)this.txtmatkhaucudmk.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.txtmatkhaumoidmk.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.txtnhaplaimatkhaudmk.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.PanelControl1).EndInit();
			this.PanelControl1.ResumeLayout(false);
			this.PanelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.RibbonControl1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal DevExpress.XtraEditors.TextEdit txtmatkhaucudmk;
		internal DevExpress.XtraEditors.TextEdit txtmatkhaumoidmk;
		internal DevExpress.XtraEditors.TextEdit txtnhaplaimatkhaudmk;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		private DevExpress.XtraEditors.SimpleButton withEventsField_btnDongY;
		internal DevExpress.XtraEditors.SimpleButton btnDongY {
			get { return withEventsField_btnDongY; }
			set {
				if (withEventsField_btnDongY != null) {
					withEventsField_btnDongY.Click -= btnDongY_Click_1;
				}
				withEventsField_btnDongY = value;
				if (withEventsField_btnDongY != null) {
					withEventsField_btnDongY.Click += btnDongY_Click_1;
				}
			}
		}
		private DevExpress.XtraEditors.SimpleButton withEventsField_btnThoat;
		internal DevExpress.XtraEditors.SimpleButton btnThoat {
			get { return withEventsField_btnThoat; }
			set {
				if (withEventsField_btnThoat != null) {
					withEventsField_btnThoat.Click -= btnThoat_Click_1;
				}
				withEventsField_btnThoat = value;
				if (withEventsField_btnThoat != null) {
					withEventsField_btnThoat.Click += btnThoat_Click_1;
				}
			}
		}
		internal TextBox txtuser;
		internal DevExpress.XtraEditors.PanelControl PanelControl1;
		internal DevExpress.XtraBars.Ribbon.RibbonControl RibbonControl1;
		internal Label labelthanhcong;
		internal Label labelform;
		internal Label labeltrung;
	}
}
