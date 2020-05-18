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
	partial class HeThong_DangNhap : DevExpress.XtraBars.Ribbon.RibbonForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeThong_DangNhap));
			this.RibbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
			this.txtidcongty = new System.Windows.Forms.TextBox();
			this.labelform = new System.Windows.Forms.Label();
			this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.txtmatkhau = new DevExpress.XtraEditors.TextEdit();
			this.txtdangnhap = new DevExpress.XtraEditors.TextEdit();
			this.noti = new System.Windows.Forms.Label();
			this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
			this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			((System.ComponentModel.ISupportInitialize)this.RibbonControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.PanelControl1).BeginInit();
			this.PanelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.txtmatkhau.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.txtdangnhap.Properties).BeginInit();
			this.SuspendLayout();
			//
			//RibbonControl1
			//
			this.RibbonControl1.ExpandCollapseItem.Id = 0;
			this.RibbonControl1.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.RibbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { this.RibbonControl1.ExpandCollapseItem });
			this.RibbonControl1.Location = new System.Drawing.Point(0, 0);
			this.RibbonControl1.MaxItemId = 1;
			this.RibbonControl1.Name = "RibbonControl1";
			this.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOffice;
			this.RibbonControl1.Size = new System.Drawing.Size(376, 52);
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(33, 39);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(91, 14);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Tên đăng nhập";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(35, 72);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(57, 14);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Mật khẩu";
			//
			//btnThoat
			//
			this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnThoat.Appearance.Options.UseFont = true;
			this.btnThoat.Image = (System.Drawing.Image)resources.GetObject("btnThoat.Image");
			this.btnThoat.Location = new System.Drawing.Point(207, 117);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(103, 27);
			this.btnThoat.TabIndex = 9;
			this.btnThoat.Text = "Thoát";
			//
			//txtidcongty
			//
			this.txtidcongty.Location = new System.Drawing.Point(202, 237);
			this.txtidcongty.Name = "txtidcongty";
			this.txtidcongty.Size = new System.Drawing.Size(86, 21);
			this.txtidcongty.TabIndex = 10;
			//
			//labelform
			//
			this.labelform.AutoSize = true;
			this.labelform.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.labelform.Location = new System.Drawing.Point(127, 159);
			this.labelform.Name = "labelform";
			this.labelform.Size = new System.Drawing.Size(156, 14);
			this.labelform.TabIndex = 11;
			this.labelform.Text = "(User: Admin, Pass: Admin)";
			//
			//PanelControl1
			//
			this.PanelControl1.Controls.Add(this.txtmatkhau);
			this.PanelControl1.Controls.Add(this.txtdangnhap);
			this.PanelControl1.Controls.Add(this.noti);
			this.PanelControl1.Controls.Add(this.labelform);
			this.PanelControl1.Controls.Add(this.txtidcongty);
			this.PanelControl1.Controls.Add(this.btnThoat);
			this.PanelControl1.Controls.Add(this.btnDangNhap);
			this.PanelControl1.Controls.Add(this.Label2);
			this.PanelControl1.Controls.Add(this.Label1);
			this.PanelControl1.Location = new System.Drawing.Point(0, 27);
			this.PanelControl1.Name = "PanelControl1";
			this.PanelControl1.Size = new System.Drawing.Size(376, 204);
			this.PanelControl1.TabIndex = 2;
			//
			//txtmatkhau
			//
			this.txtmatkhau.EditValue = "admin";
			this.txtmatkhau.Location = new System.Drawing.Point(130, 69);
			this.txtmatkhau.MenuManager = this.RibbonControl1;
			this.txtmatkhau.Name = "txtmatkhau";
			this.txtmatkhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtmatkhau.Properties.Appearance.Options.UseFont = true;
			this.txtmatkhau.Properties.UseSystemPasswordChar = true;
			this.txtmatkhau.Size = new System.Drawing.Size(171, 20);
			this.txtmatkhau.TabIndex = 14;
			//
			//txtdangnhap
			//
			this.txtdangnhap.EditValue = "admin";
			this.txtdangnhap.Location = new System.Drawing.Point(130, 36);
			this.txtdangnhap.MenuManager = this.RibbonControl1;
			this.txtdangnhap.Name = "txtdangnhap";
			this.txtdangnhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtdangnhap.Properties.Appearance.Options.UseFont = true;
			this.txtdangnhap.Size = new System.Drawing.Size(171, 20);
			this.txtdangnhap.TabIndex = 13;
			//
			//noti
			//
			this.noti.AutoSize = true;
			this.noti.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.noti.ForeColor = System.Drawing.Color.Firebrick;
			this.noti.Location = new System.Drawing.Point(33, 159);
			this.noti.Name = "noti";
			this.noti.Size = new System.Drawing.Size(0, 14);
			this.noti.TabIndex = 12;
			//
			//btnDangNhap
			//
			this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnDangNhap.Appearance.Options.UseFont = true;
			this.btnDangNhap.Image = (System.Drawing.Image)resources.GetObject("btnDangNhap.Image");
			this.btnDangNhap.Location = new System.Drawing.Point(59, 117);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(103, 27);
			this.btnDangNhap.TabIndex = 8;
			this.btnDangNhap.Text = "Đăng nhập";
			//
			//HeThong_DangNhap
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(376, 221);
			this.Controls.Add(this.PanelControl1);
			this.Controls.Add(this.RibbonControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "HeThong_DangNhap";
			this.Ribbon = this.RibbonControl1;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng Nhập Quản Lý Bán Hàng";
			((System.ComponentModel.ISupportInitialize)this.RibbonControl1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.PanelControl1).EndInit();
			this.PanelControl1.ResumeLayout(false);
			this.PanelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.txtmatkhau.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.txtdangnhap.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal DevExpress.XtraBars.Ribbon.RibbonControl RibbonControl1;
		internal Label Label1;
		internal Label Label2;
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
		internal TextBox txtidcongty;
		internal Label labelform;
		internal DevExpress.XtraEditors.PanelControl PanelControl1;
		internal DevExpress.LookAndFeel.DefaultLookAndFeel DefaultLookAndFeel1;
		internal Label noti;
		internal DevExpress.XtraEditors.TextEdit txtmatkhau;
		internal DevExpress.XtraEditors.TextEdit txtdangnhap;
		private DevExpress.XtraEditors.SimpleButton withEventsField_btnDangNhap;
		internal DevExpress.XtraEditors.SimpleButton btnDangNhap {
			get { return withEventsField_btnDangNhap; }
			set {
				if (withEventsField_btnDangNhap != null) {
					withEventsField_btnDangNhap.Click -= btnDangNhap_Click;
				}
				withEventsField_btnDangNhap = value;
				if (withEventsField_btnDangNhap != null) {
					withEventsField_btnDangNhap.Click += btnDangNhap_Click;
				}
			}
		}
	}
}
