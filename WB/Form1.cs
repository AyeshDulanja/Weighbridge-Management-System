using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WB
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                mouseX = MousePosition.X - 0;
                mouseY = MousePosition.Y - 0;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            mainw frm2 = new mainw();
            frm2.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayesh Dulanja\Documents\Visual Studio 2015\Projects\WB\userdb.mdf;Integrated Security=True;Connect Timeout=30");
           // string query = "Select * from users Where username = '" + txtun.Text.Trim() + "' and password ='" + txtpw.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM [users] WHERE username = '" + txtun.Text.Trim() + "' AND password ='" + txtpw.Text.Trim() + "'", sqlcon);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                mainw mw = new mainw();
                this.Hide();
                mw.Show();
            }
            else
            {
                MessageBox.Show("User Name or Password are Incorrect","Login Failed");
            }
            txtun.Clear();
            txtpw.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
