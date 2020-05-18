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

namespace QuanLyBanHang.GUI.NhapXuat
{
    public partial class ChucNang_MuaHang_ChonHangMua : DevExpress.XtraEditors.XtraForm
    {
        public ChucNang_MuaHang_ChonHangMua()
        {
            InitializeComponent();
        }

        public HangHoaDTO sp_can_lay = new HangHoaDTO();

        public void LayData(DataGridView r1, HangHoaDTO sp)
        {

            // sp = new HangHoaDTO();
            // sp = sp_can_lay;
            // MessageBox.Show(sp_can_lay.MaHangHoa.ToString());
            sp.MaHangHoa = sp_can_lay.MaHangHoa;
            sp.TenHangHoa = sp_can_lay.TenHangHoa;
            sp.LoaiHangHoa = sp_can_lay.LoaiHangHoa;
            sp.PhanLoai = sp_can_lay.PhanLoai;
            sp.DonVi = sp_can_lay.DonVi;
            sp.TonKhoToiThieu = sp_can_lay.TonKhoToiThieu;
            sp.TonKho = sp_can_lay.TonKho;
            sp.GiaMua = sp_can_lay.GiaMua;
            sp.GiaBan = sp_can_lay.GiaBan;
            sp.ConQuanLy = sp_can_lay.ConQuanLy;
        }

        private void ChucNang_MuaHang_ChonHangMua_Load(object sender, EventArgs e)
        {
            LoadGridHangHoa();
        }

        private void LoadGridHangHoa()
        {
            LoadCotDonVi();
            LoadCotLoaiHang();
            LoadCotPhanLoai();
            gridHangHoa.DataSource = HangHoaBUS.LayToanBoHangHoa();

            //ẩn một số cột không cần đùng
            gridHangHoa.Columns["KhoMacDinh"].Visible = false;
            gridHangHoa.Columns["XuatXu"].Visible = false;
            gridHangHoa.Columns["NhaCungCap"].Visible = false;

        }

        private void LoadCotDonVi()
        {
            DonVi.DataSource = DonViTinhBUS.LayTatCaDonVi();
            DonVi.DisplayMember = "TenDonVi";
            DonVi.ValueMember = "MaDV";
        }
        private void LoadCotLoaiHang()
        {
            PhanLoai.DataSource = HangHoaBUS.LayToanBoLoaiHang();
            PhanLoai.DisplayMember = "TenLoaiHH";
            PhanLoai.ValueMember = "MaLoaiHH";
        }
        private void LoadCotPhanLoai()
        {
            LoaiHangHoa.DataSource = NhomHangBUS.LoadNhomHang();
            LoaiHangHoa.DisplayMember = "TenNhomHang";
            LoaiHangHoa.ValueMember = "MaNhomHang";
        }

        private void btnThemHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc_ThemHangHoa f = new DanhMuc_ThemHangHoa();
            f.eventThemXong += LoadGridHangHoa;
            f.ShowDialog();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //int[] l = gridHangHoa.SelectedRows;
            //var index = l[0];
            //DanhMuc_SuaHangHoa f = new DanhMuc_SuaHangHoa();
            //f.HangHoaSua = ((List<HangHoaDTO>)gridHangHoa.DataSource)[index];
            //f.eventSuaXong += LoadGridHangHoa;
            //f.ShowDialog();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gridHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = gridHangHoa.CurrentCell.RowIndex;

            sp_can_lay.MaHangHoa = int.Parse(gridHangHoa.Rows[vt].Cells["MaHangHoa"].Value.ToString());
            sp_can_lay.TenHangHoa = gridHangHoa.Rows[vt].Cells["TenHangHoa"].Value.ToString();
            sp_can_lay.LoaiHangHoa = int.Parse(gridHangHoa.Rows[vt].Cells["LoaiHangHoa"].Value.ToString());
//            sp_can_lay.KhoMacDinh = int.Parse(gridHangHoa.Rows[vt].Cells["KhoMacDinh"].Value.ToString());
            sp_can_lay.PhanLoai = int.Parse(gridHangHoa.Rows[vt].Cells["PhanLoai"].Value.ToString());
            sp_can_lay.DonVi = int.Parse(gridHangHoa.Rows[vt].Cells["DonVi"].Value.ToString());
//            sp_can_lay.XuatXu = gridHangHoa.Rows[vt].Cells["XuatXu"].Value.ToString();
            sp_can_lay.TonKhoToiThieu = int.Parse(gridHangHoa.Rows[vt].Cells["TonKhoToiThieu"].Value.ToString());
            sp_can_lay.TonKho = int.Parse(gridHangHoa.Rows[vt].Cells["TonKho"].Value.ToString());
//            sp_can_lay.NhaCungCap = int.Parse(gridHangHoa.Rows[vt].Cells["NhaCungCap"].Value.ToString());
            sp_can_lay.GiaMua = double.Parse(gridHangHoa.Rows[vt].Cells["GiaMua"].Value.ToString());
            sp_can_lay.GiaBan = double.Parse(gridHangHoa.Rows[vt].Cells["GiaBan"].Value.ToString());
            sp_can_lay.ConQuanLy = bool.Parse(gridHangHoa.Rows[vt].Cells["ConQuanLy"].Value.ToString());
            Close();
        }
    }
}
