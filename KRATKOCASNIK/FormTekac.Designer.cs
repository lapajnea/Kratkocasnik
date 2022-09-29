
namespace KRATKOCASNIK
{
    partial class FormTekac
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
            this.components = new System.ComponentModel.Container();
            this.lblTocke = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.slikaTekac = new System.Windows.Forms.PictureBox();
            this.slikaTla = new System.Windows.Forms.PictureBox();
            this.slikaDdrevo = new System.Windows.Forms.PictureBox();
            this.slikaOgraja = new System.Windows.Forms.PictureBox();
            this.timerCas = new System.Windows.Forms.Timer(this.components);
            this.lblCas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.slikaTekac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slikaTla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slikaDdrevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slikaOgraja)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTocke
            // 
            this.lblTocke.AutoSize = true;
            this.lblTocke.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTocke.ForeColor = System.Drawing.Color.Black;
            this.lblTocke.Location = new System.Drawing.Point(26, 73);
            this.lblTocke.Name = "lblTocke";
            this.lblTocke.Size = new System.Drawing.Size(56, 24);
            this.lblTocke.TabIndex = 3;
            this.lblTocke.Text = "Točke: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // slikaTekac
            // 
            this.slikaTekac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.slikaTekac.Image = global::KRATKOCASNIK.Properties.Resources.runner1;
            this.slikaTekac.Location = new System.Drawing.Point(131, 385);
            this.slikaTekac.Name = "slikaTekac";
            this.slikaTekac.Size = new System.Drawing.Size(44, 60);
            this.slikaTekac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slikaTekac.TabIndex = 1;
            this.slikaTekac.TabStop = false;
            // 
            // slikaTla
            // 
            this.slikaTla.BackColor = System.Drawing.Color.Green;
            this.slikaTla.Location = new System.Drawing.Point(-12, 452);
            this.slikaTla.Name = "slikaTla";
            this.slikaTla.Size = new System.Drawing.Size(652, 50);
            this.slikaTla.TabIndex = 0;
            this.slikaTla.TabStop = false;
            // 
            // slikaDdrevo
            // 
            this.slikaDdrevo.Image = global::KRATKOCASNIK.Properties.Resources.drevo1;
            this.slikaDdrevo.Location = new System.Drawing.Point(534, 400);
            this.slikaDdrevo.Name = "slikaDdrevo";
            this.slikaDdrevo.Size = new System.Drawing.Size(50, 50);
            this.slikaDdrevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slikaDdrevo.TabIndex = 5;
            this.slikaDdrevo.TabStop = false;
            this.slikaDdrevo.Tag = "ovira";
            // 
            // slikaOgraja
            // 
            this.slikaOgraja.Image = global::KRATKOCASNIK.Properties.Resources.ograja;
            this.slikaOgraja.Location = new System.Drawing.Point(473, 397);
            this.slikaOgraja.Name = "slikaOgraja";
            this.slikaOgraja.Size = new System.Drawing.Size(95, 49);
            this.slikaOgraja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slikaOgraja.TabIndex = 6;
            this.slikaOgraja.TabStop = false;
            this.slikaOgraja.Tag = "ovira";
            // 
            // timerCas
            // 
            this.timerCas.Interval = 1000;
            this.timerCas.Tick += new System.EventHandler(this.timerCas_Tick);
            // 
            // lblCas
            // 
            this.lblCas.AutoSize = true;
            this.lblCas.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCas.ForeColor = System.Drawing.Color.Black;
            this.lblCas.Location = new System.Drawing.Point(26, 97);
            this.lblCas.Name = "lblCas";
            this.lblCas.Size = new System.Drawing.Size(96, 24);
            this.lblCas.TabIndex = 7;
            this.lblCas.Text = "Čas: 0 sekund";
            // 
            // FormTekac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(618, 475);
            this.Controls.Add(this.lblCas);
            this.Controls.Add(this.slikaOgraja);
            this.Controls.Add(this.slikaDdrevo);
            this.Controls.Add(this.lblTocke);
            this.Controls.Add(this.slikaTekac);
            this.Controls.Add(this.slikaTla);
            this.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.Name = "FormTekac";
            this.Text = "Tekač";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tipkaDol);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tipkaGor);
            ((System.ComponentModel.ISupportInitialize)(this.slikaTekac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slikaTla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slikaDdrevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slikaOgraja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox slikaTla;
        private System.Windows.Forms.PictureBox slikaTekac;
        private System.Windows.Forms.Label lblTocke;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox slikaDdrevo;
        private System.Windows.Forms.PictureBox slikaOgraja;
        private System.Windows.Forms.Timer timerCas;
        private System.Windows.Forms.Label lblCas;
    }
}