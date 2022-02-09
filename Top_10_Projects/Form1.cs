using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Top_10_Projects.Controls;

namespace Top_10_Projects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Home h = new Home();
            adduserControl(h);
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.ForeColor =Color.Brown; 
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.ForeColor =Color.White; 
        }

         Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void adduserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer2.Controls.Clear();
            panelContainer2.Controls.Add(userControl);
            userControl.BringToFront();
        }

       

       

        private void Home_Click_1(object sender, EventArgs e)
        {
             Home h = new Home();
             adduserControl(h);
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            AboutUs a = new AboutUs();
            adduserControl(a);   
        }

        private void Projects_Click(object sender, EventArgs e)
        {
            Projects p = new Projects();
            adduserControl(p);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/Bizzaro333");
        }


        private void myName_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/Bizzaro333");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ceiti.md/");
        }

        
    }
}