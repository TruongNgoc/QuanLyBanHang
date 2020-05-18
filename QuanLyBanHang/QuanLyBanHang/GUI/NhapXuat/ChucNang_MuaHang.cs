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
using QuanLyBanHang.GUI.NhaCungCap;
using QuanLyBanHang.GUI.HangHoa;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using QuanLyBanHang.GUI.NhapXuat;

namespace QuanLyBanHang.GUI.NhapXuat
{
    public partial class ChucNang_MuaHang : DevExpress.XtraEditors.XtraForm
    {
        public ChucNang_MuaHang()
        {
            InitializeComponent();
        }

        private void ChucNang_MuaHang_Load(object sender, EventArgs e)
        {
            LoadNhaCungCap();

            //load tgian cho hạn thanh toán
            dtpHanThanhToan.Text = DateTime.Today.ToString("dd/MM/yyy");

            //load tgian cho ngày
            DateEdit1.Text = DateTime.Today.ToString("dd/MM/yyy");

            // load thông tin các nhân viên
            LoadNhanVien();

            //load dockpanel cho form (load các kho hàng và load các sản phẩm trong kho hàng đó)
            LoadKhoHang();

            // load cột đơn vị
            LoadCotDonVi();

        }
        private void LoadCotDonVi()
        {
            DonVi.DataSource = DonViTinhBUS.LayTatCaDonVi();
            DonVi.DisplayMember = "TenDonVi";
            DonVi.ValueMember = "MaDV";
        }

        //private void LoadDonViSanPham()
        //{
        //    DonVi.DataSource = DonViTinhBUS.LayTatCaDonVi();
        //    DonVi.DisplayMember = "TenDonVi";
        //    DonVi.ValueMember = "MaDV";
        //}

        //private void LoadDataHangHoa()
        //{
        //    TenHangHoa.DataSource = HangHoaBUS.LayToanBoHangHoa();
        //    TenHangHoa.DisplayMember = "TenHangHoa";
        //    TenHangHoa.ValueMember = "MaHangHoa";
        //}



        private void LoadNhanVien()
        {
            lkpNhanVien.Properties.DataSource = NhanVienBUS.LayToanBoNhanVien();
            lkpNhanVien.Properties.DisplayMember = "HoTen";
            lkpNhanVien.Properties.ValueMember = "MaNhanVien";

            if (!ReferenceEquals(((List<NhanVienDTO>)lkpNhanVien.Properties.DataSource)[0], null))
            {
                lkpNhanVien.EditValue = ((List<NhanVienDTO>)lkpNhanVien.Properties.DataSource)[0].MaNhanVien;
            }
        }

        private void LoadKhoHang()
        {
            lkpKhoHang.Properties.DataSource = KhoHangBUS.LayToanBoKhoHang();
            lkpKhoHang.Properties.DisplayMember = "TenKho";
            lkpKhoHang.Properties.ValueMember = "MaKho";
            if (!ReferenceEquals(((List<KhoHangDTO>)lkpKhoHang.Properties.DataSource)[0], null))
            {
                lkpKhoHang.EditValue = ((List<KhoHangDTO>)lkpKhoHang.Properties.DataSource)[0].MaKho;
            }
        }

        private void LoadMatHangCoTrongKho()
        {

            //    repositoryItemLookUpEdit1.DataSource = HangHoaBUS.LayToanBoHangHoa();
            //    repositoryItemLookUpEdit1.DisplayMember = "TenHangHoa";
            //    repositoryItemLookUpEdit1.ValueMember = "MaHangHoa";

        }
        private void LoadNhaCungCap()
        {
            lkpTenNCC.Properties.DataSource = NhaCungCapBUS.KiemTraLoad();
            lkpTenNCC.Properties.DisplayMember = "TenNhaPhanPhoi";
            lkpTenNCC.Properties.ValueMember = "MaNhaCungCap";

            // hàm so sánh 2 đối tượng
            //kiểm tra xem nếu dữ liệu đầu tiên trong datasource có rỗng hay không ?
            //nếu không rõng thì hiển thị thông tin đầu tiên của nhà cung cấp đó lên
            if (!ReferenceEquals(((List<NhaCungCapDTO>)lkpTenNCC.Properties.DataSource)[0], null))
            {
                lkpTenNCC.EditValue = ((List<NhaCungCapDTO>)lkpTenNCC.Properties.DataSource)[0].MaNhaCungCap;
            }
        }

