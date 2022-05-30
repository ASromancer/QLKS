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
    public partial class frmKhach : Form
    {
        int vitri;
        bool dangThemMoi = false;

        public frmKhach()
        {
            InitializeComponent();
        }

        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhach.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmKhach_Load(object sender, EventArgs e)
        {
            this.DS.EnforceConstraints = false;

            this.pHIEUTHUETableAdapter.Connection = Program.conn;
            this.pHIEUTHUETableAdapter.Fill(this.DS.PHIEUTHUE);

            this.pHIEUDATTableAdapter.Connection = Program.conn;
            this.pHIEUDATTableAdapter.Fill(this.DS.PHIEUDAT);

            this.kHACHHANGTableAdapter.Connection = Program.conn;
            this.kHACHHANGTableAdapter.Fill(this.DS.KHACHHANG);

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.kHACHHANGTableAdapter.Fill(this.DS.KHACHHANG);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi RELOAD: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThemMoi = true;
            vitri = bdsKhach.Position;

            bdsKhach.AddNew();

            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
            gcKhach.Enabled = false;
            txtMaKhach.Enabled = btnHuy.Enabled = true;


        }

        private bool checkMAKH()
        {
            String sql = "SELECT * FROM KHACHHANG WHERE MAKH = '" + txtMaKhach.Text.Trim() + "'";
            SqlDataReader data = Program.ExecSqlDataReader(sql);
            bool check = data.Read();
            data.Close();
            return check;
        }

        private bool checkMSTHUE()
        {
            String sql = "SELECT * FROM KHACHHANG WHERE MASOTHUE = '" + txtMaSoThue.Text.Trim() + "'";
            SqlDataReader data = Program.ExecSqlDataReader(sql);
            bool check = data.Read();
            data.Close();
            return check;
        }

        private bool checkThongTin()
        {

            if (txtMaKhach.Text.Trim().Length != 5)
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng, mã khách hàng phải có 5 kí tự KHxxx!");
                txtMaKhach.Focus();
                return false;
            }

            if(txtMaKhach.Text.Trim() == "") 
            {
                MessageBox.Show("Mã khách trống!");
                txtMaKhach.Focus();
                return false;
            }

            if (!txtMaKhach.Text.Contains("KH"))
            {
                MessageBox.Show("Mã khách hàng không đúng yêu cầu, vui lòng nhập lại mã khách hàng!");
                txtMaKhach.Focus();
                return false;
            }

            if(txtHo.Text.Trim().Length == 0)
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
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập email !");
                txtEmail.Focus();
                return false;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ !");
                txtDiaChi.Focus();
                return false;
            }
            if (txtMaSoThue.Text.Trim().Length != 6)
            {
                MessageBox.Show("Vui lòng nhập mã số thuế theo VATxxx!");
                txtMaSoThue.Focus();
                return false;
            }
            if (!txtMaSoThue.Text.Contains("VAT"))
            {
                MessageBox.Show("Mã số thuế không đúng yêu cầu, vui lòng nhập lại!");
                txtMaSoThue.Focus();
                return false;
            }

            return true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkThongTin())
            {
                return;
            }

            if (dangThemMoi)
            {
                if (checkMAKH())
                {
                    MessageBox.Show("Mã khách đã tồn tại, vui lòng nhập lại!");
                    txtMaKhach.Focus();
                    return;
                }

                if (checkMSTHUE())
                {
                    MessageBox.Show("Mã số thuế đã tồn tại, vui lòng nhập lại!");
                    txtMaSoThue.Focus();
                    return;
                }
            }

            if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
                gcKhach.Enabled = true;
                txtMaKhach.Enabled = btnHuy.Enabled = false;

                bdsKhach.EndEdit();

                this.kHACHHANGTableAdapter.Connection = Program.conn;
                this.kHACHHANGTableAdapter.Update(this.DS.KHACHHANG);

                dangThemMoi = false;
                MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsPT.Count > 0)
            {
                MessageBox.Show("Khách đã được lập phiếu thuê, không thể xóa!");
                return;
            }

            if (bdsPD.Count > 0)
            {
                MessageBox.Show("Khách đã được lập phiếu đặt, không thể xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa phòng này ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bdsKhach.RemoveCurrent();
                kHACHHANGTableAdapter.Connection = Program.conn;
                kHACHHANGTableAdapter.Fill(DS.KHACHHANG);

                MessageBox.Show("Xóa khách thành công!\n", "", MessageBoxButtons.OK);
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
            gcKhach.Enabled = true;
            txtMaKhach.Enabled = btnHuy.Enabled = false;

            bdsKhach.CancelEdit();
            this.kHACHHANGTableAdapter.Update(this.DS.KHACHHANG);
            bdsKhach.Position = vitri;
        }
    }
}
