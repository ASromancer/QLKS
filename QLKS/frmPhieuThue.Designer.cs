
namespace QLKS
{
    partial class frmPhieuThue
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
            System.Windows.Forms.Label mAPTLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label mAPDLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label tENLabel1;
            System.Windows.Forms.Label mAPHONGLabel;
            System.Windows.Forms.Label gHICHULabel;
            System.Windows.Forms.Label nGAYGIODENLabel;
            System.Windows.Forms.Label nGAYGIODILabel;
            System.Windows.Forms.Label nGAYLAPPHIEULabel;
            System.Windows.Forms.Label mADVLabel;
            System.Windows.Forms.Label gHICHULabel1;
            System.Windows.Forms.Label sOLUONGLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuThue));
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.DS = new QLKS.DS();
            this.bdsPT = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUTHUETableAdapter = new QLKS.DSTableAdapters.PHIEUTHUETableAdapter();
            this.tableAdapterManager = new QLKS.DSTableAdapters.TableAdapterManager();
            this.gcPT = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAPD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYLAPPHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelInput = new DevExpress.XtraEditors.PanelControl();
            this.btnHuyCTDV = new System.Windows.Forms.Button();
            this.btnXoaCTDV = new System.Windows.Forms.Button();
            this.btnGhiCTDV = new System.Windows.Forms.Button();
            this.btnThemCTDV = new System.Windows.Forms.Button();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.spnSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.bdsCTDV = new System.Windows.Forms.BindingSource(this.components);
            this.txtGhiChuDV = new System.Windows.Forms.TextBox();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.btnChonDV = new System.Windows.Forms.Button();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.btnLayDuLieuPhieuDat = new System.Windows.Forms.Button();
            this.txtMaxTgThue = new System.Windows.Forms.TextBox();
            this.txtTongThoiGianThue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.btnChonPhong = new System.Windows.Forms.Button();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.bdsCTPT = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.cbxKH = new System.Windows.Forms.ComboBox();
            this.bdsKH = new System.Windows.Forms.BindingSource(this.components);
            this.cbxNV = new System.Windows.Forms.ComboBox();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaPD = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.btnChonPD = new System.Windows.Forms.Button();
            this.spnNgayGioDen = new DevExpress.XtraEditors.TimeEdit();
            this.spnNgayGioDi = new DevExpress.XtraEditors.TimeEdit();
            this.bdsPD = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUDATTableAdapter = new QLKS.DSTableAdapters.PHIEUDATTableAdapter();
            this.nHANVIENTableAdapter = new QLKS.DSTableAdapters.NHANVIENTableAdapter();
            this.kHACHHANGTableAdapter = new QLKS.DSTableAdapters.KHACHHANGTableAdapter();
            this.cTPHIEUTHUETableAdapter = new QLKS.DSTableAdapters.CTPHIEUTHUETableAdapter();
            this.gcCTPT = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGIODEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGIODI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemCT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiCT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaCT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHuyCT = new System.Windows.Forms.ToolStripMenuItem();
            this.cTDICHVUTableAdapter = new QLKS.DSTableAdapters.CTDICHVUTableAdapter();
            this.gcCTDV = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMADV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHICHU1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAPT2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            mAPTLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            mAPDLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            tENLabel1 = new System.Windows.Forms.Label();
            mAPHONGLabel = new System.Windows.Forms.Label();
            gHICHULabel = new System.Windows.Forms.Label();
            nGAYGIODENLabel = new System.Windows.Forms.Label();
            nGAYGIODILabel = new System.Windows.Forms.Label();
            nGAYLAPPHIEULabel = new System.Windows.Forms.Label();
            mADVLabel = new System.Windows.Forms.Label();
            gHICHULabel1 = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).BeginInit();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnNgayGioDen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnNgayGioDi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPTLabel
            // 
            mAPTLabel.AutoSize = true;
            mAPTLabel.Location = new System.Drawing.Point(143, 20);
            mAPTLabel.Name = "mAPTLabel";
            mAPTLabel.Size = new System.Drawing.Size(47, 17);
            mAPTLabel.TabIndex = 1;
            mAPTLabel.Text = "MAPT:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(400, 65);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(48, 17);
            mANVLabel.TabIndex = 3;
            mANVLabel.Text = "MANV:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(400, 112);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(48, 17);
            mAKHLabel.TabIndex = 5;
            mAKHLabel.Text = "MAKH:";
            // 
            // mAPDLabel
            // 
            mAPDLabel.AutoSize = true;
            mAPDLabel.Location = new System.Drawing.Point(280, 161);
            mAPDLabel.Name = "mAPDLabel";
            mAPDLabel.Size = new System.Drawing.Size(49, 17);
            mAPDLabel.TabIndex = 7;
            mAPDLabel.Text = "MAPD:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(131, 65);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(59, 17);
            tENLabel.TabIndex = 11;
            tENLabel.Text = "TEN NV:";
            // 
            // tENLabel1
            // 
            tENLabel1.AutoSize = true;
            tENLabel1.Location = new System.Drawing.Point(105, 112);
            tENLabel1.Name = "tENLabel1";
            tENLabel1.Size = new System.Drawing.Size(85, 17);
            tENLabel1.TabIndex = 13;
            tENLabel1.Text = "TEN KHACH:";
            // 
            // mAPHONGLabel
            // 
            mAPHONGLabel.AutoSize = true;
            mAPHONGLabel.Location = new System.Drawing.Point(114, 260);
            mAPHONGLabel.Name = "mAPHONGLabel";
            mAPHONGLabel.Size = new System.Drawing.Size(76, 17);
            mAPHONGLabel.TabIndex = 16;
            mAPHONGLabel.Text = "MAPHONG:";
            // 
            // gHICHULabel
            // 
            gHICHULabel.AutoSize = true;
            gHICHULabel.Location = new System.Drawing.Point(448, 260);
            gHICHULabel.Name = "gHICHULabel";
            gHICHULabel.Size = new System.Drawing.Size(62, 17);
            gHICHULabel.TabIndex = 18;
            gHICHULabel.Text = "GHICHU:";
            // 
            // nGAYGIODENLabel
            // 
            nGAYGIODENLabel.AutoSize = true;
            nGAYGIODENLabel.Location = new System.Drawing.Point(93, 303);
            nGAYGIODENLabel.Name = "nGAYGIODENLabel";
            nGAYGIODENLabel.Size = new System.Drawing.Size(97, 17);
            nGAYGIODENLabel.TabIndex = 20;
            nGAYGIODENLabel.Text = "NGAYGIODEN:";
            // 
            // nGAYGIODILabel
            // 
            nGAYGIODILabel.AutoSize = true;
            nGAYGIODILabel.Location = new System.Drawing.Point(426, 303);
            nGAYGIODILabel.Name = "nGAYGIODILabel";
            nGAYGIODILabel.Size = new System.Drawing.Size(84, 17);
            nGAYGIODILabel.TabIndex = 22;
            nGAYGIODILabel.Text = "NGAYGIODI:";
            // 
            // nGAYLAPPHIEULabel
            // 
            nGAYLAPPHIEULabel.AutoSize = true;
            nGAYLAPPHIEULabel.Location = new System.Drawing.Point(340, 20);
            nGAYLAPPHIEULabel.Name = "nGAYLAPPHIEULabel";
            nGAYLAPPHIEULabel.Size = new System.Drawing.Size(108, 17);
            nGAYLAPPHIEULabel.TabIndex = 24;
            nGAYLAPPHIEULabel.Text = "NGAYLAPPHIEU:";
            // 
            // mADVLabel
            // 
            mADVLabel.AutoSize = true;
            mADVLabel.Location = new System.Drawing.Point(169, 414);
            mADVLabel.Name = "mADVLabel";
            mADVLabel.Size = new System.Drawing.Size(49, 17);
            mADVLabel.TabIndex = 32;
            mADVLabel.Text = "MADV:";
            // 
            // gHICHULabel1
            // 
            gHICHULabel1.AutoSize = true;
            gHICHULabel1.Location = new System.Drawing.Point(156, 457);
            gHICHULabel1.Name = "gHICHULabel1";
            gHICHULabel1.Size = new System.Drawing.Size(62, 17);
            gHICHULabel1.TabIndex = 34;
            gHICHULabel1.Text = "GHICHU:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(143, 500);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(75, 17);
            sOLUONGLabel.TabIndex = 36;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1420, 30);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 756);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnThoat,
            this.btnHuy,
            this.btnLamMoi,
            this.btnGhi,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 9;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 7;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Enabled = false;
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.LargeImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Id = 5;
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.LargeImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 3;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1420, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 786);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1420, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 756);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(1420, 30);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(0, 756);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPT
            // 
            this.bdsPT.DataMember = "PHIEUTHUE";
            this.bdsPT.DataSource = this.DS;
            // 
            // pHIEUTHUETableAdapter
            // 
            this.pHIEUTHUETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOPHANTableAdapter = null;
            this.tableAdapterManager.CT_TRANGTHAIPHONGTableAdapter = null;
            this.tableAdapterManager.CTDICHVUTableAdapter = null;
            this.tableAdapterManager.CTPHIEUDATTableAdapter = null;
            this.tableAdapterManager.CTPHIEUTHUETableAdapter = null;
            this.tableAdapterManager.DICHVUTableAdapter = null;
            this.tableAdapterManager.DS_PD_CHUACO_PTTableAdapter = null;
            this.tableAdapterManager.HANGPHONGTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KIEUPHONGTableAdapter = null;
            this.tableAdapterManager.LOAIPHONGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUDATTableAdapter = null;
            this.tableAdapterManager.PHIEUTHUETableAdapter = this.pHIEUTHUETableAdapter;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLKS.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcPT
            // 
            this.gcPT.DataSource = this.bdsPT;
            this.gcPT.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPT.Location = new System.Drawing.Point(0, 30);
            this.gcPT.MainView = this.gridView1;
            this.gcPT.MenuManager = this.barManager1;
            this.gcPT.Name = "gcPT";
            this.gcPT.Size = new System.Drawing.Size(1420, 196);
            this.gcPT.TabIndex = 6;
            this.gcPT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPT,
            this.colMANV,
            this.colMAKH,
            this.colMAPD,
            this.colNGAYLAPPHIEU});
            this.gridView1.GridControl = this.gcPT;
            this.gridView1.Name = "gridView1";
            // 
            // colMAPT
            // 
            this.colMAPT.FieldName = "MAPT";
            this.colMAPT.MinWidth = 25;
            this.colMAPT.Name = "colMAPT";
            this.colMAPT.Visible = true;
            this.colMAPT.VisibleIndex = 0;
            this.colMAPT.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 1;
            this.colMANV.Width = 94;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 25;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 2;
            this.colMAKH.Width = 94;
            // 
            // colMAPD
            // 
            this.colMAPD.FieldName = "MAPD";
            this.colMAPD.MinWidth = 25;
            this.colMAPD.Name = "colMAPD";
            this.colMAPD.Visible = true;
            this.colMAPD.VisibleIndex = 3;
            this.colMAPD.Width = 94;
            // 
            // colNGAYLAPPHIEU
            // 
            this.colNGAYLAPPHIEU.FieldName = "NGAYLAPPHIEU";
            this.colNGAYLAPPHIEU.MinWidth = 25;
            this.colNGAYLAPPHIEU.Name = "colNGAYLAPPHIEU";
            this.colNGAYLAPPHIEU.Visible = true;
            this.colNGAYLAPPHIEU.VisibleIndex = 4;
            this.colNGAYLAPPHIEU.Width = 94;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.btnHuyCTDV);
            this.panelInput.Controls.Add(this.btnXoaCTDV);
            this.panelInput.Controls.Add(this.btnGhiCTDV);
            this.panelInput.Controls.Add(this.btnThemCTDV);
            this.panelInput.Controls.Add(this.separatorControl3);
            this.panelInput.Controls.Add(sOLUONGLabel);
            this.panelInput.Controls.Add(this.spnSoLuong);
            this.panelInput.Controls.Add(gHICHULabel1);
            this.panelInput.Controls.Add(this.txtGhiChuDV);
            this.panelInput.Controls.Add(mADVLabel);
            this.panelInput.Controls.Add(this.txtMaDV);
            this.panelInput.Controls.Add(this.btnChonDV);
            this.panelInput.Controls.Add(this.separatorControl2);
            this.panelInput.Controls.Add(this.btnLayDuLieuPhieuDat);
            this.panelInput.Controls.Add(this.txtMaxTgThue);
            this.panelInput.Controls.Add(this.txtTongThoiGianThue);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Controls.Add(nGAYLAPPHIEULabel);
            this.panelInput.Controls.Add(this.txtNgayLap);
            this.panelInput.Controls.Add(this.btnChonPhong);
            this.panelInput.Controls.Add(nGAYGIODILabel);
            this.panelInput.Controls.Add(nGAYGIODENLabel);
            this.panelInput.Controls.Add(gHICHULabel);
            this.panelInput.Controls.Add(this.txtGhiChu);
            this.panelInput.Controls.Add(mAPHONGLabel);
            this.panelInput.Controls.Add(this.txtMaPhong);
            this.panelInput.Controls.Add(this.separatorControl1);
            this.panelInput.Controls.Add(tENLabel1);
            this.panelInput.Controls.Add(this.cbxKH);
            this.panelInput.Controls.Add(tENLabel);
            this.panelInput.Controls.Add(this.cbxNV);
            this.panelInput.Controls.Add(mAPDLabel);
            this.panelInput.Controls.Add(this.txtMaPD);
            this.panelInput.Controls.Add(mAKHLabel);
            this.panelInput.Controls.Add(this.txtMaKH);
            this.panelInput.Controls.Add(mANVLabel);
            this.panelInput.Controls.Add(this.txtMaNV);
            this.panelInput.Controls.Add(mAPTLabel);
            this.panelInput.Controls.Add(this.txtMaPT);
            this.panelInput.Controls.Add(this.btnChonPD);
            this.panelInput.Controls.Add(this.spnNgayGioDen);
            this.panelInput.Controls.Add(this.spnNgayGioDi);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput.Location = new System.Drawing.Point(0, 226);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(837, 560);
            this.panelInput.TabIndex = 7;
            // 
            // btnHuyCTDV
            // 
            this.btnHuyCTDV.Enabled = false;
            this.btnHuyCTDV.Location = new System.Drawing.Point(655, 486);
            this.btnHuyCTDV.Name = "btnHuyCTDV";
            this.btnHuyCTDV.Size = new System.Drawing.Size(98, 31);
            this.btnHuyCTDV.TabIndex = 42;
            this.btnHuyCTDV.Text = "Hủy CTDV";
            this.btnHuyCTDV.UseVisualStyleBackColor = true;
            this.btnHuyCTDV.Click += new System.EventHandler(this.btnHuyCTDV_Click);
            // 
            // btnXoaCTDV
            // 
            this.btnXoaCTDV.Location = new System.Drawing.Point(513, 486);
            this.btnXoaCTDV.Name = "btnXoaCTDV";
            this.btnXoaCTDV.Size = new System.Drawing.Size(103, 31);
            this.btnXoaCTDV.TabIndex = 41;
            this.btnXoaCTDV.Text = "Xóa CTDV";
            this.btnXoaCTDV.UseVisualStyleBackColor = true;
            this.btnXoaCTDV.Click += new System.EventHandler(this.btnXoaCTDV_Click);
            // 
            // btnGhiCTDV
            // 
            this.btnGhiCTDV.Location = new System.Drawing.Point(655, 425);
            this.btnGhiCTDV.Name = "btnGhiCTDV";
            this.btnGhiCTDV.Size = new System.Drawing.Size(98, 32);
            this.btnGhiCTDV.TabIndex = 40;
            this.btnGhiCTDV.Text = "Ghi CTDV";
            this.btnGhiCTDV.UseVisualStyleBackColor = true;
            this.btnGhiCTDV.Click += new System.EventHandler(this.btnGhiCTDV_Click);
            // 
            // btnThemCTDV
            // 
            this.btnThemCTDV.Location = new System.Drawing.Point(513, 425);
            this.btnThemCTDV.Name = "btnThemCTDV";
            this.btnThemCTDV.Size = new System.Drawing.Size(103, 34);
            this.btnThemCTDV.TabIndex = 39;
            this.btnThemCTDV.Text = "Thêm CTDV";
            this.btnThemCTDV.UseVisualStyleBackColor = true;
            this.btnThemCTDV.Click += new System.EventHandler(this.btnThemCTDV_Click);
            // 
            // separatorControl3
            // 
            this.separatorControl3.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl3.Location = new System.Drawing.Point(440, 397);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Size = new System.Drawing.Size(22, 151);
            this.separatorControl3.TabIndex = 38;
            // 
            // spnSoLuong
            // 
            this.spnSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDV, "SOLUONG", true));
            this.spnSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnSoLuong.Location = new System.Drawing.Point(224, 497);
            this.spnSoLuong.MenuManager = this.barManager1;
            this.spnSoLuong.Name = "spnSoLuong";
            this.spnSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnSoLuong.Properties.IsFloatValue = false;
            this.spnSoLuong.Properties.Mask.EditMask = "N00";
            this.spnSoLuong.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.spnSoLuong.Size = new System.Drawing.Size(154, 24);
            this.spnSoLuong.TabIndex = 37;
            // 
            // bdsCTDV
            // 
            this.bdsCTDV.DataMember = "FK_PHIEUTHUE_CTDICHVU";
            this.bdsCTDV.DataSource = this.bdsPT;
            // 
            // txtGhiChuDV
            // 
            this.txtGhiChuDV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTDV, "GHICHU", true));
            this.txtGhiChuDV.Location = new System.Drawing.Point(224, 454);
            this.txtGhiChuDV.Name = "txtGhiChuDV";
            this.txtGhiChuDV.Size = new System.Drawing.Size(154, 23);
            this.txtGhiChuDV.TabIndex = 35;
            // 
            // txtMaDV
            // 
            this.txtMaDV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTDV, "MADV", true));
            this.txtMaDV.Location = new System.Drawing.Point(224, 411);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.ReadOnly = true;
            this.txtMaDV.Size = new System.Drawing.Size(154, 23);
            this.txtMaDV.TabIndex = 33;
            // 
            // btnChonDV
            // 
            this.btnChonDV.Enabled = false;
            this.btnChonDV.Location = new System.Drawing.Point(40, 407);
            this.btnChonDV.Name = "btnChonDV";
            this.btnChonDV.Size = new System.Drawing.Size(115, 30);
            this.btnChonDV.TabIndex = 32;
            this.btnChonDV.Text = "Chọn dịch vụ";
            this.btnChonDV.UseVisualStyleBackColor = true;
            this.btnChonDV.Click += new System.EventHandler(this.btnChonDV_Click);
            // 
            // separatorControl2
            // 
            this.separatorControl2.Location = new System.Drawing.Point(2, 382);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(815, 23);
            this.separatorControl2.TabIndex = 31;
            // 
            // btnLayDuLieuPhieuDat
            // 
            this.btnLayDuLieuPhieuDat.Enabled = false;
            this.btnLayDuLieuPhieuDat.Location = new System.Drawing.Point(451, 155);
            this.btnLayDuLieuPhieuDat.Name = "btnLayDuLieuPhieuDat";
            this.btnLayDuLieuPhieuDat.Size = new System.Drawing.Size(142, 29);
            this.btnLayDuLieuPhieuDat.TabIndex = 30;
            this.btnLayDuLieuPhieuDat.Text = "Lấy dữ liệu từ PD";
            this.btnLayDuLieuPhieuDat.UseVisualStyleBackColor = true;
            this.btnLayDuLieuPhieuDat.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMaxTgThue
            // 
            this.txtMaxTgThue.Enabled = false;
            this.txtMaxTgThue.Location = new System.Drawing.Point(516, 353);
            this.txtMaxTgThue.Name = "txtMaxTgThue";
            this.txtMaxTgThue.Size = new System.Drawing.Size(187, 23);
            this.txtMaxTgThue.TabIndex = 29;
            // 
            // txtTongThoiGianThue
            // 
            this.txtTongThoiGianThue.Enabled = false;
            this.txtTongThoiGianThue.Location = new System.Drawing.Point(196, 353);
            this.txtTongThoiGianThue.Name = "txtTongThoiGianThue";
            this.txtTongThoiGianThue.Size = new System.Drawing.Size(187, 23);
            this.txtTongThoiGianThue.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Giờ thuê tối đa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tổng thời gian thuê:";
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPT, "NGAYLAPPHIEU", true));
            this.txtNgayLap.EditValue = null;
            this.txtNgayLap.Location = new System.Drawing.Point(454, 17);
            this.txtNgayLap.MenuManager = this.barManager1;
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayLap.Size = new System.Drawing.Size(125, 22);
            this.txtNgayLap.TabIndex = 25;
            // 
            // btnChonPhong
            // 
            this.btnChonPhong.Enabled = false;
            this.btnChonPhong.Location = new System.Drawing.Point(196, 219);
            this.btnChonPhong.Name = "btnChonPhong";
            this.btnChonPhong.Size = new System.Drawing.Size(133, 27);
            this.btnChonPhong.TabIndex = 24;
            this.btnChonPhong.Text = "Chọn phòng";
            this.btnChonPhong.UseVisualStyleBackColor = true;
            this.btnChonPhong.Click += new System.EventHandler(this.btnChonPhong_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPT, "GHICHU", true));
            this.txtGhiChu.Location = new System.Drawing.Point(516, 257);
            this.txtGhiChu.MenuManager = this.barManager1;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(186, 22);
            this.txtGhiChu.TabIndex = 19;
            // 
            // bdsCTPT
            // 
            this.bdsCTPT.DataMember = "FK__CTPHIEUTHU__MAPT__5629CD9C";
            this.bdsCTPT.DataSource = this.bdsPT;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPT, "MAPHONG", true));
            this.txtMaPhong.Enabled = false;
            this.txtMaPhong.Location = new System.Drawing.Point(196, 257);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(182, 23);
            this.txtMaPhong.TabIndex = 17;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(12, 190);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(811, 23);
            this.separatorControl1.TabIndex = 15;
            // 
            // cbxKH
            // 
            this.cbxKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "TEN", true));
            this.cbxKH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPT, "MAKH", true));
            this.cbxKH.DataSource = this.bdsKH;
            this.cbxKH.DisplayMember = "TEN";
            this.cbxKH.FormattingEnabled = true;
            this.cbxKH.Location = new System.Drawing.Point(196, 109);
            this.cbxKH.Name = "cbxKH";
            this.cbxKH.Size = new System.Drawing.Size(121, 24);
            this.cbxKH.TabIndex = 14;
            this.cbxKH.ValueMember = "MAKH";
            this.cbxKH.SelectedIndexChanged += new System.EventHandler(this.cbxKH_SelectedIndexChanged);
            // 
            // bdsKH
            // 
            this.bdsKH.DataMember = "KHACHHANG";
            this.bdsKH.DataSource = this.DS;
            // 
            // cbxNV
            // 
            this.cbxNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "TEN", true));
            this.cbxNV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPT, "MANV", true));
            this.cbxNV.DataSource = this.bdsNV;
            this.cbxNV.DisplayMember = "TEN";
            this.cbxNV.FormattingEnabled = true;
            this.cbxNV.Location = new System.Drawing.Point(196, 62);
            this.cbxNV.Name = "cbxNV";
            this.cbxNV.Size = new System.Drawing.Size(121, 24);
            this.cbxNV.TabIndex = 12;
            this.cbxNV.ValueMember = "MANV";
            this.cbxNV.SelectedIndexChanged += new System.EventHandler(this.cbxNV_SelectedIndexChanged);
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "NHANVIEN";
            this.bdsNV.DataSource = this.DS;
            // 
            // txtMaPD
            // 
            this.txtMaPD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPT, "MAPD", true));
            this.txtMaPD.Enabled = false;
            this.txtMaPD.Location = new System.Drawing.Point(335, 158);
            this.txtMaPD.Name = "txtMaPD";
            this.txtMaPD.Size = new System.Drawing.Size(100, 23);
            this.txtMaPD.TabIndex = 8;
            // 
            // txtMaKH
            // 
            this.txtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPT, "MAKH", true));
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(454, 109);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 23);
            this.txtMaKH.TabIndex = 6;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPT, "MANV", true));
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(454, 62);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 23);
            this.txtMaNV.TabIndex = 4;
            // 
            // txtMaPT
            // 
            this.txtMaPT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPT, "MAPT", true));
            this.txtMaPT.Enabled = false;
            this.txtMaPT.Location = new System.Drawing.Point(196, 17);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(121, 23);
            this.txtMaPT.TabIndex = 2;
            // 
            // btnChonPD
            // 
            this.btnChonPD.Location = new System.Drawing.Point(147, 156);
            this.btnChonPD.Name = "btnChonPD";
            this.btnChonPD.Size = new System.Drawing.Size(127, 28);
            this.btnChonPD.TabIndex = 0;
            this.btnChonPD.Text = " Chọn phiếu đặt";
            this.btnChonPD.UseVisualStyleBackColor = true;
            this.btnChonPD.Click += new System.EventHandler(this.btnChonPD_Click);
            // 
            // spnNgayGioDen
            // 
            this.spnNgayGioDen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPT, "NGAYGIODEN", true));
            this.spnNgayGioDen.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnNgayGioDen.Enabled = false;
            this.spnNgayGioDen.Location = new System.Drawing.Point(196, 300);
            this.spnNgayGioDen.MenuManager = this.barManager1;
            this.spnNgayGioDen.Name = "spnNgayGioDen";
            this.spnNgayGioDen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnNgayGioDen.Properties.Mask.EditMask = "g";
            this.spnNgayGioDen.Size = new System.Drawing.Size(182, 24);
            this.spnNgayGioDen.TabIndex = 21;
            // 
            // spnNgayGioDi
            // 
            this.spnNgayGioDi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPT, "NGAYGIODI", true));
            this.spnNgayGioDi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnNgayGioDi.Location = new System.Drawing.Point(516, 300);
            this.spnNgayGioDi.MenuManager = this.barManager1;
            this.spnNgayGioDi.Name = "spnNgayGioDi";
            this.spnNgayGioDi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnNgayGioDi.Properties.Mask.EditMask = "g";
            this.spnNgayGioDi.Size = new System.Drawing.Size(187, 24);
            this.spnNgayGioDi.TabIndex = 23;
            this.spnNgayGioDi.EditValueChanged += new System.EventHandler(this.spnNgayGioDi_EditValueChanged);
            // 
            // bdsPD
            // 
            this.bdsPD.DataMember = "PHIEUDAT";
            this.bdsPD.DataSource = this.DS;
            // 
            // pHIEUDATTableAdapter
            // 
            this.pHIEUDATTableAdapter.ClearBeforeFill = true;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // cTPHIEUTHUETableAdapter
            // 
            this.cTPHIEUTHUETableAdapter.ClearBeforeFill = true;
            // 
            // gcCTPT
            // 
            this.gcCTPT.DataSource = this.bdsCTPT;
            this.gcCTPT.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcCTPT.Location = new System.Drawing.Point(837, 226);
            this.gcCTPT.MainView = this.gridView2;
            this.gcCTPT.MenuManager = this.barManager1;
            this.gcCTPT.Name = "gcCTPT";
            this.gcCTPT.Size = new System.Drawing.Size(583, 282);
            this.gcCTPT.TabIndex = 22;
            this.gcCTPT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPT1,
            this.colMAPHONG,
            this.colGHICHU,
            this.colNGAYGIODEN,
            this.colNGAYGIODI});
            this.gridView2.GridControl = this.gcCTPT;
            this.gridView2.Name = "gridView2";
            // 
            // colMAPT1
            // 
            this.colMAPT1.FieldName = "MAPT";
            this.colMAPT1.MinWidth = 25;
            this.colMAPT1.Name = "colMAPT1";
            this.colMAPT1.Visible = true;
            this.colMAPT1.VisibleIndex = 0;
            this.colMAPT1.Width = 94;
            // 
            // colMAPHONG
            // 
            this.colMAPHONG.FieldName = "MAPHONG";
            this.colMAPHONG.MinWidth = 25;
            this.colMAPHONG.Name = "colMAPHONG";
            this.colMAPHONG.Visible = true;
            this.colMAPHONG.VisibleIndex = 1;
            this.colMAPHONG.Width = 94;
            // 
            // colGHICHU
            // 
            this.colGHICHU.FieldName = "GHICHU";
            this.colGHICHU.MinWidth = 25;
            this.colGHICHU.Name = "colGHICHU";
            this.colGHICHU.Visible = true;
            this.colGHICHU.VisibleIndex = 2;
            this.colGHICHU.Width = 94;
            // 
            // colNGAYGIODEN
            // 
            this.colNGAYGIODEN.DisplayFormat.FormatString = "g";
            this.colNGAYGIODEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYGIODEN.FieldName = "NGAYGIODEN";
            this.colNGAYGIODEN.MinWidth = 25;
            this.colNGAYGIODEN.Name = "colNGAYGIODEN";
            this.colNGAYGIODEN.Visible = true;
            this.colNGAYGIODEN.VisibleIndex = 3;
            this.colNGAYGIODEN.Width = 94;
            // 
            // colNGAYGIODI
            // 
            this.colNGAYGIODI.DisplayFormat.FormatString = "g";
            this.colNGAYGIODI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYGIODI.FieldName = "NGAYGIODI";
            this.colNGAYGIODI.MinWidth = 25;
            this.colNGAYGIODI.Name = "colNGAYGIODI";
            this.colNGAYGIODI.Visible = true;
            this.colNGAYGIODI.VisibleIndex = 4;
            this.colNGAYGIODI.Width = 94;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemCT,
            this.btnGhiCT,
            this.btnXoaCT,
            this.btnHuyCT});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 100);
            // 
            // btnThemCT
            // 
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(164, 24);
            this.btnThemCT.Text = "Thêm chi tiết";
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // btnGhiCT
            // 
            this.btnGhiCT.Name = "btnGhiCT";
            this.btnGhiCT.Size = new System.Drawing.Size(164, 24);
            this.btnGhiCT.Text = "Ghi chi tiết";
            this.btnGhiCT.Click += new System.EventHandler(this.btnGhiCT_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(164, 24);
            this.btnXoaCT.Text = "Xóa chi tiết";
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnHuyCT
            // 
            this.btnHuyCT.Enabled = false;
            this.btnHuyCT.Name = "btnHuyCT";
            this.btnHuyCT.Size = new System.Drawing.Size(164, 24);
            this.btnHuyCT.Text = "Hủy";
            this.btnHuyCT.Click += new System.EventHandler(this.btnHuyCT_Click);
            // 
            // cTDICHVUTableAdapter
            // 
            this.cTDICHVUTableAdapter.ClearBeforeFill = true;
            // 
            // gcCTDV
            // 
            this.gcCTDV.DataSource = this.bdsCTDV;
            this.gcCTDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTDV.Location = new System.Drawing.Point(837, 508);
            this.gcCTDV.MainView = this.gridView3;
            this.gcCTDV.MenuManager = this.barManager1;
            this.gcCTDV.Name = "gcCTDV";
            this.gcCTDV.Size = new System.Drawing.Size(583, 278);
            this.gcCTDV.TabIndex = 27;
            this.gcCTDV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMADV,
            this.colGHICHU1,
            this.colMAPT2,
            this.colSOLUONG});
            this.gridView3.GridControl = this.gcCTDV;
            this.gridView3.Name = "gridView3";
            // 
            // colMADV
            // 
            this.colMADV.FieldName = "MADV";
            this.colMADV.MinWidth = 25;
            this.colMADV.Name = "colMADV";
            this.colMADV.Visible = true;
            this.colMADV.VisibleIndex = 0;
            this.colMADV.Width = 94;
            // 
            // colGHICHU1
            // 
            this.colGHICHU1.FieldName = "GHICHU";
            this.colGHICHU1.MinWidth = 25;
            this.colGHICHU1.Name = "colGHICHU1";
            this.colGHICHU1.Visible = true;
            this.colGHICHU1.VisibleIndex = 1;
            this.colGHICHU1.Width = 94;
            // 
            // colMAPT2
            // 
            this.colMAPT2.FieldName = "MAPT";
            this.colMAPT2.MinWidth = 25;
            this.colMAPT2.Name = "colMAPT2";
            this.colMAPT2.Visible = true;
            this.colMAPT2.VisibleIndex = 2;
            this.colMAPT2.Width = 94;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 3;
            this.colSOLUONG.Width = 94;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // frmPhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 786);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.gcCTDV);
            this.Controls.Add(this.gcCTPT);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.gcPT);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuThue";
            this.Text = "frmPhieuThue";
            this.Load += new System.EventHandler(this.frmPhieuThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnNgayGioDen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnNgayGioDi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private System.Windows.Forms.BindingSource bdsPT;
        private DS DS;
        private DSTableAdapters.PHIEUTHUETableAdapter pHIEUTHUETableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelInput;
        private DevExpress.XtraGrid.GridControl gcPT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnChonPD;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPT;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYLAPPHIEU;
        private System.Windows.Forms.BindingSource bdsPD;
        private DSTableAdapters.PHIEUDATTableAdapter pHIEUDATTableAdapter;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.TextBox txtMaPD;
        private System.Windows.Forms.BindingSource bdsNV;
        private DSTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.ComboBox cbxNV;
        private System.Windows.Forms.BindingSource bdsKH;
        private DSTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.ComboBox cbxKH;
        private DSTableAdapters.CTPHIEUTHUETableAdapter cTPHIEUTHUETableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPT;
        private DevExpress.XtraGrid.GridControl gcCTPT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPT1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn colGHICHU;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGIODEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGIODI;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemCT;
        private System.Windows.Forms.ToolStripMenuItem btnGhiCT;
        private System.Windows.Forms.ToolStripMenuItem btnXoaCT;
        private System.Windows.Forms.ToolStripMenuItem btnHuyCT;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private System.Windows.Forms.TextBox txtMaPhong;
        private DevExpress.XtraEditors.TimeEdit spnNgayGioDen;
        private System.Windows.Forms.Button btnChonPhong;
        private DevExpress.XtraEditors.TimeEdit spnNgayGioDi;
        private DevExpress.XtraEditors.DateEdit txtNgayLap;
        private System.Windows.Forms.TextBox txtMaxTgThue;
        private System.Windows.Forms.TextBox txtTongThoiGianThue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLayDuLieuPhieuDat;
        private System.Windows.Forms.BindingSource bdsCTDV;
        private DSTableAdapters.CTDICHVUTableAdapter cTDICHVUTableAdapter;
        private DevExpress.XtraGrid.GridControl gcCTDV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colMADV;
        private DevExpress.XtraGrid.Columns.GridColumn colGHICHU1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPT2;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private System.Windows.Forms.Button btnChonDV;
        private DevExpress.XtraEditors.SpinEdit spnSoLuong;
        private System.Windows.Forms.TextBox txtGhiChuDV;
        private System.Windows.Forms.TextBox txtMaDV;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private System.Windows.Forms.Button btnHuyCTDV;
        private System.Windows.Forms.Button btnXoaCTDV;
        private System.Windows.Forms.Button btnGhiCTDV;
        private System.Windows.Forms.Button btnThemCTDV;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}