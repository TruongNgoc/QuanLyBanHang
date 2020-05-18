using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using QuanLyBanHang.GUI.HangHoa;
using QuanLyBanHang.GUI.BaoCao;
using QuanLyBanHang.GUI.ChucNang;
using QuanLyBanHang.GUI.HeThong;
using QuanLyBanHang.GUI.NhapXuat;

namespace QuanLyBanHang
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            Application.Run(new HeThong_DangNhap());
        }
    }
}
