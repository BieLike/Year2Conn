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
using System.Diagnostics;
using System.Data.Common;

namespace Year2Conn
{
    public partial class frmProduct : Form
    {

        Connct cntn = new Connct();
        public frmProduct()
        {
            InitializeComponent();
        }

        /*String strcon = "data source = DESKTOP-7TT19G3\\SQLEXPRESS; initial catalog = HW1; integrated security= true";
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();*/

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            cntn.ds.Clear();
            cntn.da = new SqlDataAdapter("Select tbProduct.ProductID, tbProduct.Product, tbProduct.Price, tbProduct.Quantity, tbCategory.CategoryName, tbUnit.UnitName, tbProduct.ConditionCheck  from tbProduct inner join tbCategory on tbProduct.CategoryID = tbCategory.CategoryID inner join tbUnit on tbProduct.UnitID=tbUnit.UnitID where tbProduct.ProductID like N'"+txtCatN.Text+"' or tbProduct.Product like N'%"+txtCatN.Text+"%' or tbCategory.CategoryName like N'%"+txtCatN.Text+"%'  or tbUnit.UnitName like N'%"+txtCatN.Text+"%'  ", cntn.conn);
            cntn.da.Fill(cntn.ds);
            DGV.DataSource = cntn.ds.Tables[0];
            DGV.Refresh();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        
        private void frmProduct_Load(object sender, EventArgs e)
        {
            cntn.Check();

            SqlDataAdapter daU = new SqlDataAdapter("Select * from tbUnit",cntn.conn);
            DataSet dsU = new DataSet();
            //daU.Fill(dsU, "UnitName");
            dsU.Clear();
            daU.Fill(dsU,"Unit");
            cmbUnit.DataSource = dsU.Tables[0];
            cmbUnit.DisplayMember = "UnitName";
            cmbUnit.ValueMember = "UnitID";
            SqlDataAdapter daC = new SqlDataAdapter("Select * from tbCategory",cntn.conn);
            DataSet dsC = new DataSet();
            daC.Fill(dsC);
            cmbCat.DataSource = dsC.Tables[0];
            cmbCat.DisplayMember = "CategoryName";
            cmbCat.ValueMember = "CategoryID";


            ShowData();
        }

        void ShowData()
        {
            cntn.ds.Clear();
            cntn.da = new SqlDataAdapter("Select tbProduct.ProductID, tbProduct.Product, tbProduct.Price, tbProduct.Quantity, tbCategory.CategoryName, tbUnit.UnitName, tbProduct.ConditionCheck  from tbProduct inner join tbCategory on tbProduct.CategoryID = tbCategory.CategoryID inner join tbUnit on tbProduct.UnitID=tbUnit.UnitID", cntn.conn);
            cntn.da.Fill(cntn.ds);
            DGV.DataSource = cntn.ds.Tables[0];
            DGV.Refresh();
            DGV.Columns[0].Width = 140;
            DGV.Columns[1].Width = 140;
            DGV.Columns[2].Width = 140;
            DGV.Columns[3].Width = 140;
            DGV.Columns[4].Width = 140;
            DGV.Columns[5].Width = 140;
            DGV.Columns[6].Width = 140;
            DGV.Columns[0].HeaderText = "ລະຫັດສິນຄ້າ";
            DGV.Columns[1].HeaderText = "ຊື່ສິນຄ້າ";
            DGV.Columns[2].HeaderText = "ລາຄາ";
            DGV.Columns[3].HeaderText = "ຈຳນວນ";
            DGV.Columns[4].HeaderText = "ປະເພດ";
            DGV.Columns[5].HeaderText = "ຫົວໜ່ວຍ";
            DGV.Columns[6].HeaderText = "ເງື່ອນໄຂການຊື້";

        }

        void Clear()
        {
            txtProduct.Clear();
            txtProductID.Clear();
            txtCondition.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            cmbCat.SelectedIndex = 0;
            cmbUnit.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cntn.cmd = new SqlCommand("insert into tbProduct values(@ID, @Product, @Price, @Qty, @Category, @Unit, @Condition)", cntn.conn);
            cntn.cmd.Parameters.AddWithValue("@ID",txtProductID.Text);
            cntn.cmd.Parameters.AddWithValue("@Product", txtProduct.Text);
            cntn.cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
            cntn.cmd.Parameters.AddWithValue("@Qty", txtQty.Text);
            cntn.cmd.Parameters.AddWithValue("@Category", cmbCat.SelectedValue);
            cntn.cmd.Parameters.AddWithValue("@Unit", cmbUnit.SelectedValue);
            cntn.cmd.Parameters.AddWithValue("@Condition", txtCondition.Text);

            cntn.cmd.ExecuteNonQuery();
            ShowData();
            Clear();

        }

        private void frmProduct_Activated(object sender, EventArgs e)
        {
        }

        private void DGV_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbCat.Text = "";
            cmbUnit.Text = "";
            txtProductID.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString();
            txtProduct.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[1].Value.ToString();
            txtPrice.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[2].Value.ToString();
            txtQty.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[3].Value.ToString();
            txtCondition.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[6].Value.ToString();
            cmbCat.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[4].Value.ToString();
            cmbUnit.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[5].Value.ToString();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cntn.cmd = new SqlCommand("Update tbProduct set Product = @Product, Price = @Price, Quantity = @Qty, CategoryID = @Category, UnitID = @Unit, ConditionCheck = @Condition where ProductID = @ID",cntn.conn);
            cntn.cmd.Parameters.AddWithValue("@Product", txtProduct.Text);
            cntn.cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
            cntn.cmd.Parameters.AddWithValue("@Qty", txtQty.Text);
            cntn.cmd.Parameters.AddWithValue("@Category", cmbCat.SelectedValue);
            cntn.cmd.Parameters.AddWithValue("@Unit", cmbUnit.SelectedValue);
            cntn.cmd.Parameters.AddWithValue("@Condition", txtCondition.Text);
            cntn.cmd.Parameters.AddWithValue("@ID", txtProductID.Text);

            cntn.cmd.ExecuteNonQuery();
            ShowData();
            Clear();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cntn.cmd = new SqlCommand("delete tbProduct where ProductID = @ID", cntn.conn);
            cntn.cmd.Parameters.AddWithValue("@ID", txtProductID.Text);

            cntn.cmd.ExecuteNonQuery();
            ShowData();
            Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
