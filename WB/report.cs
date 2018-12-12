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
    public partial class report : UserControl
    {
        public report()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtsearch.Text))
            {
                MessageBox.Show("Enter a Ticket Number to Search");
                txtsearch.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");

                con.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM records WHERE (ticketno) = '" + txtsearch.Text + "'", con);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);

                dataGridView1.DataSource = dtbl;

                txtsearch.Clear();
                txtsearch.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM records ORDER BY ticketno DESC", con);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void report_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtsearch;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM records ORDER BY ticketno DESC", con);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);

            dataGridView1.DataSource = dtbl;

            
            dataGridView1.Columns[0].HeaderCell.Value = "Ticket No.";
            dataGridView1.Columns[1].HeaderCell.Value = "Product Name";
            dataGridView1.Columns[2].HeaderCell.Value = "Vehicle Number";
            dataGridView1.Columns[3].HeaderCell.Value = "Harvester";
            dataGridView1.Columns[4].HeaderCell.Value = "Date/Time";
            dataGridView1.Columns[5].HeaderCell.Value = "First Weight (Kg)";
            dataGridView1.Columns[6].HeaderCell.Value = "Second Weight (Kg)";
            dataGridView1.Columns[7].HeaderCell.Value = "Net Weight (Kg)";

            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Width = 70;
            dataGridView1.Columns[6].Width = 70;
            dataGridView1.Columns[7].Width = 70;

            
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnsearch.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StatUpdate su = new StatUpdate();
            su.Show();
        }
    }
}
