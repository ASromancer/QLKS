
namespace QLKS
{
    partial class frmHangPhong
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
            System.Windows.Forms.Label mAHPLabel;
            System.Windows.Forms.Label gIAHANGPHONGLabel;
            System.Windows.Forms.Label tENKIEUPHONGLabel;
            System.Windows.Forms.Label tENLOAIPHONGLabel;
            System.Windows.Forms.Label mALPLabel;
            System.Windows.Forms.Label mAKPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangPhong));
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
            this.bdsHangPhong = new System.Windows.Forms.BindingSource(this.components);
            this.hANGPHONGTableAdapter = new QLKS.DSTableAdapters.HANGPHONGTableAdapter();
            this.tableAdapterManager = new QLKS.DSTableAdapters.TableAdapterManager();
            this.kIEUPHONGTableAdapter = new QLKS.DSTableAdapters.KIEUPHONGTableAdapter();
            this.lOAIPHONGTableAdapter = new QLKS.DSTableAdapters.LOAIPHONGTableAdapter();
            this.pHONGTableAdapter = new QLKS.DSTableAdapters.PHONGTableAdapter();
            this.gcHangPhong = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIAHANGPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelInput = new DevExpress.XtraEditors.PanelControl();
            this.txtKP = new System.Windows.Forms.TextBox();
            this.txtLP = new System.Windows.Forms.TextBox();
            this.cbxLP = new System.Windows.Forms.ComboBox();
            this.bdsLoaiPhong = new System.Windows.Forms.BindingSource(this.components);
            this.cbxKP = new System.Windows.Forms.ComboBox();
            this.bdsKieuPhong = new System.Windows.Forms.BindingSource(this.components);
            this.txtGiaHP = new DevExpress.XtraEditors.TextEdit();
            this.txtMaHP = new DevExpress.XtraEditors.TextEdit();
            this.bdsPhong = new System.Windows.Forms.BindingSource(this.components);
            mAHPLabel = new System.Windows.Forms.Label();
            gIAHANGPHONGLabel = new System.Windows.Forms.Label();
            tENKIEUPHONGLabel = new System.Windows.Forms.Label();
            tENLOAIPHONGLabel = new System.Windows.Forms.Label();
            mALPLabel = new System.Windows.Forms.Label();
            mAKPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHangPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHangPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).BeginInit();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLoaiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKieuPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaHP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // mAHPLabel
            // 
            mAHPLabel.AutoSize = true;
            mAHPLabel.Location = new System.Drawing.Point(124, 34);
            mAHPLabel.Name = "mAHPLabel";
            mAHPLabel.Size = new System.Drawing.Size(48, 17);
            mAHPLabel.TabIndex = 0;
            mAHPLabel.Text = "MAHP:";
            // 
            // gIAHANGPHONGLabel
            // 
            gIAHANGPHONGLabel.AutoSize = true;
            gIAHANGPHONGLabel.Location = new System.Drawing.Point(58, 89);
            gIAHANGPHONGLabel.Name = "gIAHANGPHONGLabel";
            gIAHANGPHONGLabel.Size = new System.Drawing.Size(114, 17);
            gIAHANGPHONGLabel.TabIndex = 2;
            gIAHANGPHONGLabel.Text = "GIAHANGPHONG:";
            // 
            // tENKIEUPHONGLabel
            // 
            tENKIEUPHONGLabel.AutoSize = true;
            tENKIEUPHONGLabel.Location = new System.Drawing.Point(60, 159);
            tENKIEUPHONGLabel.Name = "tENKIEUPHONGLabel";
            tENKIEUPHONGLabel.Size = new System.Drawing.Size(112, 17);
            tENKIEUPHONGLabel.TabIndex = 6;
            tENKIEUPHONGLabel.Text = "TENKIEUPHONG:";
            // 
            // tENLOAIPHONGLabel
            // 
            tENLOAIPHONGLabel.AutoSize = true;
            tENLOAIPHONGLabel.Location = new System.Drawing.Point(60, 234);
            tENLOAIPHONGLabel.Name = "tENLOAIPHONGLabel";
            tENLOAIPHONGLabel.Size = new System.Drawing.Size(112, 17);
            tENLOAIPHONGLabel.TabIndex = 8;
            tENLOAIPHONGLabel.Text = "TENLOAIPHONG:";
            // 
            // mALPLabel
            // 
            mALPLabel.AutoSize = true;
            mALPLabel.Location = new System.Drawing.Point(427, 231);
            mALPLabel.Name = "mALPLabel";
            mALPLabel.Size = new System.Drawing.Size(46, 17);
            mALPLabel.TabIndex = 10;
            mALPLabel.Text = "MALP:";
            // 
            // mAKPLabel
            // 
            mAKPLabel.AutoSize = true;
            mAKPLabel.Location = new System.Drawing.Point(426, 159);
            mAKPLabel.Name = "mAKPLabel";
            mAKPLabel.Size = new System.Drawing.Size(47, 17);
            mAKPLabel.TabIndex = 12;
            mAKPLabel.Text = "MAKP:";
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
            this.btnGhi,
            this.btnXoa,
            this.btnThoat,
            this.btnHuy,
            this.btnLamMoi});
            this.barManager1.MaxItemId = 6;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            this.btnGhi.Id = 1;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1092, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 689);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1092, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 659);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1092, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 659);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsHangPhong
            // 
            this.bdsHangPhong.DataMember = "HANGPHONG";
            this.bdsHangPhong.DataSource = this.DS;
            // 
            // hANGPHONGTableAdapter
            // 
            this.hANGPHONGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOPHANTableAdapter = null;
            this.tableAdapterManager.CT_TRANGTHAIPHONGTableAdapter = null;
            this.tableAdapterManager.CTDICHVUTableAdapter = null;
            this.tableAdapterManager.CTPHIEUTHUETableAdapter = null;
            this.tableAdapterManager.DICHVUTableAdapter = null;
            this.tableAdapterManager.DS_PD_CHUACO_PTTableAdapter = null;
            this.tableAdapterManager.HANGPHONGTableAdapter = this.hANGPHONGTableAdapter;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KIEUPHONGTableAdapter = this.kIEUPHONGTableAdapter;
            this.tableAdapterManager.LOAIPHONGTableAdapter = this.lOAIPHONGTableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUDATTableAdapter = null;
            this.tableAdapterManager.PHIEUTHUE_CHUA_HOADONTableAdapter = null;
            this.tableAdapterManager.PHIEUTHUETableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = this.pHONGTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLKS.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kIEUPHONGTableAdapter
            // 
            this.kIEUPHONGTableAdapter.ClearBeforeFill = true;
            // 
            // lOAIPHONGTableAdapter
            // 
            this.lOAIPHONGTableAdapter.ClearBeforeFill = true;
            // 
            // pHONGTableAdapter
            // 
            this.pHONGTableAdapter.ClearBeforeFill = true;
            // 
            // gcHangPhong
            // 
            this.gcHangPhong.DataSource = this.bdsHangPhong;
            this.gcHangPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcHangPhong.Location = new System.Drawing.Point(0, 30);
            this.gcHangPhong.MainView = this.gridView1;
            this.gcHangPhong.MenuManager = this.barManager1;
            this.gcHangPhong.Name = "gcHangPhong";
            this.gcHangPhong.Size = new System.Drawing.Size(1092, 220);
            this.gcHangPhong.TabIndex = 5;
            this.gcHangPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHP,
            this.colGIAHANGPHONG,
            this.colMALP,
            this.colMAKP});
            this.gridView1.GridControl = this.gcHangPhong;
            this.gridView1.Name = "gridView1";
            // 
            // colMAHP
            // 
            this.colMAHP.FieldName = "MAHP";
            this.colMAHP.MinWidth = 25;
            this.colMAHP.Name = "colMAHP";
            this.colMAHP.Visible = true;
            this.colMAHP.VisibleIndex = 0;
            this.colMAHP.Width = 94;
            // 
            // colGIAHANGPHONG
            // 
            this.colGIAHANGPHONG.FieldName = "GIAHANGPHONG";
            this.colGIAHANGPHONG.MinWidth = 25;
            this.colGIAHANGPHONG.Name = "colGIAHANGPHONG";
            this.colGIAHANGPHONG.Visible = true;
            this.colGIAHANGPHONG.VisibleIndex = 1;
            this.colGIAHANGPHONG.Width = 94;
            // 
            // colMALP
            // 
            this.colMALP.FieldName = "MALP";
            this.colMALP.MinWidth = 25;
            this.colMALP.Name = "colMALP";
            this.colMALP.Visible = true;
            this.colMALP.VisibleIndex = 2;
            this.colMALP.Width = 94;
            // 
            // colMAKP
            // 
            this.colMAKP.FieldName = "MAKP";
            this.colMAKP.MinWidth = 25;
            this.colMAKP.Name = "colMAKP";
            this.colMAKP.Visible = true;
            this.colMAKP.VisibleIndex = 3;
            this.colMAKP.Width = 94;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(mAKPLabel);
            this.panelInput.Controls.Add(this.txtKP);
            this.panelInput.Controls.Add(mALPLabel);
            this.panelInput.Controls.Add(this.txtLP);
            this.panelInput.Controls.Add(tENLOAIPHONGLabel);
            this.panelInput.Controls.Add(this.cbxLP);
            this.panelInput.Controls.Add(tENKIEUPHONGLabel);
            this.panelInput.Controls.Add(this.cbxKP);
            this.panelInput.Controls.Add(gIAHANGPHONGLabel);
            this.panelInput.Controls.Add(this.txtGiaHP);
            this.panelInput.Controls.Add(mAHPLabel);
            this.panelInput.Controls.Add(this.txtMaHP);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(0, 250);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1092, 439);
            this.panelInput.TabIndex = 6;
            // 
            // txtKP
            // 
            this.txtKP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHangPhong, "MAKP", true));
            this.txtKP.Enabled = false;
            this.txtKP.Location = new System.Drawing.Point(479, 156);
            this.txtKP.Name = "txtKP";
            this.txtKP.Size = new System.Drawing.Size(100, 23);
            this.txtKP.TabIndex = 13;
            // 
            // txtLP
            // 
            this.txtLP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHangPhong, "MALP", true));
            this.txtLP.Enabled = false;
            this.txtLP.Location = new System.Drawing.Point(479, 228);
            this.txtLP.Name = "txtLP";
            this.txtLP.Size = new System.Drawing.Size(100, 23);
            this.txtLP.TabIndex = 11;
            // 
            // cbxLP
            // 
            this.cbxLP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLoaiPhong, "TENLOAIPHONG", true));
            this.cbxLP.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsHangPhong, "MALP", true));
            this.cbxLP.DataSource = this.bdsLoaiPhong;
            this.cbxLP.DisplayMember = "TENLOAIPHONG";
            this.cbxLP.FormattingEnabled = true;
            this.cbxLP.Location = new System.Drawing.Point(178, 231);
            this.cbxLP.Name = "cbxLP";
            this.cbxLP.Size = new System.Drawing.Size(121, 24);
            this.cbxLP.TabIndex = 9;
            this.cbxLP.ValueMember = "MALP";
            this.cbxLP.SelectedIndexChanged += new System.EventHandler(this.cbxLP_SelectedIndexChanged);
            // 
            // bdsLoaiPhong
            // 
            this.bdsLoaiPhong.DataMember = "LOAIPHONG";
            this.bdsLoaiPhong.DataSource = this.DS;
            // 
            // cbxKP
            // 
            this.cbxKP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKieuPhong, "TENKIEUPHONG", true));
            this.cbxKP.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsHangPhong, "MAKP", true));
            this.cbxKP.DataSource = this.bdsKieuPhong;
            this.cbxKP.DisplayMember = "TENKIEUPHONG";
            this.cbxKP.FormattingEnabled = true;
            this.cbxKP.Location = new System.Drawing.Point(178, 156);
            this.cbxKP.Name = "cbxKP";
            this.cbxKP.Size = new System.Drawing.Size(121, 24);
            this.cbxKP.TabIndex = 7;
            this.cbxKP.ValueMember = "MAKP";
            this.cbxKP.SelectedIndexChanged += new System.EventHandler(this.cbxKP_SelectedIndexChanged);
            // 
            // bdsKieuPhong
            // 
            this.bdsKieuPhong.DataMember = "KIEUPHONG";
            this.bdsKieuPhong.DataSource = this.DS;
            // 
            // txtGiaHP
            // 
            this.txtGiaHP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHangPhong, "GIAHANGPHONG", true));
            this.txtGiaHP.Location = new System.Drawing.Point(178, 86);
            this.txtGiaHP.MenuManager = this.barManager1;
            this.txtGiaHP.Name = "txtGiaHP";
            this.txtGiaHP.Properties.DisplayFormat.FormatString = "n0";
            this.txtGiaHP.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtGiaHP.Properties.EditFormat.FormatString = "n0";
            this.txtGiaHP.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtGiaHP.Properties.Mask.EditMask = "n0";
            this.txtGiaHP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtGiaHP.Size = new System.Drawing.Size(125, 22);
            this.txtGiaHP.TabIndex = 3;
            // 
            // txtMaHP
            // 
            this.txtMaHP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHangPhong, "MAHP", true));
            this.txtMaHP.Enabled = false;
            this.txtMaHP.Location = new System.Drawing.Point(178, 31);
            this.txtMaHP.MenuManager = this.barManager1;
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(125, 22);
            this.txtMaHP.TabIndex = 1;
            // 
            // bdsPhong
            // 
            this.bdsPhong.DataMember = "FK__PHONG__MAHP__412EB0B6";
            this.bdsPhong.DataSource = this.bdsHangPhong;
            // 
            // frmHangPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 689);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.gcHangPhong);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHangPhong";
            this.Text = "frmHangPhong";
            this.Load += new System.EventHandler(this.frmHangPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHangPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHangPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLoaiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKieuPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaHP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhong)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsHangPhong;
        private DS DS;
        private DSTableAdapters.HANGPHONGTableAdapter hANGPHONGTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelInput;
        private DevExpress.XtraEditors.TextEdit txtGiaHP;
        private DevExpress.XtraEditors.TextEdit txtMaHP;
        private DevExpress.XtraGrid.GridControl gcHangPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSTableAdapters.PHONGTableAdapter pHONGTableAdapter;
        private System.Windows.Forms.BindingSource bdsPhong;
        private DSTableAdapters.KIEUPHONGTableAdapter kIEUPHONGTableAdapter;
        private System.Windows.Forms.BindingSource bdsKieuPhong;
        private DSTableAdapters.LOAIPHONGTableAdapter lOAIPHONGTableAdapter;
        private System.Windows.Forms.BindingSource bdsLoaiPhong;
        private System.Windows.Forms.TextBox txtKP;
        private System.Windows.Forms.TextBox txtLP;
        private System.Windows.Forms.ComboBox cbxLP;
        private System.Windows.Forms.ComboBox cbxKP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHP;
        private DevExpress.XtraGrid.Columns.GridColumn colGIAHANGPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMALP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKP;
    }
}