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
    public partial class DanhMuc_BoPhan : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_BoPhan()
        {
            InitializeComponent();
        }
        public void DanhMuc_BoPhan_Load(object sender, EventArgs e)
        {
            LoadGridBoPhan();
            Log_BUS.ThemNhatKy("Bộ phận", "Xem danh sách bộ phận");
        }
        public void LoadGridBoPhan()
        {
            gridBoPhan.DataSource = BoPhanBUS.LayToanBoBoPhan();
        }

        public void btnThemBoPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc_ThemBoPhan f = new DanhMuc_ThemBoPhan();
            f.eventThemXongBoPhan += LoadGridBoPhan;
            f.ShowDialog();
        }

        public void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] l = GridView1.GetSelectedRows();

            var index = l[0];

            DanhMuc_SuaBoPhan f = new DanhMuc_SuaBoPhan();
            f.BoPhanSua = ((List<BoPhanDTO>)gridBoPhan.DataSource)[index];
            f.eventSuaXongBoPhan += LoadGridBoPhan;
            f.ShowDialog();
        }

        public void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] l = GridView1.GetSelectedRows();
            var index = l[0];
            switch (MessageBox.Show("Bạn có chắc chắn muốn xóa bộ phận này không?", "Hỏi Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    BoPhanDTO bophan = default(BoPhanDTO);
                    bophan = ((List<BoPhanDTO>)gridBoPhan.DataSource)[index];
                    bool test = BoPhanBUS.XoaKhoHang(bophan);

                    if (test == true)
                    {
                        Log_BUS.ThemNhatKy("Bộ phận", "Xóa bộ phận");
                        LoadGridBoPhan();
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