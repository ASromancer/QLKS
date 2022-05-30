
namespace QLKS
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangKy = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhong = new DevExpress.XtraBars.BarButtonItem();
            this.btnNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhach = new DevExpress.XtraBars.BarButtonItem();
            this.btnDichVu = new DevExpress.XtraBars.BarButtonItem();
            this.btnKieuPhong = new DevExpress.XtraBars.BarButtonItem();
            this.btnHangPhong = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiPhong = new DevExpress.XtraBars.BarButtonItem();
            this.btnPD = new DevExpress.XtraBars.BarButtonItem();
            this.btnPT = new DevExpress.XtraBars.BarButtonItem();
            this.btnHD = new DevExpress.XtraBars.BarButtonItem();
            this.rib_QUANLY = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rib_LAPPHIEU = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rib_HETHONG = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MANV = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.HOTEN = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.VAITRO = new System.Windows.Forms.ToolStripLabel();
            this.rib_BAOCAO = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnLogin,
            this.barButtonItem1,
            this.btnDangKy,
            this.btnLogout,
            this.btnPhong,
            this.btnNV,
            this.btnKhach,
            this.btnDichVu,
            this.btnKieuPhong,
            this.btnHangPhong,
            this.btnLoaiPhong,
            this.btnPD,
            this.btnPT,
            this.btnHD,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rib_QUANLY,
            this.rib_LAPPHIEU,
            this.rib_BAOCAO,
            this.rib_HETHONG});
            this.ribbonControl1.Size = new System.Drawing.Size(1376, 158);
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng nhập";
            this.btnLogin.Id = 1;
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.LargeImage")));
            this.btnLogin.LargeWidth = 80;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thoát";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.LargeWidth = 80;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Caption = "Đăng ký";
            this.btnDangKy.Enabled = false;
            this.btnDangKy.Id = 3;
            this.btnDangKy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangKy.ImageOptions.Image")));
            this.btnDangKy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangKy.ImageOptions.LargeImage")));
            this.btnDangKy.LargeWidth = 80;
            this.btnDangKy.Name = "btnDangKy";
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng xuất";
            this.btnLogout.Enabled = false;
            this.btnLogout.Id = 4;
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.LargeImage")));
            this.btnLogout.LargeWidth = 80;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnPhong
            // 
            this.btnPhong.Caption = "Phòng";
            this.btnPhong.Id = 5;
            this.btnPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhong.ImageOptions.Image")));
            this.btnPhong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhong.ImageOptions.LargeImage")));
            this.btnPhong.LargeWidth = 80;
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhong_ItemClick);
            // 
            // btnNV
            // 
            this.btnNV.Caption = "Nhân viên";
            this.btnNV.Id = 6;
            this.btnNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNV.ImageOptions.Image")));
            this.btnNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNV.ImageOptions.LargeImage")));
            this.btnNV.LargeWidth = 80;
            this.btnNV.Name = "btnNV";
            this.btnNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNV_ItemClick);
            // 
            // btnKhach
            // 
            this.btnKhach.Caption = "Khách hàng";
            this.btnKhach.Id = 7;
            this.btnKhach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKhach.ImageOptions.Image")));
            this.btnKhach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKhach.ImageOptions.LargeImage")));
            this.btnKhach.LargeWidth = 80;
            this.btnKhach.Name = "btnKhach";
            this.btnKhach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhach_ItemClick);
            // 
            // btnDichVu
            // 
            this.btnDichVu.Caption = "Dịch vụ";
            this.btnDichVu.Id = 8;
            this.btnDichVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDichVu.ImageOptions.Image")));
            this.btnDichVu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDichVu.ImageOptions.LargeImage")));
            this.btnDichVu.LargeWidth = 80;
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDichVu_ItemClick);
            // 
            // btnKieuPhong
            // 
            this.btnKieuPhong.Caption = "Kiểu phòng";
            this.btnKieuPhong.Id = 9;
            this.btnKieuPhong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKieuPhong.ImageOptions.SvgImage")));
            this.btnKieuPhong.LargeWidth = 80;
            this.btnKieuPhong.Name = "btnKieuPhong";
            this.btnKieuPhong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKieuPhong_ItemClick);
            // 
            // btnHangPhong
            // 
            this.btnHangPhong.Caption = "Hạng phòng";
            this.btnHangPhong.Id = 10;
            this.btnHangPhong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHangPhong.ImageOptions.SvgImage")));
            this.btnHangPhong.LargeWidth = 80;
            this.btnHangPhong.Name = "btnHangPhong";
            this.btnHangPhong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHangPhong_ItemClick);
            // 
            // btnLoaiPhong
            // 
            this.btnLoaiPhong.Caption = "Loại phòng";
            this.btnLoaiPhong.Id = 11;
            this.btnLoaiPhong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoaiPhong.ImageOptions.SvgImage")));
            this.btnLoaiPhong.LargeWidth = 80;
            this.btnLoaiPhong.Name = "btnLoaiPhong";
            this.btnLoaiPhong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiPhong_ItemClick);
            // 
            // btnPD
            // 
            this.btnPD.Caption = "Phiếu đặt";
            this.btnPD.Id = 12;
            this.btnPD.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPD.ImageOptions.SvgImage")));
            this.btnPD.LargeWidth = 80;
            this.btnPD.Name = "btnPD";
            this.btnPD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPD_ItemClick);
            // 
            // btnPT
            // 
            this.btnPT.Caption = "Phiếu thuê";
            this.btnPT.Id = 13;
            this.btnPT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPT.ImageOptions.SvgImage")));
            this.btnPT.LargeWidth = 80;
            this.btnPT.Name = "btnPT";
            this.btnPT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPT_ItemClick);
            // 
            // btnHD
            // 
            this.btnHD.Caption = "Hóa đơn";
            this.btnHD.Id = 14;
            this.btnHD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHD.ImageOptions.Image")));
            this.btnHD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHD.ImageOptions.LargeImage")));
            this.btnHD.LargeWidth = 80;
            this.btnHD.Name = "btnHD";
            this.btnHD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHD_ItemClick);
            // 
            // rib_QUANLY
            // 
            this.rib_QUANLY.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rib_QUANLY.Name = "rib_QUANLY";
            this.rib_QUANLY.Text = "QUẢN LÝ";
            this.rib_QUANLY.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPhong);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNV);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKhach);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDichVu);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKieuPhong);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHangPhong);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLoaiPhong);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản lý";
            // 
            // rib_LAPPHIEU
            // 
            this.rib_LAPPHIEU.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rib_LAPPHIEU.Name = "rib_LAPPHIEU";
            this.rib_LAPPHIEU.Text = "LẬP PHIẾU";
            this.rib_LAPPHIEU.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPD);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPT);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnHD);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Lập phiếu";
            // 
            // rib_HETHONG
            // 
            this.rib_HETHONG.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rib_HETHONG.Name = "rib_HETHONG";
            this.rib_HETHONG.Text = "HỆ THỐNG";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLogin);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDangKy);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Hệ thống";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANV,
            this.toolStripSeparator1,
            this.HOTEN,
            this.toolStripSeparator2,
            this.VAITRO});
            this.toolStrip1.Location = new System.Drawing.Point(0, 632);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1376, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MANV
            // 
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(46, 22);
            this.MANV.Text = "Mã NV:";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(46, 22);
            this.HOTEN.Text = "Họ tên:";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // VAITRO
            // 
            this.VAITRO.Name = "VAITRO";
            this.VAITRO.Size = new System.Drawing.Size(43, 22);
            this.VAITRO.Text = "Vai trò:";
            // 
            // rib_BAOCAO
            // 
            this.rib_BAOCAO.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rib_BAOCAO.Name = "rib_BAOCAO";
            this.rib_BAOCAO.Text = "BÁO CÁO";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 15;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // frmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 657);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rib_QUANLY;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rib_HETHONG;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnDangKy;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripLabel MANV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripLabel HOTEN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripLabel VAITRO;
        private DevExpress.XtraBars.BarButtonItem btnPhong;
        private DevExpress.XtraBars.BarButtonItem btnNV;
        private DevExpress.XtraBars.BarButtonItem btnKhach;
        private DevExpress.XtraBars.BarButtonItem btnDichVu;
        private DevExpress.XtraBars.BarButtonItem btnKieuPhong;
        private DevExpress.XtraBars.BarButtonItem btnHangPhong;
        private DevExpress.XtraBars.BarButtonItem btnLoaiPhong;
        private DevExpress.XtraBars.BarButtonItem btnPD;
        private DevExpress.XtraBars.BarButtonItem btnPT;
        private DevExpress.XtraBars.Ribbon.RibbonPage rib_LAPPHIEU;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnHD;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rib_BAOCAO;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}

