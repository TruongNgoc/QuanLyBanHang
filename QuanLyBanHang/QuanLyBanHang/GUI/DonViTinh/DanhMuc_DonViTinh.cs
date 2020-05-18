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
    public partial class DanhMuc_DonViTinh : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_DonViTinh()
        {
            InitializeComponent();
        }
        public void DanhMuc_DonViTinh_Load(object sender, EventArgs e)
        {
            Log_BUS.ThemNhatKy("Đơn vị", "Xem danh sách đơn vị");
            LoadGridDonVi();
        }
        private void LoadGridDonVi()
        {
            gridDonVi.DataSource = DonViTinhBUS.LayTatCaDonVi();
        }

        public void btnThemDonVi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc_ThemDonVi f = new DanhMuc_ThemDonVi();
            f.eventThemXong += LoadGridDonVi;
            f.ShowDialog();
        }

        public void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] l = GridView1.GetSelectedRows();
            var index = l[0];
            DanhMuc_SuaDonVi f = new DanhMuc_SuaDonVi();
            f.DVSua = ((List<DonViTinhDTO>)gridDonVi.DataSource)[index];
            f.eventSuaXong += LoadGridDonVi;
            f.ShowDialog();
        }

        public void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] l = GridView1.GetSelectedRows();

            var index = l[0];
            switch (MessageBox.Show("Bạn có chắc chắn muốn xóa đơn vị này không?","Hỏi Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    DonViTinhDTO dv = default(DonViTinhDTO);
                    dv = ((List<DonViTinhDTO>)gridDonVi.DataSource)[index];
                    bool test = DonViTinhBUS.XoaDonVi(dv);

                    if (test == true)
                    {
                        LoadGridDonVi();
                        Log_BUS.ThemNhatKy("Đơn vị", "Xóa đơn vị");
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                    break;
                case DialogResult.No:
                    return;
            }
        }

        public void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}