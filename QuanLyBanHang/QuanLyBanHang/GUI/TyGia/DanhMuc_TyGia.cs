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

namespace QuanLyBanHang.GUI.TyGia
{
    public partial class DanhMuc_TyGia : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_TyGia()
        {
            InitializeComponent();
        }
        public void LayTatCaTyGia()
        {
            List<TyGiaDTO> ltg = TyGiaBUS.LoadTatCaTyGia();
            GridControl1.DataSource = ltg;
        }

        public void DanhMuc_TyGia_Load(object sender, EventArgs e)
        {
            LayTatCaTyGia();
        }

        public void btnThemTyGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc_ThemTyGia f = new DanhMuc_ThemTyGia();
            f.eventThemXong += LayTatCaTyGia;
            f.ShowDialog();
        }

        public void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc_SuaTyGia f = new DanhMuc_SuaTyGia();
            int[] i = GridView1.GetSelectedRows();
            TyGiaDTO ncc = ((List<TyGiaDTO>)GridControl1.DataSource)[i[0]];
            f.txtMa.Text = ncc.MaTyGia.ToString();
            f.txtTen.Text = ncc.TenTyGia;
            f.ceTyGiaQuyDoi.Value = (decimal)ncc.TyGiaQuyDoi;
            if (ncc.ConQuanLy == true)
            {
                f.chxConQuanLy.Checked = true;
            }
            else
            {
                f.chxConQuanLy.Checked = false;
            }
            f.eventSuaXong += LayTatCaTyGia;
            f.ShowDialog();
        }

        public void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] i = GridView1.GetSelectedRows();
            int matg = Convert.ToInt32(GridView1.GetRowCellValue(i[0], "MaTyGia"));
            bool check = TyGiaBUS.KiemTraXoa(matg);
            if (check)
            {
                LayTatCaTyGia();
                MessageBox.Show("Xóa thành công!");
                Log_BUS.ThemNhatKy("Tỷ giá", "Xóa tỷ giá");
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        public void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}