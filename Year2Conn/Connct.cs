using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Data;
using System.Data.SqlClient;

namespace Year2Conn
{
    internal class Connct
    {
            public String strcon = "data source = DESKTOP-TSHJDI9\\SQLEXPRESS; initial catalog = HW1; integrated security= true";
            public SqlConnection conn = new SqlConnection();
            public SqlDataAdapter da = new SqlDataAdapter();
            public SqlCommand cmd = new SqlCommand();
            public DataSet ds = new DataSet();

        public void Check()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.ConnectionString = strcon;
            ds.Clear();
            conn.Open();

        }
    }
     

}

