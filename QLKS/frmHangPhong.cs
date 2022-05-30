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
    public partial class frmHangPhong : Form
    {

        int vitri;
        bool dangThemMoi = false;
        public frmHangPhong()
        {
            InitializeComponent();
        }

        private void hANGPHONGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsHangPhong.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmHangPhong_Load(object sender, EventArgs e)
        {

            this.DS.EnforceConstraints = false;

            this.lOAIPHONGTableAdapter.Connection = Program.conn;
            this.lOAIPHONGTableAdapter.Fill(this.DS.LOAIPHONG);

            this.kIEUPHONGTableAdapter.Connection = Program.conn;
            this.kIEUPHONGTableAdapter.Fill(this.DS.KIEUPHONG);

            this.pHONGTableAdapter.Connection = Program.conn;
            this.pHONGTableAdapter.Fill(this.DS.PHONG);

            this.hANGPHONGTableAdapter.Connection = Program.conn;
            this.hANGPHONGTableAdapter.Fill(this.DS.HANGPHONG);

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.hANGPHONGTableAdapter.Fill(this.DS.HANGPHONG);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi RELOAD: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThemMoi = true;
            vitri = bdsHangPhong.Position;
            bdsHangPhong.AddNew();

            cbxLP.SelectedIndex = 1;
            cbxKP.SelectedIndex = 1;

            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
            gcHangPhong.Enabled = false;
            txtMaHP.Enabled = btnHuy.Enabled = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
            gcHangPhong.Enabled = true;
            txtMaHP.Enabled = btnHuy.Enabled = false;

            bdsHangPhong.CancelEdit();
            this.hANGPHONGTableAdapter.Fill(this.DS.HANGPHONG);
            bdsHangPhong.Position = vitri;
        }

        bool checkThongTin()
        {
            if (txtMaHP.Text.Trim() == "")
            {
                MessageBox.Show("Mã dịch vụ trống!");
                txtMaHP.Focus();
                return false;
            }

            if (txtMaHP.Text.Trim().Length != 5)
            {
                MessageBox.Show("Mã phòng gồm 5 kí tự HPxxx, vui lòng nhập lại!");
                txtMaHP.Focus();
                return false;
            }
            if (!txtMaHP.Text.Contains("HP"))
            {
                MessageBox.Show("Mã dịch vụ phải được nhập theo mẫu HPxxx, vui lòng nhập lại!");
                txtMaHP.Focus();
                return false;
            }

            if (txtGiaHP.Text.Trim() == "")
            {
                MessageBox.Show("Giá dịch vụ trống!");
                txtGiaHP.Focus();
                return false;
            }

            if (int.Parse(txtGiaHP.EditValue.ToString()) < 0)
            {
                MessageBox.Show("Giá dịch vụ phải lớn hơn 0!");
                txtGiaHP.Focus();
                return false;
            }

            return true;
        }

        bool checkHP()
        {
            String sql = "SELECT * FROM HANGPHONG WHERE MAHP = '" + txtMaHP.Text.Trim() + "'";
            SqlDataReader data = Program.ExecSqlDataReader(sql);
            bool check = data.Read();
            data.Close();
            return check;
        }

        bool checkKPLP()
        {
            String sql = "SELECT * FROM HANGPHONG WHERE MALP = '" + cbxLP.SelectedValue.ToString().Trim() + "' AND MAKP = '"
                    + cbxKP.SelectedValue.ToString().Trim() + "'";
            SqlDataReader data = Program.ExecSqlDataReader(sql);
            bool check = data.Read();
            data.Close();
            return check;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(!checkThongTin())
            {
                return;
            }

            if(dangThemMoi)
            {
                if(checkHP())
                {
                    MessageBox.Show("Mã hạng phòng này đã tồn tại!");
                    txtMaHP.Focus();
                    return;
                }

                if(checkKPLP())
                {
                    MessageBox.Show("Hạng phòng có kiểu phòng và loại phòng này đã tồn tại, hãy chọn cái khác!");
                    cbxLP.Focus();
                    return;
                }
            }

            if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
                gcHangPhong.Enabled = true;
                txtMaHP.Enabled = btnHuy.Enabled = false;

                bdsHangPhong.EndEdit();

                this.hANGPHONGTableAdapter.Connection = Program.conn;
                this.hANGPHONGTableAdapter.Update(this.DS.HANGPHONG);

                dangThemMoi = false;
                MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void cbxKP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtKP.Text = cbxKP.SelectedValue.ToString();
            } catch (Exception ex)
            {

            }
            
        }

        private void cbxLP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtLP.Text = cbxLP.SelectedValue.ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(bdsPhong.Count > 0)
            {
                MessageBox.Show("Hạng phòng này đã được sử dụng, không thể xóa!");
                return;
            }

            if(bdsPhong.Count > 0)
            {
                MessageBox.Show("Hạng phòng này đã được sử dụng cho các phòng, không thể xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa hạng phòng này ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bdsHangPhong.RemoveCurrent();
                hANGPHONGTableAdapter.Connection = Program.conn;
                hANGPHONGTableAdapter.Update(DS.HANGPHONG);

                MessageBox.Show("Xóa hạng phòng thành công!\n", "", MessageBoxButtons.OK);
            }
        }
    }
}
