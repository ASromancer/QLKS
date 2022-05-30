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
    public partial class frmLoaiPhong : Form
    {
        int vitri;
        bool dangThemMoi = false;

        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        private void lOAIPHONGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLoaiPhong.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            this.DS.EnforceConstraints = false;

            this.hANGPHONGTableAdapter.Connection = Program.conn;
            this.hANGPHONGTableAdapter.Fill(this.DS.HANGPHONG);

            this.lOAIPHONGTableAdapter.Connection = Program.conn;
            this.lOAIPHONGTableAdapter.Fill(this.DS.LOAIPHONG);

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThemMoi = true;
            vitri = bdsLoaiPhong.Position;
            bdsLoaiPhong.AddNew();


            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
            gcLoaiPhong.Enabled = false;
            txtMaLP.Enabled = btnHuy.Enabled = true;
        }

        bool checkThongTin()
        {

            if(txtMaLP.Text.Trim() == "")
            {
                MessageBox.Show("Mã loại phòng trống!");
                txtMaLP.Focus();
                return false;
            }

            if (txtMaLP.Text.Trim().Length != 5)
            {
                MessageBox.Show("Mã loại phòng gồm 5 kí tự LPxxx, vui lòng nhập lại!");
                txtMaLP.Focus();
                return false;
            }
            if (!txtMaLP.Text.Contains("LP"))
            {
                MessageBox.Show("Mã loại phòng phải được nhập theo mẫu LPxxx, vui lòng nhập lại!");
                txtMaLP.Focus();
                return false;
            }

            if (txtMaLP.Text.Trim() == "")
            {
                MessageBox.Show("Mã loại phòng trống!");
                txtMaLP.Focus();
                return false;
            }

            return true;
        }

        bool checkLP()
        {
            String sql = "SELECT * FROM LOAIPHONG WHERE MALP = '" + txtMaLP.Text.Trim() + "'";
            SqlDataReader data = Program.ExecSqlDataReader(sql);
            bool check = data.Read();
            data.Close();
            return check;
        }

        bool checkTenLP()
        {
            String sql = "SELECT * FROM LOAIPHONG WHERE TENLOAIPHONG = N'" + txtTenLP.Text.Trim() + "'";
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
                if(checkLP())
                {
                    MessageBox.Show("Mã loại phòng đã tồn tại!");
                    txtMaLP.Focus();
                    return;
                }

                if(checkTenLP())
                {
                    MessageBox.Show("Tên loại phòng đã tồn tại, hãy chọn tên khác!");
                    txtMaLP.Focus();
                    return;
                }
            }

            if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
                gcLoaiPhong.Enabled = true;
                txtMaLP.Enabled = btnHuy.Enabled = false;

                bdsLoaiPhong.EndEdit();

                this.lOAIPHONGTableAdapter.Connection = Program.conn;
                this.lOAIPHONGTableAdapter.Update(this.DS.LOAIPHONG);

                dangThemMoi = false;
                MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(bdsHangPhong.Count > 0)
            {
                MessageBox.Show("Loại phòng này đã được sử dụng làm thông tin cho hạng phòng, không thể xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa loại phòng này ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bdsLoaiPhong.RemoveCurrent();
                lOAIPHONGTableAdapter.Connection = Program.conn;
                lOAIPHONGTableAdapter.Update(DS.LOAIPHONG);

                MessageBox.Show("Xóa loại phòng thành công!\n", "", MessageBoxButtons.OK);
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
            gcLoaiPhong.Enabled = true;
            txtMaLP.Enabled = btnHuy.Enabled = false;

            bdsLoaiPhong.CancelEdit();
            this.lOAIPHONGTableAdapter.Fill(this.DS.LOAIPHONG);
            bdsLoaiPhong.Position = vitri;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOAIPHONGTableAdapter.Fill(this.DS.LOAIPHONG);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi RELOAD: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }
    }
}
