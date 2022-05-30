using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class frmPhong : Form
    {

        int vitri;
        bool dangThemMoi = false;

        public frmPhong()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            this.DS.EnforceConstraints = false;

            this.hANGPHONGTableAdapter.Connection = Program.conn;
            this.hANGPHONGTableAdapter.Fill(this.DS.HANGPHONG);

            this.pHONGTableAdapter.Connection = Program.conn;
            this.pHONGTableAdapter.Fill(this.DS.PHONG);

            this.cTPHIEUTHUETableAdapter.Connection = Program.conn;
            this.cTPHIEUTHUETableAdapter.Fill(this.DS.CTPHIEUTHUE);
        }

        private void pHONGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhong.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private bool checkMP()
        {
            String sql = "SELECT * FROM PHONG WHERE MAPHONG = '" + txtMaPhong.Text.Trim() + "'";
            SqlDataReader data = Program.ExecSqlDataReader(sql);
            bool check = data.Read();
            data.Close();
            return check;
        }

        private bool checkSoPhong()
        {
            String sql = "SELECT * FROM PHONG WHERE SOPHONG = " + spnSophong.Value;
            SqlDataReader data = Program.ExecSqlDataReader(sql);
            bool check = data.Read();
            data.Close();
            return check;
        }

        private bool checkThongTin()
        {
            if(txtMaPhong.Text.Trim() == "")
            {
                MessageBox.Show("Mã phòng trống!");
                txtMaPhong.Focus();
                return false;
            }

            if (txtMaPhong.Text.Trim().Length != 5)
            {
                MessageBox.Show("Mã phòng gồm 5 kí tự MPxxx, vui lòng nhập lại!");
                txtMaPhong.Focus();
                return false;
            }
            if (!txtMaPhong.Text.Contains("MP"))
            {
                MessageBox.Show("Mã phòng phải được nhập theo mãu MPxxx, vui lòng nhập lại!");
                txtMaPhong.Focus();
                return false;
            }


            return true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThemMoi = true;
            vitri = bdsPhong.Position;

            bdsPhong.AddNew();
            txtMaPhong.Text = "";
            txtMaPhong.Focus();
            spnSophong.Value = 0;
            spnSoTang.Value = 0;
            cbxHP.SelectedIndex = 1;

            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
            gcPhong.Enabled = false;
            txtMaPhong.Enabled = btnHuy.Enabled = true;

        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.pHONGTableAdapter.Fill(this.DS.PHONG);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi RELOAD: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
            gcPhong.Enabled = true;
            txtMaPhong.Enabled = btnHuy.Enabled = false;

            bdsPhong.CancelEdit();
            this.pHONGTableAdapter.Fill(this.DS.PHONG);
            bdsPhong.Position = vitri;
        }

        private void panelInput_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(!checkThongTin())
            {
                return;
            }

            if (dangThemMoi)
            {
                if (checkMP())
                {
                    MessageBox.Show("Mã phòng đã tồn tại, vui lòng nhập lại!");
                    txtMaPhong.Focus();
                    return;
                }

                if (checkSoPhong())
                {
                    MessageBox.Show("Số phòng đã tồn tại, vui lòng nhập lại!");
                    spnSophong.Focus();
                    return;
                }

                if (cbxHP.SelectedValue.ToString() == "System.Data.DataRowView")
                {
                    MessageBox.Show("Chưa chọn hạng phòng!");
                    cbxHP.Focus();
                    return;
                }
            }

            if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
                gcPhong.Enabled = true;
                txtMaPhong.Enabled = btnHuy.Enabled = false;

                bdsPhong.EndEdit();

                this.pHONGTableAdapter.Connection = Program.conn;
                this.pHONGTableAdapter.Update(this.DS.PHONG);

                dangThemMoi = false;
                MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTPT.Count > 0)
            {
                MessageBox.Show("Phòng đã từng được sử dụng nên không thể xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa phòng này ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bdsPhong.RemoveCurrent();
                pHONGTableAdapter.Connection = Program.conn;
                pHONGTableAdapter.Update(DS.PHONG);

                MessageBox.Show("Xóa phòng thành công!\n", "", MessageBoxButtons.OK);

            }
        }

        private void cbxHP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtHP.Text = cbxHP.SelectedValue.ToString();
            } catch(Exception ex)
            {

            }
        }
    }
}
