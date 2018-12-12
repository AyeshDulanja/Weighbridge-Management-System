using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WB
{
    public partial class mainw : Form
    {
        public mainw()
        {
            InitializeComponent();
            sidebar.Height = button3.Height;
            sidebar.Top = button3.Top;
            home1.BringToFront();
        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void button2_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidebar.Height = button3.Height;
            sidebar.Top = button3.Top;
            home1.BringToFront();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            sidebar.Height = button4.Height;
            sidebar.Top = button4.Top;
            stats1.BringToFront();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            sidebar.Height = button5.Height;
            sidebar.Top = button5.Top;
            report1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sidebar.Height = button6.Height;
            sidebar.Top = button6.Top;
           // about1.BringToFront();  
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 0;
                mouseY = MousePosition.Y - 0;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainw_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button2, "Logout");
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

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
