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

namespace QuanLyBanHang.GUI.PhanQuyen
{
    public partial class HT_PhanQuyen_SuaVaiTro : DevExpress.XtraEditors.XtraForm
    {
        public HT_PhanQuyen_SuaVaiTro()
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

        private VaiTroDTO _VaiTroSua;
        public VaiTroDTO VaiTroSua
        {
            get
            {
                return _VaiTroSua;
            }
            set
            {
                _VaiTroSua = value;
            }
        }

        public void ckTatCaHeThong_CheckedChanged(object sender, EventArgs e)
        {

            foreach (Control ctr in groupHeThong.Controls)
            {
                ((CheckBox)ctr).Checked = ckTatCaHeThong.Checked;
            }
        }

        public void ckTatCaDanhMuc_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control ctr in groupDanhMuc.Controls)
            {
                ((CheckBox)ctr).Checked = ckTatCaDanhMuc.Checked;
            }
        }

        public void ckTatCaChucNang_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control ctr in groupChucNang.Controls)
            {
                ((CheckBox)ctr).Checked = ckTatCaChucNang.Checked;
            }
        }

        private void HT_PhanQuyen_SuaVaiTro_Load(object sender, EventArgs e)
        {
            LoadTheoVaiTro();
        }
        private void LoadTheoVaiTro()
        {
            txtTenVaiTro.Text = VaiTroSua.Ten;
            ckPhanQuyen.Checked = VaiTroSua.PhanQuyen;
            ckDoiMatKhau.Checked = VaiTroSua.DoiMatKhau;
            ckNhatKyHeThong.Checked = VaiTroSua.NhatKyHeThong;
            ckSaoLuu.Checked = VaiTroSua.SaoLuu;
            ckPhucHoi.Checked = VaiTroSua.PhucHoi;
            ckKhuVuc.Checked = VaiTroSua.KhuVuc;
            ckKhachHang.Checked = VaiTroSua.KhachHang;
            ckNhaCungCap.Checked = VaiTroSua.NhaCungCap;
            ckKhoHang.Checked = VaiTroSua.KhoHang;
            ckDonViTinh.Checked = VaiTroSua.DonViTinh;
            ckNhomHang.Checked = VaiTroSua.NhomHang;
            ckHangHoa.Checked = VaiTroSua.HangHoa;
            ckTyGia.Checked = VaiTroSua.TyGia;
            ckBoPhan.Checked = VaiTroSua.BoPhan;
            ckNhanVien.Checked = VaiTroSua.NhanVien;
            ckMuaHang.Checked = VaiTroSua.MuaHang;
            ckBanHang.Checked = VaiTroSua.BanHang;
            ckTonKho.Checked = VaiTroSua.TonKho;
            ckChuyenKho.Checked = VaiTroSua.ChuyenKho;
            ckThuTien.Checked = VaiTroSua.ThuTien;
            ckTraTien.Checked = VaiTroSua.TraTien;
            ckBaoCaoBanHang.Checked = VaiTroSua.BaoCaoBanHang;
            ckBaoCaoKhoHang.Checked = VaiTroSua.BaoCaoKhoHang;
        }

        public void SimpleButton1_Click(object sender, EventArgs e)
        {
            if (txtTenVaiTro.Text == "")
            {
                MessageBox.Show("Tên vai trò không được để trống");
                return;
            }
            VaiTroSua.Ten = Convert.ToString(txtTenVaiTro.Text);
            VaiTroSua.PhanQuyen = ckPhanQuyen.Checked;
            VaiTroSua.DoiMatKhau = ckDoiMatKhau.Checked;
            VaiTroSua.NhatKyHeThong = ckNhatKyHeThong.Checked;
            VaiTroSua.SaoLuu = ckSaoLuu.Checked;
            VaiTroSua.PhucHoi = ckPhucHoi.Checked;
            VaiTroSua.KhuVuc = ckKhuVuc.Checked;
            VaiTroSua.KhachHang = ckKhachHang.Checked;
            VaiTroSua.NhaCungCap = ckNhaCungCap.Checked;
            VaiTroSua.KhoHang = ckKhoHang.Checked;
            VaiTroSua.DonViTinh = ckDonViTinh.Checked;
            VaiTroSua.NhomHang = ckNhomHang.Checked;
            VaiTroSua.TyGia = ckTyGia.Checked;
            VaiTroSua.HangHoa = ckHangHoa.Checked;
            VaiTroSua.BoPhan = ckBoPhan.Checked;
            VaiTroSua.NhanVien = ckNhanVien.Checked;
            VaiTroSua.MuaHang = ckMuaHang.Checked;
            VaiTroSua.BanHang = ckBanHang.Checked;
            VaiTroSua.TonKho = ckTonKho.Checked;
            VaiTroSua.ChuyenKho = ckChuyenKho.Checked;
            VaiTroSua.BaoCaoKhoHang = ckBaoCaoKhoHang.Checked;
            VaiTroSua.BaoCaoBanHang = ckBaoCaoBanHang.Checked;
            VaiTroSua.ThuTien = ckThuTien.Checked;
            VaiTroSua.TraTien = ckTraTien.Checked;
            bool test = TaiKhoan_BUS.SuaVaiTro(VaiTroSua);
            if (test == true)
            {
                MessageBox.Show("Sửa thành công");
                if (eventThemXongEvent != null)
                    eventThemXongEvent();
                return;
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi ghi xuống dữ liệu");
                return;
            }
        }

        public void SimpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}