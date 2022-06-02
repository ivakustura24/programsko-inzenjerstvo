namespace _10_Glasanje
{
    partial class GlasanjeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGlasaj = new System.Windows.Forms.Button();
            this.cmbOpcija = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBOib = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSuzdrzan = new System.Windows.Forms.Label();
            this.lbProtiv = new System.Windows.Forms.Label();
            this.lbZa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite OIB:";
            // 
            // btnGlasaj
            // 
            this.btnGlasaj.Location = new System.Drawing.Point(33, 174);
            this.btnGlasaj.Name = "btnGlasaj";
            this.btnGlasaj.Size = new System.Drawing.Size(171, 33);
            this.btnGlasaj.TabIndex = 1;
            this.btnGlasaj.Text = "Glasaj";
            this.btnGlasaj.UseVisualStyleBackColor = true;
            this.btnGlasaj.Click += new System.EventHandler(this.btnGlasaj_Click);
            // 
            // cmbOpcija
            // 
            this.cmbOpcija.FormattingEnabled = true;
            this.cmbOpcija.Location = new System.Drawing.Point(33, 133);
            this.cmbOpcija.Name = "cmbOpcija";
            this.cmbOpcija.Size = new System.Drawing.Size(171, 24);
            this.cmbOpcija.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Odaberite opciju";
            // 
            // tBOib
            // 
            this.tBOib.Location = new System.Drawing.Point(33, 65);
            this.tBOib.Name = "tBOib";
            this.tBOib.Size = new System.Drawing.Size(171, 22);
            this.tBOib.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rezultati";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "ZA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "PROTIV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "SUZDRŽAN:";
            // 
            // lbSuzdrzan
            // 
            this.lbSuzdrzan.AutoSize = true;
            this.lbSuzdrzan.Location = new System.Drawing.Point(411, 150);
            this.lbSuzdrzan.Name = "lbSuzdrzan";
            this.lbSuzdrzan.Size = new System.Drawing.Size(0, 16);
            this.lbSuzdrzan.TabIndex = 9;
            // 
            // lbProtiv
            // 
            this.lbProtiv.AutoSize = true;
            this.lbProtiv.Location = new System.Drawing.Point(411, 114);
            this.lbProtiv.Name = "lbProtiv";
            this.lbProtiv.Size = new System.Drawing.Size(0, 16);
            this.lbProtiv.TabIndex = 10;
            // 
            // lbZa
            // 
            this.lbZa.AutoSize = true;
            this.lbZa.Location = new System.Drawing.Point(411, 71);
            this.lbZa.Name = "lbZa";
            this.lbZa.Size = new System.Drawing.Size(0, 16);
            this.lbZa.TabIndex = 11;
            // 
            // GlasanjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 233);
            this.Controls.Add(this.lbZa);
            this.Controls.Add(this.lbProtiv);
            this.Controls.Add(this.lbSuzdrzan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBOib);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOpcija);
            this.Controls.Add(this.btnGlasaj);
            this.Controls.Add(this.label1);
            this.Name = "GlasanjeForm";
            this.Text = "Izbori";
            this.Load += new System.EventHandler(this.GlasanjeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGlasaj;
        private System.Windows.Forms.ComboBox cmbOpcija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBOib;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbSuzdrzan;
        private System.Windows.Forms.Label lbProtiv;
        private System.Windows.Forms.Label lbZa;
    }
}

