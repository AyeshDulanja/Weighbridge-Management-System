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
    public partial class edit : Form
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;

       // int mouseX = 0, mouseY = 0;
       // bool mouseDown;

        public edit()
        {
            InitializeComponent();
            LoadData1();
            LoadData2();
            LoadData3();

            //txtid.Enabled = false;
            //txtid.Text = "Select a Value";

        }

        public void LoadData1()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM items", con);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);

            dataGridView1.DataSource = dtbl;

            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 250;


        }

        public void LoadData2()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM vehicle", con);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);

            dataGridView2.DataSource = dtbl;

            dataGridView2.Columns[0].Width = 50;
            dataGridView2.Columns[1].Width = 250;


        }

        public void LoadData3()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM harvester", con);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);

            dataGridView3.DataSource = dtbl;

            dataGridView3.Columns[0].Width = 50;
            dataGridView3.Columns[1].Width = 250;


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row =this.dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString().Trim();
                txtproduct.Text = row.Cells[1].Value.ToString().Trim();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            cmd = new SqlCommand("INSERT INTO items (id,item) VALUES (@id,@item)", con);

            cmd.Parameters.AddWithValue("@id", txtid.Text.Trim());
            cmd.Parameters.AddWithValue("@item", txtproduct.Text.Trim());

            int affectedRows = cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Added", "Weighbridge Management");
            LoadData1();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            cmd = new SqlCommand("UPDATE items set id=@id,item=@item WHERE id='"+txtid.Text+"'", con);

            cmd.Parameters.AddWithValue("@id", txtid.Text.Trim());
            cmd.Parameters.AddWithValue("@item", txtproduct.Text.Trim());

            int affectedRows = cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated");
            LoadData1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            cmd = new SqlCommand("DELETE items WHERE id='" + txtid.Text + "'", con);
            int affectedRows = cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data Successfully Deleted");
            txtid.Clear();
            txtproduct.Clear();
            LoadData1();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            cmd = new SqlCommand("INSERT INTO vehicle (id,vehicle) VALUES (@id,@vehicle)", con);

            cmd.Parameters.AddWithValue("@id", textBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@vehicle", textBox1.Text.Trim());

            int affectedRows = cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Added", "Weighbridge Management");
            LoadData2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            cmd = new SqlCommand("UPDATE vehicle set id=@id,vehicle=@vehicle WHERE id='" + textBox2.Text + "'", con);

            cmd.Parameters.AddWithValue("@id", textBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@vehicle", textBox1.Text.Trim());

            int affectedRows = cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated");
            LoadData2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            cmd = new SqlCommand("DELETE vehicle WHERE id='" + textBox2.Text + "'", con);
            int affectedRows = cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data Successfully Deleted");
            textBox2.Clear();
            textBox1.Clear();
            LoadData2();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            cmd = new SqlCommand("INSERT INTO harvester (id,name) VALUES (@id,@name)", con);

            cmd.Parameters.AddWithValue("@id", textBox4.Text.Trim());
            cmd.Parameters.AddWithValue("@name", textBox3.Text.Trim());

            int affectedRows = cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Added", "Weighbridge Management");
            LoadData3();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            cmd = new SqlCommand("UPDATE harvester set id=@id,name=@name WHERE id='" + textBox4.Text + "'", con);

            cmd.Parameters.AddWithValue("@id", textBox4.Text.Trim());
            cmd.Parameters.AddWithValue("@name", textBox3.Text.Trim());

            int affectedRows = cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated");
            LoadData3();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            cmd = new SqlCommand("DELETE harvester WHERE id='" + textBox4.Text + "'", con);
            int affectedRows = cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data Successfully Deleted");
            textBox4.Clear();
            textBox3.Clear();
            LoadData3();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                textBox2.Text = row.Cells[0].Value.ToString().Trim();
                textBox1.Text = row.Cells[1].Value.ToString().Trim();
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView3.Rows[e.RowIndex];
                textBox4.Text = row.Cells[0].Value.ToString().Trim();
                textBox3.Text = row.Cells[1].Value.ToString().Trim();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            /*if (mouseDown)
            {
                mouseX = MousePosition.X - 0;
                mouseY = MousePosition.Y - 0;

                this.SetDesktopLocation(mouseX, mouseY);
            }*/
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //mouseDown = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
           // mouseDown = true;
        }
    }
}
