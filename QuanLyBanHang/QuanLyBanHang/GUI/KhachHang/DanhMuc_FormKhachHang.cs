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

namespace QuanLyBanHang.GUI.KhachHang
{
    public partial class DanhMuc_FormKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_FormKhachHang()
        {
            InitializeComponent();
        }
        public void btnThemKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc_ThemKhachHang f = new DanhMuc_ThemKhachHang();
            f.eventThemXongKhachHang += LoadGridControl;
            f.ShowDialog();
        }

        public void DanhMuc_FormKhachHang_Load(object sender, EventArgs e)
        {
            LoadCotKhuVuc();
            LoadGridControl();
        }

        public void LoadGridControl()
        {
            List<KhachHangDTO> lKH = KhachHangBUS.LayDanhSachKhachHang();
            gridKhachHang.DataSource = lKH;
        }

        private void LoadCotKhuVuc()
        {
            RepositoryItemCheckedComboBoxEdit_2.DataSource = KhuVucBUS.KiemTraLoad();
            RepositoryItemCheckedComboBoxEdit_2.ValueMember = "MaKhuVuc";
            RepositoryItemCheckedComboBoxEdit_2.DisplayMember = "TenKhuVuc";
        }

        public void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc_SuaKhachHang f = new DanhMuc_SuaKhachHang();
            int[] l = GridView1.GetSelectedRows();

            var index = l[0];

            KhachHangDTO khSua = default(KhachHangDTO);
            khSua = ((List<KhachHangDTO>)gridKhachHang.DataSource)[index];
            f.eventSuaXongKhachHang += LoadGridControl;
            f.KhachHangSua = khSua;
            f.ShowDialog();
        }

        public void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] l = GridView1.GetSelectedRows();

            var index = l[0];
            switch (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?","Hỏi Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    KhachHangDTO khXoa = default(KhachHangDTO);
                    khXoa = ((List<KhachHangDTO>)gridKhachHang.DataSource)[index];

                    KhachHangBUS.XoaKhachHang(khXoa);
                    Log_BUS.ThemNhatKy("Khách hàng", "Xóa khách hàng");

                    LoadGridControl();
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