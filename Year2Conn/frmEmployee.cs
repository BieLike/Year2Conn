using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Year2Conn
{
    public partial class frmEmployee : Form
    {

        Connct cnn = new Connct();
        public frmEmployee()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            cnn.cmd = new SqlCommand("insert into tbUser values(@userN, @userPass, @author)",cnn.conn);
            cnn.cmd.Parameters.AddWithValue("@userN", txtFname.Text);
            cnn.cmd.Parameters.AddWithValue("@userPass", txtPass.Text);
            cnn.cmd.Parameters.AddWithValue("@author", cmbAuthor.Text);
            cnn.cmd.ExecuteNonQuery();
            dgvEmp.Refresh();
            ShowData();
            clear();

        }

        void ShowData()
        {
            
            cnn.Check();
            cnn.da = new SqlDataAdapter("select * from tbUser Where author not like N'ຜູ້ດູແລລະບົບ' ", cnn.conn);
            cnn.ds.Clear();
            cnn.da.Fill(cnn.ds);
            dgvEmp.DataSource = cnn.ds.Tables[0];
            dgvEmp.Refresh();
            dgvEmp.Columns[0].HeaderText = "ຊື່ຜູ້ໃຊ້";
            dgvEmp.Columns[1].HeaderText = "ລະຫັດຜູ້ໃຊ້";
            dgvEmp.Columns[2].HeaderText = "ໜ້າທີ່່ຜູ້ໃຊ້";
            dgvEmp.Columns[0].Width = 200;
            dgvEmp.Columns[1].Width = 200;
            dgvEmp.Columns[2].Width = 180;
        }

        void clear()
        {
            txtFname.Text = "";
            txtPass.Text = "";
            cmbAuthor.Text = "";
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            ShowData();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cnn.cmd = new SqlCommand("update tbUser set userPassword=@userPass, Author=@author where userName=@userN ", cnn.conn);
            cnn.cmd.Parameters.AddWithValue("@userN", txtFname.Text);
            cnn.cmd.Parameters.AddWithValue("@userPass", txtPass.Text);
            cnn.cmd.Parameters.AddWithValue("@author", cmbAuthor.Text);
            cnn.cmd.ExecuteNonQuery();
            dgvEmp.Refresh();
            ShowData();
            clear();
        }

        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFname.Text = dgvEmp.Rows[dgvEmp.CurrentRow.Index].Cells[0].Value.ToString();
            txtPass.Text = dgvEmp.Rows[dgvEmp.CurrentRow.Index].Cells[1].Value.ToString();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cnn.cmd = new SqlCommand("delete from tbUser where userName=@userN ", cnn.conn);
            cnn.cmd.Parameters.AddWithValue("@userN", txtFname.Text);
            cnn.cmd.ExecuteNonQuery();
            dgvEmp.Refresh();
            ShowData();
            clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
