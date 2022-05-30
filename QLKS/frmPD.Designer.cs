
namespace QLKS
{
    partial class frmPD
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
            System.Windows.Forms.Label mAPDLabel;
            System.Windows.Forms.Label nGAYLAPPHIEULabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label tENLabel1;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label gHICHULabel;
            System.Windows.Forms.Label mAPHONGLabel;
            System.Windows.Forms.Label nGAYGIO_TRAPHONGLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label nGAYBATDAUTHUELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPD));
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
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DS = new QLKS.DS();
            this.bdsPD = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUDATTableAdapter = new QLKS.DSTableAdapters.PHIEUDATTableAdapter();
            this.tableAdapterManager = new QLKS.DSTableAdapters.TableAdapterManager();
            this.cTPHIEUDATTableAdapter = new QLKS.DSTableAdapters.CTPHIEUDATTableAdapter();
            this.kHACHHANGTableAdapter = new QLKS.DSTableAdapters.KHACHHANGTableAdapter();
            this.nHANVIENTableAdapter = new QLKS.DSTableAdapters.NHANVIENTableAdapter();
            this.gcPD = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYBATDAUTHUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYLAPPHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelInput = new DevExpress.XtraEditors.PanelControl();
            this.txtNgayBatDauThue = new DevExpress.XtraEditors.TimeEdit();
            this.txtMaxTgThue = new DevExpress.XtraEditors.TextEdit();
            this.txtTongThoiGianThue = new DevExpress.XtraEditors.TextEdit();
            this.spnNgayGioTraPhong = new DevExpress.XtraEditors.TimeEdit();
            this.bdsCTPD = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.btnChonHP = new System.Windows.Forms.Button();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.cbxKH = new System.Windows.Forms.ComboBox();
            this.bdsKH = new System.Windows.Forms.BindingSource(this.components);
            this.cbxNV = new System.Windows.Forms.ComboBox();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.txtNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.txtMaPD = new System.Windows.Forms.TextBox();
            this.gcCTPD = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGIO_TRAPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemCT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiCT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaCT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHuyCT = new System.Windows.Forms.ToolStripMenuItem();
            mAPDLabel = new System.Windows.Forms.Label();
            nGAYLAPPHIEULabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            tENLabel1 = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            gHICHULabel = new System.Windows.Forms.Label();
            mAPHONGLabel = new System.Windows.Forms.Label();
            nGAYGIO_TRAPHONGLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            nGAYBATDAUTHUELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).BeginInit();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBatDauThue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxTgThue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongThoiGianThue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnNgayGioTraPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAPDLabel
            // 
            mAPDLabel.AutoSize = true;
            mAPDLabel.Location = new System.Drawing.Point(112, 26);
            mAPDLabel.Name = "mAPDLabel";
            mAPDLabel.Size = new System.Drawing.Size(49, 17);
            mAPDLabel.TabIndex = 0;
            mAPDLabel.Text = "MAPD:";
            // 
            // nGAYLAPPHIEULabel
            // 
            nGAYLAPPHIEULabel.AutoSize = true;
            nGAYLAPPHIEULabel.Location = new System.Drawing.Point(406, 68);
            nGAYLAPPHIEULabel.Name = "nGAYLAPPHIEULabel";
            nGAYLAPPHIEULabel.Size = new System.Drawing.Size(108, 17);
            nGAYLAPPHIEULabel.TabIndex = 9;
            nGAYLAPPHIEULabel.Text = "NGAYLAPPHIEU:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(107, 116);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(59, 17);
            tENLabel.TabIndex = 14;
            tENLabel.Text = "TEN NV:";
            // 
            // tENLabel1
            // 
            tENLabel1.AutoSize = true;
            tENLabel1.Location = new System.Drawing.Point(81, 171);
            tENLabel1.Name = "tENLabel1";
            tENLabel1.Size = new System.Drawing.Size(85, 17);
            tENLabel1.TabIndex = 15;
            tENLabel1.Text = "TEN KHACH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(403, 116);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(48, 17);
            mANVLabel.TabIndex = 16;
            mANVLabel.Text = "MANV:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(403, 171);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(48, 17);
            mAKHLabel.TabIndex = 17;
            mAKHLabel.Text = "MAKH:";
            // 
            // gHICHULabel
            // 
            gHICHULabel.AutoSize = true;
            gHICHULabel.Location = new System.Drawing.Point(99, 336);
            gHICHULabel.Name = "gHICHULabel";
            gHICHULabel.Size = new System.Drawing.Size(62, 17);
            gHICHULabel.TabIndex = 19;
            gHICHULabel.Text = "GHICHU:";
            // 
            // mAPHONGLabel
            // 
            mAPHONGLabel.AutoSize = true;
            mAPHONGLabel.Location = new System.Drawing.Point(332, 272);
            mAPHONGLabel.Name = "mAPHONGLabel";
            mAPHONGLabel.Size = new System.Drawing.Size(76, 17);
            mAPHONGLabel.TabIndex = 23;
            mAPHONGLabel.Text = "MAPHONG:";
            // 
            // nGAYGIO_TRAPHONGLabel
            // 
            nGAYGIO_TRAPHONGLabel.AutoSize = true;
            nGAYGIO_TRAPHONGLabel.Location = new System.Drawing.Point(307, 336);
            nGAYGIO_TRAPHONGLabel.Name = "nGAYGIO_TRAPHONGLabel";
            nGAYGIO_TRAPHONGLabel.Size = new System.Drawing.Size(144, 17);
            nGAYGIO_TRAPHONGLabel.TabIndex = 24;
            nGAYGIO_TRAPHONGLabel.Text = "NGAYGIO TRAPHONG:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(195, 465);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 17);
            label1.TabIndex = 26;
            label1.Text = "Giờ thuê tối đa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(164, 412);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(128, 17);
            label2.TabIndex = 28;
            label2.Text = "Tổng thời gian thuê";
            // 
            // nGAYBATDAUTHUELabel
            // 
            nGAYBATDAUTHUELabel.AutoSize = true;
            nGAYBATDAUTHUELabel.Location = new System.Drawing.Point(34, 67);
            nGAYBATDAUTHUELabel.Name = "nGAYBATDAUTHUELabel";
            nGAYBATDAUTHUELabel.Size = new System.Drawing.Size(132, 17);
            nGAYBATDAUTHUELabel.TabIndex = 30;
            nGAYBATDAUTHUELabel.Text = "NGAYBATDAUTHUE:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnThoat,
            this.btnHuy,
            this.btnLamMoi,
            this.btnGhi});
            this.barManager1.MaxItemId = 8;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            this.barDockControlTop.Size = new System.Drawing.Size(1321, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 766);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1321, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 736);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1321, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 736);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOPHANTableAdapter = null;
            this.tableAdapterManager.CT_TRANGTHAIPHONGTableAdapter = null;
            this.tableAdapterManager.CTDICHVUTableAdapter = null;
            this.tableAdapterManager.CTPHIEUDATTableAdapter = this.cTPHIEUDATTableAdapter;
            this.tableAdapterManager.CTPHIEUTHUETableAdapter = null;
            this.tableAdapterManager.DICHVUTableAdapter = null;
            this.tableAdapterManager.DS_PD_CHUACO_PTTableAdapter = null;
            this.tableAdapterManager.HANGPHONGTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = this.kHACHHANGTableAdapter;
            this.tableAdapterManager.KIEUPHONGTableAdapter = null;
            this.tableAdapterManager.LOAIPHONGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.nHANVIENTableAdapter;
            this.tableAdapterManager.PHIEUDATTableAdapter = this.pHIEUDATTableAdapter;
            this.tableAdapterManager.PHIEUTHUETableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLKS.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cTPHIEUDATTableAdapter
            // 
            this.cTPHIEUDATTableAdapter.ClearBeforeFill = true;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // gcPD
            // 
            this.gcPD.DataSource = this.bdsPD;
            this.gcPD.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPD.Location = new System.Drawing.Point(0, 30);
            this.gcPD.MainView = this.gridView1;
            this.gcPD.MenuManager = this.barManager1;
            this.gcPD.Name = "gcPD";
            this.gcPD.Size = new System.Drawing.Size(1321, 187);
            this.gcPD.TabIndex = 5;
            this.gcPD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPD,
            this.colNGAYBATDAUTHUE,
            this.colNGAYLAPPHIEU,
            this.colMANV,
            this.colMAKH});
            this.gridView1.GridControl = this.gcPD;
            this.gridView1.Name = "gridView1";
            // 
            // colMAPD
            // 
            this.colMAPD.FieldName = "MAPD";
            this.colMAPD.MinWidth = 25;
            this.colMAPD.Name = "colMAPD";
            this.colMAPD.Visible = true;
            this.colMAPD.VisibleIndex = 0;
            this.colMAPD.Width = 94;
            // 
            // colNGAYBATDAUTHUE
            // 
            this.colNGAYBATDAUTHUE.FieldName = "NGAYBATDAUTHUE";
            this.colNGAYBATDAUTHUE.MinWidth = 25;
            this.colNGAYBATDAUTHUE.Name = "colNGAYBATDAUTHUE";
            this.colNGAYBATDAUTHUE.Visible = true;
            this.colNGAYBATDAUTHUE.VisibleIndex = 1;
            this.colNGAYBATDAUTHUE.Width = 94;
            // 
            // colNGAYLAPPHIEU
            // 
            this.colNGAYLAPPHIEU.FieldName = "NGAYLAPPHIEU";
            this.colNGAYLAPPHIEU.MinWidth = 25;
            this.colNGAYLAPPHIEU.Name = "colNGAYLAPPHIEU";
            this.colNGAYLAPPHIEU.Visible = true;
            this.colNGAYLAPPHIEU.VisibleIndex = 2;
            this.colNGAYLAPPHIEU.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 94;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 25;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 4;
            this.colMAKH.Width = 94;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(nGAYBATDAUTHUELabel);
            this.panelInput.Controls.Add(this.txtNgayBatDauThue);
            this.panelInput.Controls.Add(this.txtMaxTgThue);
            this.panelInput.Controls.Add(this.txtTongThoiGianThue);
            this.panelInput.Controls.Add(label2);
            this.panelInput.Controls.Add(label1);
            this.panelInput.Controls.Add(nGAYGIO_TRAPHONGLabel);
            this.panelInput.Controls.Add(this.spnNgayGioTraPhong);
            this.panelInput.Controls.Add(mAPHONGLabel);
            this.panelInput.Controls.Add(this.txtMaPhong);
            this.panelInput.Controls.Add(this.btnChonHP);
            this.panelInput.Controls.Add(gHICHULabel);
            this.panelInput.Controls.Add(this.txtGhiChu);
            this.panelInput.Controls.Add(mAKHLabel);
            this.panelInput.Controls.Add(this.txtMaKH);
            this.panelInput.Controls.Add(mANVLabel);
            this.panelInput.Controls.Add(this.txtMaNV);
            this.panelInput.Controls.Add(tENLabel1);
            this.panelInput.Controls.Add(this.cbxKH);
            this.panelInput.Controls.Add(tENLabel);
            this.panelInput.Controls.Add(this.cbxNV);
            this.panelInput.Controls.Add(nGAYLAPPHIEULabel);
            this.panelInput.Controls.Add(this.txtNgayLap);
            this.panelInput.Controls.Add(this.separatorControl1);
            this.panelInput.Controls.Add(mAPDLabel);
            this.panelInput.Controls.Add(this.txtMaPD);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput.Location = new System.Drawing.Point(0, 217);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(757, 549);
            this.panelInput.TabIndex = 6;
            // 
            // txtNgayBatDauThue
            // 
            this.txtNgayBatDauThue.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPD, "NGAYBATDAUTHUE", true));
            this.txtNgayBatDauThue.EditValue = new System.DateTime(2022, 5, 29, 0, 0, 0, 0);
            this.txtNgayBatDauThue.Location = new System.Drawing.Point(172, 64);
            this.txtNgayBatDauThue.MenuManager = this.barManager1;
            this.txtNgayBatDauThue.Name = "txtNgayBatDauThue";
            this.txtNgayBatDauThue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayBatDauThue.Properties.Mask.EditMask = "g";
            this.txtNgayBatDauThue.Size = new System.Drawing.Size(201, 24);
            this.txtNgayBatDauThue.TabIndex = 31;
            // 
            // txtMaxTgThue
            // 
            this.txtMaxTgThue.Location = new System.Drawing.Point(312, 462);
            this.txtMaxTgThue.MenuManager = this.barManager1;
            this.txtMaxTgThue.Name = "txtMaxTgThue";
            this.txtMaxTgThue.Properties.ReadOnly = true;
            this.txtMaxTgThue.Size = new System.Drawing.Size(169, 22);
            this.txtMaxTgThue.TabIndex = 30;
            // 
            // txtTongThoiGianThue
            // 
            this.txtTongThoiGianThue.Location = new System.Drawing.Point(312, 409);
            this.txtTongThoiGianThue.MenuManager = this.barManager1;
            this.txtTongThoiGianThue.Name = "txtTongThoiGianThue";
            this.txtTongThoiGianThue.Properties.ReadOnly = true;
            this.txtTongThoiGianThue.Size = new System.Drawing.Size(169, 22);
            this.txtTongThoiGianThue.TabIndex = 29;
            // 
            // spnNgayGioTraPhong
            // 
            this.spnNgayGioTraPhong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPD, "NGAYGIO_TRAPHONG", true));
            this.spnNgayGioTraPhong.EditValue = new System.DateTime(2022, 5, 29, 0, 0, 0, 0);
            this.spnNgayGioTraPhong.Location = new System.Drawing.Point(457, 333);
            this.spnNgayGioTraPhong.MenuManager = this.barManager1;
            this.spnNgayGioTraPhong.Name = "spnNgayGioTraPhong";
            this.spnNgayGioTraPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnNgayGioTraPhong.Properties.Mask.EditMask = "g";
            this.spnNgayGioTraPhong.Size = new System.Drawing.Size(184, 24);
            this.spnNgayGioTraPhong.TabIndex = 25;
            this.spnNgayGioTraPhong.EditValueChanged += new System.EventHandler(this.spnNgayGioTraPhong_EditValueChanged);
            // 
            // bdsCTPD
            // 
            this.bdsCTPD.DataMember = "FK__CTPHIEUDAT__MAPD__5EBF139D";
            this.bdsCTPD.DataSource = this.bdsPD;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPD, "MAPHONG", true));
            this.txtMaPhong.Enabled = false;
            this.txtMaPhong.Location = new System.Drawing.Point(414, 269);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(100, 23);
            this.txtMaPhong.TabIndex = 24;
            // 
            // btnChonHP
            // 
            this.btnChonHP.Enabled = false;
            this.btnChonHP.Location = new System.Drawing.Point(219, 262);
            this.btnChonHP.Name = "btnChonHP";
            this.btnChonHP.Size = new System.Drawing.Size(104, 37);
            this.btnChonHP.TabIndex = 23;
            this.btnChonHP.Text = "Chọn phòng";
            this.btnChonHP.UseVisualStyleBackColor = true;
            this.btnChonHP.Click += new System.EventHandler(this.btnChonHP_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPD, "GHICHU", true));
            this.txtGhiChu.Location = new System.Drawing.Point(167, 333);
            this.txtGhiChu.MenuManager = this.barManager1;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(125, 22);
            this.txtGhiChu.TabIndex = 20;
            // 
            // txtMaKH
            // 
            this.txtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPD, "MAKH", true));
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(457, 168);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 23);
            this.txtMaKH.TabIndex = 18;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPD, "MANV", true));
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(457, 113);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 23);
            this.txtMaNV.TabIndex = 17;
            // 
            // cbxKH
            // 
            this.cbxKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "TEN", true));
            this.cbxKH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPD, "MAKH", true));
            this.cbxKH.DataSource = this.bdsKH;
            this.cbxKH.DisplayMember = "TEN";
            this.cbxKH.FormattingEnabled = true;
            this.cbxKH.Location = new System.Drawing.Point(172, 168);
            this.cbxKH.Name = "cbxKH";
            this.cbxKH.Size = new System.Drawing.Size(121, 24);
            this.cbxKH.TabIndex = 16;
            this.cbxKH.ValueMember = "MAKH";
            this.cbxKH.SelectedIndexChanged += new System.EventHandler(this.cbxKH_SelectedIndexChanged_1);
            // 
            // bdsKH
            // 
            this.bdsKH.DataMember = "KHACHHANG";
            this.bdsKH.DataSource = this.DS;
            // 
            // cbxNV
            // 
            this.cbxNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "TEN", true));
            this.cbxNV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPD, "MANV", true));
            this.cbxNV.DataSource = this.bdsNV;
            this.cbxNV.DisplayMember = "TEN";
            this.cbxNV.FormattingEnabled = true;
            this.cbxNV.Location = new System.Drawing.Point(172, 113);
            this.cbxNV.Name = "cbxNV";
            this.cbxNV.Size = new System.Drawing.Size(121, 24);
            this.cbxNV.TabIndex = 15;
            this.cbxNV.ValueMember = "MANV";
            this.cbxNV.SelectedIndexChanged += new System.EventHandler(this.cbxNV_SelectedIndexChanged);
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "NHANVIEN";
            this.bdsNV.DataSource = this.DS;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPD, "NGAYLAPPHIEU", true));
            this.txtNgayLap.EditValue = null;
            this.txtNgayLap.Location = new System.Drawing.Point(520, 65);
            this.txtNgayLap.MenuManager = this.barManager1;
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayLap.Size = new System.Drawing.Size(179, 22);
            this.txtNgayLap.TabIndex = 10;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(12, 217);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(745, 23);
            this.separatorControl1.TabIndex = 8;
            // 
            // txtMaPD
            // 
            this.txtMaPD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPD, "MAPD", true));
            this.txtMaPD.Enabled = false;
            this.txtMaPD.Location = new System.Drawing.Point(171, 23);
            this.txtMaPD.Name = "txtMaPD";
            this.txtMaPD.Size = new System.Drawing.Size(121, 23);
            this.txtMaPD.TabIndex = 1;
            // 
            // gcCTPD
            // 
            this.gcCTPD.DataSource = this.bdsCTPD;
            this.gcCTPD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTPD.Location = new System.Drawing.Point(757, 217);
            this.gcCTPD.MainView = this.gridView2;
            this.gcCTPD.MenuManager = this.barManager1;
            this.gcCTPD.Name = "gcCTPD";
            this.gcCTPD.Size = new System.Drawing.Size(564, 549);
            this.gcCTPD.TabIndex = 7;
            this.gcCTPD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPD1,
            this.colGHICHU,
            this.colMAPHONG,
            this.colNGAYGIO_TRAPHONG});
            this.gridView2.GridControl = this.gcCTPD;
            this.gridView2.Name = "gridView2";
            // 
            // colMAPD1
            // 
            this.colMAPD1.FieldName = "MAPD";
            this.colMAPD1.MinWidth = 25;
            this.colMAPD1.Name = "colMAPD1";
            this.colMAPD1.Visible = true;
            this.colMAPD1.VisibleIndex = 0;
            this.colMAPD1.Width = 94;
            // 
            // colGHICHU
            // 
            this.colGHICHU.FieldName = "GHICHU";
            this.colGHICHU.MinWidth = 25;
            this.colGHICHU.Name = "colGHICHU";
            this.colGHICHU.Visible = true;
            this.colGHICHU.VisibleIndex = 1;
            this.colGHICHU.Width = 94;
            // 
            // colMAPHONG
            // 
            this.colMAPHONG.FieldName = "MAPHONG";
            this.colMAPHONG.MinWidth = 25;
            this.colMAPHONG.Name = "colMAPHONG";
            this.colMAPHONG.Visible = true;
            this.colMAPHONG.VisibleIndex = 2;
            this.colMAPHONG.Width = 94;
            // 
            // colNGAYGIO_TRAPHONG
            // 
            this.colNGAYGIO_TRAPHONG.DisplayFormat.FormatString = "g";
            this.colNGAYGIO_TRAPHONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYGIO_TRAPHONG.FieldName = "NGAYGIO_TRAPHONG";
            this.colNGAYGIO_TRAPHONG.MinWidth = 25;
            this.colNGAYGIO_TRAPHONG.Name = "colNGAYGIO_TRAPHONG";
            this.colNGAYGIO_TRAPHONG.Visible = true;
            this.colNGAYGIO_TRAPHONG.VisibleIndex = 3;
            this.colNGAYGIO_TRAPHONG.Width = 94;
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
            this.btnGhiCT.Click += new System.EventHandler(this.xóaChiTiếtToolStripMenuItem_Click);
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
            // frmPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 766);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.gcCTPD);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.gcPD);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPD";
            this.Text = "frmPD";
            this.Load += new System.EventHandler(this.frmPD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBatDauThue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxTgThue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongThoiGianThue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnNgayGioTraPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsPD;
        private DS DS;
        private DSTableAdapters.PHIEUDATTableAdapter pHIEUDATTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelInput;
        private DevExpress.XtraGrid.GridControl gcPD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSTableAdapters.CTPHIEUDATTableAdapter cTPHIEUDATTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPD;
        private DevExpress.XtraGrid.GridControl gcCTPD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemCT;
        private System.Windows.Forms.ToolStripMenuItem btnGhiCT;
        private System.Windows.Forms.ToolStripMenuItem btnXoaCT;
        private System.Windows.Forms.ToolStripMenuItem btnHuyCT;
        private DevExpress.XtraEditors.DateEdit txtNgayLap;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.TextBox txtMaPD;
        private DSTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsNV;
        private DSTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.BindingSource bdsKH;
        private System.Windows.Forms.ComboBox cbxKH;
        private System.Windows.Forms.ComboBox cbxNV;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaNV;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private System.Windows.Forms.Button btnChonHP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYBATDAUTHUE;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYLAPPHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private System.Windows.Forms.TextBox txtMaPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPD1;
        private DevExpress.XtraGrid.Columns.GridColumn colGHICHU;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGIO_TRAPHONG;
        private DevExpress.XtraEditors.TimeEdit spnNgayGioTraPhong;
        private DevExpress.XtraEditors.TextEdit txtMaxTgThue;
        private DevExpress.XtraEditors.TextEdit txtTongThoiGianThue;
        private DevExpress.XtraEditors.TimeEdit txtNgayBatDauThue;
    }
}