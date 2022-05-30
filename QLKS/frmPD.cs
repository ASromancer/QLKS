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
    public partial class frmPD : Form
    {
        bool dangThemMoi = false;
        bool dangThemMoiCT = false;

        int vitri = 0;
        int vitriCT = 0;
        public frmPD()
        {
            InitializeComponent();
        }

        private void pHIEUDATBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPD.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmPD_Load(object sender, EventArgs e)
        {
            this.DS.EnforceConstraints = false;

            this.kHACHHANGTableAdapter.Connection = Program.conn;
            this.kHACHHANGTableAdapter.Fill(this.DS.KHACHHANG);

            this.nHANVIENTableAdapter.Connection = Program.conn;
            this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);

            this.cTPHIEUDATTableAdapter.Connection = Program.conn;
            this.cTPHIEUDATTableAdapter.Fill(this.DS.CTPHIEUDAT);

            this.pHIEUDATTableAdapter.Connection = Program.conn;
            this.pHIEUDATTableAdapter.Fill(this.DS.PHIEUDAT);

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private bool checkThongTinCTPD()
        {
            if(txtMaPhong.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn mã phòng");
                return false;
            }

            return true;
        }

        private bool checkTonTaiPhong()
        {
            String sql = "SELECT * FROM CTPHIEUDAT WHERE MAPD = '" + txtMaPD.Text.Trim() + "' AND MAPHONG = '" + txtMaPhong.Text.Trim() + "'";
            SqlDataReader data = Program.ExecSqlDataReader(sql);
            bool check = data.Read();
            data.Close();
            return check;
        }

        private void xóaChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string manv = ((DataRowView)bdsPD[bdsPD.Position])["MANV"].ToString();
            if (manv != Program.manv)
            {
                MessageBox.Show("Không thể ghi vào chi tiết phiếu đặt không phải do chính mình tạo");
                return;
            }

            if (((DateTime)txtNgayBatDauThue.EditValue).Date < DateTime.Now.Date)
            {
                MessageBox.Show("Phiếu đặt này đã hết hạn vì ngày bắt đầu thuê < ngày hiện tại, không thể thao tác!");
                return;
            }

            if (!checkThongTinCTPD())
            {
                return;
            }

            if(dangThemMoiCT)
            {
                if (checkTonTaiPhong())
                {
                    MessageBox.Show("Phòng này đã có trong chi tiết phiếu đặt, hãy chọn phòng khác!");
                    return;
                }
            }

            // Lấy tổng thời gian thuê
            TimeSpan ts = ((DateTime)spnNgayGioTraPhong.EditValue).Subtract(Program.tgBdThue);

            if(ts.Hours < 1)
            {
                MessageBox.Show("Thời gian thuê tối thiểu 1 tiếng!");
                return;
            }

            if (Program.tongTgianThueToiDa != 0 && Program.tongTgianThueToiDa < ts.TotalHours)
            {
                MessageBox.Show("Tổng thời gian thuê không được quá thời gian thuê tối đa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnChonHP.Enabled = btnHuyCT.Enabled = false;
                gcCTPD.Enabled = btnThemCT.Enabled = btnXoaCT.Enabled = gcPD.Enabled = true;

                //Phần này để ghi trạng thái 'Đặt trước' của phòng đó vào bảng chi tiết trạng thái phòng
                if (dangThemMoiCT)
                {
                    try
                    {
                        string sql = "INSERT INTO CT_TRANGTHAIPHONG(MAPHONG, TG_BATDAU, TG_KETTHUC, TRANGTHAI)" +
                                    "VALUES(" +
                                        "'" + txtMaPhong.Text + "', " +
                                        "'" + txtNgayBatDauThue.EditValue.ToString() + "', " +
                                        "'" + spnNgayGioTraPhong.EditValue.ToString() + "', " +
                                        "N'Đặt trước'" +
                                    ")";
                        Program.ExecSqlNonQuery(sql);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi thêm trạng thái đặt trước " + ex);
                        return;
                    }

                }
                //======================================================================================


                bdsCTPD.EndEdit();
                this.cTPHIEUDATTableAdapter.Connection = Program.conn;
                this.cTPHIEUDATTableAdapter.Update(this.DS.CTPHIEUDAT);

                dangThemMoiCT = false;
                MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.kHACHHANGTableAdapter.FillBy(this.DS.KHACHHANG);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cbxNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaNV.Text = cbxNV.SelectedValue.ToString();
            } catch (Exception ex) { }
        }

        private void cbxKH_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                txtMaKH.Text = cbxKH.SelectedValue.ToString();
            }
            catch (Exception ex) { }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.pHIEUDATTableAdapter.Fill(this.DS.PHIEUDAT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi RELOAD: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThemMoi = true;
            vitri = bdsPD.Position;
            bdsPD.AddNew();

            txtNgayLap.DateTime = DateTime.Now; // ngày lập phiếu đặt là ngày hiện tại
            txtNgayBatDauThue.EditValue = DateTime.Now; // set sẵn ngày bắt đầu thuê là ngày hiện tại, sau đó phải nâng lên
            txtMaNV.Text = Program.manv; // mã nhân viên lập phiếu sẽ là nhân viên đang đăng nhập
            cbxKH.SelectedIndex = 0;

            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = cbxNV.Enabled = false;
            gcPD.Enabled = gcCTPD.Enabled = false;
            txtMaPD.Enabled = btnHuy.Enabled = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = cbxNV.Enabled = true;
            gcPD.Enabled = gcCTPD.Enabled = true;
            txtMaPD.Enabled = btnHuy.Enabled = false;
            dangThemMoi = false;
            bdsPD.CancelEdit();
            this.pHIEUDATTableAdapter.Fill(this.DS.PHIEUDAT);
            bdsPD.Position = vitri;
        }

        bool checkThongTin()
        {

            if(txtMaPD.Text.Trim() == "")
            {
                MessageBox.Show("Mã phiếu đặt trống");
                txtMaPD.Focus();
                return false;
            }

            if(txtMaPD.Text.Trim().Length != 5)
            {
                MessageBox.Show("Mã phiếu đặt gồm 5 kí tự PDxxx, vui lòng nhập lại!");
                txtMaPD.Focus();
                return false;
            }
            if (!txtMaPD.Text.Contains("PD"))
            {
                MessageBox.Show("Mã phiếu đặt phải được nhập theo mẫu PDxxx, vui lòng nhập lại!");
                txtMaPD.Focus();
                return false;
            }

            if( ((DateTime)txtNgayBatDauThue.EditValue) <= DateTime.Now)
            {
                MessageBox.Show("Ngày giờ bắt đầu thuê phải lớn hơn ngày giờ hiện tại!");
                txtNgayBatDauThue.Focus();
                return false;
            }

            if(cbxKH.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Chọn khách hàng!");
                cbxKH.Focus();
                return false;
            }

            return true;
        }

        private bool checkPD()
        {
            String sql = "SELECT * FROM PHIEUDAT WHERE MAPD = '" + txtMaPD.Text.Trim() + "'";
            SqlDataReader data = Program.ExecSqlDataReader(sql);
            bool check = data.Read();
            data.Close();
            return check;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string manv = ((DataRowView)bdsPD[bdsPD.Position])["MANV"].ToString();

            if (manv != Program.manv)
            {
                MessageBox.Show("Không thể ghi phiếu đặt không phải của chính mình lập!");
                return;
            }

            if (!checkThongTin())
            {
                return;
            }

            if(dangThemMoi)
            {
                if(checkPD())
                {
                    MessageBox.Show("Mã phiếu đặt đã tồn tại!");
                    return;
                }
            }

            if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
                gcPD.Enabled = gcCTPD.Enabled = true;
                txtMaPD.Enabled = btnHuy.Enabled = false;

                bdsPD.EndEdit();

                this.pHIEUDATTableAdapter.Connection = Program.conn;
                this.pHIEUDATTableAdapter.Update(this.DS.PHIEUDAT);

                dangThemMoi = false;
                MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string manv = ((DataRowView)bdsPD[bdsPD.Position])["MANV"].ToString();

            if(manv != Program.manv)
            {
                MessageBox.Show("Không thể xóa phiếu đặt không phải của chính mình lập!");
                return;
            }

            if(bdsCTPD.Count > 0)
            {
                MessageBox.Show("Phiếu đặt này đã có chi tiết phiếu đặt, không thể xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa phiếu đặt này ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bdsPD.RemoveCurrent();
                pHIEUDATTableAdapter.Connection = Program.conn;
                pHIEUDATTableAdapter.Update(DS.PHIEUDAT);

                gcCTPD.Enabled = true;

                MessageBox.Show("Xóa phiếu đặt thành công!\n", "", MessageBoxButtons.OK);
            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            string manv = ((DataRowView)bdsPD[bdsPD.Position])["MANV"].ToString();

            if(manv != Program.manv)
            {
                MessageBox.Show("Không thể thêm vào chi tiết phiếu đặt không phải của chính mình tạo!");
                return;
            }

            if (((DateTime)txtNgayBatDauThue.EditValue).Date < DateTime.Now.Date)
            {
                MessageBox.Show("Phiếu đặt này đã hết hạn vì ngày bắt đầu thuê < ngày hiện tại, không thể thao tác!");
                return;
            }

            gcPD.Focus();

            btnChonHP.Enabled = btnHuyCT.Enabled = true;
            btnChonHP.Focus();

            vitriCT = bdsCTPD.Position;
            dangThemMoiCT = true;

            gcCTPD.Enabled = btnThemCT.Enabled = btnXoaCT.Enabled = gcPD.Enabled = false;
            bdsCTPD.AddNew();
            ((DataRowView)bdsCTPD[bdsCTPD.Position])["MAPD"] = txtMaPD.Text;
            spnNgayGioTraPhong.EditValue = (DateTime)txtNgayBatDauThue.EditValue; // mặc định đặt thời gian trả phòng là thời gian bắt đầu thuê, sau đó tự chỉnh

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnChonHP_Click(object sender, EventArgs e)
        {
            Form frm = CheckExists(typeof(frmChonPhong));
            if (frm != null)
                frm.Activate();
            else
            {
                Program.tgBdThue = (DateTime)txtNgayBatDauThue.EditValue;

                frmChonPhong f = new frmChonPhong();
                f.ShowDialog();

                txtMaPhong.Text = Program.maPhongDaChon;

                txtMaxTgThue.Text = Program.gioThueToiDa + " giờ " + Program.phutThueToiDa + " phút";
            }
        }

        private void btnHuyCT_Click(object sender, EventArgs e)
        {
            dangThemMoiCT = false;

            btnChonHP.Enabled = btnHuyCT.Enabled = false;
            gcCTPD.Enabled = btnThemCT.Enabled = btnXoaCT.Enabled = gcPD.Enabled = true;

            bdsCTPD.CancelEdit();
            this.cTPHIEUDATTableAdapter.Connection = Program.conn;
            this.cTPHIEUDATTableAdapter.Fill(this.DS.CTPHIEUDAT);
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            string manv = ((DataRowView)bdsPD[bdsPD.Position])["MANV"].ToString();

            if (manv != Program.manv)
            {
                MessageBox.Show("Không thể xóa chi tiết phiếu đặt không phải của chính mình tạo!");
                return;
            }

            if( ((DateTime)txtNgayBatDauThue.EditValue).Date < DateTime.Now.Date)
            {
                MessageBox.Show("Phiếu đặt này đã hết hạn vì ngày bắt đầu thuê < ngày hiện tại, không thể thao tác!");
                return;
            }

            if(bdsCTPD.Count == 0)
            {
                MessageBox.Show("Không có chi tiết phiếu đặt để xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa hạng phòng này khỏi chi tiết phiếu đặt ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                // Xóa phòng này trong chi tiết trạng thái
                try
                {
                    string sql = "DELETE FROM CT_TRANGTHAIPHONG WHERE MAPHONG = '" 
                                    + txtMaPhong.Text + "' AND TG_BATDAU = '" + txtNgayBatDauThue.EditValue.ToString() + "'";
                    Program.ExecSqlNonQuery(sql);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa trạng thái đặt trước " + ex);
                    return;
                }
                //==========================================

                bdsCTPD.RemoveCurrent();
                this.cTPHIEUDATTableAdapter.Connection = Program.conn;
                this.cTPHIEUDATTableAdapter.Update(this.DS.CTPHIEUDAT);

                dangThemMoiCT = false;
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

        }

        private void spnNgayGioTraPhong_EditValueChanged(object sender, EventArgs e)
        {
            TimeSpan ts = ((DateTime)spnNgayGioTraPhong.EditValue).Subtract((DateTime)txtNgayBatDauThue.EditValue);

            int hour = ts.Hours;
            int minute = ts.Minutes;

            txtTongThoiGianThue.Text = hour + " giờ " + minute + " phút";
            
        }
    }
}
