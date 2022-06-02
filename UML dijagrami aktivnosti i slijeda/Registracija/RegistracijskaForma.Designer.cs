namespace _14_Registracija
{
    partial class RegistracijskaForma
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
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.buttonRegistriraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(161, 47);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(204, 22);
            this.tbIme.TabIndex = 2;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(161, 112);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(204, 22);
            this.tbPrezime.TabIndex = 3;
            // 
            // buttonRegistriraj
            // 
            this.buttonRegistriraj.Location = new System.Drawing.Point(264, 176);
            this.buttonRegistriraj.Name = "buttonRegistriraj";
            this.buttonRegistriraj.Size = new System.Drawing.Size(101, 33);
            this.buttonRegistriraj.TabIndex = 4;
            this.buttonRegistriraj.Text = "Registriraj";
            this.buttonRegistriraj.UseVisualStyleBackColor = true;
            this.buttonRegistriraj.Click += new System.EventHandler(this.buttonRegistriraj_Click);
            // 
            // RegistracijskaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 260);
            this.Controls.Add(this.buttonRegistriraj);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistracijskaForma";
            this.Text = "Registriraj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Button buttonRegistriraj;
    }
}

