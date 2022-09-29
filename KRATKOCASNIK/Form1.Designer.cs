
namespace KRATKOCASNIK
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
            this.gmbPuzle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gmbTekac = new System.Windows.Forms.Button();
            this.gmbBesede = new System.Windows.Forms.Button();
            this.slikaBesede = new System.Windows.Forms.PictureBox();
            this.slikaTekac = new System.Windows.Forms.PictureBox();
            this.slikaPuzzle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.slikaBesede)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slikaTekac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slikaPuzzle)).BeginInit();
            this.SuspendLayout();
            // 
            // gmbPuzle
            // 
            this.gmbPuzle.BackColor = System.Drawing.Color.LightGreen;
            this.gmbPuzle.Location = new System.Drawing.Point(62, 345);
            this.gmbPuzle.Name = "gmbPuzle";
            this.gmbPuzle.Size = new System.Drawing.Size(158, 26);
            this.gmbPuzle.TabIndex = 1;
            this.gmbPuzle.Text = "IGRAJ PUZLE";
            this.gmbPuzle.UseVisualStyleBackColor = false;
            this.gmbPuzle.Click += new System.EventHandler(this.gmbPuzle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gmbTekac
            // 
            this.gmbTekac.BackColor = System.Drawing.Color.PaleTurquoise;
            this.gmbTekac.Location = new System.Drawing.Point(256, 345);
            this.gmbTekac.Name = "gmbTekac";
            this.gmbTekac.Size = new System.Drawing.Size(158, 26);
            this.gmbTekac.TabIndex = 1;
            this.gmbTekac.Text = "IGRAJ TEKAČA";
            this.gmbTekac.UseVisualStyleBackColor = false;
            this.gmbTekac.Click += new System.EventHandler(this.gmbTekac_Click);
            // 
            // gmbBesede
            // 
            this.gmbBesede.BackColor = System.Drawing.Color.Thistle;
            this.gmbBesede.Location = new System.Drawing.Point(439, 345);
            this.gmbBesede.Name = "gmbBesede";
            this.gmbBesede.Size = new System.Drawing.Size(158, 26);
            this.gmbBesede.TabIndex = 1;
            this.gmbBesede.Text = "IGRAJ BESEDE";
            this.gmbBesede.UseVisualStyleBackColor = false;
            this.gmbBesede.Click += new System.EventHandler(this.gmbBesede_Click);
            // 
            // slikaBesede
            // 
            this.slikaBesede.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.slikaBesede.Image = global::KRATKOCASNIK.Properties.Resources.lingo;
            this.slikaBesede.Location = new System.Drawing.Point(438, 62);
            this.slikaBesede.Name = "slikaBesede";
            this.slikaBesede.Size = new System.Drawing.Size(159, 259);
            this.slikaBesede.TabIndex = 0;
            this.slikaBesede.TabStop = false;
            // 
            // slikaTekac
            // 
            this.slikaTekac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.slikaTekac.Image = global::KRATKOCASNIK.Properties.Resources.Screenshot_11;
            this.slikaTekac.Location = new System.Drawing.Point(62, 62);
            this.slikaTekac.Name = "slikaTekac";
            this.slikaTekac.Size = new System.Drawing.Size(159, 259);
            this.slikaTekac.TabIndex = 0;
            this.slikaTekac.TabStop = false;
            // 
            // slikaPuzzle
            // 
            this.slikaPuzzle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.slikaPuzzle.Image = global::KRATKOCASNIK.Properties.Resources.tekacOzadje;
            this.slikaPuzzle.Location = new System.Drawing.Point(257, 62);
            this.slikaPuzzle.Name = "slikaPuzzle";
            this.slikaPuzzle.Size = new System.Drawing.Size(159, 259);
            this.slikaPuzzle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slikaPuzzle.TabIndex = 0;
            this.slikaPuzzle.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(665, 414);
            this.Controls.Add(this.gmbBesede);
            this.Controls.Add(this.gmbTekac);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gmbPuzle);
            this.Controls.Add(this.slikaBesede);
            this.Controls.Add(this.slikaTekac);
            this.Controls.Add(this.slikaPuzzle);
            this.Name = "Form1";
            this.Text = "KRATKOČASNIK";
            ((System.ComponentModel.ISupportInitialize)(this.slikaBesede)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slikaTekac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slikaPuzzle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox slikaPuzzle;
        private System.Windows.Forms.PictureBox slikaTekac;
        private System.Windows.Forms.PictureBox slikaBesede;
        private System.Windows.Forms.Button gmbPuzle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button gmbTekac;
        private System.Windows.Forms.Button gmbBesede;
    }
}

