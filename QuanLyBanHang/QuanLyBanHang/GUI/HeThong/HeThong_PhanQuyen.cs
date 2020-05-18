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
using QuanLyBanHang.GUI.PhanQuyen;
using QuanLyBanHang.GUI.KhachHang;

namespace QuanLyBanHang.GUI.HeThong
{
    public partial class HeThong_PhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        public HeThong_PhanQuyen()
        {
            InitializeComponent();
        }
        public void LoadDuLieu()
        {
            LoadGridVaiTro();
            LoadGridColumnVaiTro();
            LoadGridNguoiDung();
        }

        private void LoadGridVaiTro()
        {
            gridVaiTro.DataSource = TaiKhoan_BUS.LayHetVaiTro();

        }

        private void LoadGridNguoiDung()
        {
            gridNguoiDung.DataSource = TaiKhoan_BUS.LayHetNguoiDung();
        }

        private void LoadGridColumnVaiTro()
        {
            RepositoryItemCheckedComboBoxEdit1.DataSource = TaiKhoan_BUS.LayHetVaiTro();
            RepositoryItemCheckedComboBoxEdit1.ValueMember = "MaVaiTro";
            RepositoryItemCheckedComboBoxEdit1.DisplayMember = "Ten";
        }
        public void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        public void btnThemVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HT_PhanQuyen_ThemVaiTro f = new HT_PhanQuyen_ThemVaiTro();
            f.eventThemXong += LoadDuLieu;
            f.ShowDialog();
        }

        public void btnSuaVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] l = GridView1.GetSelectedRows();
            var index = l[0];
            HT_PhanQuyen_SuaVaiTro f = new HT_PhanQuyen_SuaVaiTro();
            f.VaiTroSua = ((List<VaiTroDTO>)gridVaiTro.DataSource)[index];
            f.eventThemXong += LoadDuLieu;
            f.ShowDialog();
        }

        public void btnXoaVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] l = GridView1.GetSelectedRows();
            var index = l[0];
            switch (MessageBox.Show("Bạn có chắc chắn muốn xóa vai trò này không?", "Hỏi Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    VaiTroDTO vt = default(VaiTroDTO);
                    vt = ((List<VaiTroDTO>)gridVaiTro.DataSource)[index];
                    bool test = TaiKhoan_BUS.XoaVaiTro(vt);

                    if (test == true)
                    {
                        LoadGridVaiTro();
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

        public void HeThong_PhanQuyen_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        public void btnThemND_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HT_PhanQuyen_ThemNguoiDung f = new HT_PhanQuyen_ThemNguoiDung();
            f.eventThemXong += LoadDuLieu;
            f.ShowDialog();
        }

        public void btnSuaND_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] l = GridView2.GetSelectedRows();
            var index = l[0];
            HT_PhanQuyen_SuaNguoiDung f = new HT_PhanQuyen_SuaNguoiDung();
            f.NguoiDungSua = ((List<TaiKhoan_DTO>)gridNguoiDung.DataSource)[index];
            f.eventSuaXong += LoadDuLieu;
            f.ShowDialog();
        }

        public void btnXoaND_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] l = GridView2.GetSelectedRows();
            var index = l[0];
            switch (MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này không?", "Hỏi Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    TaiKhoan_DTO nd = default(TaiKhoan_DTO);
                    nd = ((List<TaiKhoan_DTO>)gridNguoiDung.DataSource)[index];
                    bool test = TaiKhoan_BUS.XoaNguoiDung(nd);
                    if (test == true)
                    {
                        LoadGridNguoiDung();

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

        public void btnDong2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}