USE [master]
GO
/****** Object:  Database [QuanLyBanHang]    Script Date: 09-1-2018 9:32:46 PM ******/
CREATE DATABASE [QuanLyBanHang]

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyBanHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyBanHang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyBanHang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyBanHang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyBanHang] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyBanHang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyBanHang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyBanHang] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyBanHang] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyBanHang', N'ON'
GO
USE [QuanLyBanHang]
GO
/****** Object:  Table [dbo].[BOPHAN]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOPHAN](
	[MaBoPhan] [int] IDENTITY(1,1) NOT NULL,
	[TenBoPhan] [nvarchar](255) NULL,
	[GhiChu] [nvarchar](255) NULL,
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_BOPHAN] PRIMARY KEY CLUSTERED 
(
	[MaBoPhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETCHUYENKHO]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETCHUYENKHO](
	[MaPhieu] [int] NOT NULL,
	[MaHangHoa] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_CHITIETCHUYENKHO] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CONGNO_KH]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONGNO_KH](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaKH] [int] NOT NULL,
	[NgayPhatSinh] [date] NULL,
	[NoPhatSinh] [float] NULL,
	[DaThu] [float] NULL,
	[ConLai] [float] NULL,
	[LoaiPhatSinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_CONGNO_KH_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CONGNO_NCC]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONGNO_NCC](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaNCC] [int] NOT NULL,
	[NgayPhatSinh] [date] NULL,
	[No] [float] NOT NULL,
	[DaThu] [float] NULL,
	[ConLai] [float] NULL,
	[LoaiPhatSinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_CONGNO_NCC_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTMUAHANG]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTMUAHANG](
	[MaPhieuMH] [int] NOT NULL,
	[MaHangHoa] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_CTMUAHANG] PRIMARY KEY CLUSTERED 
(
	[MaPhieuMH] ASC,
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTXUATHANG]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTXUATHANG](
	[MaPhieuXuat] [int] NOT NULL,
	[MaHangHoa] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_CTXUATHANG] PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC,
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DONVI]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONVI](
	[MaDV] [int] IDENTITY(1,1) NOT NULL,
	[TenDonVi] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](255) NULL,
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_DONVI] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[MaHangHoa] [int] IDENTITY(1,1) NOT NULL,
	[TenHangHoa] [nvarchar](255) NULL,
	[LoaiHangHoa] [int] NULL,
	[KhoMacDinh] [int] NULL,
	[PhanLoai] [int] NULL,
	[DonVi] [int] NULL,
	[XuatXu] [nvarchar](255) NULL,
	[TonKhoToiThieu] [int] NULL,
	[TonKho] [int] NULL,
	[NhaCungCap] [int] NULL,
	[GiaMua] [float] NULL,
	[GiaBan] [float] NULL,
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_HANGHOA] PRIMARY KEY CLUSTERED 
(
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](255) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[MaSoThue] [char](20) NULL,
	[SoDiDong] [char](20) NULL,
	[SoDienThoaiBan] [char](20) NULL,
	[Email] [char](255) NULL,
	[Fax] [char](20) NULL,
	[Website] [char](255) NULL,
	[SoTaiKhoan] [char](30) NULL,
	[NganHang] [nvarchar](255) NULL,
	[GioiHanNo] [float] NULL,
	[ChietKhau] [float] NULL,
	[NguoiLenHe] [nvarchar](255) NULL,
	[NoHienTai] [float] NULL,
	[NickYahoo] [char](50) NULL,
	[LoaiKhachHang] [int] NULL,
	[KhuVuc] [int] NULL,
	[NickSkype] [char](50) NULL,
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHO]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHO](
	[MaKho] [int] IDENTITY(1,1) NOT NULL,
	[TenKho] [nvarchar](255) NULL,
	[NVQuanLy] [int] NULL,
	[NguoiLienHe] [nvarchar](255) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[DienThoai] [char](20) NULL,
	[Fax] [char](20) NULL,
	[Email] [char](255) NULL,
	[DienGiai] [nvarchar](255) NULL,
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_KHO] PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHO_HANGHOA]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHO_HANGHOA](
	[MaKho] [int] NOT NULL,
	[MaHangHoa] [int] NOT NULL,
	[SoLuongTon] [int] NULL,
 CONSTRAINT [PK_KHO_HANGHOA] PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC,
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHUVUC]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHUVUC](
	[MaKhuVuc] [int] IDENTITY(1,1) NOT NULL,
	[TenKhuVuc] [nvarchar](255) NULL,
	[GhiChu] [nvarchar](255) NULL,
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_KHUVUC] PRIMARY KEY CLUSTERED 
(
	[MaKhuVuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAIHANGHOA]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIHANGHOA](
	[MaLoaiHH] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiHH] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAIHANGHOA] PRIMARY KEY CLUSTERED 
(
	[MaLoaiHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAIKHACHHANG]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIKHACHHANG](
	[MaLoaiKH] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiKH] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAIKHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaLoaiKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOG]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOG](
	[MaNKHD] [int] IDENTITY(1,1) NOT NULL,
	[TenNguoiDung] [varchar](50) NULL,
	[ChucNang] [nvarchar](255) NOT NULL,
	[HanhDong] [nvarchar](255) NULL,
	[ThoiGian] [varchar](50) NULL,
 CONSTRAINT [PK_LOG] PRIMARY KEY CLUSTERED 
(
	[MaNKHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[MaNguoiDung] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](255) NOT NULL,
	[TaiKhoan] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NULL,
	[XacNhan] [varchar](50) NULL,
	[VaiTro] [int] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_NGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[MaNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](255) NULL,
	[ChucVu] [nvarchar](255) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[Email] [char](255) NULL,
	[DienThoai] [char](20) NULL,
	[DiDong] [char](20) NULL,
	[BoPhan] [int] NULL,
	[QuanLy] [int] NULL,
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHAPHANPHOI]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHAPHANPHOI](
	[MaNhaPhanPhoi] [int] IDENTITY(1,1) NOT NULL,
	[TenNhaPhanPhoi] [nvarchar](255) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[MaSoThue] [char](20) NULL,
	[SoDiDong] [char](20) NULL,
	[SoDienThoaiBan] [char](20) NULL,
	[Email] [char](255) NULL,
	[Fax] [char](20) NULL,
	[Website] [char](255) NULL,
	[SoTaiKhoan] [char](30) NULL,
	[NganHang] [nvarchar](255) NULL,
	[GioiHanNo] [float] NULL,
	[ChietKhau] [float] NULL,
	[NguoiLenHe] [nvarchar](255) NULL,
	[ChucVu] [nvarchar](255) NULL,
	[NoHienTai] [float] NULL,
	[KhuVuc] [int] NOT NULL,
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_NHAPHANPHOI] PRIMARY KEY CLUSTERED 
(
	[MaNhaPhanPhoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHOMHANG]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHOMHANG](
	[MaNhomHang] [int] IDENTITY(1,1) NOT NULL,
	[TenNhomHang] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](255) NULL,
	[ConQuanLy] [bit] NOT NULL,
 CONSTRAINT [PK_NHOMHANG] PRIMARY KEY CLUSTERED 
(
	[MaNhomHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUCHUYENKHO]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUCHUYENKHO](
	[MaPhieu] [int] IDENTITY(1,1) NOT NULL,
	[NgayChuyen] [date] NULL,
	[KhoXuat] [int] NULL,
	[KhoNhan] [int] NULL,
	[GhiChu] [nvarchar](255) NULL,
	[NguoiChuyen] [int] NULL,
	[NguoiNhan] [int] NULL,
 CONSTRAINT [PK_PHIEUCHUYENKHO] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUNHAPHANG]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAPHANG](
	[MaPhieuNhap] [int] IDENTITY(1,1) NOT NULL,
	[NhaCC] [int] NULL,
	[NgayNhap] [date] NULL,
	[NVPhuTrach] [int] NULL,
	[KhoNhap] [int] NULL,
	[DKThanhToan] [nvarchar](50) NULL,
	[HTThanhToan] [nvarchar](50) NULL,
	[HanThanhToan] [date] NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [PK_PHIEUNHAPHANG] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUXUATHANG]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUXUATHANG](
	[MaPhieuXuat] [int] IDENTITY(1,1) NOT NULL,
	[MaKH] [int] NULL,
	[NgayXuat] [date] NULL,
	[NVBanHang] [int] NULL,
	[KhoXuat] [int] NULL,
	[DKThanhToan] [nvarchar](50) NULL,
	[HTThanhToan] [nvarchar](50) NULL,
	[HanThanhToan] [date] NULL,
	[NgayGiao] [date] NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [PK_PHIEUXUATHANG] PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TYGIA]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TYGIA](
	[MaTyGia] [int] IDENTITY(1,1) NOT NULL,
	[TenTyGia] [nvarchar](50) NULL,
	[TyGiaQuyDoi] [float] NULL,
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_TYGIA] PRIMARY KEY CLUSTERED 
(
	[MaTyGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VAITRO]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VAITRO](
	[MaVaiTro] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](255) NULL,
	[PhanQuyen] [bit] NULL CONSTRAINT [DF_VAITRO_PhanQuyen]  DEFAULT ((1)),
	[DoiMatKhau] [bit] NULL CONSTRAINT [DF_VAITRO_DoiMatKhau]  DEFAULT ((1)),
	[NhatKyHeThong] [bit] NULL CONSTRAINT [DF_VAITRO_NhatKyHeThong]  DEFAULT ((1)),
	[SaoLuu] [bit] NULL CONSTRAINT [DF_VAITRO_SaoLuu]  DEFAULT ((1)),
	[PhucHoi] [bit] NULL CONSTRAINT [DF_VAITRO_PhucHoi]  DEFAULT ((1)),
	[KhuVuc] [bit] NULL CONSTRAINT [DF_VAITRO_KhuVuc]  DEFAULT ((1)),
	[KhachHang] [bit] NULL CONSTRAINT [DF_VAITRO_KhachHang]  DEFAULT ((1)),
	[NhaCungCap] [bit] NULL CONSTRAINT [DF_VAITRO_NhaCungCap]  DEFAULT ((1)),
	[KhoHang] [bit] NULL CONSTRAINT [DF_VAITRO_KhoHang]  DEFAULT ((1)),
	[DonViTinh] [bit] NULL CONSTRAINT [DF_VAITRO_DonViTinh]  DEFAULT ((1)),
	[NhomHang] [bit] NULL CONSTRAINT [DF_VAITRO_NhomHang]  DEFAULT ((1)),
	[HangHoa] [bit] NULL CONSTRAINT [DF_VAITRO_HangHoa]  DEFAULT ((1)),
	[TyGia] [bit] NULL CONSTRAINT [DF_VAITRO_TyGia]  DEFAULT ((1)),
	[BoPhan] [bit] NULL CONSTRAINT [DF_VAITRO_BoPhan]  DEFAULT ((1)),
	[NhanVien] [bit] NULL CONSTRAINT [DF_VAITRO_NhanVien]  DEFAULT ((1)),
	[MuaHang] [bit] NULL CONSTRAINT [DF_VAITRO_MuaHang]  DEFAULT ((1)),
	[BanHang] [bit] NULL CONSTRAINT [DF_VAITRO_BanHang]  DEFAULT ((1)),
	[TonKho] [bit] NULL CONSTRAINT [DF_VAITRO_TonKho]  DEFAULT ((1)),
	[ChuyenKho] [bit] NULL CONSTRAINT [DF_VAITRO_ChuyenKho]  DEFAULT ((1)),
	[ThuTien] [bit] NULL CONSTRAINT [DF_VAITRO_ThuTien]  DEFAULT ((1)),
	[TraTien] [bit] NULL CONSTRAINT [DF_VAITRO_TraTien]  DEFAULT ((1)),
	[BaoCaoKhohang] [bit] NULL CONSTRAINT [DF_VAITRO_BaoCaoKhohang]  DEFAULT ((1)),
	[BaoCaoBanHang] [bit] NULL CONSTRAINT [DF_VAITRO_BaoCaoBanHang]  DEFAULT ((1)),
 CONSTRAINT [PK_VAITRO] PRIMARY KEY CLUSTERED 
(
	[MaVaiTro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[BOPHAN] ON 

INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan], [GhiChu], [ConQuanLy]) VALUES (1, N'Bán hàng', N'', 1)
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan], [GhiChu], [ConQuanLy]) VALUES (2, N'Giám Đốc', NULL, 1)
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan], [GhiChu], [ConQuanLy]) VALUES (3, N'Phòng Kinh Doanh', NULL, 1)
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan], [GhiChu], [ConQuanLy]) VALUES (4, N'Phòng Kế Toán', NULL, 1)
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan], [GhiChu], [ConQuanLy]) VALUES (5, N'Phòng Kỹ Thuật', NULL, 1)
SET IDENTITY_INSERT [dbo].[BOPHAN] OFF
SET IDENTITY_INSERT [dbo].[DONVI] ON 

INSERT [dbo].[DONVI] ([MaDV], [TenDonVi], [GhiChu], [ConQuanLy]) VALUES (1, N'Bộ', NULL, 1)
INSERT [dbo].[DONVI] ([MaDV], [TenDonVi], [GhiChu], [ConQuanLy]) VALUES (2, N'Cái', NULL, 1)
INSERT [dbo].[DONVI] ([MaDV], [TenDonVi], [GhiChu], [ConQuanLy]) VALUES (3, N'Cặp', NULL, 1)
INSERT [dbo].[DONVI] ([MaDV], [TenDonVi], [GhiChu], [ConQuanLy]) VALUES (4, N'Cây', NULL, 1)
INSERT [dbo].[DONVI] ([MaDV], [TenDonVi], [GhiChu], [ConQuanLy]) VALUES (5, N'Chai', NULL, 1)
INSERT [dbo].[DONVI] ([MaDV], [TenDonVi], [GhiChu], [ConQuanLy]) VALUES (6, N'Cuộn', NULL, 1)
SET IDENTITY_INSERT [dbo].[DONVI] OFF
SET IDENTITY_INSERT [dbo].[HANGHOA] ON 

INSERT [dbo].[HANGHOA] ([MaHangHoa], [TenHangHoa], [LoaiHangHoa], [KhoMacDinh], [PhanLoai], [DonVi], [XuatXu], [TonKhoToiThieu], [TonKho], [NhaCungCap], [GiaMua], [GiaBan], [ConQuanLy]) VALUES (3, N'Đinh ghim sắt', 1, 5, 2, 1, N'', 600, 4500, 5, 20000, 25000, 1)
INSERT [dbo].[HANGHOA] ([MaHangHoa], [TenHangHoa], [LoaiHangHoa], [KhoMacDinh], [PhanLoai], [DonVi], [XuatXu], [TonKhoToiThieu], [TonKho], [NhaCungCap], [GiaMua], [GiaBan], [ConQuanLy]) VALUES (6, N'Nguồn tổng kocom 24DC', 1, 8, 2, 2, N'', 20, 1200, 3, 600000, 699000, 1)
INSERT [dbo].[HANGHOA] ([MaHangHoa], [TenHangHoa], [LoaiHangHoa], [KhoMacDinh], [PhanLoai], [DonVi], [XuatXu], [TonKhoToiThieu], [TonKho], [NhaCungCap], [GiaMua], [GiaBan], [ConQuanLy]) VALUES (7, N'Vỏ chụp camera PIH-5088', 1, 9, 2, 2, N'', 300, 1000, 4, 300000, 450000, 1)
INSERT [dbo].[HANGHOA] ([MaHangHoa], [TenHangHoa], [LoaiHangHoa], [KhoMacDinh], [PhanLoai], [DonVi], [XuatXu], [TonKhoToiThieu], [TonKho], [NhaCungCap], [GiaMua], [GiaBan], [ConQuanLy]) VALUES (8, N'Micro thu âm KJ-301', 1, 8, 2, 2, N'', 2000, 4000, 4, 200000, 400000, 1)
INSERT [dbo].[HANGHOA] ([MaHangHoa], [TenHangHoa], [LoaiHangHoa], [KhoMacDinh], [PhanLoai], [DonVi], [XuatXu], [TonKhoToiThieu], [TonKho], [NhaCungCap], [GiaMua], [GiaBan], [ConQuanLy]) VALUES (9, N'Tem từ giấy 3x3', 1, 5, 2, 6, NULL, 1000, 60000, 3, 2000, 2500, 1)
INSERT [dbo].[HANGHOA] ([MaHangHoa], [TenHangHoa], [LoaiHangHoa], [KhoMacDinh], [PhanLoai], [DonVi], [XuatXu], [TonKhoToiThieu], [TonKho], [NhaCungCap], [GiaMua], [GiaBan], [ConQuanLy]) VALUES (10, N'Cọc tiếp địa Ấn Độ', 1, 9, 2, 2, NULL, 1000, 2000, 4, 1500000, 2000000, 1)
INSERT [dbo].[HANGHOA] ([MaHangHoa], [TenHangHoa], [LoaiHangHoa], [KhoMacDinh], [PhanLoai], [DonVi], [XuatXu], [TonKhoToiThieu], [TonKho], [NhaCungCap], [GiaMua], [GiaBan], [ConQuanLy]) VALUES (11, N'Máy chấm công 808', 1, 8, 2, 2, N'', 1000, 20000, 5, 2000000, 2500000, 1)
INSERT [dbo].[HANGHOA] ([MaHangHoa], [TenHangHoa], [LoaiHangHoa], [KhoMacDinh], [PhanLoai], [DonVi], [XuatXu], [TonKhoToiThieu], [TonKho], [NhaCungCap], [GiaMua], [GiaBan], [ConQuanLy]) VALUES (12, N'Ổ cứng western 1TB', 1, 5, 2, 2, NULL, 2500, 4000, 1, 1500000, 1700000, 1)
INSERT [dbo].[HANGHOA] ([MaHangHoa], [TenHangHoa], [LoaiHangHoa], [KhoMacDinh], [PhanLoai], [DonVi], [XuatXu], [TonKhoToiThieu], [TonKho], [NhaCungCap], [GiaMua], [GiaBan], [ConQuanLy]) VALUES (13, N'Ổ cắm điện', 1, 5, 2, 2, NULL, 500, 3000, 5, 15000, 20000, 1)
INSERT [dbo].[HANGHOA] ([MaHangHoa], [TenHangHoa], [LoaiHangHoa], [KhoMacDinh], [PhanLoai], [DonVi], [XuatXu], [TonKhoToiThieu], [TonKho], [NhaCungCap], [GiaMua], [GiaBan], [ConQuanLy]) VALUES (14, N'Bộ lọc tín hiệu QTA 105', 1, 9, 2, 2, NULL, 300, 450, 1, 800000, 1200000, 1)
INSERT [dbo].[HANGHOA] ([MaHangHoa], [TenHangHoa], [LoaiHangHoa], [KhoMacDinh], [PhanLoai], [DonVi], [XuatXu], [TonKhoToiThieu], [TonKho], [NhaCungCap], [GiaMua], [GiaBan], [ConQuanLy]) VALUES (15, N'Bút Chì 2B', 1, 5, 1, 2, N'Việt Nam', 200, 0, 1, 2500, 3500, 1)
SET IDENTITY_INSERT [dbo].[HANGHOA] OFF
SET IDENTITY_INSERT [dbo].[KHO] ON 

INSERT [dbo].[KHO] ([MaKho], [TenKho], [NVQuanLy], [NguoiLienHe], [DiaChi], [DienThoai], [Fax], [Email], [DienGiai], [ConQuanLy]) VALUES (5, N'Kho Công Ty', 1, N'', NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[KHO] ([MaKho], [TenKho], [NVQuanLy], [NguoiLienHe], [DiaChi], [DienThoai], [Fax], [Email], [DienGiai], [ConQuanLy]) VALUES (8, N'Kho Hà Nội', 3, N'', NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[KHO] ([MaKho], [TenKho], [NVQuanLy], [NguoiLienHe], [DiaChi], [DienThoai], [Fax], [Email], [DienGiai], [ConQuanLy]) VALUES (9, N'Kho 6 HCM', 4, NULL, NULL, NULL, NULL, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[KHO] OFF
INSERT [dbo].[KHO_HANGHOA] ([MaKho], [MaHangHoa], [SoLuongTon]) VALUES (5, 3, 200)
INSERT [dbo].[KHO_HANGHOA] ([MaKho], [MaHangHoa], [SoLuongTon]) VALUES (5, 15, 0)
INSERT [dbo].[KHO_HANGHOA] ([MaKho], [MaHangHoa], [SoLuongTon]) VALUES (8, 6, 200)
INSERT [dbo].[KHO_HANGHOA] ([MaKho], [MaHangHoa], [SoLuongTon]) VALUES (8, 11, 300)
INSERT [dbo].[KHO_HANGHOA] ([MaKho], [MaHangHoa], [SoLuongTon]) VALUES (9, 9, 4000)
INSERT [dbo].[KHO_HANGHOA] ([MaKho], [MaHangHoa], [SoLuongTon]) VALUES (9, 10, 1)
SET IDENTITY_INSERT [dbo].[KHUVUC] ON 

INSERT [dbo].[KHUVUC] ([MaKhuVuc], [TenKhuVuc], [GhiChu], [ConQuanLy]) VALUES (1, N'Miền Nam', N'Khu vực miền Nam', 1)
INSERT [dbo].[KHUVUC] ([MaKhuVuc], [TenKhuVuc], [GhiChu], [ConQuanLy]) VALUES (2, N'Miền Trung', N'Khu vực miền Trung', 1)
INSERT [dbo].[KHUVUC] ([MaKhuVuc], [TenKhuVuc], [GhiChu], [ConQuanLy]) VALUES (3, N'Miền Bắc', N'Khu vực miền Bắc', 1)
SET IDENTITY_INSERT [dbo].[KHUVUC] OFF
SET IDENTITY_INSERT [dbo].[LOAIHANGHOA] ON 

INSERT [dbo].[LOAIHANGHOA] ([MaLoaiHH], [TenLoaiHH]) VALUES (1, N'Hàng hóa')
INSERT [dbo].[LOAIHANGHOA] ([MaLoaiHH], [TenLoaiHH]) VALUES (2, N'Dịch vụ')
SET IDENTITY_INSERT [dbo].[LOAIHANGHOA] OFF
SET IDENTITY_INSERT [dbo].[LOAIKHACHHANG] ON 

INSERT [dbo].[LOAIKHACHHANG] ([MaLoaiKH], [TenLoaiKH]) VALUES (1, N'Đại lý')
INSERT [dbo].[LOAIKHACHHANG] ([MaLoaiKH], [TenLoaiKH]) VALUES (2, N'Khách lẻ')
SET IDENTITY_INSERT [dbo].[LOAIKHACHHANG] OFF
SET IDENTITY_INSERT [dbo].[LOG] ON 

INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (50, N'admin', N'Nhật ký hệ thống', N'Xóa sạch nhật ký', N'10/01/2017 11:37:34 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (51, N'admin', N'Nhật ký hệ thống', N'Xem nhật ký', N'10/01/2017 11:37:36 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (52, N'admin', N'Hệ thống', N'Đăng nhập', N'10/01/2017 11:38:27 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (53, N'admin', N'Dữ liệu', N'Sao lưu dữ liệu', N'10/01/2017 11:38:39 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (54, N'admin', N'Hệ thống', N'Đăng nhập', N'14-12-2017 4:21:13 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (55, N'admin', N'Nhật ký hệ thống', N'Xem nhật ký', N'14-12-2017 4:22:13 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (56, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'14-12-2017 4:22:21 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (57, N'admin', N'Hệ thống', N'Đăng nhập', N'14-12-2017 4:31:55 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (58, N'admin', N'Nhóm hàng', N'Xem danh sách nhóm hàng', N'14-12-2017 4:32:00 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (59, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'14-12-2017 4:32:03 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (60, N'admin', N'Hệ thống', N'Đăng nhập', N'14-12-2017 4:34:48 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (61, N'admin', N'Kho hàng', N'Xem danh sách kho hàng', N'14-12-2017 4:36:03 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (62, N'admin', N'Nhóm hàng', N'Xem danh sách nhóm hàng', N'14-12-2017 4:36:06 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (63, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'14-12-2017 4:36:08 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (64, N'admin', N'Bộ phận', N'Xem danh sách bộ phận', N'14-12-2017 4:36:10 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (65, N'admin', N'Nhân viên', N'Xem danh sách nhân viên', N'14-12-2017 4:36:12 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (66, N'admin', N'Hệ thống', N'Đăng nhập', N'14-12-2017 8:03:42 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (67, N'admin', N'Nhóm hàng', N'Xem danh sách nhóm hàng', N'14-12-2017 8:04:16 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (68, N'admin', N'Nhà cung cấp', N'Xem danh sách nhà cung cấp', N'14-12-2017 8:04:30 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (69, N'admin', N'Khu vực', N'Xem danh sách khu vực', N'14-12-2017 8:04:37 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (70, N'admin', N'Nhân viên', N'Xem danh sách nhân viên', N'14-12-2017 8:04:41 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (71, N'admin', N'Bộ phận', N'Xem danh sách bộ phận', N'14-12-2017 8:04:49 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (72, N'admin', N'Đơn vị', N'Xem danh sách đơn vị', N'14-12-2017 8:04:53 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (73, N'admin', N'Hàng hóa', N'Thêm hàng hóa', N'14-12-2017 8:06:16 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (74, N'admin', N'Hệ thống', N'Đăng nhập', N'14-12-2017 8:09:35 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (75, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'14-12-2017 8:09:38 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (76, N'admin', N'Nhà cung cấp', N'Xem danh sách nhà cung cấp', N'14-12-2017 8:10:22 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (77, N'admin', N'Khu vực', N'Xem danh sách khu vực', N'14-12-2017 8:10:25 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (78, N'admin', N'Nhân viên', N'Xem danh sách nhân viên', N'14-12-2017 8:10:30 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (79, N'admin', N'Bộ phận', N'Xem danh sách bộ phận', N'14-12-2017 8:10:35 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (80, N'admin', N'Nhóm hàng', N'Xem danh sách nhóm hàng', N'14-12-2017 8:10:39 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (81, N'admin', N'Đơn vị', N'Xem danh sách đơn vị', N'14-12-2017 8:10:40 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (82, N'admin', N'Kho hàng', N'Xem danh sách kho hàng', N'14-12-2017 8:10:40 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (83, N'admin', N'Hệ thống', N'Đăng nhập', N'14-12-2017 8:12:42 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (84, N'123456', N'Hệ thống', N'Đăng nhập', N'14-12-2017 8:15:31 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (85, N'123456', N'Hàng hóa', N'Xem danh sách hàng hóa', N'14-12-2017 8:15:47 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (86, N'admin', N'Hệ thống', N'Đăng nhập', N'14-12-2017 11:12:20 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (87, N'admin', N'Hệ thống', N'Đăng nhập', N'14-12-2017 11:32:37 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (88, N'admin', N'Hệ thống', N'Đăng nhập', N'15-12-2017 12:02:40 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (89, N'admin', N'Hệ thống', N'Đăng nhập', N'15-12-2017 12:10:37 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (90, N'admin', N'Hệ thống', N'Đăng nhập', N'15-12-2017 12:11:00 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (91, N'admin', N'Hệ thống', N'Đăng nhập', N'15-12-2017 12:16:11 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (92, N'tienngoc', N'Hệ thống', N'Đăng nhập', N'15-12-2017 12:16:35 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (93, N'admin', N'Hệ thống', N'Đăng nhập', N'15-12-2017 12:18:35 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (94, N'admin', N'Hệ thống', N'Đăng nhập', N'15-12-2017 12:19:04 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (95, N'admin', N'Hệ thống', N'Đăng nhập', N'15-12-2017 12:20:06 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (96, N'tienngoc', N'Hệ thống', N'Đăng nhập', N'15-12-2017 12:35:23 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (97, N'admin', N'Hệ thống', N'Đăng nhập', N'15-12-2017 12:41:04 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (98, N'admin', N'Hệ thống', N'Đăng nhập', N'15-12-2017 12:41:32 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (99, N'admin', N'Hệ thống', N'Đăng nhập', N'15-12-2017 12:43:02 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (100, N'admin', N'Hệ thống', N'Đăng nhập', N'15-12-2017 12:43:17 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (101, N'admin', N'Hệ thống', N'Đăng nhập', N'15-12-2017 12:47:48 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (102, N'admin', N'Hệ thống', N'Đăng nhập', N'15-12-2017 12:48:18 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (103, N'admin', N'Hệ thống', N'Đăng nhập', N'15-12-2017 12:48:55 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (104, N'admin', N'Hệ thống', N'Đăng nhập', N'15-12-2017 1:04:21 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (105, N'admin', N'Hệ thống', N'Đăng nhập', N'15-12-2017 2:36:31 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (106, N'123456', N'Hệ thống', N'Đăng nhập', N'15-12-2017 2:37:57 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (107, N'123456', N'Khu vực', N'Xem danh sách khu vực', N'15-12-2017 2:38:00 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (108, N'123456', N'Hệ thống', N'Đổi mật khẩu', N'15-12-2017 2:38:23 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (109, N'123456', N'Nhật ký hệ thống', N'Xem nhật ký', N'15-12-2017 2:38:26 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (110, N'admin', N'Hệ thống', N'Đăng nhập', N'15-12-2017 3:35:29 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (111, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'15-12-2017 3:35:35 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (112, N'admin', N'Hệ thống', N'Đăng nhập', N'15-12-2017 3:36:20 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (113, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'15-12-2017 3:36:23 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (114, N'admin', N'Hệ thống', N'Đăng nhập', N'15-12-2017 3:40:56 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (115, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'15-12-2017 3:41:02 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (116, N'admin', N'Hệ thống', N'Đăng nhập', N'15-12-2017 3:42:32 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (117, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'15-12-2017 3:42:37 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (118, N'admin', N'Hệ thống', N'Đăng nhập', N'15-12-2017 3:46:03 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (119, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'15-12-2017 3:46:07 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (120, N'admin', N'Hệ thống', N'Đăng nhập', N'15-12-2017 4:23:09 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (121, N'123456', N'Hệ thống', N'Đăng nhập', N'16-12-2017 12:37:13 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (122, N'123456', N'Nhà cung cấp', N'Xem danh sách nhà cung cấp', N'16-12-2017 12:37:16 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (123, N'123456', N'Khu vực', N'Xem danh sách khu vực', N'16-12-2017 12:37:19 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (124, N'123456', N'Kho hàng', N'Xem danh sách kho hàng', N'16-12-2017 12:37:20 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (125, N'123456', N'Nhóm hàng', N'Xem danh sách nhóm hàng', N'16-12-2017 12:37:22 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (126, N'123456', N'Hàng hóa', N'Xem danh sách hàng hóa', N'16-12-2017 12:37:23 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (127, N'123456', N'Hệ thống', N'Đăng nhập', N'16-12-2017 12:38:29 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (128, N'123456', N'Bộ phận', N'Xem danh sách bộ phận', N'16-12-2017 12:38:35 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (129, N'123456', N'Nhân viên', N'Xem danh sách nhân viên', N'16-12-2017 12:38:36 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (130, N'123456', N'Hệ thống', N'Đăng nhập', N'16-12-2017 12:38:53 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (131, N'123456', N'Nhân viên', N'Sửa thông tin nhân viên', N'16-12-2017 12:39:40 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (132, N'123456', N'Hệ thống', N'Đăng nhập', N'16-12-2017 12:40:35 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (133, N'admin', N'Hệ thống', N'Đăng nhập', N'16-12-2017 12:43:14 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (134, N'admin', N'Nhân viên', N'Xem danh sách nhân viên', N'16-12-2017 12:43:18 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (135, N'admin', N'Nhân viên', N'Sửa thông tin nhân viên', N'16-12-2017 12:43:35 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (136, N'admin', N'Nhân viên', N'Sửa thông tin nhân viên', N'16-12-2017 12:43:46 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (137, N'admin', N'Nhân viên', N'Sửa thông tin nhân viên', N'16-12-2017 12:43:55 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (138, N'admin', N'Nhân viên', N'Sửa thông tin nhân viên', N'16-12-2017 12:44:11 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (139, N'admin', N'Hệ thống', N'Đăng nhập', N'16-12-2017 12:44:30 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (140, N'admin', N'Nhân viên', N'Xem danh sách nhân viên', N'16-12-2017 12:44:33 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (141, N'123456', N'Hệ thống', N'Đăng nhập', N'16-12-2017 12:45:53 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (142, N'123456', N'Nhân viên', N'Xem danh sách nhân viên', N'16-12-2017 12:45:56 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (143, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 10:46:42 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (144, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 11:02:10 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (145, N'123456', N'Hệ thống', N'Đăng nhập', N'18-12-2017 11:22:47 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (146, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 11:25:37 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (147, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 11:29:02 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (148, N'tienngoc', N'Hệ thống', N'Đăng nhập', N'18-12-2017 4:10:32 PM')
GO
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (149, N'tienngoc', N'Hệ thống', N'Đăng nhập', N'18-12-2017 4:13:56 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (150, N'tienngoc', N'Hệ thống', N'Đăng nhập', N'18-12-2017 4:15:08 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (151, N'tienngoc', N'Hệ thống', N'Đăng nhập', N'18-12-2017 4:17:32 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (152, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 4:19:32 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (153, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 4:20:03 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (154, N'123456', N'Hệ thống', N'Đăng nhập', N'18-12-2017 4:21:27 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (155, N'tienngoc', N'Hệ thống', N'Đăng nhập', N'18-12-2017 4:23:03 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (156, N'tienngoc', N'Hệ thống', N'Đăng nhập', N'18-12-2017 4:24:01 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (157, N'123456', N'Hệ thống', N'Đăng nhập', N'18-12-2017 4:24:58 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (158, N'tienngoc', N'Hệ thống', N'Đăng nhập', N'18-12-2017 4:25:22 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (159, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 4:34:09 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (160, N'123456', N'Hệ thống', N'Đăng nhập', N'18-12-2017 4:34:56 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (161, N'123456', N'Hệ thống', N'Đăng nhập', N'18-12-2017 4:35:46 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (162, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 4:36:44 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (163, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'18-12-2017 4:37:17 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (164, N'admin', N'Nhà cung cấp', N'Xem danh sách nhà cung cấp', N'18-12-2017 4:37:31 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (165, N'admin', N'Khu vực', N'Xem danh sách khu vực', N'18-12-2017 4:37:34 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (166, N'admin', N'Nhóm hàng', N'Xem danh sách nhóm hàng', N'18-12-2017 4:37:38 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (167, N'admin', N'Nhân viên', N'Xem danh sách nhân viên', N'18-12-2017 4:37:44 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (168, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 4:41:20 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1143, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 7:34:58 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1144, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'18-12-2017 7:35:02 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1145, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 7:36:18 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1146, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'18-12-2017 7:36:21 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1147, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 7:39:08 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1148, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 7:41:57 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1149, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'18-12-2017 7:42:02 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1150, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 7:43:39 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1151, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 7:52:47 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1152, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 7:54:53 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1153, N'admin', N'Nhân viên', N'Xem danh sách nhân viên', N'18-12-2017 7:55:16 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1154, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 8:00:33 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1155, N'admin', N'Nhân viên', N'Xem danh sách nhân viên', N'18-12-2017 8:00:38 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1156, N'admin', N'Nhân viên', N'Sửa thông tin nhân viên', N'18-12-2017 8:00:59 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1157, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 8:21:14 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1158, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 8:31:26 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1159, N'admin', N'Hệ thống', N'Đổi mật khẩu', N'18-12-2017 8:35:37 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1160, N'admin', N'Nhật ký hệ thống', N'Xem nhật ký', N'18-12-2017 8:36:20 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1161, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 8:41:30 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1162, N'admin', N'Nhật ký hệ thống', N'Xem nhật ký', N'18-12-2017 8:41:41 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1163, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'18-12-2017 8:41:48 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1164, N'admin', N'Nhóm hàng', N'Xem danh sách nhóm hàng', N'18-12-2017 8:41:50 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1165, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 8:44:09 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1166, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'18-12-2017 8:44:23 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1167, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 8:58:57 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1168, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 9:01:54 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1169, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 9:05:48 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1170, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 9:07:51 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1171, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 9:08:48 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1172, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 9:12:12 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1173, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 9:12:50 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1174, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 9:25:04 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1175, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 10:36:27 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1176, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 10:38:36 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1177, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 11:19:29 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1178, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 11:21:06 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1179, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 11:36:06 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1180, N'admin', N'Hệ thống', N'Đăng nhập', N'18-12-2017 11:39:55 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1181, N'admin', N'Hệ thống', N'Đăng nhập', N'19-12-2017 1:10:48 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1182, N'admin', N'Hệ thống', N'Đăng nhập', N'19-12-2017 1:12:01 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1183, N'admin', N'Hệ thống', N'Đăng nhập', N'19-12-2017 1:13:11 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1184, N'admin', N'Hệ thống', N'Đăng nhập', N'19-12-2017 1:16:22 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1185, N'admin', N'Hệ thống', N'Đăng nhập', N'19-12-2017 1:17:49 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1186, N'admin', N'Hệ thống', N'Đăng nhập', N'19-12-2017 1:19:44 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1187, N'admin', N'Hệ thống', N'Đăng nhập', N'19-12-2017 1:21:22 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1188, N'admin', N'Hệ thống', N'Đăng nhập', N'19-12-2017 1:23:48 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1189, N'admin', N'Kho hàng', N'Xem danh sách kho hàng', N'19-12-2017 1:23:56 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1190, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'19-12-2017 1:24:01 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1191, N'admin', N'Hàng hóa', N'Sửa hàng hóa', N'19-12-2017 1:24:21 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1192, N'admin', N'Hàng hóa', N'Sửa hàng hóa', N'19-12-2017 1:24:43 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1193, N'admin', N'Hệ thống', N'Đăng nhập', N'19-12-2017 1:27:42 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1194, N'admin', N'Hệ thống', N'Đăng nhập', N'19-12-2017 1:28:53 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1195, N'admin', N'Kho hàng', N'Xem danh sách kho hàng', N'19-12-2017 1:29:32 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1196, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'19-12-2017 1:29:36 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1197, N'admin', N'Hệ thống', N'Đăng nhập', N'19-12-2017 1:33:26 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1198, N'admin', N'Hệ thống', N'Đăng nhập', N'19-12-2017 1:34:34 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1199, N'admin', N'Hệ thống', N'Đăng nhập', N'19-12-2017 1:44:00 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1200, N'admin', N'Hệ thống', N'Đăng nhập', N'19-12-2017 1:46:06 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1201, N'admin', N'Hệ thống', N'Đăng nhập', N'19-12-2017 2:01:19 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1202, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'19-12-2017 2:01:22 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1203, N'admin', N'Hệ thống', N'Đăng nhập', N'19-12-2017 2:09:05 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1204, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'19-12-2017 2:09:08 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1205, N'admin', N'Hệ thống', N'Đăng nhập', N'19-12-2017 2:13:32 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1206, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'19-12-2017 2:13:37 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1207, N'admin', N'Hệ thống', N'Đăng nhập', N'19-12-2017 2:21:12 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1208, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'19-12-2017 2:21:15 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1209, N'admin', N'Hệ thống', N'Đăng nhập', N'19-12-2017 2:42:03 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1210, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'19-12-2017 2:42:05 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1211, N'admin', N'Nhân viên', N'Xem danh sách nhân viên', N'19-12-2017 2:44:48 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1212, N'admin', N'Hệ thống', N'Đăng nhập', N'21-12-2017 2:20:32 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1213, N'admin', N'Hệ thống', N'Đăng nhập', N'21-12-2017 2:38:08 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1214, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'21-12-2017 2:38:15 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1215, N'admin', N'Hệ thống', N'Đăng nhập', N'21-12-2017 4:30:58 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1216, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'21-12-2017 4:31:02 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1217, N'admin', N'Nhân viên', N'Xem danh sách nhân viên', N'21-12-2017 4:31:32 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1218, N'admin', N'Kho hàng', N'Xem danh sách kho hàng', N'21-12-2017 4:31:34 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1219, N'admin', N'Hệ thống', N'Đăng nhập', N'22-12-2017 5:46:20 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1220, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'22-12-2017 5:46:24 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1221, N'admin', N'Hàng hóa', N'Sửa hàng hóa', N'22-12-2017 5:46:52 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1222, N'admin', N'Hàng hóa', N'Sửa hàng hóa', N'22-12-2017 5:47:07 AM')
GO
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1223, N'admin', N'Nhóm hàng', N'Xem danh sách nhóm hàng', N'22-12-2017 5:47:20 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1224, N'admin', N'Hàng hóa', N'Sửa hàng hóa', N'22-12-2017 5:48:37 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1225, N'admin', N'Hệ thống', N'Đăng nhập', N'22-12-2017 5:49:32 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1226, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'22-12-2017 5:49:36 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1227, N'admin', N'Hàng hóa', N'Sửa hàng hóa', N'22-12-2017 5:50:01 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1228, N'admin', N'Hệ thống', N'Đăng nhập', N'22-12-2017 5:50:34 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1229, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'22-12-2017 5:50:37 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1230, N'admin', N'Hàng hóa', N'Sửa hàng hóa', N'22-12-2017 5:50:49 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1231, N'admin', N'Hàng hóa', N'Sửa hàng hóa', N'22-12-2017 5:51:36 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1232, N'admin', N'Hệ thống', N'Đăng nhập', N'22-12-2017 5:53:47 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1233, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'22-12-2017 5:53:50 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1234, N'admin', N'Hệ thống', N'Đăng nhập', N'22-12-2017 6:30:16 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1235, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'22-12-2017 6:30:19 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1236, N'admin', N'Hệ thống', N'Đăng nhập', N'22-12-2017 6:30:55 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1237, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'22-12-2017 6:31:00 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1238, N'admin', N'Hệ thống', N'Đăng nhập', N'22-12-2017 6:31:22 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1239, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'22-12-2017 6:31:27 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1240, N'admin', N'Hệ thống', N'Đăng nhập', N'23-12-2017 8:41:55 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1241, N'admin', N'Hệ thống', N'Đăng nhập', N'23-12-2017 8:44:05 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1242, N'admin', N'Hệ thống', N'Đăng nhập', N'23-12-2017 8:58:31 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1243, N'admin', N'Hệ thống', N'Đăng nhập', N'23-12-2017 9:00:49 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1244, N'admin', N'Hệ thống', N'Đăng nhập', N'24-12-2017 9:47:32 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1245, N'admin', N'Hệ thống', N'Đăng nhập', N'24-12-2017 9:48:35 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1246, N'tienngoc', N'Hệ thống', N'Đăng nhập', N'24-12-2017 9:53:17 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1247, N'tienngoc', N'Hệ thống', N'Đăng nhập', N'24-12-2017 9:53:33 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1248, N'admin', N'Hệ thống', N'Đăng nhập', N'24-12-2017 9:59:30 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1249, N'admin', N'Hệ thống', N'Đăng nhập', N'24-12-2017 10:02:17 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1250, N'admin', N'Hệ thống', N'Đăng nhập', N'24-12-2017 10:03:42 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1251, N'admin', N'Hệ thống', N'Đăng nhập', N'24-12-2017 10:05:05 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1252, N'admin', N'Hệ thống', N'Đăng nhập', N'24-12-2017 10:06:35 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1253, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'24-12-2017 10:06:39 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1254, N'admin', N'Hàng hóa', N'Sửa hàng hóa', N'24-12-2017 10:06:51 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1255, N'admin', N'Nhóm hàng', N'Xem danh sách nhóm hàng', N'24-12-2017 10:06:56 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1256, N'admin', N'Nhân viên', N'Xem danh sách nhân viên', N'24-12-2017 10:07:00 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1257, N'admin', N'Hệ thống', N'Đăng nhập', N'24-12-2017 10:41:09 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1258, N'admin', N'Hệ thống', N'Đăng nhập', N'24-12-2017 10:42:38 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1259, N'admin', N'Hệ thống', N'Đăng nhập', N'24-12-2017 10:54:33 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1260, N'admin', N'Hệ thống', N'Đăng nhập', N'26-12-2017 9:23:27 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1261, N'admin', N'Hệ thống', N'Đăng nhập', N'26-12-2017 9:33:50 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1262, N'admin', N'Hệ thống', N'Đăng nhập', N'26-12-2017 9:34:24 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1263, N'admin', N'Hệ thống', N'Đăng nhập', N'26-12-2017 9:35:49 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1264, N'admin', N'Hệ thống', N'Đăng nhập', N'26-12-2017 9:36:50 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1265, N'admin', N'Hệ thống', N'Đăng nhập', N'26-12-2017 9:37:06 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1266, N'admin', N'Hệ thống', N'Đăng nhập', N'26-12-2017 9:37:20 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1267, N'admin', N'Hệ thống', N'Đăng nhập', N'26-12-2017 9:38:40 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1268, N'admin', N'Hệ thống', N'Đăng nhập', N'26-12-2017 9:39:42 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1269, N'admin', N'Hệ thống', N'Đăng nhập', N'26-12-2017 9:41:43 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1270, N'admin', N'Hệ thống', N'Đăng nhập', N'26-12-2017 10:04:05 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1271, N'admin', N'Hệ thống', N'Đăng nhập', N'26-12-2017 10:18:07 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1272, N'admin', N'Hệ thống', N'Đăng nhập', N'26-12-2017 10:18:55 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1273, N'admin', N'Hệ thống', N'Đăng nhập', N'26-12-2017 10:36:13 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1274, N'admin', N'Hệ thống', N'Đăng nhập', N'26-12-2017 10:51:24 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1275, N'admin', N'Hệ thống', N'Đăng nhập', N'26-12-2017 9:30:10 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1276, N'admin', N'Hệ thống', N'Đăng nhập', N'26-12-2017 9:47:35 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1277, N'admin', N'Hệ thống', N'Đăng nhập', N'26-12-2017 9:49:26 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1278, N'admin', N'Hệ thống', N'Đăng nhập', N'26-12-2017 9:56:51 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1279, N'admin', N'Hệ thống', N'Đăng nhập', N'26-12-2017 10:01:15 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (1280, N'admin', N'Hệ thống', N'Đăng nhập', N'26-12-2017 10:06:37 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2237, N'admin', N'Hệ thống', N'Đăng nhập', N'30-12-2017 10:19:24 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2238, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 12:41:32 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2239, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 12:43:00 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2240, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 12:43:58 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2241, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 12:44:55 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2242, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 12:45:53 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2243, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 12:48:30 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2244, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 1:00:59 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2245, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 3:08:50 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2246, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 3:11:57 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2247, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 3:19:37 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2248, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 3:55:49 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2249, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 4:05:19 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2250, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 4:07:01 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2251, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 4:11:24 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2252, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 4:12:35 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2253, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 4:13:22 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2254, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 4:17:05 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2255, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 4:19:00 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2256, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 4:23:29 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2257, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 4:31:51 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2258, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 4:37:20 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2259, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 4:38:52 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2260, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 4:39:36 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2261, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 4:40:45 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2262, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 4:50:20 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2263, N'admin', N'Hệ thống', N'Đăng nhập', N'31-12-2017 4:52:31 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2264, N'admin', N'Hệ thống', N'Đăng nhập', N'01-1-2018 4:28:48 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2265, N'admin', N'Hệ thống', N'Đăng nhập', N'01-1-2018 4:36:43 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2266, N'admin', N'Hệ thống', N'Đăng nhập', N'01-1-2018 4:38:22 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2267, N'admin', N'Hệ thống', N'Đăng nhập', N'01-1-2018 4:53:31 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2268, N'admin', N'Hệ thống', N'Đăng nhập', N'01-1-2018 5:13:51 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2269, N'admin', N'Hệ thống', N'Đăng nhập', N'01-1-2018 5:16:10 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2270, N'admin', N'Hệ thống', N'Đăng nhập', N'01-1-2018 5:33:03 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2271, N'admin', N'Hệ thống', N'Đăng nhập', N'01-1-2018 5:36:35 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2272, N'admin', N'Hệ thống', N'Đăng nhập', N'01-1-2018 8:57:43 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2273, N'admin', N'Hệ thống', N'Đăng nhập', N'01-1-2018 9:44:29 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2274, N'admin', N'Hệ thống', N'Đăng nhập', N'01-1-2018 9:50:37 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2275, N'admin', N'Hệ thống', N'Đăng nhập', N'01-1-2018 9:52:52 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2276, N'admin', N'Hệ thống', N'Đăng nhập', N'01-1-2018 9:55:54 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2277, N'admin', N'Hệ thống', N'Đăng nhập', N'01-1-2018 10:00:03 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2278, N'admin', N'Hệ thống', N'Đăng nhập', N'01-1-2018 10:03:03 PM')
GO
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2279, N'admin', N'Hệ thống', N'Đăng nhập', N'01-1-2018 10:05:29 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2280, N'admin', N'Hệ thống', N'Đăng nhập', N'01-1-2018 10:08:03 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2281, N'admin', N'Hệ thống', N'Đăng nhập', N'01-1-2018 10:14:47 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2282, N'admin', N'Hệ thống', N'Đăng nhập', N'01-1-2018 10:21:33 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2283, N'admin', N'Hệ thống', N'Đăng nhập', N'01-1-2018 10:23:02 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2284, N'admin', N'Hệ thống', N'Đăng nhập', N'01-1-2018 10:23:47 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2285, N'admin', N'Hệ thống', N'Đăng nhập', N'01-1-2018 10:28:21 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2286, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 1:37:09 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2287, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 1:39:34 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2288, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 1:47:43 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2289, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 1:48:44 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2290, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 1:55:33 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2291, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 1:59:52 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2292, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'04-1-2018 2:00:05 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2293, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 2:03:47 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2294, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 2:06:57 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2295, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'04-1-2018 2:07:20 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2296, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 2:08:07 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2297, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'04-1-2018 2:08:11 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2298, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 2:09:54 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2299, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'04-1-2018 2:09:57 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2300, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 2:14:52 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2301, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'04-1-2018 2:14:57 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2302, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 2:17:31 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2303, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'04-1-2018 2:17:36 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2304, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 2:22:08 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2305, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'04-1-2018 2:22:11 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2306, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 2:28:07 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2307, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'04-1-2018 2:28:10 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2308, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 2:33:31 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2309, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'04-1-2018 2:33:36 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2310, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 2:35:46 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2311, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'04-1-2018 2:35:49 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2312, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 2:46:35 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2313, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 2:51:37 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2314, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'04-1-2018 2:51:40 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2315, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 2:52:45 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2316, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'04-1-2018 2:52:48 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2317, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 2:56:05 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2318, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'04-1-2018 2:56:08 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2319, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 2:58:51 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2320, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'04-1-2018 2:58:55 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2321, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 3:03:49 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2322, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'04-1-2018 3:03:54 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2323, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 3:04:18 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2324, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'04-1-2018 3:04:21 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2325, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 3:07:28 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2326, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'04-1-2018 3:07:32 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2327, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 3:10:36 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2328, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'04-1-2018 3:10:39 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2329, N'admin', N'Hàng hóa', N'Sửa hàng hóa', N'04-1-2018 3:11:00 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2330, N'admin', N'Hệ thống', N'Đăng nhập', N'04-1-2018 3:13:26 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2331, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 4:45:36 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2332, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 4:46:39 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2333, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 4:49:14 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2334, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 4:52:36 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2335, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'07-1-2018 4:52:44 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2336, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 4:54:02 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2337, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'07-1-2018 4:54:09 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2338, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 4:55:17 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2339, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 4:55:53 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2340, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 5:46:13 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2341, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 5:46:55 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2342, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 5:47:52 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2343, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 5:48:53 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2344, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 5:49:51 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2345, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 5:51:06 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2346, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 5:57:28 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2347, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 6:01:09 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2348, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 6:02:39 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2349, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 6:03:34 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2350, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 6:05:14 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2351, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 6:07:27 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2352, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 6:08:40 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2353, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 6:13:52 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2354, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 6:16:57 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2355, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 6:17:46 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2356, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 6:18:22 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2357, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 6:19:24 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2358, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 6:20:11 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2359, N'admin', N'Hệ thống', N'Đăng nhập', N'07-1-2018 6:20:55 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2360, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 12:25:52 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2361, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 12:25:59 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2362, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 12:26:20 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2363, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 12:26:47 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2364, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 12:35:27 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2365, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 12:46:47 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2366, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 12:52:10 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2367, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 12:53:34 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2368, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 12:55:31 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2369, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 12:56:36 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2370, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 12:58:20 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2371, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 1:00:08 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2372, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 1:00:51 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2373, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 1:43:48 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2374, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 1:46:06 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2375, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 1:47:08 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2376, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 1:50:07 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2377, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 1:50:49 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2378, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 1:53:44 AM')
GO
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2379, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 1:54:27 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2380, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 1:54:56 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2381, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 1:56:03 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2382, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 1:56:50 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2383, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 1:58:17 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2384, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 1:58:52 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2385, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 2:00:08 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2386, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 2:02:25 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2387, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 7:35:43 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2388, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 7:37:54 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2389, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 7:39:03 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2390, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 7:41:02 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2391, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 7:42:00 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2392, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 7:42:26 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2393, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 7:43:06 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2394, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 8:05:46 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2395, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 8:06:59 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2396, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 8:12:20 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2397, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 8:14:39 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2398, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 8:20:02 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2399, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 8:21:29 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2400, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 8:32:46 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2401, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 8:33:57 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2402, N'admin', N'Hệ thống', N'Đăng nhập', N'08-1-2018 8:35:49 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2403, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:33:55 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2404, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:34:38 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2405, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:37:44 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2406, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:38:48 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2407, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:39:46 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2408, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:45:41 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2409, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:47:31 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2410, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:48:53 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2411, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:49:48 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2412, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:50:59 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2413, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:51:39 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2414, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:54:04 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2415, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:55:40 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2416, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:57:51 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2417, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 10:03:37 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2418, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 10:04:46 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2419, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 10:07:07 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2420, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 10:10:08 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2421, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 10:10:26 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2422, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 10:12:44 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2423, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 10:15:28 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2424, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 10:20:36 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2425, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 10:22:45 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2426, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 10:23:49 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2427, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 10:28:52 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2428, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 10:34:48 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2429, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 10:37:30 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2430, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 10:38:16 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2431, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 10:41:37 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2432, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 10:42:42 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2433, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 10:43:52 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2434, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 10:48:48 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2435, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 10:53:35 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2436, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 10:54:58 AM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2437, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:13:34 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2438, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:18:26 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2439, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:19:30 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2440, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:19:58 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2441, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:20:17 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2442, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:21:51 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2443, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:22:33 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2444, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:22:48 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2445, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:24:12 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2446, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:25:23 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2447, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:28:08 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2448, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:30:15 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2449, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:31:29 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2450, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:34:09 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2451, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:34:32 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2452, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:36:17 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2453, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:38:59 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2454, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:45:31 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2455, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:46:55 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2456, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:50:55 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2457, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:54:52 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2458, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:56:22 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2459, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 4:57:15 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2460, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 5:00:56 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2461, N'admin', N'Hệ thống', N'Đổi mật khẩu', N'09-1-2018 5:01:00 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2462, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 5:03:48 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2463, N'admin', N'Hệ thống', N'Đổi mật khẩu', N'09-1-2018 5:03:55 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2464, N'admin', N'Nhật ký hệ thống', N'Xem nhật ký', N'09-1-2018 5:04:03 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2465, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 5:06:46 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2466, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 5:09:02 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2467, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 5:12:54 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2468, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 5:15:10 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2469, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 5:15:41 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2470, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 5:18:58 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2471, N'admin', N'Kho hàng', N'Xem danh sách kho hàng', N'09-1-2018 5:19:01 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2472, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 5:19:13 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2473, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 5:19:18 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2474, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 5:19:24 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2475, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 5:20:01 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2476, N'tienngoc', N'Hệ thống', N'Đăng nhập', N'09-1-2018 5:20:17 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2477, N'soclo7ngay', N'Hệ thống', N'Đăng nhập', N'09-1-2018 5:28:20 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2478, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 5:28:51 PM')
GO
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2479, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 7:49:41 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2480, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 7:50:50 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2481, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 7:59:25 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2482, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 7:59:59 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2483, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 8:23:59 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2484, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 8:26:57 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2485, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 8:36:23 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2486, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 8:37:20 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2487, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 8:39:00 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2488, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 8:39:56 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2489, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 8:42:08 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2490, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 8:44:05 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2491, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 8:45:50 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2492, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 8:46:38 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2493, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 8:48:07 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2494, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 8:51:10 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2495, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 8:52:27 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2496, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 8:54:39 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2497, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 8:55:20 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2498, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 8:56:58 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2499, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:00:50 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2500, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:02:05 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2501, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:06:12 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2502, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:06:53 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2503, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:08:51 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2504, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:10:09 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2505, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:11:04 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2506, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:13:05 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2507, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:14:54 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2508, N'admin', N'Khu vực', N'Xem danh sách khu vực', N'09-1-2018 9:16:51 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2509, N'admin', N'Nhà cung cấp', N'Xem danh sách nhà cung cấp', N'09-1-2018 9:16:56 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2510, N'admin', N'Kho hàng', N'Xem danh sách kho hàng', N'09-1-2018 9:16:57 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2511, N'admin', N'Nhóm hàng', N'Xem danh sách nhóm hàng', N'09-1-2018 9:16:59 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2512, N'admin', N'Hàng hóa', N'Xem danh sách hàng hóa', N'09-1-2018 9:17:18 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2513, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:18:56 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2514, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:27:08 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2515, N'admin', N'Đơn vị', N'Xem danh sách đơn vị', N'09-1-2018 9:27:22 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2516, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:28:51 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2517, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:29:56 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2518, N'admin', N'Đơn vị', N'Xem danh sách đơn vị', N'09-1-2018 9:30:00 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2519, N'admin', N'Hệ thống', N'Đăng nhập', N'09-1-2018 9:30:21 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2520, N'admin', N'Đơn vị', N'Xem danh sách đơn vị', N'09-1-2018 9:30:26 PM')
INSERT [dbo].[LOG] ([MaNKHD], [TenNguoiDung], [ChucNang], [HanhDong], [ThoiGian]) VALUES (2521, N'admin', N'Kho hàng', N'Xem danh sách kho hàng', N'09-1-2018 9:30:41 PM')
SET IDENTITY_INSERT [dbo].[LOG] OFF
SET IDENTITY_INSERT [dbo].[NGUOIDUNG] ON 

INSERT [dbo].[NGUOIDUNG] ([MaNguoiDung], [Ten], [TaiKhoan], [MatKhau], [XacNhan], [VaiTro], [GhiChu]) VALUES (1, N'Trương Tiến Ngọc', N'tienngoc', N'tienngoc', N'tienngoc', 1, N'Admin')
INSERT [dbo].[NGUOIDUNG] ([MaNguoiDung], [Ten], [TaiKhoan], [MatKhau], [XacNhan], [VaiTro], [GhiChu]) VALUES (3, N'Trần Bình Liêu', N'soclo7ngay', N'soclo7ngay', N'admin', 2, N'Bán Hàng')
INSERT [dbo].[NGUOIDUNG] ([MaNguoiDung], [Ten], [TaiKhoan], [MatKhau], [XacNhan], [VaiTro], [GhiChu]) VALUES (4, N'Huỳnh Lâm Tấn Phát', N'quaykhongnghi', N'quaykhongnghi', N'admin', 2, N'Bán Hàng')
INSERT [dbo].[NGUOIDUNG] ([MaNguoiDung], [Ten], [TaiKhoan], [MatKhau], [XacNhan], [VaiTro], [GhiChu]) VALUES (5, N'Admin', N'admin', N'123456', N'admin', 1, N'Admin')
INSERT [dbo].[NGUOIDUNG] ([MaNguoiDung], [Ten], [TaiKhoan], [MatKhau], [XacNhan], [VaiTro], [GhiChu]) VALUES (6, N'Khách Hàng', N'123456', N'123456', NULL, 3, N'')
SET IDENTITY_INSERT [dbo].[NGUOIDUNG] OFF
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTen], [ChucVu], [DiaChi], [Email], [DienThoai], [DiDong], [BoPhan], [QuanLy], [ConQuanLy]) VALUES (1, N'Trương Long', N'Giám Đốc', N'25/5 Điện Biên Phủ, Quận 1, TP Hồ Chí Minh', N'                                                                                                                                                                                                                                                               ', N'0163987231          ', N'0963473249          ', 1, 6, 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTen], [ChucVu], [DiaChi], [Email], [DienThoai], [DiDong], [BoPhan], [QuanLy], [ConQuanLy]) VALUES (3, N'Nguyễn Thị Minh  Huệ', N'', N'', N'huenguyen@hptvn.com                                                                                                                                                                                                                                            ', N'0946 980 408        ', N'0946 980 408        ', 3, 1, 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTen], [ChucVu], [DiaChi], [Email], [DienThoai], [DiDong], [BoPhan], [QuanLy], [ConQuanLy]) VALUES (4, N'Phan Quang Thông', N'', N'', N'quangthong@hptvn.com                                                                                                                                                                                                                                           ', N'0946 980 409        ', N'0946 980 409        ', 3, 4, 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTen], [ChucVu], [DiaChi], [Email], [DienThoai], [DiDong], [BoPhan], [QuanLy], [ConQuanLy]) VALUES (5, N'Nguyễn Hoàng Dũng', N'', N'', N'hoangdung@hptvn.com                                                                                                                                                                                                                                            ', N'0946 980 407        ', N'0946 980 407        ', 5, 3, 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTen], [ChucVu], [DiaChi], [Email], [DienThoai], [DiDong], [BoPhan], [QuanLy], [ConQuanLy]) VALUES (6, N'Vũ Anh Tuấn', N'', N'', N'director@hptvn.com                                                                                                                                                                                                                                             ', N'0909 668 443        ', N'0909 668 443        ', 1, 1, 1)
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
SET IDENTITY_INSERT [dbo].[NHAPHANPHOI] ON 

INSERT [dbo].[NHAPHANPHOI] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [MaSoThue], [SoDiDong], [SoDienThoaiBan], [Email], [Fax], [Website], [SoTaiKhoan], [NganHang], [GioiHanNo], [ChietKhau], [NguoiLenHe], [ChucVu], [NoHienTai], [KhuVuc], [ConQuanLy]) VALUES (1, N'Nhà cung cấp A', N'', N'                    ', N'                    ', N'                    ', N'                                                                                                                                                                                                                                                               ', N'                    ', N'                                                                                                                                                                                                                                                               ', N'                              ', N'', 2000000, 0, N'', N'', 50000, 2, 1)
INSERT [dbo].[NHAPHANPHOI] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [MaSoThue], [SoDiDong], [SoDienThoaiBan], [Email], [Fax], [Website], [SoTaiKhoan], [NganHang], [GioiHanNo], [ChietKhau], [NguoiLenHe], [ChucVu], [NoHienTai], [KhuVuc], [ConQuanLy]) VALUES (3, N'Nhà Cung Cấp B', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3000000, 3, NULL, NULL, 0, 1, 1)
INSERT [dbo].[NHAPHANPHOI] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [MaSoThue], [SoDiDong], [SoDienThoaiBan], [Email], [Fax], [Website], [SoTaiKhoan], [NganHang], [GioiHanNo], [ChietKhau], [NguoiLenHe], [ChucVu], [NoHienTai], [KhuVuc], [ConQuanLy]) VALUES (4, N'Nhà Cung Cấp E', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 15000000, 10, NULL, NULL, 2500000, 3, 1)
INSERT [dbo].[NHAPHANPHOI] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [MaSoThue], [SoDiDong], [SoDienThoaiBan], [Email], [Fax], [Website], [SoTaiKhoan], [NganHang], [GioiHanNo], [ChietKhau], [NguoiLenHe], [ChucVu], [NoHienTai], [KhuVuc], [ConQuanLy]) VALUES (5, N'Nhà Cung Cấp N', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 30000000, 2, NULL, NULL, 1000000, 2, 1)
SET IDENTITY_INSERT [dbo].[NHAPHANPHOI] OFF
SET IDENTITY_INSERT [dbo].[NHOMHANG] ON 

INSERT [dbo].[NHOMHANG] ([MaNhomHang], [TenNhomHang], [GhiChu], [ConQuanLy]) VALUES (1, N'Dụng cụ học tập', N'', 0)
INSERT [dbo].[NHOMHANG] ([MaNhomHang], [TenNhomHang], [GhiChu], [ConQuanLy]) VALUES (2, N'Dụng cụ sinh hoạt', N'', 0)
INSERT [dbo].[NHOMHANG] ([MaNhomHang], [TenNhomHang], [GhiChu], [ConQuanLy]) VALUES (3, N'Sách giáo khoa', N'', 0)
INSERT [dbo].[NHOMHANG] ([MaNhomHang], [TenNhomHang], [GhiChu], [ConQuanLy]) VALUES (4, N'Chăm sóc sức khỏe', N'', 0)
SET IDENTITY_INSERT [dbo].[NHOMHANG] OFF
SET IDENTITY_INSERT [dbo].[TYGIA] ON 

INSERT [dbo].[TYGIA] ([MaTyGia], [TenTyGia], [TyGiaQuyDoi], [ConQuanLy]) VALUES (1, N'VND', 1, 1)
INSERT [dbo].[TYGIA] ([MaTyGia], [TenTyGia], [TyGiaQuyDoi], [ConQuanLy]) VALUES (2, N'USD', 25000, 1)
INSERT [dbo].[TYGIA] ([MaTyGia], [TenTyGia], [TyGiaQuyDoi], [ConQuanLy]) VALUES (3, N'Euro', 30000, 1)
SET IDENTITY_INSERT [dbo].[TYGIA] OFF
SET IDENTITY_INSERT [dbo].[VAITRO] ON 

INSERT [dbo].[VAITRO] ([MaVaiTro], [Ten], [PhanQuyen], [DoiMatKhau], [NhatKyHeThong], [SaoLuu], [PhucHoi], [KhuVuc], [KhachHang], [NhaCungCap], [KhoHang], [DonViTinh], [NhomHang], [HangHoa], [TyGia], [BoPhan], [NhanVien], [MuaHang], [BanHang], [TonKho], [ChuyenKho], [ThuTien], [TraTien], [BaoCaoKhohang], [BaoCaoBanHang]) VALUES (1, N'Quản trị', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO] ([MaVaiTro], [Ten], [PhanQuyen], [DoiMatKhau], [NhatKyHeThong], [SaoLuu], [PhucHoi], [KhuVuc], [KhachHang], [NhaCungCap], [KhoHang], [DonViTinh], [NhomHang], [HangHoa], [TyGia], [BoPhan], [NhanVien], [MuaHang], [BanHang], [TonKho], [ChuyenKho], [ThuTien], [TraTien], [BaoCaoKhohang], [BaoCaoBanHang]) VALUES (2, N'Bán hàng', 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[VAITRO] ([MaVaiTro], [Ten], [PhanQuyen], [DoiMatKhau], [NhatKyHeThong], [SaoLuu], [PhucHoi], [KhuVuc], [KhachHang], [NhaCungCap], [KhoHang], [DonViTinh], [NhomHang], [HangHoa], [TyGia], [BoPhan], [NhanVien], [MuaHang], [BanHang], [TonKho], [ChuyenKho], [ThuTien], [TraTien], [BaoCaoKhohang], [BaoCaoBanHang]) VALUES (3, N'Khách Hàng', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[VAITRO] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [TaiKhoan_Unique]    Script Date: 09-1-2018 9:32:46 PM ******/
ALTER TABLE [dbo].[NGUOIDUNG] ADD  CONSTRAINT [TaiKhoan_Unique] UNIQUE NONCLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CHITIETCHUYENKHO]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETCHUYENKHO_HANGHOA] FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HANGHOA] ([MaHangHoa])
GO
ALTER TABLE [dbo].[CHITIETCHUYENKHO] CHECK CONSTRAINT [FK_CHITIETCHUYENKHO_HANGHOA]
GO
ALTER TABLE [dbo].[CHITIETCHUYENKHO]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETCHUYENKHO_PHIEUCHUYENKHO] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PHIEUCHUYENKHO] ([MaPhieu])
GO
ALTER TABLE [dbo].[CHITIETCHUYENKHO] CHECK CONSTRAINT [FK_CHITIETCHUYENKHO_PHIEUCHUYENKHO]
GO
ALTER TABLE [dbo].[CONGNO_KH]  WITH CHECK ADD  CONSTRAINT [FK_CONGNO_KH_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[CONGNO_KH] CHECK CONSTRAINT [FK_CONGNO_KH_KHACHHANG]
GO
ALTER TABLE [dbo].[CONGNO_NCC]  WITH CHECK ADD  CONSTRAINT [FK_CONGNO_NCC_NHAPHANPHOI] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NHAPHANPHOI] ([MaNhaPhanPhoi])
GO
ALTER TABLE [dbo].[CONGNO_NCC] CHECK CONSTRAINT [FK_CONGNO_NCC_NHAPHANPHOI]
GO
ALTER TABLE [dbo].[CTMUAHANG]  WITH CHECK ADD  CONSTRAINT [FK_CTMUAHANG_HANGHOA] FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HANGHOA] ([MaHangHoa])
GO
ALTER TABLE [dbo].[CTMUAHANG] CHECK CONSTRAINT [FK_CTMUAHANG_HANGHOA]
GO
ALTER TABLE [dbo].[CTMUAHANG]  WITH CHECK ADD  CONSTRAINT [FK_CTMUAHANG_PHIEUNHAPHANG] FOREIGN KEY([MaPhieuMH])
REFERENCES [dbo].[PHIEUNHAPHANG] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[CTMUAHANG] CHECK CONSTRAINT [FK_CTMUAHANG_PHIEUNHAPHANG]
GO
ALTER TABLE [dbo].[CTXUATHANG]  WITH CHECK ADD  CONSTRAINT [FK_CTXUATHANG_HANGHOA] FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HANGHOA] ([MaHangHoa])
GO
ALTER TABLE [dbo].[CTXUATHANG] CHECK CONSTRAINT [FK_CTXUATHANG_HANGHOA]
GO
ALTER TABLE [dbo].[CTXUATHANG]  WITH CHECK ADD  CONSTRAINT [FK_CTXUATHANG_PHIEUXUATHANG] FOREIGN KEY([MaPhieuXuat])
REFERENCES [dbo].[PHIEUXUATHANG] ([MaPhieuXuat])
GO
ALTER TABLE [dbo].[CTXUATHANG] CHECK CONSTRAINT [FK_CTXUATHANG_PHIEUXUATHANG]
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD  CONSTRAINT [FK_HANGHOA_DONVI] FOREIGN KEY([DonVi])
REFERENCES [dbo].[DONVI] ([MaDV])
GO
ALTER TABLE [dbo].[HANGHOA] CHECK CONSTRAINT [FK_HANGHOA_DONVI]
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD  CONSTRAINT [FK_HANGHOA_KHO1] FOREIGN KEY([KhoMacDinh])
REFERENCES [dbo].[KHO] ([MaKho])
GO
ALTER TABLE [dbo].[HANGHOA] CHECK CONSTRAINT [FK_HANGHOA_KHO1]
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD  CONSTRAINT [FK_HANGHOA_LOAIHANGHOA] FOREIGN KEY([LoaiHangHoa])
REFERENCES [dbo].[LOAIHANGHOA] ([MaLoaiHH])
GO
ALTER TABLE [dbo].[HANGHOA] CHECK CONSTRAINT [FK_HANGHOA_LOAIHANGHOA]
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD  CONSTRAINT [FK_HANGHOA_NHAPHANPHOI] FOREIGN KEY([NhaCungCap])
REFERENCES [dbo].[NHAPHANPHOI] ([MaNhaPhanPhoi])
GO
ALTER TABLE [dbo].[HANGHOA] CHECK CONSTRAINT [FK_HANGHOA_NHAPHANPHOI]
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD  CONSTRAINT [FK_HANGHOA_NHOMHANG] FOREIGN KEY([PhanLoai])
REFERENCES [dbo].[NHOMHANG] ([MaNhomHang])
GO
ALTER TABLE [dbo].[HANGHOA] CHECK CONSTRAINT [FK_HANGHOA_NHOMHANG]
GO
ALTER TABLE [dbo].[KHACHHANG]  WITH CHECK ADD  CONSTRAINT [FK_KHACHHANG_KHUVUC] FOREIGN KEY([KhuVuc])
REFERENCES [dbo].[KHUVUC] ([MaKhuVuc])
GO
ALTER TABLE [dbo].[KHACHHANG] CHECK CONSTRAINT [FK_KHACHHANG_KHUVUC]
GO
ALTER TABLE [dbo].[KHACHHANG]  WITH CHECK ADD  CONSTRAINT [FK_KHACHHANG_LOAIKHACHHANG] FOREIGN KEY([LoaiKhachHang])
REFERENCES [dbo].[LOAIKHACHHANG] ([MaLoaiKH])
GO
ALTER TABLE [dbo].[KHACHHANG] CHECK CONSTRAINT [FK_KHACHHANG_LOAIKHACHHANG]
GO
ALTER TABLE [dbo].[KHO]  WITH CHECK ADD  CONSTRAINT [FK_KHO_NHANVIEN] FOREIGN KEY([NVQuanLy])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[KHO] CHECK CONSTRAINT [FK_KHO_NHANVIEN]
GO
ALTER TABLE [dbo].[KHO_HANGHOA]  WITH CHECK ADD  CONSTRAINT [FK_KHO_HANGHOA_HANGHOA] FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HANGHOA] ([MaHangHoa])
GO
ALTER TABLE [dbo].[KHO_HANGHOA] CHECK CONSTRAINT [FK_KHO_HANGHOA_HANGHOA]
GO
ALTER TABLE [dbo].[KHO_HANGHOA]  WITH CHECK ADD  CONSTRAINT [FK_KHO_HANGHOA_KHO] FOREIGN KEY([MaKho])
REFERENCES [dbo].[KHO] ([MaKho])
GO
ALTER TABLE [dbo].[KHO_HANGHOA] CHECK CONSTRAINT [FK_KHO_HANGHOA_KHO]
GO
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK__NGUOIDUNG__VaiTr__498EEC8D] FOREIGN KEY([VaiTro])
REFERENCES [dbo].[VAITRO] ([MaVaiTro])
GO
ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [FK__NGUOIDUNG__VaiTr__498EEC8D]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_BOPHAN] FOREIGN KEY([BoPhan])
REFERENCES [dbo].[BOPHAN] ([MaBoPhan])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_BOPHAN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_NHANVIEN] FOREIGN KEY([QuanLy])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_NHANVIEN]
GO
ALTER TABLE [dbo].[NHAPHANPHOI]  WITH CHECK ADD  CONSTRAINT [FK_NHAPHANPHOI_KHUVUC] FOREIGN KEY([KhuVuc])
REFERENCES [dbo].[KHUVUC] ([MaKhuVuc])
GO
ALTER TABLE [dbo].[NHAPHANPHOI] CHECK CONSTRAINT [FK_NHAPHANPHOI_KHUVUC]
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUCHUYENKHO_KHO] FOREIGN KEY([KhoNhan])
REFERENCES [dbo].[KHO] ([MaKho])
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO] CHECK CONSTRAINT [FK_PHIEUCHUYENKHO_KHO]
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUCHUYENKHO_KHO1] FOREIGN KEY([KhoXuat])
REFERENCES [dbo].[KHO] ([MaKho])
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO] CHECK CONSTRAINT [FK_PHIEUCHUYENKHO_KHO1]
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUCHUYENKHO_NHANVIEN] FOREIGN KEY([NguoiChuyen])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO] CHECK CONSTRAINT [FK_PHIEUCHUYENKHO_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUCHUYENKHO_NHANVIEN1] FOREIGN KEY([NguoiNhan])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUCHUYENKHO] CHECK CONSTRAINT [FK_PHIEUCHUYENKHO_NHANVIEN1]
GO
ALTER TABLE [dbo].[PHIEUNHAPHANG]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAPHANG_KHO] FOREIGN KEY([KhoNhap])
REFERENCES [dbo].[KHO] ([MaKho])
GO
ALTER TABLE [dbo].[PHIEUNHAPHANG] CHECK CONSTRAINT [FK_PHIEUNHAPHANG_KHO]
GO
ALTER TABLE [dbo].[PHIEUNHAPHANG]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAPHANG_NHANVIEN] FOREIGN KEY([NVPhuTrach])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUNHAPHANG] CHECK CONSTRAINT [FK_PHIEUNHAPHANG_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUNHAPHANG]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAPHANG_NHAPHANPHOI] FOREIGN KEY([NhaCC])
REFERENCES [dbo].[NHAPHANPHOI] ([MaNhaPhanPhoi])
GO
ALTER TABLE [dbo].[PHIEUNHAPHANG] CHECK CONSTRAINT [FK_PHIEUNHAPHANG_NHAPHANPHOI]
GO
/****** Object:  StoredProcedure [dbo].[KiemTraDangNhap]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KiemTraDangNhap]
@TaiKhoan varchar(50),
@MatKhau varchar(50), 
@ThanhCong bit out
as
begin
	if not exists (select *
					from NGUOIDUNG
					where TaiKhoan = @TaiKhoan and MatKhau = @MatKhau)
	begin
		set @ThanhCong = 'FALSE'
		return
	end
	set @ThanhCong = 'TRUE'
	return
end




GO
/****** Object:  StoredProcedure [dbo].[LayDanhSachNhatKyHeThong]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LayDanhSachNhatKyHeThong]
as
begin
	select nk.MaNKHD, nd.TaiKhoan, nk.ThoiGian, nk.ChucNang, nk.HanhDong, nk.ThoiGian
	from NGUOIDUNG nd, LOG nk
end




GO
/****** Object:  StoredProcedure [dbo].[LayTatCaHangHoa]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[LayTatCaHangHoa]
AS BEGIN
 SELECT MaHangHoa, TenHangHoa, TenDonVi, GiaMua, GiaBan, TonKhoToiThieu, TonKho, TenLoaiHH, TenNhomHang FROM dbo.HANGHOA, dbo.LOAIHANGHOA, dbo.LOAIKHACHHANG, dbo.DONVI, dbo.NHOMHANG
 WHERE MaDV= DonVi AND LoaiHangHoa= MaLoaiHH AND PhanLoai = MaNhomHang
END
GO
/****** Object:  StoredProcedure [dbo].[sp_BaoCaoChuyenKho]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_BaoCaoChuyenKho]
as begin
	select hh.MaHangHoa, hh.TenHangHoa,
	(select distinct TenKho from KHO k1 where k1.MaKho = pck.KhoXuat) as KhoXuat
	,(select distinct TenKho from KHO k2 where k2.MaKho = pck.KhoNhan) as KhoNhan
	, ctck.SoLuong, dv.TenDonVi, nh.TenNhomHang
	from HANGHOA hh, CHITIETCHUYENKHO ctck, NHOMHANG nh, DONVI dv, PHIEUCHUYENKHO pck
	where ctck.MaHangHoa = hh.MaHangHoa and hh.PhanLoai = nh.MaNhomHang and hh.DonVi = dv.MaDV and ctck.MaPhieu = pck.MaPhieu
	order by pck.MaPhieu
end




GO
/****** Object:  StoredProcedure [dbo].[sp_BaoCaoMuaHang_TheoNgay]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_BaoCaoMuaHang_TheoNgay]
as
begin
select nh.NgayNhap, SUM(TongTien) as TongTienMua, (Select SUM(TongTien)
									from PHIEUXUATHANG xh
									where xh.NgayXuat = nh.NgayNhap
									) as TongTienBan
from PHIEUNHAPHANG nh
group by nh.NgayNhap
end




GO
/****** Object:  StoredProcedure [dbo].[sp_BaoCaoNhapHangHoa]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_BaoCaoNhapHangHoa]
as begin
	select hh.MaHangHoa, hh.TenHangHoa, dv.TenDonVi, nh.TenNhomHang, sum(ctmh.SoLuong) as SoLuongNhap, sum(ctmh.ThanhTien) as TienChiTra
	from HANGHOA hh, CTMUAHANG ctmh, NHOMHANG nh, DONVI dv
	where ctmh.MaHangHoa = hh.MaHangHoa and hh.PhanLoai = nh.MaNhomHang and hh.DonVi = dv.MaDV
	group by hh.MaHangHoa, hh.TenHangHoa, dv.TenDonVi, nh.TenNhomHang
	order by MaHangHoa
end




GO
/****** Object:  StoredProcedure [dbo].[sp_BaoCaoXuatHangHoa]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_BaoCaoXuatHangHoa]
as begin
	select hh.MaHangHoa, hh.TenHangHoa, dv.TenDonVi, nh.TenNhomHang, sum(ctxh.SoLuong) as SoLuongXuat, sum(ctxh.ThanhTien) as TienThuDuoc
	from HANGHOA hh, CTXUATHANG ctxh, NHOMHANG nh, DONVI dv
	where ctxh.MaHangHoa = hh.MaHangHoa and hh.PhanLoai = nh.MaNhomHang and hh.DonVi = dv.MaDV
	group by hh.MaHangHoa, hh.TenHangHoa, dv.TenDonVi, nh.TenNhomHang
	order by MaHangHoa
end




GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatTonKho]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_CapNhatTonKho]
@MaHangHoa int
as begin
	declare @sl int
	set @sl = (select Sum(SoLuongTon) from KHO_HANGHOA where MaHangHoa = @MaHangHoa)
	update HANGHOA
	set TonKho = @sl
	where MaHangHoa = @MaHangHoa
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ChiPhiMuaHang_TheoNCC]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ChiPhiMuaHang_TheoNCC]
as
begin
	select pp.MaNhaPhanPhoi, pp.TenNhaPhanPhoi, kv.TenKhuVuc, SUM(nh.TongTien) as ChiPhi
	from PHIEUNHAPHANG nh, NHAPHANPHOI pp, KHUVUC kv
	where nh.NhaCC = pp.MaNhaPhanPhoi and kv.MaKhuVuc = pp.KhuVuc
	group by pp.MaNhaPhanPhoi, pp.TenNhaPhanPhoi, kv.TenKhuVuc
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ChonKhachHang]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ChonKhachHang]
as
begin
	select * from KHACHHANG
end




GO
/****** Object:  StoredProcedure [dbo].[sp_DoanhSoBanHang_TheoHH]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DoanhSoBanHang_TheoHH]
as
begin
	select h.MaHangHoa, h.TenHangHoa, dv.TenDonVi, nh.TenNhomHang, k.TenKho, SUM(ct.SoLuong) as SoLuong, SUM(ct.ThanhTien) as TongTienThu
from HANGHOA h, PHIEUXUATHANG x, CTXUATHANG ct, DONVI dv, NHOMHANG nh, KHO k
where x.MaPhieuXuat = ct.MaPhieuXuat
 and ct.MaHangHoa = h.MaHangHoa and h.DonVi = dv.MaDV
 and h.PhanLoai = nh.MaNhomHang and x.KhoXuat = k.MaKho
group by h.MaHangHoa, h.TenHangHoa, dv.TenDonVi, nh.TenNhomHang, k.TenKho
end




GO
/****** Object:  StoredProcedure [dbo].[sp_DoanhSoBanHang_TheoKH]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DoanhSoBanHang_TheoKH]
as
begin
	select kh.MaKH, kh.HoTen, kv.TenKhuVuc, SUM(xh.TongTien) as TongThu
	from PHIEUXUATHANG xh, KHACHHANG kh, KHUVUC kv
	where xh.MaKH = kh.MaKH and kv.MaKhuVuc = kh.KhuVuc
	group by kh.MaKH, kh.HoTen, kv.TenKhuVuc
end




GO
/****** Object:  StoredProcedure [dbo].[sp_DoanhSoBanHang_TheoNgay]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DoanhSoBanHang_TheoNgay]
as
begin
select nh.NgayXuat, SUM(TongTien) as TongTienBan, (Select SUM(TongTien)
									from PHIEUNHAPHANG xh
									where xh.NgayNhap = nh.NGAYXUAT
									) as TongTienMua
from PHIEUXUATHANG nh
group by nh.NgayXuat
end




GO
/****** Object:  StoredProcedure [dbo].[sp_DoanhSoBanHang_TheoNhanVien]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DoanhSoBanHang_TheoNhanVien]
as
begin
select nv.MaNhanVien, nv.HoTen, nv.DiaChi, nv.DienThoai,
 (select SUM(TongTien) from PHIEUNHAPHANG nh where nh.NVPhuTrach = nv.MaNhanVien) as TongTienMua
 ,(select SUM(TongTien) from PHIEUXUATHANG xh where  xh.NVBanHang = nv.MaNhanVien) as TongTienBan
from NHANVIEN nv
end




GO
/****** Object:  StoredProcedure [dbo].[sp_GiamNoKhachHang]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GiamNoKhachHang]
	@MaKH int,
	@SoTienGiam float
as
begin
	update KHACHHANG
	set NoHienTai = NoHienTai - @SoTienGiam
	where MaKH = @MaKH
end




GO
/****** Object:  StoredProcedure [dbo].[sp_GiamNoNhaCC]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GiamNoNhaCC]
@MaNCC int,
@SoTienGiam float
as begin
	update NHAPHANPHOI
	set NoHienTai = NoHienTai - @SoTienGiam
	where MaNhaPhanPhoi = @MaNCC
end




GO
/****** Object:  StoredProcedure [dbo].[sp_GiamSoLuongHangTonTrongKho]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GiamSoLuongHangTonTrongKho]
	@MaKho int,
	@MaHangHoa int, 
	@SoLuong int
as
begin
	update KHO_HANGHOA
	set SoLuongTon = SoLuongTon - @SoLuong
	where MaKho = @MaKho and MaHangHoa = @MaHangHoa
end




GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraDangNhap]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_KiemTraDangNhap]
  @tk varchar(50),
  @mk varchar(50),
  @check bit out
  as begin
	if exists (select * from NGUOIDUNG where TaiKhoan = @tk and MatKhau = @mk)
		set @check = 1
	else
		set @check = 0
  end




GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachCongNoTheoKH]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDanhSachCongNoTheoKH]
as
begin
select khachhang.MaKH, HoTen, NgayPhatSinh, NoPhatSinh, DaThu, ConLai, LoaiPhatSinh
from CONGNO_KH, KHACHHANG
where CONGNO_KH.MaKH = KHACHHANG.MaKH
order by MaKH, CONGNO_KH.ID
end




GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachCongNoTheoNCC]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDanhSachCongNoTheoNCC]
as begin
	select ncc.MaNhaPhanPhoi, ncc.TenNhaPhanPhoi, cn.NgayPhatSinh, cn.No, cn.DaThu, cn.ConLai, LoaiPhatSinh
	from NHAPHANPHOI ncc, CONGNO_NCC cn
	where ncc.MaNhaPhanPhoi = cn.MaNCC
	order by ncc.MaNhaPhanPhoi, cn.ID
end




GO
/****** Object:  StoredProcedure [dbo].[sp_LayDuLieuNhaCungCap]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDuLieuNhaCungCap]
as
begin
	select * from NHAPHANPHOI
end




GO
/****** Object:  StoredProcedure [dbo].[sp_LayHangHoaTheoKHo]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LayHangHoaTheoKHo]
	@MaKho INT
AS
BEGIN
	SELECT hh.MaHangHoa, hh.TenHangHoa, SoLuongTon, hh.GiaMua
	FROM KHO_HANGHOA k_hh, HANGHOA hh
	WHERE k_hh.MaKho = @MaKho AND k_hh.MaHangHoa = hh.MaHangHoa
END

GO
/****** Object:  StoredProcedure [dbo].[sp_LayHetNguoiDung]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayHetNguoiDung]
 as
 begin
	select * from NGUOIDUNG
 end




GO
/****** Object:  StoredProcedure [dbo].[sp_LayHetVaiTro]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayHetVaiTro]
 as
 begin
	select * from VAITRO
 end




GO
/****** Object:  StoredProcedure [dbo].[sp_LayMaHangHoaMoiNhat]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_LayMaHangHoaMoiNhat]
@MaHangHoa int out
as
begin
	select @MaHangHoa = Max(MaHangHoa)
	from HANGHOA
end




GO
/****** Object:  StoredProcedure [dbo].[sp_LayMaKhoMoiNhat]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_LayMaKhoMoiNhat]
	@MaKho int out
as
begin
	select @MaKho =  MAX(MaKho)
	from Kho
end




GO
/****** Object:  StoredProcedure [dbo].[sp_LayMaVaTenKhoHang]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayMaVaTenKhoHang]
as begin
	select MaKho, TenKho from KHO
end




GO
/****** Object:  StoredProcedure [dbo].[sp_LayTatCaBoPhan]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayTatCaBoPhan]
as
begin
	select * from BOPHAN
end




GO
/****** Object:  StoredProcedure [dbo].[sp_LayTatCaDonVi]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayTatCaDonVi]
as
begin
	select * from DONVI
end




GO
/****** Object:  StoredProcedure [dbo].[sp_LayTatCaHangHoa]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayTatCaHangHoa]
as
begin
select * from HANGHOA
end




GO
/****** Object:  StoredProcedure [dbo].[sp_LayTatCaKhoHang]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayTatCaKhoHang]
as
begin
	select * from KHO
end




GO
/****** Object:  StoredProcedure [dbo].[sp_LayTatCaKhuVuc]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_LayTatCaKhuVuc]
as begin
	select * from KHUVUC
end




GO
/****** Object:  StoredProcedure [dbo].[sp_LayTatCaLoaiHang]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayTatCaLoaiHang]
as
begin
select * from LOAIHANGHOA
end




GO
/****** Object:  StoredProcedure [dbo].[sp_LayTatCaNhanVien]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayTatCaNhanVien]
as
begin
	select * from NHANVIEN
end




GO
/****** Object:  StoredProcedure [dbo].[sp_LayTatCaNhomHang]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayTatCaNhomHang]
as begin
	select * from NHOMHANG
end




GO
/****** Object:  StoredProcedure [dbo].[sp_LayTatCaTyGia]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayTatCaTyGia]
as begin
	select * from TYGIA
end




GO
/****** Object:  StoredProcedure [dbo].[sp_LayThongTinHangHoaCanMuaTheoMa]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_LayThongTinHangHoaCanMuaTheoMa] @MaHangHoa INT
AS BEGIN
	SELECT hh.MaHangHoa, hh.TenHangHoa, hh.DonVi, hh.GiaMua FROM dbo.HANGHOA hh
	WHERE hh.MaHangHoa= @MaHangHoa
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LayVaiTroTheoMa]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayVaiTroTheoMa]
	@MaVaiTro int
  as
  begin
	select *
	from VAITRO
	where MaVaiTro = @MaVaiTro
  end




GO
/****** Object:  StoredProcedure [dbo].[sp_LayVaiTroTheoTaiKhoan]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_LayVaiTroTheoTaiKhoan]
	@TaiKhoan varchar(50)
  as
  begin
	select VAITRO.*
	from VAITRO, NGUOIDUNG
	where VAITRO.MaVaiTro = NGUOIDUNG.VaiTro and NGUOIDUNG.TaiKhoan = @TaiKhoan
  end




GO
/****** Object:  StoredProcedure [dbo].[sp_LoadLOG]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_LoadLOG]
as begin
	select * from LOG order by ThoiGian desc
end




GO
/****** Object:  StoredProcedure [dbo].[sp_LoiNhuanTheoHangHoa]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LoiNhuanTheoHangHoa]
as
begin
	select h.MaHangHoa, h.TenHangHoa, dv.TenDonVi, nh.TenNhomHang, k.TenKho,
	 SUM(ct.SoLuong) as SoLuong, SUM(ct.ThanhTien) as TongTienThu, h.GiaMua, 
	 SUM(ct.SoLuong)*h.giamua as TongTienMua, SUM(ct.ThanhTien) - SUM(ct.SoLuong)*h.giamua as LoiNhuan
	from HANGHOA h, PHIEUXUATHANG x, CTXUATHANG ct, DONVI dv, NHOMHANG nh, KHO k
	where x.MaPhieuXuat = ct.MaPhieuXuat
	 and ct.MaHangHoa = h.MaHangHoa and h.DonVi = dv.MaDV
	 and h.PhanLoai = nh.MaNhomHang and x.KhoXuat = k.MaKho
	group by h.MaHangHoa, h.TenHangHoa, dv.TenDonVi, nh.TenNhomHang, k.TenKho, h.GiaMua
end




GO
/****** Object:  StoredProcedure [dbo].[sp_SaoLuu]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SaoLuu]
@duongdan nvarchar(256)
as begin
	BACKUP DATABASE quanlybanhang
		TO DISK = @duongdan
		WITH FORMAT;
end




GO
/****** Object:  StoredProcedure [dbo].[sp_SuaBoPhan]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SuaBoPhan]
	@MaBoPhan int,
	@TenBoPhan nvarchar(255),
	@GhiChu nvarchar(255),
	@ConQuanLy bit
as
begin
	update BOPHAN
	set TenBoPhan = @TenBoPhan,GhiChu = @GhiChu,ConQuanLy = @ConQuanLy
	where MaBoPhan = @MaBoPhan
end




GO
/****** Object:  StoredProcedure [dbo].[sp_SuaDonVi]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SuaDonVi]
	@MaDV int,
	@TenDonVi nvarchar(255),
	@GhiChu nvarchar(255),
	@ConQuanLy bit
as 
begin
	update DONVI
	set TenDonVi = @TenDonVi, GhiChu = @GhiChu, ConQuanLy = @ConQuanLy
	where MaDV = @MaDV
end




GO
/****** Object:  StoredProcedure [dbo].[sp_SuaHangHoa]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SuaHangHoa]
	@MaHangHoa int,
	@TenHangHoa nvarchar(255),
	@LoaiHangHoa int, 
	@KhoMacDinh int,
	@PhanLoai int,
	@DonVi int,
	@XuatXu nvarchar(255),
	@TonKhoToiThieu int,
	@TonKho int,
	@NhaCungCap int, 
	@GiaMua float, 
	@GiaBan float,
	@ConQuanLy bit
	
as 
begin
	update HANGHOA
	set TenHangHoa = @TenHangHoa, LoaiHangHoa = @LoaiHangHoa,
	KhoMacDinh = @KhoMacDinh, PhanLoai = @PhanLoai, DonVi = @DonVi,
	XuatXu = @XuatXu, TonKhoToiThieu = @TonKhoToiThieu, TonKho = @TonKho, 
	NhaCungCap = @NhaCungCap, GiaMua = @GiaMua, GiaBan = @GiaBan, ConQuanLy = @ConQuanLy
	where MaHangHoa = @MaHangHoa
end




GO
/****** Object:  StoredProcedure [dbo].[sp_SuaKhoHang]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SuaKhoHang]
	@MaKho int,
	@TenKho nvarchar(255),
	@NVQuanLy int,
	@NguoiLienHe nvarchar(255),
	@DiaChi nvarchar(255), 
	@DienThoai char(20),
	@Fax char(20),
	@Email char(255),
	@DienGiai nvarchar(255),
	@ConQuanLy bit
as
begin
	update KHO
	set TenKho = @TenKho, NVQuanLy = @NVQuanLy, NguoiLienHe = @NguoiLienHe, DiaChi = @DiaChi,
	DienThoai = @DienThoai, Fax = @Fax, Email = @Email, DienGiai = @DienGiai, ConQuanLy = @ConQuanLy
	where MaKho = @MaKho
end




GO
/****** Object:  StoredProcedure [dbo].[sp_SuaKhuVuc]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SuaKhuVuc]
@makv as int,
@tenkv as nvarchar(255),
@ghichu as nvarchar(255),
@conquanly as bit
as begin
	update KHUVUC
	set
		TenKhuVuc = @tenkv,
		GhiChu = @ghichu,
		ConQuanLy = @conquanly
	where MaKhuVuc = @makv
end




GO
/****** Object:  StoredProcedure [dbo].[sp_SuaNguoiDung]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SuaNguoiDung]
	@MaNguoiDung int,
	@Ten nvarchar(255),
	@TaiKhoan varchar(50),
	@MatKhau varchar(50),
	@VaiTro int,
	@GhiChu nvarchar(50)
as
begin
	update NGUOIDUNG
	set Ten = @Ten, TaiKhoan = @TaiKhoan, MatKhau = @MatKhau, VaiTro = @VaiTro, GhiChu = @GhiChu
	where MaNguoiDung = @MaNguoiDung
end




GO
/****** Object:  StoredProcedure [dbo].[sp_SuaNhaCungCap]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SuaNhaCungCap]
@mancc int,
@tenncc nvarchar(255),
@diachi nvarchar(255),
@masothue char(20),
@sodidong char(20),
@sodienthoaiban char(20),
@email char(255),
@fax char(20),
@website char(255),
@sotaikhoan char(30),
@nganhang nvarchar(255),
@gioihanno float,
@chietkhau float,
@nguoilienhe nvarchar(255),
@chucvu nvarchar(255),
@nohientai float,
@khuvuc int,
@conquanly bit
as begin
	update NHAPHANPHOI 
	set 
	TenNhaPhanPhoi = @tenncc, 
	DiaChi = @diachi, 
	MaSoThue = @masothue, 
	SoDiDong = @sodidong, 
	SoDienThoaiBan = @sodienthoaiban, 
	Email = @email, 
	Fax = @fax, 
	Website = @website,
	SoTaiKhoan = @sotaikhoan, 
	NganHang = @nganhang,
	GioiHanNo = @gioihanno,
	ChietKhau = @chietkhau,
	NguoiLenHe = @nguoilienhe,
	ChucVu = @chucvu,
	NoHienTai = @nohientai,
	KhuVuc = @khuvuc,
	ConQuanLy = @conquanly
	where MaNhaPhanPhoi = @mancc
end




GO
/****** Object:  StoredProcedure [dbo].[sp_SuaNhanVien]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_SuaNhanVien]
	@MaNhanVien	int,
	@HoTen nvarchar(255),
	@ChucVu nvarchar(255),
	@DiaChi nvarchar(255),
	@Email char(255),
	@DienThoai char(20),
	@DiDong char(20),
	@BoPhan int,
	@QuanLy int,
	@ConQuanLy bit
as
begin
	update NHANVIEN
	set HoTen = @HoTen, ChucVu = @ChucVu, DiaChi = @DiaChi, 
	Email = @Email, DienThoai = @DienThoai, DiDong = @DiDong,
	BoPhan = @BoPhan, QuanLy = @QuanLy, ConQuanLy = @ConQuanLy
	where MaNhanVien = @MaNhanVien
end




GO
/****** Object:  StoredProcedure [dbo].[sp_SuaNhomHang]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SuaNhomHang]
@manh int,
@tennh nvarchar(50),
@ghichu nvarchar(255),
@conquanly bit
as begin
	update NHOMHANG
	set
	TenNhomHang = @tennh,
	GhiChu = @ghichu,
	ConQuanLy = @conquanly
	where MaNhomHang = @manh
end




GO
/****** Object:  StoredProcedure [dbo].[sp_SuaTyGia]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_SuaTyGia]
@matg int,
@tentg nvarchar(50),
@tygiaquydoi float,
@conquanly bit
as begin
	update TYGIA
	set
		TenTyGia = @tentg,
		TyGiaQuyDoi = @tygiaquydoi,
		ConQuanLy = @conquanly
	where MaTyGia = @matg
end




GO
/****** Object:  StoredProcedure [dbo].[sp_SuaVaiTro]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_SuaVaiTro]
	  @MaVaiTro int,
      @Ten nvarchar(255),
      @PhanQuyen bit,
      @DoiMatKhau bit,
      @NhatKyHeThong bit,
      @SaoLuu bit,
      @PhucHoi bit,
      @KhuVuc bit,
      @KhachHang bit,
      @NhaCungCap bit,
      @KhoHang bit,
      @DonViTinh bit,
      @NhomHang bit,
      @HangHoa bit,
      @TyGia bit,
      @BoPhan bit,
      @NhanVien bit,
      @MuaHang bit,
      @BanHang bit,
      @TonKho bit,
      @ChuyenKho bit,
      @ThuTien bit,
      @TraTien bit,
      @BaoCaoKhohang bit,
      @BaoCaoBanHang bit
as
begin
	update VAITRO
	set Ten = @Ten, PhanQuyen = @PhanQuyen, DoiMatKhau = @DoiMatKhau, NhatKyHeThong = @NhatKyHeThong,
	SaoLuu = @SaoLuu, PhucHoi = @PhucHoi, KhuVuc = @KhuVuc, KhachHang = @KhachHang, NhaCungCap = @NhaCungCap,
	KhoHang = @KhoHang, DonViTinh = @DonViTinh, NhomHang = @NhomHang, HangHoa = @HangHoa, 
	TyGia = @TyGia, BoPhan = @BoPhan, NhanVien = @NhanVien, MuaHang = @MuaHang, BanHang = @BanHang,
	TonKho = @TonKho, ChuyenKho = @ChuyenKho, ThuTien = @ThuTien, TraTien = @TraTien, BaoCaoKhohang = @BaoCaoKhohang, BaoCaoBanHang = @BaoCaoBanHang
	where MaVaiTro = @MaVaiTro
end




GO
/****** Object:  StoredProcedure [dbo].[sp_TangNoKhachHang]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_TangNoKhachHang]
	@MaKH int,
	@SoTienTang float
as
begin
	update KHACHHANG
	set NoHienTai = NoHienTai + @SoTienTang
	where MaKH = @MaKH
end




GO
/****** Object:  StoredProcedure [dbo].[sp_TangNoNhaCC]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_TangNoNhaCC]
@MaNCC int,
@SoTienTang float
as begin
	update NHAPHANPHOI
	set NoHienTai = NoHienTai + @SoTienTang
	where MaNhaPhanPhoi = @MaNCC
end




GO
/****** Object:  StoredProcedure [dbo].[sp_TangSoLuongHangTonTrongKho]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_TangSoLuongHangTonTrongKho]
	@MaKho int, 
	@MaHangHoa int,
	@SoLuong int
as
begin
	update KHO_HANGHOA
	set SoLuongTon = SoLuongTon + @SoLuong
	where MaKho = @MaKho and MaHangHoa = @MaHangHoa
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ThemBoPhan]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemBoPhan]
	@TenBoPhan nvarchar(255),
	@GhiChu nvarchar(255),
	@ConQuanLy bit
as
begin
	insert BOPHAN(TenBoPhan, GhiChu, ConQuanLy)
	values (@TenBoPhan, @GhiChu, @ConQuanLy)
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ThemChiTietChuyenKho]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemChiTietChuyenKho]
	@MaPhieu int,
	@MaHangHoa int,
	@SoLuong int
as
begin
	insert CHITIETCHUYENKHO
	values(@MaPhieu, @MaHangHoa, @SoLuong)
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ThemChiTietPhieuNhap]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemChiTietPhieuNhap]
@MaPhieuNhap int,
@MaHangHoa int,
@SoLuong int,
@DonGia float,
@ThanhTien float
as begin
	insert into CTMUAHANG values(@MaPhieuNhap, @MaHangHoa, @SoLuong, @DonGia, @ThanhTien)
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ThemChiTietPhieuXuat]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemChiTietPhieuXuat]
	@MaPhieuXuat int,
	@MaHangHoa int,
	@SoLuong int, 
	@DonGia float,
	@ThanhTien float
as
begin
	insert CTXUATHANG
	values (@MaPhieuXuat, @MaHangHoa, @SoLuong, @DonGia, @ThanhTien)
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ThemCongNo_KH]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ThemCongNo_KH]
	@MaKH int,
	@NgayPhatSinh date,
	@NoPhatSinh float,
	@DaThu float,
	@ConLai float,
	@LoaiPhatSinh nvarchar(50)
as
begin
	insert CONGNO_KH
	values (@MaKH, @NgayPhatSinh, @NoPhatSinh, @DaThu, @ConLai, @LoaiPhatSinh)
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ThemCongNo_NCC]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemCongNo_NCC]
@MaNCC int,
@NgayPhatSinh date,
@NoPhatSinh float,
@DaThu float,
@ConLai float,
@LoaiPhatSinh nvarchar(50)
as begin
	insert into CONGNO_NCC(MaNCC, NgayPhatSinh, No, DaThu, ConLai ,LoaiPhatSinh)
	values(@MaNCC, @NgayPhatSinh, @NoPhatSinh, @DaThu, @ConLai, @LoaiPhatSinh)
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ThemDonVi]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemDonVi]
	@TenDonVi nvarchar(255),
	@GhiChu nvarchar(255),
	@ConQuanLy bit
as 
begin
	insert DONVI(TenDonVi, GhiChu, ConQuanLy)
	values (@TenDonVi, @GhiChu, @ConQuanLy)
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ThemHangHoa]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemHangHoa]
	@TenHangHoa nvarchar(255),
	@LoaiHangHoa int, 
	@KhoMacDinh int,
	@PhanLoai int,
	@DonVi int,
	@XuatXu nvarchar(255),
	@TonKhoToiThieu int,
	@TonKho int,
	@NhaCungCap int, 
	@GiaMua float, 
	@GiaBan float,
	@ConQuanLy bit
	
as 
begin
	insert HANGHOA (TenHangHoa, LoaiHangHoa, KhoMacDinh, PhanLoai, DonVi, XuatXu,
	TonKhoToiThieu, TonKho, NhaCungCap, GiaMua, GiaBan, ConQuanLy)
	
	values (@TenHangHoa, @LoaiHangHoa, @KhoMacDinh, @PhanLoai,
	@DonVi, @XuatXu, @TonKhoToiThieu, @TonKho, @NhaCungCap, @GiaMua, @GiaBan, @ConQuanLy)
	
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ThemHangHoaVaoKho]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemHangHoaVaoKho]
	@MaHangHoa int
as
begin
	declare cur cursor 
	for  select MaKho from KHO
	open cur
	declare @MaKho int
	fetch next from cur into @MaKho
	while (@@FETCH_STATUS = 0)
	begin
		insert KHO_HANGHOA
		values(@MaKho, @MaHangHoa, 0)
		fetch next from cur into @MaKho
	end
	close cur
	deallocate cur
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ThemKhoHang]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemKhoHang]
	@TenKho nvarchar(255),
	@NVQuanLy int,
	@NguoiLienHe nvarchar(255),
	@DiaChi nvarchar(255), 
	@DienThoai char(20),
	@Fax char(20),
	@Email char(255),
	@DienGiai nvarchar(255),
	@ConQuanLy bit
as
begin
	insert KHO (TenKho, NVQuanLy, NguoiLienHe, DiaChi,
	DienThoai, Fax, Email, DienGiai, ConQuanLy)
	values (@TenKho, @NVQuanLy, @NguoiLienHe, @DiaChi,
	@DienThoai, @Fax, @Email, @DienGiai, @ConQuanLy)
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ThemKhuVuc]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemKhuVuc]
@tenkv nvarchar(255),
@ghichu nvarchar(1000),
@conquanly bit
as begin
	insert into KHUVUC values(@tenkv, @ghichu, @conquanly)
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ThemNguoiDung]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemNguoiDung]
	@Ten nvarchar(255),
	@TaiKhoan varchar(50),
	@MatKhau varchar(50),
	@VaiTro int,
	@GhiChu nvarchar(50)
as
begin
	insert NGUOIDUNG(Ten, TaiKhoan, MatKhau, VaiTro, GhiChu)
	values(@Ten, @TaiKhoan, @MatKhau, @VaiTro, @GhiChu)
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ThemNhaCungCap]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ThemNhaCungCap]
@tenncc nvarchar(255),
@diachi nvarchar(255),
@masothue char(20),
@sodidong char(20),
@sodienthoaiban char(20),
@email char(255),
@fax char(20),
@website char(255),
@sotaikhoan char(30),
@nganhang nvarchar(255),
@gioihanno float,
@chietkhau float,
@nguoilienhe nvarchar(255),
@chucvu nvarchar(255),
@nohientai float,
@khuvuc int,
@conquanly bit
as begin
	insert into NHAPHANPHOI values(@tenncc, @diachi, @masothue, @sodidong, @sodienthoaiban, @email, @fax, @website,@sotaikhoan, @nganhang,@gioihanno,@chietkhau,@nguoilienhe,@chucvu,@nohientai,@khuvuc,@conquanly)
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ThemNhanVien]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemNhanVien]
	@HoTen nvarchar(255),
	@ChucVu nvarchar(255),
	@DiaChi nvarchar(255),
	@Email char(255),
	@DienThoai char(20),
	@DiDong char(20),
	@BoPhan int,
	@QuanLy int,
	@ConQuanLy bit
as
begin
	insert NHANVIEN(HoTen, ChucVu, DiaChi, Email, DienThoai,
	DiDong, BoPhan, QuanLy, ConQuanLy)
	values (@HoTen, @ChucVu, @DiaChi, @Email, @DienThoai, @DiDong
	, @BoPhan, @QuanLy, @ConQuanLy)
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ThemNhatKy]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ThemNhatKy]
@tennd varchar(50),
@chucnang nvarchar(255),
@hanhdong nvarchar(255),
@thoigian varchar(50)
as begin
	insert into LOG
	values(@tennd, @chucnang, @hanhdong, @thoigian)
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ThemNhomHang]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemNhomHang]
@tennh nvarchar(50),
@ghichu nvarchar(255),
@conquanly bit
as begin
	insert into NHOMHANG values(@tennh, @ghichu, @conquanly)
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ThemPhieuChuyenKho]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ThemPhieuChuyenKho]
	@MaPhieu int out,
	@NgayChuyen date,
	@KhoXuat int,
	@KhoNhan int,
	@GhiChu nvarchar(255),
	@NguoiChuyen int,
	@NguoiNhan int
as
begin
	insert PHIEUCHUYENKHO(NgayChuyen, KhoXuat, KhoNhan, GhiChu, NguoiChuyen, NguoiNhan)
	values(@NgayChuyen, @KhoXuat, @KhoNhan, @GhiChu, @NguoiChuyen, @NguoiNhan)
	select @MaPhieu = MAX(MaPhieu)
	from PHIEUCHUYENKHO
	return
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ThemPhieuNhapHang]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ThemPhieuNhapHang]
@NhaCC int,
@NgayNhap date,
@NVPhuTrach int,
@KhoNhap int,
@DKThanhToan nvarchar(50),
@HTThanhToan nvarchar(50),
@HanThanhToan date,
@TongTien float,
@MaPhieuNhap int out
as begin
	insert into PHIEUNHAPHANG values(@NhaCC, @NgayNhap, @NVPhuTrach, @KhoNhap, @DKThanhToan, @HTThanhToan, @HanThanhToan, @TongTien)
	set @MaPhieuNhap = (select MAX(MaPhieuNhap) from PHIEUNHAPHANG)
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ThemPhieuXuatHang]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ThemPhieuXuatHang]
	@MaKH int, 
	@NgayXuat date,
	@NVBanHang int,
	@KhoXuat int,
	@DKThanhToan nvarchar(50),
	@HTThanhToan nvarchar(50),
	@HanThanhToan date,
	@NgayGiao date,
	@TongTien float,
	@MaPhieuXuat int out
as
begin
	insert PHIEUXUATHANG(MaKH, NgayXuat, NVBanHang, KhoXuat,
	DKThanhToan, HTThanhToan, HanThanhToan, NgayGiao, TongTien)
	values (@MaKH, @NgayXuat, @NVBanHang, @KhoXuat, @DKThanhToan, @HTThanhToan, @HanThanhToan, @NgayGiao, @TongTien)
	
	select @MaPhieuXuat = MAX(MaPhieuXuat)
	from PHIEUXUATHANG
	return
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ThemTatCaHangHoaVaoKho]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ThemTatCaHangHoaVaoKho]
	@MaKho int
as
begin
	declare cur cursor
	for select MaHangHoa from HANGHOA
	
	open cur
	declare @MaHangHoa int	
	fetch next from cur into @MaHangHoa
	
	while (@@FETCH_STATUS = 0)
	begin
		insert KHO_HANGHOA
		values (@MaKho, @MaHangHoa, 0)
		fetch next from cur into @MaHangHoa
	end

	close cur
	deallocate cur
	
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ThemTyGia]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemTyGia]
@tentygia nvarchar(50),
@tygiaquydoi float,
@conquanly bit
as begin
	insert into TYGIA values (@tentygia, @tygiaquydoi, @conquanly)
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ThemVaiTro]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemVaiTro]
      @Ten nvarchar(255),
      @PhanQuyen bit,
      @DoiMatKhau bit,
      @NhatKyHeThong bit,
      @SaoLuu bit,
      @PhucHoi bit,
      @KhuVuc bit,
      @KhachHang bit,
      @NhaCungCap bit,
      @KhoHang bit,
      @DonViTinh bit,
      @NhomHang bit,
      @HangHoa bit,
      @TyGia bit,
      @BoPhan bit,
      @NhanVien bit,
      @MuaHang bit,
      @BanHang bit,
      @TonKho bit,
      @ChuyenKho bit,
      @ThuTien bit,
      @TraTien bit,
      @BaoCaoKhohang bit,
      @BaoCaoBanHang bit
as
begin
	insert VAITRO (Ten, PhanQuyen, DoiMatKhau, NhatKyHeThong, SaoLuu, PhucHoi, KhuVuc,
	KhachHang, NhaCungCap, KhoHang, DonViTinh, NhomHang, HangHoa, TyGia, BoPhan, NhanVien,
	MuaHang, BanHang, TonKho, ChuyenKho, ThuTien, TraTien, BaoCaoKhohang, BaoCaoBanHang)
	values(@Ten, @PhanQuyen, @DoiMatKhau, @NhatKyHeThong, @SaoLuu, @PhucHoi, @KhuVuc,
	@KhachHang, @NhaCungCap, @KhoHang, @DonViTinh, @NhomHang, @HangHoa, @TyGia, @BoPhan,@NhanVien,
	@MuaHang, @BanHang, @TonKho, @ChuyenKho, @ThuTien, @TraTien, @BaoCaoKhohang, @BaoCaoBanHang)
end




GO
/****** Object:  StoredProcedure [dbo].[sp_TongHopBaoCaoKhoHang]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_TongHopBaoCaoKhoHang]
  as begin
	select k.TenKho, h.MaHangHoa, h.TenHangHoa, h.GiaMua, (h.GiaMua * khh.SoLuongTon) as TongTien, h.DonVi,khh.SoLuongTon, l.TenNhomHang, dv.TenDonVi, h.ConQuanLy
	from HANGHOA h, NHOMHANG l, KHO k, KHO_HANGHOA khh, DONVI dv
	where h.LoaiHangHoa = l.MaNhomHang and h.MaHangHoa = khh.MaHangHoa and khh.MaKho = k.makho and h.DonVi = dv.MaDV
	order by MaHangHoa
  end




GO
/****** Object:  StoredProcedure [dbo].[sp_XemTonKho]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_XemTonKho]
as
begin
	select h.MaHangHoa, h.TenHangHoa, k.TenKho as MaKho, h.DonVi,khh.SoLuongTon, l.TenNhomHang, dv.TenDonVi, h.ConQuanLy
	from HANGHOA h, NHOMHANG l, KHO k, KHO_HANGHOA khh, DONVI dv
	where h.LoaiHangHoa = l.MaNhomHang and h.MaHangHoa = khh.MaHangHoa and khh.MaKho = k.makho and h.DonVi = dv.MaDV
	order by MaHangHoa
end




GO
/****** Object:  StoredProcedure [dbo].[sp_XemTonKhoTheoKho]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XemTonKhoTheoKho]
@MaKho int
as
begin
	select h.MaHangHoa, h.TenHangHoa, k.TenKho as MaKho, h.DonVi,khh.SoLuongTon, l.TenNhomHang, dv.TenDonVi, h.ConQuanLy
	from HANGHOA h, NHOMHANG l, KHO k, KHO_HANGHOA khh, DONVI dv
	where h.LoaiHangHoa = l.MaNhomHang and h.MaHangHoa = khh.MaHangHoa and khh.MaKho = k.makho and h.DonVi = dv.MaDV and k.MaKho = @MaKho
	order by MaHangHoa
end




GO
/****** Object:  StoredProcedure [dbo].[sp_XoaBoPhan]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaBoPhan]
	@MaBoPhan int
as
begin
	delete BOPHAN
	where BOPHAN.MaBoPhan = @MaBoPhan
end




GO
/****** Object:  StoredProcedure [dbo].[sp_XoaDonVi]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaDonVi]
	@MaDV int
as 
begin
	delete DONVI
	where MaDV = @MaDV
end




GO
/****** Object:  StoredProcedure [dbo].[sp_XoaHangHoa]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_XoaHangHoa]
	@MaHangHoa int

as 
begin
	delete KHO_HANGHOA
	where MaHangHoa = @MaHangHoa

	delete HANGHOA
	where MaHangHoa = @MaHangHoa
end




GO
/****** Object:  StoredProcedure [dbo].[sp_XoaHetNhatKy]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaHetNhatKy]
as begin
	delete from LOG
end




GO
/****** Object:  StoredProcedure [dbo].[sp_XoaKhoHang]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaKhoHang]
	@MaKho int
as
begin
	delete KHO
	where MaKho = @MaKho
end




GO
/****** Object:  StoredProcedure [dbo].[sp_XoaKhuVuc]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaKhuVuc]
@makv as int
as begin
	delete from KHUVUC where MaKhuVuc = @makv
end




GO
/****** Object:  StoredProcedure [dbo].[sp_XoaNguoiDung]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Script for SelectTopNRows command from SSMS  ******/
create proc [dbo].[sp_XoaNguoiDung]
	@MaNguoiDung int
