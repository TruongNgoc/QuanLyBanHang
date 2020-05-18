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
using QuanLyBanHang.GUI.NhaCungCap;
using QuanLyBanHang.GUI.DonViTinh;
using QuanLyBanHang.GUI.NhomHang;
using QuanLyBanHang.GUI.KhoHang;

namespace QuanLyBanHang.GUI.HangHoa
{
    public partial class DanhMuc_SuaHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_SuaHangHoa()
        {
            InitializeComponent();
        }

        public delegate void SuaXong();
        private SuaXong eventSuaXongEvent;
        public event SuaXong eventSuaXong
        {
            add
            {
                eventSuaXongEvent = (SuaXong)System.Delegate.Combine(eventSuaXongEvent, value);
            }
            remove
            {
                eventSuaXongEvent = (SuaXong)System.Delegate.Remove(eventSuaXongEvent, value);
            }
        }


        private HangHoaDTO _HangHoaSua;
        public HangHoaDTO HangHoaSua
        {
            get
            {
                return _HangHoaSua;
            }
            set
            {
                _HangHoaSua = value;
            }
        }

        private void DanhMuc_SuaHangHoa_Load(object sender, EventArgs e)
        {
            LoadLoaiHangHoa();
            LoadKhoMacDinh();
            LoadPhanLoai();
            LoadDonVi();
            LoadNhaCungCap();
            LoadTheoHangHoaSua();
        }

        private void LoadLoaiHangHoa()
        {
            cmbLoaiHangHoa.DataSource = HangHoaBUS.LayToanBoLoaiHang();
            cmbLoaiHangHoa.DisplayMember = "TenLoaiHH";
            cmbLoaiHangHoa.ValueMember = "MaLoaiHH";
        }

        private void LoadKhoMacDinh()
        {

            lkpKhoMacDinh.Properties.DataSource = KhoHangBUS.LayToanBoKhoHang();
            lkpKhoMacDinh.Properties.DisplayMember = "TenKho";
            lkpKhoMacDinh.Properties.ValueMember = "MaKho";
            if (!ReferenceEquals(((List<KhoHangDTO>)lkpKhoMacDinh.Properties.DataSource)[0], null))
            {
                lkpKhoMacDinh.EditValue = ((List<KhoHangDTO>)lkpKhoMacDinh.Properties.DataSource)[0].MaKho;
            }

        }

        private void LoadPhanLoai()
        {
            lkpPhanLoai.Properties.DataSource = NhomHangBUS.LoadNhomHang();
            lkpPhanLoai.Properties.DisplayMember = "TenNhomHang";
            lkpPhanLoai.Properties.ValueMember = "MaNhomHang";
            if (!ReferenceEquals(((List<NhomHangDTO>)lkpPhanLoai.Properties.DataSource)[0], null))
            {
                lkpPhanLoai.EditValue = ((List<NhomHangDTO>)lkpPhanLoai.Properties.DataSource)[0].MaNhomHang;
            }
        }

        private void LoadDonVi()
        {
            lkpDonVi.Properties.DataSource = DonViTinhBUS.LayTatCaDonVi();
            lkpDonVi.Properties.DisplayMember = "TenDonVi";
            lkpDonVi.Properties.ValueMember = "MaDV";
            if (!ReferenceEquals(((List<DonViTinhDTO>)lkpDonVi.Properties.DataSource)[0], null))
            {
                lkpDonVi.EditValue = ((List<DonViTinhDTO>)lkpDonVi.Properties.DataSource)[0].MaDV;
            }
        }

