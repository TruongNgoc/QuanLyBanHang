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

namespace QuanLyBanHang.GUI.DonViTinh
{
    public partial class DanhMuc_ThemDonVi : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_ThemDonVi()
        {
            InitializeComponent();
        }
        public delegate void ThemXong();
        private ThemXong eventThemXongEvent;
        public event ThemXong eventThemXong
        {
            add
            {
                eventThemXongEvent = (ThemXong)System.Delegate.Combine(eventThemXongEvent, value);
            }
            remove
            {
                eventThemXongEvent = (ThemXong)System.Delegate.Remove(eventThemXongEvent, value);
            }
        }


        public void btnLuu_Click(object sender, EventArgs e)
        {
            DonViTinhDTO dv = new DonViTinhDTO();
            dv.TenDonVi = System.Convert.ToString(txtTenDonVi.Text);
            dv.GhiChu = System.Convert.ToString(txtGhiChu.Text);
            if (chkConQuanLy.Checked == true)
            {
                dv.ConQuanLy = true;
            }
            else
            {
                dv.ConQuanLy = false;
            }

            bool test = DonViTinhBUS.ThemDonVi(dv);
            if (test == true)
            {
                Log_BUS.ThemNhatKy("Đơn vị", "Thêm đơn vị");
                MessageBox.Show("Thêm đơn vị thành công");
                if (eventThemXongEvent != null)
                    eventThemXongEvent();
            }
            else
            {
                MessageBox.Show("Thêm đơn vị không thành công, dữ liệu thêm không đúng");
            }
        }

        public void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}