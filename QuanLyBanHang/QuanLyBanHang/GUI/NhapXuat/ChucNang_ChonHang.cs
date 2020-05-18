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
using QuanLyBanHang.GUI.HangHoa;
using System.Collections;
using QuanLyBanHang.DAO;

namespace QuanLyBanHang.GUI.NhapXuat
{
    public partial class ChucNang_ChonHang : DevExpress.XtraEditors.XtraForm
    {
        public ChucNang_ChonHang()
        {
            InitializeComponent();
        }

        private void ChucNang_ChonHang_Load(object sender, EventArgs e)
        {
            LoadGridHangHoa();
        }
        private void LoadGridHangHoa()
        {
            gridHangHoa.DataSource = HangHoaBUS.LayToanBoHangHoa();
            repositoryItemLookUpEdit1.DataSource = HangHoaBUS.LayToanBoHangHoa();
            repositoryItemLookUpEdit1.DisplayMember = "TenHangHoa";
            repositoryItemLookUpEdit1.ValueMember = "MaHangHoa";
        }

        public void LayData(DataGridView r1, HangHoaDTO sp)
        {

            //sp.LayDuLieu(CurMa, CurTen, CurGia);
        }

        private void btnThemHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc_ThemHangHoa f = new DanhMuc_ThemHangHoa();
            f.eventThemXong += LoadGridHangHoa;
            f.ShowDialog();
        }

        public void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // thực hiện truyền các hàng hóa đó sang bên from cha và yêu cầu nhập số lượng hàng hóa và các thông tin còn lại
            if (GridView1.SelectedRowsCount > 0)
            {

                List<HangHoaDTO> danhsachSP = new List<HangHoaDTO>();
                // thêm các sp đã chọn vào list

                int soluong = GridView1.SelectedRowsCount;
                for (int i = 0; i < soluong; i++)
                {
                    // kiểm tra xem dòng nào đã chọn dòng nào chưa chọn
                    if (GridView1.GetSelectedRows()[i] > 0)
                    {
                        // truyền hàng hóa vừa chọn vào form cha
                        MessageBox.Show("đã chọn hàng rồi á");


                    }

                    this.Close();
                }
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            // thực hiện truyền thông tin sản phẩm cho bên form cha

        }
    }
}