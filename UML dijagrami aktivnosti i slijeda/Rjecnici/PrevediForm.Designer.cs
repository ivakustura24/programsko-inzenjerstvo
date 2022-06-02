namespace Rjecnici
{
    partial class PrevediForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbRecenica = new System.Windows.Forms.TextBox();
            this.tbPrevedenaRecenica = new System.Windows.Forms.TextBox();
            this.buttonPrijevod = new System.Windows.Forms.Button();
            this.cmbIzvorisni = new System.Windows.Forms.ComboBox();
            this.cmbOdredisni = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOcisti = new System.Windows.Forms.Button();
            this.PocetnaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite rečenicu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prijevod";
            // 
            // tbRecenica
            // 
            this.tbRecenica.Location = new System.Drawing.Point(139, 39);
            this.tbRecenica.Name = "tbRecenica";
            this.tbRecenica.Size = new System.Drawing.Size(336, 22);
            this.tbRecenica.TabIndex = 2;
            // 
            // tbPrevedenaRecenica
            // 
            this.tbPrevedenaRecenica.Location = new System.Drawing.Point(139, 210);
            this.tbPrevedenaRecenica.Name = "tbPrevedenaRecenica";
            this.tbPrevedenaRecenica.Size = new System.Drawing.Size(336, 22);
            this.tbPrevedenaRecenica.TabIndex = 3;
            // 
            // buttonPrijevod
            // 
            this.buttonPrijevod.Location = new System.Drawing.Point(380, 155);
            this.buttonPrijevod.Name = "buttonPrijevod";
            this.buttonPrijevod.Size = new System.Drawing.Size(95, 36);
            this.buttonPrijevod.TabIndex = 4;
            this.buttonPrijevod.Text = "Prevedi";
            this.buttonPrijevod.UseVisualStyleBackColor = true;
            this.buttonPrijevod.Click += new System.EventHandler(this.buttonPrijevod_Click);
            // 
            // cmbIzvorisni
            // 
            this.cmbIzvorisni.FormattingEnabled = true;
            this.cmbIzvorisni.Location = new System.Drawing.Point(139, 67);
            this.cmbIzvorisni.Name = "cmbIzvorisni";
            this.cmbIzvorisni.Size = new System.Drawing.Size(336, 24);
            this.cmbIzvorisni.TabIndex = 5;
            // 
            // cmbOdredisni
            // 
            this.cmbOdredisni.FormattingEnabled = true;
            this.cmbOdredisni.Location = new System.Drawing.Point(139, 112);
            this.cmbOdredisni.Name = "cmbOdredisni";
            this.cmbOdredisni.Size = new System.Drawing.Size(336, 24);
            this.cmbOdredisni.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Izvorišni jezik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Odredišni jezik";
            // 
            // tbOcisti
            // 
            this.tbOcisti.Location = new System.Drawing.Point(265, 155);
            this.tbOcisti.Name = "tbOcisti";
            this.tbOcisti.Size = new System.Drawing.Size(95, 36);
            this.tbOcisti.TabIndex = 9;
            this.tbOcisti.Text = "Očisti";
            this.tbOcisti.UseVisualStyleBackColor = true;
            this.tbOcisti.Click += new System.EventHandler(this.tbOcisti_Click);
            // 
            // PocetnaButton
            // 
            this.PocetnaButton.Location = new System.Drawing.Point(139, 155);
            this.PocetnaButton.Name = "PocetnaButton";
            this.PocetnaButton.Size = new System.Drawing.Size(95, 36);
            this.PocetnaButton.TabIndex = 10;
            this.PocetnaButton.Text = "Odustani";
            this.PocetnaButton.UseVisualStyleBackColor = true;
            this.PocetnaButton.Click += new System.EventHandler(this.PocetnaButton_Click);
            // 
            // PrevediForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 278);
            this.Controls.Add(this.PocetnaButton);
            this.Controls.Add(this.tbOcisti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbOdredisni);
            this.Controls.Add(this.cmbIzvorisni);
            this.Controls.Add(this.buttonPrijevod);
            this.Controls.Add(this.tbPrevedenaRecenica);
            this.Controls.Add(this.tbRecenica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PrevediForm";
            this.Text = "Prevedi";
            this.Load += new System.EventHandler(this.PrevediForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRecenica;
        private System.Windows.Forms.TextBox tbPrevedenaRecenica;
        private System.Windows.Forms.Button buttonPrijevod;
        private System.Windows.Forms.ComboBox cmbIzvorisni;
        private System.Windows.Forms.ComboBox cmbOdredisni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button tbOcisti;
        private System.Windows.Forms.Button PocetnaButton;
    }
}