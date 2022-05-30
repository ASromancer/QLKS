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
    public partial class frmChonPhong : Form
    {
        public frmChonPhong()
        {
            InitializeComponent();
            this.CenterToScreen();
            txtBD.EditValue = Program.tgBdThue;
            txtKT.EditValue = Program.tgBdThue;
        }

        private void locPhongTheoTgian()
        {
            Program.Ketnoi();
            string sql = "DECLARE @START smalldatetime = '"+ txtBD.EditValue + "', " +
                          "@END smalldatetime = '" + txtKT.EditValue + "'" +
                           "SELECT p.*, MOTA_HANGPHONG = kp.TENKIEUPHONG + ' ' + lp.TENLOAIPHONG, " +
                            "TRANGTHAI = ISNULL(ct.TRANGTHAI, N'Trống') " +
                            "FROM PHONG p LEFT JOIN CT_TRANGTHAIPHONG ct ON p.MAPHONG = ct.MAPHONG " +
                            "AND((TG_BATDAU BETWEEN @START AND @END) " +
                             "OR(TG_BATDAU <= @START AND @END <= TG_KETTHUC) " +
                              "OR(TG_KETTHUC BETWEEN @START AND @END) ) " +
                                ", HANGPHONG hp, KIEUPHONG kp, LOAIPHONG lp " +
                                "WHERE hp.MAHP = p.MAHP AND hp.MAKP = kp.MAKP AND hp.MALP = lp.MALP";
            SqlCommand cmd = new SqlCommand(sql, Program.conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Program.conn.Close();
            gvChonPhong.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {

            if( DateTime.Compare((DateTime)txtBD.EditValue, (DateTime)txtKT.EditValue) >= 0 )  
            {
                MessageBox.Show("Thời gian bắt đầu không vượt quá thời gian kết thúc!");
                return;
            }

            TimeSpan ts = ((DateTime)txtKT.EditValue).Subtract((DateTime)txtBD.EditValue);

            int hour = ts.Hours, minute = ts.Minutes;

            txtMaxHour.Text = hour + "giờ " + minute + " phút";

            if (ts.Hours == 0)
            {
                MessageBox.Show("Thuê ít nhất 1 tiếng!");
                return;
            }

            locPhongTheoTgian();

            Program.tongTgianThueToiDa = ts.TotalHours;
            Program.gioThueToiDa = hour;
            Program.phutThueToiDa = minute;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(gvChonPhong.SelectedCells.Count > 0)
            {
                int index = gvChonPhong.SelectedCells[0].RowIndex;
                DataGridViewRow row = gvChonPhong.Rows[index];

                // Chọn phòng không trống thì báo lỗi
                if(!row.Cells["TRANGTHAI"].Value.ToString().Equals("Trống"))
                {
                    MessageBox.Show("Phòng này đã được đặt trước hoặc đang thuê, không thể chọn!");
                    return;
                }

                Program.maPhongDaChon = row.Cells["MAPHONG"].Value.ToString();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu để chọn, hãy lọc dữ liệu");
            }
        }
    }
}
