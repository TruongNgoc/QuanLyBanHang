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

namespace QuanLyBanHang.GUI.BoPhan
{
    public partial class DanhMuc_ThemBoPhan : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_ThemBoPhan()
        {
            InitializeComponent();
        }
        public delegate void ThemXongBoPhan();
        private ThemXongBoPhan eventThemXongBoPhanEvent;
        public event ThemXongBoPhan eventThemXongBoPhan
        {
            add
            {
                eventThemXongBoPhanEvent = (ThemXongBoPhan)System.Delegate.Combine(eventThemXongBoPhanEvent, value);
            }
            remove
            {
                eventThemXongBoPhanEvent = (ThemXongBoPhan)System.Delegate.Remove(eventThemXongBoPhanEvent, value);
            }
        }


        public void btnLuu_Click(object sender, EventArgs e)
        {
            BoPhanDTO bophanmoi = new BoPhanDTO();
            bophanmoi.TenBoPhan = Convert.ToString(txtTenBoPhan.Text);
            bophanmoi.GhiChu = Convert.ToString(txtGhiChu.Text);
            if (chkConQuanLy.Checked == true)
            {
                bophanmoi.ConQuanLy = true;
            }
            else
            {
                bophanmoi.ConQuanLy = false;

            }

            int test = BoPhanBUS.ThemBoPhan(bophanmoi);
            if (test == 0)
            {
                Log_BUS.ThemNhatKy("Bộ phận", "Thêm bộ phận");
                MessageBox.Show("Thêm bộ phận thành công");
                if (eventThemXongBoPhanEvent != null)
                    eventThemXongBoPhanEvent();
            }
            else
            {
                MessageBox.Show("Nội dung nhập không hợp lệ");
            }
        }

        public void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}