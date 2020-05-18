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

namespace QuanLyBanHang.GUI.HeThong
{
    public partial class HeThong_NhatKy : DevExpress.XtraEditors.XtraForm
    {
        public HeThong_NhatKy()
        {
            InitializeComponent();
        }
        public void LoadDuLieu()
        {
            GridControl1.DataSource = Log_BUS.KiemTraLoad();
        }

        public void HeThong_NhatKy_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            string cn = "Nhật ký hệ thống";
            string hd = "Xem nhật ký";
            Log_BUS.ThemNhatKy(cn, hd);
        }

        public void BarButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] i = GridView1.GetSelectedRows();
            if (ReferenceEquals(GridView1.GetRowCellValue(i[0], "ThoiGian"), null))
            {
                return;
            }
            string tg = GridView1.GetRowCellValue(i[0], "ThoiGian").ToString();
            bool check = Log_BUS.XoaNhatKy(tg);
            if (!check)
            {
                MessageBox.Show("Xóa không thành công! Vui lòng thử lại!", "Thông báo");
            }
            else
            {
                LoadDuLieu();
                MessageBox.Show("Xóa nhật ký thành công!", "Thông báo");
            }
        }

        public void BarButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (MessageBox.Show("Bạn có chắc chắn muốn xóa hết nhật ký không?", "Hỏi Xóa" , MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    bool check = Log_BUS.XoaHetNhatKy();
                    if (check)
                    {
                        LoadDuLieu();
                        MessageBox.Show("Xóa thành công!");
                        Log_BUS.ThemNhatKy("Nhật ký hệ thống", "Xóa sạch nhật ký");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                    break;
                case DialogResult.No:
                    return;
            }
        }

        public void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDuLieu();
        }

        public void BarButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}