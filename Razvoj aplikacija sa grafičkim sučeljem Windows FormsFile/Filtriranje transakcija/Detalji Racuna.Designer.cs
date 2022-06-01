namespace Filtirranje_transakcija
{
    partial class DetaljiRacunaForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.IBANTextBox = new System.Windows.Forms.TextBox();
            this.StanjeTextBox = new System.Windows.Forms.TextBox();
            this.VlasnikTextBox = new System.Windows.Forms.TextBox();
            this.UkupniPrometTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IBAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ukupni promet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stanje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vlasnik";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(139, 256);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // IBANTextBox
            // 
            this.IBANTextBox.Location = new System.Drawing.Point(181, 52);
            this.IBANTextBox.Name = "IBANTextBox";
            this.IBANTextBox.Size = new System.Drawing.Size(100, 22);
            this.IBANTextBox.TabIndex = 6;
            // 
            // StanjeTextBox
            // 
            this.StanjeTextBox.Location = new System.Drawing.Point(181, 145);
            this.StanjeTextBox.Name = "StanjeTextBox";
            this.StanjeTextBox.Size = new System.Drawing.Size(100, 22);
            this.StanjeTextBox.TabIndex = 7;
            // 
            // VlasnikTextBox
            // 
            this.VlasnikTextBox.Location = new System.Drawing.Point(181, 88);
            this.VlasnikTextBox.Name = "VlasnikTextBox";
            this.VlasnikTextBox.Size = new System.Drawing.Size(100, 22);
            this.VlasnikTextBox.TabIndex = 8;
            // 
            // UkupniPrometTextBox
            // 
            this.UkupniPrometTextBox.Location = new System.Drawing.Point(181, 185);
            this.UkupniPrometTextBox.Name = "UkupniPrometTextBox";
            this.UkupniPrometTextBox.Size = new System.Drawing.Size(100, 22);
            this.UkupniPrometTextBox.TabIndex = 9;
            // 
            // DetaljiRacunaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 323);
            this.Controls.Add(this.UkupniPrometTextBox);
            this.Controls.Add(this.VlasnikTextBox);
            this.Controls.Add(this.StanjeTextBox);
            this.Controls.Add(this.IBANTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "DetaljiRacunaForm";
            this.Text = "Detalji računa";
            this.Load += new System.EventHandler(this.DetaljiRacunaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox IBANTextBox;
        private System.Windows.Forms.TextBox StanjeTextBox;
        private System.Windows.Forms.TextBox VlasnikTextBox;
        private System.Windows.Forms.TextBox UkupniPrometTextBox;
    }
}