as
begin
	delete NGUOIDUNG
	where MaNguoiDung = @MaNguoiDung
end




GO
/****** Object:  StoredProcedure [dbo].[sp_XoaNhaCungCap]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaNhaCungCap]
@mancc int
as begin
	delete from NHAPHANPHOI where MaNhaPhanPhoi = @mancc
end




GO
/****** Object:  StoredProcedure [dbo].[sp_XoaNhanVien]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaNhanVien]
	@MaNhanVien	int

as
begin
	delete NHANVIEN
	where MaNhanVien = @MaNhanVien
end




GO
/****** Object:  StoredProcedure [dbo].[sp_XoaNhatKy]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaNhatKy]
@tg varchar(50)
as begin
	delete from LOG where ThoiGian = @tg
end




GO
/****** Object:  StoredProcedure [dbo].[sp_XoaNhomHang]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaNhomHang]
@manh int
as begin
	delete from NHOMHANG where MaNhomHang = @manh
end




GO
/****** Object:  StoredProcedure [dbo].[sp_XoaTyGia]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaTyGia]
@matg int
as begin
	delete from TYGIA where MaTyGia = @matg
end




GO
/****** Object:  StoredProcedure [dbo].[sp_XoaVaiTro]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaVaiTro]
	  @MaVaiTro int
as
begin
	delete VAITRO
	where MaVaiTro = @MaVaiTro
end




GO
/****** Object:  StoredProcedure [dbo].[sptest]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sptest]
@TenNhaPhanPhoi nvarchar(255),
@DiaChi nvarchar(255),
@KhuVuc int
as
begin
	insert NHAPHANPHOI(TenNhaPhanPhoi,DiaChi, KhuVuc)
	values (@TenNhaPhanPhoi, @DiaChi, @KhuVuc)
end




GO
/****** Object:  StoredProcedure [dbo].[spThemKhachHang]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spThemKhachHang]
	@HoTen nvarchar(255),
	@DiaChi nvarchar(255),
	@MaSoThue char(20),
	@SoDiDong char(20),
	@SoDienThoaiBan char(20),
	@Email char(255),
	@Fax char(20),
	@Website char(255),
	@SoTaiKhoan char(30),
	@NganHang nvarchar(255),
	@GioiHanNo float,
	@ChietKhau float,
	@NguoiLienHe nvarchar(255),
	@NoHienTai float,
	@NickYahoo char(50),
	@LoaiKhachHang int,
	@KhuVuc int,
	@NickSkype char(50),
	@ConQuanLy bit
as
begin
	insert KHACHHANG
	values (@HoTen, @DiaChi, @MaSoThue, @SoDiDong, @SoDienThoaiBan, @Email, @Fax, @Website, @SoTaiKhoan,
			@NganHang, @GioiHanNo, @ChietKhau, @NguoiLienHe, @NoHienTai, @NickYahoo, @LoaiKhachHang, @KhuVuc,
			@NickSkype, @ConQuanLy)
end




GO
/****** Object:  StoredProcedure [dbo].[ThayDoiMatKhau]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[ThayDoiMatKhau]
	@ten varchar(50),
	@matkhaucu varchar(50),
	@matkhaumoi varchar(50),
	@xacnhanmatkhaumoi varchar(50),
	@a int output
as
begin
	declare @mk varchar(50)
	select @mk=MatKhau
	from NGUOIDUNG
	where TaiKhoan=@ten
	
	if(@mk=@matkhaucu)
	begin
		update NGUOIDUNG
		set MatKhau=@matkhaumoi,XacNhan=@xacnhanmatkhaumoi
		where TaiKhoan=@ten
		set @a=1	
	end
	else
	begin
		set @a=0
	end
end





GO
/****** Object:  StoredProcedure [dbo].[ThemLOG]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemLOG]
	@MaNguoiDung int,
	@ChucNang nvarchar(255),
	@HanhDong nvarchar(255),
	@ThoiGian datetime
as
begin
	insert LOG
	values(@MaNguoiDung, @ChucNang, @HanhDong, @ThoiGian)
end




GO
/****** Object:  StoredProcedure [dbo].[XoaHetNhatKyHeThong]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaHetNhatKyHeThong]
as
begin
	delete LOG
end




GO
/****** Object:  StoredProcedure [dbo].[XoaNhatKyHeThong]    Script Date: 09-1-2018 9:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaNhatKyHeThong]
	@MaNhatKy int
as
begin
	delete LOG
	where MaNKHD = @MaNhatKy
end




GO
USE [master]
GO
ALTER DATABASE [QuanLyBanHang] SET  READ_WRITE 
GO
