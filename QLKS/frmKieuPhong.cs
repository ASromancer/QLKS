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
    public partial class frmKieuPhong : Form
    {

        int vitri;
        bool dangThemMoi = false;
        public frmKieuPhong()
        {
            InitializeComponent();
        }

        private void kIEUPHONGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKieuPhong.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmKieuPhong_Load(object sender, EventArgs e)
        {
            this.DS.EnforceConstraints = false;

            this.hANGPHONGTableAdapter.Connection = Program.conn;
            this.hANGPHONGTableAdapter.Fill(this.DS.HANGPHONG);
            this.kIEUPHONGTableAdapter.Connection = Program.conn;
            this.kIEUPHONGTableAdapter.Fill(this.DS.KIEUPHONG);

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.kIEUPHONGTableAdapter.Fill(this.DS.KIEUPHONG);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi RELOAD: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThemMoi = true;
            vitri = bdsKieuPhong.Position;

            bdsKieuPhong.AddNew();

            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
            gcKieuPhong.Enabled = false;
            txtMaKP.Enabled = btnHuy.Enabled = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
            gcKieuPhong.Enabled = true;
            txtMaKP.Enabled = btnHuy.Enabled = false;

            bdsKieuPhong.CancelEdit();
            this.kIEUPHONGTableAdapter.Fill(this.DS.KIEUPHONG);
            bdsKieuPhong.Position = vitri;
        }

        bool checkThongTin()
        {
            if(txtMaKP.Text.Trim() == "")
            {
                MessageBox.Show("Mã kiểu phòng trống!");
                txtMaKP.Focus();
                return false;
            }

            if (txtMaKP.Text.Trim().Length != 5)
            {
                MessageBox.Show("Mã kiểu phòng gồm 5 kí tự KPxxx, vui lòng nhập lại!");
                txtMaKP.Focus();
                return false;
            }
            if (!txtMaKP.Text.Contains("KP"))
            {
                MessageBox.Show("Mã kiểu phòng phải được nhập theo mãu KPxxx, vui lòng nhập lại!");
                txtMaKP.Focus();
                return false;
            }

            if(txtTenKP.Text.Trim() == "")
            {
                MessageBox.Show("Tên kiểu phòng trống!");
                txtTenKP.Focus();
                return false;
            }

            return true;
        }

        bool checkKP()
        {
            String sql = "SELECT * FROM KIEUPHONG WHERE MAKP = '" + txtMaKP.Text.Trim() + "'";
            SqlDataReader data = Program.ExecSqlDataReader(sql);
            bool check = data.Read();
            data.Close();
            return check;
        }

        bool checkTenKP()
        {
            String sql = "SELECT * FROM KIEUPHONG WHERE TENKIEUPHONG = N'" + txtTenKP.Text.Trim() + "'";
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
                if (checkKP())
                {
                    MessageBox.Show("Mã kiểu phòng đã tồn tại, vui lòng nhập lại!");
                    txtMaKP.Focus();
                    return;
                }

                if (checkTenKP())
                {
                    MessageBox.Show("Tên kiểu phòng đã tồn tại, vui lòng nhập lại!");
                    txtTenKP.Focus();
                    return;
                }
            }

            if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
                gcKieuPhong.Enabled = true;
                txtMaKP.Enabled = btnHuy.Enabled = false;

                bdsKieuPhong.EndEdit();

                this.kIEUPHONGTableAdapter.Connection = Program.conn;
                this.kIEUPHONGTableAdapter.Update(this.DS.KIEUPHONG);

                dangThemMoi = false;
                MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(bdsHangPhong.Count > 0)
            {
                MessageBox.Show("Kiểu phòng này đã được sử dụng làm thông tin cho hạng phòng, không thể xóa!");
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa kiểu phòng này ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bdsKieuPhong.RemoveCurrent();
                kIEUPHONGTableAdapter.Connection = Program.conn;
                kIEUPHONGTableAdapter.Update(DS.KIEUPHONG);

                MessageBox.Show("Xóa kiểu phòng thành công!\n", "", MessageBoxButtons.OK);

            }
        }
    }
}
