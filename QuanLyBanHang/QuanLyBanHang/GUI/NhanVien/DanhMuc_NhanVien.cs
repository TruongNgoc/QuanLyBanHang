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

namespace QuanLyBanHang.GUI.NhanVien
{
    public partial class DanhMuc_NhanVien : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_NhanVien()
        {
            InitializeComponent();
        }
        public void DanhMuc_NhanVien_Load(object sender, EventArgs e)
        {
            LoadGridNhanVien();
            Log_BUS.ThemNhatKy("Nhân viên", "Xem danh sách nhân viên");
        }
        public void LoadGridNhanVien()
        {
            gridNhanVien.DataSource = NhanVienBUS.LayToanBoNhanVien();
        }
        public void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc_ThemNhanVien f = new DanhMuc_ThemNhanVien();
            f.eventThemXong += LoadGridNhanVien;
            f.ShowDialog();
        }

        public void BarButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] l = GridView1.GetSelectedRows();
            var index = l[0];
            DanhMuc_SuaNhanVien f = new DanhMuc_SuaNhanVien();
            f.NVSua = ((List<NhanVienDTO>)gridNhanVien.DataSource)[index];
            f.eventSuaXong += LoadGridNhanVien;
            f.ShowDialog();
        }
        public void BarButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] l = GridView1.GetSelectedRows();
            var index = l[0];
            switch (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Hỏi Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    NhanVienDTO nv = default(NhanVienDTO);
                    nv = ((List<NhanVienDTO>)gridNhanVien.DataSource)[index];
                    bool test = BoPhanBUS.XoaNhanVien(nv);
                    if (test == true)
                    {
                        LoadGridNhanVien();
                        Log_BUS.ThemNhatKy("Nhân viên", "Xóa nhân viên");
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

        public void BarButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}