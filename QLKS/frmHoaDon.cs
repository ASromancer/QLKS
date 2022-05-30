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
    public partial class frmHoaDon : Form
    {

        bool dangThemMoi = false;
        int vitri = 0;

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void hOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsHD.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {

            this.DS.EnforceConstraints = false;

            this.pHIEUTHUETableAdapter.Connection = Program.conn;
            this.pHIEUTHUETableAdapter.Fill(this.DS.PHIEUTHUE);

            this.hOADONTableAdapter.Connection = Program.conn;
            this.hOADONTableAdapter.Fill(this.DS.HOADON);

        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnChonPT_Click(object sender, EventArgs e)
        {
            Form frm = CheckExists(typeof(frmPhieuThueChuaHoaDon));
            if (frm != null)
                frm.Activate();
            else
            {
                frmPhieuThueChuaHoaDon f = new frmPhieuThueChuaHoaDon();
                f.ShowDialog();
                this.txtMaPT.Text = Program.maptDaChon;
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.hOADONTableAdapter.Fill(this.DS.HOADON);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi RELOAD: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThemMoi = true;
            vitri = bdsHD.Position;

            bdsHD.AddNew();

            txtNgayTao.EditValue = DateTime.Now; // ngày lập phiếu đặt là ngày hiện tại
            txtMaNV.Text = Program.manv; // mã nhân viên lập phiếu sẽ là nhân viên đang đăng nhập

            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
            gcHD.Enabled = false;
            txtMaHD.Enabled = btnHuy.Enabled = btnChonPT.Enabled = true;
            txtMaHD.Focus();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
            gcHD.Enabled = true;
            txtMaHD.Enabled = btnHuy.Enabled = btnChonPT.Enabled = false;
            dangThemMoi = false;
            bdsHD.CancelEdit();
            this.hOADONTableAdapter.Fill(this.DS.HOADON);
            bdsHD.Position = vitri;
        }

        bool checkThongTin()
        {

            if (txtMaHD.Text.Trim() == "")
            {
                MessageBox.Show("Mã hóa đơn trống");
                txtMaHD.Focus();
                return false;
            }

            if (txtMaHD.Text.Trim().Length != 5)
            {
                MessageBox.Show("Mã hóa đơn gồm 5 kí tự HDxxx, vui lòng nhập lại!");
                txtMaHD.Focus();
                return false;
            }
            if (!txtMaHD.Text.Contains("HD"))
            {
                MessageBox.Show("Mã hóa đơn phải được nhập theo mẫu HDxxx, vui lòng nhập lại!");
                txtMaHD.Focus();
                return false;
            }
            return true;
        }

        private bool checkHD()
        {
            String sql = "SELECT * FROM HOADON WHERE MAHD = '" + txtMaHD.Text.Trim() + "'";
            SqlDataReader data = Program.ExecSqlDataReader(sql);
            bool check = data.Read();
            data.Close();
            return check;
        }

        private double tongTienPhongCuaPT(string mapt)
        {
            double total = 0;

            string sql = "SELECT CTPT.MAPHONG, NGAYGIODEN, NGAYGIODI, " +
                         "SOPHUTTHUE = DATEDIFF(MINUTE, NGAYGIODEN, NGAYGIODI), " +
                         "HP.GIAHANGPHONG, " +
                         "TONGCONG = (DATEDIFF(MINUTE, NGAYGIODEN, NGAYGIODI) / 60.0) * HP.GIAHANGPHONG " +
                         "FROM CTPHIEUTHUE CTPT, HANGPHONG HP, PHONG P " +
                         "WHERE CTPT.MAPT = '" + mapt + "' AND CTPT.MAPHONG = P.MAPHONG AND P.MAHP = HP.MAHP";

            SqlDataReader data = Program.ExecSqlDataReader(sql);
            
            while(data.Read())
            {
                total += data.GetDouble(5);
            }
            data.Close();
            return total;
        }

        private double tongTienDichVuCuaPT(string mapt)
        {
            double total = 0;

            string sql = "SELECT DV.MADV, CTDV.SOLUONG, DV.GIA, TONG = SOLUONG * GIA " +
                         "FROM CTDICHVU CTDV, DICHVU DV " +
                         "WHERE CTDV.MAPT = '" + mapt + "' AND CTDV.MADV = DV.MADV";
            SqlDataReader data = Program.ExecSqlDataReader(sql);

            while (data.Read())
            {
                total += data.GetDouble(3);
            }
            data.Close();
            return total;
        }

        private bool checkHDforPT()
        {
            string sql = "SELECT MAPT FROM HOADON WHERE MAPT = '" + txtMaPT.Text + "'";
            SqlDataReader data = Program.ExecSqlDataReader(sql);
            bool check = data.Read();
            data.Close();
            return check;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string manv = ((DataRowView)bdsHD[bdsHD.Position])["MANV"].ToString();

            if(bdsHD.Count == 0)
            {
                MessageBox.Show("Không còn gì để ghi");
                return;
            }

            if (manv != Program.manv)
            {
                MessageBox.Show("Không thể ghi hóa đơn không phải của chính mình lập!");
                return;
            }

            if (!checkThongTin())
            {
                return;
            }

            if(txtMaPT.Text == "")
            {
                MessageBox.Show("Chưa chọn phiếu thuê!");
                return;
            }

            if (dangThemMoi)
            {
                if (checkHD())
                {
                    MessageBox.Show("Mã hóa đơn đã tồn tại!");
                    return;
                }
            }

            if(checkHDforPT())
            {
                MessageBox.Show("Hóa đơn cho phiếu thuê này đã có!");
                return;
            }

            if (MessageBox.Show("Xác nhận tạo hóa đơn cho phiếu thuê này ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
                gcHD.Enabled = true;
                txtMaHD.Enabled = btnHuy.Enabled = btnChonPT.Enabled = false;

                // Tính tổng tiền phòng và dịch vụ đã sử dụng của phiếu thuê

                double tongTienPhong = tongTienPhongCuaPT(txtMaPT.Text);
                double tongTienDichVu = tongTienDichVuCuaPT(txtMaPT.Text);

                ((DataRowView)bdsHD[bdsHD.Position])["TONGTIEN"] = tongTienPhong + tongTienDichVu;

                //==========================================================


                bdsHD.EndEdit();

                this.hOADONTableAdapter.Connection = Program.conn;
                this.hOADONTableAdapter.Update(this.DS.HOADON);

                dangThemMoi = false;
                MessageBox.Show("Tạo hóa đơn thành công thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string manv = ((DataRowView)bdsHD[bdsHD.Position])["MANV"].ToString();

            if (bdsHD.Count == 0)
            {
                MessageBox.Show("Không còn gì để xóa");
                return;
            }

            if (manv != Program.manv)
            {
                MessageBox.Show("Không thể xóa hóa đơn không phải của chính mình lập!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này ?\n"
                            + "Hành động này sẽ xóa vĩnh viễn hóa đơn và có thể gây mất mát dữ liệu!", "Cảnh báo!!!!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bdsHD.RemoveCurrent();
                hOADONTableAdapter.Connection = Program.conn;
                hOADONTableAdapter.Update(DS.HOADON);

                gcHD.Enabled = true;

                MessageBox.Show("Xóa hóa đơn thành công!\n", "", MessageBoxButtons.OK);
            }
        }

        private void btnXuatCTHoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}
