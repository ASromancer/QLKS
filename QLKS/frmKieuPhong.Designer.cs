
namespace QLKS
{
    partial class frmKieuPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKieuPhong));
            System.Windows.Forms.Label mAKPLabel;
            System.Windows.Forms.Label tENKIEUPHONGLabel;
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
            this.bdsKieuPhong = new System.Windows.Forms.BindingSource(this.components);
            this.kIEUPHONGTableAdapter = new QLKS.DSTableAdapters.KIEUPHONGTableAdapter();
            this.tableAdapterManager = new QLKS.DSTableAdapters.TableAdapterManager();
            this.gcKieuPhong = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKIEUPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelInput = new DevExpress.XtraEditors.PanelControl();
            this.txtMaKP = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKP = new DevExpress.XtraEditors.TextEdit();
            this.bdsHangPhong = new System.Windows.Forms.BindingSource(this.components);
            this.hANGPHONGTableAdapter = new QLKS.DSTableAdapters.HANGPHONGTableAdapter();
            mAKPLabel = new System.Windows.Forms.Label();
            tENKIEUPHONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKieuPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKieuPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).BeginInit();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHangPhong)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(1079, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 543);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1079, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 513);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1079, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 513);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKieuPhong
            // 
            this.bdsKieuPhong.DataMember = "KIEUPHONG";
            this.bdsKieuPhong.DataSource = this.DS;
            // 
            // kIEUPHONGTableAdapter
            // 
            this.kIEUPHONGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOPHANTableAdapter = null;
            this.tableAdapterManager.CTDICHVUTableAdapter = null;
            this.tableAdapterManager.CTPHIEUDATTableAdapter = null;
            this.tableAdapterManager.CTPHIEUTHUETableAdapter = null;
            this.tableAdapterManager.DICHVUTableAdapter = null;
            this.tableAdapterManager.HANGPHONGTableAdapter = this.hANGPHONGTableAdapter;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KIEUPHONGTableAdapter = this.kIEUPHONGTableAdapter;
            this.tableAdapterManager.LOAIPHONGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUDATTableAdapter = null;
            this.tableAdapterManager.PHIEUTHUETableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLKS.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcKieuPhong
            // 
            this.gcKieuPhong.DataSource = this.bdsKieuPhong;
            this.gcKieuPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKieuPhong.Location = new System.Drawing.Point(0, 30);
            this.gcKieuPhong.MainView = this.gridView1;
            this.gcKieuPhong.MenuManager = this.barManager1;
            this.gcKieuPhong.Name = "gcKieuPhong";
            this.gcKieuPhong.Size = new System.Drawing.Size(1079, 220);
            this.gcKieuPhong.TabIndex = 5;
            this.gcKieuPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKP,
            this.colTENKIEUPHONG});
            this.gridView1.GridControl = this.gcKieuPhong;
            this.gridView1.Name = "gridView1";
            // 
            // colMAKP
            // 
            this.colMAKP.FieldName = "MAKP";
            this.colMAKP.MinWidth = 25;
            this.colMAKP.Name = "colMAKP";
            this.colMAKP.Visible = true;
            this.colMAKP.VisibleIndex = 0;
            this.colMAKP.Width = 94;
            // 
            // colTENKIEUPHONG
            // 
            this.colTENKIEUPHONG.FieldName = "TENKIEUPHONG";
            this.colTENKIEUPHONG.MinWidth = 25;
            this.colTENKIEUPHONG.Name = "colTENKIEUPHONG";
            this.colTENKIEUPHONG.Visible = true;
            this.colTENKIEUPHONG.VisibleIndex = 1;
            this.colTENKIEUPHONG.Width = 94;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(tENKIEUPHONGLabel);
            this.panelInput.Controls.Add(this.txtTenKP);
            this.panelInput.Controls.Add(mAKPLabel);
            this.panelInput.Controls.Add(this.txtMaKP);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(0, 250);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1079, 293);
            this.panelInput.TabIndex = 6;
            // 
            // mAKPLabel
            // 
            mAKPLabel.AutoSize = true;
            mAKPLabel.Location = new System.Drawing.Point(91, 44);
            mAKPLabel.Name = "mAKPLabel";
            mAKPLabel.Size = new System.Drawing.Size(47, 17);
            mAKPLabel.TabIndex = 0;
            mAKPLabel.Text = "MAKP:";
            // 
            // txtMaKP
            // 
            this.txtMaKP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKieuPhong, "MAKP", true));
            this.txtMaKP.Enabled = false;
            this.txtMaKP.Location = new System.Drawing.Point(144, 41);
            this.txtMaKP.MenuManager = this.barManager1;
            this.txtMaKP.Name = "txtMaKP";
            this.txtMaKP.Size = new System.Drawing.Size(200, 22);
            this.txtMaKP.TabIndex = 1;
            // 
            // tENKIEUPHONGLabel
            // 
            tENKIEUPHONGLabel.AutoSize = true;
            tENKIEUPHONGLabel.Location = new System.Drawing.Point(26, 98);
            tENKIEUPHONGLabel.Name = "tENKIEUPHONGLabel";
            tENKIEUPHONGLabel.Size = new System.Drawing.Size(112, 17);
            tENKIEUPHONGLabel.TabIndex = 2;
            tENKIEUPHONGLabel.Text = "TENKIEUPHONG:";
            // 
            // txtTenKP
            // 
            this.txtTenKP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKieuPhong, "TENKIEUPHONG", true));
            this.txtTenKP.Location = new System.Drawing.Point(144, 95);
            this.txtTenKP.MenuManager = this.barManager1;
            this.txtTenKP.Name = "txtTenKP";
            this.txtTenKP.Size = new System.Drawing.Size(200, 22);
            this.txtTenKP.TabIndex = 3;
            // 
            // bdsHangPhong
            // 
            this.bdsHangPhong.DataMember = "FK__HANGPHONG__MAKP__3D5E1FD2";
            this.bdsHangPhong.DataSource = this.bdsKieuPhong;
            // 
            // hANGPHONGTableAdapter
            // 
            this.hANGPHONGTableAdapter.ClearBeforeFill = true;
            // 
            // frmKieuPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 543);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.gcKieuPhong);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmKieuPhong";
            this.Text = "frmKieuPhong";
            this.Load += new System.EventHandler(this.frmKieuPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKieuPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKieuPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHangPhong)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsKieuPhong;
        private DS DS;
        private DSTableAdapters.KIEUPHONGTableAdapter kIEUPHONGTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelInput;
        private DevExpress.XtraGrid.GridControl gcKieuPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKIEUPHONG;
        private DevExpress.XtraEditors.TextEdit txtTenKP;
        private DevExpress.XtraEditors.TextEdit txtMaKP;
        private DSTableAdapters.HANGPHONGTableAdapter hANGPHONGTableAdapter;
        private System.Windows.Forms.BindingSource bdsHangPhong;
    }
}