using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

// This file was created by the VB to C# converter (SharpDevelop 4.4.2.9749).
// It contains classes for supporting the VB "My" namespace in C#.
// If the VB application does not use the "My" namespace, or if you removed the usage
// after the conversion to C#, you can delete this file.

namespace GUI.My
{
	sealed partial class MyProject
	{
		[ThreadStatic] static MyApplication application;
		
		public static MyApplication Application {
			[DebuggerStepThrough]
			get {
				if (application == null)
					application = new MyApplication();
				return application;
			}
		}
		
		[ThreadStatic] static MyComputer computer;
		
		public static MyComputer Computer {
			[DebuggerStepThrough]
			get {
				if (computer == null)
					computer = new MyComputer();
				return computer;
			}
		}
		
		[ThreadStatic] static User user;
		
		public static User User {
			[DebuggerStepThrough]
			get {
				if (user == null)
					user = new User();
				return user;
			}
		}
		
		[ThreadStatic] static MyForms forms;
		
		public static MyForms Forms {
			[DebuggerStepThrough]
			get {
				if (forms == null)
					forms = new MyForms();
				return forms;
			}
		}
		
		internal sealed class MyForms
		{
			global::GUI.ChucNang_TraTien ChucNang_TraTien_instance;
			bool ChucNang_TraTien_isCreating;
			public global::GUI.ChucNang_TraTien ChucNang_TraTien {
				[DebuggerStepThrough] get { return GetForm(ref ChucNang_TraTien_instance, ref ChucNang_TraTien_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref ChucNang_TraTien_instance, value); }
			}
			
			global::GUI.HeThong_DangNhap HeThong_DangNhap_instance;
			bool HeThong_DangNhap_isCreating;
			public global::GUI.HeThong_DangNhap HeThong_DangNhap {
				[DebuggerStepThrough] get { return GetForm(ref HeThong_DangNhap_instance, ref HeThong_DangNhap_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref HeThong_DangNhap_instance, value); }
			}
			
			global::GUI.DanhMuc_SuaTyGia DanhMuc_SuaTyGia_instance;
			bool DanhMuc_SuaTyGia_isCreating;
			public global::GUI.DanhMuc_SuaTyGia DanhMuc_SuaTyGia {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_SuaTyGia_instance, ref DanhMuc_SuaTyGia_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_SuaTyGia_instance, value); }
			}
			
			global::GUI.ChucNang_BaoCaoBanHang ChucNang_BaoCaoBanHang_instance;
			bool ChucNang_BaoCaoBanHang_isCreating;
			public global::GUI.ChucNang_BaoCaoBanHang ChucNang_BaoCaoBanHang {
				[DebuggerStepThrough] get { return GetForm(ref ChucNang_BaoCaoBanHang_instance, ref ChucNang_BaoCaoBanHang_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref ChucNang_BaoCaoBanHang_instance, value); }
			}
			
