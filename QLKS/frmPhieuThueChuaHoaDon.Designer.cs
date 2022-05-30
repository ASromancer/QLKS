
namespace QLKS
{
    partial class frmPhieuThueChuaHoaDon
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
            this.DS = new QLKS.DS();
            this.bdsPTHD = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUTHUE_CHUA_HOADONTableAdapter = new QLKS.DSTableAdapters.PHIEUTHUE_CHUA_HOADONTableAdapter();
            this.tableAdapterManager = new QLKS.DSTableAdapters.TableAdapterManager();
            this.gcPTHD = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.colMAPT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAPD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYLAPPHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPTHD
            // 
            this.bdsPTHD.DataMember = "PHIEUTHUE_CHUA_HOADON";
            this.bdsPTHD.DataSource = this.DS;
            // 
            // pHIEUTHUE_CHUA_HOADONTableAdapter
            // 
            this.pHIEUTHUE_CHUA_HOADONTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PHIEUTHUE_CHUA_HOADONTableAdapter = this.pHIEUTHUE_CHUA_HOADONTableAdapter;
            this.tableAdapterManager.PHIEUTHUETableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLKS.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcPTHD
            // 
            this.gcPTHD.DataSource = this.bdsPTHD;
            this.gcPTHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPTHD.Location = new System.Drawing.Point(0, 0);
            this.gcPTHD.MainView = this.gridView1;
            this.gcPTHD.Name = "gcPTHD";
            this.gcPTHD.Size = new System.Drawing.Size(964, 288);
            this.gcPTHD.TabIndex = 1;
            this.gcPTHD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView1.GridControl = this.gcPTHD;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.button2);
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 288);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(964, 134);
            this.panelControl1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Chọn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // frmPhieuThueChuaHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 422);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcPTHD);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPhieuThueChuaHoaDon";
            this.Text = "frmPhieuThueChuaHoaDon";
            this.Load += new System.EventHandler(this.frmPhieuThueChuaHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DS DS;
        private System.Windows.Forms.BindingSource bdsPTHD;
        private DSTableAdapters.PHIEUTHUE_CHUA_HOADONTableAdapter pHIEUTHUE_CHUA_HOADONTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcPTHD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPT;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYLAPPHIEU;
    }
}