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
    public partial class HeThong_PhucHoi : DevExpress.XtraEditors.XtraForm
    {
        public HeThong_PhucHoi()
        {
            InitializeComponent();
        }

        TaiKhoan_BUS TKBUS = new TaiKhoan_BUS();
        TaiKhoan_DTO TKDTO = new TaiKhoan_DTO();


        // tạo button thực hiện đè lên button hoàn thành để khi ta chọn xong file để backup thì button thực hiện sẽ xuất hiện
        // khi progressbar chạy xong thì button sẽ chuyển thành hoàn thành và khi click vào nó thì sẽ thoát

        public void btnThucHien_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Start();
                ProgressBar1.Visible = true;
                TKBUS.Restore(Convert.ToString(txtTen.Text));
            }
            catch (Exception ex)
            {
                timer1.Stop();
                ProgressBar1.Visible = false;
                btnThucHien.Visible = true;
                btnHoanThanh.Visible = false;
                MessageBox.Show(ex.Message, "Lỗi Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.labelthanhcong.Text = "(*) Phục hồi thất bại!";
                this.labelform.Text = "";
            }
        }

        public void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void txtTen_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Chọn đường dẫn tới file Backup";
            openFileDialog1.Filter = "Backup Database File | *.bak";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtTen.EditValue = openFileDialog1.FileName.ToString();
            }
        }

        public void btnHoanThanh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Increment(1);
            if (ProgressBar1.Value == ProgressBar1.Maximum)
            {
                timer1.Stop();
                this.labelthanhcong.Text = "Phục hồi thành công!";
                this.labelform.Text = "";
                ProgressBar1.Visible = false;
                btnThucHien.Visible = false;
                btnHoanThanh.Visible = true;
                this.btnHoanThanh.Focus();
                Log_BUS.ThemNhatKy("Dữ liệu", "Phục hồi dữ liệu");
            }
        }
    }
}