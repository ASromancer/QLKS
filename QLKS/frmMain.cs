using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKS
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public void enableButtons()
        {
            btnLogin.Enabled = false;
            btnLogout.Enabled = true;
            btnDangKy.Enabled = true;

            rib_QUANLY.Visible = true;
            rib_LAPPHIEU.Visible = true;
        }
        //kiem tra form da ton tai hay chua ?
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(frmLogin));
            if(f != null)
            {
                f.Activate();
            } else
            {
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

        //giải phóng tài nguyên của tất cả các form
        private void LogoutAllForm()
        {
            foreach (Form frm in this.MdiChildren)
                frm.Dispose();
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LogoutAllForm();
            rib_QUANLY.Visible = false;
            rib_LAPPHIEU.Visible = false;

            btnLogin.Enabled = true;
            btnLogout.Enabled = false;
            btnDangKy.Enabled = false;

            Form f = CheckExists(typeof(frmLogin));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                Program.frmChinh.MANV.Text = "Mã NV: ";
                Program.frmChinh.HOTEN.Text = "Họ tên: ";
                Program.frmChinh.VAITRO.Text = "Vai trò: ";

                frmLogin login = new frmLogin();
                login.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(frmNhanVien));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmNhanVien phong = new frmNhanVien();
                phong.MdiParent = this;
                phong.Show();
            }
        }

        private void btnPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(frmPhong));
            if (f != null)
            {
                f.Activate();
            } else
            {
                frmPhong phong = new frmPhong();
                phong.MdiParent = this;
                phong.Show();
            }
        }

        private void btnKhach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(frmKhach));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmKhach phong = new frmKhach();
                phong.MdiParent = this;
                phong.Show();
            }
        }

        private void btnDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(frmDichVu));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmDichVu phong = new frmDichVu();
                phong.MdiParent = this;
                phong.Show();
            }
        }

        private void btnKieuPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(frmKieuPhong));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmKieuPhong phong = new frmKieuPhong();
                phong.MdiParent = this;
                phong.Show();
            }
        }

        private void btnHangPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(frmHangPhong));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmHangPhong phong = new frmHangPhong();
                phong.MdiParent = this;
                phong.Show();
            }
        }

        private void btnLoaiPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(frmLoaiPhong));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmLoaiPhong phong = new frmLoaiPhong();
                phong.MdiParent = this;
                phong.Show();
            }
        }

        private void btnPD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(frmPD));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmPD phong = new frmPD();
                phong.MdiParent = this;
                phong.Show();
            }
        }

        private void btnPT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(frmPhieuThue));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmPhieuThue phong = new frmPhieuThue();
                phong.MdiParent = this;
                phong.Show();
            }
        }

        private void btnHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(frmHoaDon));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmHoaDon phong = new frmHoaDon();
                phong.MdiParent = this;
                phong.Show();
            }
        }
    }
}
