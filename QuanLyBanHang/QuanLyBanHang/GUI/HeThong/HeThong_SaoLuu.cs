using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBanHang.BUS;
using QuanLyBanHang.BUS;

namespace QuanLyBanHang.GUI.HeThong
{
    public partial class HeThong_SaoLuu : DevExpress.XtraEditors.XtraForm
    {
        public HeThong_SaoLuu()
        {
            InitializeComponent();
        }
        TaiKhoan_BUS TKBUS = new TaiKhoan_BUS();
        TaiKhoan_DTO TKDTO = new TaiKhoan_DTO();
        private void HeThong_SaoLuu_Load(object sender, EventArgs e)
        {
            txtTen.Text = "QuanLyBanHang";
            txtDuongDan.Text = "D:\\";
        }

        public void btnThucHien_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTen.Text == "")
                {
                    this.labelthanhcong.Text = "(*) Bạn chưa đặt tên cho file backup!";
                    this.labelform.Text = "";
                    return;
                }
                string ten = "\\" + txtTen.Text + " " + DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString() + " " + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + ".bak";
                string duongdan = Convert.ToString(txtDuongDan.Text);
                timer1.Start();
                ProgressBar1.Visible = true;
                TKBUS.Backup(ten, duongdan);
            }
            catch (Exception ex)
            {
                timer1.Stop();
                ProgressBar1.Visible = false;
                btnThucHien.Visible = true;
                btnHoanThanh.Visible = false;
                MessageBox.Show(ex.Message, "Lỗi Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.labelthanhcong.Text = "(*) Bạn vui lòng chọn lại đường dẫn hợp lệ";
                this.labelform.Text = "";
            }
        }

        public void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void txtDuongDan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            folderBrowserDialog1.Description = "Chọn đường dẫn tới ổ D, E (trừ ổ hệ thống)";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDuongDan.EditValue = folderBrowserDialog1.SelectedPath.ToString();
            }
        }

        public void Timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Increment(1);
            if (ProgressBar1.Value == ProgressBar1.Maximum)
            {
               timer1.Stop();
                this.labelthanhcong.Text = "Cơ sở dữ liệu đã được Backup thành công";
                this.labelform.Text = "";
                ProgressBar1.Visible = false;
                btnThucHien.Visible = false;
                btnHoanThanh.Visible = true;
                this.btnHoanThanh.Focus();
                Log_BUS.ThemNhatKy("Dữ liệu", "Sao lưu dữ liệu");
            }
        }

        public void btnHoanThanh_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}