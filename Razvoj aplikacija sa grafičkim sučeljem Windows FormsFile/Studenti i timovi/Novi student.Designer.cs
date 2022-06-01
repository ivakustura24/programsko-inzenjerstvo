namespace Studenti_i_timovi
{
    partial class NoviStudentForm
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
            this.JMBAG = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.JMBAGtexbox = new System.Windows.Forms.TextBox();
            this.Imetextbox = new System.Windows.Forms.TextBox();
            this.prezimetextbox = new System.Windows.Forms.TextBox();
            this.ureduButton = new System.Windows.Forms.Button();
            this.odustanibutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JMBAG
            // 
            this.JMBAG.AutoSize = true;
            this.JMBAG.Location = new System.Drawing.Point(33, 40);
            this.JMBAG.Name = "JMBAG";
            this.JMBAG.Size = new System.Drawing.Size(53, 16);
            this.JMBAG.TabIndex = 0;
            this.JMBAG.Text = "JMBAG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime";
            // 
            // JMBAGtexbox
            // 
            this.JMBAGtexbox.Location = new System.Drawing.Point(139, 38);
            this.JMBAGtexbox.Name = "JMBAGtexbox";
            this.JMBAGtexbox.Size = new System.Drawing.Size(163, 22);
            this.JMBAGtexbox.TabIndex = 3;
            // 
            // Imetextbox
            // 
            this.Imetextbox.Location = new System.Drawing.Point(139, 79);
            this.Imetextbox.Name = "Imetextbox";
            this.Imetextbox.Size = new System.Drawing.Size(163, 22);
            this.Imetextbox.TabIndex = 4;
            // 
            // prezimetextbox
            // 
            this.prezimetextbox.Location = new System.Drawing.Point(139, 114);
            this.prezimetextbox.Name = "prezimetextbox";
            this.prezimetextbox.Size = new System.Drawing.Size(163, 22);
            this.prezimetextbox.TabIndex = 5;
            // 
            // ureduButton
            // 
            this.ureduButton.Location = new System.Drawing.Point(139, 179);
            this.ureduButton.Name = "ureduButton";
            this.ureduButton.Size = new System.Drawing.Size(87, 28);
            this.ureduButton.TabIndex = 6;
            this.ureduButton.Text = "U redu";
            this.ureduButton.UseVisualStyleBackColor = true;
            this.ureduButton.Click += new System.EventHandler(this.ureduButton_Click);
            // 
            // odustanibutton
            // 
            this.odustanibutton.Location = new System.Drawing.Point(232, 179);
            this.odustanibutton.Name = "odustanibutton";
            this.odustanibutton.Size = new System.Drawing.Size(87, 28);
            this.odustanibutton.TabIndex = 7;
            this.odustanibutton.Text = "Odustani";
            this.odustanibutton.UseVisualStyleBackColor = true;
            this.odustanibutton.Click += new System.EventHandler(this.odustanibutton_Click);
            // 
            // NoviStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 238);
            this.Controls.Add(this.odustanibutton);
            this.Controls.Add(this.ureduButton);
            this.Controls.Add(this.prezimetextbox);
            this.Controls.Add(this.Imetextbox);
            this.Controls.Add(this.JMBAGtexbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JMBAG);
            this.Name = "NoviStudentForm";
            this.Text = "Novi student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JMBAG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox JMBAGtexbox;
        private System.Windows.Forms.TextBox Imetextbox;
        private System.Windows.Forms.TextBox prezimetextbox;
        private System.Windows.Forms.Button ureduButton;
        private System.Windows.Forms.Button odustanibutton;
    }
}