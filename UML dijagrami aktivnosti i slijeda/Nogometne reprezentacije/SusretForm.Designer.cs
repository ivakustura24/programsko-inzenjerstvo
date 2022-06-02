namespace _08_Nogometne_reprezentacije
{
    partial class SusretForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbDomacin = new System.Windows.Forms.TextBox();
            this.tbGost = new System.Windows.Forms.TextBox();
            this.tbRezultat = new System.Windows.Forms.TextBox();
            this.buttonEvidentiraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domaćin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rezultat";
            // 
            // tbDomacin
            // 
            this.tbDomacin.Location = new System.Drawing.Point(127, 34);
            this.tbDomacin.Name = "tbDomacin";
            this.tbDomacin.Size = new System.Drawing.Size(173, 22);
            this.tbDomacin.TabIndex = 3;
            // 
            // tbGost
            // 
            this.tbGost.Location = new System.Drawing.Point(127, 88);
            this.tbGost.Name = "tbGost";
            this.tbGost.Size = new System.Drawing.Size(173, 22);
            this.tbGost.TabIndex = 4;
            // 
            // tbRezultat
            // 
            this.tbRezultat.Location = new System.Drawing.Point(127, 148);
            this.tbRezultat.Name = "tbRezultat";
            this.tbRezultat.Size = new System.Drawing.Size(173, 22);
            this.tbRezultat.TabIndex = 5;
            // 
            // buttonEvidentiraj
            // 
            this.buttonEvidentiraj.Location = new System.Drawing.Point(214, 215);
            this.buttonEvidentiraj.Name = "buttonEvidentiraj";
            this.buttonEvidentiraj.Size = new System.Drawing.Size(86, 33);
            this.buttonEvidentiraj.TabIndex = 6;
            this.buttonEvidentiraj.Text = "Evidentiraj";
            this.buttonEvidentiraj.UseVisualStyleBackColor = true;
            this.buttonEvidentiraj.Click += new System.EventHandler(this.buttonEvidentiraj_Click);
            // 
            // SusretForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 272);
            this.Controls.Add(this.buttonEvidentiraj);
            this.Controls.Add(this.tbRezultat);
            this.Controls.Add(this.tbGost);
            this.Controls.Add(this.tbDomacin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SusretForm";
            this.Text = "Nogometni susret";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDomacin;
        private System.Windows.Forms.TextBox tbGost;
        private System.Windows.Forms.TextBox tbRezultat;
        private System.Windows.Forms.Button buttonEvidentiraj;
    }
}

