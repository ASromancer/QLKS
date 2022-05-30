
namespace QLKS
{
    partial class frmPDKhongPT
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
            this.dS = new QLKS.DS();
            this.bdsPD = new System.Windows.Forms.BindingSource(this.components);
            this.dS_PD_CHUACO_PTTableAdapter = new QLKS.DSTableAdapters.DS_PD_CHUACO_PTTableAdapter();
            this.tableAdapterManager = new QLKS.DSTableAdapters.TableAdapterManager();
            this.dS_PD_CHUACO_PTGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYBATDAUTHUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYLAPPHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PD_CHUACO_PTGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPD
            // 
            this.bdsPD.DataMember = "DS_PD_CHUACO_PT";
            this.bdsPD.DataSource = this.dS;
            // 
            // dS_PD_CHUACO_PTTableAdapter
            // 
            this.dS_PD_CHUACO_PTTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.DS_PD_CHUACO_PTTableAdapter = this.dS_PD_CHUACO_PTTableAdapter;
            this.tableAdapterManager.HANGPHONGTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KIEUPHONGTableAdapter = null;
            this.tableAdapterManager.LOAIPHONGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUDATTableAdapter = null;
            this.tableAdapterManager.PHIEUTHUETableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLKS.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dS_PD_CHUACO_PTGridControl
            // 
            this.dS_PD_CHUACO_PTGridControl.DataSource = this.bdsPD;
            this.dS_PD_CHUACO_PTGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dS_PD_CHUACO_PTGridControl.Location = new System.Drawing.Point(0, 0);
            this.dS_PD_CHUACO_PTGridControl.MainView = this.gridView1;
            this.dS_PD_CHUACO_PTGridControl.Name = "dS_PD_CHUACO_PTGridControl";
            this.dS_PD_CHUACO_PTGridControl.Size = new System.Drawing.Size(982, 279);
            this.dS_PD_CHUACO_PTGridControl.TabIndex = 1;
            this.dS_PD_CHUACO_PTGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView1.GridControl = this.dS_PD_CHUACO_PTGridControl;
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
            this.colNGAYBATDAUTHUE.DisplayFormat.FormatString = "g";
            this.colNGAYBATDAUTHUE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.button2);
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 279);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(982, 116);
            this.panelControl1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Chọn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPDKhongPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 395);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.dS_PD_CHUACO_PTGridControl);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPDKhongPT";
            this.Text = "Phiếu đặt chưa có phiếu thuê sẽ đến trong ngày";
            this.Load += new System.EventHandler(this.frmPDKhongPT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PD_CHUACO_PTGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource bdsPD;
        private DSTableAdapters.DS_PD_CHUACO_PTTableAdapter dS_PD_CHUACO_PTTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl dS_PD_CHUACO_PTGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYBATDAUTHUE;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYLAPPHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}