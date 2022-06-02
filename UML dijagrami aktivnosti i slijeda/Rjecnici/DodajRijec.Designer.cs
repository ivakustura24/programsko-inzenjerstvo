namespace Rjecnici
{
    partial class DodajRijecForm
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
            this.tbRijec = new System.Windows.Forms.TextBox();
            this.tbPrijevod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUnesi = new System.Windows.Forms.Button();
            this.cmbjezik1 = new System.Windows.Forms.ComboBox();
            this.cmbJezik2 = new System.Windows.Forms.ComboBox();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbRijec
            // 
            this.tbRijec.Location = new System.Drawing.Point(210, 59);
            this.tbRijec.Name = "tbRijec";
            this.tbRijec.Size = new System.Drawing.Size(157, 22);
            this.tbRijec.TabIndex = 0;
            // 
            // tbPrijevod
            // 
            this.tbPrijevod.Location = new System.Drawing.Point(210, 123);
            this.tbPrijevod.Name = "tbPrijevod";
            this.tbPrijevod.Size = new System.Drawing.Size(157, 22);
            this.tbPrijevod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Riječ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prijevod";
            // 
            // buttonUnesi
            // 
            this.buttonUnesi.Location = new System.Drawing.Point(292, 194);
            this.buttonUnesi.Name = "buttonUnesi";
            this.buttonUnesi.Size = new System.Drawing.Size(75, 35);
            this.buttonUnesi.TabIndex = 4;
            this.buttonUnesi.Text = "Unesi";
            this.buttonUnesi.UseVisualStyleBackColor = true;
            this.buttonUnesi.Click += new System.EventHandler(this.buttonUnesi_Click);
            // 
            // cmbjezik1
            // 
            this.cmbjezik1.FormattingEnabled = true;
            this.cmbjezik1.Location = new System.Drawing.Point(210, 93);
            this.cmbjezik1.Name = "cmbjezik1";
            this.cmbjezik1.Size = new System.Drawing.Size(157, 24);
            this.cmbjezik1.TabIndex = 5;
            // 
            // cmbJezik2
            // 
            this.cmbJezik2.FormattingEnabled = true;
            this.cmbJezik2.Location = new System.Drawing.Point(210, 151);
            this.cmbJezik2.Name = "cmbJezik2";
            this.cmbJezik2.Size = new System.Drawing.Size(157, 24);
            this.cmbJezik2.TabIndex = 6;
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(186, 194);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(75, 35);
            this.buttonOdustani.TabIndex = 7;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            // 
            // DodajRijecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 241);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.cmbJezik2);
            this.Controls.Add(this.cmbjezik1);
            this.Controls.Add(this.buttonUnesi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrijevod);
            this.Controls.Add(this.tbRijec);
            this.Name = "DodajRijecForm";
            this.Text = "Dodaj rijec";
            this.Load += new System.EventHandler(this.DodajRijecForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRijec;
        private System.Windows.Forms.TextBox tbPrijevod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUnesi;
        private System.Windows.Forms.ComboBox cmbjezik1;
        private System.Windows.Forms.ComboBox cmbJezik2;
        private System.Windows.Forms.Button buttonOdustani;
    }
}