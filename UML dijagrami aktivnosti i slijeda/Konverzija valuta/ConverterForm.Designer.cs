namespace _02_Konverzija_valuta
{
    partial class FrmConverter
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbConvertedAmount = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.cbSecondCurrency = new System.Windows.Forms.ComboBox();
            this.cbFirstCurrency = new System.Windows.Forms.ComboBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose first currency:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose second currency:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Converted amount:";
            // 
            // tbConvertedAmount
            // 
            this.tbConvertedAmount.Location = new System.Drawing.Point(41, 382);
            this.tbConvertedAmount.Name = "tbConvertedAmount";
            this.tbConvertedAmount.Size = new System.Drawing.Size(254, 22);
            this.tbConvertedAmount.TabIndex = 4;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(41, 256);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(254, 22);
            this.tbAmount.TabIndex = 5;
            // 
            // cbSecondCurrency
            // 
            this.cbSecondCurrency.FormattingEnabled = true;
            this.cbSecondCurrency.Location = new System.Drawing.Point(41, 171);
            this.cbSecondCurrency.Name = "cbSecondCurrency";
            this.cbSecondCurrency.Size = new System.Drawing.Size(254, 24);
            this.cbSecondCurrency.TabIndex = 6;
            // 
            // cbFirstCurrency
            // 
            this.cbFirstCurrency.FormattingEnabled = true;
            this.cbFirstCurrency.Location = new System.Drawing.Point(41, 89);
            this.cbFirstCurrency.Name = "cbFirstCurrency";
            this.cbFirstCurrency.Size = new System.Drawing.Size(254, 24);
            this.cbFirstCurrency.TabIndex = 7;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(41, 295);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(254, 23);
            this.buttonConvert.TabIndex = 8;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // FrmConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.cbFirstCurrency);
            this.Controls.Add(this.cbSecondCurrency);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbConvertedAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmConverter";
            this.Text = "Convert";
            this.Load += new System.EventHandler(this.FrmConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbConvertedAmount;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.ComboBox cbSecondCurrency;
        private System.Windows.Forms.ComboBox cbFirstCurrency;
        private System.Windows.Forms.Button buttonConvert;
    }
}