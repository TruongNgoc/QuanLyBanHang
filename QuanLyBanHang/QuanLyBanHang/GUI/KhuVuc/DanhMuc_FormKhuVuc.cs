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

namespace QuanLyBanHang.GUI.KhuVuc
{
    public partial class DanhMuc_FormKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_FormKhuVuc()
        {
            InitializeComponent();
        }
        public void LoadTatCaKhuVuc()
        {
            GridControl1.DataSource = KhuVucBUS.KiemTraLoad();
        }
        public void DanhMuc_FormKhuVuc_Load(object sender, EventArgs e)
        {
            LoadTatCaKhuVuc();
            Log_BUS.ThemNhatKy("Khu vực", "Xem danh sách khu vực");
        }

        public void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc_ThemKhuVuc f = new DanhMuc_ThemKhuVuc();
            f.eventThemXong += LoadTatCaKhuVuc;
            f.ShowDialog();
        }

        public void BarButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc_SuaKhuVuc f = new DanhMuc_SuaKhuVuc();
            int[] i = GridView1.GetSelectedRows();
            KhuVucDTO kv = ((List<KhuVucDTO>)GridControl1.DataSource)[i[0]];
            f.txtMaKhuVuc.Text = kv.MaKhuVuc.ToString();
            f.txtTen.Text = kv.TenKhuVuc.ToString();
            f.txtGhiChu.Text = kv.GhiChu.ToString();
            if (kv.ConQuanLy)
            {
                f.chxConQuanLy.Checked = true;
            }
            else
            {
                f.chxConQuanLy.Checked = false;
            }
            f.eventSuaXong += LoadTatCaKhuVuc;
            f.ShowDialog();
        }

        public void BarButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] i = GridView1.GetSelectedRows();
            int makv = System.Convert.ToInt32(GridView1.GetRowCellValue(i[0], "MaKhuVuc"));
            bool check = KhuVucBUS.KiemTraXoa(makv);
            if (check)
            {
                LoadTatCaKhuVuc();
                MessageBox.Show("Xóa thành công!");
                Log_BUS.ThemNhatKy("Khu vực", "Xóa khu vực");
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