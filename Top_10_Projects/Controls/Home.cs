using System;
using System.Windows.Forms;

namespace Top_10_Projects.Controls
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

       


        private void pictureBox1_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process.Start("https://github.com/Sergiu333");
        }
    }
}