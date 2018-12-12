using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Data.Sql;
using System.Data.SqlClient;

/*class myConnection
{
    public static SqlConnection GetConnection()
    {
        string str = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30";

        SqlConnection con = new SqlConnection(str);
        con.Open();
        }
}*/

namespace WB
{
    public partial class home : UserControl
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;

        private void item()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string qry = ("SELECT item FROM items");
            SqlDataReader dr = new SqlCommand(qry, con).ExecuteReader();
            while (dr.Read())
            {
                cbitem.Items.Add(dr.GetValue(0).ToString());
                cbitem.SelectedIndex = 0;
            }
            con.Close();
        }

        private void vehicle()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string qry = ("SELECT vehicle FROM vehicle");
            SqlDataReader dr = new SqlCommand(qry, con).ExecuteReader();
            while (dr.Read())
            {
                cbvehicle.Items.Add(dr.GetValue(0).ToString());
                cbvehicle.SelectedIndex = 0;
            }
            con.Close();
        }

        private void harvester()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string qry = ("SELECT name FROM harvester");
            SqlDataReader dr = new SqlCommand(qry, con).ExecuteReader();
            while (dr.Read())
            {
                cbharvester.Items.Add(dr.GetValue(0).ToString());
                cbharvester.SelectedIndex = 0;
            }
            con.Close();
        }

        public home()
        {
            InitializeComponent();
            timer1.Start();
           
            //Item Type
            vehicle();

            //Vehicle
            item();

            //harvester
            harvester();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void home_Load(object sender, EventArgs e)
        {
            //Ticket No. (Auto Increment)
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT isnull(MAX (cast(ticketno AS int)),0)+1 FROM records", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtticket.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = cbitem;

            /*
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string qry = ("SELECT item FROM items");
            SqlDataReader dr = new SqlCommand(qry, con).ExecuteReader();
            while (dr.Read())
            {
                cbitem.Items.Add(dr.GetValue(0).ToString());
            }
            con.Close();
            */
        }

        private void txtnwt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtwt2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtwt1.Text) && !string.IsNullOrEmpty(txtwt2.Text))
                txtnetwt.Text = (Convert.ToDouble(txtwt1.Text) - Convert.ToDouble(txtwt2.Text)).ToString();

            //lblnetwt.Text = Convert.ToString(Convert.ToInt32(txtwt1.Text) - Convert.ToInt32(txtwt2.Text));

            /*float a = Convert.(txtwt1.Text);

            float b = Convert.ToInt32(txtwt2.Text);

            float c = a - b;

            lblnetwt.Text = Convert.ToString(c);*/
        }

        private void txtwt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.txtdt.Text = datetime.ToString();
        }

        private void netwt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtwt1.Text))
            {
                MessageBox.Show("Enter First Weight");
                txtwt1.Focus();
            }

            else if (String.IsNullOrEmpty(txtwt2.Text))
            {
                MessageBox.Show("Enter Second Weight");
                txtwt2.Focus();
            }

            else
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");

                con.Open();

                cmd = new SqlCommand("INSERT INTO records (ticketno,item,vehicle,harvester,datentime,firstwt,secondwt,netwt) VALUES (@ticketno,@item,@vehicle,@harvester,@datentime,@firstwt,@secondwt,@netwt)", con);

                cmd.Parameters.AddWithValue("@ticketno", txtticket.Text.Trim());
                cmd.Parameters.AddWithValue("@item", cbitem.SelectedItem.ToString().Trim());
                cmd.Parameters.AddWithValue("@vehicle", cbvehicle.SelectedItem.ToString().Trim());
                cmd.Parameters.AddWithValue("@harvester", cbharvester.SelectedItem.ToString().Trim());
                cmd.Parameters.AddWithValue("@datentime",txtdt.Text.Trim());
                cmd.Parameters.AddWithValue("@firstwt", txtwt1.Text.Trim());
                cmd.Parameters.AddWithValue("@secondwt", txtwt2.Text.Trim());
                cmd.Parameters.AddWithValue("@netwt", txtnetwt.Text.Trim());
                
                int affectedRows = cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Successfully Added", "Weighbridge Management");

                txtticket.Clear();
                txtwt2.Clear();
                txtwt1.Clear();
                txtnetwt.Clear();

                SqlDataAdapter sda = new SqlDataAdapter("SELECT isnull(MAX (cast(ticketno AS int)),0)+1 FROM records", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                txtticket.Text = dt.Rows[0][0].ToString();

                cbitem.Focus();
            }
        }

        private void home_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                button1.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            edit ed = new edit();
            ed.Show();
        }
    }
}
