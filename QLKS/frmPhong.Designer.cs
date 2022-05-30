
namespace QLKS
{
    partial class frmPhong
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
            System.Windows.Forms.Label mAPHONGLabel;
            System.Windows.Forms.Label sOPHONGLabel;
            System.Windows.Forms.Label sOTANGLabel;
            System.Windows.Forms.Label mAHPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhong));
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
            this.bdsPhong = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGTableAdapter = new QLKS.DSTableAdapters.PHONGTableAdapter();
            this.tableAdapterManager = new QLKS.DSTableAdapters.TableAdapterManager();
            this.hANGPHONGTableAdapter = new QLKS.DSTableAdapters.HANGPHONGTableAdapter();
            this.gcPhong = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelInput = new DevExpress.XtraEditors.PanelControl();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.cbxHP = new System.Windows.Forms.ComboBox();
            this.bdsHangPhong = new System.Windows.Forms.BindingSource(this.components);
            this.spnSoTang = new DevExpress.XtraEditors.SpinEdit();
            this.spnSophong = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaPhong = new DevExpress.XtraEditors.TextEdit();
            this.bdsCTPT = new System.Windows.Forms.BindingSource(this.components);
            this.cTPHIEUTHUETableAdapter = new QLKS.DSTableAdapters.CTPHIEUTHUETableAdapter();
            this.colMAPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAHP = new DevExpress.XtraGrid.Columns.GridColumn();
            mAPHONGLabel = new System.Windows.Forms.Label();
            sOPHONGLabel = new System.Windows.Forms.Label();
            sOTANGLabel = new System.Windows.Forms.Label();
            mAHPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).BeginInit();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHangPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSoTang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSophong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPT)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPHONGLabel
            // 
            mAPHONGLabel.AutoSize = true;
            mAPHONGLabel.Location = new System.Drawing.Point(63, 47);
            mAPHONGLabel.Name = "mAPHONGLabel";
            mAPHONGLabel.Size = new System.Drawing.Size(76, 17);
            mAPHONGLabel.TabIndex = 0;
            mAPHONGLabel.Text = "MAPHONG:";
            // 
            // sOPHONGLabel
            // 
            sOPHONGLabel.AutoSize = true;
            sOPHONGLabel.Location = new System.Drawing.Point(311, 46);
            sOPHONGLabel.Name = "sOPHONGLabel";
            sOPHONGLabel.Size = new System.Drawing.Size(76, 17);
            sOPHONGLabel.TabIndex = 2;
            sOPHONGLabel.Text = "SOPHONG:";
            // 
            // sOTANGLabel
            // 
            sOTANGLabel.AutoSize = true;
            sOTANGLabel.Location = new System.Drawing.Point(573, 46);
            sOTANGLabel.Name = "sOTANGLabel";
            sOTANGLabel.Size = new System.Drawing.Size(65, 17);
            sOTANGLabel.TabIndex = 4;
            sOTANGLabel.Text = "SOTANG:";
            // 
            // mAHPLabel
            // 
            mAHPLabel.AutoSize = true;
            mAHPLabel.Location = new System.Drawing.Point(92, 124);
            mAHPLabel.Name = "mAHPLabel";
            mAHPLabel.Size = new System.Drawing.Size(48, 17);
            mAHPLabel.TabIndex = 10;
            mAHPLabel.Text = "MAHP:";
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
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1415, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 668);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1415, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 638);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1415, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 638);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPhong
            // 
            this.bdsPhong.DataMember = "PHONG";
            this.bdsPhong.DataSource = this.DS;
            // 
            // pHONGTableAdapter
            // 
            this.pHONGTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.HANGPHONGTableAdapter = this.hANGPHONGTableAdapter;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KIEUPHONGTableAdapter = null;
            this.tableAdapterManager.LOAIPHONGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUDATTableAdapter = null;
            this.tableAdapterManager.PHIEUTHUE_CHUA_HOADONTableAdapter = null;
            this.tableAdapterManager.PHIEUTHUETableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = this.pHONGTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLKS.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hANGPHONGTableAdapter
            // 
            this.hANGPHONGTableAdapter.ClearBeforeFill = true;
            // 
            // gcPhong
            // 
            this.gcPhong.DataSource = this.bdsPhong;
            this.gcPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPhong.Location = new System.Drawing.Point(0, 30);
            this.gcPhong.MainView = this.gridView1;
            this.gcPhong.MenuManager = this.barManager1;
            this.gcPhong.Name = "gcPhong";
            this.gcPhong.Size = new System.Drawing.Size(1415, 220);
            this.gcPhong.TabIndex = 5;
            this.gcPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPHONG,
            this.colSOPHONG,
            this.colSOTANG,
            this.colMAHP});
            this.gridView1.GridControl = this.gcPhong;
            this.gridView1.Name = "gridView1";
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.txtHP);
            this.panelInput.Controls.Add(mAHPLabel);
            this.panelInput.Controls.Add(this.cbxHP);
            this.panelInput.Controls.Add(sOTANGLabel);
            this.panelInput.Controls.Add(this.spnSoTang);
            this.panelInput.Controls.Add(sOPHONGLabel);
            this.panelInput.Controls.Add(this.spnSophong);
            this.panelInput.Controls.Add(mAPHONGLabel);
            this.panelInput.Controls.Add(this.txtMaPhong);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(0, 250);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1415, 418);
            this.panelInput.TabIndex = 6;
            this.panelInput.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInput_Paint);
            // 
            // txtHP
            // 
            this.txtHP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhong, "MAHP", true));
            this.txtHP.Location = new System.Drawing.Point(302, 121);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(100, 23);
            this.txtHP.TabIndex = 12;
            // 
            // cbxHP
            // 
            this.cbxHP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHangPhong, "MAHP", true));
            this.cbxHP.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPhong, "MAHP", true));
            this.cbxHP.DataSource = this.bdsHangPhong;
            this.cbxHP.DisplayMember = "MAHP";
            this.cbxHP.FormattingEnabled = true;
            this.cbxHP.Location = new System.Drawing.Point(146, 121);
            this.cbxHP.Name = "cbxHP";
            this.cbxHP.Size = new System.Drawing.Size(121, 24);
            this.cbxHP.TabIndex = 11;
            this.cbxHP.ValueMember = "MAHP";
            this.cbxHP.SelectedIndexChanged += new System.EventHandler(this.cbxHP_SelectedIndexChanged);
            // 
            // bdsHangPhong
            // 
            this.bdsHangPhong.DataMember = "HANGPHONG";
            this.bdsHangPhong.DataSource = this.DS;
            // 
            // spnSoTang
            // 
            this.spnSoTang.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhong, "SOTANG", true));
            this.spnSoTang.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnSoTang.Location = new System.Drawing.Point(644, 43);
            this.spnSoTang.MenuManager = this.barManager1;
            this.spnSoTang.Name = "spnSoTang";
            this.spnSoTang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnSoTang.Properties.IsFloatValue = false;
            this.spnSoTang.Properties.Mask.EditMask = "N00";
            this.spnSoTang.Properties.MaxValue = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spnSoTang.Size = new System.Drawing.Size(125, 24);
            this.spnSoTang.TabIndex = 5;
            // 
            // spnSophong
            // 
            this.spnSophong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhong, "SOPHONG", true));
            this.spnSophong.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnSophong.Location = new System.Drawing.Point(393, 43);
            this.spnSophong.MenuManager = this.barManager1;
            this.spnSophong.Name = "spnSophong";
            this.spnSophong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnSophong.Properties.IsFloatValue = false;
            this.spnSophong.Properties.Mask.EditMask = "N00";
            this.spnSophong.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.spnSophong.Size = new System.Drawing.Size(125, 24);
            this.spnSophong.TabIndex = 3;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhong, "MAPHONG", true));
            this.txtMaPhong.Enabled = false;
            this.txtMaPhong.Location = new System.Drawing.Point(145, 44);
            this.txtMaPhong.MenuManager = this.barManager1;
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(125, 22);
            this.txtMaPhong.TabIndex = 1;
            // 
            // bdsCTPT
            // 
            this.bdsCTPT.DataMember = "FK__CTPHIEUTH__MAPHO__571DF1D5";
            this.bdsCTPT.DataSource = this.bdsPhong;
            // 
            // cTPHIEUTHUETableAdapter
            // 
            this.cTPHIEUTHUETableAdapter.ClearBeforeFill = true;
            // 
            // colMAPHONG
            // 
            this.colMAPHONG.FieldName = "MAPHONG";
            this.colMAPHONG.MinWidth = 25;
            this.colMAPHONG.Name = "colMAPHONG";
            this.colMAPHONG.Visible = true;
            this.colMAPHONG.VisibleIndex = 0;
            this.colMAPHONG.Width = 94;
            // 
            // colSOPHONG
            // 
            this.colSOPHONG.FieldName = "SOPHONG";
            this.colSOPHONG.MinWidth = 25;
            this.colSOPHONG.Name = "colSOPHONG";
            this.colSOPHONG.Visible = true;
            this.colSOPHONG.VisibleIndex = 1;
            this.colSOPHONG.Width = 94;
            // 
            // colSOTANG
            // 
            this.colSOTANG.FieldName = "SOTANG";
            this.colSOTANG.MinWidth = 25;
            this.colSOTANG.Name = "colSOTANG";
            this.colSOTANG.Visible = true;
            this.colSOTANG.VisibleIndex = 2;
            this.colSOTANG.Width = 94;
            // 
            // colMAHP
            // 
            this.colMAHP.FieldName = "MAHP";
            this.colMAHP.MinWidth = 25;
            this.colMAHP.Name = "colMAHP";
            this.colMAHP.Visible = true;
            this.colMAHP.VisibleIndex = 3;
            this.colMAHP.Width = 94;
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 668);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.gcPhong);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhong";
            this.Text = "frmPhong";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHangPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSoTang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSophong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsPhong;
        private DS DS;
        private DSTableAdapters.PHONGTableAdapter pHONGTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelInput;
        private DevExpress.XtraEditors.SpinEdit spnSoTang;
        private DevExpress.XtraEditors.SpinEdit spnSophong;
        private DevExpress.XtraEditors.TextEdit txtMaPhong;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DSTableAdapters.HANGPHONGTableAdapter hANGPHONGTableAdapter;
        private System.Windows.Forms.BindingSource bdsHangPhong;
        private System.Windows.Forms.BindingSource bdsCTPT;
        private DSTableAdapters.CTPHIEUTHUETableAdapter cTPHIEUTHUETableAdapter;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.ComboBox cbxHP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTANG;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHP;
    }
}