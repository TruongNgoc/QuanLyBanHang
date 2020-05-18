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

namespace QuanLyBanHang.GUI.BoPhan
{
    public partial class DanhMuc_SuaBoPhan : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_SuaBoPhan()
        {
            InitializeComponent();
        }
        public delegate void SuaXongBoPhan();
        private SuaXongBoPhan eventSuaXongBoPhanEvent;
        public event SuaXongBoPhan eventSuaXongBoPhan
        {
            add
            {
                eventSuaXongBoPhanEvent = (SuaXongBoPhan)System.Delegate.Combine(eventSuaXongBoPhanEvent, value);
            }
            remove
            {
                eventSuaXongBoPhanEvent = (SuaXongBoPhan)System.Delegate.Remove(eventSuaXongBoPhanEvent, value);
            }
        }

        private BoPhanDTO _BoPhanSua;
        public BoPhanDTO BoPhanSua
        {
            get
            {
                return _BoPhanSua;
            }
            set
            {
                _BoPhanSua = value;
            }
        }

        private void DanhMuc_SuaBoPhan_Load(object sender, EventArgs e)
        {
            LoadBoPhanSua();
        }
        private void LoadBoPhanSua()
        {
            txtTenBoPhan.Text = BoPhanSua.TenBoPhan;
            txtGhiChu.Text = BoPhanSua.GhiChu;
            if (BoPhanSua.ConQuanLy == true)
            {
                chkConQuanLy.Checked = true;
            }
            else
            {
                chkConQuanLy.Checked = false;
            }
        }

        public void btnLuu_Click(object sender, EventArgs e)
        {
            BoPhanSua.TenBoPhan = System.Convert.ToString(txtTenBoPhan.Text);
            BoPhanSua.GhiChu = System.Convert.ToString(txtGhiChu.Text);
            if (chkConQuanLy.Checked == true)
            {
                BoPhanSua.ConQuanLy = true;
            }
            else
            {
                BoPhanSua.ConQuanLy = false;
            }
            bool test = BoPhanBUS.SuaBoPhan(BoPhanSua);
            if (test == true)
            {
                Log_BUS.ThemNhatKy("Bộ phận", "Sửa bộ phận");
                MessageBox.Show("Sửa thành công");

                if (eventSuaXongBoPhanEvent != null)
                {
                    eventSuaXongBoPhanEvent();
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu sửa không hợp lệ");
            }
        }
        public void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}