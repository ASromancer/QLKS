using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class frmPDKhongPT : Form
    {
        public frmPDKhongPT()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void dS_PD_CHUACO_PTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPD.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmPDKhongPT_Load(object sender, EventArgs e)
        {
            this.dS_PD_CHUACO_PTTableAdapter.Connection = Program.conn;
            this.dS_PD_CHUACO_PTTableAdapter.Fill(this.dS.DS_PD_CHUACO_PT);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = bdsPD.Position;
            if(index == -1)
            {
                MessageBox.Show("Không có phiếu đặt nào chưa có phiếu thuê");
                return;
            }

            string mapd = ((DataRowView)bdsPD[bdsPD.Position])["MAPD"].ToString();
            DateTime startTime = DateTime.Parse( ((DataRowView)bdsPD[bdsPD.Position])["NGAYBATDAUTHUE"].ToString() );

            Program.mapdDaChon = mapd;
            Program.tgBdThueCuaPD = startTime;
            this.Dispose();
        }
    }
}
