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

namespace QuanLyBanHang.GUI.NhomHang
{
    public partial class DanhMuc_NhomHang : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_NhomHang()
        {
            InitializeComponent();
        }
        public void LoadTatCaNhomHang()
        {
            GridControl1.DataSource = null;
            GridControl1.DataSource = NhomHangBUS.LoadNhomHang();
        }

        public void DanhMuc_NhomHang_Load(object sender, EventArgs e)
        {
            LoadTatCaNhomHang();
            Log_BUS.ThemNhatKy("Nhóm hàng", "Xem danh sách nhóm hàng");
        }

        public void btnTenNhomHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc_ThemNhomHang f = new DanhMuc_ThemNhomHang();
            f.eventThemXong += LoadTatCaNhomHang;
            f.ShowDialog();
        }

        public void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] i = GridView1.GetSelectedRows();
            NhomHangDTO nh = new NhomHangDTO();
            nh = ((List<NhomHangDTO>)GridControl1.DataSource)[i[0]];
            DanhMuc_SuaNhomHang f = new DanhMuc_SuaNhomHang();
            f.txtMa.Text = nh.MaNhomHang.ToString();
            f.txtTen.Text = nh.TenNhomHang;
            f.txtGhiChu.Text = nh.GhiChu;
            if (nh.ConQuanLy == true)
            {
                f.chxConQuanLy.Checked = true;
            }
            else
            {
                f.chxConQuanLy.Checked = false;
            }
            f.eventSuaXong += LoadTatCaNhomHang;
            f.ShowDialog();
        }

        public void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (MessageBox.Show("Bạn có chắc chắn muốn xóa nhóm hàng này không?", "Hỏi Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    int[] i = GridView1.GetSelectedRows();
                    int index = System.Convert.ToInt32(GridView1.GetRowCellValue(i[0], "MaNhomHang"));
                    bool check = NhomHangBUS.KiemTraXoa(index);
                    if (check)
                    {
                        LoadTatCaNhomHang();
                        MessageBox.Show("Xóa thành công!");
                        Log_BUS.ThemNhatKy("Nhóm hàng", "Xóa nhóm hàng");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
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