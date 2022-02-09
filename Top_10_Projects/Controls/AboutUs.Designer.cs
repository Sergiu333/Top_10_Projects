using System.ComponentModel;

namespace Top_10_Projects.Controls
{
    partial class AboutUs
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
            this.label1 = new System.Windows.Forms.Label();
            this.labelAbout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lobster", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "About Us";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAbout
            // 
            this.labelAbout.Font = new System.Drawing.Font("Lobster", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelAbout.Location = new System.Drawing.Point(36, 116);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(743, 182);
            this.labelAbout.TabIndex = 1;
            this.labelAbout.Text = resources.GetString("labelAbout.Text");
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (150)))), ((int) (((byte) (136)))));
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.label1);
            this.Name = "AboutUs";
            this.Size = new System.Drawing.Size(800, 319);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelAbout;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}