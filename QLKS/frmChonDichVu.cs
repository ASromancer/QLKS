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
    public partial class frmChonDichVu : Form
    {
        public frmChonDichVu()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void dICHVUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmChonDichVu_Load(object sender, EventArgs e)
        {

            this.dICHVUTableAdapter.Connection = Program.conn;
            this.dICHVUTableAdapter.Fill(this.DS.DICHVU);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            string madv = ((DataRowView)bdsDV[bdsDV.Position])["MADV"].ToString();
            Program.madvDaChon = madv;
            this.Dispose();
        }
    }
}
