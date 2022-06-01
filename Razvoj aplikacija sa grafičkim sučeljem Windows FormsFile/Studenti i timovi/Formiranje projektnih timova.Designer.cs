namespace Studenti_i_timovi
{
    partial class FormiranjeForm
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
            this.NoviButton = new System.Windows.Forms.Button();
            this.DodajButton = new System.Windows.Forms.Button();
            this.ukloniButton = new System.Windows.Forms.Button();
            this.NedodijeljeniListBox = new System.Windows.Forms.ListBox();
            this.TimoviListBox = new System.Windows.Forms.ListBox();
            this.ClanoviListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nedodjeljeni student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Timovi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Članovi tima";
            // 
            // NoviButton
            // 
            this.NoviButton.Location = new System.Drawing.Point(38, 337);
            this.NoviButton.Name = "NoviButton";
            this.NoviButton.Size = new System.Drawing.Size(107, 47);
            this.NoviButton.TabIndex = 3;
            this.NoviButton.Text = "+ Novi student";
            this.NoviButton.UseVisualStyleBackColor = true;
            this.NoviButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DodajButton
            // 
            this.DodajButton.Location = new System.Drawing.Point(154, 337);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(102, 47);
            this.DodajButton.TabIndex = 4;
            this.DodajButton.Text = "Dodaj u tim >>";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ukloniButton
            // 
            this.ukloniButton.Location = new System.Drawing.Point(594, 337);
            this.ukloniButton.Name = "ukloniButton";
            this.ukloniButton.Size = new System.Drawing.Size(133, 45);
            this.ukloniButton.TabIndex = 5;
            this.ukloniButton.Text = "<< Ukloni iz tima";
            this.ukloniButton.UseVisualStyleBackColor = true;
            this.ukloniButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // NedodijeljeniListBox
            // 
            this.NedodijeljeniListBox.FormattingEnabled = true;
            this.NedodijeljeniListBox.ItemHeight = 16;
            this.NedodijeljeniListBox.Location = new System.Drawing.Point(36, 68);
            this.NedodijeljeniListBox.Name = "NedodijeljeniListBox";
            this.NedodijeljeniListBox.Size = new System.Drawing.Size(220, 260);
            this.NedodijeljeniListBox.TabIndex = 6;
            // 
            // TimoviListBox
            // 
            this.TimoviListBox.FormattingEnabled = true;
            this.TimoviListBox.ItemHeight = 16;
            this.TimoviListBox.Location = new System.Drawing.Point(281, 68);
            this.TimoviListBox.Name = "TimoviListBox";
            this.TimoviListBox.Size = new System.Drawing.Size(213, 260);
            this.TimoviListBox.TabIndex = 7;
            this.TimoviListBox.Click += new System.EventHandler(this.TimoviListBox_Click);
            // 
            // ClanoviListBox
            // 
            this.ClanoviListBox.FormattingEnabled = true;
            this.ClanoviListBox.ItemHeight = 16;
            this.ClanoviListBox.Location = new System.Drawing.Point(514, 68);
            this.ClanoviListBox.Name = "ClanoviListBox";
            this.ClanoviListBox.Size = new System.Drawing.Size(213, 260);
            this.ClanoviListBox.TabIndex = 8;
            // 
            // FormiranjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.ClanoviListBox);
            this.Controls.Add(this.TimoviListBox);
            this.Controls.Add(this.NedodijeljeniListBox);
            this.Controls.Add(this.ukloniButton);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.NoviButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormiranjeForm";
            this.Text = "Formiranje projektnih timova";
            this.Load += new System.EventHandler(this.FormiranjeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NoviButton;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.Button ukloniButton;
        private System.Windows.Forms.ListBox NedodijeljeniListBox;
        private System.Windows.Forms.ListBox TimoviListBox;
        private System.Windows.Forms.ListBox ClanoviListBox;
    }
}

