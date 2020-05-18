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
	partial class HeThong_FormThongTin : DevExpress.XtraBars.Ribbon.RibbonForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeThong_FormThongTin));
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl12 = new DevExpress.XtraEditors.LabelControl();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.RibbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.GroupBox3.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PanelControl1).BeginInit();
			this.PanelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.RibbonControl1).BeginInit();
			this.SuspendLayout();
			//
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.LabelControl10);
			this.GroupBox3.Controls.Add(this.LabelControl9);
			this.GroupBox3.Controls.Add(this.LabelControl12);
			this.GroupBox3.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.GroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.GroupBox3.Location = new System.Drawing.Point(14, 342);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(417, 124);
			this.GroupBox3.TabIndex = 7;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Thành viên nhóm:";
			//
			//LabelControl10
			//
			this.LabelControl10.Appearance.Font = new System.Drawing.Font("Arial", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.LabelControl10.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
			this.LabelControl10.Appearance.Options.UseFont = true;
			this.LabelControl10.Appearance.Options.UseForeColor = true;
			this.LabelControl10.Location = new System.Drawing.Point(81, 96);
			this.LabelControl10.Name = "LabelControl10";
			this.LabelControl10.Size = new System.Drawing.Size(154, 16);
			this.LabelControl10.TabIndex = 0;
			this.LabelControl10.Text = "1361125 Nguyễn Quốc Vĩ";
			//
			//LabelControl9
			//
			this.LabelControl9.Appearance.Font = new System.Drawing.Font("Arial", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.LabelControl9.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
			this.LabelControl9.Appearance.Options.UseFont = true;
			this.LabelControl9.Appearance.Options.UseForeColor = true;
			this.LabelControl9.Location = new System.Drawing.Point(81, 66);
			this.LabelControl9.Name = "LabelControl9";
			this.LabelControl9.Size = new System.Drawing.Size(171, 16);
			this.LabelControl9.TabIndex = 0;
			this.LabelControl9.Text = "1361013 Nguyễn Văn Chiến";
			//
			//LabelControl12
			//
			this.LabelControl12.Appearance.Font = new System.Drawing.Font("Arial", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.LabelControl12.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
			this.LabelControl12.Appearance.Options.UseFont = true;
			this.LabelControl12.Appearance.Options.UseForeColor = true;
			this.LabelControl12.Location = new System.Drawing.Point(81, 36);
			this.LabelControl12.Name = "LabelControl12";
			this.LabelControl12.Size = new System.Drawing.Size(142, 16);
			this.LabelControl12.TabIndex = 0;
			this.LabelControl12.Text = "1361134 Đỗ Trung Hiếu";
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.LabelControl8);
			this.GroupBox2.Controls.Add(this.LabelControl7);
			this.GroupBox2.Controls.Add(this.LabelControl6);
			this.GroupBox2.Controls.Add(this.LabelControl5);
			this.GroupBox2.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.GroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.GroupBox2.Location = new System.Drawing.Point(14, 171);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(417, 154);
			this.GroupBox2.TabIndex = 6;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Sản phẩm này được đăng ký cho: ";
			//
			//LabelControl8
			//
			this.LabelControl8.Appearance.Font = new System.Drawing.Font("Arial", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.LabelControl8.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
			this.LabelControl8.Appearance.Options.UseFont = true;
			this.LabelControl8.Appearance.Options.UseForeColor = true;
			this.LabelControl8.Location = new System.Drawing.Point(81, 120);
			this.LabelControl8.Name = "LabelControl8";
			this.LabelControl8.Size = new System.Drawing.Size(151, 16);
			this.LabelControl8.TabIndex = 0;
			this.LabelControl8.Text = "Phiên bản: Professional";
			//
			//LabelControl7
			//
			this.LabelControl7.Appearance.Font = new System.Drawing.Font("Arial", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.LabelControl7.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
			this.LabelControl7.Appearance.Options.UseFont = true;
			this.LabelControl7.Appearance.Options.UseForeColor = true;
			this.LabelControl7.Location = new System.Drawing.Point(81, 92);
			this.LabelControl7.Name = "LabelControl7";
			this.LabelControl7.Size = new System.Drawing.Size(173, 16);
			this.LabelControl7.TabIndex = 0;
			this.LabelControl7.Text = "Địa chỉ: khoailang.khoaitay";
			//
			//LabelControl6
			//
			this.LabelControl6.Appearance.Font = new System.Drawing.Font("Arial", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.LabelControl6.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
			this.LabelControl6.Appearance.Options.UseFont = true;
			this.LabelControl6.Appearance.Options.UseForeColor = true;
			this.LabelControl6.Location = new System.Drawing.Point(81, 62);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(122, 16);
			this.LabelControl6.TabIndex = 0;
			this.LabelControl6.Text = "Công ty: com.khoai";
			//
			//LabelControl5
			//
			this.LabelControl5.Appearance.Font = new System.Drawing.Font("Arial", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.LabelControl5.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
			this.LabelControl5.Appearance.Options.UseFont = true;
			this.LabelControl5.Appearance.Options.UseForeColor = true;
			this.LabelControl5.Location = new System.Drawing.Point(81, 35);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(158, 16);
			this.LabelControl5.TabIndex = 0;
			this.LabelControl5.Text = "Họ và tên: Nguyễn Văn A";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.LabelControl4);
			this.GroupBox1.Controls.Add(this.LabelControl3);
			this.GroupBox1.Controls.Add(this.LabelControl2);
			this.GroupBox1.Controls.Add(this.LabelControl1);
			this.GroupBox1.Location = new System.Drawing.Point(14, 9);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(417, 144);
			this.GroupBox1.TabIndex = 5;
			this.GroupBox1.TabStop = false;
			//
			//LabelControl4
			//
			this.LabelControl4.Appearance.Font = new System.Drawing.Font("Arial", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.LabelControl4.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
			this.LabelControl4.Appearance.Options.UseFont = true;
			this.LabelControl4.Appearance.Options.UseForeColor = true;
			this.LabelControl4.Location = new System.Drawing.Point(81, 112);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(209, 16);
			this.LabelControl4.TabIndex = 0;
			this.LabelControl4.Text = "Email: rocketteam69@gmail.com";
			//
			//LabelControl3
			//
			this.LabelControl3.Appearance.Font = new System.Drawing.Font("Arial", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.LabelControl3.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
			this.LabelControl3.Appearance.Options.UseFont = true;
			this.LabelControl3.Appearance.Options.UseForeColor = true;
			this.LabelControl3.Location = new System.Drawing.Point(81, 84);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(214, 16);
			this.LabelControl3.TabIndex = 0;
			this.LabelControl3.Text = "Website: rocketteam69.com.khoai";
			//
			//LabelControl2
			//
			this.LabelControl2.Appearance.Font = new System.Drawing.Font("Arial", 11.25f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.LabelControl2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
			this.LabelControl2.Appearance.Options.UseFont = true;
			this.LabelControl2.Appearance.Options.UseForeColor = true;
			this.LabelControl2.Location = new System.Drawing.Point(81, 52);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(248, 17);
			this.LabelControl2.TabIndex = 0;
			this.LabelControl2.Text = "Rocket Team @Sale Shopping Online";
			//
			//LabelControl1
			//
			this.LabelControl1.Appearance.Font = new System.Drawing.Font("Arial", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.LabelControl1.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.LabelControl1.Appearance.Options.UseFont = true;
			this.LabelControl1.Appearance.Options.UseForeColor = true;
			this.LabelControl1.Location = new System.Drawing.Point(30, 19);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(367, 27);
			this.LabelControl1.TabIndex = 0;
			this.LabelControl1.Text = "PHẦN MỀM QUẢN LÝ BÁN HÀNG";
			//
			//PanelControl1
			//
			this.PanelControl1.Controls.Add(this.GroupBox1);
			this.PanelControl1.Controls.Add(this.GroupBox3);
			this.PanelControl1.Controls.Add(this.GroupBox2);
			this.PanelControl1.Location = new System.Drawing.Point(0, 27);
			this.PanelControl1.Name = "PanelControl1";
			this.PanelControl1.Size = new System.Drawing.Size(446, 493);
			this.PanelControl1.TabIndex = 8;
			//
			//RibbonControl1
			//
			this.RibbonControl1.ExpandCollapseItem.Id = 0;
			this.RibbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { this.RibbonControl1.ExpandCollapseItem });
			this.RibbonControl1.Location = new System.Drawing.Point(0, 0);
			this.RibbonControl1.MaxItemId = 1;
			this.RibbonControl1.Name = "RibbonControl1";
			this.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOffice;
			this.RibbonControl1.Size = new System.Drawing.Size(446, 52);
			//
			//HeThong_FormThongTin
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(446, 508);
			this.Controls.Add(this.PanelControl1);
			this.Controls.Add(this.RibbonControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "HeThong_FormThongTin";
			this.Ribbon = this.RibbonControl1;
			this.Text = "Thông tin phần mềm";
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.PanelControl1).EndInit();
			this.PanelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.RibbonControl1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		internal GroupBox GroupBox3;
		internal DevExpress.XtraEditors.LabelControl LabelControl10;
		internal DevExpress.XtraEditors.LabelControl LabelControl9;
		internal DevExpress.XtraEditors.LabelControl LabelControl12;
		internal GroupBox GroupBox2;
		internal DevExpress.XtraEditors.LabelControl LabelControl8;
		internal DevExpress.XtraEditors.LabelControl LabelControl7;
		internal DevExpress.XtraEditors.LabelControl LabelControl6;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal GroupBox GroupBox1;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.PanelControl PanelControl1;
		internal DevExpress.XtraBars.Ribbon.RibbonControl RibbonControl1;
	}
}
