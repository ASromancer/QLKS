
namespace QLKS
{
    partial class frmKhach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhach));
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mASOTHUELabel;
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
            this.bdsKhach = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHHANGTableAdapter = new QLKS.DSTableAdapters.KHACHHANGTableAdapter();
            this.tableAdapterManager = new QLKS.DSTableAdapters.TableAdapterManager();
            this.gcKhach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASOTHUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelInput = new DevExpress.XtraEditors.PanelControl();
            this.txtMaKhach = new DevExpress.XtraEditors.TextEdit();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSoThue = new DevExpress.XtraEditors.TextEdit();
            this.bdsPD = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUDATTableAdapter = new QLKS.DSTableAdapters.PHIEUDATTableAdapter();
            this.bdsPT = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUTHUETableAdapter = new QLKS.DSTableAdapters.PHIEUTHUETableAdapter();
            mAKHLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mASOTHUELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).BeginInit();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoThue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPT)).BeginInit();
            this.SuspendLayout();
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
            this.barDockControlTop.Size = new System.Drawing.Size(1146, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 714);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1146, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 684);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1146, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 684);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKhach
            // 
            this.bdsKhach.DataMember = "KHACHHANG";
            this.bdsKhach.DataSource = this.DS;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOPHANTableAdapter = null;
            this.tableAdapterManager.CTDICHVUTableAdapter = null;
            this.tableAdapterManager.CTPHIEUDATTableAdapter = null;
            this.tableAdapterManager.CTPHIEUTHUETableAdapter = null;
            this.tableAdapterManager.DICHVUTableAdapter = null;
            this.tableAdapterManager.HANGPHONGTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = this.kHACHHANGTableAdapter;
            this.tableAdapterManager.KIEUPHONGTableAdapter = null;
            this.tableAdapterManager.LOAIPHONGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUDATTableAdapter = this.pHIEUDATTableAdapter;
            this.tableAdapterManager.PHIEUTHUETableAdapter = this.pHIEUTHUETableAdapter;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLKS.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcKhach
            // 
            this.gcKhach.DataSource = this.bdsKhach;
            this.gcKhach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKhach.Location = new System.Drawing.Point(0, 30);
            this.gcKhach.MainView = this.gridView1;
            this.gcKhach.MenuManager = this.barManager1;
            this.gcKhach.Name = "gcKhach";
            this.gcKhach.Size = new System.Drawing.Size(1146, 220);
            this.gcKhach.TabIndex = 5;
            this.gcKhach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colCMND,
            this.colHO,
            this.colTEN,
            this.colSDT,
            this.colEMAIL,
            this.colDIACHI,
            this.colMASOTHUE});
            this.gridView1.GridControl = this.gcKhach;
            this.gridView1.Name = "gridView1";
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 25;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            this.colMAKH.Width = 94;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            this.colCMND.Width = 94;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 2;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 3;
            this.colTEN.Width = 94;
            // 
            // colSDT
            // 
            this.colSDT.FieldName = "SDT";
            this.colSDT.MinWidth = 25;
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 4;
            this.colSDT.Width = 94;
            // 
            // colEMAIL
            // 
            this.colEMAIL.FieldName = "EMAIL";
            this.colEMAIL.MinWidth = 25;
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.Visible = true;
            this.colEMAIL.VisibleIndex = 5;
            this.colEMAIL.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 6;
            this.colDIACHI.Width = 94;
            // 
            // colMASOTHUE
            // 
            this.colMASOTHUE.FieldName = "MASOTHUE";
            this.colMASOTHUE.MinWidth = 25;
            this.colMASOTHUE.Name = "colMASOTHUE";
            this.colMASOTHUE.Visible = true;
            this.colMASOTHUE.VisibleIndex = 7;
            this.colMASOTHUE.Width = 94;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(mASOTHUELabel);
            this.panelInput.Controls.Add(this.txtMaSoThue);
            this.panelInput.Controls.Add(dIACHILabel);
            this.panelInput.Controls.Add(this.txtDiaChi);
            this.panelInput.Controls.Add(eMAILLabel);
            this.panelInput.Controls.Add(this.txtEmail);
            this.panelInput.Controls.Add(sDTLabel);
            this.panelInput.Controls.Add(this.txtPhone);
            this.panelInput.Controls.Add(tENLabel);
            this.panelInput.Controls.Add(this.txtTen);
            this.panelInput.Controls.Add(hOLabel);
            this.panelInput.Controls.Add(this.txtHo);
            this.panelInput.Controls.Add(cMNDLabel);
            this.panelInput.Controls.Add(this.txtCMND);
            this.panelInput.Controls.Add(mAKHLabel);
            this.panelInput.Controls.Add(this.txtMaKhach);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(0, 250);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1146, 464);
            this.panelInput.TabIndex = 6;
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(77, 36);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(48, 17);
            mAKHLabel.TabIndex = 0;
            mAKHLabel.Text = "MAKH:";
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhach, "MAKH", true));
            this.txtMaKhach.Location = new System.Drawing.Point(131, 33);
            this.txtMaKhach.MenuManager = this.barManager1;
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(125, 22);
            this.txtMaKhach.TabIndex = 1;
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(322, 34);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(51, 17);
            cMNDLabel.TabIndex = 2;
            cMNDLabel.Text = "CMND:";
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhach, "CMND", true));
            this.txtCMND.Location = new System.Drawing.Point(379, 31);
            this.txtCMND.MenuManager = this.barManager1;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(125, 22);
            this.txtCMND.TabIndex = 3;
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(93, 87);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(32, 17);
            hOLabel.TabIndex = 4;
            hOLabel.Text = "HO:";
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhach, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(131, 84);
            this.txtHo.MenuManager = this.barManager1;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(125, 22);
            this.txtHo.TabIndex = 5;
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(335, 87);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(38, 17);
            tENLabel.TabIndex = 6;
            tENLabel.Text = "TEN:";
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhach, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(379, 84);
            this.txtTen.MenuManager = this.barManager1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(125, 22);
            this.txtTen.TabIndex = 7;
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(86, 143);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(39, 17);
            sDTLabel.TabIndex = 8;
            sDTLabel.Text = "SDT:";
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhach, "SDT", true));
            this.txtPhone.Location = new System.Drawing.Point(131, 140);
            this.txtPhone.MenuManager = this.barManager1;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(125, 22);
            this.txtPhone.TabIndex = 9;
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Location = new System.Drawing.Point(323, 141);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(50, 17);
            eMAILLabel.TabIndex = 10;
            eMAILLabel.Text = "EMAIL:";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhach, "EMAIL", true));
            this.txtEmail.Location = new System.Drawing.Point(379, 138);
            this.txtEmail.MenuManager = this.barManager1;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(125, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(68, 201);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(57, 17);
            dIACHILabel.TabIndex = 12;
            dIACHILabel.Text = "DIACHI:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhach, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(131, 198);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(125, 22);
            this.txtDiaChi.TabIndex = 13;
            // 
            // mASOTHUELabel
            // 
            mASOTHUELabel.AutoSize = true;
            mASOTHUELabel.Location = new System.Drawing.Point(290, 201);
            mASOTHUELabel.Name = "mASOTHUELabel";
            mASOTHUELabel.Size = new System.Drawing.Size(83, 17);
            mASOTHUELabel.TabIndex = 14;
            mASOTHUELabel.Text = "MASOTHUE:";
            // 
            // txtMaSoThue
            // 
            this.txtMaSoThue.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhach, "MASOTHUE", true));
            this.txtMaSoThue.Location = new System.Drawing.Point(379, 198);
            this.txtMaSoThue.MenuManager = this.barManager1;
            this.txtMaSoThue.Name = "txtMaSoThue";
            this.txtMaSoThue.Size = new System.Drawing.Size(125, 22);
            this.txtMaSoThue.TabIndex = 15;
            // 
            // bdsPD
            // 
            this.bdsPD.DataMember = "FK__PHIEUDAT__MAKH__60A75C0F";
            this.bdsPD.DataSource = this.bdsKhach;
            // 
            // pHIEUDATTableAdapter
            // 
            this.pHIEUDATTableAdapter.ClearBeforeFill = true;
            // 
            // bdsPT
            // 
            this.bdsPT.DataMember = "FK__PHIEUTHUE__MAKH__4F7CD00D";
            this.bdsPT.DataSource = this.bdsKhach;
            // 
            // pHIEUTHUETableAdapter
            // 
            this.pHIEUTHUETableAdapter.ClearBeforeFill = true;
            // 
            // frmKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 714);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.gcKhach);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmKhach";
            this.Text = "frmKhach";
            this.Load += new System.EventHandler(this.frmKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoThue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPD)).EndInit();
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
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsKhach;
        private DS DS;
        private DSTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelInput;
        private DevExpress.XtraGrid.GridControl gcKhach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMASOTHUE;
        private DevExpress.XtraEditors.TextEdit txtMaSoThue;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private DevExpress.XtraEditors.TextEdit txtMaKhach;
        private DSTableAdapters.PHIEUDATTableAdapter pHIEUDATTableAdapter;
        private System.Windows.Forms.BindingSource bdsPD;
        private DSTableAdapters.PHIEUTHUETableAdapter pHIEUTHUETableAdapter;
        private System.Windows.Forms.BindingSource bdsPT;
    }
}