using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLKS
{
    static class Program
    {

        public static SqlConnection conn = new SqlConnection();
        public static String connstr_publisher = "Data Source=ASROMANCER;Initial Catalog=QLKS;Integrated Security=true;User ID=sa;Password=123";
        public static frmMain frmChinh;

        public static string manv = "";
        public static string maPhongDaChon = ""; // đặt trước
        public static string mapdDaChon = ""; // lập PT cho PD
        public static string madvDaChon = "";
        public static string maptDaChon = "";

        public static DateTime tgBdThueCuaPD; // dùng trong việc gán thời gian đến thuê khi chuyển từ CTPD -> CTPT
        public static DateTime tgBdThue; // dùng để gán vào thời gian bắt đầu trong form frmChonPhong

        public static double tongTgianThueToiDa = 0d; // tong tgian thuê theo kiểu thập phân vd :5,063 giờ
        public static int gioThueToiDa = 0;
        public static int phutThueToiDa = 0;

        public static int Ketnoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                Program.conn.ConnectionString = Program.connstr_publisher;
                Program.conn.Open();
                return 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối cở sở dữ liệu.\nXem lại tài khoản và mật khẩu.\n " + ex.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        //Thực hiện mà data trả vể chỉ để xem
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        // Thực thi SP mà không trả về giá trị
        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand sqlcmd = new SqlCommand(strlenh, conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;// 10 phut
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State;

            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }
    }
}
