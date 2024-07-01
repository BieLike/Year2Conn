using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Year2Conn
{
    public partial class frmRptByDate : Form
    {
        public frmRptByDate()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmRptData frm = new frmRptData(dtpFdate.Text, dtpLdate.Text);
            frm.Show();
        }
    }
}
