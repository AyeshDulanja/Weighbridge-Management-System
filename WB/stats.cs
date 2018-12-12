using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WB
{
    public partial class stats : UserControl
    {
        public void load()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM records order by ticketno DESC", con);

            DataSet ds = new DataSet();
            sqlda.Fill(ds);

            DataView source = new DataView(ds.Tables[0]);

            chart1.DataSource = source;

            chart1.Series[0].XValueMember = "ticketno";
            chart1.Series[0].YValueMembers = "netwt";
            chart1.DataBind();
        }
        public stats()
        {
            InitializeComponent();
            load();
        }

        private void stats_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM records order by ticketno DESC", con);

            DataSet ds = new DataSet();
            sqlda.Fill(ds);

            DataView source = new DataView(ds.Tables[0]);

            chart1.DataSource = source;

            chart1.Series[0].XValueMember = "ticketno";
            chart1.Series[0].YValueMembers = "netwt";
            chart1.DataBind();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