        private void lkpTenNCC_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.ButtonEdit Editor = (DevExpress.XtraEditors.ButtonEdit)sender;
            int buttonIndex = System.Convert.ToInt32(Editor.Properties.Buttons.IndexOf(e.Button));
            if (buttonIndex == 1)
            {
                DanhMuc_ThemNhaCungCap f = new DanhMuc_ThemNhaCungCap();
                f.eventThemXong += LoadNhaCungCap;
                f.ShowDialog();
            }
        }

        private void lkpKhoHang_TextChanged(object sender, EventArgs e)
        {
            // load lại các mặt hàng trong kho đó
            int makho = int.Parse(lkpKhoHang.EditValue.ToString());
            GridControl1.DataSource = KhoHangBUS.LayHangHoaTheoKho(makho);
        }


        private void btnChonHangVaoPhieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // load danh sách hàng hóa bên form HangHoa
            ChucNang_ChonHang frm = new ChucNang_ChonHang();
            frm.Show();


        }

        //private void LoadCotTenHangHoa()
        //{
        //    repositoryItemLookUpEdit1.DataSource = HangHoaBUS.LayToanBoLoaiHang();
        //    repositoryItemLookUpEdit1.DisplayMember = "TenLoaiHH";
        //    repositoryItemLookUpEdit1.ValueMember = "MaLoaiHH";
        //}

        //private void GridControl2_Load(object sender, EventArgs e)
        //{
        //    // load hàng hóa cho lookupedit
        //    LoadGridHangHoa();
        //}

        //private void LoadGridHangHoa()
        //{
        //    repositoryItemLookUpEdit1.DataSource = HangHoaBUS.LayToanBoHangHoa();
        //    repositoryItemLookUpEdit1.DisplayMember = "TenHangHoa";
        //    repositoryItemLookUpEdit1.ValueMember = "MaHangHoa";

        //}

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChucNang_ChonHang frm = new ChucNang_ChonHang();
            frm.ShowDialog();


            //ChucNang_ChonHangHoa frm = new ChucNang_ChonHangHoa();
            //frm.ShowDialog();
        }

        //        public delegate HangHoaDTO GetHangHoa(GridControl grd);



        // đúp chuột hiện bảng chọn hàng hóa

        private void GridView2_DoubleClick(object sender, EventArgs e)
        {
            // hiển thị form chọn sản phẩm
            ChucNang_ChonHang frm = new ChucNang_ChonHang();
            frm.ShowDialog();

            //GetHangHoa layhang = new GetHangHoa(frm.);

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }



        bool thaydoi = false;
        bool check = false;
        string so_luong_sp_truoc_do = "";
        bool check_hop_le_so = false;

        public delegate void getdulieu(DataGridView frm, HangHoaDTO sp);

        private void dtgHangHoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            #region
            //if (thaydoi)
            //{
            //    dtgHangHoa_CellValueChanged(sender, e);
            //    thaydoi = false;
            //}

            //else
            //{
            //    //#region
            //    //while (check_hop_le_so == false && thaydoi)
            //    //{
            //    //    dtgHangHoa_CellValueChanged(sender, e);
            //    //}
            //    //#endregion

            //    // lấy vị trí hiện tại của dòng đang click 
            //    int vitrihientai = dtgHangHoa.CurrentCell.RowIndex;

            //    // thực hiện load form để show các hàng hóa để mua thêm vào
            //    ChucNang_MuaHang_ChonHangMua frm = new ChucNang_MuaHang_ChonHangMua();
            //    frm.ShowDialog();
            //    getdulieu laydata = new getdulieu(frm.LayData);
            //    HangHoaDTO sp = new HangHoaDTO();
            //    laydata(dtgHangHoa, sp);
            //    // vitridachon = dtgHangHoa.RowCount;

            //    dtgHangHoa.Rows.Add(sp.MaHangHoa, sp.TenHangHoa, sp.DonVi, null, sp.GiaMua);

            //    dtgHangHoa.CurrentCell = dtgHangHoa.Rows[vitrihientai].Cells[3];
            //    thaydoi = true;
            //}
            #endregion

            thaydoi = true;

            // thực hiện kiểm tra dữ liệu của ô trước đó, nếu như chưa có dữ liệu thì xuất thông báo và cho người dùng nhập
            int sl_dong = dtgHangHoa.SelectedRows.Count;

            check= Ktra_Nhap_So_Luong_Cua_Dong_Truoc_Do();
            if (!check && sl_dong> 1)
            {
                while (check== false)
                {
                    check = Ktra_Nhap_So_Luong_Cua_Dong_Truoc_Do();
                }
                return;
            }

            // lấy vị trí hiện tại của dòng đang click 
            int vitrihientai = dtgHangHoa.CurrentCell.RowIndex;

            // thực hiện load form để show các hàng hóa để mua thêm vào
            ChucNang_MuaHang_ChonHangMua frm = new ChucNang_MuaHang_ChonHangMua();
            frm.ShowDialog();
            getdulieu laydata = new getdulieu(frm.LayData);
            HangHoaDTO sp = new HangHoaDTO();
            laydata(dtgHangHoa, sp);
            // vitridachon = dtgHangHoa.RowCount;

            dtgHangHoa.Rows.Add(sp.MaHangHoa, sp.TenHangHoa, sp.DonVi, null, sp.GiaMua);

            dtgHangHoa.CurrentCell = dtgHangHoa.Rows[vitrihientai].Cells[3];
            // thaydoi = true;
        }

        public bool Ktra_Nhap_So_Luong_Cua_Dong_Truoc_Do()
        {
            int sl_dong = dtgHangHoa.Rows.Count;
            bool check = false;

            if (sl_dong == 1 && thaydoi== false)
            {
                return false;
            }

            if (thaydoi && sl_dong > 1)
            {
                foreach (DataGridViewRow item in dtgHangHoa.Rows)
                {
                    int sl = 0;
                    int vitri = item.Index;

                    if (vitri == sl_dong)
                    {
                        break;
                    }

                    while (check_hop_le_so == false)
                    {
                        if (item.Cells["SoLuong"].Value == null)
                        {
                            MessageBox.Show("Bạn chưa nhập số lượng hàng hóa cần mua");
                            dtgHangHoa.CurrentCell = dtgHangHoa.Rows[vitri].Cells[3];
                            break;
                        }

                        else if (!int.TryParse(item.Cells["SoLuong"].Value.ToString(), out sl))
                        {
                            MessageBox.Show("Số lượng nhập vào không hợp lệ !");
                            dtgHangHoa.CurrentCell = dtgHangHoa.Rows[vitri].Cells[3];
                            break;
                        }
                        else
                        {
                            // thay đổi số lượng thành công
                            check_hop_le_so = true;
                            check = true;
                            return check;
                        }
                    }
                }
            }
            return check;

        }


        private void dtgHangHoa_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            #region
            //if (thaydoi)
            //{

            //    int sl_dong = dtgHangHoa.Rows.Count;
            //    if (sl_dong > 1)
            //    {
            //        foreach (DataGridViewRow item in dtgHangHoa.Rows)
            //        {
            //            while (check_hop_le_so == false)
            //            {
            //                int vitri = dtgHangHoa.CurrentCell.RowIndex;
            //                if (vitri == sl_dong)
            //                {
            //                    break;
            //                }

            //                int sl = 0;
            //                // nếu chưa nhập số lượng của hàng hóa cần mua
            //                if (item.Cells["SoLuong"].Value == null)
            //                {
            //                    MessageBox.Show("Bạn chưa nhập số lượng hàng hóa cần mua");
            //                    dtgHangHoa.CurrentCell = dtgHangHoa.Rows[vitri - 1].Cells[3];
            //                    return;
            //                }

            //                else
            //                {
            //                    if (!int.TryParse(item.Cells["SoLuong"].Value.ToString(), out sl))
            //                    {
            //                        MessageBox.Show("Số lượng nhập vào không hợp lệ !");
            //                        dtgHangHoa.CurrentCell = dtgHangHoa.Rows[vitri].Cells[3];
            //                    }
            //                    else
            //                    {
            //                        // thay đổi số lượng thành công
            //                        check_hop_le_so = true;
            //                        return;
            //                    }
            //                }
            //            }

            //        }
            //     }
            //   }
            #endregion

            //MessageBox.Show("Mới tạo chưa có thay đổi gì");

            int sl = 0;
            double tien = 0;
            double dongia = 0;
            double chietkhau = 0;
            double tienchietkhau = 0;
            double tongtien = 0;

            if (thaydoi)
            {
                //tongtien = double.Parse(txtTongTien.Text.ToString());

                // tiền hành xử lý kiểm tra nhập ô số lượng
                int vitri = dtgHangHoa.CurrentCell.RowIndex;
                dongia = double.Parse(dtgHangHoa.Rows[vitri].Cells["DonGia"].Value.ToString());
                if (!int.TryParse(dtgHangHoa.Rows[vitri].Cells["SoLuong"].Value.ToString(), out sl))
                {
                    MessageBox.Show("Số lượng nhập vào không hợp lệ !");
                    dtgHangHoa.CurrentCell = dtgHangHoa.Rows[vitri].Cells["SoLuong"];
                }

                tien = sl * dongia;
                dtgHangHoa.Rows[vitri].Cells["ThanhTien"].Value = tien;

                // tính tiền của tổng tất cả trong datagridview
                int sodong = dtgHangHoa.RowCount;
                foreach (DataGridViewRow item in dtgHangHoa.Rows)
                {
                    int vitridong = item.Index;

                    // kiểm tra xem có bị trùng với 2 dòng mới chưa có dữ liệu được tạo ra sau sự kiện double click không
                    if (vitridong < sodong - 1 )
                    {
                        // loại bỏ việc tính tiền dòng mới trong datagridview sinh ra sau sự kiện valuechanged
                        if (vitridong == sodong-1)
                        {
                            break;
                        }

                        // lấy tiền từng sản phẩm
                        double tien_tung_san_pham = double.Parse(item.Cells["ThanhTien"].Value.ToString());
                        chietkhau = double.Parse(txtChietKhau.Text.ToString());
                        tongtien += tien_tung_san_pham;
                        tienchietkhau = tongtien * chietkhau;
                        txtTienChietKhau.Text = tienchietkhau.ToString();
                        txtTongTien_LyThuyet.Text = tongtien.ToString();
                        txtTongTien.Text = (tongtien - tienchietkhau).ToString();
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }

        private void txtChietKhau_TextChanged(object sender, EventArgs e)
        {
            //double chietkhau = 0;
            //double tienchietkhau = 0;
            //double tongtien = 0;

            //// tính tiền của tổng tất cả trong datagridview
            //int sodong = dtgHangHoa.RowCount;
            //foreach (DataGridViewRow item in dtgHangHoa.Rows)
            //{
            //    int vitridong = item.Index;

            //    // kiểm tra xem có bị trùng với 2 dòng mới chưa có dữ liệu được tạo ra sau sự kiện double click không
            //    if (vitridong < sodong - 1)
            //    {
            //        // loại bỏ việc tính tiền dòng mới trong datagridview sinh ra sau sự kiện valuechanged
            //        if (vitridong == sodong - 1)
            //        {
            //            break;
            //        }

            //        // lấy tiền từng sản phẩm
            //        double tien_tung_san_pham = double.Parse(item.Cells["ThanhTien"].Value.ToString());
            //        chietkhau = double.Parse(txtChietKhau.Text.ToString());
            //        tongtien += tien_tung_san_pham;
            //        tienchietkhau = tongtien * chietkhau;
            //        txtTienChietKhau.Text = tienchietkhau.ToString();
            //        txtTongTien_LyThuyet.Text = tongtien.ToString();
            //        txtTongTien.Text = (tongtien - tienchietkhau).ToString();
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

        }

        private void txtChietKhau_EditValueChanged(object sender, EventArgs e)
        {
            double chietkhau = 0;
            double tienchietkhau = 0;
            double tongtien = 0;

            // tính tiền của tổng tất cả trong datagridview
            int sodong = dtgHangHoa.RowCount;
            foreach (DataGridViewRow item in dtgHangHoa.Rows)
            {
                int vitridong = item.Index;

                // kiểm tra xem có bị trùng với 2 dòng mới chưa có dữ liệu được tạo ra sau sự kiện double click không
                if (vitridong < sodong - 1)
                {
                    // loại bỏ việc tính tiền dòng mới trong datagridview sinh ra sau sự kiện valuechanged
                    if (vitridong == sodong - 1)
                    {
                        break;
                    }

                    // lấy tiền từng sản phẩm
                    double tien_tung_san_pham = double.Parse(item.Cells["ThanhTien"].Value.ToString());
                    chietkhau = double.Parse(txtChietKhau.Text.ToString());
                    tongtien += tien_tung_san_pham;
                    tienchietkhau = tongtien * chietkhau;
                    txtTienChietKhau.Text = tienchietkhau.ToString();
                    txtTongTien_LyThuyet.Text = tongtien.ToString();
                    txtTongTien.Text = (tongtien - tienchietkhau).ToString();
                }
                else
                {
                    break;
                }
            }

        }
    }
}
