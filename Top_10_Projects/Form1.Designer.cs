namespace Top_10_Projects
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelContainer2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AboutUs = new System.Windows.Forms.Button();
            this.Projects = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.myName = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.myName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.BorderSize = 8;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.Location = new System.Drawing.Point(757, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (69)))), ((int) (((byte) (8)))), ((int) (((byte) (24)))));
            this.panelContainer.Controls.Add(this.panelContainer2);
            this.panelContainer.Controls.Add(this.panel3);
            this.panelContainer.Controls.Add(this.panel2);
            this.panelContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(800, 450);
            this.panelContainer.TabIndex = 1;
            this.panelContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panelContainer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panelContainer2
            // 
            this.panelContainer2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (150)))), ((int) (((byte) (136)))));
            this.panelContainer2.Location = new System.Drawing.Point(0, 131);
            this.panelContainer2.Name = "panelContainer2";
            this.panelContainer2.Size = new System.Drawing.Size(800, 319);
            this.panelContainer2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (47)))), ((int) (((byte) (48)))), ((int) (((byte) (71)))));
            this.panel3.Controls.Add(this.AboutUs);
            this.panel3.Controls.Add(this.Projects);
            this.panel3.Controls.Add(this.Home);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 55);
            this.panel3.TabIndex = 1;
            // 
            // AboutUs
            // 
            this.AboutUs.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (14)))), ((int) (((byte) (26)))), ((int) (((byte) (40)))));
            this.AboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutUs.Font = new System.Drawing.Font("Lobster", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.AboutUs.ForeColor = System.Drawing.SystemColors.Control;
            this.AboutUs.Location = new System.Drawing.Point(144, 3);
            this.AboutUs.Name = "AboutUs";
            this.AboutUs.Size = new System.Drawing.Size(117, 49);
            this.AboutUs.TabIndex = 5;
            this.AboutUs.Text = "About Us";
            this.AboutUs.UseVisualStyleBackColor = false;
            this.AboutUs.Click += new System.EventHandler(this.AboutUs_Click);
            // 
            // Projects
            // 
            this.Projects.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (14)))), ((int) (((byte) (26)))), ((int) (((byte) (40)))));
            this.Projects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Projects.Font = new System.Drawing.Font("Lobster", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Projects.ForeColor = System.Drawing.SystemColors.Control;
            this.Projects.Location = new System.Drawing.Point(267, 3);
            this.Projects.Name = "Projects";
            this.Projects.Size = new System.Drawing.Size(117, 49);
            this.Projects.TabIndex = 4;
            this.Projects.Text = "Projects";
            this.Projects.UseVisualStyleBackColor = false;
            this.Projects.Click += new System.EventHandler(this.Projects_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (14)))), ((int) (((byte) (26)))), ((int) (((byte) (40)))));
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (14)))), ((int) (((byte) (26)))), ((int) (((byte) (40)))));
            this.Home.Font = new System.Drawing.Font("Lobster", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Home.ForeColor = System.Drawing.SystemColors.Control;
            this.Home.Location = new System.Drawing.Point(21, 3);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(117, 49);
            this.Home.TabIndex = 3;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (37)))), ((int) (((byte) (58)))));
            this.panel2.Controls.Add(this.name);
            this.panel2.Controls.Add(this.myName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.buttonClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 78);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // name
            // 
            this.name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.name.Font = new System.Drawing.Font("Lobster", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.name.Location = new System.Drawing.Point(558, 42);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(135, 22);
            this.name.TabIndex = 4;
            this.name.Text = "Anghelenici Sergiu";
            this.name.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // myName
            // 
            this.myName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myName.Image = ((System.Drawing.Image) (resources.GetObject("myName.Image")));
            this.myName.Location = new System.Drawing.Point(682, 9);
            this.myName.Name = "myName";
            this.myName.Size = new System.Drawing.Size(84, 63);
            this.myName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myName.TabIndex = 3;
            this.myName.TabStop = false;
            this.myName.Click += new System.EventHandler(this.myName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (37)))), ((int) (((byte) (58)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonClose.Location = new System.Drawing.Point(772, 9);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(25, 28);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "X";
            this.buttonClose.Click += new System.EventHandler(this.label2_Click);
            this.buttonClose.MouseEnter += new System.EventHandler(this.buttonClose_MouseEnter);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lobster", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (239)))), ((int) (((byte) (239)))), ((int) (((byte) (239)))));
            this.label1.Location = new System.Drawing.Point(330, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Projects";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.myName)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label name;

        private System.Windows.Forms.PictureBox myName;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button Home;

        private System.Windows.Forms.Panel panelContainer2;

        private System.Windows.Forms.Button AboutUs;

        private System.Windows.Forms.Button Projects;



        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Label buttonClose;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panelContainer;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}