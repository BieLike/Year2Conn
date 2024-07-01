using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Year2Conn
{
    public partial class frmImport : Form
    {
        public frmImport()
        {
            InitializeComponent();
        }

        Connct cnt = new Connct();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string productID = "", productName, price, unitName;
        DataTable dt = new DataTable();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //SamePD
            int rc = dgvImport.RowCount;
            int i, sm = 0;

            if (rc == 1)
            {
                if (productID == "")
                {
                    MessageBox.Show("Please Select Product");
                }
                else
                {
                    dt.Rows.Add(productID, productName, price, "", unitName, "");
                    dgvImport.DataSource = dt;
                }

            }
            else
            {
                for (i = 1; i < rc; i++)
                {
                    if (productID == dgvImport.Rows[i-1].Cells[0].Value.ToString())
                    {
                        sm = 1;
                    }
                }
                if (sm == 1)
                {
                    MessageBox.Show("Item already in the cart");
                }
                else
                {
                    dt.Rows.Add(productID, productName, price, "", unitName, "");
                    dgvImport.DataSource = dt;

                }
            }

            sm = 0;
            dgvImport.Refresh();

        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productID = dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[0].Value.ToString();
            productName = dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[1].Value.ToString();
            price = dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[2].Value.ToString();
            unitName = dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[4].Value.ToString();

        }

        private void dgvProduct_Click(object sender, EventArgs e)
        {
        }

        private void dgvProduct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvImport_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            string Qty, Total;
            price = dgvImport.Rows[dgvImport.CurrentRow.Index].Cells[2].Value.ToString();
            Qty = dgvImport.Rows[dgvImport.CurrentRow.Index].Cells[3].Value.ToString();
            Total = (int.Parse(price) * int.Parse(Qty)).ToString();
            dgvImport.Rows[dgvImport.CurrentRow.Index].Cells[5].Value = int.Parse(Total).ToString("#,###");
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            // BlankQty
            int rc = dgvImport.RowCount,i,S=0;
            string name = "", total="";
            for (i=1; i<rc; i++)
            {
                if (dgvImport.Rows[i-1].Cells[3].Value.ToString() == "")
                {
                    S = 1;
                    name = dgvImport.Rows[i - 1].Cells[1].Value.ToString();
                }
            }

            if (dgvImport.Rows.Count < 2)
            {
                MessageBox.Show("There is nothing add in");
            }else if (S == 1)
            {
                MessageBox.Show("Please insert Quantity of "+name);
            }
            else
            {
                cnt.cmd = new SqlCommand("insert into tbOrder values(@BillNo, @Date, @SupplierID)", cnt.conn);
                cnt.cmd.Parameters.AddWithValue("@BillNo",lbBillNum.Text);
                cnt.cmd.Parameters.AddWithValue("@Date", (DateTime.Now.ToString("yyyy-dd-MM")));
                cnt.cmd.Parameters.AddWithValue("@SupplierID", cmbSupplier.SelectedValue);
                cnt.cmd.ExecuteNonQuery();

                for (i=0; i<rc-1; i++ )
                {
                    cnt.cmd = new SqlCommand("insert into OrderDetails values(@BillNo, @productID, @price, @Qty, @total)", cnt.conn);
                    cnt.cmd.Parameters.AddWithValue("@BillNo", lbBillNum.Text);
                    cnt.cmd.Parameters.AddWithValue("@productID", dgvImport.Rows[i].Cells[0].Value.ToString());
                    cnt.cmd.Parameters.AddWithValue("@price", dgvImport.Rows[i].Cells[2].Value.ToString());
                    cnt.cmd.Parameters.AddWithValue("@Qty", dgvImport.Rows[i].Cells[3].Value.ToString());
                    total = dgvImport.Rows[i].Cells[5].Value.ToString();
                    total = total.Replace(",","");
                    cnt.cmd.Parameters.AddWithValue("@total", total);
                    cnt.cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Save");
            }
            S = 0;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rc = dgvImport.RowCount;
            if (rc == 1)
            {
                MessageBox.Show("There is no item");
            }
            else
            {
                dgvImport.Rows.Remove(dgvImport.Rows[dgvImport.CurrentRow.Index]);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AutoBill()
        {
            SqlDataAdapter daB = new SqlDataAdapter("Select Max(OrderID) from tbOrder",cnt.conn);
            DataSet dsB = new DataSet();
            dsB.Clear();
            daB.Fill(dsB);
            string BillNo="";
            if (dsB.Tables[0].Rows[0].ItemArray[0].ToString() == "")
            {
                BillNo = "00001";
            }
            else
            {
                BillNo = dsB.Tables[0].Rows[0].ItemArray[0].ToString();
                BillNo = (int.Parse(BillNo)+1).ToString("00000");
            }
            lbBillNum.Text = BillNo;

        }

        private void btnCheckItem_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT dbo.tbProduct.ProductID, dbo.tbProduct.Product, dbo.tbProduct.Price, dbo.tbProduct.Quantity, dbo.tbProduct.ConditionCheck, dbo.tbUnit.UnitName FROM dbo.tbProduct INNER JOIN dbo.tbCategory ON dbo.tbProduct.CategoryID = dbo.tbCategory.CategoryID INNER JOIN dbo.tbUnit ON dbo.tbProduct.UnitID = dbo.tbUnit.UnitID WHERE (dbo.tbProduct.Quantity < dbo.tbProduct.ConditionCheck)", cnt.conn);
            ds.Clear();
            da.Fill(ds);
            dgvProduct.DataSource = ds.Tables[0];
            dgvProduct.Refresh();

        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            cnt.Check();
            AutoBill();

            SqlDataAdapter daS = new SqlDataAdapter("Select * from supplier", cnt.conn);
            DataSet dsS = new DataSet();
            dsS.Clear();
            daS.Fill(dsS);
            cmbSupplier.DataSource = dsS.Tables[0];
            cmbSupplier.DisplayMember = "SuplierName";
            cmbSupplier.ValueMember = "SupplierID";

            da = new SqlDataAdapter("SELECT dbo.tbProduct.ProductID, dbo.tbProduct.Product, dbo.tbProduct.Price, dbo.tbProduct.Quantity, dbo.tbUnit.UnitName FROM dbo.tbProduct INNER JOIN dbo.tbUnit ON dbo.tbProduct.UnitID = dbo.tbUnit.UnitID WHERE (dbo.tbProduct.Quantity < 0)", cnt.conn);
            ds.Clear();
            da.Fill(ds);
            dgvProduct.DataSource = ds.Tables[0];
            dgvProduct.Refresh();
            dgvProduct.Columns[0].HeaderText = "ລະຫັດສິນຄ້າ";
            dgvProduct.Columns[1].HeaderText = "ຊື່ສິນຄ້າ";
            dgvProduct.Columns[2].HeaderText = "ລາຄາສິນຄ້າ";
            dgvProduct.Columns[3].HeaderText = "ຈຳນວນສິນຄ້າ";
            dgvProduct.Columns[4].HeaderText = "ຫົວໜ່ວຍສິນຄ້າ";
            dgvProduct.Columns[0].Width = 150;
            dgvProduct.Columns[1].Width = 200;
            dgvProduct.Columns[2].Width = 180;
            dgvProduct.Columns[3].Width = 120;
            dgvProduct.Columns[4].Width = 150;
            dt.Columns.Add("ລະຫັດສິນຄ້າ", typeof(string));
            dt.Columns.Add("ຊື່ສິນຄ້າ", typeof(string));
            dt.Columns.Add("ລາຄາສິນຄ້າ", typeof(string));
            dt.Columns.Add("ຈຳນວນສິນຄ້າ", typeof(string));
            dt.Columns.Add("ຫົວໜ່ວຍສິນຄ້າ", typeof(string));
            dt.Columns.Add("ລາຄາລວມ", typeof(string));
            dgvImport.DataSource = dt;
            dgvImport.Columns[0].Width = 130;
            dgvImport.Columns[1].Width = 180;
            dgvImport.Columns[2].Width = 150;
            dgvImport.Columns[3].Width = 100;
            dgvImport.Columns[4].Width = 100;
            dgvImport.Columns[5].Width = 140;
            dgvImport.Refresh();

        }
    }
}
