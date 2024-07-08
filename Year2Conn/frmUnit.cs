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
using System.Runtime.InteropServices;

namespace Year2Conn
{
    public partial class Unit : Form
    {


        public Unit()
        {
            InitializeComponent();

        }

        //Strcon,conn,da,ds,cmd;

        String strcon = "data source = DESKTOP-TSHJDI9\\SQLEXPRESS; initial catalog = HW1; integrated security = true";
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Update tbUnit set UnitName=@Unit where UnitID=@UID",conn);
            cmd.Parameters.AddWithValue("@Unit",txtUnit.Text);
            cmd.Parameters.AddWithValue("@UID",txtUnitID.Text);

            cmd.ExecuteNonQuery();
            ShowData();
            Clear();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into tbUnit values(@UID,@Unit)",conn);
            cmd.Parameters.AddWithValue("@UID", txtUnitID.Text);
            cmd.Parameters.AddWithValue("@Unit", txtUnit.Text);

            cmd.ExecuteNonQuery();
            ShowData();
            Clear();

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            

        }
        void ShowData()
        {
            ds.Clear();
            da = new SqlDataAdapter("Select * from tbUnit",conn);
            da.Fill(ds);
            DGV.DataSource = ds.Tables[0];
            DGV.Refresh();
            DGV.Columns[0].Width = 155;
            DGV.Columns[1].Width = 155;
            DGV.Columns[0].HeaderText = "ລະຫັດ";
            DGV.Columns[1].HeaderText = "ຫົວໜ່ວຍ";
        }

        private void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtUnitID.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString();
            txtUnit.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Delete from tbUnit where UnitID = @UID",conn);
            cmd.Parameters.AddWithValue("@UID",txtUnitID.Text);

            cmd.ExecuteNonQuery();
            ShowData();
            Clear();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void Clear()
        {
            txtUnitID.Clear();
            txtUnit.Clear();
            txtUnitID.Focus();
        }

        private void Unit_Load(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            ds.Clear();
            conn.ConnectionString = strcon;
            conn.Open();
            ShowData();
            Clear();
        }
    }
}
