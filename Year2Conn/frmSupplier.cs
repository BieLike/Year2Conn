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

namespace Year2Conn
{
    public partial class frmSupplier : Form
    {
        Connct cnn = new Connct();
        public frmSupplier()
        {
            InitializeComponent();
        }
        void ShowData()
        {

            cnn.Check();
            cnn.da = new SqlDataAdapter("select * from supplier ", cnn.conn);
            cnn.ds.Clear();
            cnn.da.Fill(cnn.ds);
            dgvEmp.DataSource = cnn.ds.Tables[0];
            dgvEmp.Refresh();
            dgvEmp.Columns[0].HeaderText = "ລະຫັດຜູ້ໃຊ້";
            dgvEmp.Columns[1].HeaderText = "ຊື່ຜູ້ໃຊ້";
            dgvEmp.Columns[2].HeaderText = "ເບີໂທ";
            dgvEmp.Columns[3].HeaderText = "ທີ່ຢູ່";
            dgvEmp.Columns[0].Width = 50;
            dgvEmp.Columns[1].Width = 200;
            dgvEmp.Columns[2].Width = 180;
            dgvEmp.Columns[3].Width = 180;
        }

        void clear()
        {
            txtFname.Text = "";
            txtPass.Text = "";
            txtPhone.Text = "";
            txtAddr.Text = "";
        }
        private void frmSupplier_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cnn.cmd = new SqlCommand("insert into supplier values(@ID, @userN, @P, @Addr)", cnn.conn);
            cnn.cmd.Parameters.AddWithValue("@ID", txtPass.Text);
            cnn.cmd.Parameters.AddWithValue("@userN", txtFname.Text);
            cnn.cmd.Parameters.AddWithValue("@P", txtPhone.Text);
            cnn.cmd.Parameters.AddWithValue("@Addr", txtAddr.Text);
            cnn.cmd.ExecuteNonQuery();
            dgvEmp.Refresh();
            ShowData();
            clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cnn.cmd = new SqlCommand("update supplier set Phone=@P, SuplierName=@userN ,Address=@Addr where SupplierID=@ID ", cnn.conn);
            cnn.cmd.Parameters.AddWithValue("@ID", txtPass.Text);
            cnn.cmd.Parameters.AddWithValue("@userN", txtFname.Text);
            cnn.cmd.Parameters.AddWithValue("@P", txtPhone.Text);
            cnn.cmd.Parameters.AddWithValue("@Addr", txtAddr.Text);
            cnn.cmd.ExecuteNonQuery();
            dgvEmp.Refresh();
            ShowData();
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cnn.cmd = new SqlCommand("delete from supplier where SupplierID=@ID ", cnn.conn);
            cnn.cmd.Parameters.AddWithValue("@ID", txtPass.Text);
            cnn.cmd.ExecuteNonQuery();
            dgvEmp.Refresh();
            ShowData();
            clear();
        }

        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtFname.Text = dgvEmp.Rows[dgvEmp.CurrentRow.Index].Cells[1].Value.ToString();
            txtPass.Text = dgvEmp.Rows[dgvEmp.CurrentRow.Index].Cells[0].Value.ToString();
            txtPhone.Text = dgvEmp.Rows[dgvEmp.CurrentRow.Index].Cells[2].Value.ToString();
            txtAddr.Text = dgvEmp.Rows[dgvEmp.CurrentRow.Index].Cells[3].Value.ToString();
        }
    }
}