			global::GUI.DanhMuc_ThemTyGia DanhMuc_ThemTyGia_instance;
			bool DanhMuc_ThemTyGia_isCreating;
			public global::GUI.DanhMuc_ThemTyGia DanhMuc_ThemTyGia {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_ThemTyGia_instance, ref DanhMuc_ThemTyGia_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_ThemTyGia_instance, value); }
			}
			
			global::GUI.DanhMuc_KhoHang DanhMuc_KhoHang_instance;
			bool DanhMuc_KhoHang_isCreating;
			public global::GUI.DanhMuc_KhoHang DanhMuc_KhoHang {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_KhoHang_instance, ref DanhMuc_KhoHang_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_KhoHang_instance, value); }
			}
			
			global::GUI.ChucNang_BanHang ChucNang_BanHang_instance;
			bool ChucNang_BanHang_isCreating;
			public global::GUI.ChucNang_BanHang ChucNang_BanHang {
				[DebuggerStepThrough] get { return GetForm(ref ChucNang_BanHang_instance, ref ChucNang_BanHang_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref ChucNang_BanHang_instance, value); }
			}
			
			global::GUI.DanhMuc_FormKhuVuc DanhMuc_FormKhuVuc_instance;
			bool DanhMuc_FormKhuVuc_isCreating;
			public global::GUI.DanhMuc_FormKhuVuc DanhMuc_FormKhuVuc {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_FormKhuVuc_instance, ref DanhMuc_FormKhuVuc_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_FormKhuVuc_instance, value); }
			}
			
			global::GUI.DanhMuc_SuaKhoHang DanhMuc_SuaKhoHang_instance;
			bool DanhMuc_SuaKhoHang_isCreating;
			public global::GUI.DanhMuc_SuaKhoHang DanhMuc_SuaKhoHang {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_SuaKhoHang_instance, ref DanhMuc_SuaKhoHang_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_SuaKhoHang_instance, value); }
			}
			
			global::GUI.ChucNang_BaoCaoKhoHang ChucNang_BaoCaoKhoHang_instance;
			bool ChucNang_BaoCaoKhoHang_isCreating;
			public global::GUI.ChucNang_BaoCaoKhoHang ChucNang_BaoCaoKhoHang {
				[DebuggerStepThrough] get { return GetForm(ref ChucNang_BaoCaoKhoHang_instance, ref ChucNang_BaoCaoKhoHang_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref ChucNang_BaoCaoKhoHang_instance, value); }
			}
			
			global::GUI.HeThong_DoiMatKhau HeThong_DoiMatKhau_instance;
			bool HeThong_DoiMatKhau_isCreating;
			public global::GUI.HeThong_DoiMatKhau HeThong_DoiMatKhau {
				[DebuggerStepThrough] get { return GetForm(ref HeThong_DoiMatKhau_instance, ref HeThong_DoiMatKhau_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref HeThong_DoiMatKhau_instance, value); }
			}
			
			global::GUI.DanhMuc_ThemKhoHang DanhMuc_ThemKhoHang_instance;
			bool DanhMuc_ThemKhoHang_isCreating;
			public global::GUI.DanhMuc_ThemKhoHang DanhMuc_ThemKhoHang {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_ThemKhoHang_instance, ref DanhMuc_ThemKhoHang_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_ThemKhoHang_instance, value); }
			}
			
			global::GUI.ChucNang_MuaHang ChucNang_MuaHang_instance;
			bool ChucNang_MuaHang_isCreating;
			public global::GUI.ChucNang_MuaHang ChucNang_MuaHang {
				[DebuggerStepThrough] get { return GetForm(ref ChucNang_MuaHang_instance, ref ChucNang_MuaHang_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref ChucNang_MuaHang_instance, value); }
			}
			
			global::GUI.ChucNang_NhapSLHang ChucNang_NhapSLHang_instance;
			bool ChucNang_NhapSLHang_isCreating;
			public global::GUI.ChucNang_NhapSLHang ChucNang_NhapSLHang {
				[DebuggerStepThrough] get { return GetForm(ref ChucNang_NhapSLHang_instance, ref ChucNang_NhapSLHang_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref ChucNang_NhapSLHang_instance, value); }
			}
			
			global::GUI.DanhMuc_TyGia DanhMuc_TyGia_instance;
			bool DanhMuc_TyGia_isCreating;
			public global::GUI.DanhMuc_TyGia DanhMuc_TyGia {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_TyGia_instance, ref DanhMuc_TyGia_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_TyGia_instance, value); }
			}
			
			global::GUI.DanhMuc_SuaKhuVuc DanhMuc_SuaKhuVuc_instance;
			bool DanhMuc_SuaKhuVuc_isCreating;
			public global::GUI.DanhMuc_SuaKhuVuc DanhMuc_SuaKhuVuc {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_SuaKhuVuc_instance, ref DanhMuc_SuaKhuVuc_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_SuaKhuVuc_instance, value); }
			}
			
			global::GUI.HeThong_FormThongTin HeThong_FormThongTin_instance;
			bool HeThong_FormThongTin_isCreating;
			public global::GUI.HeThong_FormThongTin HeThong_FormThongTin {
				[DebuggerStepThrough] get { return GetForm(ref HeThong_FormThongTin_instance, ref HeThong_FormThongTin_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref HeThong_FormThongTin_instance, value); }
			}
			
			global::GUI.DanhMuc_SuaBoPhan DanhMuc_SuaBoPhan_instance;
			bool DanhMuc_SuaBoPhan_isCreating;
			public global::GUI.DanhMuc_SuaBoPhan DanhMuc_SuaBoPhan {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_SuaBoPhan_instance, ref DanhMuc_SuaBoPhan_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_SuaBoPhan_instance, value); }
			}
			
			global::GUI.DanhMuc_ThemKhuVuc DanhMuc_ThemKhuVuc_instance;
			bool DanhMuc_ThemKhuVuc_isCreating;
			public global::GUI.DanhMuc_ThemKhuVuc DanhMuc_ThemKhuVuc {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_ThemKhuVuc_instance, ref DanhMuc_ThemKhuVuc_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_ThemKhuVuc_instance, value); }
			}
			
			global::GUI.DanhMuc_NhomHang DanhMuc_NhomHang_instance;
			bool DanhMuc_NhomHang_isCreating;
			public global::GUI.DanhMuc_NhomHang DanhMuc_NhomHang {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_NhomHang_instance, ref DanhMuc_NhomHang_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_NhomHang_instance, value); }
			}
			
			global::GUI.DanhMuc_ThemBoPhan DanhMuc_ThemBoPhan_instance;
			bool DanhMuc_ThemBoPhan_isCreating;
			public global::GUI.DanhMuc_ThemBoPhan DanhMuc_ThemBoPhan {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_ThemBoPhan_instance, ref DanhMuc_ThemBoPhan_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_ThemBoPhan_instance, value); }
			}
			
			global::GUI.DanhMuc_SuaNhomHang DanhMuc_SuaNhomHang_instance;
			bool DanhMuc_SuaNhomHang_isCreating;
			public global::GUI.DanhMuc_SuaNhomHang DanhMuc_SuaNhomHang {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_SuaNhomHang_instance, ref DanhMuc_SuaNhomHang_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_SuaNhomHang_instance, value); }
			}
			
			global::GUI.DanhMuc_NhaCungCap DanhMuc_NhaCungCap_instance;
			bool DanhMuc_NhaCungCap_isCreating;
			public global::GUI.DanhMuc_NhaCungCap DanhMuc_NhaCungCap {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_NhaCungCap_instance, ref DanhMuc_NhaCungCap_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_NhaCungCap_instance, value); }
			}
			
			global::GUI.HeThong_NhatKy HeThong_NhatKy_instance;
			bool HeThong_NhatKy_isCreating;
			public global::GUI.HeThong_NhatKy HeThong_NhatKy {
				[DebuggerStepThrough] get { return GetForm(ref HeThong_NhatKy_instance, ref HeThong_NhatKy_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref HeThong_NhatKy_instance, value); }
			}
			
			global::GUI.ChucNang_ChuyenKho ChucNang_ChuyenKho_instance;
			bool ChucNang_ChuyenKho_isCreating;
			public global::GUI.ChucNang_ChuyenKho ChucNang_ChuyenKho {
				[DebuggerStepThrough] get { return GetForm(ref ChucNang_ChuyenKho_instance, ref ChucNang_ChuyenKho_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref ChucNang_ChuyenKho_instance, value); }
			}
			
			global::GUI.DanhMuc_ThemNhomHang DanhMuc_ThemNhomHang_instance;
			bool DanhMuc_ThemNhomHang_isCreating;
			public global::GUI.DanhMuc_ThemNhomHang DanhMuc_ThemNhomHang {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_ThemNhomHang_instance, ref DanhMuc_ThemNhomHang_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_ThemNhomHang_instance, value); }
			}
			
			global::GUI.ChucNang_LapPhieuChi ChucNang_LapPhieuChi_instance;
			bool ChucNang_LapPhieuChi_isCreating;
			public global::GUI.ChucNang_LapPhieuChi ChucNang_LapPhieuChi {
				[DebuggerStepThrough] get { return GetForm(ref ChucNang_LapPhieuChi_instance, ref ChucNang_LapPhieuChi_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref ChucNang_LapPhieuChi_instance, value); }
			}
			
			global::GUI.HT_PhanQuyen_SuaNguoiDung HT_PhanQuyen_SuaNguoiDung_instance;
			bool HT_PhanQuyen_SuaNguoiDung_isCreating;
			public global::GUI.HT_PhanQuyen_SuaNguoiDung HT_PhanQuyen_SuaNguoiDung {
				[DebuggerStepThrough] get { return GetForm(ref HT_PhanQuyen_SuaNguoiDung_instance, ref HT_PhanQuyen_SuaNguoiDung_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref HT_PhanQuyen_SuaNguoiDung_instance, value); }
			}
			
			global::GUI.ChucNang_LapPhieuThu ChucNang_LapPhieuThu_instance;
			bool ChucNang_LapPhieuThu_isCreating;
			public global::GUI.ChucNang_LapPhieuThu ChucNang_LapPhieuThu {
				[DebuggerStepThrough] get { return GetForm(ref ChucNang_LapPhieuThu_instance, ref ChucNang_LapPhieuThu_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref ChucNang_LapPhieuThu_instance, value); }
			}
			
			global::GUI.DanhMuc_SuaNhaCungCap DanhMuc_SuaNhaCungCap_instance;
			bool DanhMuc_SuaNhaCungCap_isCreating;
			public global::GUI.DanhMuc_SuaNhaCungCap DanhMuc_SuaNhaCungCap {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_SuaNhaCungCap_instance, ref DanhMuc_SuaNhaCungCap_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_SuaNhaCungCap_instance, value); }
			}
			
			global::GUI.DanhMuc_DonViTinh DanhMuc_DonViTinh_instance;
			bool DanhMuc_DonViTinh_isCreating;
			public global::GUI.DanhMuc_DonViTinh DanhMuc_DonViTinh {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_DonViTinh_instance, ref DanhMuc_DonViTinh_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_DonViTinh_instance, value); }
			}
			
			global::GUI.HeThong_PhanQuyen HeThong_PhanQuyen_instance;
			bool HeThong_PhanQuyen_isCreating;
			public global::GUI.HeThong_PhanQuyen HeThong_PhanQuyen {
				[DebuggerStepThrough] get { return GetForm(ref HeThong_PhanQuyen_instance, ref HeThong_PhanQuyen_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref HeThong_PhanQuyen_instance, value); }
			}
			
			global::GUI.ChucNang_ThuTien ChucNang_ThuTien_instance;
			bool ChucNang_ThuTien_isCreating;
			public global::GUI.ChucNang_ThuTien ChucNang_ThuTien {
				[DebuggerStepThrough] get { return GetForm(ref ChucNang_ThuTien_instance, ref ChucNang_ThuTien_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref ChucNang_ThuTien_instance, value); }
			}
			
			global::GUI.DanhMuc_SuaDonVi DanhMuc_SuaDonVi_instance;
			bool DanhMuc_SuaDonVi_isCreating;
			public global::GUI.DanhMuc_SuaDonVi DanhMuc_SuaDonVi {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_SuaDonVi_instance, ref DanhMuc_SuaDonVi_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_SuaDonVi_instance, value); }
			}
			
			global::GUI.ChucNang_TonKho ChucNang_TonKho_instance;
			bool ChucNang_TonKho_isCreating;
			public global::GUI.ChucNang_TonKho ChucNang_TonKho {
				[DebuggerStepThrough] get { return GetForm(ref ChucNang_TonKho_instance, ref ChucNang_TonKho_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref ChucNang_TonKho_instance, value); }
			}
			
			global::GUI.DanhMuc_ThemNhaCungCap DanhMuc_ThemNhaCungCap_instance;
			bool DanhMuc_ThemNhaCungCap_isCreating;
			public global::GUI.DanhMuc_ThemNhaCungCap DanhMuc_ThemNhaCungCap {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_ThemNhaCungCap_instance, ref DanhMuc_ThemNhaCungCap_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_ThemNhaCungCap_instance, value); }
			}
			
			global::GUI.DanhMuc_ThemDonVi DanhMuc_ThemDonVi_instance;
			bool DanhMuc_ThemDonVi_isCreating;
			public global::GUI.DanhMuc_ThemDonVi DanhMuc_ThemDonVi {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_ThemDonVi_instance, ref DanhMuc_ThemDonVi_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_ThemDonVi_instance, value); }
			}
			
			global::GUI.HT_PhanQuyen_SuaVaiTro HT_PhanQuyen_SuaVaiTro_instance;
			bool HT_PhanQuyen_SuaVaiTro_isCreating;
			public global::GUI.HT_PhanQuyen_SuaVaiTro HT_PhanQuyen_SuaVaiTro {
				[DebuggerStepThrough] get { return GetForm(ref HT_PhanQuyen_SuaVaiTro_instance, ref HT_PhanQuyen_SuaVaiTro_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref HT_PhanQuyen_SuaVaiTro_instance, value); }
			}
			
			global::GUI.HeThong_PhucHoi HeThong_PhucHoi_instance;
			bool HeThong_PhucHoi_isCreating;
			public global::GUI.HeThong_PhucHoi HeThong_PhucHoi {
				[DebuggerStepThrough] get { return GetForm(ref HeThong_PhucHoi_instance, ref HeThong_PhucHoi_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref HeThong_PhucHoi_instance, value); }
			}
			
			global::GUI.HT_PhanQuyen_ThemNguoiDung HT_PhanQuyen_ThemNguoiDung_instance;
			bool HT_PhanQuyen_ThemNguoiDung_isCreating;
			public global::GUI.HT_PhanQuyen_ThemNguoiDung HT_PhanQuyen_ThemNguoiDung {
				[DebuggerStepThrough] get { return GetForm(ref HT_PhanQuyen_ThemNguoiDung_instance, ref HT_PhanQuyen_ThemNguoiDung_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref HT_PhanQuyen_ThemNguoiDung_instance, value); }
			}
			
			global::GUI.HeThong_SaoLuu HeThong_SaoLuu_instance;
			bool HeThong_SaoLuu_isCreating;
			public global::GUI.HeThong_SaoLuu HeThong_SaoLuu {
				[DebuggerStepThrough] get { return GetForm(ref HeThong_SaoLuu_instance, ref HeThong_SaoLuu_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref HeThong_SaoLuu_instance, value); }
			}
			
			global::GUI.FormMain FormMain_instance;
			bool FormMain_isCreating;
			public global::GUI.FormMain FormMain {
				[DebuggerStepThrough] get { return GetForm(ref FormMain_instance, ref FormMain_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref FormMain_instance, value); }
			}
			
			global::GUI.DanhMuc_NhanVien DanhMuc_NhanVien_instance;
			bool DanhMuc_NhanVien_isCreating;
			public global::GUI.DanhMuc_NhanVien DanhMuc_NhanVien {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_NhanVien_instance, ref DanhMuc_NhanVien_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_NhanVien_instance, value); }
			}
			
			global::GUI.DanhMuc_HangHoa DanhMuc_HangHoa_instance;
			bool DanhMuc_HangHoa_isCreating;
			public global::GUI.DanhMuc_HangHoa DanhMuc_HangHoa {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_HangHoa_instance, ref DanhMuc_HangHoa_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_HangHoa_instance, value); }
			}
			
			global::GUI.DanhMuc_FormKhachHang DanhMuc_FormKhachHang_instance;
			bool DanhMuc_FormKhachHang_isCreating;
			public global::GUI.DanhMuc_FormKhachHang DanhMuc_FormKhachHang {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_FormKhachHang_instance, ref DanhMuc_FormKhachHang_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_FormKhachHang_instance, value); }
			}
			
			global::GUI.HT_PhanQuyen_ThemVaiTro HT_PhanQuyen_ThemVaiTro_instance;
			bool HT_PhanQuyen_ThemVaiTro_isCreating;
			public global::GUI.HT_PhanQuyen_ThemVaiTro HT_PhanQuyen_ThemVaiTro {
				[DebuggerStepThrough] get { return GetForm(ref HT_PhanQuyen_ThemVaiTro_instance, ref HT_PhanQuyen_ThemVaiTro_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref HT_PhanQuyen_ThemVaiTro_instance, value); }
			}
			
			global::GUI.DanhMuc_SuaNhanVien DanhMuc_SuaNhanVien_instance;
			bool DanhMuc_SuaNhanVien_isCreating;
			public global::GUI.DanhMuc_SuaNhanVien DanhMuc_SuaNhanVien {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_SuaNhanVien_instance, ref DanhMuc_SuaNhanVien_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_SuaNhanVien_instance, value); }
			}
			
			global::GUI.DanhMuc_SuaHangHoa DanhMuc_SuaHangHoa_instance;
			bool DanhMuc_SuaHangHoa_isCreating;
			public global::GUI.DanhMuc_SuaHangHoa DanhMuc_SuaHangHoa {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_SuaHangHoa_instance, ref DanhMuc_SuaHangHoa_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_SuaHangHoa_instance, value); }
			}
			
			global::GUI.DanhMuc_SuaKhachHang DanhMuc_SuaKhachHang_instance;
			bool DanhMuc_SuaKhachHang_isCreating;
			public global::GUI.DanhMuc_SuaKhachHang DanhMuc_SuaKhachHang {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_SuaKhachHang_instance, ref DanhMuc_SuaKhachHang_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_SuaKhachHang_instance, value); }
			}
			
			global::GUI.DanhMuc_BoPhan DanhMuc_BoPhan_instance;
			bool DanhMuc_BoPhan_isCreating;
			public global::GUI.DanhMuc_BoPhan DanhMuc_BoPhan {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_BoPhan_instance, ref DanhMuc_BoPhan_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_BoPhan_instance, value); }
			}
			
			global::GUI.DanhMuc_ThemNhanVien DanhMuc_ThemNhanVien_instance;
			bool DanhMuc_ThemNhanVien_isCreating;
			public global::GUI.DanhMuc_ThemNhanVien DanhMuc_ThemNhanVien {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_ThemNhanVien_instance, ref DanhMuc_ThemNhanVien_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_ThemNhanVien_instance, value); }
			}
			
			global::GUI.DanhMuc_ThemKhachHang DanhMuc_ThemKhachHang_instance;
			bool DanhMuc_ThemKhachHang_isCreating;
			public global::GUI.DanhMuc_ThemKhachHang DanhMuc_ThemKhachHang {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_ThemKhachHang_instance, ref DanhMuc_ThemKhachHang_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_ThemKhachHang_instance, value); }
			}
			
			global::GUI.DanhMuc_ThemHangHoa DanhMuc_ThemHangHoa_instance;
			bool DanhMuc_ThemHangHoa_isCreating;
			public global::GUI.DanhMuc_ThemHangHoa DanhMuc_ThemHangHoa {
				[DebuggerStepThrough] get { return GetForm(ref DanhMuc_ThemHangHoa_instance, ref DanhMuc_ThemHangHoa_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DanhMuc_ThemHangHoa_instance, value); }
			}
			
			[DebuggerStepThrough]
			static T GetForm<T>(ref T instance, ref bool isCreating) where T : Form, new()
			{
				if (instance == null || instance.IsDisposed) {
					if (isCreating) {
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
					isCreating = true;
					try {
						instance = new T();
					} catch (System.Reflection.TargetInvocationException ex) {
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[] { ex.InnerException.Message }), ex.InnerException);
					} finally {
						isCreating = false;
					}
				}
				return instance;
			}
			
			[DebuggerStepThrough]
			static void SetForm<T>(ref T instance, T value) where T : Form
			{
				if (instance != value) {
					if (value == null) {
						instance.Dispose();
						instance = null;
					} else {
						throw new ArgumentException("Property can only be set to null");
					}
				}
			}
		}
	}
	
	partial class MyApplication : WindowsFormsApplicationBase
	{
		[STAThread]
		public static void Main(string[] args)
		{
			Application.SetCompatibleTextRenderingDefault(UseCompatibleTextRendering);
			MyProject.Application.Run(args);
		}
	}
	
	partial class MyComputer : Computer
	{
	}
}
