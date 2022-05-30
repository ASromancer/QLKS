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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // điền sẵn test cho nhanh
            txtUserName.Text = "nv001";
            txtPass.Text = "1234";

            this.CenterToScreen();
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            string tk = txtUserName.Text.Trim();
            string mk = txtPass.Text.Trim();

            if(Program.Ketnoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối đến database, vui lòng kiểm tra lại!");
            } 

            string sql = "SELECT MANV, HO + ' ' + TEN, TENBP " +
                "FROM NHANVIEN nv, BOPHAN b WHERE MANV = '" + tk +"' AND MATKHAU = '" + mk +"' AND nv.MABP = b.MABP";
            SqlDataReader data = Program.ExecSqlDataReader(sql);
            if(data.Read()) // có tồn tại record của nhân viên đó
            {
                Program.frmChinh.MANV.Text = "Mã NV: " + data.GetString(0);
                Program.frmChinh.HOTEN.Text = "Họ tên: " + data.GetString(1);
                Program.frmChinh.VAITRO.Text = "Vai trò: " + data.GetString(2);

                Program.manv = data.GetString(0); // lưu lại mã nhân viên để sử dụng cho PD, PT

                Program.frmChinh.enableButtons();
                data.Close();
                this.Close();
            } else
            {
                MessageBox.Show("Đăng nhập không thành công, vui lòng kiểm tra lại thông tin đăng nhập!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
