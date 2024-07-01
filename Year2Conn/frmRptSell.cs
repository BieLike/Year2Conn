using CrystalDecisions.Shared;
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
    public partial class frmRptSell : Form
    {
        public frmRptSell()
        {
            InitializeComponent();
        }

        Connct cnt = new Connct();

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRptSell_Load(object sender, EventArgs e)
        {
            cnt.Check();
            cnt.da = new SqlDataAdapter("Select * from tbUser where Author = N'ພະນັກງານຂາຍ'",cnt.conn);
            cnt.ds.Clear();
            cnt.da.Fill(cnt.ds);
            cmbUser.DataSource = cnt.ds.Tables[0];
            cmbUser.DisplayMember = "userName";
            cmbUser.ValueMember = "userName";
            crystalReportViewer1.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //crystalReportViewer1.SelectionFormula = "{tbSale.UserName}='" + cmbUser.SelectedValue + "' and {tbSale.BillDate} = '"+Convert.ToDateTime(dtpSellDate.Text).ToString("yyyy-dd-MM")+"'  ";
            //crystalReportViewer1.RefreshReport();

            SqlDataAdapter da = new SqlDataAdapter("SELECT dbo.tbSale.BillNo, dbo.tbSale.BillDate, dbo.tbSale.BillTime, dbo.tbProduct.Product, dbo.tbSaleDetail.Price, dbo.tbSaleDetail.Qty, dbo.tbUnit.UnitName, dbo.tbSaleDetail.Total, dbo.tbSale.UserName FROM dbo.tbProduct INNER JOIN dbo.tbSaleDetail ON dbo.tbProduct.ProductID = dbo.tbSaleDetail.ProductID INNER JOIN dbo.tbSale ON dbo.tbSaleDetail.BillNo = dbo.tbSale.BillNo INNER JOIN dbo.tbUnit ON dbo.tbProduct.UnitID = dbo.tbUnit.UnitID WHERE (dbo.tbSale.UserName = N'"+cmbUser.SelectedValue+"') AND (dbo.tbSale.BillDate = '"+Convert.ToDateTime(dtpSellDate.Text).ToString("yyyy-dd-MM")+"')",cnt.conn);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            rptSell rpt = new rptSell();
            rpt.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.RefreshReport();

        }

        private void rptSell3_InitReport(object sender, EventArgs e)
        {

        }
    }
}