        private void LoadNhaCungCap()
        {
            lkpNhaCungCap.Properties.DataSource = NhaCungCapBUS.KiemTraLoad();
            lkpNhaCungCap.Properties.DisplayMember = "TenNhaPhanPhoi";
            lkpNhaCungCap.Properties.ValueMember = "MaNhaCungCap";
            if (!ReferenceEquals(((List<NhaCungCapDTO>)lkpNhaCungCap.Properties.DataSource)[0], null))
            {
                lkpNhaCungCap.EditValue = ((List<NhaCungCapDTO>)lkpNhaCungCap.Properties.DataSource)[0].MaNhaCungCap;
            }
        }
        public void lkpKhoMacDinh_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.ButtonEdit Editor = (DevExpress.XtraEditors.ButtonEdit)sender;
            int buttonIndex = System.Convert.ToInt32(Editor.Properties.Buttons.IndexOf(e.Button));
            if (buttonIndex == 1)
            {
                DanhMuc_ThemKhoHang f = new DanhMuc_ThemKhoHang();
                f.eventThemXongKho += LoadKhoMacDinh;
                f.ShowDialog();
            }
        }

        public void lkpPhanLoai_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.ButtonEdit Editor = (DevExpress.XtraEditors.ButtonEdit)sender;
            int buttonIndex = System.Convert.ToInt32(Editor.Properties.Buttons.IndexOf(e.Button));
            if (buttonIndex == 1)
            {
                DanhMuc_ThemNhomHang f = new DanhMuc_ThemNhomHang();
                f.eventThemXong += LoadPhanLoai;
                f.ShowDialog();
            }
        }

        public void lkpDonVi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.ButtonEdit Editor = (DevExpress.XtraEditors.ButtonEdit)sender;
            int buttonIndex = System.Convert.ToInt32(Editor.Properties.Buttons.IndexOf(e.Button));
            if (buttonIndex == 1)
            {
                DanhMuc_ThemDonVi f = new DanhMuc_ThemDonVi();
                f.eventThemXong += LoadDonVi;
                f.ShowDialog();
            }
        }
        private void LoadTheoHangHoaSua()
        {
            if (ReferenceEquals(HangHoaSua, null))
            {
                this.Close();
            }
            cmbLoaiHangHoa.SelectedValue = HangHoaSua.LoaiHangHoa;
            lkpKhoMacDinh.EditValue = HangHoaSua.KhoMacDinh;
            lkpPhanLoai.EditValue = HangHoaSua.PhanLoai;
            txtTenHang.Text = HangHoaSua.TenHangHoa;
            lkpDonVi.EditValue = HangHoaSua.DonVi;

            txtXuatXu.Text = HangHoaSua.XuatXu;
            ceTonHienTai.Value = HangHoaSua.TonKho;
            ceTonToiThieu.Value = HangHoaSua.TonKhoToiThieu;

            lkpNhaCungCap.EditValue = HangHoaSua.NhaCungCap;
            ceGiaBan.Value = (decimal)HangHoaSua.GiaBan;
            ceGiaMua.Value = (decimal)HangHoaSua.GiaMua;
        }

        public void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnLuu_Click(object sender, EventArgs e)
        {
            HangHoaSua.LoaiHangHoa = Convert.ToInt32(cmbLoaiHangHoa.SelectedValue);
            HangHoaSua.KhoMacDinh = Convert.ToInt32(lkpKhoMacDinh.EditValue);
            HangHoaSua.PhanLoai = Convert.ToInt32(lkpPhanLoai.EditValue);
            HangHoaSua.TenHangHoa = Convert.ToString(txtTenHang.Text);
            HangHoaSua.DonVi = Convert.ToInt32(lkpDonVi.EditValue);
            HangHoaSua.XuatXu = Convert.ToString(txtXuatXu.Text);
            HangHoaSua.TonKhoToiThieu = Convert.ToInt32(ceTonToiThieu.Value);
            HangHoaSua.TonKho = Convert.ToInt32(ceTonHienTai.Value);
            HangHoaSua.NhaCungCap = Convert.ToInt32(lkpNhaCungCap.EditValue);
            HangHoaSua.GiaMua = Convert.ToDouble(ceGiaMua.Value);
            HangHoaSua.GiaBan = Convert.ToDouble(ceGiaBan.Value);
            if (chkConQuanLy.Checked == true)
            {
                HangHoaSua.ConQuanLy = true;
            }
            else
            {
                HangHoaSua.ConQuanLy = false;
            }

            bool test = HangHoaBUS.SuaHangHoa(HangHoaSua);
            if (test == true)
            {
                MessageBox.Show("Sửa hàng hóa thành công");
                Log_BUS.ThemNhatKy("Hàng hóa", "Sửa hàng hóa");
                if (eventSuaXongEvent != null)
                    eventSuaXongEvent();
            }
            else
            {
                MessageBox.Show("Sửa hàng hóa không thành công, thông tin sửa không đúng");
            }
        }

        public void lkpNhaCungCap_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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
    }
}