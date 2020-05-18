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

namespace QuanLyBanHang.GUI.TyGia
{
    public partial class DanhMuc_ThemTyGia : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_ThemTyGia()
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


        public void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnLuu_Click(object sender, EventArgs e)
        {
            TyGiaDTO tg = new TyGiaDTO();
            tg.TenTyGia = Convert.ToString(txtTen.Text.Trim());
            tg.TyGiaQuyDoi = Convert.ToDouble(ceTyGiaQuyDoi.Value);
            if (chxConQuanLy.Checked == true)
            {
                tg.ConQuanLy = true;
            }
            else
            {
                tg.ConQuanLy = false;
            }
            bool check = TyGiaBUS.KiemTraThem(tg);
            if (check)
            {
                if (eventThemXongEvent != null)
                    eventThemXongEvent();
                MessageBox.Show("Thêm thành công!");
                Log_BUS.ThemNhatKy("Tỷ giá", "Thêm tỷ giá");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }
    }
}