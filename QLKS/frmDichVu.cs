using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class frmDichVu : Form
    {

        int vitri;
        bool dangThemMoi = false;
        public frmDichVu()
        {
            InitializeComponent();
        }

        private void dICHVUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDichVu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            this.DS.EnforceConstraints = false;

            this.cTDICHVUTableAdapter.Connection = Program.conn;
            this.cTDICHVUTableAdapter.Fill(this.DS.CTDICHVU);

            this.dICHVUTableAdapter.Connection = Program.conn;
            this.dICHVUTableAdapter.Fill(this.DS.DICHVU);

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThemMoi = true;
            vitri = bdsDichVu.Position;
            bdsDichVu.AddNew();


            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
            gcDichVu.Enabled = false;
            txtMaDV.Enabled = btnHuy.Enabled = true;
        }

        bool checkThongTin()
        {
            if(txtMaDV.Text.Trim() == "")
            {
                MessageBox.Show("Mã dịch vụ trống!");
                txtMaDV.Focus();
                return false;
            }

            if (txtMaDV.Text.Trim().Length != 5)
            {
                MessageBox.Show("Mã phòng gồm 5 kí tự DVxxx, vui lòng nhập lại!");
                txtMaDV.Focus();
                return false;
            }
            if (!txtMaDV.Text.Contains("DV"))
            {
                MessageBox.Show("Mã dịch vụ phải được nhập theo mẫu DVxxx, vui lòng nhập lại!");
                txtMaDV.Focus();
                return false;
            }

            if(txtTenDV.Text.Trim() == "")
            {
                MessageBox.Show("Tên dịch vụ trống!");
                txtTenDV.Focus();
                return false;
            }

            if (txtGia.Text.Trim() == "")
            {
                MessageBox.Show("Giá dịch vụ trống!");
                txtGia.Focus();
                return false;
            }

            if (int.Parse(txtGia.EditValue.ToString()) < 0)
            {
                MessageBox.Show("Giá dịch vụ phải lớn hơn 0!");
                txtGia.Focus();
                return false;
            }

            return true;
        }

        private bool checkDV()
        {
            String sql = "SELECT * FROM DICHVU WHERE MADV = '" + txtMaDV.Text.Trim() + "'";
            SqlDataReader data = Program.ExecSqlDataReader(sql);
            bool check = data.Read();
            data.Close();
            return check;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkThongTin())
            {
                return;
            }

            if (dangThemMoi)
            {
                if (checkDV())
                {
                    MessageBox.Show("Mã dịch vụ đã tồn tại, vui lòng nhập lại!");
                    txtMaDV.Focus();
                    return;
                }
            }

            if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
                gcDichVu.Enabled = true;
                txtMaDV.Enabled = btnHuy.Enabled = false;

                bdsDichVu.EndEdit();

                this.dICHVUTableAdapter.Connection = Program.conn;
                this.dICHVUTableAdapter.Update(this.DS.DICHVU);

                dangThemMoi = false;
                MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
            gcDichVu.Enabled = true;
            txtMaDV.Enabled = btnHuy.Enabled = false;

            bdsDichVu.CancelEdit();
            this.dICHVUTableAdapter.Fill(this.DS.DICHVU);
            bdsDichVu.Position = vitri;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.dICHVUTableAdapter.Fill(this.DS.DICHVU);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi RELOAD: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTDV.Count > 0)
            {
                MessageBox.Show("Dịch vụ này đã được sử dụng, không thể xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa dịch vụ này ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bdsDichVu.RemoveCurrent();
                dICHVUTableAdapter.Connection = Program.conn;
                dICHVUTableAdapter.Update(DS.DICHVU);

                MessageBox.Show("Xóa dịch vụ thành công!\n", "", MessageBoxButtons.OK);
            }
        }
    }
}
