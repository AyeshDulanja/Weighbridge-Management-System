using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WB
{
    public partial class StatUpdate : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;

        public StatUpdate()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM records", con);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString().Trim();
                textBox2.Text = row.Cells[1].Value.ToString().Trim();
                textBox3.Text = row.Cells[2].Value.ToString().Trim();
                textBox4.Text = row.Cells[3].Value.ToString().Trim();
                textBox5.Text = row.Cells[4].Value.ToString().Trim();
                textBox6.Text = row.Cells[5].Value.ToString().Trim();
                textBox7.Text = row.Cells[6].Value.ToString().Trim();
                textBox8.Text = row.Cells[7].Value.ToString().Trim();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            cmd = new SqlCommand("UPDATE records set ticketno=@ticketno,item=@item,vehicle=@vehicle,harvester=@harvester,datentime=@datentime,firstwt=@firstwt,secondwt=@secondwt,netwt=@netwt WHERE ticketno='" + textBox1.Text + "'", con);

            cmd.Parameters.AddWithValue("@ticketno", textBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@item", textBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@vehicle", textBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@harvester", textBox4.Text.Trim());
            cmd.Parameters.AddWithValue("@datentime", textBox5.Text.Trim());
            cmd.Parameters.AddWithValue("@firstwt", textBox6.Text.Trim());
            cmd.Parameters.AddWithValue("@secondwt", textBox7.Text.Trim());
            cmd.Parameters.AddWithValue("@netwt", textBox8.Text.Trim());

            int affectedRows = cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated");
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            cmd = new SqlCommand("DELETE records WHERE ticketno='" + textBox1.Text + "'", con);
            int affectedRows = cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data Successfully Deleted");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            LoadData();
        }
    }
}
