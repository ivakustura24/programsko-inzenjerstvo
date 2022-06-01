namespace Provedba_ispita
{
    partial class ProvedbaIspitaForm
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
            this.OdgovorLB = new System.Windows.Forms.ListBox();
            this.SljedeceButton = new System.Windows.Forms.Button();
            this.PotvrdiButton = new System.Windows.Forms.Button();
            this.Pitanje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PotvrdenOdgovorTextBox = new System.Windows.Forms.TextBox();
            this.PitanjeTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OdgovorLB
            // 
            this.OdgovorLB.FormattingEnabled = true;
            this.OdgovorLB.ItemHeight = 16;
            this.OdgovorLB.Location = new System.Drawing.Point(175, 116);
            this.OdgovorLB.Name = "OdgovorLB";
            this.OdgovorLB.Size = new System.Drawing.Size(264, 100);
            this.OdgovorLB.TabIndex = 0;
            // 
            // SljedeceButton
            // 
            this.SljedeceButton.Location = new System.Drawing.Point(456, 120);
            this.SljedeceButton.Name = "SljedeceButton";
            this.SljedeceButton.Size = new System.Drawing.Size(144, 86);
            this.SljedeceButton.TabIndex = 2;
            this.SljedeceButton.Text = "Sljedeće pitanje >>";
            this.SljedeceButton.UseVisualStyleBackColor = true;
            this.SljedeceButton.Click += new System.EventHandler(this.SljedeceButton_Click);
            // 
            // PotvrdiButton
            // 
            this.PotvrdiButton.Location = new System.Drawing.Point(175, 247);
            this.PotvrdiButton.Name = "PotvrdiButton";
            this.PotvrdiButton.Size = new System.Drawing.Size(264, 36);
            this.PotvrdiButton.TabIndex = 3;
            this.PotvrdiButton.Text = "Potvrdi odgovor";
            this.PotvrdiButton.UseVisualStyleBackColor = true;
            this.PotvrdiButton.Click += new System.EventHandler(this.PotvrdiButton_Click);
            // 
            // Pitanje
            // 
            this.Pitanje.AutoSize = true;
            this.Pitanje.Location = new System.Drawing.Point(31, 60);
            this.Pitanje.Name = "Pitanje";
            this.Pitanje.Size = new System.Drawing.Size(48, 16);
            this.Pitanje.TabIndex = 4;
            this.Pitanje.Text = "Pitanje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Potvrđen odgovor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mogući odabir";
            // 
            // PotvrdenOdgovorTextBox
            // 
            this.PotvrdenOdgovorTextBox.Location = new System.Drawing.Point(175, 299);
            this.PotvrdenOdgovorTextBox.Name = "PotvrdenOdgovorTextBox";
            this.PotvrdenOdgovorTextBox.Size = new System.Drawing.Size(264, 22);
            this.PotvrdenOdgovorTextBox.TabIndex = 7;
            // 
            // PitanjeTB
            // 
            this.PitanjeTB.Location = new System.Drawing.Point(175, 60);
            this.PitanjeTB.Name = "PitanjeTB";
            this.PitanjeTB.Size = new System.Drawing.Size(425, 22);
            this.PitanjeTB.TabIndex = 8;
            // 
            // ProvedbaIspitaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 352);
            this.Controls.Add(this.PitanjeTB);
            this.Controls.Add(this.PotvrdenOdgovorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pitanje);
            this.Controls.Add(this.PotvrdiButton);
            this.Controls.Add(this.SljedeceButton);
            this.Controls.Add(this.OdgovorLB);
            this.Name = "ProvedbaIspitaForm";
            this.Text = "Provedba ispita";
            this.Load += new System.EventHandler(this.ProvedbaIspitaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OdgovorLB;
        private System.Windows.Forms.Button SljedeceButton;
        private System.Windows.Forms.Button PotvrdiButton;
        private System.Windows.Forms.Label Pitanje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PotvrdenOdgovorTextBox;
        private System.Windows.Forms.TextBox PitanjeTB;
    }
}

