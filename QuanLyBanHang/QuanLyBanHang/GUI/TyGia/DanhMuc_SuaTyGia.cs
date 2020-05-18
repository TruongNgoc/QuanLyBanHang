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
    public partial class DanhMuc_SuaTyGia : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_SuaTyGia()
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


        public void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnLuu_Click(object sender, EventArgs e)
        {
            TyGiaDTO tg = new TyGiaDTO();
            tg.MaTyGia = Convert.ToInt32(txtMa.Text);
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
            bool check = TyGiaBUS.KiemTraSua(tg);
            if (check)
            {
                if (eventSuaXongEvent != null)
                    eventSuaXongEvent();
                MessageBox.Show("Sửa thành công!");
                Log_BUS.ThemNhatKy("Tỷ giá", "Sửa thông tin tỷ giá");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }
    }
}