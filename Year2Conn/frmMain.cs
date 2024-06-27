﻿using System;
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
                ນຳເຂາສນຄາToolStripMenuItem.Enabled = false;
                ຂາຍສນຄາToolStripMenuItem.Enabled = true;

            }
            else if (author == "ພະນັກງານຈັດຊື້")
            {
                ຈດການຂມນປະເພດສນຄາToolStripMenuItem.Enabled = true;
                ກວດສອບແລະສງຊສນຄາToolStripMenuItem.Enabled = true;
                ນຳເຂາສນຄາToolStripMenuItem.Enabled = true;
                ຂາຍສນຄາToolStripMenuItem.Enabled = false;

            }
            else if (author == "ຜູ້ດູແລລະບົບ")
            {
                ຈດການຂມນປະເພດສນຄາToolStripMenuItem.Enabled = true;
                ກວດສອບແລະສງຊສນຄາToolStripMenuItem.Enabled = true;
                ນຳເຂາສນຄາToolStripMenuItem.Enabled = true;
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
            Category frmC = new Category();
            frmC.MdiParent = this;
            frmC.Show();

        }

        private void ຈດການຂມນຫວໜວຍToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unit frmU = new Unit();
            frmU.MdiParent = this;
            frmU.Show();

        }

        private void ຈດການຂມນສນຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct frmP = new frmProduct();
            frmP.MdiParent = this;
            frmP.Show();

        }

        private void ຂາຍສນຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSell frmS = new frmSell();
            frmS.MdiParent = this;
            frmS.Show();
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
    }
}
