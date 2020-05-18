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

namespace QuanLyBanHang.GUI.DonViTinh
{
    public partial class DanhMuc_SuaDonVi : DevExpress.XtraEditors.XtraForm
    {
        public DanhMuc_SuaDonVi()
        {
            InitializeComponent();
        }
        private DonViTinhDTO _dvSua;
        public DonViTinhDTO DVSua
        {
            get
            {
                return _dvSua;
            }
            set
            {
                _dvSua = value;
            }
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


        private void DanhMuc_SuaDonVi_Load(object sender, EventArgs e)
        {
            LoadTheoDVSua();
        }
        public void LoadTheoDVSua()
        {
            txtTenDonVi.Text = DVSua.TenDonVi;
            txtGhiChu.Text = DVSua.GhiChu;
            if (DVSua.ConQuanLy == true)
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
            DVSua.TenDonVi = Convert.ToString(txtTenDonVi.Text);
            DVSua.GhiChu = Convert.ToString(txtGhiChu.Text);
            if (chkConQuanLy.Checked == true)
            {
                DVSua.ConQuanLy = true;
            }
            else
            {
                DVSua.ConQuanLy = false;
            }

            bool test = DonViTinhBUS.SuaDonVi(DVSua);
            if (test == true)
            {
                Log_BUS.ThemNhatKy("Đơn vị", "Sửa đơn vị");
                MessageBox.Show("Sửa đơn vị thành công");
                if (eventSuaXongEvent != null)
                    eventSuaXongEvent();
            }
            else
            {
                MessageBox.Show("Sửa đơn vị không thành công, dữ liệu thêm không đúng");
            }
        }

        public void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}