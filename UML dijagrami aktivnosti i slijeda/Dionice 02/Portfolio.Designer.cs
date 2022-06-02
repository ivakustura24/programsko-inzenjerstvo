namespace _05_Dionice_02
{
    partial class PortfolioForm
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
            this.dgwStocks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.buttonShowPortfolio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwStocks
            // 
            this.dgwStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStocks.Location = new System.Drawing.Point(24, 29);
            this.dgwStocks.Name = "dgwStocks";
            this.dgwStocks.RowHeadersWidth = 51;
            this.dgwStocks.RowTemplate.Height = 24;
            this.dgwStocks.Size = new System.Drawing.Size(610, 255);
            this.dgwStocks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(474, 311);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(160, 22);
            this.tbTotal.TabIndex = 2;
            // 
            // buttonShowPortfolio
            // 
            this.buttonShowPortfolio.Location = new System.Drawing.Point(511, 360);
            this.buttonShowPortfolio.Name = "buttonShowPortfolio";
            this.buttonShowPortfolio.Size = new System.Drawing.Size(123, 28);
            this.buttonShowPortfolio.TabIndex = 3;
            this.buttonShowPortfolio.Text = "Show portfolio";
            this.buttonShowPortfolio.UseVisualStyleBackColor = true;
            this.buttonShowPortfolio.Click += new System.EventHandler(this.buttonShowPortfolio_Click);
            // 
            // PortfolioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.buttonShowPortfolio);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwStocks);
            this.Name = "PortfolioForm";
            this.Text = "Stocks Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgwStocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwStocks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button buttonShowPortfolio;
    }
}

