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
    public partial class frmSell : Form
    {
        public frmSell()
        {
            InitializeComponent();
        }

        Connct cntn = new Connct();
        String total, amount;

        void AutoBill()
        {
            SqlDataAdapter daB = new SqlDataAdapter("Select max(BillNo) from tbSale",cntn.conn);
            DataSet dsB = new DataSet();
            daB.Fill(dsB);
            dsB.Clear();
            daB.Fill(dsB);
            String billNo = "";
            if (dsB.Tables[0].Rows[0].ItemArray[0].ToString() == "")
            {
                billNo = "00001";
            }
            else
            {
                billNo = dsB.Tables[0].Rows[0].ItemArray[0].ToString();
                billNo = (int.Parse(billNo) + 1).ToString("00000");
                
            }
            lbBillNo.Text = billNo.ToString();

        }

        private void frmSell_Load(object sender, EventArgs e)
        {
            cntn.Check();
            lbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            timer1.Start();
            LV.Columns.Add("ລະຫັດສິນຄ້າ",150,HorizontalAlignment.Left);
            LV.Columns.Add("ຊື່ສິນຄ້າ", 250, HorizontalAlignment.Left);
            LV.Columns.Add("ລາຄາສິນຄ້າ", 120, HorizontalAlignment.Right);
            LV.Columns.Add("ຈຳນວນສິນຄ້າ", 80, HorizontalAlignment.Center);
            LV.Columns.Add("ຫົວໜ່ວຍ", 100, HorizontalAlignment.Center);
            LV.Columns.Add("ລວມເປັນເງິນ", 150, HorizontalAlignment.Right);
            LV.View = View.Details;
            txtAmount.Enabled = false;
            txtPrice.Enabled = false;
            txtProductName.Enabled = false;
            txtQty.Enabled = false;
            txtTotal.Enabled = false;
            cbAuto.Checked = false;
            AutoBill();

        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAuto.Checked == true)
            {
                txtQty.Enabled = true;
            }
            else
            {
                txtQty.Enabled = false;
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtProductName.Clear();
                txtPrice.Clear();
                lbUnit.Text = "ຫົວໜ່ວຍ";
                txtQty.Clear();
                txtTotal.Clear();
                cntn.da = new SqlDataAdapter("Select p.Product, p.Price, u.UnitName from tbProduct p inner join tbUnit u on p.UnitID = u.UnitID where p.ProductID = "+txtProductID.Text+" ",cntn.conn);
                cntn.da.Fill(cntn.ds, "Product");
                cntn.ds.Tables[0].Clear();
                cntn.da.Fill(cntn.ds, "Product");
                txtProductName.Text = cntn.ds.Tables[0].Rows[0].ItemArray[0].ToString();
                txtPrice.Text = (int.Parse(cntn.ds.Tables[0].Rows[0].ItemArray[1].ToString())).ToString("#,###");
                lbUnit.Text = cntn.ds.Tables[0].Rows[0].ItemArray[2].ToString();
                txtQty.Text = "1";
                txtTotal.Text = txtPrice.Text;
                if (cbAuto.Checked == false)
                {
                    btnAdd.PerformClick();
                    txtProductID.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] AllData;
            AllData = new string[]{
                txtProductID.Text, txtProductName.Text, txtPrice.Text, txtQty.Text, lbUnit.Text, txtTotal.Text
            };
            ListViewItem lvi = new ListViewItem(AllData);
            LV.Items.Add(lvi);
            total = txtTotal.Text.Replace(",","");
            amount = txtAmount.Text.Replace(",", "");
            txtAmount.Text = (int.Parse(amount) + int.Parse(total)).ToString("#,###");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem() ;
            int i;
            for (i=0; i<LV.SelectedItems.Count; i++)
            {
                lvi = LV.SelectedItems[i];
                total = LV.SelectedItems[i].SubItems[5].Text;
            }
            LV.Items.Remove(lvi);
            total = total.Replace(",", "");
            amount = txtAmount.Text;
            amount = amount.Replace(",", "");
            if (int.Parse(amount) <= int.Parse(total))
            {
                txtAmount.Text = "0";
            }
            else
            {
                txtAmount.Text = (int.Parse(amount) - int.Parse(total)).ToString("#,###");
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = "ທ້າວແສງ";
            cntn.cmd = new SqlCommand("insert into tbSale values(@billNo, @billDate, @billTime, @userName)",cntn.conn);
            cntn.cmd.Parameters.AddWithValue("@billNo", lbBillNo.Text);
            cntn.cmd.Parameters.AddWithValue("@billDate", Convert.ToDateTime(lbDate.Text).ToString("yyyy-MM-dd"));
            cntn.cmd.Parameters.AddWithValue("@billTime", lbTime.Text);
            cntn.cmd.Parameters.AddWithValue("@userName", username);
            cntn.cmd.ExecuteNonQuery();

            int i;
            for (i=0; i<LV.Items.Count; i++)
            {
                cntn.cmd = new SqlCommand("insert into tbSaleDetail values(@billNo, @productID, @price, @qty, @total)",cntn.conn);
                cntn.cmd.Parameters.AddWithValue("@billNo",lbBillNo.Text);
                cntn.cmd.Parameters.AddWithValue("@productID", LV.Items[i].SubItems[0].Text);
                string price = LV.Items[i].SubItems[2].Text;
                price = price.Replace(",", "");
                cntn.cmd.Parameters.AddWithValue("@price", price);
                cntn.cmd.Parameters.AddWithValue("@qty", LV.Items[i].SubItems[3].Text);
                string total = LV.Items[i].SubItems[5].Text;
                total = total.Replace(",", "");
                cntn.cmd.Parameters.AddWithValue("@total",total);
                cntn.cmd.ExecuteNonQuery();

                SqlDataAdapter daQ = new SqlDataAdapter("select Quantity from tbProduct where ProductID = '" + LV.Items[i].SubItems[0].Text + "'", cntn.conn);
                DataSet dsQ = new DataSet();
                daQ.Fill(dsQ);
                dsQ.Clear();
                daQ.Fill(dsQ);
                string qty = dsQ.Tables[0].Rows[0].ItemArray[0].ToString();
                qty = (float.Parse(qty) - (float.Parse(LV.Items[i].SubItems[3].Text))).ToString();
                cntn.cmd = new SqlCommand("update tbProduct set Quantity=@qty where ProductID = @ID", cntn.conn);
                cntn.cmd.Parameters.AddWithValue("@qty", qty);
                cntn.cmd.Parameters.AddWithValue("@ID", LV.Items[i].SubItems[0].Text);
                cntn.cmd.ExecuteNonQuery();

            }

            AutoBill();
            LV.Items.Clear();
            txtProductID.Focus();
            MessageBox.Show("Save");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bool ch = false;
                int num;
                if (txtQty.Text != "") {
                    ch = int.TryParse(txtQty.Text, out num);
                    if (ch == false)
                    {
                        MessageBox.Show("ກະລຸນາປ້ອນຕົວເລກເທົ່ານັ້ນ", "ຜົນກວດສອບ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtQty.Text = "";
                    }
                    else
                    {
                        string price = txtPrice.Text;
                        price = price.Replace(",", "");
                        txtTotal.Text = (int.Parse(price) * int.Parse(txtQty.Text)).ToString("#,###");
                    }
                }
                else
                {
                    txtTotal.Text = "";
                }
                

            }
            catch(Exception ex)
            {

            }
            

        }
    }
}
