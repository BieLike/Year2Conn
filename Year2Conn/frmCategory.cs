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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        String strcon = "data source = DESKTOP-7TT19G3\\SQLEXPRESS; initial catalog = HW1; integrated security = true";
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into tbCategory values(@CID,@Category)", conn);
            cmd.Parameters.AddWithValue("@CID", txtCID.Text);
            cmd.Parameters.AddWithValue("@Category", txtCategory.Text);

            cmd.ExecuteNonQuery();
            Showdata();
            Clear();
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            ds.Clear();
            conn.ConnectionString = strcon;
            conn.Open();
            Showdata();
            Clear();

        }
        void Showdata()
        {
            ds.Clear();
            da = new SqlDataAdapter("Select * from tbCategory",conn);
            da.Fill(ds);
            DGV.DataSource = ds.Tables[0];
            DGV.Refresh();
            DGV.Columns[0].Width = 155;
            DGV.Columns[1].Width = 155;
            DGV.Columns[0].HeaderText = "ລະຫັດ";
            DGV.Columns[1].HeaderText = "ປະເພດ";
        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Update tbCategory set CategoryName=@Category where CategoryID=@CID", conn);
            cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
            cmd.Parameters.AddWithValue("@CID", txtCID.Text);

            cmd.ExecuteNonQuery();
            Showdata();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Delete from tbCategory where CategoryID = @CID", conn);
            cmd.Parameters.AddWithValue("@CID", txtCID.Text);

            cmd.ExecuteNonQuery();
            Showdata();
            Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCID.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString();
            txtCategory.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void Clear()
        {
            txtCategory.Clear();
            txtCID.Clear();
            txtCID.Focus();
        }

        private void Category_Load(object sender, EventArgs e)
        {

        }
    }
}
