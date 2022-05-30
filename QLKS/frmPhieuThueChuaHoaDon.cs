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
    public partial class frmPhieuThueChuaHoaDon : Form
    {
        public frmPhieuThueChuaHoaDon()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void pHIEUTHUE_CHUA_HOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPTHD.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmPhieuThueChuaHoaDon_Load(object sender, EventArgs e)
        {
            this.pHIEUTHUE_CHUA_HOADONTableAdapter.Connection = Program.conn;
            this.pHIEUTHUE_CHUA_HOADONTableAdapter.Fill(this.DS.PHIEUTHUE_CHUA_HOADON);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int index = bdsPTHD.Position;
            if (index == -1)
            {
                MessageBox.Show("Không có phiếu thuê nào chưa có hóa đơn");
                return;
            }

            string mapt = ((DataRowView)bdsPTHD[bdsPTHD.Position])["MAPT"].ToString();

            Program.maptDaChon = mapt;
            this.Dispose();
        }
    }
}
