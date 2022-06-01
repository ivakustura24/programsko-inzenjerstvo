namespace Provedba_i_sortiranje_transakcija
{
    partial class PopisTransakcijaForm
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
            this.PopisTransakcijaDGW = new System.Windows.Forms.DataGridView();
            this.ProvediButton = new System.Windows.Forms.Button();
            this.StornirajButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PopisTransakcijaDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // PopisTransakcijaDGW
            // 
            this.PopisTransakcijaDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PopisTransakcijaDGW.Location = new System.Drawing.Point(12, 35);
            this.PopisTransakcijaDGW.Name = "PopisTransakcijaDGW";
            this.PopisTransakcijaDGW.RowHeadersWidth = 51;
            this.PopisTransakcijaDGW.RowTemplate.Height = 24;
            this.PopisTransakcijaDGW.Size = new System.Drawing.Size(737, 320);
            this.PopisTransakcijaDGW.TabIndex = 0;
            // 
            // ProvediButton
            // 
            this.ProvediButton.Location = new System.Drawing.Point(639, 373);
            this.ProvediButton.Name = "ProvediButton";
            this.ProvediButton.Size = new System.Drawing.Size(110, 54);
            this.ProvediButton.TabIndex = 2;
            this.ProvediButton.Text = "Provedi transakciju";
            this.ProvediButton.UseVisualStyleBackColor = true;
            this.ProvediButton.Click += new System.EventHandler(this.ProvediButton_Click);
            // 
            // StornirajButton
            // 
            this.StornirajButton.Location = new System.Drawing.Point(508, 373);
            this.StornirajButton.Name = "StornirajButton";
            this.StornirajButton.Size = new System.Drawing.Size(110, 54);
            this.StornirajButton.TabIndex = 3;
            this.StornirajButton.Text = "Storniraj transakciju";
            this.StornirajButton.UseVisualStyleBackColor = true;
            this.StornirajButton.Click += new System.EventHandler(this.StornirajButton_Click);
            // 
            // PopisTransakcijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StornirajButton);
            this.Controls.Add(this.ProvediButton);
            this.Controls.Add(this.PopisTransakcijaDGW);
            this.Name = "PopisTransakcijaForm";
            this.Text = "Popis transakcija";
            this.Load += new System.EventHandler(this.PopisTransakcijaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PopisTransakcijaDGW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PopisTransakcijaDGW;
        private System.Windows.Forms.Button ProvediButton;
        private System.Windows.Forms.Button StornirajButton;
    }
}

