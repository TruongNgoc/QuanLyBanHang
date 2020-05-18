using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS
{
    public class Log_DTO
    {
        int _Ma;
        public int Ma
        {
            get { return _Ma; }
            set { _Ma = value; }
        }

        string _TenND;
        public string TenND
        {
            get { return _TenND; }
            set { _TenND = value; }
        }
        string _ChucNang;
        public string ChucNang
        {
            get { return _ChucNang; }
            set { _ChucNang = value; }
        }
        string _HanhDong;
        public string HanhDong
        {
            get { return _HanhDong; }
            set { _HanhDong = value; }
        }
        string _ThoiGian;
        public string ThoiGian
        {
            get { return _ThoiGian; }
            set { _ThoiGian = value; }
        }
    }
}
