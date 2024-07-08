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
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;

        public frmMain(string username, string author)
        {
            InitializeComponent();
            tslbUsername.Text = "ຊື່ຜູ້ໃຊ້ລະບົບ: "+username;
            if (author == "ພະນັກງານຂາຍ")
            {
                ຈດການຂມນປະເພດສນຄາToolStripMenuItem.Enabled = false;
                ກວດສອບແລະສງຊສນຄາToolStripMenuItem.Enabled = false;
                //ນຳເຂາສນຄາToolStripMenuItem.Enabled = false;
                ຂາຍສນຄາToolStripMenuItem.Enabled = true;

            }
            else if (author == "ພະນັກງານຈັດຊື້")
            {
                ຈດການຂມນປະເພດສນຄາToolStripMenuItem.Enabled = true;
                ກວດສອບແລະສງຊສນຄາToolStripMenuItem.Enabled = true;
                //ນຳເຂາສນຄາToolStripMenuItem.Enabled = true;
                ຂາຍສນຄາToolStripMenuItem.Enabled = false;

            }
            else if (author == "ຜູ້ດູແລລະບົບ")
            {
                ຈດການຂມນປະເພດສນຄາToolStripMenuItem.Enabled = true;
                ກວດສອບແລະສງຊສນຄາToolStripMenuItem.Enabled = true;
                //ນຳເຂາສນຄາToolStripMenuItem.Enabled = true;
                ຂາຍສນຄາToolStripMenuItem.Enabled = true;

            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ຈດການຂມນປະເພດສນຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ຈດການຂມນປະເພດສນຄາToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           /* Category frmC = new Category();
            frmC.MdiParent = this;
            frmC.Show();*/
           this.panelSubMain.Controls.Clear();
            Category frmCat_vrb = new Category() { Dock = DockStyle.Fill,TopLevel=false,TopMost=true};
            frmCat_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelSubMain.Controls.Add(frmCat_vrb);
            frmCat_vrb.Show();

        }

        private void ຈດການຂມນຫວໜວຍToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Unit frmU = new Unit();
             frmU.MdiParent = this;
             frmU.Show();*/
            this.panelSubMain.Controls.Clear();
            Unit frmU_vrb = new Unit() { Dock = DockStyle.Fill,TopLevel=false,TopMost=true };
            frmU_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelSubMain.Controls.Add((frmU_vrb));
            frmU_vrb.Show();

        }

        private void ຈດການຂມນສນຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmProduct frmP = new frmProduct();
             * 
            frmP.MdiParent = this;
            frmP.Show();*/
            this.panelSubMain.Controls.Clear();
            frmProduct frmP_vrb = new frmProduct() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmP_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelSubMain.Controls.Add(frmP_vrb);
            frmP_vrb.Show();

        }

        private void ຂາຍສນຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* frmSell frmS = new frmSell();
             frmS.MdiParent = this;
             frmS.Show();*/
            frmSell frmS_vrb = new frmSell() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmS_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelSubMain.Controls.Clear();
            this.panelSubMain.Controls.Add(frmS_vrb);
            frmS_vrb.Show();
            
        }

        private void ອອກຈາກລະບບToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmLogin fln = new frmLogin();
            fln.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void ຈດການຂມນຜສະໜອງToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmSupplier fs = new frmSupplier();
            fs.MdiParent = this;
            fs.Show();*/
            this.panelSubMain.Controls.Clear();
            frmSupplier frmSP_vrb = new frmSupplier() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSP_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelSubMain.Controls.Add(frmSP_vrb);
            frmSP_vrb.Show();
        }

        private void ຈດການຂມນຜໃຊToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmEmployee fey = new frmEmployee();
            fey.MdiParent = this;
            fey.Show();*/
            frmEmployee frmEP_vrb = new frmEmployee() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelSubMain.Controls.Clear();
            frmEP_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelSubMain.Controls.Add(frmEP_vrb);
            frmEP_vrb.Show();
        }

        private void ນຳເຂາສນຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ກວດສອບແລະສງຊສນຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmImport fip = new frmImport();
            fip.MdiParent = this;
            fip.Show();*/
            this.panelSubMain.Controls.Clear();
            frmImport frmIMP_vrb = new frmImport() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmIMP_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelSubMain.Controls.Add(frmIMP_vrb);
            frmIMP_vrb.Show();

        }

        private void ລາຍງານການຂາຍToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRptSell frs = new frmRptSell();
            frs.MdiParent = this;
            frs.Show();
        }

        private void ລາຍງານສນຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* frmRptProduct frp = new frmRptProduct();
            frp.MdiParent = this;
            frp.Show();*/
           frmRptProduct frm = new frmRptProduct() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; 
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panelSubMain.Controls.Clear();
            this.panelSubMain.Controls.Add(frm);
            frm.Show();
           
        }

        private void ລາຍງານການສງຊToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmRptImport fri = new frmRptImport();
            fri.MdiParent = this;
            fri.Show();*/
            frmRptImport frm = new frmRptImport() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panelSubMain.Controls.Clear();
            this.panelSubMain.Controls.Add(frm);
            frm.Show();
        }

        private void ລາຍງານການຂາຍຕາມມToolStripMenuItem_Click(object sender, EventArgs e)
        {
          /*  frmRptByDate frd = new frmRptByDate();
            frd.MdiParent = this;
            frd.Show();*/
          frmRptByDate report = new frmRptByDate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            report.FormBorderStyle = FormBorderStyle.None;
            this.panelSubMain.Controls.Clear();
            this.panelSubMain.Controls.Add(report);
            report.Show();
        }

        private void ລາຍງານສນຄາຂາຍດToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmRptBestSell frbs = new frmRptBestSell();
            frbs.MdiParent = this;
            frbs.Show();*/
            frmRptBestSell report = new frmRptBestSell() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            report.FormBorderStyle = FormBorderStyle.None;
            this.panelSubMain.Controls.Clear();
            this.panelSubMain.Controls.Add(report);
            report.Show();
        }

        private void ລາຍງານToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ລາຍງານການນຳເຂາສນຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
