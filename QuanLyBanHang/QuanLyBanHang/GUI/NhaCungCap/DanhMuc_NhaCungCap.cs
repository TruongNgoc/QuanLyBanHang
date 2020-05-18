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

namespace QuanLyBanHang.GUI.NhaCungCap
{
    public partial class DanhMuc_NhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_NhaCungCap()
        {
            InitializeComponent();
        }
        public void DanhMuc_NhaCungCap_Load(object sender, EventArgs e)
        {
            LoadCotKhuVuc();
            LoadDanhSachNCC();
            Log_BUS.ThemNhatKy("Nhà cung cấp", "Xem danh sách nhà cung cấp");
        }

        public void LoadDanhSachNCC()
        {
            GridControl1.DataSource = NhaCungCapBUS.KiemTraLoad();
        }
        public void LoadCotKhuVuc()
        {
            RepositoryItemCheckedComboBoxEdit1.DataSource = KhuVucBUS.LayToanBoKhuVuc();
            RepositoryItemCheckedComboBoxEdit1.DisplayMember = "TenKhuVuc";
            RepositoryItemCheckedComboBoxEdit1.ValueMember = "MaKhuVuc";
        }

        public void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc_ThemNhaCungCap f = new DanhMuc_ThemNhaCungCap();
            f.eventThemXong += LoadDanhSachNCC;
            f.Show();
        }

        public void BarButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] i = GridView1.GetSelectedRows();
            NhaCungCapDTO ncc = ((List<NhaCungCapDTO>)GridControl1.DataSource)[i[0]];
            DanhMuc_SuaNhaCungCap f = new DanhMuc_SuaNhaCungCap();
            f.txtMa.Text = ncc.MaNhaCungCap.ToString();
            f.lkpKhuVuc.EditValue = ncc.KhuVuc;
            f.txtTen.Text = ncc.TenNhaPhanPhoi.ToString();
            f.txtDiaChi.Text = ncc.DiaChi.ToString();
            f.txtMaSoThue.Text = ncc.MaSoThue.ToString();
            f.txtDienThoai.Text = ncc.SoDienThoaiBan.ToString();
            f.txtEmail.Text = ncc.Email.ToString();
            f.txtSoTaiKhoan.Text = ncc.SoTaiKhoan.ToString();
            f.ceGioiHanNo.Value = Convert.ToDecimal(ncc.GioiHanNo);
            f.ceChietKhau.Value = (decimal)ncc.ChietKhau;
            f.txtFax.Text = ncc.Fax.ToString();
            f.txtMobile.Text = ncc.SoDiDong.ToString();
            f.txtWebsite.Text = ncc.Website.ToString();
            f.txtNganHang.Text = ncc.NganHang.ToString();
            f.txtNoHienTai.Text = ncc.NoHienTai.ToString();
            f.txtNguoiLienHe.Text = ncc.NguoiLienHe.ToString();
            f.txtChucVu.Text = ncc.ChucVu.ToString();
            if (f.chxConQuanLy.Checked == true)
            {
                ncc.ConQuanLy = true;
            }
            else
            {
                ncc.ConQuanLy = false;
            }
            f.eventSuaXong += LoadDanhSachNCC;
            f.ShowDialog();
        }

        public void BarButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] i = GridView1.GetSelectedRows();
            var index = Convert.ToInt32(GridView1.GetRowCellValue(i[0], "MaNhaCungCap"));
            bool check = NhaCungCapBUS.KiemTraXoa(index);
            LoadDanhSachNCC();
            if (check)
            {
                MessageBox.Show("Xóa thành công!");
                Log_BUS.ThemNhatKy("Nhà cung cấp", "Xóa nhà cung cấp");
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        public void BarButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}