namespace _18_Tecajna_lista
{
    partial class ExchangeForm
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
            this.dgwExchangeRates = new System.Windows.Forms.DataGridView();
            this.btnShowRates = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwExchangeRates)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwExchangeRates
            // 
            this.dgwExchangeRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwExchangeRates.Location = new System.Drawing.Point(12, 30);
            this.dgwExchangeRates.Name = "dgwExchangeRates";
            this.dgwExchangeRates.RowHeadersWidth = 51;
            this.dgwExchangeRates.RowTemplate.Height = 24;
            this.dgwExchangeRates.Size = new System.Drawing.Size(361, 275);
            this.dgwExchangeRates.TabIndex = 0;
            // 
            // btnShowRates
            // 
            this.btnShowRates.Location = new System.Drawing.Point(267, 328);
            this.btnShowRates.Name = "btnShowRates";
            this.btnShowRates.Size = new System.Drawing.Size(106, 35);
            this.btnShowRates.TabIndex = 1;
            this.btnShowRates.Text = "Show Rates";
            this.btnShowRates.UseVisualStyleBackColor = true;
            this.btnShowRates.Click += new System.EventHandler(this.btnShowRates_Click);
            // 
            // ExchangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 397);
            this.Controls.Add(this.btnShowRates);
            this.Controls.Add(this.dgwExchangeRates);
            this.Name = "ExchangeForm";
            this.Text = "Exchange Forrm";
            ((System.ComponentModel.ISupportInitialize)(this.dgwExchangeRates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwExchangeRates;
        private System.Windows.Forms.Button btnShowRates;
    }
}

