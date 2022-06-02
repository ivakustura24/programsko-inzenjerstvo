namespace Sigurnosna_vrata
{
    partial class FormOtvaranjeVrata
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
            this.Button501 = new System.Windows.Forms.Button();
            this.Button502 = new System.Windows.Forms.Button();
            this.Button503 = new System.Windows.Forms.Button();
            this.tbBrojKartice = new System.Windows.Forms.TextBox();
            this.tbPIN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj kartice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "PIN";
            // 
            // Button501
            // 
            this.Button501.Location = new System.Drawing.Point(81, 192);
            this.Button501.Name = "Button501";
            this.Button501.Size = new System.Drawing.Size(94, 59);
            this.Button501.TabIndex = 2;
            this.Button501.Text = "Otvori Vrata br. 501";
            this.Button501.UseVisualStyleBackColor = true;
            this.Button501.Click += new System.EventHandler(this.Button501_Click);
            // 
            // Button502
            // 
            this.Button502.Location = new System.Drawing.Point(211, 192);
            this.Button502.Name = "Button502";
            this.Button502.Size = new System.Drawing.Size(93, 60);
            this.Button502.TabIndex = 3;
            this.Button502.Text = "Otvori Vrata br. 502";
            this.Button502.UseVisualStyleBackColor = true;
            this.Button502.Click += new System.EventHandler(this.Button502_Click);
            // 
            // Button503
            // 
            this.Button503.Location = new System.Drawing.Point(337, 192);
            this.Button503.Name = "Button503";
            this.Button503.Size = new System.Drawing.Size(93, 60);
            this.Button503.TabIndex = 4;
            this.Button503.Text = "Otvori Vrata br. 503";
            this.Button503.UseVisualStyleBackColor = true;
            this.Button503.Click += new System.EventHandler(this.Button503_Click);
            // 
            // tbBrojKartice
            // 
            this.tbBrojKartice.Location = new System.Drawing.Point(133, 57);
            this.tbBrojKartice.Name = "tbBrojKartice";
            this.tbBrojKartice.Size = new System.Drawing.Size(297, 22);
            this.tbBrojKartice.TabIndex = 5;
            // 
            // tbPIN
            // 
            this.tbPIN.Location = new System.Drawing.Point(133, 96);
            this.tbPIN.Name = "tbPIN";
            this.tbPIN.Size = new System.Drawing.Size(297, 22);
            this.tbPIN.TabIndex = 6;
            // 
            // FormOtvaranjeVrata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 296);
            this.Controls.Add(this.tbPIN);
            this.Controls.Add(this.tbBrojKartice);
            this.Controls.Add(this.Button503);
            this.Controls.Add(this.Button502);
            this.Controls.Add(this.Button501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormOtvaranjeVrata";
            this.Text = "Otvaranje vrata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button501;
        private System.Windows.Forms.Button Button502;
        private System.Windows.Forms.Button Button503;
        private System.Windows.Forms.TextBox tbBrojKartice;
        private System.Windows.Forms.TextBox tbPIN;
    }
}

