namespace _01_Stanovnici_Hrvatske
{
    partial class StanovniciFrm
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
            this.dgvStanovnici = new System.Windows.Forms.DataGridView();
            this.btnUnesi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanovnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStanovnici
            // 
            this.dgvStanovnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStanovnici.Location = new System.Drawing.Point(12, 37);
            this.dgvStanovnici.Name = "dgvStanovnici";
            this.dgvStanovnici.RowHeadersWidth = 51;
            this.dgvStanovnici.RowTemplate.Height = 24;
            this.dgvStanovnici.Size = new System.Drawing.Size(618, 313);
            this.dgvStanovnici.TabIndex = 0;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(524, 387);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(106, 39);
            this.btnUnesi.TabIndex = 1;
            this.btnUnesi.Text = "button1";
            this.btnUnesi.UseVisualStyleBackColor = true;
            // 
            // StanovniciFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.dgvStanovnici);
            this.Name = "StanovniciFrm";
            this.Text = "Stanovnici";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanovnici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStanovnici;
        private System.Windows.Forms.Button btnUnesi;
    }
}

