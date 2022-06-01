namespace Provedba_ispita_2
{
    partial class IspitForm
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
            this.PrethodnoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SljedeceButton = new System.Windows.Forms.Button();
            this.PitanjeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AButton = new System.Windows.Forms.Button();
            this.BButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.DButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrethodnoButton
            // 
            this.PrethodnoButton.Location = new System.Drawing.Point(29, 25);
            this.PrethodnoButton.Name = "PrethodnoButton";
            this.PrethodnoButton.Size = new System.Drawing.Size(165, 64);
            this.PrethodnoButton.TabIndex = 0;
            this.PrethodnoButton.Text = "<< Prethodno ";
            this.PrethodnoButton.UseVisualStyleBackColor = true;
            this.PrethodnoButton.Click += new System.EventHandler(this.PrethodnoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "PITANJE";
            // 
            // SljedeceButton
            // 
            this.SljedeceButton.Location = new System.Drawing.Point(234, 25);
            this.SljedeceButton.Name = "SljedeceButton";
            this.SljedeceButton.Size = new System.Drawing.Size(165, 64);
            this.SljedeceButton.TabIndex = 2;
            this.SljedeceButton.Text = "Sljedeće >>";
            this.SljedeceButton.UseVisualStyleBackColor = true;
            this.SljedeceButton.Click += new System.EventHandler(this.SljedeceButton_Click);
            // 
            // PitanjeTextBox
            // 
            this.PitanjeTextBox.Location = new System.Drawing.Point(31, 160);
            this.PitanjeTextBox.Name = "PitanjeTextBox";
            this.PitanjeTextBox.Size = new System.Drawing.Size(367, 22);
            this.PitanjeTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ODGOVORI";
            // 
            // AButton
            // 
            this.AButton.Location = new System.Drawing.Point(32, 256);
            this.AButton.Name = "AButton";
            this.AButton.Size = new System.Drawing.Size(366, 44);
            this.AButton.TabIndex = 5;
            this.AButton.Text = "button1";
            this.AButton.UseVisualStyleBackColor = true;
            this.AButton.Click += new System.EventHandler(this.AButton_Click);
            // 
            // BButton
            // 
            this.BButton.Location = new System.Drawing.Point(33, 316);
            this.BButton.Name = "BButton";
            this.BButton.Size = new System.Drawing.Size(366, 44);
            this.BButton.TabIndex = 6;
            this.BButton.Text = "button2";
            this.BButton.UseVisualStyleBackColor = true;
            this.BButton.Click += new System.EventHandler(this.BButton_Click);
            // 
            // CButton
            // 
            this.CButton.Location = new System.Drawing.Point(33, 377);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(366, 44);
            this.CButton.TabIndex = 7;
            this.CButton.Text = "button3";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // DButton
            // 
            this.DButton.Location = new System.Drawing.Point(33, 437);
            this.DButton.Name = "DButton";
            this.DButton.Size = new System.Drawing.Size(366, 44);
            this.DButton.TabIndex = 8;
            this.DButton.Text = "button4";
            this.DButton.UseVisualStyleBackColor = true;
            this.DButton.Click += new System.EventHandler(this.DButton_Click);
            // 
            // IspitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 505);
            this.Controls.Add(this.DButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.BButton);
            this.Controls.Add(this.AButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PitanjeTextBox);
            this.Controls.Add(this.SljedeceButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrethodnoButton);
            this.Name = "IspitForm";
            this.Text = "Ispit";
            this.Load += new System.EventHandler(this.IspitForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrethodnoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SljedeceButton;
        private System.Windows.Forms.TextBox PitanjeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AButton;
        private System.Windows.Forms.Button BButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button DButton;
    }
}

