using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Top_10_Projects.Controls
{
    public partial class Projects : UserControl
    {
        
      
        public Projects()
        {
            InitializeComponent();
            
        }

        

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            
        }
        
        //sssssssssssssssssssssssssssssssssssssssssssssssssssssssss
        private void Project1_MouseEnter(object sender, EventArgs e)
        {
            Project1.BackColor =Color.FromArgb(0,52,59);
        }
        private void Project1_MouseLeave(object sender, EventArgs e)
        {
            Project1.BackColor =Color.FromArgb(0,66,66);
        }
        
        
        //sssssssssssssssssssssssssssssssssssssssssssssssssssssssss
        void Project2_MouseEnter(object sender, EventArgs e)
        {
            Project2.BackColor =Color.FromArgb(0,52,59);
        }
        private void Project2_MouseLeave(object sender, EventArgs e)
        {
            Project2.BackColor =Color.FromArgb(0,66,66);
        }
        
        //sssssssssssssssssssssssssssssssssssssssssssssssssssssssss
        void Project3_MouseEnter(object sender, EventArgs e)
        {
            Project3.BackColor =Color.FromArgb(0,52,59);
        }
        private void Project3_MouseLeave(object sender, EventArgs e)
        {
            Project3.BackColor =Color.FromArgb(0,66,66);
        }
        
        //sssssssssssssssssssssssssssssssssssssssssssssssssssssssss
        void Project4_MouseEnter(object sender, EventArgs e)
        {
            Project4.BackColor =Color.FromArgb(0,52,59);
        }
        private void Project4_MouseLeave(object sender, EventArgs e)
        {
            Project4.BackColor =Color.FromArgb(0,66,66);
        }
        
        //sssssssssssssssssssssssssssssssssssssssssssssssssssssssss
        void Project5_MouseEnter(object sender, EventArgs e)
        {
            Project5.BackColor =Color.FromArgb(0,52,59);
        }
        private void Project5_MouseLeave(object sender, EventArgs e)
        {
            Project5.BackColor =Color.FromArgb(0,66,66);
        }
        
        //sssssssssssssssssssssssssssssssssssssssssssssssssssssssss
        void Project6_MouseEnter(object sender, EventArgs e)
        {
            Project6.BackColor =Color.FromArgb(0,52,59);
        }
        private void Project6_MouseLeave(object sender, EventArgs e)
        {
            Project6.BackColor =Color.FromArgb(0,66,66);
        }
        
        //sssssssssssssssssssssssssssssssssssssssssssssssssssssssss
        void Project7_MouseEnter(object sender, EventArgs e)
        {
            Project7.BackColor =Color.FromArgb(0,52,59);
        }
        private void Project7_MouseLeave(object sender, EventArgs e)
        {
            Project7.BackColor =Color.FromArgb(0,66,66);
        }
        
        //sssssssssssssssssssssssssssssssssssssssssssssssssssssssss
        void Project8_MouseEnter(object sender, EventArgs e)
        {
            Project8.BackColor =Color.FromArgb(0,52,59);
        }
        private void Project8_MouseLeave(object sender, EventArgs e)
        {
            Project8.BackColor =Color.FromArgb(0,66,66);
        }
        
        //sssssssssssssssssssssssssssssssssssssssssssssssssssssssss
        void Project9_MouseEnter(object sender, EventArgs e)
        {
            Project9.BackColor =Color.FromArgb(0,52,59);
        }
        private void Project9_MouseLeave(object sender, EventArgs e)
        {
            Project9.BackColor =Color.FromArgb(0,66,66);
        }
        
        //sssssssssssssssssssssssssssssssssssssssssssssssssssssssss
        void Project10_MouseEnter(object sender, EventArgs e)
        {
            Project10.BackColor =Color.FromArgb(0,52,59);
        }
        private void Project10_MouseLeave(object sender, EventArgs e)
        {
            Project10.BackColor =Color.FromArgb(0,66,66);
        }

        private void Project1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Sergiu333/RapidMobil");
        }

       private void Project2_Click(object sender, EventArgs e)
       {
           System.Diagnostics.Process.Start("https://github.com/Sergiu333/registration_form_weather");
        }
        
       private void Project3_Click(object sender, EventArgs e)
       {
           System.Diagnostics.Process.Start("https://github.com/Sergiu333/AsusStore_SGBD");
       }
       
        private void Project4_Click(object sender, EventArgs e) 
        { 
            System.Diagnostics.Process.Start("https://github.com/Sergiu333/Banck");
        }

        private void Project5_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process.Start("https://github.com/Sergiu333/Hotel");
        }

        private void Project6_Click(object sender, EventArgs e)
        {
          System.Diagnostics.Process.Start("https://github.com/Sergiu333/Orchard");
        }
        private void Project7_Click(object sender, EventArgs e) 
        { 
            System.Diagnostics.Process.Start("https://github.com/Sergiu333/AsusStore");
        }


        private void Project8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Sergiu333/Pizza");

        }

        private void Project9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Sergiu333/DateStudents");
        }

        private void Project10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Sergiu333/Students");
        }
    }
}