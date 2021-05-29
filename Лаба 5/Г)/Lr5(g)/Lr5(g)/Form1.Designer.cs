
namespace Lr5_g_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picEarth = new System.Windows.Forms.PictureBox();
            this.picUFO = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picEarth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUFO)).BeginInit();
            this.SuspendLayout();
            // 
            // picEarth
            // 
            this.picEarth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picEarth.Image = global::Lr5_g_.Properties.Resources.Earth;
            this.picEarth.Location = new System.Drawing.Point(0, 0);
            this.picEarth.Name = "picEarth";
            this.picEarth.Size = new System.Drawing.Size(1575, 822);
            this.picEarth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEarth.TabIndex = 0;
            this.picEarth.TabStop = false;
            // 
            // picUFO
            // 
            this.picUFO.Image = global::Lr5_g_.Properties.Resources.ufo1;
            this.picUFO.Location = new System.Drawing.Point(1427, 379);
            this.picUFO.Name = "picUFO";
            this.picUFO.Size = new System.Drawing.Size(136, 99);
            this.picUFO.TabIndex = 1;
            this.picUFO.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lr5_g_.Properties.Resources.spacebackground;
            this.ClientSize = new System.Drawing.Size(1575, 822);
            this.Controls.Add(this.picUFO);
            this.Controls.Add(this.picEarth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEarth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUFO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picEarth;
        private System.Windows.Forms.PictureBox picUFO;
        private System.Windows.Forms.Timer timer1;
    }
}

