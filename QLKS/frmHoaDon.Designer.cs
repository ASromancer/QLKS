
namespace QLKS
{
    partial class frmHoaDon
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
            System.Windows.Forms.Label mAHDLabel;
            System.Windows.Forms.Label gHICHULabel;
            System.Windows.Forms.Label mAPTLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label nGAYTAOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.DS = new QLKS.DS();
            this.bdsHD = new System.Windows.Forms.BindingSource(this.components);
            this.hOADONTableAdapter = new QLKS.DSTableAdapters.HOADONTableAdapter();
            this.tableAdapterManager = new QLKS.DSTableAdapters.TableAdapterManager();
            this.gcHD = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTONGTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAPT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelInput = new DevExpress.XtraEditors.PanelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.btnXuatCTHoaDon = new System.Windows.Forms.Button();
            this.btnChonPT = new System.Windows.Forms.Button();
            this.txtNgayTao = new DevExpress.XtraEditors.TimeEdit();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.bdsPT = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUTHUETableAdapter = new QLKS.DSTableAdapters.PHIEUTHUETableAdapter();
            mAHDLabel = new System.Windows.Forms.Label();
            gHICHULabel = new System.Windows.Forms.Label();
            mAPTLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            nGAYTAOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).BeginInit();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayTao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPT)).BeginInit();
            this.SuspendLayout();
            // 
            // mAHDLabel
            // 
            mAHDLabel.AutoSize = true;
            mAHDLabel.Location = new System.Drawing.Point(96, 43);
            mAHDLabel.Name = "mAHDLabel";
            mAHDLabel.Size = new System.Drawing.Size(50, 17);
            mAHDLabel.TabIndex = 0;
            mAHDLabel.Text = "MAHD:";
            // 
            // gHICHULabel
            // 
            gHICHULabel.AutoSize = true;
            gHICHULabel.Location = new System.Drawing.Point(84, 110);
            gHICHULabel.Name = "gHICHULabel";
            gHICHULabel.Size = new System.Drawing.Size(62, 17);
            gHICHULabel.TabIndex = 2;
            gHICHULabel.Text = "GHICHU:";
            // 
            // mAPTLabel
            // 
            mAPTLabel.AutoSize = true;
            mAPTLabel.Location = new System.Drawing.Point(374, 179);
            mAPTLabel.Name = "mAPTLabel";
            mAPTLabel.Size = new System.Drawing.Size(47, 17);
            mAPTLabel.TabIndex = 4;
            mAPTLabel.Text = "MAPT:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(373, 110);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(48, 17);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "MANV:";
            // 
            // nGAYTAOLabel
            // 
            nGAYTAOLabel.AutoSize = true;
            nGAYTAOLabel.Location = new System.Drawing.Point(348, 43);
            nGAYTAOLabel.Name = "nGAYTAOLabel";
            nGAYTAOLabel.Size = new System.Drawing.Size(73, 17);
            nGAYTAOLabel.TabIndex = 8;
            nGAYTAOLabel.Text = "NGAYTAO:";
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
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1376, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 670);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1376, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 640);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(1376, 30);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(0, 640);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsHD
            // 
            this.bdsHD.DataMember = "HOADON";
            this.bdsHD.DataSource = this.DS;
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.HOADONTableAdapter = this.hOADONTableAdapter;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KIEUPHONGTableAdapter = null;
            this.tableAdapterManager.LOAIPHONGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUDATTableAdapter = null;
            this.tableAdapterManager.PHIEUTHUE_CHUA_HOADONTableAdapter = null;
            this.tableAdapterManager.PHIEUTHUETableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLKS.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcHD
            // 
            this.gcHD.DataSource = this.bdsHD;
            this.gcHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcHD.Location = new System.Drawing.Point(0, 30);
            this.gcHD.MainView = this.gridView1;
            this.gcHD.MenuManager = this.barManager1;
            this.gcHD.Name = "gcHD";
            this.gcHD.Size = new System.Drawing.Size(1376, 229);
            this.gcHD.TabIndex = 5;
            this.gcHD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHD,
            this.colTONGTIEN,
            this.colGHICHU,
            this.colMAPT,
            this.colMANV,
            this.colNGAYTAO});
            this.gridView1.GridControl = this.gcHD;
            this.gridView1.Name = "gridView1";
            // 
            // colMAHD
            // 
            this.colMAHD.FieldName = "MAHD";
            this.colMAHD.MinWidth = 25;
            this.colMAHD.Name = "colMAHD";
            this.colMAHD.Visible = true;
            this.colMAHD.VisibleIndex = 0;
            this.colMAHD.Width = 94;
            // 
            // colTONGTIEN
            // 
            this.colTONGTIEN.FieldName = "TONGTIEN";
            this.colTONGTIEN.MinWidth = 25;
            this.colTONGTIEN.Name = "colTONGTIEN";
            this.colTONGTIEN.Visible = true;
            this.colTONGTIEN.VisibleIndex = 1;
            this.colTONGTIEN.Width = 94;
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
            // colMAPT
            // 
            this.colMAPT.FieldName = "MAPT";
            this.colMAPT.MinWidth = 25;
            this.colMAPT.Name = "colMAPT";
            this.colMAPT.Visible = true;
            this.colMAPT.VisibleIndex = 3;
            this.colMAPT.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 4;
            this.colMANV.Width = 94;
            // 
            // colNGAYTAO
            // 
            this.colNGAYTAO.FieldName = "NGAYTAO";
            this.colNGAYTAO.MinWidth = 25;
            this.colNGAYTAO.Name = "colNGAYTAO";
            this.colNGAYTAO.Visible = true;
            this.colNGAYTAO.VisibleIndex = 5;
            this.colNGAYTAO.Width = 94;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.separatorControl1);
            this.panelInput.Controls.Add(this.btnXuatCTHoaDon);
            this.panelInput.Controls.Add(this.btnChonPT);
            this.panelInput.Controls.Add(nGAYTAOLabel);
            this.panelInput.Controls.Add(this.txtNgayTao);
            this.panelInput.Controls.Add(mANVLabel);
            this.panelInput.Controls.Add(this.txtMaNV);
            this.panelInput.Controls.Add(mAPTLabel);
            this.panelInput.Controls.Add(this.txtMaPT);
            this.panelInput.Controls.Add(gHICHULabel);
            this.panelInput.Controls.Add(this.txtGhiChu);
            this.panelInput.Controls.Add(mAHDLabel);
            this.panelInput.Controls.Add(this.txtMaHD);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(0, 259);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1376, 411);
            this.panelInput.TabIndex = 6;
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(685, 6);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(30, 400);
            this.separatorControl1.TabIndex = 12;
            // 
            // btnXuatCTHoaDon
            // 
            this.btnXuatCTHoaDon.Location = new System.Drawing.Point(802, 43);
            this.btnXuatCTHoaDon.Name = "btnXuatCTHoaDon";
            this.btnXuatCTHoaDon.Size = new System.Drawing.Size(161, 41);
            this.btnXuatCTHoaDon.TabIndex = 11;
            this.btnXuatCTHoaDon.Text = "Xem chi tiết hóa đơn";
            this.btnXuatCTHoaDon.UseVisualStyleBackColor = true;
            this.btnXuatCTHoaDon.Click += new System.EventHandler(this.btnXuatCTHoaDon_Click);
            // 
            // btnChonPT
            // 
            this.btnChonPT.Enabled = false;
            this.btnChonPT.Location = new System.Drawing.Point(135, 167);
            this.btnChonPT.Name = "btnChonPT";
            this.btnChonPT.Size = new System.Drawing.Size(161, 41);
            this.btnChonPT.TabIndex = 10;
            this.btnChonPT.Text = "Chọn phiếu thuê";
            this.btnChonPT.UseVisualStyleBackColor = true;
            this.btnChonPT.Click += new System.EventHandler(this.btnChonPT_Click);
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHD, "NGAYTAO", true));
            this.txtNgayTao.EditValue = new System.DateTime(2022, 5, 30, 0, 0, 0, 0);
            this.txtNgayTao.Location = new System.Drawing.Point(427, 39);
            this.txtNgayTao.MenuManager = this.barManager1;
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayTao.Properties.Mask.EditMask = "g";
            this.txtNgayTao.Properties.ReadOnly = true;
            this.txtNgayTao.Size = new System.Drawing.Size(185, 24);
            this.txtNgayTao.TabIndex = 9;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHD, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(427, 107);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(100, 23);
            this.txtMaNV.TabIndex = 7;
            // 
            // txtMaPT
            // 
            this.txtMaPT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHD, "MAPT", true));
            this.txtMaPT.Location = new System.Drawing.Point(427, 176);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.ReadOnly = true;
            this.txtMaPT.Size = new System.Drawing.Size(100, 23);
            this.txtMaPT.TabIndex = 5;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHD, "GHICHU", true));
            this.txtGhiChu.Location = new System.Drawing.Point(152, 107);
            this.txtGhiChu.MenuManager = this.barManager1;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(125, 22);
            this.txtGhiChu.TabIndex = 3;
            // 
            // txtMaHD
            // 
            this.txtMaHD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHD, "MAHD", true));
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Location = new System.Drawing.Point(152, 40);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(125, 23);
            this.txtMaHD.TabIndex = 1;
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
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 670);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.gcHD);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayTao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPT)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private System.Windows.Forms.BindingSource bdsHD;
        private DS DS;
        private DSTableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcHD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelInput;
        private System.Windows.Forms.TextBox txtMaHD;
        private DevExpress.XtraEditors.TimeEdit txtNgayTao;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaPT;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHD;
        private DevExpress.XtraGrid.Columns.GridColumn colTONGTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colGHICHU;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPT;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTAO;
        private System.Windows.Forms.BindingSource bdsPT;
        private DSTableAdapters.PHIEUTHUETableAdapter pHIEUTHUETableAdapter;
        private System.Windows.Forms.Button btnChonPT;
        private System.Windows.Forms.Button btnXuatCTHoaDon;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
    }
}