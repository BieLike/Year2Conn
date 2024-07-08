using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Year2Conn
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        Connct cnt = new Connct();
        String username, author;
        private void button1_Click(object sender, EventArgs e)
        {
            cnt.Check();
            SqlDataReader dr;
            DataTable dt = new DataTable();
            cnt.cmd = new SqlCommand("Select * from tbUser where userName = @username and userPassword = @password",cnt.conn);
            cnt.cmd.Parameters.AddWithValue("@username", txtName.Text);
            cnt.cmd.Parameters.AddWithValue("@password", mtxtPassword.Text);
            dr = cnt.cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dt.Load(dr);
                username = txtName.Text;
                author = dt.Rows[0].ItemArray[2].ToString();
                frmMain frm = new frmMain(username, author);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ຊື່ແລະລະຫັດບໍ່ຖືກຕ້ອງ","ຜົນການຄົ້ນຫາ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            mtxtPassword.UseSystemPasswordChar = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
