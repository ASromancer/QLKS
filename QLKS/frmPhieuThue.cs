using System;
using System.Collections;
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
    public partial class frmPhieuThue : Form
    {
        bool dangThemMoi = false;
        bool dangThemMoiCT = false;

        int vitri = 0;
        int vitriCT = 0;

        DateTime ngayGioDen; // cái này để nhận thời gian bắt đầu thuê từ phiếu đặt
        public frmPhieuThue()
        {
            InitializeComponent();
        }

        private void pHIEUTHUEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmPhieuThue_Load(object sender, EventArgs e)
        {
            
            this.DS.EnforceConstraints = false;

            this.cTDICHVUTableAdapter.Connection = Program.conn;
            this.cTDICHVUTableAdapter.Fill(this.DS.CTDICHVU);

            this.cTPHIEUTHUETableAdapter.Connection = Program.conn;
            this.cTPHIEUTHUETableAdapter.Fill(this.DS.CTPHIEUTHUE);

            this.kHACHHANGTableAdapter.Connection = Program.conn;
            this.kHACHHANGTableAdapter.Fill(this.DS.KHACHHANG);

            this.nHANVIENTableAdapter.Connection = Program.conn;
            this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);

            this.pHIEUDATTableAdapter.Connection = Program.conn;
            this.pHIEUDATTableAdapter.Fill(this.DS.PHIEUDAT);

            this.pHIEUTHUETableAdapter.Connection = Program.conn;
            this.pHIEUTHUETableAdapter.Fill(this.DS.PHIEUTHUE);



        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.pHIEUTHUETableAdapter.Fill(this.DS.PHIEUTHUE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi RELOAD: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnChonPD_Click(object sender, EventArgs e)
        {
            // Kiểm tra phiếu thuê đã thuê xong thì ko cho chọn phòng nữa
            if (!checkPTChuaHetHan(txtMaPT.Text) && txtNgayLap.DateTime.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Phiếu thuê này đã thuê xong, không thể thao tác!");
                return;
            }

            Form frm = CheckExists(typeof(frmPDKhongPT));
            if (frm != null)
                frm.Activate();
            else
            {
                frmPDKhongPT f = new frmPDKhongPT();
                f.ShowDialog();
                this.txtMaPD.Text = Program.mapdDaChon;
                this.ngayGioDen = Program.tgBdThueCuaPD;
            }

            if(txtMaPD.Text != "")
            {
                btnLayDuLieuPhieuDat.Enabled = true;
                btnLayDuLieuPhieuDat.Focus();
            }
        }

        private void cbxNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaNV.Text = cbxNV.SelectedValue.ToString();

            }
            catch (Exception ex)
            {

            }
        }

        private void cbxKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaKH.Text = cbxKH.SelectedValue.ToString();

            }
            catch (Exception ex)
            {

            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThemMoi = true;
            vitri = bdsPT.Position;
            bdsPT.AddNew();

            txtNgayLap.DateTime = DateTime.Now; // ngày lập phiếu đặt là ngày hiện tại
            txtMaNV.Text = Program.manv; // mã nhân viên lập phiếu sẽ là nhân viên đang đăng nhập
            cbxKH.SelectedIndex = 0;

            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = cbxNV.Enabled = txtNgayLap.Enabled = false;
            gcPT.Enabled = gcCTPT.Enabled = false;
            txtMaPT.Enabled = btnHuy.Enabled = btnChonPD.Enabled = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = cbxNV.Enabled = txtNgayLap.Enabled = true;
            gcPT.Enabled = gcCTPT.Enabled = true;
            txtMaPT.Enabled = btnHuy.Enabled = btnChonPD.Enabled = false;
            dangThemMoi = false;
            bdsPT.CancelEdit();
            this.pHIEUTHUETableAdapter.Fill(this.DS.PHIEUTHUE);
            bdsPT.Position = vitri;
        }

        bool checkThongTin()
        {

            if (txtMaPT.Text.Trim() == "")
            {
                MessageBox.Show("Mã phiếu thuê trống");
                txtMaPT.Focus();
                return false;
            }

            if (txtMaPT.Text.Trim().Length != 5)
            {
                MessageBox.Show("Mã phiếu thuê gồm 5 kí tự PTxxx, vui lòng nhập lại!");
                txtMaPT.Focus();
                return false;
            }
            if (!txtMaPT.Text.Contains("PT"))
            {
                MessageBox.Show("Mã phiếu thuê phải được nhập theo mẫu PTxxx, vui lòng nhập lại!");
                txtMaPT.Focus();
                return false;
            }

            /*if(txtNgayLap.DateTime < DateTime.Now)
            {
                MessageBox.Show("Ngày lập phiếu thuê không thể < ngày hiện tại");
                txtNgayLap.Focus();
                return false;
            }*/

            if (cbxKH.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Chọn khách hàng!");
                cbxKH.Focus();
                return false;
            }

            return true;
        }

        private bool checkPT()
        {
            String sql = "SELECT * FROM PHIEUTHUE WHERE MAPT = '" + txtMaPT.Text.Trim() + "'";
            SqlDataReader data = Program.ExecSqlDataReader(sql);
            bool check = data.Read();
            data.Close();
            return check;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string manv = ((DataRowView)bdsPT[bdsPT.Position])["MANV"].ToString();

            if (bdsPT.Count == 0)
            {
                MessageBox.Show("Không còn gì để ghi");
                return;
            }

            if (manv != Program.manv)
            {
                MessageBox.Show("Không thể ghi phiếu thuê không phải của chính mình lập!");
                return;
            }

            // nếu phiếu thuê đó đã hết hạn và ngày lập phiếu thuê < ngày hiện tại
            // có khả năng phiếu đó chưa hết hạn nhưng ngày lập vẫn bé hơn ngày hiện lại ==> xem như chưa hết hạn
            // VD: lập ngày đêm 27 nhưng qua 28 khách vẫn còn thuê ==> chưa tính là hết hạn
            if (!checkPTChuaHetHan(txtMaPT.Text) && txtNgayLap.DateTime.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Phiếu thuê này đã thuê xong, không thể thao tác!");
                return;
            }

            if (!checkThongTin())
            {
                return;
            }

            if (dangThemMoi)
            {
                if (checkPT())
                {
                    MessageBox.Show("Mã phiếu thuê đã tồn tại!");
                    return;
                }
            }

            if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnThem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
                gcPT.Enabled = gcCTPT.Enabled = true;
                txtMaPT.Enabled = btnHuy.Enabled = btnChonPD.Enabled = btnLayDuLieuPhieuDat.Enabled = false;

                bdsPT.EndEdit();

                this.pHIEUTHUETableAdapter.Connection = Program.conn;
                this.pHIEUTHUETableAdapter.Update(this.DS.PHIEUTHUE);

                dangThemMoi = false;
                MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string manv = ((DataRowView)bdsPT[bdsPT.Position])["MANV"].ToString();

            if (bdsPT.Count == 0)
            {
                MessageBox.Show("Không còn gì để xóa");
                return;
            }

            if (manv != Program.manv)
            {
                MessageBox.Show("Không thể xóa phiếu thuê không phải của chính mình lập!");
                return;
            }

            if (bdsCTPT.Count > 0)
            {
                MessageBox.Show("Phiếu thuê này đã có chi tiết phiếu thuê, không thể xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa phiếu thuê này ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bdsPT.RemoveCurrent();
                pHIEUTHUETableAdapter.Connection = Program.conn;
                pHIEUTHUETableAdapter.Update(DS.PHIEUTHUE);

                gcCTPT.Enabled = true;

                MessageBox.Show("Xóa phiếu thuê thành công!\n", "", MessageBoxButtons.OK);
            }
        }

        private bool checkPTChuaHetHan(string mapt)
        {
            // nếu trong ctpt đó còn 1 phòng nào mà ngày giờ trả phòng > ngày giờ hiện tại thì phiếu thuê đó chưa thuê xong
            String sql = "DECLARE @maxNgayGio smalldatetime " +
                        "SET @maxNgayGio = (SELECT max(NGAYGIODI) FROM CTPHIEUTHUE WHERE MAPT = '" + mapt + "') " +
                        "SELECT * " +
                        "FROM CTPHIEUTHUE WHERE @maxNgayGio > (SELECT CURRENT_TIMESTAMP) AND MAPT = '" + mapt + "'";
            SqlDataReader data = Program.ExecSqlDataReader(sql);
            bool check = data.Read();
            data.Close();
            return check;
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            string manv = ((DataRowView)bdsPD[bdsPD.Position])["MANV"].ToString();

            if (manv != Program.manv)
            {
                MessageBox.Show("Không thể thêm vào chi tiết phiếu thuê không phải của chính mình tạo!");
                return;
            }

            // nếu phiếu thuê đó đã hết hạn và ngày lập phiếu thuê < ngày hiện tại
            // có khả năng phiếu đó chưa hết hạn nhưng ngày lập vẫn bé hơn ngày hiện lại ==> xem như chưa hết hạn
            // VD: lập ngày đêm 27 nhưng qua 28 khách vẫn còn thuê ==> chưa tính là hết hạn
            if (!checkPTChuaHetHan(txtMaPT.Text) && txtNgayLap.DateTime.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Phiếu thuê này đã thuê xong, không thể thao tác!");
                return;
            }

            gcPT.Focus();

            btnChonPhong.Enabled = btnHuyCT.Enabled = true;
            btnChonPhong.Focus();

            vitriCT = bdsCTPT.Position;
            dangThemMoiCT = true;

            gcCTPT.Enabled = btnThemCT.Enabled = btnXoaCT.Enabled = gcPT.Enabled = false;

            bdsCTPT.AddNew();
            ((DataRowView)bdsCTPT[bdsCTPT.Position])["MAPT"] = txtMaPT.Text;
            spnNgayGioDen.EditValue = DateTime.Parse(DateTime.Now.ToString("g"));
            spnNgayGioDi.EditValue = DateTime.Parse(DateTime.Now.ToString("g"));
        }

        private bool checkThongTinCTPT()
        {
            if (txtMaPhong.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn mã phòng");
                return false;
            }

            return true;
        }

        private bool checkTonTaiPhong()
        {
            String sql = "SELECT * FROM CTPHIEUTHUE WHERE MAPT = '" + txtMaPT.Text.Trim() + "' AND MAPHONG = '" + txtMaPhong.Text.Trim() + "'";
            SqlDataReader data = Program.ExecSqlDataReader(sql);
            bool check = data.Read();
            data.Close();
            return check;
        }

        private void btnGhiCT_Click(object sender, EventArgs e)
        {
            string manv = ((DataRowView)bdsPD[bdsPD.Position])["MANV"].ToString();

            if (manv != Program.manv)
            {
                MessageBox.Show("Không thể thêm vào chi tiết phiếu thuê không phải của chính mình tạo!");
                return;
            }

            // nếu phiếu thuê đó đã hết hạn và ngày lập phiếu thuê < ngày hiện tại
            // có khả năng phiếu đó chưa hết hạn nhưng ngày lập vẫn bé hơn ngày hiện lại ==> xem như chưa hết hạn
            // VD: lập ngày đêm 27 nhưng qua 28 khách vẫn còn thuê ==> chưa tính là hết hạn
            if (!checkPTChuaHetHan(txtMaPT.Text) && txtNgayLap.DateTime.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Phiếu thuê này đã thuê xong, không thể thao tác!");
                return;
            }

            if (!checkThongTinCTPT())
            {
                return;
            }

            if (checkPhongDuocLoadTuPhieuDat())
            {
                MessageBox.Show("Phòng này được đã được tạo từ phiếu đặt, không thể thao tác!");
                return;
            }

            if (dangThemMoiCT)
            {
                if (checkTonTaiPhong())
                {
                    MessageBox.Show("Phòng này đã có trong chi tiết phiếu thuê, hãy chọn phòng khác!");
                    return;
                }
            }

            // Lấy tổng thời gian thuê
            TimeSpan ts = ((DateTime)spnNgayGioDi.EditValue).Subtract((DateTime)spnNgayGioDen.EditValue);

            if (ts.Hours < 1)
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
                btnChonPhong.Enabled = btnHuyCT.Enabled = false;
                gcCTPT.Enabled = btnThemCT.Enabled = btnXoaCT.Enabled = gcPT.Enabled = true;

                //Phần này để ghi trạng thái 'Đang thuê' của phòng đó vào bảng chi tiết trạng thái phòng
                if (dangThemMoiCT)
                {
                    try
                    {
                        string sql = "INSERT INTO CT_TRANGTHAIPHONG(MAPHONG, TG_BATDAU, TG_KETTHUC, TRANGTHAI)" +
                                    "VALUES(" +
                                        "'" + txtMaPhong.Text + "', " +
                                        "'" + spnNgayGioDen.EditValue.ToString() + "', " +
                                        "'" + spnNgayGioDi.EditValue.ToString() + "', " +
                                        "N'Đang thuê'" +
                                    ")";
                        Program.ExecSqlNonQuery(sql);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi thêm trạng thái đang thuê " + ex);
                        return;
                    }

                }
                //======================================================================================


                bdsCTPT.EndEdit();
                this.cTPHIEUTHUETableAdapter.Connection = Program.conn;
                this.cTPHIEUTHUETableAdapter.Update(this.DS.CTPHIEUTHUE);

                dangThemMoiCT = false;
                MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnHuyCT_Click(object sender, EventArgs e)
        {
            dangThemMoiCT = false;

            btnChonPhong.Enabled = btnHuyCT.Enabled = false;
            gcCTPT.Enabled = btnThemCT.Enabled = btnXoaCT.Enabled = gcPT.Enabled = true;

            bdsCTPT.CancelEdit();
            this.cTPHIEUTHUETableAdapter.Connection = Program.conn;
            this.cTPHIEUTHUETableAdapter.Fill(this.DS.CTPHIEUTHUE);
        }

        private bool checkPhongDuocLoadTuPhieuDat()
        {
            string mapd = ((DataRowView)bdsPT[bdsPT.Position])["MAPD"].ToString();
            string maphong = ((DataRowView)bdsCTPT[bdsCTPT.Position])["MAPHONG"].ToString();
            string sql = "SELECT * FROM CTPHIEUDAT WHERE MAPD = '" + mapd + "' AND MAPHONG = '" + maphong + "'";

            SqlDataReader data = Program.ExecSqlDataReader(sql);
            bool check = data.Read();
            data.Close();
            return check;
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            string manv = ((DataRowView)bdsPT[bdsPT.Position])["MANV"].ToString();

            if (manv != Program.manv)
            {
                MessageBox.Show("Không thể xóa chi tiết phiếu thuê không phải của chính mình tạo!");
                return;
            }

            // - Nếu phiếu thuê đó đã hết hạn và ngày lập phiếu thuê < ngày hiện tại
            // - Có khả năng phiếu đó chưa hết hạn nhưng ngày lập vẫn bé hơn ngày hiện tại ==> xem như chưa hết hạn
            // VD: Lập ngày đêm 27 nhưng qua 28 khách vẫn còn thuê ==> chưa tính là hết hạn
            if (!checkPTChuaHetHan(txtMaPT.Text) && txtNgayLap.DateTime.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Phiếu thuê này đã thuê xong, không thể thao tác!");
                return;
            }

            if(checkPhongDuocLoadTuPhieuDat())
            {
                MessageBox.Show("Phòng này được đã được tạo từ phiếu đặt, không thể thao tác!");
                return;
            }

            if (bdsCTPT.Count == 0)
            {
                MessageBox.Show("Không có chi tiết phiếu đặt để xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa hạng phòng này khỏi chi tiết phiếu thuê ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                // Xóa phòng này trong chi tiết trạng thái
                try
                {
                    string sql = "DELETE FROM CT_TRANGTHAIPHONG WHERE MAPHONG = '"
                                    + txtMaPhong.Text + "' AND TG_BATDAU = '" + spnNgayGioDen.EditValue.ToString() + "'";
                    Program.ExecSqlNonQuery(sql);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa trạng thái đang thuê " + ex);
                    return;
                }
                //==========================================

                bdsCTPT.RemoveCurrent();
                this.cTPHIEUTHUETableAdapter.Connection = Program.conn;
                this.cTPHIEUTHUETableAdapter.Update(this.DS.CTPHIEUTHUE);

                dangThemMoiCT = false;
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnChonPhong_Click(object sender, EventArgs e)
        {
            Form frm = CheckExists(typeof(frmChonPhong));
            if (frm != null)
                frm.Activate();
            else
            {
                Program.tgBdThue = DateTime.Parse(DateTime.Now.ToString("g"));

                frmChonPhong f = new frmChonPhong();
                f.ShowDialog();

                txtMaPhong.Text = Program.maPhongDaChon;

                txtMaxTgThue.Text = Program.gioThueToiDa + " giờ " + Program.phutThueToiDa + " phút";
            }
        }

        private void spnNgayGioDi_EditValueChanged(object sender, EventArgs e)
        {
            TimeSpan ts = ((DateTime)spnNgayGioDi.EditValue).Subtract((DateTime)spnNgayGioDen.EditValue);

            int hour = ts.Hours;
            int minute = ts.Minutes;

            txtTongThoiGianThue.Text = hour + " giờ " + minute + " phút";
        }

        private void themPhieuDatChoPhieuThue()
        {
            String sql = "UPDATE PHIEUTHUE SET MAPD = '" + txtMaPD.Text + "' WHERE MAPT = '" + txtMaPT.Text + "'";
            Program.ExecSqlNonQuery(sql);
        }
        private void chuyenDoi_CTPT_Sang_CTPT()
        {
            Queue queueInsert = new Queue();

            String sql = "SELECT * FROM CTPHIEUDAT WHERE MAPD = '" + txtMaPD.Text + "'";
            SqlDataReader data = Program.ExecSqlDataReader(sql);

            string maphong, ghichu = " ";
            DateTime ngayGioDi;

            while (data.Read())
            {
                // Lấy thông tin của phòng đó trong CT phiếu đặt
                maphong = data.GetString(1);

                if(!data.IsDBNull(2))
                {
                    ghichu = data.GetString(2);
                }

                ngayGioDi = data.GetDateTime(3);

                string sqlCTPT = "INSERT INTO CTPHIEUTHUE (MAPT, MAPHONG, GHICHU, NGAYGIODEN, NGAYGIODI) " +
                                   "VALUES (" +
                                   "'" + txtMaPT.Text + "', " +
                                   "'" + maphong + "', " +
                                   "N'" + ghichu + "', " +
                                   "'" + this.ngayGioDen.ToString() + "', " +
                                   "'" + ngayGioDi.ToString() + "')";

                queueInsert.Enqueue(sqlCTPT); // đưa lệnh insert chi tiet phieu thue vào queue

                string sqlTrangThai = "INSERT INTO CT_TRANGTHAIPHONG(MAPHONG, TG_BATDAU, TG_KETTHUC, TRANGTHAI)" +
                                    "VALUES(" +
                                        "'" + maphong + "', " +
                                        "'" + this.ngayGioDen.ToString() + "', " +
                                        "'" + ngayGioDi.ToString() + "', " +
                                        "N'Đang thuê')";
                queueInsert.Enqueue(sqlTrangThai); // đưa lệnh insert chi tiet trang thái vào queue
            }
            data.Close();

            // Lấy từng lệnh từ queue ra rồi insert vào DB
            while(queueInsert.Count > 0)
            {
                string lenh = queueInsert.Dequeue().ToString();
                Program.ExecSqlNonQuery(lenh);
            }

            this.cTPHIEUTHUETableAdapter.Connection = Program.conn;
            this.cTPHIEUTHUETableAdapter.Fill(this.DS.CTPHIEUTHUE);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thao tác này sẽ chuyển đổi các phòng đã đặt trước từ CT PHIẾU ĐẶT --> CT PHIẾU THUÊ\n"
                               + "Bạn có muốn chuyển không ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    themPhieuDatChoPhieuThue();

                    chuyenDoi_CTPT_Sang_CTPT();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chuyển đổi từ CTPD -> CTPT \n" + ex);
                    return;
                }

                MessageBox.Show("Chuyển đổi thành công!");
                btnLayDuLieuPhieuDat.Enabled = false;
            }
        }

        private void btnChonDV_Click(object sender, EventArgs e)
        {
            Form frm = CheckExists(typeof(frmChonDichVu));
            if (frm != null)
                frm.Activate();
            else
            {
                frmChonDichVu f = new frmChonDichVu();
                f.ShowDialog();

                txtMaDV.Text = Program.madvDaChon;

            }
        }

        private void btnHuyCTDV_Click(object sender, EventArgs e)
        {
            dangThemMoiCT = false;

            btnChonDV.Enabled = btnHuyCTDV.Enabled = false;
            gcCTDV.Enabled = btnThemCTDV.Enabled = btnXoaCTDV.Enabled = gcPT.Enabled = true;

            bdsCTDV.CancelEdit();
            this.cTDICHVUTableAdapter.Connection = Program.conn;
            this.cTDICHVUTableAdapter.Fill(this.DS.CTDICHVU);
        }

        private void btnThemCTDV_Click(object sender, EventArgs e)
        {
            string manv = ((DataRowView)bdsPD[bdsPD.Position])["MANV"].ToString();

            if (manv != Program.manv)
            {
                MessageBox.Show("Không thể thêm vào chi tiết phiếu thuê không phải của chính mình tạo!");
                return;
            }

            // nếu phiếu thuê đó đã hết hạn và ngày lập phiếu thuê < ngày hiện tại
            // có khả năng phiếu đó chưa hết hạn nhưng ngày lập vẫn bé hơn ngày hiện lại ==> xem như chưa hết hạn
            // VD: lập ngày đêm 27 nhưng qua 28 khách vẫn còn thuê ==> chưa tính là hết hạn
            if (!checkPTChuaHetHan(txtMaPT.Text) && txtNgayLap.DateTime.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Phiếu thuê này đã thuê xong, không thể thao tác!");
                return;
            }

            gcPT.Focus();

            btnChonDV.Enabled = btnHuyCTDV.Enabled = true;
            btnChonDV.Focus();

            vitriCT = bdsCTDV.Position;
            dangThemMoiCT = true;

            gcCTDV.Enabled = btnThemCTDV.Enabled = btnXoaCTDV.Enabled = gcPT.Enabled = false;

            bdsCTDV.AddNew();
            ((DataRowView)bdsCTDV[bdsCTDV.Position])["MAPT"] = txtMaPT.Text;

            spnSoLuong.EditValue = 1;


        }

        private bool checkThongTinCTDV()
        {
            if(txtMaDV.Text == "")
            {
                MessageBox.Show("Chưa chọn mã dịch vụ!");
                return false;
            }

            return true;
        }

        private bool checkTonTaiDichVu()
        {
            string sql = "SELECT * FROM CTDICHVU WHERE MADV = '" + txtMaDV.Text + "' AND MAPT = '" + txtMaPT.Text + "'";
            SqlDataReader data = Program.ExecSqlDataReader(sql);
            bool check = data.Read();
            data.Close();
            return check;
        }

        private void btnGhiCTDV_Click(object sender, EventArgs e)
        {
            string manv = ((DataRowView)bdsPD[bdsPD.Position])["MANV"].ToString();

            if (manv != Program.manv)
            {
                MessageBox.Show("Không thể thêm vào chi tiết phiếu thuê không phải của chính mình tạo!");
                return;
            }

            // nếu phiếu thuê đó đã hết hạn và ngày lập phiếu thuê < ngày hiện tại
            // có khả năng phiếu đó chưa hết hạn nhưng ngày lập vẫn bé hơn ngày hiện lại ==> xem như chưa hết hạn
            // VD: lập ngày đêm 27 nhưng qua 28 khách vẫn còn thuê ==> chưa tính là hết hạn
            if (!checkPTChuaHetHan(txtMaPT.Text) && txtNgayLap.DateTime.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Phiếu thuê này đã thuê xong, không thể thao tác!");
                return;
            }

            if (!checkThongTinCTDV())
            {
                return;
            }

            if (dangThemMoiCT)
            {
                if (checkTonTaiDichVu())
                {
                    MessageBox.Show("Dịch vụ này đã có trong chi tiết dịch vụ, hãy chọn dịch vụ khác!");
                    return;
                }
            }

            if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnChonDV.Enabled = btnHuyCTDV.Enabled = false;
                gcCTDV.Enabled = btnThemCTDV.Enabled = btnXoaCTDV.Enabled = gcPT.Enabled = true;

                bdsCTDV.EndEdit();
                this.cTDICHVUTableAdapter.Connection = Program.conn;
                this.cTDICHVUTableAdapter.Update(this.DS.CTDICHVU);

                dangThemMoiCT = false;
                MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoaCTDV_Click(object sender, EventArgs e)
        {
            string manv = ((DataRowView)bdsPT[bdsPT.Position])["MANV"].ToString();

            if (manv != Program.manv)
            {
                MessageBox.Show("Không thể xóa chi tiết phiếu thuê không phải của chính mình tạo!");
                return;
            }

            // - Nếu phiếu thuê đó đã hết hạn và ngày lập phiếu thuê < ngày hiện tại
            // - Có khả năng phiếu đó chưa hết hạn nhưng ngày lập vẫn bé hơn ngày hiện tại ==> xem như chưa hết hạn
            // VD: Lập ngày đêm 27 nhưng qua 28 khách vẫn còn thuê ==> chưa tính là hết hạn
            if (!checkPTChuaHetHan(txtMaPT.Text) && txtNgayLap.DateTime.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Phiếu thuê này đã thuê xong, không thể thao tác!");
                return;
            }

            if (bdsCTDV.Count == 0)
            {
                MessageBox.Show("Không có chi tiết dịch vụ để xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa dịch vụ này khỏi chi tiết dịch vụ ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                bdsCTDV.RemoveCurrent();
                this.cTDICHVUTableAdapter.Connection = Program.conn;
                this.cTDICHVUTableAdapter.Update(this.DS.CTDICHVU);

                dangThemMoiCT = false;
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
