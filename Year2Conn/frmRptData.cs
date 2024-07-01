using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Year2Conn
{
    public partial class frmRptData : Form
    {
        public frmRptData(String FirstDate, String LastDate)
        {
            InitializeComponent();

            ParameterField fDate = new ParameterField();
            ParameterField lDate = new ParameterField();
            ParameterDiscreteValue vFDate = new ParameterDiscreteValue();
            ParameterDiscreteValue vLDate = new ParameterDiscreteValue();
            fDate.ParameterFieldName = "FirstDate";
            lDate.ParameterFieldName = "LastDate";
            vFDate.Value = FirstDate;
            vLDate.Value = LastDate;
            fDate.CurrentValues.Add(vFDate);
            lDate.CurrentValues.Add(vLDate);

            ParameterFields AllValue = new ParameterFields();
            AllValue.Add(fDate);
            AllValue.Add(lDate);
            crvData.ParameterFieldInfo = AllValue;
            crvData.SelectionFormula = "{tbSale.BillDate} IN '" + Convert.ToDateTime(FirstDate).ToString("yyyy-dd-MM") + "' To '" + Convert.ToDateTime(LastDate).ToString("yyyy-dd-MM") + "'  ";

        }


        private void rptProduct11_InitReport(object sender, EventArgs e)
        {

        }


        private void frmRptData_Load(object sender, EventArgs e)
        {

        }

        private void crvData_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


        }
    }
}
