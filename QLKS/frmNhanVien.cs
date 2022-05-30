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
    public partial class frmNhanVien : Form
    {

        int vitri;
        bool dangThemMoi = false;

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void nHANVIENBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            this.DS.EnforceConstraints = false;


            this.pHIEUTHUETableAdapter.Connection = Program.conn;
            this.pHIEUTHUETableAdapter.Fill(this.DS.PHIEUTHUE);

            this.pHIEUDATTableAdapter.Connection = Program.conn;
            this.pHIEUDATTableAdapter.Fill(this.DS.PHIEUDAT);

            this.hOADONTableAdapter.Connection = Program.conn;
            this.hOADONTableAdapter.Fill(this.DS.HOADON);

            this.bOPHANTableAdapter.Connection = Program.conn;
            this.bOPHANTableAdapter.Fill(this.DS.BOPHAN);

            this.nHANVIENTableAdapter.Connection = Program.conn;
            this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi RELOAD: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private int CalculateAge(DateTime dob)
        {
            int age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.DayOfYear < dob.DayOfYear)
                age -= 1;
            return age;
        }

        private bool checkThongTin()
        {
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên trống!");
                txtMaNV.Focus();
                return false;
            }

            if (txtMaNV.Text.Trim().Length != 5)
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên, mã nhân viên phải có 5 kí tự KHxxx!");
                txtMaNV.Focus();
                return false;
            }

            if (!txtMaNV.Text.Contains("NV"))
            {
                MessageBox.Show("Mã nhân viên không đúng yêu cầu, vui lòng nhập lại theo NVxxx!");
                txtMaNV.Focus();
                return false;
            }

            if (txtHo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập Họ !");
                txtHo.Focus();
                return false;
            }

            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập Tên !");
                txtTen.Focus();
                return false;
            }

            if (txtPhone.Text.Trim().Length != 10)
            {
                MessageBox.Show("Vui lòng nhập SDT !");
                txtPhone.Focus();
                return false;
            }

            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!");
                txtDiaChi.Focus();
                return false;
            }

            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập email !");
                txtEmail.Focus();
                return false;
            }

            if (txtPhai.Text.Trim() == "")
            {
                txtPhai.Focus();
                MessageBox.Show("Giới tính trống!");
                return false;
            }

            if (txtPhai.Text.Trim() != "Nam" && txtPhai.Text.Trim() != "Nữ")
            {
                txtPhai.Focus();
                MessageBox.Show("Giới tính chỉ nhập Nam hoặc Nữ!");
                return false;
            }

            if (CalculateAge(txtNgaySinh.DateTime) < 18)
            {
                MessageBox.Show("Nhân viên chưa đủ 18 tuổi");
                txtNgaySinh.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThemMoi = true;
            vitri = bdsNhanVien.Position;

            bdsNhanVien.AddNew();
            txtMaNV.Text = "";
            cbxBP.SelectedIndex = 1;

            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
            gcNhanVien.Enabled = false;
            txtMaNV.Enabled = btnHuy.Enabled = true;

        }

        private bool checkMaNV()
        {
            String sql = "SELECT * FROM NHANVIEN WHERE MANV = '" + txtMaNV.Text.Trim() + "'";
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
            if(dangThemMoi)
            {
                if (checkMaNV())
                {
                    txtMaNV.Focus();
                    MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK);

                }
            }

            if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
                gcNhanVien.Enabled = true;
                txtMaNV.Enabled = btnHuy.Enabled = false;
                bdsNhanVien.EndEdit();

                this.nHANVIENTableAdapter.Connection = Program.conn;
                this.nHANVIENTableAdapter.Update(this.DS.NHANVIEN);

                dangThemMoi = false;
                MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
            gcNhanVien.Enabled = true;
            txtMaNV.Enabled = btnHuy.Enabled = false;

            bdsNhanVien.CancelEdit();
            this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
            bdsNhanVien.Position = vitri;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsPD.Count > 0)
            {
                MessageBox.Show("Nhân viên đã lập phiếu đặt không thể xóa");
                return;
            }
            if (bdsPT.Count > 0)
            {
                MessageBox.Show("Nhân viên đã lập phiếu thuê không thể xóa");
                return;
            }
            if (bdsHoaDon.Count > 0)
            {
                MessageBox.Show("Nhân viên đã lập hóa đơn không thể xóa");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này ?", "Thông báo",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bdsNhanVien.RemoveCurrent();

                this.nHANVIENTableAdapter.Connection = Program.conn;
                this.nHANVIENTableAdapter.Update(this.DS.NHANVIEN);

                MessageBox.Show("Xóa nhân viên thành công!\n", "", MessageBoxButtons.OK);
            }
        }

        private void cbxBP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaBP.Text = cbxBP.SelectedValue.ToString();
            } catch(Exception ex)
            {

            }
        }
    }
}
