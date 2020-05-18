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

namespace QuanLyBanHang.GUI.HangHoa
{
    public partial class DanhMuc_HangHoa : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_HangHoa()
        {
            InitializeComponent();
        }
        public void DanhMuc_HangHoa_Load(object sender, EventArgs e)
        {
            LoadCotDonVi();
            LoadCotLoaiHang();
            LoadCotPhanLoai();
            LoadGridHangHoa();
            Log_BUS.ThemNhatKy("Hàng hóa", "Xem danh sách hàng hóa");
        }

        private void LoadGridHangHoa()
        {
            gridHangHoa.DataSource = HangHoaBUS.LayToanBoHangHoa();
        }

        private void LoadCotDonVi()
        {
            repositoryItemCheckedComboBoxEdit_1.DataSource = DonViTinhBUS.LayTatCaDonVi();
            repositoryItemCheckedComboBoxEdit_1.DisplayMember = "TenDonVi";
            repositoryItemCheckedComboBoxEdit_1.ValueMember = "MaDV";
        }
        private void LoadCotLoaiHang()
        {
            repositoryItemCheckedComboBoxEdit_3.DataSource = HangHoaBUS.LayToanBoLoaiHang();
            repositoryItemCheckedComboBoxEdit_3.DisplayMember = "TenLoaiHH";
            repositoryItemCheckedComboBoxEdit_3.ValueMember = "MaLoaiHH";
        }
        private void LoadCotPhanLoai()
        {
            repositoryItemCheckedComboBoxEdit_2.DataSource = NhomHangBUS.LoadNhomHang();
            repositoryItemCheckedComboBoxEdit_2.DisplayMember = "TenNhomHang";
            repositoryItemCheckedComboBoxEdit_2.ValueMember = "MaNhomHang";
        }

        public void btnThemHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc_ThemHangHoa f = new DanhMuc_ThemHangHoa();
            f.eventThemXong += LoadGridHangHoa;
            f.ShowDialog();
        }

        public void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] l = GridView1.GetSelectedRows();
            var index = l[0];
            DanhMuc_SuaHangHoa f = new DanhMuc_SuaHangHoa();
            f.HangHoaSua = ((List<HangHoaDTO>)gridHangHoa.DataSource)[index];
            f.eventSuaXong += LoadGridHangHoa;
            f.ShowDialog();
        }

        public void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] l = GridView1.GetSelectedRows();

            var index = l[0];
            switch (MessageBox.Show("Bạn có chắc chắn muốn xóa hàng hóa này không?", "Hỏi Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    HangHoaDTO hh = default(HangHoaDTO);
                    hh = ((List<HangHoaDTO>)gridHangHoa.DataSource)[index];
                    bool test = HangHoaBUS.XoaKhoHang(hh);

                    if (test == true)
                    {
                        LoadGridHangHoa();
                        Log_BUS.ThemNhatKy("Hàng hóa", "Xóa hàng hoá");
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

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            // load form sửa hàng hóa để show hết thông tin của sản phẩm đó và cho phép người dùng thay đổi 1 số thuộc tính của hàng hóa đó

            int[] l = GridView1.GetSelectedRows();
            var index = l[0];
            DanhMuc_SuaHangHoa f = new DanhMuc_SuaHangHoa();
            f.HangHoaSua = ((List<HangHoaDTO>)gridHangHoa.DataSource)[index];
            f.eventSuaXong += LoadGridHangHoa;
            f.ShowDialog();
        }
    }
}
