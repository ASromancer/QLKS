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
    public partial class frmHoaDon : Form
    {
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

        private void btnChonPT_Click(object sender, EventArgs e)
        {

        }
    }
}
