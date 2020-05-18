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
    public partial class HT_PhanQuyen_ThemVaiTro : DevExpress.XtraEditors.XtraForm
    {
        public HT_PhanQuyen_ThemVaiTro()
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

        public void SimpleButton1_Click(object sender, EventArgs e)
        {
            if (txtTenVaiTro.Text == "")
            {
                MessageBox.Show("Tên vai trò không được để trống");
                return;
            }

            VaiTroDTO vt = new VaiTroDTO();
            vt.Ten = Convert.ToString(txtTenVaiTro.Text);
            vt.PhanQuyen = ckPhanQuyen.Checked;
            vt.DoiMatKhau = ckDoiMatKhau.Checked;
            vt.NhatKyHeThong = ckNhatKyHeThong.Checked;
            vt.SaoLuu = ckSaoLuu.Checked;
            vt.PhucHoi = ckPhucHoi.Checked;
            vt.KhuVuc = ckKhuVuc.Checked;
            vt.KhachHang = ckKhachHang.Checked;
            vt.NhaCungCap = ckNhaCungCap.Checked;
            vt.KhoHang = ckKhoHang.Checked;
            vt.DonViTinh = ckDonViTinh.Checked;
            vt.NhomHang = ckNhomHang.Checked;
            vt.TyGia = ckTyGia.Checked;
            vt.HangHoa = ckHangHoa.Checked;
            vt.BoPhan = ckBoPhan.Checked;
            vt.NhanVien = ckNhanVien.Checked;
            vt.MuaHang = ckMuaHang.Checked;
            vt.BanHang = ckBanHang.Checked;
            vt.TonKho = ckTonKho.Checked;
            vt.ChuyenKho = ckChuyenKho.Checked;
            vt.BaoCaoKhoHang = ckBaoCaoKhoHang.Checked;
            vt.BaoCaoBanHang = ckBaoCaoBanHang.Checked;
            vt.ThuTien = ckThuTien.Checked;
            vt.TraTien = ckTraTien.Checked;
            bool test = TaiKhoan_BUS.ThemVaiTro(vt);
            if (test == true)
            {
                MessageBox.Show("Thêm thành công");
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