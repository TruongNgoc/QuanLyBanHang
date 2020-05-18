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

namespace QuanLyBanHang.GUI.HeThong
{
    public partial class frmdoimatkhau : DevExpress.XtraEditors.XtraForm
    {
        public frmdoimatkhau()
        {
            InitializeComponent();
        }
        TaiKhoan_BUS TKBUS = new TaiKhoan_BUS();

        string a;
        string b;
        string c;
        string d;
        public void btnDongY_Click_1(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                this.labelform.Text = "";
                this.labelthanhcong.Text = "(*) Thông tin bắt buộc không được để trống";
            }
            else
            {
                a = txtuser.Text;
                b = Convert.ToString(txtmatkhaucudmk.Text);
                c = Convert.ToString(txtmatkhaumoidmk.Text);
                d = Convert.ToString(txtnhaplaimatkhaudmk.Text);
                if (txtmatkhaumoidmk.Text == txtnhaplaimatkhaudmk.Text)
                {
                    if (txtmatkhaucudmk.Text != txtmatkhaumoidmk.Text)
                    {
                        if (TKBUS.ThayDoiMatKhau(a, b, c, d) == 1)
                        {
                            this.labelform.Text = "";
                            this.labelthanhcong.Text = "Bạn đã thay đổi mật khẩu thành công";
                            this.labeltrung.Text = "";
                        }
                        else
                        {
                            this.labeltrung.Text = "";
                            this.labelform.Text = "";
                            this.labelthanhcong.Text = "(*) Mật khẩu cũ không chính xác";
                        }
                    }
                    else
                    {
                        this.labelform.Text = "";
                        this.labeltrung.Text = "(*) Mật khẩu mới không được trùng với mật khẩu cũ";
                        this.labelthanhcong.Text = "";
                    }
                }
                else
                {
                    this.labelform.Text = "";
                    this.labelthanhcong.Text = "(*) Nhập lại mật khẩu không chính xác";
                    this.labeltrung.Text = "";
                }
            }
        }
        private void frmdoimatkhau_Load(object sender, EventArgs e)
        {
            Log_BUS.ThemNhatKy("Hệ thống", "Đổi mật khẩu");
            this.AcceptButton = btnDongY;
        }
        public void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsEmpty()
        {
            return string.IsNullOrEmpty(Convert.ToString(this.txtmatkhaucudmk.Text)) || string.IsNullOrEmpty(Convert.ToString(this.txtmatkhaumoidmk.Text)) || string.IsNullOrEmpty(Convert.ToString(this.txtnhaplaimatkhaudmk.Text));
        }
    }
}