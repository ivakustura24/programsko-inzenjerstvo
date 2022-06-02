namespace _07_Filmovi
{
    partial class FilmoviForm
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
            this.dgwFilmovi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilmovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwFilmovi
            // 
            this.dgwFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilmovi.Location = new System.Drawing.Point(12, 12);
            this.dgwFilmovi.Name = "dgwFilmovi";
            this.dgwFilmovi.RowHeadersWidth = 51;
            this.dgwFilmovi.RowTemplate.Height = 24;
            this.dgwFilmovi.Size = new System.Drawing.Size(411, 249);
            this.dgwFilmovi.TabIndex = 0;
            // 
            // FilmoviForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 291);
            this.Controls.Add(this.dgwFilmovi);
            this.Name = "FilmoviForm";
            this.Text = "Filmovi";
            this.Load += new System.EventHandler(this.FilmoviForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilmovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwFilmovi;
    }
}

