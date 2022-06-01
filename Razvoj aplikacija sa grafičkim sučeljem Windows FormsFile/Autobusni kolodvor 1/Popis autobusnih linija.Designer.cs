namespace Autobusni_kolodvor_1
{
    partial class Popis_autobusnih_linija
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
            this.LinijedataGridView = new System.Windows.Forms.DataGridView();
            this.OdaberiButton = new System.Windows.Forms.Button();
            this.IzlazButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LinijedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LinijedataGridView
            // 
            this.LinijedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LinijedataGridView.Location = new System.Drawing.Point(12, 73);
            this.LinijedataGridView.Name = "LinijedataGridView";
            this.LinijedataGridView.RowHeadersWidth = 51;
            this.LinijedataGridView.RowTemplate.Height = 24;
            this.LinijedataGridView.Size = new System.Drawing.Size(754, 241);
            this.LinijedataGridView.TabIndex = 1;
            this.LinijedataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // OdaberiButton
            // 
            this.OdaberiButton.Location = new System.Drawing.Point(516, 351);
            this.OdaberiButton.Name = "OdaberiButton";
            this.OdaberiButton.Size = new System.Drawing.Size(117, 27);
            this.OdaberiButton.TabIndex = 2;
            this.OdaberiButton.Text = "Odaberi";
            this.OdaberiButton.UseVisualStyleBackColor = true;
            this.OdaberiButton.Click += new System.EventHandler(this.OdaberiButton_Click);
            // 
            // IzlazButton
            // 
            this.IzlazButton.Location = new System.Drawing.Point(658, 351);
            this.IzlazButton.Name = "IzlazButton";
            this.IzlazButton.Size = new System.Drawing.Size(108, 27);
            this.IzlazButton.TabIndex = 3;
            this.IzlazButton.Text = "Izlaz";
            this.IzlazButton.UseVisualStyleBackColor = true;
            this.IzlazButton.Click += new System.EventHandler(this.IzlazButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Autobusne linije ";
            // 
            // Popis_autobusnih_linija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IzlazButton);
            this.Controls.Add(this.OdaberiButton);
            this.Controls.Add(this.LinijedataGridView);
            this.Name = "Popis_autobusnih_linija";
            this.Text = "Popis_autobusnih_linija";
            this.Load += new System.EventHandler(this.Popis_autobusnih_linija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LinijedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView LinijedataGridView;
        private System.Windows.Forms.Button OdaberiButton;
        private System.Windows.Forms.Button IzlazButton;
        private System.Windows.Forms.Label label1;
    }
}