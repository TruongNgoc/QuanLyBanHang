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

namespace QuanLyBanHang.GUI.KhoHang
{
    public partial class DanhMuc_KhoHang : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_KhoHang()
        {
            InitializeComponent();
        }
        public void DanhMuc_KhoHang_Load(object sender, EventArgs e)
        {
            LoadGridKhoHang();
            Log_BUS.ThemNhatKy("Kho hàng", "Xem danh sách kho hàng");
        }
        private void LoadGridKhoHang()
        {
            gcKhoHang.DataSource = KhoHangBUS.LayToanBoKhoHang();
        }

        public void btnThemKhoHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc_ThemKhoHang f = new DanhMuc_ThemKhoHang();
            f.eventThemXongKho += LoadGridKhoHang;
            f.ShowDialog();
        }

        public void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] l = GridView1.GetSelectedRows();
            var index = l[0];
            DanhMuc_SuaKhoHang f = new DanhMuc_SuaKhoHang();
            f.KhoHangSua = ((List<KhoHangDTO>)gcKhoHang.DataSource)[index];
            f.eventSuaXongCho += LoadGridKhoHang;
            f.ShowDialog();
        }

        public void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] l = GridView1.GetSelectedRows();
            var index = l[0];
            switch (MessageBox.Show("Bạn có chắc chắn muốn xóa kho này không?", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    KhoHangDTO khXoa = default(KhoHangDTO);
                    khXoa = ((List<KhoHangDTO>)gcKhoHang.DataSource)[index];
                    Log_BUS.ThemNhatKy("Kho hàng", "Xóa kho hàng");
                    KhoHangBUS.XoaKhoHang(khXoa);
                    LoadGridKhoHang();
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