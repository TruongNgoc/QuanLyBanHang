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
    public partial class DanhMuc_ThemHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_ThemHangHoa()
        {
            InitializeComponent();
        }

        public delegate void ThemXong();
        private ThemXong eventThemXongEvent;
        public event ThemXong eventThemXong
        {
            add
            {
                eventThemXongEvent = (ThemXong)System.Delegate.Combine(eventThemXongEvent, value);
            }
            remove
            {
                eventThemXongEvent = (ThemXong)System.Delegate.Remove(eventThemXongEvent, value);
            }
        }


        private void DanhMuc_ThemHangHoa_Load(object sender, EventArgs e)
        {
            LoadLoaiHangHoa();
            LoadKhoMacDinh();
            LoadPhanLoai();
            LoadDonVi();
            LoadNhaCungCap();
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
        public void btnLuu_Click(object sender, EventArgs e)
        {
            HangHoaDTO hh = new HangHoaDTO();
            hh.LoaiHangHoa = System.Convert.ToInt32(cmbLoaiHangHoa.SelectedValue);
            hh.KhoMacDinh = System.Convert.ToInt32(lkpKhoMacDinh.EditValue);
            hh.PhanLoai = System.Convert.ToInt32(lkpPhanLoai.EditValue);
            hh.TenHangHoa = System.Convert.ToString(txtTenHang.Text);
            hh.DonVi = System.Convert.ToInt32(lkpDonVi.EditValue);
            hh.XuatXu = System.Convert.ToString(txtXuatXu.Text);
            hh.TonKhoToiThieu = System.Convert.ToInt32(ceTonToiThieu.Value);
            hh.TonKho = System.Convert.ToInt32(ceTonHienTai.Value);
            hh.NhaCungCap = System.Convert.ToInt32(lkpNhaCungCap.EditValue);
            hh.GiaMua = System.Convert.ToDouble(ceGiaMua.Value);
            hh.GiaBan = System.Convert.ToDouble(ceGiaBan.Value);

            if (chkConQuanLy.Checked == true)
            {
                hh.ConQuanLy = true;
            }
            else
            {
                hh.ConQuanLy = false;
            }

            bool test = HangHoaBUS.ThemHangHoa(hh);
            if (test == true)
            {
                Log_BUS.ThemNhatKy("Hàng hóa", "Thêm hàng hóa");
                MessageBox.Show("Thêm hàng hóa thành công");
                if (eventThemXongEvent != null)
                    eventThemXongEvent();
            }
            else
            {
                MessageBox.Show("Thêm hàng hóa không thành công, thông tin thêm không đúng");
            }
        }

        public void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
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