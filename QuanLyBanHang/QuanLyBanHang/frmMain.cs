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
using QuanLyBanHang.GUI.BaoCao;
using QuanLyBanHang.GUI.ChucNang;
using DevExpress.XtraBars;
using QuanLyBanHang.GUI.HeThong;
using QuanLyBanHang.GUI.KhuVuc;
using QuanLyBanHang.GUI.KhachHang;
using QuanLyBanHang.GUI.NhaCungCap;
using QuanLyBanHang.GUI.KhoHang;
using QuanLyBanHang.GUI.NhanVien;
using QuanLyBanHang.GUI.BoPhan;
using QuanLyBanHang.GUI.DonViTinh;
using QuanLyBanHang.GUI.TyGia;
using QuanLyBanHang.GUI.HangHoa;
using QuanLyBanHang.GUI.NhomHang;
using System.Diagnostics;
using QuanLyBanHang.GUI.NhapXuat;
using QuanLyBanHang.BUS;
using QuanLyBanHang.DAO;
using System.Data.SqlClient;

namespace QuanLyBanHang
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }



        // thực hiện load form
        private void frmMain_Load(object sender, EventArgs e)
        {
            // load phân quyền cho người dùng, cấm người dùng thực hiện những quyền mà admin không cho phép
            // với mỗi tài khoản người dùng lấy các quyền load tương ứng

            // tạo store lấy mã tài khoản , sau đó dùng store lấy vai trò theo mã tài khoản để tạo load lại form chính
            VaiTroDTO b = new VaiTroDTO();


            // cần xử lý đoạn lấy tên người dùng để cho ra các quyền chính xác (dùng delegate để truyền tên user và nhận tên user) 

            string tentaikhoan = this.txtuser.Text;
            b = TaiKhoan_DAO.LayVaiTroTheoTaiKhoan(tentaikhoan);

            //ứng với mỗi vai trò load các chức năng tương ứng
            if (!b.BanHang)
            {
                BarBanHang.Enabled = false;
            }
            if (!b.BaoCaoBanHang)
            {
                BarBaoCaoBanHang.Enabled = false;
            }
            if (!b.BaoCaoKhoHang)
            {
                BarBaoCaoKhoHang.Enabled = false;
            }
            if (!b.BoPhan)
            {
                BarBoPhan.Enabled = false;
            }
            if (!b.ChuyenKho)
            {
                BarChuyenKho.Enabled = false;
            }
            if (!b.DoiMatKhau)
            {
                BarMatKhau.Enabled = false;
            }
            if (!b.DonViTinh)
            {
                BarDonViTinh.Enabled = false;
            }
            if (!b.HangHoa)
            {
                BarHangHoa.Enabled = false;
            }
            if (!b.KhachHang)
            {
                BarKhachHang.Enabled = false;
            }
            if (!b.KhoHang)
            {
                BarKhoHang.Enabled = false;
            }
            if (!b.KhuVuc)
            {
                BarKhuVuc.Enabled = false;
            }
            if (!b.MuaHang)
            {
                BarMuaHang.Enabled = false;
            }
            if (!b.NhaCungCap)
            {
                BarNhaCungCap.Enabled = false;
            }
            if (!b.NhanVien)
            {
                BarNhanVien.Enabled = false;
            }
            if (!b.PhanQuyen)
            {
                BarPhanQuyen.Enabled = false;
            }
            if (!b.NhatKyHeThong)
            {
                BarNhatKy.Enabled = false;
            }
            if (!b.NhomHang)
            {
                BarNhomHang.Enabled = false;
            }
            if (!b.PhanQuyen)
            {
                BarPhanQuyen.Enabled = false;
            }
            if (!b.PhucHoi)
            {
                BarPhucHoi.Enabled = false;
            }
            if (!b.SaoLuu)
            {
                BarSaoLuu.Enabled = false;
            }
            if (!b.ThuTien)
            {
                BarThuTien.Enabled = false;
            }
            if (!b.TonKho)
            {
                BarTonKho.Enabled = false;
            }
            if (!b.TraTien)
            {
                BarTraTien.Enabled = false;
            }
            if (!b.TyGia)
            {
                BarTyGia.Enabled = false;
            }
        }


        //thực hiện kiểm tra xem form đó đã tồn tại chưa, nếu rồi thì yêu cầu form đó hoạt động
        private bool ExistForm(Form form)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
        public void BarKetThuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        public void BarThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
            HeThong_FormThongTin frm = new HeThong_FormThongTin();
            frm.ShowDialog();
        }

        public void BarMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmdoimatkhau frm = new frmdoimatkhau();
            frm.txtuser.Text = System.Convert.ToString(txtuser.Text);
            frm.Show();
        }

        public void BarNhatKy_ItemClick(object sender, ItemClickEventArgs e)
        {
            HeThong_NhatKy frm = new HeThong_NhatKy();
            if (ExistForm(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        public void BarPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            HeThong_PhanQuyen frm = new HeThong_PhanQuyen();
            if (ExistForm(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        public void BarSaoLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            HeThong_SaoLuu frm = new HeThong_SaoLuu();
            frm.ShowDialog();
        }

        public void BarPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            HeThong_PhucHoi frm = new HeThong_PhucHoi();
            frm.ShowDialog();
        }

        public void BarKhuVuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            DanhMuc_FormKhuVuc frm = new DanhMuc_FormKhuVuc();
            if (ExistForm(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void BarKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            DanhMuc_FormKhachHang frm = new DanhMuc_FormKhachHang();
            if (ExistForm(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        public void BarNhaCungCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            DanhMuc_NhaCungCap frm = new DanhMuc_NhaCungCap();
            if (ExistForm(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        public void BarKhoHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            DanhMuc_KhoHang frm = new DanhMuc_KhoHang();
            if (ExistForm(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        public void BarNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            DanhMuc_NhanVien frm = new DanhMuc_NhanVien();
            if (ExistForm(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        public void BarBoPhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            DanhMuc_BoPhan frm = new DanhMuc_BoPhan();
            if (ExistForm(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        public void BarDonViTinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            DanhMuc_DonViTinh frm = new DanhMuc_DonViTinh();
            if (ExistForm(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        public void BarTyGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            DanhMuc_TyGia frm = new DanhMuc_TyGia();
            if (ExistForm(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        public void BarHangHoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            DanhMuc_HangHoa frm = new DanhMuc_HangHoa();
            if (ExistForm(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        public void BarNhomHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            DanhMuc_NhomHang frm = new DanhMuc_NhomHang();
            if (ExistForm(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        public void BarTonKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChucNang_TonKho frm = new ChucNang_TonKho();
            if (ExistForm(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        public void BarChuyenKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChucNang_ChuyenKho frm = new ChucNang_ChuyenKho();
            if (ExistForm(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        public void BarHuongDan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("http://perfect.com.vn/phan-mem-quan-ly-ban-hang-truc-tuyen.html");
        }

        public void BarHoTro_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("https://www.facebook.com/profile.php?id=100009532224294");
        }

        public void BarMuaHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChucNang_MuaHang frm = new ChucNang_MuaHang();



            //ChucNang_MuaHang_ frm = new ChucNang_MuaHang_();



            if (ExistForm(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        public void BarBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChucNang_BanHang frm = new ChucNang_BanHang();
            if (ExistForm(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        public void BarBaoCaoKhoHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChucNang_BaoCaoKhoHang frm = new ChucNang_BaoCaoKhoHang();
            if (ExistForm(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        public void BarBaoCaoBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChucNang_BaoCaoBanHang frm = new ChucNang_BaoCaoBanHang();
            if (ExistForm(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        public void BarThuTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChucNang_ThuTien frm = new ChucNang_ThuTien();
            if (ExistForm(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        public void BarTraTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChucNang_TraTien frm = new ChucNang_TraTien();
            if (ExistForm(frm))
            {
                return;
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}