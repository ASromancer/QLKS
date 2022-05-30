
namespace QLKS
{
    partial class frmChonPhong
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
            this.gvChonPhong = new System.Windows.Forms.DataGridView();
            this.MAPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TG_BATDAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TG_KETTHUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA_HANGPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtMaxHour = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBD = new DevExpress.XtraEditors.TimeEdit();
            this.txtKT = new DevExpress.XtraEditors.TimeEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChonPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gvChonPhong
            // 
            this.gvChonPhong.AllowUserToAddRows = false;
            this.gvChonPhong.AllowUserToDeleteRows = false;
            this.gvChonPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvChonPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPHONG,
            this.TG_BATDAU,
            this.TG_KETTHUC,
            this.MAHP,
            this.MOTA_HANGPHONG,
            this.TRANGTHAI});
            this.gvChonPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvChonPhong.Location = new System.Drawing.Point(0, 0);
            this.gvChonPhong.Name = "gvChonPhong";
            this.gvChonPhong.ReadOnly = true;
            this.gvChonPhong.RowHeadersWidth = 51;
            this.gvChonPhong.RowTemplate.Height = 24;
            this.gvChonPhong.Size = new System.Drawing.Size(1078, 256);
            this.gvChonPhong.TabIndex = 0;
            // 
            // MAPHONG
            // 
            this.MAPHONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAPHONG.DataPropertyName = "MAPHONG";
            this.MAPHONG.HeaderText = "Mã phòng";
            this.MAPHONG.MinimumWidth = 6;
            this.MAPHONG.Name = "MAPHONG";
            this.MAPHONG.ReadOnly = true;
            // 
            // TG_BATDAU
            // 
            this.TG_BATDAU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TG_BATDAU.DataPropertyName = "SOPHONG";
            this.TG_BATDAU.HeaderText = "Số phòng";
            this.TG_BATDAU.MinimumWidth = 6;
            this.TG_BATDAU.Name = "TG_BATDAU";
            this.TG_BATDAU.ReadOnly = true;
            // 
            // TG_KETTHUC
            // 
            this.TG_KETTHUC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TG_KETTHUC.DataPropertyName = "SOTANG";
            this.TG_KETTHUC.HeaderText = "Số tầng";
            this.TG_KETTHUC.MinimumWidth = 6;
            this.TG_KETTHUC.Name = "TG_KETTHUC";
            this.TG_KETTHUC.ReadOnly = true;
            // 
            // MAHP
            // 
            this.MAHP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAHP.DataPropertyName = "MAHP";
            this.MAHP.HeaderText = "Mã hạng phòng";
            this.MAHP.MinimumWidth = 6;
            this.MAHP.Name = "MAHP";
            this.MAHP.ReadOnly = true;
            // 
            // MOTA_HANGPHONG
            // 
            this.MOTA_HANGPHONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MOTA_HANGPHONG.DataPropertyName = "MOTA_HANGPHONG";
            this.MOTA_HANGPHONG.HeaderText = "Mô tả hạng phòng";
            this.MOTA_HANGPHONG.MinimumWidth = 6;
            this.MOTA_HANGPHONG.Name = "MOTA_HANGPHONG";
            this.MOTA_HANGPHONG.ReadOnly = true;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            this.TRANGTHAI.HeaderText = "Trạng thái";
            this.TRANGTHAI.MinimumWidth = 6;
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.ReadOnly = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtMaxHour);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.button2);
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Controls.Add(this.btnLoc);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtBD);
            this.panelControl1.Controls.Add(this.txtKT);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 256);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1078, 325);
            this.panelControl1.TabIndex = 1;
            // 
            // txtMaxHour
            // 
            this.txtMaxHour.Location = new System.Drawing.Point(438, 140);
            this.txtMaxHour.Name = "txtMaxHour";
            this.txtMaxHour.ReadOnly = true;
            this.txtMaxHour.Size = new System.Drawing.Size(178, 23);
            this.txtMaxHour.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(307, 143);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(113, 17);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Số giờ thuê tối đa:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(556, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Chọn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(808, 50);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(124, 37);
            this.btnLoc.TabIndex = 4;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(545, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(109, 17);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ngày giờ kết thúc";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(226, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ngày giờ bắt đầu";
            // 
            // txtBD
            // 
            this.txtBD.EditValue = null;
            this.txtBD.Location = new System.Drawing.Point(226, 57);
            this.txtBD.Name = "txtBD";
            this.txtBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBD.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtBD.Properties.Mask.EditMask = "g";
            this.txtBD.Properties.ReadOnly = true;
            this.txtBD.Size = new System.Drawing.Size(229, 24);
            this.txtBD.TabIndex = 0;
            // 
            // txtKT
            // 
            this.txtKT.EditValue = null;
            this.txtKT.Location = new System.Drawing.Point(545, 57);
            this.txtKT.Name = "txtKT";
            this.txtKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtKT.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtKT.Properties.Mask.EditMask = "g";
            this.txtKT.Size = new System.Drawing.Size(229, 24);
            this.txtKT.TabIndex = 1;
            // 
            // frmChonPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 581);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gvChonPhong);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChonPhong";
            this.Text = "frmChonPhong";
            ((System.ComponentModel.ISupportInitialize)(this.gvChonPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKT.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvChonPhong;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLoc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TimeEdit txtBD;
        private DevExpress.XtraEditors.TimeEdit txtKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TG_BATDAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TG_KETTHUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA_HANGPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
        private System.Windows.Forms.TextBox txtMaxHour;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}